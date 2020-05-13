using PokerDealingOddsAnalyser.Core.Deck;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokerDealingOddsAnalyser.Core.Validation
{
    public static class CardExtractor
    {
        public static List<Card> RetrieveCardsFromInput(string input)
        {
            List<Card> cards = new List<Card>();
            string[] cardsData = input.Split('-');
            foreach (string card in cardsData)
            {
                string rank = string.Empty;
                char suit;

                if (card.Length == 3)
                {
                    rank = $"{card[0]}{card[1]}";
                    suit = card[2];
                }
                else
                {
                    rank = $"{card[0]}";
                    suit = card[1];
                }

                cards.Add(new Card(GetCardRank(rank), GetCardSuit(suit)));
            }

            return cards;
        }
        public static string RetrieveCardStringFromSelectiveForm(string name)
        {
            string[] cardsData = name.Split('-');
            char suit = cardsData[1].ToLower()[0];
            string rank = cardsData[0].Length == 2 ? cardsData[0] : cardsData[0][0].ToString();

            return $"{rank}{suit}-";
        }
        private static Suit GetCardSuit(char suit)
        {
            switch (suit.ToString().ToLower())
            {
                case "h": return Suit.Hearts;
                case "c": return Suit.Clubs;
                case "d": return Suit.Diamonds;
                case "s": return Suit.Spades;
            }

            throw new InvalidOperationException($"Invalid input provided: Suit = {suit}");
        }
        private static int GetCardRank(string rank)
        {
            switch (rank)
            {
                case "J": return 11;
                case "Q": return 12;
                case "K": return 13;
                case "A": return 14;
                default: return int.Parse(rank);
            }

            throw new InvalidOperationException($"Invalid input provided: Rank = {rank}");
        }
    }
}
