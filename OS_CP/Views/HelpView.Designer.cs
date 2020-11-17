namespace OS_CP
{
    /// <summary>
    /// Class of program for work with help screen
    /// </summary>
    partial class HelpView
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
            this.LoadingData_button = new System.Windows.Forms.Button();
            this.Info_textBox = new System.Windows.Forms.TextBox();
            this.SavingData_button = new System.Windows.Forms.Button();
            this.Export_button = new System.Windows.Forms.Button();
            this.Math_button = new System.Windows.Forms.Button();
            this.ForDevelopers_button = new System.Windows.Forms.Button();
            this.BasicInfo_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadingData_button
            // 
            this.LoadingData_button.Location = new System.Drawing.Point(100, 18);
            this.LoadingData_button.Name = "LoadingData_button";
            this.LoadingData_button.Size = new System.Drawing.Size(85, 23);
            this.LoadingData_button.TabIndex = 0;
            this.LoadingData_button.Text = "Loading data";
            this.LoadingData_button.UseVisualStyleBackColor = true;
            // 
            // Info_textBox
            // 
            this.Info_textBox.Location = new System.Drawing.Point(12, 42);
            this.Info_textBox.Multiline = true;
            this.Info_textBox.Name = "Info_textBox";
            this.Info_textBox.ReadOnly = true;
            this.Info_textBox.Size = new System.Drawing.Size(760, 407);
            this.Info_textBox.TabIndex = 3;
            // 
            // SavingData_button
            // 
            this.SavingData_button.Location = new System.Drawing.Point(188, 18);
            this.SavingData_button.Name = "SavingData_button";
            this.SavingData_button.Size = new System.Drawing.Size(85, 23);
            this.SavingData_button.TabIndex = 4;
            this.SavingData_button.Text = "Saving data";
            this.SavingData_button.UseVisualStyleBackColor = true;
            // 
            // Export_button
            // 
            this.Export_button.Location = new System.Drawing.Point(276, 18);
            this.Export_button.Name = "Export_button";
            this.Export_button.Size = new System.Drawing.Size(85, 23);
            this.Export_button.TabIndex = 5;
            this.Export_button.Text = "Export";
            this.Export_button.UseVisualStyleBackColor = true;
            // 
            // Math_button
            // 
            this.Math_button.Location = new System.Drawing.Point(364, 18);
            this.Math_button.Name = "Math_button";
            this.Math_button.Size = new System.Drawing.Size(85, 23);
            this.Math_button.TabIndex = 6;
            this.Math_button.Text = "Math";
            this.Math_button.UseVisualStyleBackColor = true;
            // 
            // ForDevelopers_button
            // 
            this.ForDevelopers_button.Location = new System.Drawing.Point(452, 18);
            this.ForDevelopers_button.Name = "ForDevelopers_button";
            this.ForDevelopers_button.Size = new System.Drawing.Size(85, 23);
            this.ForDevelopers_button.TabIndex = 7;
            this.ForDevelopers_button.Text = "For developers";
            this.ForDevelopers_button.UseVisualStyleBackColor = true;
            // 
            // BasicInfo_button
            // 
            this.BasicInfo_button.Location = new System.Drawing.Point(12, 18);
            this.BasicInfo_button.Name = "BasicInfo_button";
            this.BasicInfo_button.Size = new System.Drawing.Size(85, 23);
            this.BasicInfo_button.TabIndex = 8;
            this.BasicInfo_button.Text = "Basic info";
            this.BasicInfo_button.UseVisualStyleBackColor = true;
            // 
            // HelpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.BasicInfo_button);
            this.Controls.Add(this.ForDevelopers_button);
            this.Controls.Add(this.Math_button);
            this.Controls.Add(this.Export_button);
            this.Controls.Add(this.SavingData_button);
            this.Controls.Add(this.Info_textBox);
            this.Controls.Add(this.LoadingData_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadingData_button;
        private System.Windows.Forms.TextBox Info_textBox;
        private System.Windows.Forms.Button SavingData_button;
        private System.Windows.Forms.Button Export_button;
        private System.Windows.Forms.Button Math_button;
        private System.Windows.Forms.Button ForDevelopers_button;
        private System.Windows.Forms.Button BasicInfo_button;
    }
}