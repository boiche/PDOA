using System.IO;
using System.Threading.Tasks;

namespace PokerDealingOddsAnalyser.Core.Report
{
    public interface ILoggable
    {
        void LogIntoFile();
        Task LogIntoFileAsync();
    }
}