using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OS_CP.Model;

namespace OS_CP.Presenter
{
    /// <summary>
    /// Specific presenter interface for Main view
    /// </summary>
    public sealed class MainPresenter : BasePresenter<IMainView>
    {
        private readonly Function _function; //Object of class Function for work with model

        /// <summary>
        /// Constructor of MainPresenter class
        /// </summary>
        /// <param name="controller"> Application controller </param>
        /// <param name="view"> View </param>
        public MainPresenter(IApplicationController controller, IMainView view) : base(controller, view)
        {
            //Model initializing
            _function = new Function();

            //Event subscription
            View.Calculate += Calculate;
            View.Open += Open;
            View.Save += Save;
            View.Export += Export;
            View.About += About;
            View.Help += Help;
            View.Settings += Settings;
            View.Exit += Exit;
        }

        /// <summary>
        /// Display data
        /// </summary>
        private void Calculate()
        {
            _function.FillTable(CheckValues(View.ValueTable));
            View.DrawChart(/*ProcessData(*/_function.Table/*)*/);
        }

        /// <summary>
        /// Showing about form
        /// </summary>
        private void Open()
        {
           View.ValueTable = DoubleToString(ReadTable());
        }

        /// <summary>
        /// Showing about form
        /// </summary>
        private void Save()
        {
            _function.FillTable(CheckValues(View.ValueTable));
            Controller.Run<SavePresenter, Function, Bitmap>(_function, View.ChartImage);
        }

        /// <summary>
        /// Showing about form
        /// </summary>
        private void Export()
        {
            //ExportData();
        }

        /// <summary>
        /// Showing about form
        /// </summary>
        private void About()
        {
            Controller.Run<AboutPresenter>();
        }

        /// <summary>
        /// Showing settings form
        /// </summary>
        private void Help()
        {
            Controller.Run<HelpPresenter>();
        }

        /// <summary>
        /// Showing settings form
        /// </summary>
        private void Settings()
        {
            Controller.Run<SettingsPresenter>();
        }

        /// <summary>
        /// Reading value table from file
        /// </summary>
        /// <returns></returns>
        private double[][] ReadTable()
        {
            double[][] table = null;
            List<string> lines = new List<string>();

            int i;
            using (StreamReader sr = new StreamReader(FileFunctions.Open("txt")))
            {
                i = 0;
                do
                {
                    lines.Add(sr.ReadLine());
                    i++;
                } while (!sr.EndOfStream);
                table = new double[i][];
            }
            i = 0;
            foreach (var line in lines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    double[] arr = line.Split(' ').Select(double.Parse).ToArray();
                    if (arr.Length != 3)
                    {
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
                    throw new Exception("Error opening file!");
                }
            }
            return table;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private string[][] DoubleToString(double[][] array)
        {
            string[][] table = new string[array.Length][];
            for (int i = 0; i < array.Length; i++)
            {
                table[i] = new string[3];
                for (int j =0; j < 3; j++)
                {
                    table[i][j] = array[i][j].ToString();
                }
            }

            return table;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="srcTable"></param>
        /// <returns></returns>
        private double[][] CheckValues (string[][] srcTable)
        {
            if (srcTable.Length < 2) throw new Exception("Input data must contain at least two lines!");
            double[][] table = new double[srcTable.Length][];

            for (int i = 0; i < table.Length; i++)
            {
                table[i] = new double[3];
                for (int j = 0; j < 3; j++)
                {
                    if (String.IsNullOrEmpty(srcTable[i][j]))
                    {
                        throw new Exception($"Fill in the {j + 1} th element of the {i + 1} th row of the table!");
                    }

                    table[i][j] = Double.Parse(srcTable[i][j]);
                }
            }

            return table;
        }
    }
}