using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerDealingOddsAnalyser.Core.Deck;
using System.Collections.Generic;
using System.Linq;

namespace PokerDealingOddsAnalyser.Test.River
{
    [TestClass]
    public class StraightsAndFlushes
    {
        [TestMethod]
        public void Check_Straight_ExpectTrue()
        {
            int[] firstSequence = new int[] { 9, 6, 8, 10, 7, 2, 8 };
            int[] secondSequence = new int[] { 4, 14, 2, 3, 5, 14, 10 };

            Assert.IsTrue(CheckStraight(firstSequence));
            Assert.IsTrue(IsBottomStraight(secondSequence));
        }
        [TestMethod]
        public void Check_Straight_ExpectFalse()
        {
            int[] firstSequence = new int[] { 9, 6, 2, 14, 8, 10, 11 };
            int[] secondSequence = new int[] { 4, 14, 2, 5, 5, 7, 8 };
            Assert.IsFalse(CheckStraight(firstSequence));
            Assert.IsFalse(IsBottomStraight(secondSequence));
        }
        [TestMethod]
        public void Check_Flush_ExpectTrue()
        {
            List<Suit> firstBoard = new List<Suit>()
            {
                Suit.Clubs,
                Suit.Clubs,
                Suit.Clubs,
                Suit.Clubs,
                Suit.Clubs,
                Suit.Clubs,
                Suit.Diamonds
            }; //6 Equal
            List<Suit> secondBoard = new List<Suit>()
            {
                Suit.Diamonds,
                Suit.Spades,
                Suit.Hearts,
                Suit.Hearts,
                Suit.Hearts,
                Suit.Hearts,
                Suit.Hearts
            }; //5 Equal
            List<Suit> thirdBoard = new List<Suit>()
            {
                Suit.Hearts,
                Suit.Hearts,
                Suit.Hearts,
                Suit.Spades,
                Suit.Hearts,
                Suit.Diamonds,
                Suit.Hearts
            }; //Mixed

            Assert.IsTrue(CheckFlush(firstBoard));
            Assert.IsTrue(CheckFlush(secondBoard));
            Assert.IsTrue(CheckFlush(thirdBoard));
        }
        [TestMethod]
        public void Check_Flush_ExpectFalse()
        {
            List<Suit> firstBoard = new List<Suit>()
            {
                Suit.Clubs,
                Suit.Clubs,
                Suit.Clubs,
                Suit.Clubs,
                Suit.Diamonds,
                Suit.Diamonds,
                Suit.Diamonds
            };
            List<Suit> secondBoard = new List<Suit>()
            {
                Suit.Diamonds,
                Suit.Clubs,
                Suit.Spades,
                Suit.Hearts,
                Suit.Diamonds,
                Suit.Hearts,
                Suit.Clubs
            };

            Assert.IsFalse(CheckFlush(firstBoard));
            Assert.IsFalse(CheckFlush(secondBoard));
        }
        [TestMethod]
        public void Check_StraightFlush_ExpectTrue()
        {
            List<Card> firstHand = new List<Card>()
            {
                new Card(6, Suit.Clubs),
                new Card(7, Suit.Clubs),
                new Card(8, Suit.Clubs),
                new Card(9, Suit.Clubs),
                new Card(10, Suit.Clubs),
                new Card(2, Suit.Diamonds),
                new Card(14, Suit.Hearts)
            }.OrderBy(x => x.Rank).ToList();
            List<Card> secondHand = new List<Card>()
            {
                new Card(5, Suit.Clubs),
                new Card(13, Suit.Clubs),
                new Card(11, Suit.Clubs),
                new Card(9, Suit.Clubs),
                new Card(5, Suit.Spades),
                new Card(10, Suit.Clubs),
                new Card(12, Suit.Clubs)
            }.OrderBy(x => x.Rank).ToList();
            List<Card> thirdHand = new List<Card>()
            {
                new Card(5, Suit.Hearts),
                new Card(7, Suit.Clubs),
                new Card(4, Suit.Hearts),
                new Card(3, Suit.Hearts),
                new Card(10, Suit.Clubs),
                new Card(2, Suit.Hearts),
                new Card(14, Suit.Hearts)
            }.OrderBy(x => x.Rank).ToList();

            Assert.IsTrue(CheckStraightFlush(firstHand));
            Assert.IsTrue(CheckStraightFlush(secondHand));
            Assert.IsTrue(CheckStraightFlush(thirdHand));//A, 2, 3, 4, 5
        }
        [TestMethod]
        public void Check_StraightFlush_ExpectFalse()
        {
            List<Card> firstHand = new List<Card>()
            {
                new Card(6, Suit.Clubs),
                new Card(7, Suit.Clubs),
                new Card(8, Suit.Spades),
                new Card(9, Suit.Clubs),
                new Card(10, Suit.Clubs),
                new Card(2, Suit.Diamonds),
                new Card(14, Suit.Hearts)
            }.OrderBy(x => x.Rank).ToList();
            List<Card> secondHand = new List<Card>()
            {
                new Card(5, Suit.Clubs),
                new Card(13, Suit.Diamonds),
                new Card(11, Suit.Clubs),
                new Card(9, Suit.Clubs),
                new Card(5, Suit.Spades),
                new Card(10, Suit.Clubs),
                new Card(12, Suit.Clubs)
            }.OrderBy(x => x.Rank).ToList();
            List<Card> thirdHand = new List<Card>()
            {
                new Card(5, Suit.Hearts),
                new Card(7, Suit.Clubs),
                new Card(4, Suit.Diamonds),
                new Card(3, Suit.Hearts),
                new Card(10, Suit.Clubs),
                new Card(2, Suit.Hearts),
                new Card(14, Suit.Hearts)
            }.OrderBy(x => x.Rank).ToList();

            Assert.IsFalse(CheckStraightFlush(firstHand));
            Assert.IsFalse(CheckStraightFlush(secondHand));
            Assert.IsFalse(CheckStraightFlush(thirdHand));
        }
        [TestMethod]
        public void Check_RoyalFlush_ExpectTrue()
        {
            List<Card> firstHand = new List<Card>()
            {
                new Card(10, Suit.Clubs),
                new Card(11, Suit.Clubs),
                new Card(12, Suit.Clubs),
                new Card(13, Suit.Clubs),
                new Card(14, Suit.Clubs),
                new Card(14, Suit.Diamonds),
                new Card(14, Suit.Hearts)
            };
            List<Card> secondHand = new List<Card>()
            {
                new Card(14, Suit.Spades),
                new Card(5, Suit.Diamonds),
                new Card(9, Suit.Spades),
                new Card(13, Suit.Spades),
                new Card(10, Suit.Spades),
                new Card(12, Suit.Spades),
                new Card(11, Suit.Spades)
            };

            Assert.IsTrue(CheckRoyalFlush(firstHand));
            Assert.IsTrue(CheckRoyalFlush(secondHand));
        }
        [TestMethod]
        public void Check_RoyalFlush_ExpectFalse()
        {
            {
                List<Card> firstHand = new List<Card>()
                {
                    new Card(9, Suit.Clubs),
                    new Card(11, Suit.Clubs),
                    new Card(12, Suit.Clubs),
                    new Card(13, Suit.Clubs),
                    new Card(14, Suit.Clubs),
                    new Card(14, Suit.Diamonds),
                    new Card(14, Suit.Hearts)
                };
                List<Card> secondHand = new List<Card>()
                {
                    new Card(14, Suit.Spades),
                    new Card(5, Suit.Diamonds),
                    new Card(9, Suit.Spades),
                    new Card(13, Suit.Spades),
                    new Card(10, Suit.Spades),
                    new Card(12, Suit.Diamonds),
                    new Card(11, Suit.Spades)
                };

                Assert.IsFalse(CheckRoyalFlush(firstHand));
                Assert.IsFalse(CheckRoyalFlush(secondHand));
            }
        }
        private bool CheckStraight(int[] cardsSequence)
        {
            cardsSequence = cardsSequence.OrderBy(x => x).Distinct().ToArray();

            int[] first5Cards = new int[5];
            int[] second5Cards = new int[5];
            int[] third5Cards = new int[5];

            if (cardsSequence.Length == 7)
            {
                first5Cards = cardsSequence.Take(5).ToArray();
                second5Cards = cardsSequence.Skip(1).Take(5).ToArray();
                third5Cards = cardsSequence.Skip(2).ToArray();

                return first5Cards.SequenceEqual(Enumerable.Range(cardsSequence[0], 5)) || second5Cards.SequenceEqual(Enumerable.Range(cardsSequence[1], 5)) || third5Cards.SequenceEqual(Enumerable.Range(cardsSequence[2], 5)) || IsBottomStraight(first5Cards);                
            }
            else if (cardsSequence.Length == 6)
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
            int[] cardsSequence = yourHand.OrderByDescending(x => x.Rank).Select(x => x.Rank).Take(5).Reverse().ToArray();

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
