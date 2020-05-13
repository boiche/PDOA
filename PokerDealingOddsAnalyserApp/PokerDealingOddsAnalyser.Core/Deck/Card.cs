using System;

namespace PokerDealingOddsAnalyser.Core.Deck
{
    [Serializable]
    public class Card
    {
        public int Rank { get; set; }
        public Suit Suit { get; set; }

        public Card(int rank, Suit suit)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        public string ToString(CardFormats format)
        {
            switch (format)
            {
                case CardFormats.FullDetailed: return $"{GetRankAsString(format)}-{Suit}";
                case CardFormats.Shortened: return $"{GetRankAsString(format)}{Suit.ToString().ToLower()[0]}";                    
                default: throw new InvalidOperationException($"Unable to return card {Rank}-{Suit} as string!");                    
            }
        }

        private string GetRankAsString(CardFormats format)
        {
            string result = string.Empty;

            switch (Rank)
            {
                case 11: result = "Jack"; break;
                case 12: result = "Queen"; break;
                case 13: result = "King"; break;
                case 14: result = "Ace"; break;
                default: return Rank.ToString();                    
            }

            switch (format)
            {
                case CardFormats.FullDetailed: return result;                    
                case CardFormats.Shortened: return result[0].ToString();
                default: throw new InvalidOperationException("Unable to get cards rank as string!");
            }
        }
    }
}
