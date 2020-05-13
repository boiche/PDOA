using Newtonsoft.Json;
using PokerDealingOddsAnalyser.Core.Deck;
using PokerDealingOddsAnalyser.Core.Report;
using System;

namespace PokerDealingOddsAnalyser.Core.Logging
{
    public class HandViewTemplate
    {
        public DateTime TimeDealt { get; set; }
        public Guid DealNumber { get; set; }
        public uint DealsCount { get; set; }
        public string PlayerHand { get; set; }
        public DealDataTemplate[] DealData { get; set; }        
        public class DealDataTemplate
        {
            public FlopReport Flop { get; set; }
            public TurnReport Turn { get; set; }
            public RiverReport River { get; set; }
            public WinsCountTemplate[] Win { get; set; }

            public class MadeHandsCountTemplate
            {
                public uint HighCard { get; set; }
                public uint Pair { get; set; }
                public uint TwoPairs { get; set; }
                public uint Set { get; set; }
                public uint Straight { get; set; }
                public uint Flush { get; set; }
                public uint FullHouse { get; set; }
                public uint Quads { get; set; }
                public uint StraightFlush { get; set; }
                public uint RoyalFlush { get; set; }
            }

            public class WinsCountTemplate
            {
                public CardsTemplate[] PlayingHand { get; set; }
                public uint WonGames { get; set; }

                public class CardsTemplate
                {
                    public Suit Suit { get; set; }
                    public uint Rank { get; set; }
                }
            }
        }        
    }    
}
