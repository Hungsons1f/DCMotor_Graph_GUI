using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SerialGUI
{
    class Export2Excel
    {
        public DataTable table = new DataTable();
        public void SaveToExcel()
        {
            Microsoft.Office.Interop.Excel.Application ExcelFile = new Microsoft.Office.Interop.Excel.Application();
            ExcelFile.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook WorkBook = ExcelFile.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet WorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelFile.ActiveSheet;
            void save()
            {
                try
                {
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        WorkSheet.Cells[1, i + 1] = table.Columns[i].ColumnName;
                    }
                    int j = 2;
                    foreach (DataRow Row in table.Rows)
                    {
                        for (int i = 0; i < table.Columns.Count; i++)
                        {
                            WorkSheet.Cells[j, i + 1] = Row[i];
                        }
                        j++;
                    }
                }
                catch (Exception)
                {
                    save();
                }
            }
            save();
        }
    }
}
