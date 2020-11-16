using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OS_CP.Presenter;

namespace OS_CP
{
    /// <summary>
    /// Class of program for work with help screen
    /// </summary>
    public partial class HelpView : Form, IHelpView
    {
        /// <summary>
        /// Base constructor
        /// </summary>
        public HelpView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Showing help screen
        /// </summary>
        public new void Show()
        {
            this.ShowDialog();
        }
    }
}
