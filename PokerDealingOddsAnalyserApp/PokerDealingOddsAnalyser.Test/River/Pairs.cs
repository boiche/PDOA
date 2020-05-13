using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerDealingOddsAnalyser.Core.Deck;
using System.Collections.Generic;
using System.Linq;

namespace PokerDealingOddsAnalyser.Test.River
{
    [TestClass]
    public class Pairs
    {
        private bool isOnePair = false;
        private bool isTwoPairs = false;
        private bool isSet = false;
        private bool isFullhouse = false;
        private bool isQuads = false;
        private int highCardRank = default;      
        
        [TestMethod]
        public void Check_HighCard_Excpect13()
        {
            List<Card> sequence = new List<Card>
            {
                new Card(2, Suit.Clubs),
                new Card(3, Suit.Clubs),
                new Card(13, Suit.Hearts),
                new Card(10, Suit.Spades),
                new Card(5, Suit.Diamonds),
                new Card(8, Suit.Spades),
                new Card(7, Suit.Diamonds),
            };
            CheckPairs(sequence.OrderBy(x => x.Rank).ToList());
            Assert.AreEqual(13, this.highCardRank);
        }
        [TestMethod]
        public void Check_OnePair_ExpectTrue()
        {
            List<Card> sequence = new List<Card>
            {
                new Card(2, Suit.Clubs),
                new Card(13, Suit.Clubs),
                new Card(13, Suit.Hearts),
                new Card(10, Suit.Spades),
                new Card(5, Suit.Diamonds),
                new Card(8, Suit.Spades),
                new Card(7, Suit.Diamonds),
            };
            CheckPairs(sequence.OrderBy(x => x.Rank).ToList());
            Assert.IsTrue(isOnePair && highCardRank == 13);
        }
        [TestMethod]
        public void Check_TwoPairs_ExpectTrue()
        {
            List<Card> sequence = new List<Card>
            {
                new Card(2, Suit.Clubs),
                new Card(3, Suit.Clubs),
                new Card(13, Suit.Hearts),
                new Card(10, Suit.Spades),
                new Card(10, Suit.Diamonds),
                new Card(7, Suit.Spades),
                new Card(7, Suit.Diamonds),
            };

            CheckPairs(sequence.OrderBy(x => x.Rank).ToList());
            Assert.IsTrue(isTwoPairs && highCardRank == 10);
        }
        [TestMethod]
        public void Check_Set_ExpectTrue()
        {
            List<Card> sequence = new List<Card>
            {
                new Card(2, Suit.Clubs),
                new Card(2, Suit.Clubs),
                new Card(13, Suit.Hearts),
                new Card(10, Suit.Spades),
                new Card(5, Suit.Diamonds),
                new Card(2, Suit.Spades),
                new Card(7, Suit.Diamonds),
            };

            CheckPairs(sequence.OrderBy(x => x.Rank).ToList());
            Assert.IsTrue(isSet && highCardRank == 2);
        }
        [TestMethod]
        public void Check_FullHouse_ExpectTrue()
        {
            List<Card> sequence = new List<Card>
            {
                new Card(2, Suit.Clubs),
                new Card(3, Suit.Clubs),
                new Card(3, Suit.Hearts),
                new Card(10, Suit.Spades),
                new Card(5, Suit.Diamonds),
                new Card(2, Suit.Spades),
                new Card(2, Suit.Diamonds),
            };

            CheckPairs(sequence.OrderBy(x => x.Rank).ToList());
            Assert.IsTrue(isFullhouse && highCardRank == 2);
        }
        [TestMethod]
        public void Check_Quads_ExpectTrue()
        {
            List<Card> sequence = new List<Card>
            {
                new Card(2, Suit.Clubs),
                new Card(3, Suit.Clubs),
                new Card(13, Suit.Hearts),
                new Card(2, Suit.Spades),
                new Card(5, Suit.Diamonds),
                new Card(2, Suit.Spades),
                new Card(2, Suit.Diamonds),
            };

            CheckPairs(sequence.OrderBy(x => x.Rank).ToList());
            Assert.IsTrue(isQuads && highCardRank == 2);
        }

        private void CheckPairs(List<Card> currentHand)
        {
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
                                this.isQuads = true;                                
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
                            if (this.highCardRank < currentHand[cardIndex].Rank)
                            {
                                this.highCardRank = currentHand[cardIndex].Rank;
                            }
                            pairs += 1;
                        }
                    }
                    else continue;
                }
            }

            if (set == 1 && pairs == 2)
            {
                this.isFullhouse = true;
                highCardRank = currentHand.GroupBy(item => item).OrderByDescending(g => g.Count()).Select(g => g.Key).First().Rank;
            }
            else if (set == 1)
            {
                this.isSet = true;
            }
            else if (pairs >= 2)
            {
                this.isTwoPairs = true;
            }
            else if (pairs == 1)
            {
                this.isOnePair = true;
            }
            else
            {
                this.highCardRank = currentHand.Max(x => x.Rank);
            }
        }
    }
}
