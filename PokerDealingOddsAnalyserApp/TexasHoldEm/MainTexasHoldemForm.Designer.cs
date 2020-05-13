namespace TexasHoldEm
{
    public partial class TexasHoldEmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TexasHoldEmForm));
            this.label2 = new System.Windows.Forms.Label();
            this.yourCardsConstLabel = new System.Windows.Forms.Label();
            this.inputNumberDeals = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.logo = new System.Windows.Forms.PictureBox();
            this.opponentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sadsadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfDealsInfo = new System.Windows.Forms.Label();
            this.playerHandInput = new System.Windows.Forms.TextBox();
            this.opponent7Input = new System.Windows.Forms.TextBox();
            this.opponent6Input = new System.Windows.Forms.TextBox();
            this.opponent5Input = new System.Windows.Forms.TextBox();
            this.opponent4Input = new System.Windows.Forms.TextBox();
            this.opponent3Input = new System.Windows.Forms.TextBox();
            this.opponent2Input = new System.Windows.Forms.TextBox();
            this.opponent1Input = new System.Windows.Forms.TextBox();
            this.opponent8Input = new System.Windows.Forms.TextBox();
            this.randomPlayerHandBtn = new System.Windows.Forms.Button();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.clearPlayerHandBtn = new System.Windows.Forms.Button();
            this.manualPlayerHandBtn = new System.Windows.Forms.Button();
            this.opp1ManualBtn = new System.Windows.Forms.Button();
            this.opp8ManualBtn = new System.Windows.Forms.Button();
            this.opp7ManualBtn = new System.Windows.Forms.Button();
            this.opp6ManualBtn = new System.Windows.Forms.Button();
            this.opp5ManualBtn = new System.Windows.Forms.Button();
            this.opp4ManualBtn = new System.Windows.Forms.Button();
            this.opp3ManualBtn = new System.Windows.Forms.Button();
            this.opp2ManualBtn = new System.Windows.Forms.Button();
            this.opp8RandomBtn = new System.Windows.Forms.Button();
            this.opp7RandomBtn = new System.Windows.Forms.Button();
            this.opp6RandomBtn = new System.Windows.Forms.Button();
            this.opp5RandomBtn = new System.Windows.Forms.Button();
            this.opp4RandomBtn = new System.Windows.Forms.Button();
            this.opp3RandomBtn = new System.Windows.Forms.Button();
            this.opp2RandomBtn = new System.Windows.Forms.Button();
            this.opp1RandomBtn = new System.Windows.Forms.Button();
            this.opp6ClearBtn = new System.Windows.Forms.Button();
            this.opp7ClearBtn = new System.Windows.Forms.Button();
            this.opp8ClearBtn = new System.Windows.Forms.Button();
            this.opp5ClearBtn = new System.Windows.Forms.Button();
            this.opp4ClearBtn = new System.Windows.Forms.Button();
            this.opp3ClearBtn = new System.Windows.Forms.Button();
            this.opp2ClearBtn = new System.Windows.Forms.Button();
            this.opp1ClearBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compareHandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syntaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 5;
            // 
            // yourCardsConstLabel
            // 
            this.yourCardsConstLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yourCardsConstLabel.AutoSize = true;
            this.yourCardsConstLabel.Location = new System.Drawing.Point(14, 138);
            this.yourCardsConstLabel.Name = "yourCardsConstLabel";
            this.yourCardsConstLabel.Size = new System.Drawing.Size(74, 17);
            this.yourCardsConstLabel.TabIndex = 6;
            this.yourCardsConstLabel.Text = "Your hand";
            // 
            // inputNumberDeals
            // 
            this.inputNumberDeals.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.inputNumberDeals.Location = new System.Drawing.Point(216, 453);
            this.inputNumberDeals.Multiline = true;
            this.inputNumberDeals.Name = "inputNumberDeals";
            this.inputNumberDeals.Size = new System.Drawing.Size(156, 25);
            this.inputNumberDeals.TabIndex = 10;
            this.inputNumberDeals.Text = "1";
            this.inputNumberDeals.TextChanged += new System.EventHandler(this.ValidateInput);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.startButton.Location = new System.Drawing.Point(378, 453);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(110, 54);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "Deal";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.progressBar1.Location = new System.Drawing.Point(17, 484);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(355, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 19;
            // 
            // logo
            // 
            this.logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 40);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(476, 95);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 20;
            this.logo.TabStop = false;
            // 
            // opponentsToolStripMenuItem
            // 
            this.opponentsToolStripMenuItem.Name = "opponentsToolStripMenuItem";
            this.opponentsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // sadsadToolStripMenuItem
            // 
            this.sadsadToolStripMenuItem.Name = "sadsadToolStripMenuItem";
            this.sadsadToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // numberOfDealsInfo
            // 
            this.numberOfDealsInfo.AutoSize = true;
            this.numberOfDealsInfo.Location = new System.Drawing.Point(94, 456);
            this.numberOfDealsInfo.Name = "numberOfDealsInfo";
            this.numberOfDealsInfo.Size = new System.Drawing.Size(116, 17);
            this.numberOfDealsInfo.TabIndex = 45;
            this.numberOfDealsInfo.Text = "Number of deals:";
            // 
            // playerHandInput
            // 
            this.playerHandInput.Location = new System.Drawing.Point(107, 158);
            this.playerHandInput.Name = "playerHandInput";
            this.playerHandInput.Size = new System.Drawing.Size(381, 22);
            this.playerHandInput.TabIndex = 48;
            this.playerHandInput.Tag = "userHand";
            this.playerHandInput.Leave += new System.EventHandler(this.CheckText);
            // 
            // opponent7Input
            // 
            this.opponent7Input.Location = new System.Drawing.Point(107, 397);
            this.opponent7Input.Name = "opponent7Input";
            this.opponent7Input.Size = new System.Drawing.Size(381, 22);
            this.opponent7Input.TabIndex = 49;
            this.opponent7Input.Leave += new System.EventHandler(this.CheckText);
            // 
            // opponent6Input
            // 
            this.opponent6Input.Location = new System.Drawing.Point(107, 369);
            this.opponent6Input.Name = "opponent6Input";
            this.opponent6Input.Size = new System.Drawing.Size(381, 22);
            this.opponent6Input.TabIndex = 50;
            this.opponent6Input.Leave += new System.EventHandler(this.CheckText);
            // 
            // opponent5Input
            // 
            this.opponent5Input.Location = new System.Drawing.Point(107, 341);
            this.opponent5Input.Name = "opponent5Input";
            this.opponent5Input.Size = new System.Drawing.Size(381, 22);
            this.opponent5Input.TabIndex = 51;
            this.opponent5Input.Leave += new System.EventHandler(this.CheckText);
            // 
            // opponent4Input
            // 
            this.opponent4Input.Location = new System.Drawing.Point(107, 313);
            this.opponent4Input.Name = "opponent4Input";
            this.opponent4Input.Size = new System.Drawing.Size(381, 22);
            this.opponent4Input.TabIndex = 52;
            this.opponent4Input.Leave += new System.EventHandler(this.CheckText);
            // 
            // opponent3Input
            // 
            this.opponent3Input.Location = new System.Drawing.Point(107, 285);
            this.opponent3Input.Name = "opponent3Input";
            this.opponent3Input.Size = new System.Drawing.Size(381, 22);
            this.opponent3Input.TabIndex = 53;
            this.opponent3Input.Leave += new System.EventHandler(this.CheckText);
            // 
            // opponent2Input
            // 
            this.opponent2Input.Location = new System.Drawing.Point(107, 257);
            this.opponent2Input.Name = "opponent2Input";
            this.opponent2Input.Size = new System.Drawing.Size(381, 22);
            this.opponent2Input.TabIndex = 54;
            this.opponent2Input.Leave += new System.EventHandler(this.CheckText);
            // 
            // opponent1Input
            // 
            this.opponent1Input.Location = new System.Drawing.Point(107, 229);
            this.opponent1Input.Name = "opponent1Input";
            this.opponent1Input.Size = new System.Drawing.Size(381, 22);
            this.opponent1Input.TabIndex = 55;
            this.opponent1Input.Leave += new System.EventHandler(this.CheckText);
            // 
            // opponent8Input
            // 
            this.opponent8Input.Location = new System.Drawing.Point(107, 425);
            this.opponent8Input.Name = "opponent8Input";
            this.opponent8Input.Size = new System.Drawing.Size(381, 22);
            this.opponent8Input.TabIndex = 57;
            this.opponent8Input.Tag = "";
            this.opponent8Input.Leave += new System.EventHandler(this.CheckText);
            // 
            // randomPlayerHandBtn
            // 
            this.randomPlayerHandBtn.ImageKey = "radnomIcon.jpg";
            this.randomPlayerHandBtn.ImageList = this.icons;
            this.randomPlayerHandBtn.Location = new System.Drawing.Point(51, 158);
            this.randomPlayerHandBtn.Name = "randomPlayerHandBtn";
            this.randomPlayerHandBtn.Size = new System.Drawing.Size(22, 22);
            this.randomPlayerHandBtn.TabIndex = 58;
            this.randomPlayerHandBtn.UseVisualStyleBackColor = true;
            this.randomPlayerHandBtn.Click += new System.EventHandler(this.RandomPlayerHandBtn_Click);
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "radnomIcon.jpg");
            this.icons.Images.SetKeyName(1, "clearIcon.jpg");
            this.icons.Images.SetKeyName(2, "manualIcon.jpg");
            // 
            // clearPlayerHandBtn
            // 
            this.clearPlayerHandBtn.ImageKey = "clearIcon.jpg";
            this.clearPlayerHandBtn.ImageList = this.icons;
            this.clearPlayerHandBtn.Location = new System.Drawing.Point(77, 158);
            this.clearPlayerHandBtn.Name = "clearPlayerHandBtn";
            this.clearPlayerHandBtn.Size = new System.Drawing.Size(22, 22);
            this.clearPlayerHandBtn.TabIndex = 59;
            this.clearPlayerHandBtn.UseVisualStyleBackColor = true;
            this.clearPlayerHandBtn.Click += new System.EventHandler(this.ClearPlayerHandBtn_Click);
            // 
            // manualPlayerHandBtn
            // 
            this.manualPlayerHandBtn.ImageKey = "manualIcon.jpg";
            this.manualPlayerHandBtn.ImageList = this.icons;
            this.manualPlayerHandBtn.Location = new System.Drawing.Point(13, 158);
            this.manualPlayerHandBtn.Name = "manualPlayerHandBtn";
            this.manualPlayerHandBtn.Size = new System.Drawing.Size(34, 22);
            this.manualPlayerHandBtn.TabIndex = 60;
            this.manualPlayerHandBtn.UseVisualStyleBackColor = true;
            this.manualPlayerHandBtn.Click += new System.EventHandler(this.ManualPlayerHandBtn_Click);
            // 
            // opp1ManualBtn
            // 
            this.opp1ManualBtn.ImageKey = "manualIcon.jpg";
            this.opp1ManualBtn.ImageList = this.icons;
            this.opp1ManualBtn.Location = new System.Drawing.Point(13, 229);
            this.opp1ManualBtn.Name = "opp1ManualBtn";
            this.opp1ManualBtn.Size = new System.Drawing.Size(34, 22);
            this.opp1ManualBtn.TabIndex = 61;
            this.opp1ManualBtn.UseVisualStyleBackColor = true;
            this.opp1ManualBtn.Click += new System.EventHandler(this.Opp1ManualBtn_Click);
            // 
            // opp8ManualBtn
            // 
            this.opp8ManualBtn.ImageKey = "manualIcon.jpg";
            this.opp8ManualBtn.ImageList = this.icons;
            this.opp8ManualBtn.Location = new System.Drawing.Point(13, 425);
            this.opp8ManualBtn.Name = "opp8ManualBtn";
            this.opp8ManualBtn.Size = new System.Drawing.Size(34, 22);
            this.opp8ManualBtn.TabIndex = 62;
            this.opp8ManualBtn.UseVisualStyleBackColor = true;
            this.opp8ManualBtn.Click += new System.EventHandler(this.Opp8ManualBtn_Click);
            // 
            // opp7ManualBtn
            // 
            this.opp7ManualBtn.ImageKey = "manualIcon.jpg";
            this.opp7ManualBtn.ImageList = this.icons;
            this.opp7ManualBtn.Location = new System.Drawing.Point(13, 397);
            this.opp7ManualBtn.Name = "opp7ManualBtn";
            this.opp7ManualBtn.Size = new System.Drawing.Size(34, 22);
            this.opp7ManualBtn.TabIndex = 63;
            this.opp7ManualBtn.UseVisualStyleBackColor = true;
            this.opp7ManualBtn.Click += new System.EventHandler(this.Opp7ManualBtn_Click);
            // 
            // opp6ManualBtn
            // 
            this.opp6ManualBtn.ImageKey = "manualIcon.jpg";
            this.opp6ManualBtn.ImageList = this.icons;
            this.opp6ManualBtn.Location = new System.Drawing.Point(13, 369);
            this.opp6ManualBtn.Name = "opp6ManualBtn";
            this.opp6ManualBtn.Size = new System.Drawing.Size(34, 22);
            this.opp6ManualBtn.TabIndex = 64;
            this.opp6ManualBtn.UseVisualStyleBackColor = true;
            this.opp6ManualBtn.Click += new System.EventHandler(this.Opp6ManualBtn_Click);
            // 
            // opp5ManualBtn
            // 
            this.opp5ManualBtn.ImageKey = "manualIcon.jpg";
            this.opp5ManualBtn.ImageList = this.icons;
            this.opp5ManualBtn.Location = new System.Drawing.Point(13, 341);
            this.opp5ManualBtn.Name = "opp5ManualBtn";
            this.opp5ManualBtn.Size = new System.Drawing.Size(34, 22);
            this.opp5ManualBtn.TabIndex = 65;
            this.opp5ManualBtn.UseVisualStyleBackColor = true;
            this.opp5ManualBtn.Click += new System.EventHandler(this.Opp5ManualBtn_Click);
            // 
            // opp4ManualBtn
            // 
            this.opp4ManualBtn.ImageKey = "manualIcon.jpg";
            this.opp4ManualBtn.ImageList = this.icons;
            this.opp4ManualBtn.Location = new System.Drawing.Point(13, 313);
            this.opp4ManualBtn.Name = "opp4ManualBtn";
            this.opp4ManualBtn.Size = new System.Drawing.Size(34, 22);
            this.opp4ManualBtn.TabIndex = 66;
            this.opp4ManualBtn.UseVisualStyleBackColor = true;
            this.opp4ManualBtn.Click += new System.EventHandler(this.Opp4ManualBtn_Click);
            // 
            // opp3ManualBtn
            // 
            this.opp3ManualBtn.ImageKey = "manualIcon.jpg";
            this.opp3ManualBtn.ImageList = this.icons;
            this.opp3ManualBtn.Location = new System.Drawing.Point(13, 285);
            this.opp3ManualBtn.Name = "opp3ManualBtn";
            this.opp3ManualBtn.Size = new System.Drawing.Size(34, 22);
            this.opp3ManualBtn.TabIndex = 67;
            this.opp3ManualBtn.UseVisualStyleBackColor = true;
            this.opp3ManualBtn.Click += new System.EventHandler(this.Opp3ManualBtn_Click);
            // 
            // opp2ManualBtn
            // 
            this.opp2ManualBtn.ImageKey = "manualIcon.jpg";
            this.opp2ManualBtn.ImageList = this.icons;
            this.opp2ManualBtn.Location = new System.Drawing.Point(13, 257);
            this.opp2ManualBtn.Name = "opp2ManualBtn";
            this.opp2ManualBtn.Size = new System.Drawing.Size(34, 22);
            this.opp2ManualBtn.TabIndex = 68;
            this.opp2ManualBtn.UseVisualStyleBackColor = true;
            this.opp2ManualBtn.Click += new System.EventHandler(this.Opp2ManualBtn_Click);
            // 
            // opp8RandomBtn
            // 
            this.opp8RandomBtn.ImageKey = "radnomIcon.jpg";
            this.opp8RandomBtn.ImageList = this.icons;
            this.opp8RandomBtn.Location = new System.Drawing.Point(51, 425);
            this.opp8RandomBtn.Name = "opp8RandomBtn";
            this.opp8RandomBtn.Size = new System.Drawing.Size(22, 22);
            this.opp8RandomBtn.TabIndex = 69;
            this.opp8RandomBtn.UseVisualStyleBackColor = true;
            this.opp8RandomBtn.Click += new System.EventHandler(this.Opp8RandomBtn_Click);
            // 
            // opp7RandomBtn
            // 
            this.opp7RandomBtn.ImageKey = "radnomIcon.jpg";
            this.opp7RandomBtn.ImageList = this.icons;
            this.opp7RandomBtn.Location = new System.Drawing.Point(51, 397);
            this.opp7RandomBtn.Name = "opp7RandomBtn";
            this.opp7RandomBtn.Size = new System.Drawing.Size(22, 22);
            this.opp7RandomBtn.TabIndex = 70;
            this.opp7RandomBtn.UseVisualStyleBackColor = true;
            this.opp7RandomBtn.Click += new System.EventHandler(this.Opp7RandomBtn_Click);
            // 
            // opp6RandomBtn
            // 
            this.opp6RandomBtn.ImageKey = "radnomIcon.jpg";
            this.opp6RandomBtn.ImageList = this.icons;
            this.opp6RandomBtn.Location = new System.Drawing.Point(51, 369);
            this.opp6RandomBtn.Name = "opp6RandomBtn";
            this.opp6RandomBtn.Size = new System.Drawing.Size(22, 22);
            this.opp6RandomBtn.TabIndex = 71;
            this.opp6RandomBtn.UseVisualStyleBackColor = true;
            this.opp6RandomBtn.Click += new System.EventHandler(this.Opp6RandomBtn_Click);
            // 
            // opp5RandomBtn
            // 
            this.opp5RandomBtn.ImageKey = "radnomIcon.jpg";
            this.opp5RandomBtn.ImageList = this.icons;
            this.opp5RandomBtn.Location = new System.Drawing.Point(51, 341);
            this.opp5RandomBtn.Name = "opp5RandomBtn";
            this.opp5RandomBtn.Size = new System.Drawing.Size(22, 22);
            this.opp5RandomBtn.TabIndex = 72;
            this.opp5RandomBtn.UseVisualStyleBackColor = true;
            this.opp5RandomBtn.Click += new System.EventHandler(this.Opp5RandomBtn_Click);
            // 
            // opp4RandomBtn
            // 
            this.opp4RandomBtn.ImageKey = "radnomIcon.jpg";
            this.opp4RandomBtn.ImageList = this.icons;
            this.opp4RandomBtn.Location = new System.Drawing.Point(51, 313);
            this.opp4RandomBtn.Name = "opp4RandomBtn";
            this.opp4RandomBtn.Size = new System.Drawing.Size(22, 22);
            this.opp4RandomBtn.TabIndex = 73;
            this.opp4RandomBtn.UseVisualStyleBackColor = true;
            this.opp4RandomBtn.Click += new System.EventHandler(this.Opp4RandomBtn_Click);
            // 
            // opp3RandomBtn
            // 
            this.opp3RandomBtn.ImageKey = "radnomIcon.jpg";
            this.opp3RandomBtn.ImageList = this.icons;
            this.opp3RandomBtn.Location = new System.Drawing.Point(51, 285);
            this.opp3RandomBtn.Name = "opp3RandomBtn";
            this.opp3RandomBtn.Size = new System.Drawing.Size(22, 22);
            this.opp3RandomBtn.TabIndex = 74;
            this.opp3RandomBtn.UseVisualStyleBackColor = true;
            this.opp3RandomBtn.Click += new System.EventHandler(this.Opp3RandomBtn_Click);
            // 
            // opp2RandomBtn
            // 
            this.opp2RandomBtn.ImageKey = "radnomIcon.jpg";
            this.opp2RandomBtn.ImageList = this.icons;
            this.opp2RandomBtn.Location = new System.Drawing.Point(51, 257);
            this.opp2RandomBtn.Name = "opp2RandomBtn";
            this.opp2RandomBtn.Size = new System.Drawing.Size(22, 22);
            this.opp2RandomBtn.TabIndex = 75;
            this.opp2RandomBtn.UseVisualStyleBackColor = true;
            this.opp2RandomBtn.Click += new System.EventHandler(this.Opp2RandomBtn_Click);
            // 
            // opp1RandomBtn
            // 
            this.opp1RandomBtn.ImageKey = "radnomIcon.jpg";
            this.opp1RandomBtn.ImageList = this.icons;
            this.opp1RandomBtn.Location = new System.Drawing.Point(51, 229);
            this.opp1RandomBtn.Name = "opp1RandomBtn";
            this.opp1RandomBtn.Size = new System.Drawing.Size(22, 22);
            this.opp1RandomBtn.TabIndex = 76;
            this.opp1RandomBtn.UseVisualStyleBackColor = true;
            this.opp1RandomBtn.Click += new System.EventHandler(this.Opp1RandomBtn_Click);
            // 
            // opp6ClearBtn
            // 
            this.opp6ClearBtn.ImageKey = "clearIcon.jpg";
            this.opp6ClearBtn.ImageList = this.icons;
            this.opp6ClearBtn.Location = new System.Drawing.Point(77, 369);
            this.opp6ClearBtn.Name = "opp6ClearBtn";
            this.opp6ClearBtn.Size = new System.Drawing.Size(22, 22);
            this.opp6ClearBtn.TabIndex = 77;
            this.opp6ClearBtn.UseVisualStyleBackColor = true;
            this.opp6ClearBtn.Click += new System.EventHandler(this.Opp6ClearBtn_Click);
            // 
            // opp7ClearBtn
            // 
            this.opp7ClearBtn.ImageKey = "clearIcon.jpg";
            this.opp7ClearBtn.ImageList = this.icons;
            this.opp7ClearBtn.Location = new System.Drawing.Point(77, 397);
            this.opp7ClearBtn.Name = "opp7ClearBtn";
            this.opp7ClearBtn.Size = new System.Drawing.Size(22, 22);
            this.opp7ClearBtn.TabIndex = 78;
            this.opp7ClearBtn.UseVisualStyleBackColor = true;
            this.opp7ClearBtn.Click += new System.EventHandler(this.Opp7ClearBtn_Click);
            // 
            // opp8ClearBtn
            // 
            this.opp8ClearBtn.ImageKey = "clearIcon.jpg";
            this.opp8ClearBtn.ImageList = this.icons;
            this.opp8ClearBtn.Location = new System.Drawing.Point(77, 425);
            this.opp8ClearBtn.Name = "opp8ClearBtn";
            this.opp8ClearBtn.Size = new System.Drawing.Size(22, 22);
            this.opp8ClearBtn.TabIndex = 79;
            this.opp8ClearBtn.UseVisualStyleBackColor = true;
            this.opp8ClearBtn.Click += new System.EventHandler(this.Opp8ClearBtn_Click);
            // 
            // opp5ClearBtn
            // 
            this.opp5ClearBtn.ImageKey = "clearIcon.jpg";
            this.opp5ClearBtn.ImageList = this.icons;
            this.opp5ClearBtn.Location = new System.Drawing.Point(77, 341);
            this.opp5ClearBtn.Name = "opp5ClearBtn";
            this.opp5ClearBtn.Size = new System.Drawing.Size(22, 22);
            this.opp5ClearBtn.TabIndex = 80;
            this.opp5ClearBtn.UseVisualStyleBackColor = true;
            this.opp5ClearBtn.Click += new System.EventHandler(this.Opp5ClearBtn_Click);
            // 
            // opp4ClearBtn
            // 
            this.opp4ClearBtn.ImageKey = "clearIcon.jpg";
            this.opp4ClearBtn.ImageList = this.icons;
            this.opp4ClearBtn.Location = new System.Drawing.Point(77, 313);
            this.opp4ClearBtn.Name = "opp4ClearBtn";
            this.opp4ClearBtn.Size = new System.Drawing.Size(22, 22);
            this.opp4ClearBtn.TabIndex = 81;
            this.opp4ClearBtn.UseVisualStyleBackColor = true;
            this.opp4ClearBtn.Click += new System.EventHandler(this.Opp4ClearBtn_Click);
            // 
            // opp3ClearBtn
            // 
            this.opp3ClearBtn.ImageKey = "clearIcon.jpg";
            this.opp3ClearBtn.ImageList = this.icons;
            this.opp3ClearBtn.Location = new System.Drawing.Point(77, 285);
            this.opp3ClearBtn.Name = "opp3ClearBtn";
            this.opp3ClearBtn.Size = new System.Drawing.Size(22, 22);
            this.opp3ClearBtn.TabIndex = 82;
            this.opp3ClearBtn.UseVisualStyleBackColor = true;
            this.opp3ClearBtn.Click += new System.EventHandler(this.Opp3ClearBtn_Click);
            // 
            // opp2ClearBtn
            // 
            this.opp2ClearBtn.ImageKey = "clearIcon.jpg";
            this.opp2ClearBtn.ImageList = this.icons;
            this.opp2ClearBtn.Location = new System.Drawing.Point(77, 257);
            this.opp2ClearBtn.Name = "opp2ClearBtn";
            this.opp2ClearBtn.Size = new System.Drawing.Size(22, 22);
            this.opp2ClearBtn.TabIndex = 83;
            this.opp2ClearBtn.UseVisualStyleBackColor = true;
            this.opp2ClearBtn.Click += new System.EventHandler(this.Opp2ClearBtn_Click);
            // 
            // opp1ClearBtn
            // 
            this.opp1ClearBtn.ImageKey = "clearIcon.jpg";
            this.opp1ClearBtn.ImageList = this.icons;
            this.opp1ClearBtn.Location = new System.Drawing.Point(77, 229);
            this.opp1ClearBtn.Name = "opp1ClearBtn";
            this.opp1ClearBtn.Size = new System.Drawing.Size(22, 22);
            this.opp1ClearBtn.TabIndex = 84;
            this.opp1ClearBtn.UseVisualStyleBackColor = true;
            this.opp1ClearBtn.Click += new System.EventHandler(this.Opp1ClearBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 85;
            this.label1.Text = "Opponents\' hands";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 28);
            this.menuStrip1.TabIndex = 86;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compareHandsToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // compareHandsToolStripMenuItem
            // 
            this.compareHandsToolStripMenuItem.Name = "compareHandsToolStripMenuItem";
            this.compareHandsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.compareHandsToolStripMenuItem.Text = "Compare hands";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.syntaxToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.HistoryToolStripMenuItem_Click);
            // 
            // syntaxToolStripMenuItem
            // 
            this.syntaxToolStripMenuItem.Name = "syntaxToolStripMenuItem";
            this.syntaxToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.syntaxToolStripMenuItem.Text = "Syntax";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // TexasHoldEmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opp1ClearBtn);
            this.Controls.Add(this.opp2ClearBtn);
            this.Controls.Add(this.opp3ClearBtn);
            this.Controls.Add(this.opp4ClearBtn);
            this.Controls.Add(this.opp5ClearBtn);
            this.Controls.Add(this.opp8ClearBtn);
            this.Controls.Add(this.opp7ClearBtn);
            this.Controls.Add(this.opp6ClearBtn);
            this.Controls.Add(this.opp1RandomBtn);
            this.Controls.Add(this.opp2RandomBtn);
            this.Controls.Add(this.opp3RandomBtn);
            this.Controls.Add(this.opp4RandomBtn);
            this.Controls.Add(this.opp5RandomBtn);
            this.Controls.Add(this.opp6RandomBtn);
            this.Controls.Add(this.opp7RandomBtn);
            this.Controls.Add(this.opp8RandomBtn);
            this.Controls.Add(this.opp2ManualBtn);
            this.Controls.Add(this.opp3ManualBtn);
            this.Controls.Add(this.opp4ManualBtn);
            this.Controls.Add(this.opp5ManualBtn);
            this.Controls.Add(this.opp6ManualBtn);
            this.Controls.Add(this.opp7ManualBtn);
            this.Controls.Add(this.opp8ManualBtn);
            this.Controls.Add(this.opp1ManualBtn);
            this.Controls.Add(this.manualPlayerHandBtn);
            this.Controls.Add(this.clearPlayerHandBtn);
            this.Controls.Add(this.randomPlayerHandBtn);
            this.Controls.Add(this.opponent8Input);
            this.Controls.Add(this.opponent1Input);
            this.Controls.Add(this.opponent2Input);
            this.Controls.Add(this.opponent3Input);
            this.Controls.Add(this.opponent4Input);
            this.Controls.Add(this.opponent5Input);
            this.Controls.Add(this.opponent6Input);
            this.Controls.Add(this.opponent7Input);
            this.Controls.Add(this.playerHandInput);
            this.Controls.Add(this.numberOfDealsInfo);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.inputNumberDeals);
            this.Controls.Add(this.yourCardsConstLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TexasHoldEmForm";
            this.Tag = "";
            this.Text = "PDOA Texas Hold\'em";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseLogger);
            this.Load += new System.EventHandler(this.LoadLogger);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label yourCardsConstLabel;
        private System.Windows.Forms.TextBox inputNumberDeals;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.ToolStripMenuItem opponentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sadsadToolStripMenuItem;
        private System.Windows.Forms.Label numberOfDealsInfo;
        private System.Windows.Forms.TextBox playerHandInput;
        private System.Windows.Forms.TextBox opponent7Input;
        private System.Windows.Forms.TextBox opponent6Input;
        private System.Windows.Forms.TextBox opponent5Input;
        private System.Windows.Forms.TextBox opponent4Input;
        private System.Windows.Forms.TextBox opponent3Input;
        private System.Windows.Forms.TextBox opponent2Input;
        private System.Windows.Forms.TextBox opponent1Input;
        private System.Windows.Forms.TextBox opponent8Input;
        private System.Windows.Forms.Button randomPlayerHandBtn;
        private System.Windows.Forms.Button clearPlayerHandBtn;
        private System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.Button manualPlayerHandBtn;
        private System.Windows.Forms.Button opp1ManualBtn;
        private System.Windows.Forms.Button opp8ManualBtn;
        private System.Windows.Forms.Button opp7ManualBtn;
        private System.Windows.Forms.Button opp6ManualBtn;
        private System.Windows.Forms.Button opp5ManualBtn;
        private System.Windows.Forms.Button opp4ManualBtn;
        private System.Windows.Forms.Button opp3ManualBtn;
        private System.Windows.Forms.Button opp2ManualBtn;
        private System.Windows.Forms.Button opp8RandomBtn;
        private System.Windows.Forms.Button opp7RandomBtn;
        private System.Windows.Forms.Button opp6RandomBtn;
        private System.Windows.Forms.Button opp5RandomBtn;
        private System.Windows.Forms.Button opp4RandomBtn;
        private System.Windows.Forms.Button opp3RandomBtn;
        private System.Windows.Forms.Button opp2RandomBtn;
        private System.Windows.Forms.Button opp1RandomBtn;
        private System.Windows.Forms.Button opp6ClearBtn;
        private System.Windows.Forms.Button opp7ClearBtn;
        private System.Windows.Forms.Button opp8ClearBtn;
        private System.Windows.Forms.Button opp5ClearBtn;
        private System.Windows.Forms.Button opp4ClearBtn;
        private System.Windows.Forms.Button opp3ClearBtn;
        private System.Windows.Forms.Button opp2ClearBtn;
        private System.Windows.Forms.Button opp1ClearBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compareHandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem syntaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

