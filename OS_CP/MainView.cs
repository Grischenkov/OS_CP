﻿using System;
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
    /// Class of program for work with main screen
    /// </summary>s
    public partial class MainView : Form, IMainView
    {
        /// <summary>
        /// Base constructor
        /// </summary>
        public MainView()
        {
            InitializeComponent();
        }
    }
}
