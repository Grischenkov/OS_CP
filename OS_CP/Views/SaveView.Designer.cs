namespace OS_CP
{
    partial class SaveView
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
            this.SaveChartImage_checkBox = new System.Windows.Forms.CheckBox();
            this.SaveValuesTable_checkBox = new System.Windows.Forms.CheckBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveChartImage_checkBox
            // 
            this.SaveChartImage_checkBox.AutoSize = true;
            this.SaveChartImage_checkBox.Location = new System.Drawing.Point(12, 55);
            this.SaveChartImage_checkBox.Name = "SaveChartImage_checkBox";
            this.SaveChartImage_checkBox.Size = new System.Drawing.Size(109, 17);
            this.SaveChartImage_checkBox.TabIndex = 3;
            this.SaveChartImage_checkBox.Text = "Save chart image";
            this.SaveChartImage_checkBox.UseVisualStyleBackColor = true;
            // 
            // SaveValuesTable_checkBox
            // 
            this.SaveValuesTable_checkBox.AutoSize = true;
            this.SaveValuesTable_checkBox.Location = new System.Drawing.Point(12, 12);
            this.SaveValuesTable_checkBox.Name = "SaveValuesTable_checkBox";
            this.SaveValuesTable_checkBox.Size = new System.Drawing.Size(111, 17);
            this.SaveValuesTable_checkBox.TabIndex = 2;
            this.SaveValuesTable_checkBox.Text = "Save values table";
            this.SaveValuesTable_checkBox.UseVisualStyleBackColor = true;
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(12, 98);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(122, 23);
            this.Save_button.TabIndex = 4;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            // 
            // SaveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(147, 133);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.SaveChartImage_checkBox);
            this.Controls.Add(this.SaveValuesTable_checkBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox SaveChartImage_checkBox;
        private System.Windows.Forms.CheckBox SaveValuesTable_checkBox;
        private System.Windows.Forms.Button Save_button;
    }
}