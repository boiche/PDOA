using PokerDealingOddsAnalyser.Core.Deck;
using PokerDealingOddsAnalyser.Core.Round;
using System.Collections.Generic;

namespace PokerDealingOddsAnalyser.Core.Report
{
    public interface IReport
    {
        uint Pair { get; set; }
        uint TwoPairs { get; set; }
        uint Set { get; set; }
        uint Straight { get; set; }
        uint Flush { get; set; }
        uint FullHouse { get; set; }
        uint Quads { get; set; }
        uint StraightFlush { get; set; }
        uint RoyalFlush { get; set; }

        void GetData(List<Dictionary<string, Card[]>> Boards, Hand yourHand);
        void Reset();
    }
}
