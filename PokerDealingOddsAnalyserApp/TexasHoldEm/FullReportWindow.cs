using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PokerDealingOddsAnalyser.Core.Deck;
using PokerDealingOddsAnalyser.Core.Report;
using PokerDealingOddsAnalyser.Core.Round;

namespace PokerDealingOddsAnalyserApp
{
    public partial class FullReportWindow : Form
    {
        private readonly FlopReport FlopReport;
        private readonly TurnReport TurnReport;
        private readonly RiverReport RiverReport;
        private readonly WinningReport WinningReport;
        private readonly List<Hand> OpponentHands;
        private readonly Hand YourHand;      

        public FullReportWindow(FlopReport flopReport, TurnReport turnReport, RiverReport riverReport, WinningReport winningReport, int deals, List<Hand> opponentHands, Hand yourHand)
        {
            InitializeComponent();

            this.FlopReport = flopReport;
            this.TurnReport = turnReport;
            this.RiverReport = riverReport;
            this.WinningReport = winningReport;
            this.OpponentHands = opponentHands;
            this.YourHand = yourHand;

            this.firstCardPicture.Image = allCardsList.Images[yourHand.PlayingHand[0].ToString(CardFormats.FullDetailed)];
            this.secondCardPicture.Image = allCardsList.Images[yourHand.PlayingHand[1].ToString(CardFormats.FullDetailed)];

            ShowReports(deals);
        }

