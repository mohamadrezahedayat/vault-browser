using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Excel = Microsoft.Office.Interop.Excel;

namespace Excel
{
    public class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        public Excel()
        {

        }
        public Excel(string path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];

        }
        public string ReadCell(int i, int j)
        {
            i++;
            j++;
            if (ws.Cells[i, j].Value2 != null)
            {
                return ws.Cells[i, j].Value2;
            }
            else
            {
                return "";
            }

        }
        public void WriteCell(int i, int j, string s)
        {
            i++;
            j++;
            ws.Cells[i, j].Value2 = s;

        }
        public void CreateNewFile()
        {
            this.wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            this.wb = wb.Worksheets[1];
        }
        public void CreateNewWorkSheet()
        {
            Worksheet tempSheet = wb.Worksheets.Add(After: wb);
        }
        public void SelectWorksheet(int sheetNumber)
        {
            this.ws = wb.Worksheets[sheetNumber];
        }
        public void Selectsheet(string sheetName)
        {
            this.ws = (Worksheet)wb.Sheets[sheetName];
        }
        public string[,] ReadRange(int starti, int startj, int endi, int endj)
        {
            Range range = (Range) ws.Range[ws.Cells[starti, startj], ws.Cells[endi, endj]];
            object[,] holder = range.Value2;
            string[,] returnString = new string[endi - starti, endj - startj];
            for (int i = 0; i <= endi - starti; i++)
            {
                for (int j = 0; j <= endj - startj; j++)
                {
                    returnString[i - 1, j - 1] = holder[i, j].ToString();
                }
            }
            return returnString;
        }
        public string[,] ReadUsedRange()
        {
            Range usedRange = ws.UsedRange;
            int rowCount = usedRange.Rows.Count;
            int colCount = usedRange.Columns.Count;
            object[,] holder = usedRange.Value2;
            string[,] returnString = new string[rowCount, colCount];
            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    if (holder[i, j] != null)
                    {
                        returnString[i - 1, j - 1] = holder[i, j].ToString();
                    }
                    else
                    {
                        returnString[i - 1, j - 1] = string.Empty;
                    }
                }
            }
            return returnString;
        }
        public object[,] ReadUsedRange_obj()
        {
            Range usedRange = ws.UsedRange;
            
            object[,] holder = usedRange.Value2;
            
            return holder;
        }
        public void WriteRange(int starti, int startj, int endi, int endj, string[,] writeString)
        {
            Range range = (Range)ws.Range[ws.Range[starti, startj], ws.Range[endi, endj]];
            range.Value2 = writeString;
        }
        public void DeleteWorksheet(int sheetNumber)
        {
            wb.Worksheets[sheetNumber].Delete();
        }
         
        public void Save()
        {
            wb.Save();
        }
        public void SaveAs(string path)
        {
            wb.SaveAs(path);
        }
        public void Close()
        {
            wb.Close();
        }
    }
}
