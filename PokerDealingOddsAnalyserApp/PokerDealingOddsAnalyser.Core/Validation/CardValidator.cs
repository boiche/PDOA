using System.Text.RegularExpressions;

namespace PokerDealingOddsAnalyser.Core.Validation
{
    public static class CardValidator
    {
        private static readonly Regex cardPattern = new Regex("^([2-9]{0,1}|10|[KJQA])[hcds]-([2-9]{0,1}|10|[KJQA])[hcds]$");
        public static bool Validate(string input)
        {
            if (cardPattern.IsMatch(input))
            {
                if (CheckForDuplicates(input)) return false;
                else return true;
            }
            else if (input == "random") return true;
            else return false;
        }
        private static bool CheckForDuplicates(string input)
        {
            string[] cardsData = input.Split('-');
            if (cardsData[0] == cardsData[1]) return true;
            else return false;
        }
    }
}
