using PokerDealingOddsAnalyser.Core.Validation;
using System;
using System.Text;
using System.Windows.Forms;
using TexasHoldEm;

namespace PokerDealingOddsAnalyserApp
{
    public partial class RetreiveCardsForm : Form
    {
        private readonly TexasHoldEmForm _texasForm;
        private readonly StringBuilder _builder;
        private string _previousCardText;
        private object sender;
        public RetreiveCardsForm(TexasHoldEmForm texasHoldEmForm)
        {
            _previousCardText = string.Empty;
            this._builder = new StringBuilder();
            this._texasForm = texasHoldEmForm;
            InitializeComponent();
            InitialiseSelectiveDeck();
        }

        private void InitialiseSelectiveDeck()
        {
            for (int i = 0; i < allCardsList.Images.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem("", i)
                {
                    Text = allCardsList.Images.Keys[i]
                };
                allCardsView.Items.Add(listViewItem);
            }
        }

        private void RetrieveCard(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (_previousCardText != e.Item.Text) _builder.Append(CardExtractor.RetrieveCardStringFromSelectiveForm(e.Item.Text));
            _previousCardText = e.Item.Text;

            if (this._builder.Length >= 6)
            {
                _previousCardText = string.Empty;
                _texasForm.PopulateInput(this.sender, _builder.Remove(_builder.Length - 1, 1).ToString());
                _builder.Clear();
            }
        }
        internal void ShowForm(object sender, EventArgs e)
        {
            this.sender = sender;
            this.ShowDialog();
        }
    }
}
