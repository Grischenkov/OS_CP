namespace OS_CP
{
    /// <summary>
    /// Class of program for work with about screen
    /// </summary>
    partial class AboutView
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
            this.Author = new System.Windows.Forms.Label();
            this.Discription_third_line = new System.Windows.Forms.Label();
            this.Discription_second_line = new System.Windows.Forms.Label();
            this.Discription_first_line = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Author.Location = new System.Drawing.Point(12, 318);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(400, 15);
            this.Author.TabIndex = 12;
            this.Author.Text = "Grishchenkov Nikita Dmitrievich, gr.№ 485, 2020, SPB SI Of Technology. ";
            // 
            // Discription_third_line
            // 
            this.Discription_third_line.AutoSize = true;
            this.Discription_third_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discription_third_line.Location = new System.Drawing.Point(15, 202);
            this.Discription_third_line.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.Discription_third_line.Name = "Discription_third_line";
            this.Discription_third_line.Size = new System.Drawing.Size(250, 17);
            this.Discription_third_line.TabIndex = 11;
            this.Discription_third_line.Text = "export data to MS Excel and MS Word.";
            // 
            // Discription_second_line
            // 
            this.Discription_second_line.AutoSize = true;
            this.Discription_second_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discription_second_line.Location = new System.Drawing.Point(15, 171);
            this.Discription_second_line.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.Discription_second_line.Name = "Discription_second_line";
            this.Discription_second_line.Size = new System.Drawing.Size(289, 17);
            this.Discription_second_line.TabIndex = 10;
            this.Discription_second_line.Text = "parameters of the technological process and";
            // 
            // Discription_first_line
            // 
            this.Discription_first_line.AutoSize = true;
            this.Discription_first_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discription_first_line.Location = new System.Drawing.Point(15, 140);
            this.Discription_first_line.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.Discription_first_line.Name = "Discription_first_line";
            this.Discription_first_line.Size = new System.Drawing.Size(332, 17);
            this.Discription_first_line.TabIndex = 9;
            this.Discription_first_line.Text = "This program provides the ability to monitor specific";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(1, 9);
            this.Title.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(486, 63);
            this.Title.TabIndex = 8;
            this.Title.Text = "Operating Systems";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(15, 339);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(133, 13);
            this.Version.TabIndex = 13;
            this.Version.Text = "Version: 1.4    16/11/2020";
            // 
            // AboutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Discription_third_line);
            this.Controls.Add(this.Discription_second_line);
            this.Controls.Add(this.Discription_first_line);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label Discription_third_line;
        private System.Windows.Forms.Label Discription_second_line;
        private System.Windows.Forms.Label Discription_first_line;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Version;
    }
}