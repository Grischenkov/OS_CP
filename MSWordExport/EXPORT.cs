using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;

namespace MSWordExport
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
        public void Export(double[][] values)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Title = "Export data to word...",
                Filter = "Excel files(*.docx)|*.docx",
                OverwritePrompt = true,
                CheckPathExists = true
            };

            DialogResult check = saveFile.ShowDialog();

            switch (check)
            {
                case DialogResult.OK:
                    {
                        string filePath = saveFile.FileName;

                        Application word  = new Application();
                        Document    doc   = word.Documents.Add(Visible: false);
                        Range       range = doc.Range();
                        Table       table = doc.Tables.Add(range, values.Length, 3);

                        table.Borders.Enable = 1;
                        for (int i = 0, j = 1; i < values.Length; i++, j++)
                        {
                            table.Rows[j].Cells[1].Range.Text = values[i][0].ToString();
                            table.Rows[j].Cells[2].Range.Text = values[i][1].ToString();
                            table.Rows[j].Cells[3].Range.Text = values[i][2].ToString();
                        }

                        doc.SaveAs(filePath);
                        try
                        {
                            doc.Close();
                            word.Quit();
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
