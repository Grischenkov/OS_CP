using System;
using System.IO;
using System.Linq;
using OS_CP.Model;

namespace OS_CP.Presenter
{
    /// <summary>
    /// Specific presenter interface for Main view
    /// </summary>
    public sealed class MainPresenter : BasePresenter<IMainView>
    {
        private Function _function; //Object of class Function for work with model

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
           //View.ValueTable = ReadTable();
        }

        /// <summary>
        /// Showing about form
        /// </summary>
        private void Save()
        {
            //Controller.Run<SavePresenter>();
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
            //Controller.Run<AboutPresenter>();
        }

        /// <summary>
        /// Showing settings form
        /// </summary>
        private void Help()
        {
            //Controller.Run<HelpPresenter>();
        }

        /// <summary>
        /// Showing settings form
        /// </summary>
        private void Settings()
        {
            //Controller.Run<SettingsPresenter>();
        }

        /// <summary>
        /// Reading value table from file
        /// </summary>
        /// <returns></returns>
        private double[][] ReadTable()
        {
            double[][] table = null;

            using (StreamReader sr = new StreamReader(FileFunctions.Open("txt")))
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
                } while (!sr.EndOfStream);
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
            double[][] table = new double[srcTable.Length][];

            for (int i = 0; i < table.Length; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    table[i] = new double[3];
                    if (String.IsNullOrEmpty(srcTable[i][j]))
                    {
                        throw new Exception($"Заполните {j+1}-й элемент {i+1}-й строки таблицы!");
                    }

                    table[i][j] = Double.Parse(srcTable[i][j]);
                }
            }

            return table;
        }
    }
}