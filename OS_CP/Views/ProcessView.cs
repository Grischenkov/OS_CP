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
    public partial class ProcessView : Form, IProcessView
    {
        public ProcessView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Showing splash screen
        /// </summary>
        public new void Show()
        {
            this.ShowDialog();
        }
    }
}
