namespace PokerDealingOddsAnalyserApp
{
    partial class HistoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.handHistoryGrid = new System.Windows.Forms.DataGridView();
            this.handViewTemplateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dealDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.handViewTemplateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeDealtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealsCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.handHistoryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handViewTemplateBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handViewTemplateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // handHistoryGrid
            // 
            this.handHistoryGrid.AllowUserToAddRows = false;
            this.handHistoryGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.handHistoryGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.handHistoryGrid.AutoGenerateColumns = false;
            this.handHistoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.handHistoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeDealtDataGridViewTextBoxColumn,
            this.dealNumberDataGridViewTextBoxColumn,
            this.dealsCountDataGridViewTextBoxColumn,
            this.playerHandDataGridViewTextBoxColumn});
            this.handHistoryGrid.DataSource = this.handViewTemplateBindingSource1;
            this.handHistoryGrid.Location = new System.Drawing.Point(2, 2);
            this.handHistoryGrid.Name = "handHistoryGrid";
            this.handHistoryGrid.ReadOnly = true;
            this.handHistoryGrid.RowHeadersWidth = 51;
            this.handHistoryGrid.RowTemplate.Height = 24;
            this.handHistoryGrid.Size = new System.Drawing.Size(588, 624);
            this.handHistoryGrid.TabIndex = 0;
            this.handHistoryGrid.SelectionChanged += new System.EventHandler(this.ShowHandFullReport);
            // 
            // handViewTemplateBindingSource1
            // 
            this.handViewTemplateBindingSource1.DataSource = typeof(PokerDealingOddsAnalyser.Core.Logging.HandViewTemplate);
            // 
            // dealDataBindingSource
            // 
            this.dealDataBindingSource.DataMember = "DealData";
            this.dealDataBindingSource.DataSource = this.handViewTemplateBindingSource1;
            // 
            // handViewTemplateBindingSource
            // 
            this.handViewTemplateBindingSource.DataSource = typeof(PokerDealingOddsAnalyser.Core.Logging.HandViewTemplate);
            // 
            // timeDealtDataGridViewTextBoxColumn
            // 
            this.timeDealtDataGridViewTextBoxColumn.DataPropertyName = "TimeDealt";
            this.timeDealtDataGridViewTextBoxColumn.Frozen = true;
            this.timeDealtDataGridViewTextBoxColumn.HeaderText = "TimeDealt";
            this.timeDealtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDealtDataGridViewTextBoxColumn.Name = "timeDealtDataGridViewTextBoxColumn";
            this.timeDealtDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeDealtDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.timeDealtDataGridViewTextBoxColumn.Width = 155;
            // 
            // dealNumberDataGridViewTextBoxColumn
            // 
            this.dealNumberDataGridViewTextBoxColumn.DataPropertyName = "DealNumber";
            this.dealNumberDataGridViewTextBoxColumn.Frozen = true;
            this.dealNumberDataGridViewTextBoxColumn.HeaderText = "DealNumber";
            this.dealNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dealNumberDataGridViewTextBoxColumn.Name = "dealNumberDataGridViewTextBoxColumn";
            this.dealNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.dealNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dealNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // dealsCountDataGridViewTextBoxColumn
            // 
            this.dealsCountDataGridViewTextBoxColumn.DataPropertyName = "DealsCount";
            this.dealsCountDataGridViewTextBoxColumn.Frozen = true;
            this.dealsCountDataGridViewTextBoxColumn.HeaderText = "DealsCount";
            this.dealsCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dealsCountDataGridViewTextBoxColumn.Name = "dealsCountDataGridViewTextBoxColumn";
            this.dealsCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.dealsCountDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dealsCountDataGridViewTextBoxColumn.Width = 125;
            // 
            // playerHandDataGridViewTextBoxColumn
            // 
            this.playerHandDataGridViewTextBoxColumn.DataPropertyName = "PlayerHand";
            this.playerHandDataGridViewTextBoxColumn.Frozen = true;
            this.playerHandDataGridViewTextBoxColumn.HeaderText = "PlayerHand";
            this.playerHandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.playerHandDataGridViewTextBoxColumn.Name = "playerHandDataGridViewTextBoxColumn";
            this.playerHandDataGridViewTextBoxColumn.ReadOnly = true;
            this.playerHandDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.playerHandDataGridViewTextBoxColumn.Width = 125;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 630);
            this.Controls.Add(this.handHistoryGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.handHistoryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handViewTemplateBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handViewTemplateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource handViewTemplateBindingSource;
        private System.Windows.Forms.DataGridView handHistoryGrid;
        private System.Windows.Forms.BindingSource handViewTemplateBindingSource1;
        private System.Windows.Forms.BindingSource dealDataBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDealtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealsCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerHandDataGridViewTextBoxColumn;
    }
}