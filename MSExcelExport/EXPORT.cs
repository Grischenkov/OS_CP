using Microsoft.Office.Interop.Excel;
using System;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace MSExcelExport
{
    /// <summary>
    /// 
    /// </summary>
    public class EXPORT
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name => "MS Excel";

        /// <summary>
        /// 
        /// </summary>
        public void Export(double[][] table)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Title = "Export data to excel...",
                Filter = "Excel files(*.xlsx)|*.xlsx",
                OverwritePrompt = true,
                CheckPathExists = true
            };

            DialogResult check = saveFile.ShowDialog();

            switch (check)
            {
                case DialogResult.OK:
                    {
                        string filePath = saveFile.FileName;

                        Application excel = new Application();
                        Workbook workbook = excel.Workbooks.Add();
                        Worksheet worksheet = workbook.ActiveSheet;

                        excel.Visible = false;
                        int size = 0;
                        for (int i = 0, j = 1; i < table.Length; i++, j++, size++)
                        {
                            worksheet.Rows[j].Columns[1] = table[i][0];
                            worksheet.Rows[j].Columns[2] = table[i][1];
                            worksheet.Rows[j].Columns[3] = table[i][2];
                        }

                        string str = size.ToString();

                        ChartObjects xlCharts = (ChartObjects)worksheet.ChartObjects(Type.Missing);
                        ChartObject myChart = xlCharts.Add(200, 0, 550, 550);

                        Chart chart = myChart.Chart;

                        SeriesCollection seriesCollection = (SeriesCollection)chart.SeriesCollection(Type.Missing);

                        Series deviation = seriesCollection.NewSeries();
                        Series concentration = seriesCollection.NewSeries();

                        deviation.Name = "Deviation";
                        concentration.Name = "Concentration";

                        deviation.XValues = worksheet.get_Range("A1", "A" + str);
                        concentration.XValues = worksheet.get_Range("A1", "A" + str);
                        concentration.Values = worksheet.get_Range("B1", "B" + str);
                        deviation.Values = worksheet.get_Range("C1", "C" + str);

                        chart.ChartType = XlChartType.xlXYScatterSmooth;

                        excel.AlertBeforeOverwriting = false;
                        workbook.SaveAs(filePath);

                        try
                        {
                            workbook.Close();
                            excel.Quit();
                        }
                        catch (Exception)
                        {
                            // ignored
                        }

                        break;
                    }
                case DialogResult.Cancel:
                    break;
                default:
                    throw new Exception("Error exporting data!");
            }
        }
    }
}
