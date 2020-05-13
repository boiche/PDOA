using PokerDealingOddsAnalyser.Core.Deck;
using PokerDealingOddsAnalyser.Core.Logging;
using PokerDealingOddsAnalyser.Core.Report;
using PokerDealingOddsAnalyser.Core.Round;
using PokerDealingOddsAnalyser.Core.Validation;
using PokerDealingOddsAnalyserApp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexasHoldEm
{
    public partial class TexasHoldEmForm : Form
    {
        public Control[] Inputs { get; set; }
        private DeckCards Deck { get; set; }
        private FlopReport FlopReport { get; set; }
        private TurnReport TurnReport { get; set; }
        private RiverReport RiverReport { get; set; }
        private WinningReport WinningReport { get; set; }
        private Hand YourHand { get; set; }
        private List<Hand> OpponentHands { get; set; }

        //string: Name of the street
        //Card[]: Cards dealt on this (string)street
        public List<Dictionary<string, Card[]>> Boards { get; private set; }

        internal void PopulateInput(object sender, string result)
        {
            switch ((sender as Control).Name)
            {
                case nameof(this.manualPlayerHandBtn): this.playerHandInput.Text = result; break;                    
                case nameof(this.opp1ManualBtn): this.opponent1Input.Text = result; break;
                case nameof(this.opp2ManualBtn): this.opponent2Input.Text = result; break;
                case nameof(this.opp3ManualBtn): this.opponent3Input.Text = result; break;
                case nameof(this.opp4ManualBtn): this.opponent4Input.Text = result; break;
                case nameof(this.opp5ManualBtn): this.opponent5Input.Text = result; break;
                case nameof(this.opp6ManualBtn): this.opponent6Input.Text = result; break;
                case nameof(this.opp7ManualBtn): this.opponent7Input.Text = result; break;
                case nameof(this.opp8ManualBtn): this.opponent8Input.Text = result; break;
            }
        }
        
        private readonly RetreiveCardsForm _cardsForm;
        private readonly HistoryForm _historyForm;

        public TexasHoldEmForm()
        {
            _cardsForm = new RetreiveCardsForm(this);
            _historyForm = new HistoryForm();
            this.Deck = new DeckCards();
            this.FlopReport = new FlopReport();
            this.TurnReport = new TurnReport();
            this.RiverReport = new RiverReport();
            this.WinningReport = new WinningReport();
            this.YourHand = new Hand();
            this.OpponentHands = new List<Hand>();
            this.Boards = new List<Dictionary<string, Card[]>>();

            InitializeComponent();
            this.Inputs = this.Controls.Cast<Control>().Where(x => x.Name.Contains("Input")).ToArray();
        }
        private async void StartButton_Click(object sender, EventArgs e)
        {
            if (inputNumberDeals.ForeColor == Color.Red || !CardValidator.Validate(playerHandInput.Text))
            {
                MessageBox.Show("Invalid input.");
                return;
            }

            DealPlayersHands();

            int dealsCount = int.Parse(inputNumberDeals.Text);
            progressBar1.Maximum = dealsCount;

            for (int i = 0; i < dealsCount; i++)
            {
                this.Deck.DealBoard(this.Boards, i);
                this.Deck.Shuffle();
                progressBar1.Increment(1);
            }

            await Task.Run(() =>
            {
                YourHand.PlayingHand = YourHand.PlayingHand.OrderBy(x => x.Rank).ToList();
                this.FlopReport.GetData(this.Boards, this.YourHand);
                this.TurnReport.GetData(this.Boards, this.YourHand);
                this.RiverReport.GetData(this.Boards, this.YourHand);
                if (this.OpponentHands.Count > 0) this.WinningReport.GetData(this.Boards, this.YourHand, this.OpponentHands);
            });
            
            await Task.Run(() =>
            {
                HandLogger.StartLogHand(this.YourHand, dealsCount);
                this.FlopReport.LogIntoFile();
                this.TurnReport.LogIntoFile();
                this.RiverReport.LogIntoFile();
                this.WinningReport.LogIntoFile();
                HandLogger.EndLogHand();
                HandReader.AddCurrentHand();
            });

            FullReportWindow fullReportWindow = new FullReportWindow(FlopReport, TurnReport, RiverReport, WinningReport, Boards.Count, OpponentHands, YourHand);
            fullReportWindow.ShowDialog();
            ResetUI(sender, e);            
        }        
        private void DealPlayersHands()
        {
            foreach (Control inputControl in this.Inputs.Where(x => x.Text != "random"))
            {
                if (inputControl.Name == nameof(playerHandInput))
                {
                    this.YourHand = this.Deck.DealChosenHand(CardExtractor.RetrieveCardsFromInput(inputControl.Text));
                }
                else
                {
                    if (!CardValidator.Validate(inputControl.Text)) continue;
                    else this.OpponentHands.Add(this.Deck.DealChosenHand(CardExtractor.RetrieveCardsFromInput(inputControl.Text)));
                }                
            }
            foreach (Control inputControl in this.Inputs.Where(x=>x.Text == "random"))
            {
                if (inputControl.Name == nameof(playerHandInput)) this.YourHand = this.Deck.DealRandomHand();                
                else this.OpponentHands.Add(this.Deck.DealRandomHand());                
            }
        }
        private void ResetUI(object sender, EventArgs e)
        {
            progressBar1.Value = 0;          

            FlopReport.Reset();
            TurnReport.Reset();
            RiverReport.Reset();
            WinningReport.Reset();            
            Deck.Reset();
            Deck.Shuffle();
            Boards.Clear();

            this.OpponentHands.Clear();
        }     
        private void LoadLogger(object sender, EventArgs e) => HandLogger.StartLogger();
        private void CloseLogger(object sender, FormClosingEventArgs e) => HandLogger.EndLogger();
        private void ValidateInput(object sender, EventArgs e)
        {
            bool parsed = uint.TryParse(inputNumberDeals.Text, out uint deals);
            if (!parsed || deals == 0) inputNumberDeals.ForeColor = Color.Red;            
            else inputNumberDeals.ForeColor = Color.Black;            
        }
        #region InputManagement
        private void ManualPlayerHandBtn_Click(object sender, EventArgs e) => _cardsForm.ShowForm(sender, e);
        private void Opp1ManualBtn_Click(object sender, EventArgs e) => _cardsForm.ShowForm(sender, e);
        private void Opp2ManualBtn_Click(object sender, EventArgs e) => _cardsForm.ShowForm(sender, e);
        private void Opp3ManualBtn_Click(object sender, EventArgs e) => _cardsForm.ShowForm(sender, e);
        private void Opp4ManualBtn_Click(object sender, EventArgs e) => _cardsForm.ShowForm(sender, e);
        private void Opp5ManualBtn_Click(object sender, EventArgs e) => _cardsForm.ShowForm(sender, e);
        private void Opp6ManualBtn_Click(object sender, EventArgs e) => _cardsForm.ShowForm(sender, e);
        private void Opp7ManualBtn_Click(object sender, EventArgs e) => _cardsForm.ShowForm(sender, e);
        private void Opp8ManualBtn_Click(object sender, EventArgs e) => _cardsForm.ShowForm(sender, e);
        private void RandomPlayerHandBtn_Click(object sender, EventArgs e) => playerHandInput.Text = "random";
        private void Opp1RandomBtn_Click(object sender, EventArgs e) => opponent1Input.Text = "random";
        private void Opp2RandomBtn_Click(object sender, EventArgs e) => opponent2Input.Text = "random";
        private void Opp3RandomBtn_Click(object sender, EventArgs e) => opponent3Input.Text = "random";
        private void Opp4RandomBtn_Click(object sender, EventArgs e) => opponent4Input.Text = "random";
        private void Opp5RandomBtn_Click(object sender, EventArgs e) => opponent5Input.Text = "random";
        private void Opp6RandomBtn_Click(object sender, EventArgs e) => opponent6Input.Text = "random";
        private void Opp7RandomBtn_Click(object sender, EventArgs e) => opponent7Input.Text = "random";
        private void Opp8RandomBtn_Click(object sender, EventArgs e) => opponent8Input.Text = "random";
        private void ClearPlayerHandBtn_Click(object sender, EventArgs e) => playerHandInput.Text = string.Empty;
        private void Opp1ClearBtn_Click(object sender, EventArgs e) => opponent1Input.Text = string.Empty;
        private void Opp2ClearBtn_Click(object sender, EventArgs e) => opponent2Input.Text = string.Empty;
        private void Opp3ClearBtn_Click(object sender, EventArgs e) => opponent3Input.Text = string.Empty;
        private void Opp4ClearBtn_Click(object sender, EventArgs e) => opponent4Input.Text = string.Empty;
        private void Opp5ClearBtn_Click(object sender, EventArgs e) => opponent5Input.Text = string.Empty;
        private void Opp6ClearBtn_Click(object sender, EventArgs e) => opponent6Input.Text = string.Empty;
        private void Opp7ClearBtn_Click(object sender, EventArgs e) => opponent7Input.Text = string.Empty;
        private void Opp8ClearBtn_Click(object sender, EventArgs e) => opponent8Input.Text = string.Empty;
        #endregion
        private void CheckText(object sender, EventArgs e)
        {
            if (CardValidator.Validate((sender as Control).Text) == false) (sender as Control).ForeColor = Color.Red;
            else (sender as Control).ForeColor = Color.Black;
        }
        private void HistoryToolStripMenuItem_Click(object sender, EventArgs e) => _historyForm.ShowDialog();
    }
}