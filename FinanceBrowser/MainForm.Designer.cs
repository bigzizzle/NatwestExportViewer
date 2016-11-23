namespace FinanceBrowser
{
    partial class MainForm
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
            this.TabBox = new System.Windows.Forms.TabControl();
            this.OverviewTab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalCashflowBox = new System.Windows.Forms.TextBox();
            this.TotalExpenditureBox = new System.Windows.Forms.TextBox();
            this.TotalIncomeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExpenditureBySourcePage = new System.Windows.Forms.TabPage();
            this.IncomeBySourcePage = new System.Windows.Forms.TabPage();
            this.AllTransactionsPage = new System.Windows.Forms.TabPage();
            this.ReportGenerationTab = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCSVDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TotalIncomeCountBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalExpenditureCountBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label9 = new System.Windows.Forms.Label();
            this.IncomeTransactionsPerSource = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.IncomeIndividualTransactions = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.ExpenditureTransactionsPerSource = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.ExpenditureIndividualTransactions = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TabBox.SuspendLayout();
            this.OverviewTab.SuspendLayout();
            this.ExpenditureBySourcePage.SuspendLayout();
            this.IncomeBySourcePage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabBox
            // 
            this.TabBox.Controls.Add(this.OverviewTab);
            this.TabBox.Controls.Add(this.ExpenditureBySourcePage);
            this.TabBox.Controls.Add(this.IncomeBySourcePage);
            this.TabBox.Controls.Add(this.AllTransactionsPage);
            this.TabBox.Controls.Add(this.ReportGenerationTab);
            this.TabBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabBox.HotTrack = true;
            this.TabBox.Location = new System.Drawing.Point(0, 24);
            this.TabBox.Name = "TabBox";
            this.TabBox.SelectedIndex = 0;
            this.TabBox.Size = new System.Drawing.Size(895, 725);
            this.TabBox.TabIndex = 0;
            // 
            // OverviewTab
            // 
            this.OverviewTab.Controls.Add(this.TotalExpenditureCountBox);
            this.OverviewTab.Controls.Add(this.label7);
            this.OverviewTab.Controls.Add(this.TotalIncomeCountBox);
            this.OverviewTab.Controls.Add(this.label6);
            this.OverviewTab.Controls.Add(this.label5);
            this.OverviewTab.Controls.Add(this.TotalCashflowBox);
            this.OverviewTab.Controls.Add(this.TotalExpenditureBox);
            this.OverviewTab.Controls.Add(this.TotalIncomeBox);
            this.OverviewTab.Controls.Add(this.label3);
            this.OverviewTab.Controls.Add(this.label2);
            this.OverviewTab.Controls.Add(this.label1);
            this.OverviewTab.Location = new System.Drawing.Point(4, 22);
            this.OverviewTab.Name = "OverviewTab";
            this.OverviewTab.Padding = new System.Windows.Forms.Padding(3);
            this.OverviewTab.Size = new System.Drawing.Size(887, 699);
            this.OverviewTab.TabIndex = 0;
            this.OverviewTab.Text = "Overview";
            this.OverviewTab.UseVisualStyleBackColor = true;
            this.OverviewTab.Click += new System.EventHandler(this.OverviewTab_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Graph Over Time Here";
            // 
            // TotalCashflowBox
            // 
            this.TotalCashflowBox.Location = new System.Drawing.Point(141, 78);
            this.TotalCashflowBox.Name = "TotalCashflowBox";
            this.TotalCashflowBox.ReadOnly = true;
            this.TotalCashflowBox.Size = new System.Drawing.Size(158, 20);
            this.TotalCashflowBox.TabIndex = 5;
            // 
            // TotalExpenditureBox
            // 
            this.TotalExpenditureBox.Location = new System.Drawing.Point(141, 52);
            this.TotalExpenditureBox.Name = "TotalExpenditureBox";
            this.TotalExpenditureBox.ReadOnly = true;
            this.TotalExpenditureBox.Size = new System.Drawing.Size(158, 20);
            this.TotalExpenditureBox.TabIndex = 4;
            // 
            // TotalIncomeBox
            // 
            this.TotalIncomeBox.Location = new System.Drawing.Point(141, 26);
            this.TotalIncomeBox.Name = "TotalIncomeBox";
            this.TotalIncomeBox.ReadOnly = true;
            this.TotalIncomeBox.Size = new System.Drawing.Size(158, 20);
            this.TotalIncomeBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Net Cashflow:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Expenditure:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Income:";
            // 
            // ExpenditureBySourcePage
            // 
            this.ExpenditureBySourcePage.Controls.Add(this.splitContainer1);
            this.ExpenditureBySourcePage.Location = new System.Drawing.Point(4, 22);
            this.ExpenditureBySourcePage.Name = "ExpenditureBySourcePage";
            this.ExpenditureBySourcePage.Size = new System.Drawing.Size(887, 699);
            this.ExpenditureBySourcePage.TabIndex = 1;
            this.ExpenditureBySourcePage.Text = "Expenditure";
            this.ExpenditureBySourcePage.UseVisualStyleBackColor = true;
            // 
            // IncomeBySourcePage
            // 
            this.IncomeBySourcePage.Controls.Add(this.splitContainer2);
            this.IncomeBySourcePage.Location = new System.Drawing.Point(4, 22);
            this.IncomeBySourcePage.Name = "IncomeBySourcePage";
            this.IncomeBySourcePage.Size = new System.Drawing.Size(887, 699);
            this.IncomeBySourcePage.TabIndex = 2;
            this.IncomeBySourcePage.Text = "Income";
            this.IncomeBySourcePage.UseVisualStyleBackColor = true;
            // 
            // AllTransactionsPage
            // 
            this.AllTransactionsPage.Location = new System.Drawing.Point(4, 22);
            this.AllTransactionsPage.Name = "AllTransactionsPage";
            this.AllTransactionsPage.Size = new System.Drawing.Size(887, 699);
            this.AllTransactionsPage.TabIndex = 3;
            this.AllTransactionsPage.Text = "All Transactions";
            this.AllTransactionsPage.UseVisualStyleBackColor = true;
            // 
            // ReportGenerationTab
            // 
            this.ReportGenerationTab.Location = new System.Drawing.Point(4, 22);
            this.ReportGenerationTab.Name = "ReportGenerationTab";
            this.ReportGenerationTab.Size = new System.Drawing.Size(887, 699);
            this.ReportGenerationTab.TabIndex = 4;
            this.ReportGenerationTab.Text = "Report Generation";
            this.ReportGenerationTab.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCSVDirectoryToolStripMenuItem,
            this.toolStripSeparator3,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadCSVDirectoryToolStripMenuItem
            // 
            this.loadCSVDirectoryToolStripMenuItem.Name = "loadCSVDirectoryToolStripMenuItem";
            this.loadCSVDirectoryToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.loadCSVDirectoryToolStripMenuItem.Text = "Load CSV Directory ...";
            this.loadCSVDirectoryToolStripMenuItem.Click += new System.EventHandler(this.loadCSVDirectoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(184, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // TotalIncomeCountBox
            // 
            this.TotalIncomeCountBox.Location = new System.Drawing.Point(484, 26);
            this.TotalIncomeCountBox.Name = "TotalIncomeCountBox";
            this.TotalIncomeCountBox.ReadOnly = true;
            this.TotalIncomeCountBox.Size = new System.Drawing.Size(158, 20);
            this.TotalIncomeCountBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Income Transactions:";
            // 
            // TotalExpenditureCountBox
            // 
            this.TotalExpenditureCountBox.Location = new System.Drawing.Point(484, 52);
            this.TotalExpenditureCountBox.Name = "TotalExpenditureCountBox";
            this.TotalExpenditureCountBox.ReadOnly = true;
            this.TotalExpenditureCountBox.Size = new System.Drawing.Size(158, 20);
            this.TotalExpenditureCountBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total Expenditure Transactions:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.IncomeTransactionsPerSource);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label10);
            this.splitContainer2.Panel2.Controls.Add(this.IncomeIndividualTransactions);
            this.splitContainer2.Size = new System.Drawing.Size(887, 699);
            this.splitContainer2.SplitterDistance = 348;
            this.splitContainer2.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Transactions Per Source";
            // 
            // IncomeTransactionsPerSource
            // 
            this.IncomeTransactionsPerSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IncomeTransactionsPerSource.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.IncomeTransactionsPerSource.FullRowSelect = true;
            this.IncomeTransactionsPerSource.GridLines = true;
            this.IncomeTransactionsPerSource.Location = new System.Drawing.Point(0, 23);
            this.IncomeTransactionsPerSource.Name = "IncomeTransactionsPerSource";
            this.IncomeTransactionsPerSource.Size = new System.Drawing.Size(887, 322);
            this.IncomeTransactionsPerSource.TabIndex = 1;
            this.IncomeTransactionsPerSource.UseCompatibleStateImageBehavior = false;
            this.IncomeTransactionsPerSource.View = System.Windows.Forms.View.Details;
            this.IncomeTransactionsPerSource.SelectedIndexChanged += new System.EventHandler(this.IncomeTransactionsPerSource_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Source";
            this.columnHeader7.Width = 347;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Total Amount";
            this.columnHeader8.Width = 289;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Total Transactions";
            this.columnHeader9.Width = 223;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Individual Transactions";
            // 
            // IncomeIndividualTransactions
            // 
            this.IncomeIndividualTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IncomeIndividualTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.IncomeIndividualTransactions.FullRowSelect = true;
            this.IncomeIndividualTransactions.GridLines = true;
            this.IncomeIndividualTransactions.Location = new System.Drawing.Point(0, 25);
            this.IncomeIndividualTransactions.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.IncomeIndividualTransactions.Name = "IncomeIndividualTransactions";
            this.IncomeIndividualTransactions.Size = new System.Drawing.Size(887, 325);
            this.IncomeIndividualTransactions.TabIndex = 3;
            this.IncomeIndividualTransactions.UseCompatibleStateImageBehavior = false;
            this.IncomeIndividualTransactions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Date";
            this.columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Total";
            this.columnHeader11.Width = 155;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Description";
            this.columnHeader12.Width = 602;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.ExpenditureTransactionsPerSource);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.ExpenditureIndividualTransactions);
            this.splitContainer2.Size = new System.Drawing.Size(887, 699);
            this.splitContainer1.SplitterDistance = 346;
            this.splitContainer1.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Transactions Per Source";
            // 
            // ExpenditureTransactionsPerSource
            // 
            this.ExpenditureTransactionsPerSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpenditureTransactionsPerSource.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ExpenditureTransactionsPerSource.FullRowSelect = true;
            this.ExpenditureTransactionsPerSource.GridLines = true;
            this.ExpenditureTransactionsPerSource.Location = new System.Drawing.Point(0, 23);
            this.ExpenditureTransactionsPerSource.Name = "ExpenditureTransactionsPerSource";
            this.ExpenditureTransactionsPerSource.Size = new System.Drawing.Size(881, 320);
            this.ExpenditureTransactionsPerSource.TabIndex = 1;
            this.ExpenditureTransactionsPerSource.UseCompatibleStateImageBehavior = false;
            this.ExpenditureTransactionsPerSource.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Source";
            this.columnHeader1.Width = 347;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Total Amount";
            this.columnHeader2.Width = 289;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total Transactions";
            this.columnHeader3.Width = 223;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Individual Transactions";
            // 
            // ExpenditureIndividualTransactions
            // 
            this.ExpenditureIndividualTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpenditureIndividualTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.ExpenditureIndividualTransactions.FullRowSelect = true;
            this.ExpenditureIndividualTransactions.GridLines = true;
            this.ExpenditureIndividualTransactions.Location = new System.Drawing.Point(0, 25);
            this.ExpenditureIndividualTransactions.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ExpenditureIndividualTransactions.Name = "ExpenditureIndividualTransactions";
            this.ExpenditureIndividualTransactions.Size = new System.Drawing.Size(881, 321);
            this.ExpenditureIndividualTransactions.TabIndex = 3;
            this.ExpenditureIndividualTransactions.UseCompatibleStateImageBehavior = false;
            this.ExpenditureIndividualTransactions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total";
            this.columnHeader5.Width = 155;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Description";
            this.columnHeader6.Width = 602;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 749);
            this.Controls.Add(this.TabBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Finance Viewer";
            this.TabBox.ResumeLayout(false);
            this.OverviewTab.ResumeLayout(false);
            this.OverviewTab.PerformLayout();
            this.ExpenditureBySourcePage.ResumeLayout(false);
            this.IncomeBySourcePage.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabBox;
        private System.Windows.Forms.TabPage OverviewTab;
        private System.Windows.Forms.TabPage ExpenditureBySourcePage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCSVDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TotalCashflowBox;
        private System.Windows.Forms.TextBox TotalExpenditureBox;
        private System.Windows.Forms.TextBox TotalIncomeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage IncomeBySourcePage;
        private System.Windows.Forms.TabPage AllTransactionsPage;
        private System.Windows.Forms.TabPage ReportGenerationTab;
        private System.Windows.Forms.TextBox TotalExpenditureCountBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TotalIncomeCountBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView IncomeTransactionsPerSource;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView IncomeIndividualTransactions;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView ExpenditureTransactionsPerSource;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView ExpenditureIndividualTransactions;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

