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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Table = new System.Windows.Forms.DataGridView();
            this.Calculate_button = new System.Windows.Forms.Button();
            this.Function_name = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.File_toolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_toolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings_button = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_button = new System.Windows.Forms.ToolStripMenuItem();
            this.About_button = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_button = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_button = new System.Windows.Forms.ToolStripMenuItem();
            this.Export_button = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit_button = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(789, 126);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1103, 906);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Chart";
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(12, 126);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(771, 906);
            this.Table.TabIndex = 1;
            // 
            // Calculate_button
            // 
            this.Calculate_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calculate_button.Location = new System.Drawing.Point(646, 80);
            this.Calculate_button.Name = "Calculate_button";
            this.Calculate_button.Size = new System.Drawing.Size(137, 23);
            this.Calculate_button.TabIndex = 2;
            this.Calculate_button.Text = "Calculate";
            this.Calculate_button.UseVisualStyleBackColor = true;
            // 
            // Function_name
            // 
            this.Function_name.AutoSize = true;
            this.Function_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Function_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Function_name.Location = new System.Drawing.Point(12, 55);
            this.Function_name.Name = "Function_name";
            this.Function_name.Size = new System.Drawing.Size(344, 51);
            this.Function_name.TabIndex = 4;
            this.Function_name.Text = "Current function";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_toolStrip,
            this.Help_toolStrip});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1904, 24);
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
            this.Settings_button.Size = new System.Drawing.Size(180, 22);
            this.Settings_button.Text = "Settings";
            // 
            // Help_button
            // 
            this.Help_button.Name = "Help_button";
            this.Help_button.Size = new System.Drawing.Size(180, 22);
            this.Help_button.Text = "Help";
            // 
            // About_button
            // 
            this.About_button.Name = "About_button";
            this.About_button.Size = new System.Drawing.Size(180, 22);
            this.About_button.Text = "About";
            // 
            // Open_button
            // 
            this.Open_button.Name = "Open_button";
            this.Open_button.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Open_button.Size = new System.Drawing.Size(180, 22);
            this.Open_button.Text = "Open";
            // 
            // Save_button
            // 
            this.Save_button.Name = "Save_button";
            this.Save_button.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Save_button.Size = new System.Drawing.Size(180, 22);
            this.Save_button.Text = "Save";
            // 
            // Export_button
            // 
            this.Export_button.Name = "Export_button";
            this.Export_button.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.Export_button.Size = new System.Drawing.Size(180, 22);
            this.Export_button.Text = "Export";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // Exit_button
            // 
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.Exit_button.Size = new System.Drawing.Size(180, 22);
            this.Exit_button.Text = "Exit";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Function_name);
            this.Controls.Add(this.Calculate_button);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button Calculate_button;
        private System.Windows.Forms.Label Function_name;
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
    }
}

