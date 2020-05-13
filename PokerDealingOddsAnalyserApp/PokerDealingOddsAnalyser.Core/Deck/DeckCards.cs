using PokerDealingOddsAnalyser.Core.Round;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PokerDealingOddsAnalyser.Core.Deck
{
    public class DeckCards
    {
        public List<Card> PlayingCards { get; set; }
        private List<Card> DealtCards { get; set; }
        public DeckCards(int lowerBound = 2, int upperBound = 14)
        {
            InitialiseDeck(lowerBound, upperBound);
            Shuffle();
            this.DealtCards = new List<Card>();
        }
        public void Shuffle()
        {
            Stopwatch stopwatch = new Stopwatch();
            Random random = new Random();
            int currentCard;
            int cardToSwap;
            int deckCount = this.PlayingCards.Count;

            stopwatch.Start();

            while (stopwatch.Elapsed.TotalMilliseconds <= 12)
            {
                for (int i = 0; i < this.PlayingCards.Count - 1; i++)
                {
                    currentCard = i;
                    cardToSwap = random.Next(0, deckCount);

                    while (currentCard == cardToSwap)
                    {
                        cardToSwap = random.Next(0, deckCount);
                    }

                    Swap(currentCard , cardToSwap);
                }
            }
        }
        public void Reset()
        {
            PlayingCards.AddRange(DealtCards);
            DealtCards.Clear();
        }
        public void DealBoard(List<Dictionary<string, Card[]>> board, int currentDeal)
        {
            board.Add(new Dictionary<string, Card[]>());

            board[currentDeal].Add("Flop", new Card[3] { this.PlayingCards[3], this.PlayingCards[4], this.PlayingCards[5] });

            board[currentDeal].Add("Turn", new Card[1] { this.PlayingCards[9] });

            board[currentDeal].Add("River", new Card[1] { this.PlayingCards[7] });                                
        }
        public void InitialiseDeck(int lowerBound = 2, int upperBound = 14)
        {
            this.PlayingCards = new List<Card>(52);
            Suit[] suits = new Suit[]
            {
                Suit.Clubs,
                Suit.Diamonds,
                Suit.Hearts,
                Suit.Spades
            };

            if ((lowerBound < 2 || lowerBound > 14) || (upperBound < 2 || upperBound > 14) || lowerBound > upperBound)
            {
                throw new InvalidOperationException("Invalid card ranks. Please enter valid ranks (2-14)");
            }

            for (int s = 0; s < 4; s++)
            {
                for (int str = lowerBound
                    ; str <= upperBound; str++)
                {
                    this.PlayingCards.Add(new Card(str, suits[s]));
                }
            }            
        }
        private void Swap(int indexFirstCard, int indexSecondCard)
        {
            Card FirstCard = this.PlayingCards[indexFirstCard];
            Card SecondCard = this.PlayingCards[indexSecondCard];

            this.PlayingCards[indexFirstCard] = SecondCard;
            this.PlayingCards[indexSecondCard] = FirstCard;
        }
        public Hand DealRandomHand()
        {
            Hand hand = new Hand(this.PlayingCards[0], this.PlayingCards[1]);

            this.DealtCards.Add(this.PlayingCards[0]);
            this.DealtCards.Add(this.PlayingCards[1]);

            this.PlayingCards.RemoveRange(0, 2);

            return hand;
        }
        public Hand DealChosenHand(List<Card> cards)
        {
            Card first = cards[0];
            Card second = cards[1];

            Hand hand = new Hand(first, second);

            this.DealtCards.Add(first);
            this.DealtCards.Add(second);

            PlayingCards.Remove(PlayingCards.FirstOrDefault(x => x.Rank == first.Rank && x.Suit == first.Suit));
            PlayingCards.Remove(PlayingCards.FirstOrDefault(x => x.Rank == second.Rank && x.Suit == second.Suit));

            return hand;
        }
    }
}
