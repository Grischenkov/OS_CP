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
    public partial class SaveView : Form, ISaveView
    {
        /// <summary>
        /// 
        /// </summary>
        public bool SaveValueTable { get => SaveValuesTable_checkBox.Checked; set => SaveValuesTable_checkBox.Checked = value; }

        /// <summary>
        /// 
        /// </summary>
        public bool SaveChartImage { get => SaveChartImage_checkBox.Checked; set => SaveChartImage_checkBox.Checked = value; }

        /// <summary>
        /// 
        /// </summary>
        public bool SaveChartImageEnabled { set => SaveChartImage_checkBox.Enabled = value; }

        /// <summary>
        /// 
        /// </summary>
        public SaveView()
        {
            InitializeComponent();
            Save_button.Click += (sender, args) => Action(Save);
        }


        /// <summary>
        /// Discarding Interpolation type DLL
        /// </summary>
        public event Action Save;

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
