using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_CP.Presenter
{
    public static class FileFunctions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="format"> file format </param>
        /// <returns> path to chosen file </returns>
        public static string Open(string format)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            string _filePath;
        
            openFile.Title = @"Read data from...";
            openFile.Filter = @"Files(*." + format + @")|*." + format;

            DialogResult check = openFile.ShowDialog();
            
            switch (check)
            {
                case DialogResult.OK:
                    _filePath = openFile.FileName;
                    break;
                case DialogResult.Cancel:
                    _filePath = null;
                    break;
                default:
                    _filePath = null;
                    throw new Exception("Error opening file!");
            }

            return _filePath;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="format"> file format </param>
        /// <returns> path to chosen file </returns>
        private static string Save(string format)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            
            string _filePath;

            saveFile.Title = @"Save data like...";
            saveFile.Filter = @"Files(*." + format + @")|*." + format;

            saveFile.OverwritePrompt = true;
            saveFile.CheckPathExists = true;
            
            DialogResult check = saveFile.ShowDialog();

            switch (check)
            {
                case DialogResult.OK:
                    _filePath = saveFile.FileName;
                    break;
                case DialogResult.Cancel:
                    _filePath = null;
                    break;
                default:
                    _filePath = null;
                    throw new Exception("Error saving file!");
            }

            return _filePath;
        }
    }
}
