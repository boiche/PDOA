namespace PokerDealingOddsAnalyserApp
{
    partial class RetreiveCardsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetreiveCardsForm));
            this.allCardsView = new System.Windows.Forms.ListView();
            this.allCardsList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // allCardsView
            // 
            this.allCardsView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.allCardsView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.allCardsView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allCardsView.HideSelection = false;
            this.allCardsView.LargeImageList = this.allCardsList;
            this.allCardsView.Location = new System.Drawing.Point(12, 12);
            this.allCardsView.Name = "allCardsView";
            this.allCardsView.Size = new System.Drawing.Size(1627, 688);
            this.allCardsView.SmallImageList = this.allCardsList;
            this.allCardsView.StateImageList = this.allCardsList;
            this.allCardsView.TabIndex = 10;
            this.allCardsView.UseCompatibleStateImageBehavior = false;
            this.allCardsView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.RetrieveCard);
            // 
            // allCardsList
            // 
            this.allCardsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("allCardsList.ImageStream")));
            this.allCardsList.TransparentColor = System.Drawing.Color.Transparent;
            this.allCardsList.Images.SetKeyName(0, "2-Clubs");
            this.allCardsList.Images.SetKeyName(1, "3-Clubs");
            this.allCardsList.Images.SetKeyName(2, "4-Clubs");
            this.allCardsList.Images.SetKeyName(3, "5-Clubs");
            this.allCardsList.Images.SetKeyName(4, "6-Clubs");
            this.allCardsList.Images.SetKeyName(5, "7-Clubs");
            this.allCardsList.Images.SetKeyName(6, "8-Clubs");
            this.allCardsList.Images.SetKeyName(7, "9-Clubs");
            this.allCardsList.Images.SetKeyName(8, "10-Clubs");
            this.allCardsList.Images.SetKeyName(9, "Jack-Clubs");
            this.allCardsList.Images.SetKeyName(10, "Queen-Clubs");
            this.allCardsList.Images.SetKeyName(11, "King-Clubs");
            this.allCardsList.Images.SetKeyName(12, "Ace-Clubs");
            this.allCardsList.Images.SetKeyName(13, "2-Diamonds");
            this.allCardsList.Images.SetKeyName(14, "3-Diamonds");
            this.allCardsList.Images.SetKeyName(15, "4-Diamonds");
            this.allCardsList.Images.SetKeyName(16, "5-Diamonds");
            this.allCardsList.Images.SetKeyName(17, "6-Diamonds");
            this.allCardsList.Images.SetKeyName(18, "7-Diamonds");
            this.allCardsList.Images.SetKeyName(19, "8-Diamonds");
            this.allCardsList.Images.SetKeyName(20, "9-Diamonds");
            this.allCardsList.Images.SetKeyName(21, "10-Diamonds");
            this.allCardsList.Images.SetKeyName(22, "Jack-Diamonds");
            this.allCardsList.Images.SetKeyName(23, "Queen-Diamonds");
            this.allCardsList.Images.SetKeyName(24, "King-Diamonds");
            this.allCardsList.Images.SetKeyName(25, "Ace-Diamonds");
            this.allCardsList.Images.SetKeyName(26, "2-Spades");
            this.allCardsList.Images.SetKeyName(27, "3-Spades");
            this.allCardsList.Images.SetKeyName(28, "4-Spades");
            this.allCardsList.Images.SetKeyName(29, "5-Spades");
            this.allCardsList.Images.SetKeyName(30, "6-Spades");
            this.allCardsList.Images.SetKeyName(31, "7-Spades");
            this.allCardsList.Images.SetKeyName(32, "8-Spades");
            this.allCardsList.Images.SetKeyName(33, "9-Spades");
            this.allCardsList.Images.SetKeyName(34, "10-Spades");
            this.allCardsList.Images.SetKeyName(35, "Jack-Spades");
            this.allCardsList.Images.SetKeyName(36, "Queen-Spades");
            this.allCardsList.Images.SetKeyName(37, "King-Spades");
            this.allCardsList.Images.SetKeyName(38, "Ace-Spades");
            this.allCardsList.Images.SetKeyName(39, "2-Hearts");
            this.allCardsList.Images.SetKeyName(40, "3-Hearts");
            this.allCardsList.Images.SetKeyName(41, "4-Hearts");
            this.allCardsList.Images.SetKeyName(42, "5-Hearts");
            this.allCardsList.Images.SetKeyName(43, "6-Hearts");
            this.allCardsList.Images.SetKeyName(44, "7-Hearts");
            this.allCardsList.Images.SetKeyName(45, "8-Hearts");
            this.allCardsList.Images.SetKeyName(46, "9-Hearts");
            this.allCardsList.Images.SetKeyName(47, "10-Hearts");
            this.allCardsList.Images.SetKeyName(48, "Jack-Hearts");
            this.allCardsList.Images.SetKeyName(49, "Queen-Hearts");
            this.allCardsList.Images.SetKeyName(50, "King-Hearts");
            this.allCardsList.Images.SetKeyName(51, "Ace-Hearts");
            // 
            // RetreiveCardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 712);
            this.Controls.Add(this.allCardsView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RetreiveCardsForm";
            this.Text = "RetreiveCardsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView allCardsView;
        private System.Windows.Forms.ImageList allCardsList;
    }
}