using PokerDealingOddsAnalyser.Core.Deck;
using PokerDealingOddsAnalyser.Core.Logging;
using PokerDealingOddsAnalyser.Core.Round;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PokerDealingOddsAnalyser.Core.Report
{
    public abstract class Report : ILoggable
    {
        #region DataRegion
        public uint HighCard { get; protected set; }
        public uint Pair { get; protected set; }
        public uint TwoPairs { get; protected set; }
        public uint Set { get; protected set; }
        public uint Straight { get; protected set; }
        public uint Flush { get; protected set; }
        public uint FullHouse { get; protected set; }
        public uint Quads { get; protected set; }
        public uint StraightFlush { get; protected set; }
        public uint RoyalFlush { get; protected set; }

        protected bool isOnePair = false;
        protected bool isTwoPairs = false;
        protected bool isSet = false;
        protected bool isStraight = false;
        protected bool isFlush = false;
        protected bool isFullhouse = false;
        protected bool isQuads = false; 
        protected bool isStraightFlush = false;
        protected bool isRoyalFlush = false;
        protected int highCardRank = default;
        #endregion        

        public Report()
        {
            this.Pair = 0;
            this.TwoPairs = 0;
            this.Set = 0;
            this.Straight = 0;
            this.Flush = 0;
            this.FullHouse = 0;
            this.Quads = 0;
            this.StraightFlush = 0;
            this.RoyalFlush = 0;
        }
        public abstract void GetData(List<Dictionary<string, Card[]>> boards, Hand yourHand);
        public virtual void Reset()
        {
            this.highCardRank = default;
            this.isOnePair = false;
            this.isTwoPairs = false;
            this.isSet = false;
            this.isStraight = false;
            this.isFlush = false;
            this.isFullhouse = false;
            this.isQuads = false;
            this.isStraightFlush = false;
            this.isRoyalFlush = false;
        }
        public void LogIntoFile() => HandLogger.LogHand(this);
        public void LogIntoFile(string filePath) => HandLogger.LogHand(this, filePath);
        public async Task LogIntoFileAsync() => await Task.Run(() => LogIntoFile());        
    }
}
