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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SelectInterpolation_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(271, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(271, 20);
            this.textBox2.TabIndex = 4;
            // 
            // SelectInterpolation_button
            // 
            this.SelectInterpolation_button.Location = new System.Drawing.Point(289, 170);
            this.SelectInterpolation_button.Name = "SelectInterpolation_button";
            this.SelectInterpolation_button.Size = new System.Drawing.Size(75, 23);
            this.SelectInterpolation_button.TabIndex = 5;
            this.SelectInterpolation_button.Text = "Select";
            this.SelectInterpolation_button.UseVisualStyleBackColor = true;
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
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Interpolation type DLL:";
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 212);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectInterpolation_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button SelectInterpolation_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}