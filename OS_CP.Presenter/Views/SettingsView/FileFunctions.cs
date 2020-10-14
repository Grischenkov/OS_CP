using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_CP.Presenter
{
    /// <summary>
    /// Specific presenter interface for Settings view
    /// </summary>
    public sealed partial class SettingsPresenter
    {
        private string _filePath; //Path to file

        OpenFileDialog openFile = new OpenFileDialog();
        SaveFileDialog saveFile = new SaveFileDialog();

        private string OpenDLL(string format)
        {
            _filePath = null;

            openFile.Title = @"Read source data from...";
            openFile.Filter = @"Files(*." + format + @")|*." + format;
            
            DialogResult check = openFile.ShowDialog();
            switch (check)
            {
                case DialogResult.OK:
                    _filePath = openFile.FileName;
                    break;
                case DialogResult.Cancel:
                    _filePath = null;
                    throw new Exception("Reading canceled.");
                default:
                    _filePath = null;
                    throw new Exception("Error opening file!");
            }

            return _filePath;
        }
    }
}
