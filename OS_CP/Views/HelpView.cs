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
    /// Class of program for work with help screen
    /// </summary>
    public partial class HelpView : Form, IHelpView
    {
        /// <summary>
        /// 
        /// </summary>
        public string TextInfo { set => Info_textBox.Text = value; }

        /// <summary>
        /// Base constructor
        /// </summary>
        public HelpView()
        {
            InitializeComponent();

            BasicInfo_button.Click += (sender, args) => Action(BasicInfo);
            LoadingData_button.Click += (sender, args) => Action(LoadingData);
            SavingData_button.Click += (sender, args) => Action(SavingData);
            Export_button.Click += (sender, args) => Action(Export);
            Math_button.Click += (sender, args) => Action(Math);
            ForDevelopers_button.Click += (sender, args) => Action(ForDevelopers);
        }

        /// <summary>
        /// Editing load settings
        /// </summary>
        public event Action BasicInfo;

        /// <summary>
        /// Editing video settings
        /// </summary>
        public event Action LoadingData;

        /// <summary>
        /// Selecting Export type DLL
        /// </summary>
        public event Action SavingData;

        /// <summary>
        /// Selecting Interpolation type DLL
        /// </summary>
        public event Action Export;

        /// <summary>
        /// Discarding Export type DLL
        /// </summary>
        public event Action Math;

        /// <summary>
        /// Discarding Interpolation type DLL
        /// </summary>
        public event Action ForDevelopers;

        /// <summary>
        /// Showing help screen
        /// </summary>
        public new void Show()
        {
            this.ShowDialog();
        }

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
