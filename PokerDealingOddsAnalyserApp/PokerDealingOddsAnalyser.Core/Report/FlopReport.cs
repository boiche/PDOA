using System.Collections.Generic;
using System.Linq;
using PokerDealingOddsAnalyser.Core.Deck;
using PokerDealingOddsAnalyser.Core.Round;

namespace PokerDealingOddsAnalyser.Core.Report
{
    public class FlopReport : Report
    {
        private List<Card[]> AllFlops { get; set; }
        public FlopReport() : base()
        {
            this.AllFlops = new List<Card[]>();
        }
        public override void GetData(List<Dictionary<string, Card[]>> boards, Hand yourHand)
        {
            List<Card> currentPlayingHand = new List<Card>(5);

            for (int i = 0; i < boards.Count; i++)
            {               
                this.AllFlops.Add(boards[i]["Flop"]);
            }

            foreach (var flop in AllFlops)
            {
                currentPlayingHand.AddRange(flop);
                currentPlayingHand.AddRange(yourHand.PlayingHand);
                currentPlayingHand = currentPlayingHand.OrderBy(x => x.Rank).ToList();

                this.CheckPairs(currentPlayingHand);
                this.CheckFlushesAndStraights(currentPlayingHand);

                currentPlayingHand.Clear();
            }
        }
        private void CheckPairs(List<Card> currentHand)
        {
            int pairs = 0;
            int set = 0;

            for (int cardIndex = 0; cardIndex < 4; cardIndex++)
            {
                for (int otherCardIndex = cardIndex + 1; otherCardIndex < 5; otherCardIndex++)
                {
                    if (currentHand[cardIndex].Rank == currentHand[otherCardIndex].Rank) //Pair
                    {
                        if ((otherCardIndex + 1) <= 4 && currentHand[cardIndex].Rank == currentHand[otherCardIndex + 1].Rank) //Set
                        {
                            if ((otherCardIndex + 2) <= 4 && currentHand[cardIndex].Rank == currentHand[otherCardIndex + 2].Rank) //Quads
                            {
                                this.Quads += 1;
                                otherCardIndex += 2;
                            }
                            else
                            {
                                set += 1;
                                otherCardIndex += 1;
                            }
                        }
                        else
                        {
                            pairs += 1;
                        }
                    }
                    else continue;                   
                }                
            }


            if (set == 1 && pairs == 2)
            {
                this.FullHouse += 1;
            }
            else if (CheckFlushesAndStraights(currentHand) == false)
            {
                if (set == 1)
                {
                    this.Set += 1;
                }
                else if (pairs == 2)
                {
                    this.TwoPairs += 1;
                }
                else if (pairs == 1)
                {
                    this.Pair += 1;
                }
                else
                {
                    this.HighCard += 1;
                }
            }
        }
        private bool CheckFlushesAndStraights(List<Card> currentHand)
        {
            int[] cardsSequence = new int[5]
            {
                currentHand[0].Rank,
                currentHand[1].Rank,
                currentHand[2].Rank,
                currentHand[3].Rank,
                currentHand[4].Rank
            }.Distinct().ToArray();

            List<Suit> suits = currentHand.Select(x => x.Suit).ToList();

            if (cardsSequence.Length >= 5)
            {
                if (IsRoyalFlush(currentHand))
                {
                    this.RoyalFlush += 1;
                    return true;
                }
                else
                {
                    if (IsStraightFlush(currentHand))
                    {
                        this.StraightFlush += 1;
                        return true;
                    }
                    else
                    {
                        if (IsFlush(suits))
                        {
                            this.Flush += 1;
                            return true;
                        }
                        else if (IsStraight(cardsSequence))
                        {
                            this.Straight += 1;
                            return true;
                        }
                    }
                }
            }

            return false;
        }
        public override void Reset()
        {
            base.Reset();
            this.AllFlops.Clear();            
        }
        private bool IsStraight(int[] cardsSequence)
        {
            cardsSequence = cardsSequence.OrderBy(x => x).Distinct().ToArray();

            int[] first5Cards = new int[5];

            first5Cards = cardsSequence;
            return first5Cards.SequenceEqual(Enumerable.Range(cardsSequence[0], 5)) || IsBottomStraight(first5Cards);            
        }
        private bool IsBottomStraight(int[] cardsSequence)
        {
            cardsSequence = cardsSequence.OrderBy(x => x).Distinct().ToArray();

            if (cardsSequence.Take(4).SequenceEqual(new int[4] { 2, 3, 4, 5 }) && cardsSequence.Last() == 14)
            {
                return true;
            }
            else return false;
        }
        private bool IsFlush(List<Suit> suits)
        {
            foreach (Suit suit in suits)
            {
                if (suits.Count(x => x.Equals(suit)) >= 5)
                {
                    return true;
                }
            }

            return false;
        }
        private bool IsStraightFlush(List<Card> yourHand)
        {
            yourHand = yourHand.GroupBy(x => x.Suit).Where(g => g.Count() >= 5).SelectMany(x => x).ToList();
            int[] cardsSequence = yourHand.Select(x => x.Rank).ToArray();

            if (yourHand.Count != 0)
            {
                if (IsStraight(cardsSequence)) return true;
            }
            return false;
        }
        private bool IsRoyalFlush(List<Card> yourHand)
        {
            yourHand = yourHand.GroupBy(x => x.Suit).Where(g => g.Count() >= 5).SelectMany(x => x).ToList();
            int[] cardsSequence = yourHand.OrderBy(x => x.Rank).Select(x => x.Rank).Reverse().Take(5).ToArray();

            if (yourHand.Count != 0)
            {
                if (cardsSequence.SequenceEqual(Enumerable.Range(10, 5)))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
