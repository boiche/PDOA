using Newtonsoft.Json;
using PokerDealingOddsAnalyser.Core.Deck;
using PokerDealingOddsAnalyser.Core.Report;
using PokerDealingOddsAnalyser.Core.Round;
using System;
using System.IO;
using System.Text;

namespace PokerDealingOddsAnalyser.Core.Logging
{
    public static class HandLogger
    {
        internal static FileStream _currentFileStream = new FileStream($"..\\..\\..\\..\\PokerDealingOddsAnalyserApp\\PokerDealingOddsAnalyser.Core\\LogHands.json", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        private static readonly StreamWriter _defaultStreamWriter = new StreamWriter(_currentFileStream);        
        private static readonly StringBuilder sessionStringBuilder = new StringBuilder();
        private static readonly JsonTextWriter _jsonWriter = new JsonTextWriter(new StringWriter(sessionStringBuilder)) 
        { 
            Formatting = Formatting.Indented, 
            Indentation = 3 
        };
        private static bool _isStarted = false;
        private static bool _isOverwritten = false;
        public static void StartLogger()
        {
            if (!_isStarted)
            {
                if (_currentFileStream.Length == 0) _jsonWriter.WriteStartArray();
                else ContinueLogger();
                _isStarted = true;
            }
            else throw new InvalidOperationException("The logger is already started!");
        }
        public static void StartLogHand(Hand playerHand, int dealsCount)
        {
            _isOverwritten = true;
            if (sessionStringBuilder.Length != 0) _defaultStreamWriter.Write(",");            
            sessionStringBuilder.Clear();

            _jsonWriter.WriteStartObject();

            _jsonWriter.WritePropertyName("DealNumber");
            _jsonWriter.WriteValue(Guid.NewGuid().ToString());

            _jsonWriter.WritePropertyName("TimeDealt");
            _jsonWriter.WriteValue(DateTime.UtcNow);

            _jsonWriter.WritePropertyName("DealsCount");
            _jsonWriter.WriteValue(dealsCount);

            _jsonWriter.WritePropertyName("PlayerHand");
            _jsonWriter.WriteValue(GetPlayerHand(playerHand));

            _jsonWriter.WritePropertyName("DealData");
            _jsonWriter.WriteStartArray();
           
            SaveChanges();
        }
        public static void LogHand(this ILoggable round)
        {            
            _jsonWriter.WriteStartObject();

            switch (round.GetType().Name)
            {
                case "FlopReport": 
                    { 
                        _jsonWriter.WritePropertyName("Flop");
                        _jsonWriter.WriteRawValue(JsonConvert.SerializeObject(round, Formatting.Indented));
                    } 
                    break;
                case "TurnReport":
                    {
                        _jsonWriter.WritePropertyName("Turn");
                        _jsonWriter.WriteRawValue(JsonConvert.SerializeObject(round, Formatting.Indented));
                    }
                    break;
                case "RiverReport":
                    {
                        _jsonWriter.WritePropertyName("River");
                        _jsonWriter.WriteRawValue(JsonConvert.SerializeObject(round, Formatting.Indented));
                    }
                    break;
                case "WinningReport":
                    {
                        _jsonWriter.WritePropertyName("Win");
                        _jsonWriter.WriteRawValue(JsonConvert.SerializeObject((round as WinningReport).allHands, Formatting.Indented));
                    }
                    break;
            }            
            _jsonWriter.WriteEndObject();

            SaveChanges();
        }

        /// <summary>
        /// Sets new storage location for the current session of work and then loggs the round to the new location
        /// </summary>
        /// <param name="round">The round to be logged</param>
        /// <param name="filePath">The new location of storage</param>
        public static void LogHand(this ILoggable round, string filePath)
        {
            if (_currentFileStream.Name != filePath) _currentFileStream = new FileStream(filePath, FileMode.CreateNew, FileAccess.ReadWrite);
            LogHand(round);
        }
        public static void EndLogHand()
        {
            _jsonWriter.WriteEndArray();
            _jsonWriter.WriteEndObject();            

            SaveChanges();            

            lock (_defaultStreamWriter)
            {
                _defaultStreamWriter.Write(sessionStringBuilder.ToString());
                _defaultStreamWriter.Flush();
            }                       
        }
        public static void EndLogger()
        {
            if (_isStarted && _isOverwritten)
            {
                lock (_defaultStreamWriter)
                {
                    _defaultStreamWriter.Write("]");
                    _defaultStreamWriter.Flush();
                }
            }
            else if (!_isStarted) throw new InvalidOperationException("The logger is already ended!");
            else _defaultStreamWriter.Write(']'); //rewrites ']' in case of no dealt hands
        }
        private static string GetPlayerHand(Hand hand)
        {
            StringBuilder cardBuilder = new StringBuilder();

            foreach (Card card in hand.PlayingHand)
            {
                switch (card.Rank)
                {
                    case 11: cardBuilder.Append("J"); break;
                    case 12: cardBuilder.Append("Q"); break;
                    case 13: cardBuilder.Append("K"); break;
                    case 14: cardBuilder.Append("A"); break;
                    default: cardBuilder.Append(card.Rank); break;
                }
                switch (card.Suit)
                {
                    case Suit.Hearts: cardBuilder.Append("h"); break;
                    case Suit.Diamonds: cardBuilder.Append("d"); break;
                    case Suit.Spades: cardBuilder.Append("s"); break;
                    case Suit.Clubs: cardBuilder.Append("c"); break;
                }

                cardBuilder.Append("-");
            }

            return cardBuilder.Remove(cardBuilder.Length - 1, 1).ToString();
        }
        private static void SaveChanges() => _jsonWriter.Flush();       
        private static void ContinueLogger()
        {
            _currentFileStream.SetLength(_currentFileStream.Length - 1);
            _defaultStreamWriter.Write(",");            
        }
        internal static string GetCurrentHand() => sessionStringBuilder.ToString();
    }
}
