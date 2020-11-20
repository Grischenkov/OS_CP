using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OS_CP.Presenter;

namespace OS_CP
{
    /// <summary>
    /// Class of program for work with about screen
    /// </summary>
    public sealed partial class AboutView : Form, IAboutView
    {
        /// <summary>
        /// Base constructor
        /// </summary>
        public AboutView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Showing about screen
        /// </summary>
        public new void Show()
        {
            this.ShowDialog();
        }
    }
}
