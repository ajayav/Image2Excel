using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using TextBox = System.Windows.Forms.TextBox;

namespace Image2Excel
{
    public partial class Image2Excel : Form
    {
        public Image2Excel()
        {
            InitializeComponent();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (rowTxt.Text != "" && colTxt.Text != "" && imageTxt.Text != "" && fileLbl.Text != null)
            {
                int row = Convert.ToInt32(rowTxt.Text);
                int col = Convert.ToInt32(colTxt.Text);
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet.Cells[2, 1] = "Image in Excel file";
                Excel.Range oRange = (Excel.Range)xlWorkSheet.Cells[row, col];
                float Left = (float)((double)oRange.Left);
                float Top = (float)((double)oRange.Top);
                const float ImageSize = 32;
                xlWorkSheet.Shapes.AddPicture(imageTxt.Text, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                oRange.RowHeight = ImageSize + 2;
                xlWorkBook.SaveAs(fileTxt.Text, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();
                releaseObject(xlApp);
                releaseObject(xlWorkBook);
                releaseObject(xlWorkSheet);
                MessageBox.Show("Excel File created !", "Image Excel");
            }
            else
            {
                MessageBox.Show("Please enter Row & Column number", "File not created !");
            }

        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void rowTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void colTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
