using System.Collections.Generic;
using System.Linq;
using PokerDealingOddsAnalyser.Core.Deck;
using PokerDealingOddsAnalyser.Core.Round;

namespace PokerDealingOddsAnalyser.Core.Report
{
    public class RiverReport : Report
    {
        private List<Card[]> AllRivers { get; set; }
        public RiverReport() : base()
        {           
            this.AllRivers = new List<Card[]>();
        }
        public override void GetData(List<Dictionary<string, Card[]>> boards, Hand yourHand)
        {
            List<Card> currentPlayingHand = new List<Card>(7);

            for (int i = 0; i < boards.Count; i++)
            {
                Card[] riverBoard = new Card[5]
                {
                    boards[i]["Flop"][0],
                    boards[i]["Flop"][1],
                    boards[i]["Flop"][2],
                    boards[i]["Turn"][0],
                    boards[i]["River"][0]
                };

                this.AllRivers.Add(riverBoard);
            }

            foreach (var river in AllRivers)
            {
                currentPlayingHand.AddRange(river);
                currentPlayingHand.AddRange(yourHand.PlayingHand);
                currentPlayingHand = currentPlayingHand.OrderBy(x => x.Rank).ToList();

                this.CheckPairs(currentPlayingHand);
                this.CheckFlushesAndStraights(currentPlayingHand);

                currentPlayingHand.Clear();
            }
        }
        protected void CheckPairs(List<Card> currentHand)
        {
            base.Reset();
            int pairs = 0;
            int set = 0;

            for (int cardIndex = 0; cardIndex < 6; cardIndex++)
            {
                for (int otherCardIndex = cardIndex + 1; otherCardIndex < 7; otherCardIndex++)
                {
                    if (currentHand[cardIndex].Rank == currentHand[otherCardIndex].Rank) //Pair
                    {
                        if ((otherCardIndex + 1) < 7 && currentHand[cardIndex].Rank == currentHand[otherCardIndex + 1].Rank) //Set
                        {
                            if ((otherCardIndex + 2) < 7 && currentHand[cardIndex].Rank == currentHand[otherCardIndex + 2].Rank) //Quads
                            {
                                this.Quads += 1;
                                this.isQuads = true;
                                this.highCardRank = currentHand[cardIndex].Rank;
                                otherCardIndex += 2;
                            }
                            else
                            {
                                this.highCardRank = currentHand[cardIndex].Rank;
                                set += 1;
                                otherCardIndex += 1;
                            }
                        }
                        else
                        {
                            if (this.highCardRank < currentHand[cardIndex].Rank) this.highCardRank = currentHand[cardIndex].Rank;
                            pairs += 1;
                        }
                    }
                    else continue;
                }
            }

            if (set == 1 && pairs == 2)
            {
                this.FullHouse += 1;
                this.isFullhouse = true;
                highCardRank = currentHand.GroupBy(item => item).OrderByDescending(g => g.Count()).Select(g => g.Key).First().Rank;
            }
            else if (set == 1)
            {
                this.Set += 1;
                this.isSet = true;
            }
            else if (pairs >= 2)
            {
                this.TwoPairs += 1;
                this.isTwoPairs = true;
            }
            else if (pairs == 1)
            {
                this.Pair += 1;
                this.isOnePair = true;
            }
            else
            {
                this.HighCard += 1;
                this.highCardRank = currentHand.Max(x => x.Rank);
            }
        }
        protected void CheckFlushesAndStraights(List<Card> currentHand)
        {
            int[] cardsSequence = new int[7]
            {
                currentHand[0].Rank,
                currentHand[1].Rank,
                currentHand[2].Rank,
                currentHand[3].Rank,
                currentHand[4].Rank,
                currentHand[5].Rank,
                currentHand[6].Rank
            }.Distinct().ToArray();                     

            if (cardsSequence.Length >= 5)
            {
                if (IsRoyalFlush(currentHand))
                {
                    this.isRoyalFlush = true;
                    this.RoyalFlush += 1;
                }
                else
                {
                    if (IsStraightFlush(currentHand))
                    {
                        this.isStraightFlush = true;
                        this.StraightFlush += 1;
                    }
                    else
                    {
                        if (IsFlush(currentHand))
                        {
                            this.isFlush = true;
                            this.Flush += 1;
                        }
                        else if (IsStraight(cardsSequence))
                        {
                            this.isStraight = true;
                            this.Straight += 1;
                        }
                    }
                }
            }                      
        }
        private bool IsStraight(int[] cardsSequence)
        {
            cardsSequence = cardsSequence.OrderBy(x => x).Distinct().ToArray();

            int[] first5Cards = new int[5];
            int[] second5Cards = new int[5];
            int[] third5Cards = new int[5];

            if (cardsSequence.Length >= 5) first5Cards = cardsSequence.Take(5).ToArray();
            if (cardsSequence.Length >= 6) second5Cards = cardsSequence.Skip(1).Take(5).ToArray();
            if (cardsSequence.Length >= 7) third5Cards = cardsSequence.Skip(2).ToArray();

            if (first5Cards.SequenceEqual(Enumerable.Range(cardsSequence[0], 5)))
            {
                this.highCardRank = first5Cards[4];
                return true;
            }
            if (second5Cards.SequenceEqual(Enumerable.Range(cardsSequence[1], 5)))
            {
                this.highCardRank = second5Cards[4];
                return true;
            }
            if (third5Cards.SequenceEqual(Enumerable.Range(cardsSequence[2], 5)))
            {
                this.highCardRank = third5Cards[4];
                return true;
            }
            if (IsBottomStraight(cardsSequence))
            {
                this.highCardRank = 5; //A-2-3-4-5
                return true;
            }
            return false;

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
        private bool IsFlush(List<Card> hand)
        {
            foreach (Card suit in hand)
            {
                if (hand.Count(x => x.Suit.Equals(suit.Suit)) >= 5)
                {
                    this.highCardRank = hand.Where(x => x.Suit.Equals(suit.Suit)).OrderByDescending(x => x.Rank).First().Rank;
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
