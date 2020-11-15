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
    /// Class of program for work with settings screen
    /// </summary>
    public partial class SettingsView : Form, ISettingsView
    {
        /// <summary>
        /// 
        /// </summary>
        public bool ShowVideo { get => ShowProcessVideo_checkBox.Checked; set => ShowProcessVideo_checkBox.Checked = value; }

        /// <summary>
        /// 
        /// </summary>
        public bool ShowLoad { get => ShowLoadScreen_checkBox.Checked; set => ShowLoadScreen_checkBox.Checked = value; }

        /// <summary>
        /// Getting/Setting Export type DLL path
        /// </summary>
        public string ExportDLLPath { get => ExportDLL_textBox.Text; set => ExportDLL_textBox.Text = value; }

        /// <summary>
        /// Getting/Setting Interpolation type DLL path
        /// </summary>
        public string InterpolationDLLPath { get => InterpolationDLL_textBox.Text; set => InterpolationDLL_textBox.Text = value; }
        
        /// <summary>
        /// 
        /// </summary>
        public SettingsView()
        {
            InitializeComponent();

            ShowProcessVideo_checkBox.CheckedChanged += (sender, args) => Action(VideoShowing);
            ShowLoadScreen_checkBox.CheckedChanged += (sender, args) => Action(LoadShowing);
            SelectInterpolation_button.Click += (sender, args) => Action(SelectInterpolation);
            SelectExport_button.Click += (sender, args) => Action(SelectExport);
        }

        /// <summary>
        /// Editing load settings
        /// </summary>
        public event Action LoadShowing;

        /// <summary>
        /// Editing video settings
        /// </summary>
        public event Action VideoShowing;

        /// <summary>
        /// Selecting Export type DLL
        /// </summary>
        public event Action SelectExport;

        /// <summary>
        /// Selecting Interpolation type DLL
        /// </summary>
        public event Action SelectInterpolation;

        /// <summary>
        /// Action
        /// </summary>
        /// <param name="action"> Action </param>
        private void Action(Action action)
        {
            try
            {
                action?.Invoke();
            }
            catch (Exception e)
            {
                ShowError(e.Message);
            }
        }

        /// <summary>
        /// Showing message about error  
        /// </summary>
        /// <param name="errorMessage"> Error message </param>
        public void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Showing message about warning 
        /// </summary>
        /// <param name="warningMessage"> Warning message </param>
        public void ShowWarning(string warningMessage)
        {
            MessageBox.Show(warningMessage, @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Showing message about success
        /// </summary>
        /// <param name="successMessage"> Success message </param>
        public void ShowSuccess(string successMessage)
        {
            MessageBox.Show(successMessage, @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