        private void ShowReports(int dealsCount)
        {
            flopData.Items.Add($"High card: {FlopReport.HighCard} - {Math.Round((double)100 * FlopReport.HighCard / dealsCount, 2):F2}%");
            flopData.Items.Add($"One pair: {FlopReport.Pair} - {Math.Round((double)100 * FlopReport.Pair / dealsCount, 2):F2}%");
            flopData.Items.Add($"Two pairs: {FlopReport.TwoPairs} - {Math.Round((double)100 * FlopReport.TwoPairs / dealsCount, 2):F2}%");
            flopData.Items.Add($"Sets: {FlopReport.Set} - {Math.Round((double)100 * FlopReport.Set / dealsCount, 2):F2}%");
            flopData.Items.Add($"Straights: {FlopReport.Straight} - {Math.Round((double)100 * FlopReport.Straight / dealsCount, 2):F2}%");
            flopData.Items.Add($"Flushes: {FlopReport.Flush} - {Math.Round((double)100 * FlopReport.Flush / dealsCount, 2):F2}%");
            flopData.Items.Add($"Full houses: {FlopReport.FullHouse} - {Math.Round((double)100 * FlopReport.FullHouse / dealsCount, 2):F2}%");
            flopData.Items.Add($"Quads: {FlopReport.Quads} - {Math.Round((double)100 * FlopReport.Quads / dealsCount, 2):F2}%");
            flopData.Items.Add($"Straight flushes: {FlopReport.StraightFlush} - {Math.Round((double)100 * FlopReport.StraightFlush / dealsCount, 2):F2}%");
            flopData.Items.Add($"Royal flushes: {FlopReport.RoyalFlush} - {Math.Round((double)100 * FlopReport.RoyalFlush / dealsCount, 2):F2}%");

            flopChartReport.Series["High card"].Points.AddY(FlopReport.HighCard);
            flopChartReport.Series["One pair"].Points.AddY(FlopReport.Pair);
            flopChartReport.Series["Two pairs"].Points.AddY(FlopReport.TwoPairs);
            flopChartReport.Series["Set"].Points.AddY(FlopReport.Set);
            flopChartReport.Series["Straight"].Points.AddY(FlopReport.Straight);
            flopChartReport.Series["Flush"].Points.AddY(FlopReport.Flush);
            flopChartReport.Series["Full house"].Points.AddY(FlopReport.FullHouse);
            flopChartReport.Series["Quads"].Points.AddY(FlopReport.Quads);
            flopChartReport.Series["Straight flush"].Points.AddY(FlopReport.StraightFlush);
            flopChartReport.Series["Royal flush"].Points.AddY(FlopReport.RoyalFlush);

            turnData.Items.Add($"High card: {TurnReport.HighCard} - {Math.Round((double)100 * TurnReport.HighCard / dealsCount, 2):F2}%");
            turnData.Items.Add($"One pair: {TurnReport.Pair} - {Math.Round((double)100 * TurnReport.Pair / dealsCount, 2):F2}%");
            turnData.Items.Add($"Two pairs: {TurnReport.TwoPairs} - {Math.Round((double)100 * TurnReport.TwoPairs / dealsCount, 2):F2}%");
            turnData.Items.Add($"Sets: {TurnReport.Set} - {Math.Round((double)100 * TurnReport.Set / dealsCount, 2):F2}%");
            turnData.Items.Add($"Straights: {TurnReport.Straight} - {Math.Round((double)100 * TurnReport.Straight / dealsCount, 2):F2}%");
            turnData.Items.Add($"Flushes: {TurnReport.Flush} - {Math.Round((double)100 * TurnReport.Flush / dealsCount, 2):F2}%");
            turnData.Items.Add($"Full houses: {TurnReport.FullHouse} - {Math.Round((double)100 * TurnReport.FullHouse / dealsCount, 2):F2}%");
            turnData.Items.Add($"Quads: {TurnReport.Quads} - {Math.Round((double)100 * TurnReport.Quads / dealsCount, 2):F2}%");
            turnData.Items.Add($"Straight flushes: {TurnReport.StraightFlush} - {Math.Round((double)100 * TurnReport.StraightFlush / dealsCount, 2):F2}%");
            turnData.Items.Add($"Royal flushes: {TurnReport.RoyalFlush} - {Math.Round((double)100 * TurnReport.RoyalFlush / dealsCount, 2):F2}%");

            turnChartReport.Series["High card"].Points.AddY(TurnReport.HighCard);
            turnChartReport.Series["One pair"].Points.AddY(TurnReport.Pair);
            turnChartReport.Series["Two pairs"].Points.AddY(TurnReport.TwoPairs);
            turnChartReport.Series["Set"].Points.AddY(TurnReport.Set);
            turnChartReport.Series["Straight"].Points.AddY(TurnReport.Straight);
            turnChartReport.Series["Flush"].Points.AddY(TurnReport.Flush);
            turnChartReport.Series["Full house"].Points.AddY(TurnReport.FullHouse);
            turnChartReport.Series["Quads"].Points.AddY(TurnReport.Quads);
            turnChartReport.Series["Straight flush"].Points.AddY(TurnReport.StraightFlush);
            turnChartReport.Series["Royal flush"].Points.AddY(TurnReport.RoyalFlush);

            roundData.Items.Add($"High card: {RiverReport.HighCard} - {Math.Round((double)100 * RiverReport.HighCard / dealsCount, 2):F2}%");
            roundData.Items.Add($"One pair: {RiverReport.Pair} - {Math.Round((double)100 * RiverReport.Pair / dealsCount, 2):F2}%");
            roundData.Items.Add($"Two pairs: {RiverReport.TwoPairs} - {Math.Round((double)100 * RiverReport.TwoPairs / dealsCount, 2):F2}%");
            roundData.Items.Add($"Sets: {RiverReport.Set} - {Math.Round((double)100 * RiverReport.Set / dealsCount, 2):F2}%");
            roundData.Items.Add($"Straights: {RiverReport.Straight} - {Math.Round((double)100 * RiverReport.Straight / dealsCount, 2):F2}%");
            roundData.Items.Add($"Flushes: {RiverReport.Flush} - {Math.Round((double)100 * RiverReport.Flush / dealsCount, 2):F2}%");
            roundData.Items.Add($"Full houses: {RiverReport.FullHouse} - {Math.Round((double)100 * RiverReport.FullHouse / dealsCount, 2):F2}%");
            roundData.Items.Add($"Quads: {RiverReport.Quads} - {Math.Round((double)100 * RiverReport.Quads / dealsCount, 2):F2}%");
            roundData.Items.Add($"Straight flushes: {RiverReport.StraightFlush} - {Math.Round((double)100 * RiverReport.StraightFlush / dealsCount, 2):F2}%");
            roundData.Items.Add($"Royal flushes: {RiverReport.RoyalFlush} - {Math.Round((double)100 * RiverReport.RoyalFlush / dealsCount, 2):F2}%");

            roundChartReport.Series["High card"].Points.AddY(RiverReport.HighCard);
            roundChartReport.Series["One pair"].Points.AddY(RiverReport.Pair);
            roundChartReport.Series["Two pairs"].Points.AddY(RiverReport.TwoPairs);
            roundChartReport.Series["Set"].Points.AddY(RiverReport.Set);
            roundChartReport.Series["Straight"].Points.AddY(RiverReport.Straight);
            roundChartReport.Series["Flush"].Points.AddY(RiverReport.Flush);
            roundChartReport.Series["Full house"].Points.AddY(RiverReport.FullHouse);
            roundChartReport.Series["Quads"].Points.AddY(RiverReport.Quads);
            roundChartReport.Series["Straight flush"].Points.AddY(RiverReport.StraightFlush);
            roundChartReport.Series["Royal flush"].Points.AddY(RiverReport.RoyalFlush);

            flopChartReport.Visible = true;
            turnChartReport.Visible = true;
            roundChartReport.Visible = true;
            flopData.Visible = true;
            turnData.Visible = true;
            roundData.Visible = true;

            if (this.WinningReport != null)
            {
                DisplayOpponentHands();
                DisplayWinOdds(dealsCount);
            }
        }
        private void DisplayOpponentHands()
        {
            oppHandsView.Visible = true;

            for (int i = 0; i < this.OpponentHands.Count; i++)
            {
                foreach (Card card in this.OpponentHands[i].PlayingHand)
                {                    
                    ListViewItem item = new ListViewItem($"Opponent {i + 1}", $"{card.ToString(CardFormats.FullDetailed)}");

                    oppHandsView.Items.Add(item);
                }
            }

            oppHandsView.Show();           
        }
        private void DisplayWinOdds(int dealsCount)
        {
            winOddsListBox.Items.Add($"Your hand: {this.YourHand.WonGames} games won - {Math.Round((double)100 * YourHand.WonGames / dealsCount, 2):F2}%");
            int opponent = 1;
            foreach (Hand hand in this.OpponentHands)
            {
                winOddsListBox.Items.Add($"Opponent {opponent} hand: {hand.WonGames} games won - {Math.Round((double)100 * hand.WonGames / dealsCount, 2):F2}%");
                opponent++;
            }
            winOddsListBox.Items.Add($"Draws: {WinningReport.Draws} - {Math.Round((double)100 * WinningReport.Draws / dealsCount, 2):F2}%");
        }
    }
}
