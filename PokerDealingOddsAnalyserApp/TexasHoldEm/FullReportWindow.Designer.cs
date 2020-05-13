using System.Windows.Forms;

namespace PokerDealingOddsAnalyserApp
{
    partial class FullReportWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FullReportWindow));
            this.flopData = new System.Windows.Forms.ListBox();
            this.turnData = new System.Windows.Forms.ListBox();
            this.roundData = new System.Windows.Forms.ListBox();
            this.flopChartReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.turnChartReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.roundChartReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.oppHandsView = new System.Windows.Forms.ListView();
            this.allCardsList = new System.Windows.Forms.ImageList(this.components);
            this.winOddsListBox = new System.Windows.Forms.ListBox();
            this.playerHandInfo = new System.Windows.Forms.Label();
            this.firstCardPicture = new System.Windows.Forms.PictureBox();
            this.secondCardPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flopChartReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnChartReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundChartReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstCardPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCardPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // flopData
            // 
            this.flopData.Enabled = false;
            this.flopData.FormattingEnabled = true;
            this.flopData.ItemHeight = 16;
            this.flopData.Location = new System.Drawing.Point(12, 383);
            this.flopData.Name = "flopData";
            this.flopData.Size = new System.Drawing.Size(393, 164);
            this.flopData.TabIndex = 3;
            // 
            // turnData
            // 
            this.turnData.Enabled = false;
            this.turnData.FormattingEnabled = true;
            this.turnData.ItemHeight = 16;
            this.turnData.Location = new System.Drawing.Point(422, 383);
            this.turnData.Name = "turnData";
            this.turnData.Size = new System.Drawing.Size(393, 164);
            this.turnData.TabIndex = 4;
            // 
            // roundData
            // 
            this.roundData.Enabled = false;
            this.roundData.FormattingEnabled = true;
            this.roundData.ItemHeight = 16;
            this.roundData.Location = new System.Drawing.Point(832, 383);
            this.roundData.Name = "roundData";
            this.roundData.Size = new System.Drawing.Size(393, 164);
            this.roundData.TabIndex = 5;
            // 
            // flopChartReport
            // 
            this.flopChartReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flopChartReport.BorderlineColor = System.Drawing.Color.Black;
            this.flopChartReport.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.flopChartReport.BorderlineWidth = 5;
            chartArea1.Name = "ChartArea1";
            this.flopChartReport.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.flopChartReport.Legends.Add(legend1);
            this.flopChartReport.Location = new System.Drawing.Point(12, 12);
            this.flopChartReport.Name = "flopChartReport";
            series1.ChartArea = "ChartArea1";
            series1.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series1.Legend = "Legend1";
            series1.Name = "High card";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.ChartArea = "ChartArea1";
            series2.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series2.Legend = "Legend1";
            series2.Name = "One pair";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series3.ChartArea = "ChartArea1";
            series3.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series3.Legend = "Legend1";
            series3.Name = "Two pairs";
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series4.ChartArea = "ChartArea1";
            series4.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series4.Legend = "Legend1";
            series4.Name = "Set";
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series5.ChartArea = "ChartArea1";
            series5.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series5.Legend = "Legend1";
            series5.Name = "Straight";
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series6.ChartArea = "ChartArea1";
            series6.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series6.Legend = "Legend1";
            series6.Name = "Flush";
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series7.ChartArea = "ChartArea1";
            series7.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series7.Legend = "Legend1";
            series7.Name = "Full house";
            series7.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series8.ChartArea = "ChartArea1";
            series8.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series8.Legend = "Legend1";
            series8.Name = "Quads";
            series8.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series9.ChartArea = "ChartArea1";
            series9.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series9.Legend = "Legend1";
            series9.Name = "Straight flush";
            series9.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series10.ChartArea = "ChartArea1";
            series10.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series10.Legend = "Legend1";
            series10.Name = "Royal flush";
            series10.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.flopChartReport.Series.Add(series1);
            this.flopChartReport.Series.Add(series2);
            this.flopChartReport.Series.Add(series3);
            this.flopChartReport.Series.Add(series4);
            this.flopChartReport.Series.Add(series5);
            this.flopChartReport.Series.Add(series6);
            this.flopChartReport.Series.Add(series7);
            this.flopChartReport.Series.Add(series8);
            this.flopChartReport.Series.Add(series9);
            this.flopChartReport.Series.Add(series10);
            this.flopChartReport.Size = new System.Drawing.Size(393, 365);
            this.flopChartReport.TabIndex = 15;
            this.flopChartReport.Text = "chart1";
            this.flopChartReport.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            title1.Font = new System.Drawing.Font("Wide Latin", 20F);
            title1.Name = "Title1";
            title1.Text = "Flop chart report";
            title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.flopChartReport.Titles.Add(title1);
            this.flopChartReport.Visible = false;
            // 
            // turnChartReport
            // 
            this.turnChartReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.turnChartReport.BorderlineColor = System.Drawing.Color.Black;
            this.turnChartReport.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.turnChartReport.BorderlineWidth = 5;
            chartArea2.Name = "ChartArea1";
            this.turnChartReport.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.turnChartReport.Legends.Add(legend2);
            this.turnChartReport.Location = new System.Drawing.Point(422, 12);
            this.turnChartReport.Name = "turnChartReport";
            series11.ChartArea = "ChartArea1";
            series11.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series11.Legend = "Legend1";
            series11.Name = "High card";
            series11.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series12.ChartArea = "ChartArea1";
            series12.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series12.Legend = "Legend1";
            series12.Name = "One pair";
            series12.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series13.ChartArea = "ChartArea1";
            series13.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series13.Legend = "Legend1";
            series13.Name = "Two pairs";
            series13.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series14.ChartArea = "ChartArea1";
            series14.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series14.Legend = "Legend1";
            series14.Name = "Set";
            series14.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series15.ChartArea = "ChartArea1";
            series15.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series15.Legend = "Legend1";
            series15.Name = "Straight";
            series15.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series16.ChartArea = "ChartArea1";
            series16.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series16.Legend = "Legend1";
            series16.Name = "Flush";
            series16.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series17.ChartArea = "ChartArea1";
            series17.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series17.Legend = "Legend1";
            series17.Name = "Full house";
            series17.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series18.ChartArea = "ChartArea1";
            series18.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series18.Legend = "Legend1";
            series18.Name = "Quads";
            series18.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series19.ChartArea = "ChartArea1";
            series19.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series19.Legend = "Legend1";
            series19.Name = "Straight flush";
            series19.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series20.ChartArea = "ChartArea1";
            series20.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series20.Legend = "Legend1";
            series20.Name = "Royal flush";
            series20.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.turnChartReport.Series.Add(series11);
            this.turnChartReport.Series.Add(series12);
            this.turnChartReport.Series.Add(series13);
            this.turnChartReport.Series.Add(series14);
            this.turnChartReport.Series.Add(series15);
            this.turnChartReport.Series.Add(series16);
            this.turnChartReport.Series.Add(series17);
            this.turnChartReport.Series.Add(series18);
            this.turnChartReport.Series.Add(series19);
            this.turnChartReport.Series.Add(series20);
            this.turnChartReport.Size = new System.Drawing.Size(393, 365);
            this.turnChartReport.TabIndex = 16;
            this.turnChartReport.Text = "chart1";
            this.turnChartReport.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            title2.Font = new System.Drawing.Font("Wide Latin", 20F);
            title2.Name = "Title1";
            title2.Text = "Turn chart report";
            title2.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.turnChartReport.Titles.Add(title2);
            this.turnChartReport.Visible = false;
            // 
            // roundChartReport
            // 
            this.roundChartReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.roundChartReport.BorderlineColor = System.Drawing.Color.Black;
            this.roundChartReport.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.roundChartReport.BorderlineWidth = 5;
            chartArea3.Name = "ChartArea1";
            this.roundChartReport.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.roundChartReport.Legends.Add(legend3);
            this.roundChartReport.Location = new System.Drawing.Point(832, 12);
            this.roundChartReport.Name = "roundChartReport";
            series21.ChartArea = "ChartArea1";
            series21.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series21.Legend = "Legend1";
            series21.Name = "High card";
            series21.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series22.ChartArea = "ChartArea1";
            series22.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series22.Legend = "Legend1";
            series22.Name = "One pair";
            series22.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series23.ChartArea = "ChartArea1";
            series23.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series23.Legend = "Legend1";
            series23.Name = "Two pairs";
            series23.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series24.ChartArea = "ChartArea1";
            series24.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series24.Legend = "Legend1";
            series24.Name = "Set";
            series24.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series25.ChartArea = "ChartArea1";
            series25.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series25.Legend = "Legend1";
            series25.Name = "Straight";
            series25.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series26.ChartArea = "ChartArea1";
            series26.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series26.Legend = "Legend1";
            series26.Name = "Flush";
            series26.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series27.ChartArea = "ChartArea1";
            series27.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series27.Legend = "Legend1";
            series27.Name = "Full house";
            series27.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series28.ChartArea = "ChartArea1";
            series28.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series28.Legend = "Legend1";
            series28.Name = "Quads";
            series28.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series29.ChartArea = "ChartArea1";
            series29.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series29.Legend = "Legend1";
            series29.Name = "Straight flush";
            series29.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series30.ChartArea = "ChartArea1";
            series30.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series30.Legend = "Legend1";
            series30.Name = "Royal flush";
            series30.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.roundChartReport.Series.Add(series21);
            this.roundChartReport.Series.Add(series22);
            this.roundChartReport.Series.Add(series23);
            this.roundChartReport.Series.Add(series24);
            this.roundChartReport.Series.Add(series25);
            this.roundChartReport.Series.Add(series26);
            this.roundChartReport.Series.Add(series27);
            this.roundChartReport.Series.Add(series28);
            this.roundChartReport.Series.Add(series29);
            this.roundChartReport.Series.Add(series30);
            this.roundChartReport.Size = new System.Drawing.Size(393, 365);
            this.roundChartReport.TabIndex = 17;
            this.roundChartReport.Text = "chart1";
            this.roundChartReport.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            title3.Font = new System.Drawing.Font("Wide Latin", 20F);
            title3.Name = "Title1";
            title3.Text = "Round chart report";
            title3.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.roundChartReport.Titles.Add(title3);
            this.roundChartReport.Visible = false;
            // 
            // oppHandsView
            // 
            this.oppHandsView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.oppHandsView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.oppHandsView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oppHandsView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oppHandsView.HideSelection = false;
            this.oppHandsView.LargeImageList = this.allCardsList;
            this.oppHandsView.Location = new System.Drawing.Point(12, 553);
            this.oppHandsView.Name = "oppHandsView";
            this.oppHandsView.Size = new System.Drawing.Size(393, 342);
            this.oppHandsView.SmallImageList = this.allCardsList;
            this.oppHandsView.StateImageList = this.allCardsList;
            this.oppHandsView.TabIndex = 47;
            this.oppHandsView.UseCompatibleStateImageBehavior = false;
            this.oppHandsView.Visible = false;
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
            // winOddsListBox
            // 
            this.winOddsListBox.FormattingEnabled = true;
            this.winOddsListBox.ItemHeight = 16;
            this.winOddsListBox.Location = new System.Drawing.Point(422, 554);
            this.winOddsListBox.Name = "winOddsListBox";
            this.winOddsListBox.Size = new System.Drawing.Size(393, 340);
            this.winOddsListBox.TabIndex = 48;
            // 
            // playerHandInfo
            // 
            this.playerHandInfo.AutoSize = true;
            this.playerHandInfo.Location = new System.Drawing.Point(993, 575);
            this.playerHandInfo.Name = "playerHandInfo";
            this.playerHandInfo.Size = new System.Drawing.Size(77, 17);
            this.playerHandInfo.TabIndex = 49;
            this.playerHandInfo.Text = "Your cards";
            // 
            // firstCardPicture
            // 
            this.firstCardPicture.Location = new System.Drawing.Point(890, 595);
            this.firstCardPicture.Name = "firstCardPicture";
            this.firstCardPicture.Size = new System.Drawing.Size(138, 211);
            this.firstCardPicture.TabIndex = 50;
            this.firstCardPicture.TabStop = false;
            // 
            // secondCardPicture
            // 
            this.secondCardPicture.Location = new System.Drawing.Point(1034, 595);
            this.secondCardPicture.Name = "secondCardPicture";
            this.secondCardPicture.Size = new System.Drawing.Size(138, 211);
            this.secondCardPicture.TabIndex = 51;
            this.secondCardPicture.TabStop = false;
            // 
            // FullReportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 907);
            this.Controls.Add(this.secondCardPicture);
            this.Controls.Add(this.firstCardPicture);
            this.Controls.Add(this.playerHandInfo);
            this.Controls.Add(this.winOddsListBox);
            this.Controls.Add(this.oppHandsView);
            this.Controls.Add(this.roundChartReport);
            this.Controls.Add(this.turnChartReport);
            this.Controls.Add(this.flopChartReport);
            this.Controls.Add(this.roundData);
            this.Controls.Add(this.turnData);
            this.Controls.Add(this.flopData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FullReportWindow";
            this.Text = "Full Report";
            ((System.ComponentModel.ISupportInitialize)(this.flopChartReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnChartReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundChartReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstCardPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCardPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox flopData;
        private System.Windows.Forms.ListBox turnData;
        private System.Windows.Forms.ListBox roundData;
        private System.Windows.Forms.DataVisualization.Charting.Chart flopChartReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart turnChartReport;
        public System.Windows.Forms.DataVisualization.Charting.Chart roundChartReport;
        private System.Windows.Forms.ListView oppHandsView;
        private System.Windows.Forms.ImageList allCardsList;
        private System.Windows.Forms.ListBox winOddsListBox;
        private Label playerHandInfo;
        private PictureBox firstCardPicture;
        private PictureBox secondCardPicture;
    }
}