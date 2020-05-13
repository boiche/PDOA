using System;

namespace PokerDealingOddsAnalyser.Core.Round
{
    [Serializable]
    public class StrengthData
    {
        public int HighCardRank { get; set; }
        public HandStrengths Strength { get; set; }
    }
}
