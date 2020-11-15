using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OS_CP.Presenter;

namespace OS_CP
{
    public partial class SplashView : Form, ISplashView
    {
        /// <summary>
        /// Base constructor
        /// </summary>
        public SplashView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Showing splash screen
        /// </summary>
        public new void Show()
        {
            Thread thread = new Thread(Start);
            thread.Start();
            Thread.Sleep(5000);
            thread.Abort();
        }

        /// <summary>
        /// Starting application 
        /// </summary>
        private void Start()
        {
            Application.Run(this);
        }
    }
}
