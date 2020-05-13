using PokerDealingOddsAnalyser.Core.Logging;
using PokerDealingOddsAnalyser.Core.Round;
using System;
using System.Data;
using System.Windows.Forms;

namespace PokerDealingOddsAnalyserApp
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
            handHistoryGrid.DataSource = HandReader.GetHands();
        }       
        private void ShowHandFullReport(object sender, EventArgs e)
        {

        }
    }
}
