namespace OS_CP
{
    /// <summary>
    /// Class of program for work with main screen
    /// </summary>
    partial class MainView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Table = new System.Windows.Forms.DataGridView();
            this.Expense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Сoncentration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calculate_button = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.File_toolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_button = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_button = new System.Windows.Forms.ToolStripMenuItem();
            this.Export_button = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit_button = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_toolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings_button = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.Help_button = new System.Windows.Forms.ToolStripMenuItem();
            this.About_button = new System.Windows.Forms.ToolStripMenuItem();
            this.Clean_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chart
            // 
            this.Chart.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            chartArea7.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea7);
            this.Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend7.Name = "Legend1";
            this.Chart.Legends.Add(legend7);
            this.Chart.Location = new System.Drawing.Point(465, 3);
            this.Chart.Name = "Chart";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.Chart.Series.Add(series7);
            this.Chart.Size = new System.Drawing.Size(1072, 810);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "Chart";
            // 
            // Table
            // 
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Expense,
            this.Deviation,
            this.Сoncentration});
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Location = new System.Drawing.Point(3, 246);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(450, 480);
            this.Table.TabIndex = 1;
            // 
            // Expense
            // 
            this.Expense.HeaderText = "Expense";
            this.Expense.Name = "Expense";
            // 
            // Deviation
            // 
            this.Deviation.HeaderText = "Deviation";
            this.Deviation.Name = "Deviation";
            // 
            // Сoncentration
            // 
            this.Сoncentration.HeaderText = "Сoncentration";
            this.Сoncentration.Name = "Сoncentration";
            // 
            // Calculate_button
            // 
            this.Calculate_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calculate_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Calculate_button.Location = new System.Drawing.Point(3, 3);
            this.Calculate_button.Name = "Calculate_button";
            this.Calculate_button.Size = new System.Drawing.Size(444, 31);
            this.Calculate_button.TabIndex = 2;
            this.Calculate_button.Text = "Calculate";
            this.Calculate_button.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_toolStrip,
            this.Help_toolStrip});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1540, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip";
            // 
            // File_toolStrip
            // 
            this.File_toolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open_button,
            this.Save_button,
            this.Export_button,
            this.toolStripMenuItem3,
            this.Exit_button});
            this.File_toolStrip.Name = "File_toolStrip";
            this.File_toolStrip.Size = new System.Drawing.Size(37, 20);
            this.File_toolStrip.Text = "File";
            // 
            // Open_button
            // 
            this.Open_button.Name = "Open_button";
            this.Open_button.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Open_button.Size = new System.Drawing.Size(148, 22);
            this.Open_button.Text = "Open";
            // 
            // Save_button
            // 
            this.Save_button.Name = "Save_button";
            this.Save_button.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Save_button.Size = new System.Drawing.Size(148, 22);
            this.Save_button.Text = "Save";
            // 
            // Export_button
            // 
            this.Export_button.Name = "Export_button";
            this.Export_button.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.Export_button.Size = new System.Drawing.Size(148, 22);
            this.Export_button.Text = "Export";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(145, 6);
            // 
            // Exit_button
            // 
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.Exit_button.Size = new System.Drawing.Size(148, 22);
            this.Exit_button.Text = "Exit";
            // 
            // Help_toolStrip
            // 
            this.Help_toolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Settings_button,
            this.toolStripMenuItem2,
            this.Help_button,
            this.About_button});
            this.Help_toolStrip.Name = "Help_toolStrip";
            this.Help_toolStrip.Size = new System.Drawing.Size(44, 20);
            this.Help_toolStrip.Text = "Help";
            // 
            // Settings_button
            // 
            this.Settings_button.Name = "Settings_button";
            this.Settings_button.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.Settings_button.Size = new System.Drawing.Size(188, 22);
            this.Settings_button.Text = "Settings";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(185, 6);
            // 
            // Help_button
            // 
            this.Help_button.Name = "Help_button";
            this.Help_button.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.Help_button.Size = new System.Drawing.Size(188, 22);
            this.Help_button.Text = "Help";
            // 
            // About_button
            // 
            this.About_button.Name = "About_button";
            this.About_button.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.About_button.Size = new System.Drawing.Size(188, 22);
            this.About_button.Text = "About";
            // 
            // Clean_button
            // 
            this.Clean_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clean_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clean_button.Location = new System.Drawing.Point(3, 40);
            this.Clean_button.Name = "Clean_button";
            this.Clean_button.Size = new System.Drawing.Size(444, 32);
            this.Clean_button.TabIndex = 7;
            this.Clean_button.Text = "Clean";
            this.Clean_button.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Chart, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1540, 816);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(3, 3);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(450, 237);
            this.axWindowsMediaPlayer.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Table, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.axWindowsMediaPlayer, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(456, 810);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.Calculate_button, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Clean_button, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 732);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(450, 75);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 840);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button Calculate_button;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem File_toolStrip;
        private System.Windows.Forms.ToolStripMenuItem Open_button;
        private System.Windows.Forms.ToolStripMenuItem Save_button;
        private System.Windows.Forms.ToolStripMenuItem Export_button;
        private System.Windows.Forms.ToolStripMenuItem Help_toolStrip;
        private System.Windows.Forms.ToolStripMenuItem Settings_button;
        private System.Windows.Forms.ToolStripMenuItem Help_button;
        private System.Windows.Forms.ToolStripMenuItem About_button;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem Exit_button;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expense;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Сoncentration;
        private System.Windows.Forms.Button Clean_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

