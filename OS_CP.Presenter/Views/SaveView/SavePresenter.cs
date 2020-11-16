﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OS_CP.Model;

namespace OS_CP.Presenter
{
    /// <summary>
    /// Specific presenter interface for Splash view
    /// </summary>
    public sealed class SavePresenter : BasePresenter<ISaveView, Function, Bitmap>
    {
        private Bitmap _chart;
        private Function _function;

        /// <summary>
        /// Constructor of SplashPresenter class
        /// </summary>
        /// <param name="controller"> Application controller </param>
        /// <param name="view"> View </param>
        public SavePresenter(IApplicationController controller, ISaveView view) : base(controller, view)
        {
            View.SaveValueTable = false;
            View.SaveChartImage = false;

            View.Save += Save;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="function"></param>
        /// <param name="chart"></param>
        public override void Run(Function function, Bitmap chart)
        {
            _chart = chart;
            _function = function;
            View.SaveChartImageEnabled = _chart != null;
            View.Show();
        }


        /// <summary>
        /// 
        /// </summary>
        private void Save()
        {
            if (!View.SaveValueTable && !View.SaveChartImage)
            {
                throw new Exception("Select at least one data type to save!");
            }
            if (View.SaveValueTable)
            {
                using (StreamWriter sw = new StreamWriter(FileFunctions.Save("txt")))
                {
                    for (int i = 0; i < _function.Size; i++)
                    {
                        sw.WriteLine($"{_function.Table[i][0]} {_function.Table[i][1]} {_function.Table[i][2]}");
                    }
                }
            }
            if (View.SaveChartImage)
            { 
                _chart.Save(FileFunctions.Save("jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
    }
}