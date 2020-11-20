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
        /// Getting/Setting Math type DLL path
        /// </summary>
        public string MathDLLPath { get => MathDLL_textBox.Text; set => MathDLL_textBox.Text = value; }
        
        /// <summary>
        /// 
        /// </summary>
        public SettingsView()
        {
            InitializeComponent();

            ShowProcessVideo_checkBox.CheckedChanged += (sender, args) => Action(VideoShowing);
            ShowLoadScreen_checkBox.CheckedChanged += (sender, args) => Action(LoadShowing);
            SelectMath_button.Click += (sender, args) => Action(SelectMath);
            SelectExport_button.Click += (sender, args) => Action(SelectExport);
            DiscardMathDll.Click += (sender, args) => Action(DiscardMath);
            DiscardExportDll.Click += (sender, args) => Action(DiscardExport);
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
        /// Selecting Math type DLL
        /// </summary>
        public event Action SelectMath;

        /// <summary>
        /// Discarding Export type DLL
        /// </summary>
        public event Action DiscardExport;

        /// <summary>
        /// Discarding Math type DLL
        /// </summary>
        public event Action DiscardMath;
        
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
            catch (FileDialogCancelException)
            {
                //ignored
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
