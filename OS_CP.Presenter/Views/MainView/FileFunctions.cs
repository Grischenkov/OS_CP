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
    /// Specific presenter interface for Main view
    /// </summary>
    public sealed partial class MainPresenter
    {
        private string _filePath; //Path to file
        
        OpenFileDialog openFile = new OpenFileDialog();
        SaveFileDialog saveFile = new SaveFileDialog();
        
        /// <summary>
        /// Reading value table from file
        /// </summary>
        /// <returns></returns>
        private double[][] OpenFile()
        {
            double[][] table = null;
            
            openFile.Title = @"Read source data from...";
            openFile.Filter = @"Text files(*.txt)|*.txt";
            DialogResult check = openFile.ShowDialog();
            if (check == DialogResult.OK)
            {
                _filePath = openFile.FileName;
                using (StreamReader sr = new StreamReader(_filePath))
                {
                    int i = 0;
                    do
                    {
                        string str = sr.ReadLine();
                        i++;
                    } while (!sr.EndOfStream);

                    table = new double[i][];
                    i = 0;

                    do
                    {
                        string str = sr.ReadLine();
                        if (!string.IsNullOrEmpty(str))
                        {
                            double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                            if (arr.Length != 3) //If incorrect data in file
                            {
                                _filePath = null;
                                throw new ArgumentException("Incorrect data in file!");
                            }
                            else
                            {
                                table[i] = new double[3];
                                table[i][0] = arr[0];
                                table[i][1] = arr[1];
                                table[i][2] = arr[2];
                                i++;
                            }
                        }
                        else
                        {
                            _filePath = null;
                            throw new Exception("Error opening file!");
                        }
                    } while (!sr.EndOfStream);
                }
            }
            else if (check == DialogResult.Cancel)
            {
                _filePath = null;
                throw new Exception("Reading canceled.");
            }
            else
            {
                _filePath = null;
                throw new Exception("Error opening file!");
            }
            _filePath = null;
            return table;
        }
    }
}
