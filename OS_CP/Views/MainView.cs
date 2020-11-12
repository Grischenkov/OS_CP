﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using OS_CP.Presenter;

namespace OS_CP
{
    /// <summary>
    /// Class of program for work with main screen
    /// </summary>s
    public partial class MainView : Form, IMainView
    {
        private Series _deviation     = new Series("Deviation");        //Series of chart with deviation values
        private Series _concentration = new Series("Concentration");    //Series of chart with concentration values

        /// <summary>
        /// Get value table
        /// </summary>
        public string[][] ValueTable {
            get
            {
                string[][] table = new string[Table.RowCount - 1][];
                for (int i = 0; i < Table.RowCount - 1; i++) 
                {
                    table[i] = new string[3];
                    table[i][0] = Table.Rows[i].Cells[0].Value.ToString();
                    table[i][1] = Table.Rows[i].Cells[1].Value.ToString();
                    table[i][2] = Table.Rows[i].Cells[2].Value.ToString();
                }
                return table;
            }
            set
            {
                for (int i = 0, j = 0; i < value.Length; i++, j++)
                {
                    Table.RowCount = j + 1;
                    Table.Rows[j].Cells[0].Value = value[i][0];
                    Table.Rows[j].Cells[1].Value = value[i][1];
                    Table.Rows[j].Cells[2].Value = value[i][2];
                }
            }
        }

        /// <summary>
        /// Base constructor
        /// </summary>
        public MainView()
        {
            InitializeComponent();

            //Event subscription
            Calculate_button.Click += (sender, args) => Action(Calculate);
            Settings_button.Click += (sender, args) => Action(Settings);
            Export_button.Click += (sender, args) => Action(Export);
            About_button.Click += (sender, args) => Action(About);
            Save_button.Click += (sender, args) => Action(Save);
            Open_button.Click += (sender, args) => Action(Open);
            Help_button.Click += (sender, args) => Action(Help);
            Exit_button.Click += (sender, args) => Action(Exit);

            //Settings chart lines colour
            _deviation.Color = Color.MediumBlue;
            _concentration.Color = Color.DarkOrange;

            //Settings chart lines type
            _deviation.ChartType = SeriesChartType.Line;
            _concentration.ChartType = SeriesChartType.Line;

            //Cleaning  and adding chart series
            Chart.Series.Clear();
            Chart.Series.Add(_deviation);
            Chart.Series.Add(_concentration);

            //Setting chart
            Chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            Chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            Chart.ChartAreas[0].AxisX.Crossing = 0;
            Chart.ChartAreas[0].AxisY.Crossing = 0;
        }

        /// <summary>
        /// Calculating function value table, drawing chart
        /// </summary>
        public event Action Calculate;

        /// <summary>
        /// Reading data
        /// </summary>
        public event Action Open;

        /// <summary>
        /// Saving data
        /// </summary>
        public event Action Save;

        /// <summary>
        /// Exporting data to Excel
        /// </summary>
        public event Action Export;

        /// <summary>
        /// Showing about window
        /// </summary>
        public event Action About;

        /// <summary>
        /// Showing about window
        /// </summary>
        public event Action Help;

        /// <summary>
        /// Showing about window
        /// </summary>
        public event Action Settings;

        /// <summary>
        /// Exiting program
        /// </summary>
        public event Action Exit;

        /// <summary>
        /// Showing form 
        /// </summary>
        public new void Show()
        {
            //Starting application
            Application.Run(this);
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
        /// Drawing chart
        /// </summary>
        /// <param name="table"> data </param>
        public void DrawChart(double[][] table)
        {
            Chart.Series[0].Points.Clear();
            Chart.Series[1].Points.Clear();
            foreach (var param in table)
            {
                Chart.Series[0].Points.AddXY(param[0], param[1]);
                Chart.Series[1].Points.AddXY(param[0], param[2]);
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
