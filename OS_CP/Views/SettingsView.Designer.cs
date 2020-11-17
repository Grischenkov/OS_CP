namespace OS_CP
{
    /// <summary>
    /// Class of program for work with settings screen
    /// </summary>
    partial class SettingsView
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
            this.ShowProcessVideo_checkBox = new System.Windows.Forms.CheckBox();
            this.ShowLoadScreen_checkBox = new System.Windows.Forms.CheckBox();
            this.SelectExport_button = new System.Windows.Forms.Button();
            this.ExportDLL_textBox = new System.Windows.Forms.TextBox();
            this.MathDLL_textBox = new System.Windows.Forms.TextBox();
            this.SelectMath_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DiscardExportDll = new System.Windows.Forms.Label();
            this.DiscardMathDll = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowProcessVideo_checkBox
            // 
            this.ShowProcessVideo_checkBox.AutoSize = true;
            this.ShowProcessVideo_checkBox.Location = new System.Drawing.Point(12, 12);
            this.ShowProcessVideo_checkBox.Name = "ShowProcessVideo_checkBox";
            this.ShowProcessVideo_checkBox.Size = new System.Drawing.Size(122, 17);
            this.ShowProcessVideo_checkBox.TabIndex = 0;
            this.ShowProcessVideo_checkBox.Text = "Show process video";
            this.ShowProcessVideo_checkBox.UseVisualStyleBackColor = true;
            // 
            // ShowLoadScreen_checkBox
            // 
            this.ShowLoadScreen_checkBox.AutoSize = true;
            this.ShowLoadScreen_checkBox.Location = new System.Drawing.Point(12, 55);
            this.ShowLoadScreen_checkBox.Name = "ShowLoadScreen_checkBox";
            this.ShowLoadScreen_checkBox.Size = new System.Drawing.Size(111, 17);
            this.ShowLoadScreen_checkBox.TabIndex = 1;
            this.ShowLoadScreen_checkBox.Text = "Show load screen";
            this.ShowLoadScreen_checkBox.UseVisualStyleBackColor = true;
            // 
            // SelectExport_button
            // 
            this.SelectExport_button.Location = new System.Drawing.Point(289, 110);
            this.SelectExport_button.Name = "SelectExport_button";
            this.SelectExport_button.Size = new System.Drawing.Size(75, 23);
            this.SelectExport_button.TabIndex = 2;
            this.SelectExport_button.Text = "Select";
            this.SelectExport_button.UseVisualStyleBackColor = true;
            // 
            // ExportDLL_textBox
            // 
            this.ExportDLL_textBox.Location = new System.Drawing.Point(12, 112);
            this.ExportDLL_textBox.Name = "ExportDLL_textBox";
            this.ExportDLL_textBox.ReadOnly = true;
            this.ExportDLL_textBox.Size = new System.Drawing.Size(271, 20);
            this.ExportDLL_textBox.TabIndex = 3;
            // 
            // MathDLL_textBox
            // 
            this.MathDLL_textBox.Location = new System.Drawing.Point(12, 172);
            this.MathDLL_textBox.Name = "MathDLL_textBox";
            this.MathDLL_textBox.ReadOnly = true;
            this.MathDLL_textBox.Size = new System.Drawing.Size(271, 20);
            this.MathDLL_textBox.TabIndex = 4;
            // 
            // SelectMath_button
            // 
            this.SelectMath_button.Location = new System.Drawing.Point(289, 170);
            this.SelectMath_button.Name = "SelectMath_button";
            this.SelectMath_button.Size = new System.Drawing.Size(75, 23);
            this.SelectMath_button.TabIndex = 5;
            this.SelectMath_button.Text = "Select";
            this.SelectMath_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Export type DLL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Math type DLL:";
            // 
            // DiscardExportDll
            // 
            this.DiscardExportDll.AutoSize = true;
            this.DiscardExportDll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiscardExportDll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscardExportDll.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DiscardExportDll.Location = new System.Drawing.Point(370, 115);
            this.DiscardExportDll.Name = "DiscardExportDll";
            this.DiscardExportDll.Size = new System.Drawing.Size(43, 13);
            this.DiscardExportDll.TabIndex = 8;
            this.DiscardExportDll.Text = "Discard";
            // 
            // DiscardMathDll
            // 
            this.DiscardMathDll.AutoSize = true;
            this.DiscardMathDll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiscardMathDll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscardMathDll.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DiscardMathDll.Location = new System.Drawing.Point(370, 175);
            this.DiscardMathDll.Name = "DiscardMathDll";
            this.DiscardMathDll.Size = new System.Drawing.Size(43, 13);
            this.DiscardMathDll.TabIndex = 9;
            this.DiscardMathDll.Text = "Discard";
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 212);
            this.Controls.Add(this.DiscardMathDll);
            this.Controls.Add(this.DiscardExportDll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectMath_button);
            this.Controls.Add(this.MathDLL_textBox);
            this.Controls.Add(this.ExportDLL_textBox);
            this.Controls.Add(this.SelectExport_button);
            this.Controls.Add(this.ShowLoadScreen_checkBox);
            this.Controls.Add(this.ShowProcessVideo_checkBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ShowProcessVideo_checkBox;
        private System.Windows.Forms.CheckBox ShowLoadScreen_checkBox;
        private System.Windows.Forms.Button SelectExport_button;
        private System.Windows.Forms.TextBox ExportDLL_textBox;
        private System.Windows.Forms.TextBox MathDLL_textBox;
        private System.Windows.Forms.Button SelectMath_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DiscardExportDll;
        private System.Windows.Forms.Label DiscardMathDll;
    }
}