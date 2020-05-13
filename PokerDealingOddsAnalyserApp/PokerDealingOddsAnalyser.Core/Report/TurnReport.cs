using System.Collections.Generic;
using System.Linq;
using PokerDealingOddsAnalyser.Core.Round;
using PokerDealingOddsAnalyser.Core.Deck;

namespace PokerDealingOddsAnalyser.Core.Report
{
    public class TurnReport : Report
    {
        private List<Card[]> AllTurns { get; set; }
        public TurnReport() : base()
        {
            this.AllTurns = new List<Card[]>();            
        }
        public override void GetData(List<Dictionary<string, Card[]>> boards, Hand yourHand)
        {
            List<Card> currentPlayingHand = new List<Card>(6);

            for (int i = 0; i < boards.Count; i++)
            {
                Card[] turnBoard = new Card[4]
                {
                    boards[i]["Flop"][0],
                    boards[i]["Flop"][1],
                    boards[i]["Flop"][2],
                    boards[i]["Turn"][0]
                };

                this.AllTurns.Add(turnBoard);              
            }

            foreach (var turn in AllTurns)
            {
                currentPlayingHand.AddRange(turn);
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

            for (int cardIndex = 0; cardIndex < 5; cardIndex++)
            {
                for (int otherCardIndex = cardIndex + 1; otherCardIndex < 6; otherCardIndex++)
                {
                    if (currentHand[cardIndex].Rank == currentHand[otherCardIndex].Rank) //Pair
                    {
                        if ((otherCardIndex + 1) < 6 && currentHand[cardIndex].Rank == currentHand[otherCardIndex + 1].Rank) //Set
                        {
                            if ((otherCardIndex + 2) < 6 && currentHand[cardIndex].Rank == currentHand[otherCardIndex + 2].Rank) //Quads
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
            else if (set == 1)
            {
                this.Set += 1;
            }
            else if (pairs >= 2)
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
        private void CheckFlushesAndStraights(List<Card> currentHand)
        {
            int[] cardsSequence = new int[6]
            {
                currentHand[0].Rank,
                currentHand[1].Rank,
                currentHand[2].Rank,
                currentHand[3].Rank,
                currentHand[4].Rank,
                currentHand[5].Rank
            }.Distinct().ToArray();
            List<Suit> suits = currentHand.Select(x => x.Suit).ToList();

            if (cardsSequence.Length >= 5)
            {
                if (CheckRoyalFlush(currentHand))
                {
                    this.RoyalFlush += 1;
                }
                else
                {
                    if (CheckStraightFlush(currentHand))
                    {
                        this.StraightFlush += 1;
                    }
                    else
                    {
                        if (CheckFlush(suits))
                        {
                            this.Flush += 1;
                        }
                        else if (CheckStraight(cardsSequence))
                        {
                            this.Straight += 1;
                        }
                    }
                }
            }
        }
        public override void Reset()
        {
            base.Reset();
            this.AllTurns.Clear();            
        }
        private bool CheckStraight(int[] cardsSequence)
        {
            cardsSequence = cardsSequence.OrderBy(x => x).Distinct().ToArray();

            int[] first5Cards = new int[5];
            int[] second5Cards = new int[5];
            int[] third5Cards = new int[5];

            if (cardsSequence.Length == 6)
            {
                first5Cards = cardsSequence.Take(5).ToArray();
                second5Cards = cardsSequence.Skip(1).Take(5).ToArray();

                return first5Cards.SequenceEqual(Enumerable.Range(cardsSequence[0], 5)) || second5Cards.SequenceEqual(Enumerable.Range(cardsSequence[1], 5)) || IsBottomStraight(first5Cards);
            }
            else
            {
                first5Cards = cardsSequence;
                return first5Cards.SequenceEqual(Enumerable.Range(cardsSequence[0], 5)) || IsBottomStraight(first5Cards);
            }
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
        private bool CheckFlush(List<Suit> suits)
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
        private bool CheckStraightFlush(List<Card> yourHand)
        {
            yourHand = yourHand.GroupBy(x => x.Suit).Where(g => g.Count() >= 5).SelectMany(x => x).ToList();
            int[] cardsSequence = yourHand.Select(x => x.Rank).ToArray();

            if (yourHand.Count != 0)
            {
                if (CheckStraight(cardsSequence)) return true;
            }
            return false;
        }
        private bool CheckRoyalFlush(List<Card> yourHand)
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
