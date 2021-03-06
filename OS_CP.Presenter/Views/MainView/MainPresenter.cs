﻿using OS_CP.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

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
            View.Clean += Clean;

            View.ShowVideo = RegistryFunctions.GetValue(RegistryFunctions.CheckRegistry(Properties.Settings.Default.RegistryPath), "ShowVideo") == "True";
        }

        private void Clean()
        {
            View.DrawChart(null);
            View.ValueTable = null;
            _function.FillTable(null);
        }

        /// <summary>
        /// Display data
        /// </summary>
        private void Calculate()
        {
            _function.FillTable(CheckValues(View.ValueTable));
            View.DrawChart(ProcessData(_function.Table));
            View.ShowSuccess("Drawn successfully!");
        }

        /// <summary>
        /// Showing about form
        /// </summary>
        private void Open()
        {
            _function.FillTable(CheckValues(DoubleToString(ReadTable())));
            View.ValueTable = DoubleToString(ProcessData(_function.Table));
            View.ShowSuccess("Read successfully!");
        }

        /// <summary>
        /// Showing about form
        /// </summary>
        private void Save()
        {
            _function.FillTable(CheckValues(View.ValueTable));
            Controller.Run<SavePresenter, double[][], Bitmap>(ProcessData(_function.Table), View.ChartImage);
        }

        /// <summary>
        /// Showing about form
        /// </summary>
        private void Export()
        {
            if (RegistryFunctions.GetValue(RegistryFunctions.CheckRegistry(Properties.Settings.Default.RegistryPath), "ExportDLLPath") == Directory.GetCurrentDirectory())
                throw new Exception("Export library not selected." + '\n' + "Specify the path to the required file in the Settings window!");

            _function.FillTable(CheckValues(View.ValueTable));
            Assembly assembly = Assembly.Load(AssemblyName.GetAssemblyName(RegistryFunctions.GetValue(RegistryFunctions.CheckRegistry(Properties.Settings.Default.RegistryPath), "ExportDLLPath")));
            Type type = assembly.GetType(Path.GetFileNameWithoutExtension(RegistryFunctions.GetValue(RegistryFunctions.CheckRegistry(Properties.Settings.Default.RegistryPath), "ExportDLLPath")) + ".EXPORT");
            if (type == null)
            {
                throw new Exception("Incorrect DLL. Use a library that meets the API requirements!");
            }
            object cls = Activator.CreateInstance(type);
            MethodInfo method = type.GetMethod("Export");

            Thread thread = new Thread(Run);
            thread.Start();
            method.Invoke(cls, new object[] { ProcessData(_function.Table) });
            Thread.Sleep(0);
            thread.Abort();

            View.ShowSuccess("Export successfully!");
        }

        /// <summary>
        /// 
        /// </summary>
        private void Run()
        {
            Controller.Run<ProcessPresenter>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        private double[][] ProcessData(double[][] table)
        {
            if (RegistryFunctions.GetValue(RegistryFunctions.CheckRegistry(Properties.Settings.Default.RegistryPath), "MathDLLPath") == Directory.GetCurrentDirectory())
                return table;

            Assembly assembly = Assembly.Load(AssemblyName.GetAssemblyName(RegistryFunctions.GetValue(RegistryFunctions.CheckRegistry(Properties.Settings.Default.RegistryPath), "MathDLLPath")));
            Type type = assembly.GetType(Path.GetFileNameWithoutExtension(RegistryFunctions.GetValue(RegistryFunctions.CheckRegistry(Properties.Settings.Default.RegistryPath), "MathDLLPath")) + ".MATH");
            if (type == null)
            {
                throw new Exception("Incorrect DLL. Use a library that meets the API requirements!" + '\n' + "Load correct library or discard it for continue working.");
            }
            object cls = Activator.CreateInstance(type);
            Thread thread = new Thread(Run);
            thread.Start();
            MethodInfo method = type.GetMethod("Process");
            Thread.Sleep(0);
            thread.Abort();

            return (double[][])method.Invoke(cls, new object[] { _function.Table });
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
            foreach (string line in lines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    double[] arr = null;
                    try
                    {
                        arr = line.Split(' ').Select(double.Parse).ToArray();
                    }
                    catch (FormatException)
                    {
                        double[][] newArr = new double[i][];
                        for (int j = 0; j < i; j++)
                        {
                            newArr[j] = new double[3];
                            for (int z = 0; z < 3; z++)
                            {
                                newArr[j][z] = table[j][z];
                            }
                        }

                        View.ShowWarning("The file has not been fully read!" + '\n' + "Check the file, correct the data, and re-read if necessary.");
                        return newArr;
                    }

                    if (arr.Length != 3)
                    {
                        double[][] newArr = new double[i][];
                        for (int j = 0; j < i; j++)
                        {
                            for (int z = 0; z < 3; z++)
                            {
                                newArr[j][z] = table[j][z];
                            }
                        }

                        View.ShowWarning("The file has not been fully read!" + '\n' + "Check the file, correct the data, and re-read if necessary.");
                        return newArr;
                        //throw new ArgumentException("Incorrect data in file!");
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
                for (int j = 0; j < 3; j++)
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
        private double[][] CheckValues(string[][] srcTable)
        {
            if (srcTable.Length < 2) throw new Exception("Input data must contain at least two lines!");
            double[][] table = new double[srcTable.Length][];

            for (int i = 0; i < table.Length; i++)
            {
                table[i] = new double[3];
                for (int j = 0; j < 3; j++)
                {
                    if (string.IsNullOrEmpty(srcTable[i][j]))
                    {
                        throw new Exception($"Fill in the {j + 1} th element of the {i + 1} th row of the table!");
                    }

                    table[i][j] = double.Parse(srcTable[i][j]);
                }
            }

            return table;
        }
    }
}