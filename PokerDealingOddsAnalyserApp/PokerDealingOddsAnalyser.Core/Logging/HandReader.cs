using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace PokerDealingOddsAnalyser.Core.Logging
{
    public static class HandReader
    {       
        private static readonly StreamReader _defaultReader = new StreamReader(HandLogger._currentFileStream);
        private static readonly string fileContent = _defaultReader.ReadToEnd();
        private static readonly List<HandViewTemplate> hands = JsonConvert.DeserializeAnonymousType(fileContent, new List<HandViewTemplate>()) ?? new List<HandViewTemplate>();

        public static List<HandViewTemplate> GetHands() => hands;
        public static void AddCurrentHand() => hands.Add(JsonConvert.DeserializeAnonymousType(HandLogger.GetCurrentHand(), new HandViewTemplate()));
        internal static string GetContent() => fileContent;
    }
}
