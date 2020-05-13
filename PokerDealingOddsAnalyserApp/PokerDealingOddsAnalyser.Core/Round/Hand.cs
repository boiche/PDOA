using Newtonsoft.Json;
using PokerDealingOddsAnalyser.Core.Deck;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerDealingOddsAnalyser.Core.Round
{
    [Serializable]
    public class Hand
    {
        public List<Card> PlayingHand { get; set; }
        public int WonGames { get; private set; }
        [JsonIgnore]
        public StrengthData StrengthData { get; set; }
        public Hand()
        {            
            this.PlayingHand = new List<Card>(7);
            this.StrengthData = new StrengthData();
            WonGames = 0;
        }
        public Hand(Card first, Card second) : this()
        {
            this.PlayingHand = new List<Card>(7)
            {
                first,
                second
            };
        }
        public void WinGame() => this.WonGames++;
        public HandStrengths GetStrength() => this.StrengthData.Strength;
        public int GetHighCard()
        {
            SortHand();
            this.StrengthData.HighCardRank = this.PlayingHand[0].Rank;
            return this.StrengthData.HighCardRank;
        }
        public void SortHand()
        {
            switch (StrengthData.Strength)
            {
                case HandStrengths.HighCard: this.PlayingHand = this.PlayingHand.OrderByDescending(x => x.Rank).ToList(); break;
                case HandStrengths.OnePair: this.DispatchSort(); break;
                case HandStrengths.TwoPairs: this.DispatchSort(); break;
                case HandStrengths.Set: this.DispatchSort(); break;
                case HandStrengths.Straight: goto case HandStrengths.HighCard;
                case HandStrengths.Flush: goto case HandStrengths.HighCard;
                case HandStrengths.FullHouse: this.DispatchSort(); break;
                case HandStrengths.Quads: this.DispatchSort(); break;
                case HandStrengths.StraightFlush: goto case HandStrengths.HighCard;
                case HandStrengths.RoyalFlush: goto case HandStrengths.HighCard;                
            }
        }
        public void DispatchSort()
        {
            foreach (Card card in this.PlayingHand.Distinct())
            {
                switch (this.PlayingHand.Count(x => x.Rank == card.Rank))
                {
                    case 1: continue;
                    case 2: this.SortOnePair(card.Rank); break;
                    case 3: this.SortSet(card.Rank); return;
                    case 4: this.SortQuads(card.Rank); return;
                }
            }
        }
        private void SortQuads(int rank)
        {
            this.StrengthData.Strength = HandStrengths.Quads;
            this.StrengthData.HighCardRank = rank;
        }
        private void SortSet(int rank)
        {
            this.StrengthData.Strength = HandStrengths.Set;
            this.StrengthData.HighCardRank = rank;
            for (int i = 0; i < PlayingHand.Count; i++)
            {
                if (PlayingHand[i].Rank != rank)
                {
                    Swap(i, PlayingHand.Count - 1);
                    i--;
                }
            }
        }
        private void SortOnePair(int rank)
        {
            this.StrengthData.Strength = HandStrengths.OnePair;
            this.StrengthData.HighCardRank = rank;
        }
        private void Swap(int firstIndex, int secondIndex)
        {
            Card c = PlayingHand[firstIndex];
            PlayingHand[firstIndex] = PlayingHand[secondIndex];
            PlayingHand[secondIndex] = c;
        }        
    }
}
