using PokerDealingOddsAnalyser.Core.Round;
using PokerDealingOddsAnalyser.Core.Deck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace PokerDealingOddsAnalyser.Core.Report
{
    public class WinningReport : RiverReport
    {
        private readonly Comparison<Hand> _comparison = (first, second) =>
        {            
            int result = first.StrengthData.Strength.CompareTo(second.StrengthData.Strength);
            if (result == 0) //Equal Strength
            {
                int firstHandHighCard = first.StrengthData.HighCardRank;
                int secondHandHighCard = second.StrengthData.HighCardRank;
                switch (first.StrengthData.Strength)
                {
                    case HandStrengths.HighCard: result = firstHandHighCard.CompareTo(secondHandHighCard); break;
                    case HandStrengths.OnePair:
                        {
                            result = firstHandHighCard.CompareTo(secondHandHighCard);
                            if (result == 0) //Equal pairs
                            {                                
                                var firstHand = first.PlayingHand.OrderByDescending(x => x.Rank).Distinct().Take(5).ToList();
                                var secondHand = second.PlayingHand.OrderByDescending(x => x.Rank).Distinct().Take(5).ToList();
                                for (int i = 0; i < firstHand.Count; i++)
                                {
                                    result = firstHand[i].Rank.CompareTo(secondHand[i].Rank);
                                    if (result != 0) break;
                                }
                            }
                        }
                        break;
                    case HandStrengths.TwoPairs:
                        {
                            result = firstHandHighCard.CompareTo(secondHandHighCard);
                            if (result == 0)
                            {
                                var firstHand = first.PlayingHand.GroupBy(x => x.Rank).ToList();
                                var secondHand = second.PlayingHand.GroupBy(x => x.Rank).ToList();
                            }
                        }
                        break;
                    case HandStrengths.Set: goto case HandStrengths.OnePair;
                    case HandStrengths.Straight: goto case HandStrengths.HighCard;
                    case HandStrengths.Flush: goto case HandStrengths.HighCard;
                    case HandStrengths.FullHouse: goto case HandStrengths.OnePair;
                    case HandStrengths.Quads: goto case HandStrengths.OnePair;
                    case HandStrengths.StraightFlush: goto case HandStrengths.HighCard;
                    case HandStrengths.RoyalFlush: result = 0; break;
                }
            }
            return result;
        };
        public readonly List<Hand> allHands = new List<Hand>();
        public uint Draws { get; private set; }
        public void GetData(List<Dictionary<string, Card[]>> boards, Hand yourHand, List<Hand> oppHands)
        {
            Draws = 0;
            foreach (var board in boards)
            {
                //Mocking needed in order not to mix hole cards with community cards
                List<Hand> mockOppHands = DeepClone(oppHands);
                Hand mockYourHand = DeepClone(yourHand);
                foreach (var street in board)
                {
                    mockYourHand.PlayingHand.AddRange(street.Value);
                    foreach (var oppHand in mockOppHands)
                    {
                        oppHand.PlayingHand.AddRange(street.Value);
                    }
                }

                DetermineHandStrength(mockYourHand);
                Hand bestOppHand = GetBestOpponentHand(mockOppHands);

                int resultComparison = _comparison(mockYourHand, bestOppHand);
                if (resultComparison == 0) this.Draws++;
                else if (resultComparison > 0) yourHand.WinGame();
                else oppHands[mockOppHands.IndexOf(bestOppHand)].WinGame();
            }

            allHands.Add(yourHand);
            allHands.AddRange(oppHands);
        }
        private void DetermineHandStrength(Hand hand)
        {
            this.CheckPairs(hand.PlayingHand);
            this.CheckFlushesAndStraights(hand.PlayingHand);
            if (this.isOnePair) hand.StrengthData.Strength = HandStrengths.OnePair;
            if (this.isTwoPairs) hand.StrengthData.Strength = HandStrengths.TwoPairs;
            if (this.isSet) hand.StrengthData.Strength = HandStrengths.Set;
            if (this.isStraight) hand.StrengthData.Strength = HandStrengths.Straight;
            if (this.isFlush) hand.StrengthData.Strength = HandStrengths.Flush;
            if (this.isFullhouse) hand.StrengthData.Strength = HandStrengths.FullHouse;
            if (this.isQuads) hand.StrengthData.Strength = HandStrengths.Quads;
            if (this.isStraightFlush) hand.StrengthData.Strength = HandStrengths.StraightFlush;
            if (this.isRoyalFlush) hand.StrengthData.Strength = HandStrengths.RoyalFlush;
            hand.StrengthData.HighCardRank = this.highCardRank;            
        }
        private Hand GetBestOpponentHand(List<Hand> mockOppHands)
        {
            Hand bestOppHand = mockOppHands[0];
            DetermineHandStrength(bestOppHand);

            for (int i = 1; i < mockOppHands.Count; i++)
            {
                DetermineHandStrength(mockOppHands[i]);
                int result = _comparison(bestOppHand, mockOppHands[i]);
                if (result < 0) bestOppHand = mockOppHands[i];
            }

            return bestOppHand;
        }
        private T DeepClone<T>(T item)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter
                {
                    Context = new StreamingContext(StreamingContextStates.Clone)
                };
                formatter.Serialize(ms, item);
                ms.Position = 0;
                return (T)formatter.Deserialize(ms);
            }
        }
        public override void Reset()
        {
            base.Reset();
            allHands.Clear();
        }
    }
}