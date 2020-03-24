using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.Streaming;
using NPOI.XSSF.UserModel;

namespace YJUI.Common
{
    public static class NpoiHelper
    {
        public static Tuple<string, DataTable> ImportExcelToDataTable(string filePath, bool isColumnName)
        {
            DataTable dataTable = null;
            FileStream fs = null;
            DataColumn column = null;
            DataRow dataRow = null;
            IWorkbook workbook = null;
            ISheet sheet = null;
            IRow row = null;
            ICell cell = null;
            int startRow = 0;
            try
            {
                using (fs = File.OpenRead(filePath))
                {
                    if (filePath.IndexOf(".xlsx") > 0)
                    {
                        workbook = new XSSFWorkbook(fs);
                    }
                    else if (filePath.IndexOf(".xls") > 0)
                    {
                        workbook = new HSSFWorkbook(fs);

                    }
                    if (workbook != null)
                    {
                        sheet = workbook.GetSheetAt(0);
                        dataTable = new DataTable();
                        if (sheet != null)
                        {
                            int rowCount = sheet.LastRowNum;//总行数
                            if (rowCount > 0)
                            {
                                IRow firstRow = sheet.GetRow(0);//第一行
                                int cellCount = firstRow.LastCellNum;//列数
                                if (isColumnName)
                                {
                                    startRow = 1;
                                    for (int i = firstRow.FirstCellNum; i < cellCount; ++i)
                                    {
                                        cell = firstRow.GetCell(i);
                                        if (cell != null)
                                        {
                                            if (cell.StringCellValue != null)
                                            {
                                                column = new DataColumn(cell.StringCellValue);
                                                dataTable.Columns.Add(column);
                                            }
                                        }
                                    }

                                }
                                else
                                {
                                    for (int i = firstRow.FirstCellNum; i < cellCount; ++i)
                                    {
                                        column = new DataColumn("column" + (i + 1));
                                        dataTable.Columns.Add(column);
                                    }
                                }
                                //填充行
                                for (int i = startRow; i < rowCount; ++i)
                                {
                                    row = sheet.GetRow(i);
                                    if (row == null) continue;
                                    dataRow = dataTable.NewRow();
                                    for (int j = row.FirstCellNum; j < cellCount; ++j)
                                    {
                                        cell = row.GetCell(j);
                                        if (cell == null)
                                        {
                                            dataRow[j] = "";
                                        }
                                        else
                                        {
                                            switch (cell.CellType)
                                            {
                                                case CellType.Blank:

                                                    dataRow[j] = "";
                                                    break;
                                                case CellType.Numeric:
                                                    short format = cell.CellStyle.DataFormat;
                                                    if (format == 14 || format == 31 || format == 57 || format == 58)
                                                        dataRow[j] = cell.DateCellValue;
                                                    else
                                                        dataRow[j] = cell.NumericCellValue;
                                                    break;
                                                case CellType.String:
                                                    dataRow[j] = cell.StringCellValue;
                                                    break;

                                            }
                                        }



                                    }
                                    dataTable.Rows.Add(dataRow);

                                }
                            }

                        }
                    }
                }
                return Tuple.Create<string, DataTable>("", dataTable);
            }
            catch (Exception ex)
            {
                if (fs != null)
                {
                    fs.Close();
                }
                return Tuple.Create<string, DataTable>(ex.Message, null);
            }

        }
        public static Tuple<bool, string> ExportDataTableToExcel(DataTable dt, string saveTopath)
        {
            bool result = false;
            string message = "";
            IWorkbook workbook = null;
            FileStream fs = null;
            IRow row = null;
            ISheet sheet = null;
            ICell cell = null;
            try
            {
                if (dt != null && dt.Rows.Count > 0)
                {
                    workbook = new HSSFWorkbook();
                    sheet = workbook.CreateSheet("sheet0");
                    int rowCount = dt.Rows.Count;//行数 
                    int columnCount = dt.Columns.Count;//列数
                    row = sheet.CreateRow(0);//excel第一行设为列头 
                    for (int c = 0; c < columnCount; c++)
                    {
                        cell = row.CreateCell(c);
                        cell.SetCellValue(dt.Columns[c].ColumnName);
                    }
                    //设置每行每列的单元格, 
                    for (int i = 0; i < rowCount; i++)
                    {
                        row = sheet.CreateRow(i + 1);
                        for (int j = 0; j < columnCount; j++)
                        {
                            cell = row.CreateCell(j);//excel第二行开始写入数据  
                            cell.SetCellValue(dt.Rows[i][j].ToString());
                        }
                    }
                    using (fs = File.OpenWrite(saveTopath))
                    {
                        workbook.Write(fs);//向打开的这个xls文件中写入数据  
                        result = true;
                    }
                }
                else
                {
                    message = "没有解析到数据！";
                }
                return new Tuple<bool, string>(result, message);
            }
            catch (Exception ex)
            {

                if (fs != null)
                {
                    fs.Close();
                }
                return new Tuple<bool, string>(false, ex.Message);
            }
        }
        public static void GridToExcelByNpoi(SqlDataReader datareader, string sql, string col)
        {
            XSSFWorkbook work = new XSSFWorkbook();
            //创建一个Sheet1
            ISheet sheet1 = work.CreateSheet("Sheet1");
            SqlDataReader reader = datareader;
            IRow rowhead = sheet1.CreateRow(0);
            string str = col;
            string[] strings = str.Split(',');
            for (int i = 0; i < strings.Length; i++)
            {
                rowhead.CreateCell(i, CellType.String).SetCellValue(strings[i]);
                ;
            }
            int index = 1;
            while (reader.Read())
            {
                IRow rowbody = sheet1.CreateRow(index);
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    ICell cellbody = rowbody.CreateCell(i);
                    cellbody.SetCellValue(reader[i].ToString());
                }
                index++;
            }
            MemoryStream ms = new MemoryStream();
            work.Write(ms);
            string title = "报表";
            HttpContext.Current.Response.AddHeader("Content-Disposition", string.Format("attachment;filename={0}.xlsx", HttpUtility.UrlEncode(title + "_" + DateTime.Now.ToString("yyyy-MM-dd"), System.Text.Encoding.UTF8)));
            HttpContext.Current.Response.BinaryWrite(ms.ToArray());
            HttpContext.Current.Response.End();
            work = null;
            ms.Close();
            ms.Dispose();

        }
        /// <summary>
        /// datatable导出
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="col"></param>
        public static void ToExcelByNpoi(DataTable dataTable, string col)
        {
            XSSFWorkbook work = new XSSFWorkbook();
            IWorkbook workbook = new SXSSFWorkbook(work, 1000);
            //创建一个Sheet1


            SXSSFSheet sheet1 = (SXSSFSheet)workbook.CreateSheet("Sheet1");
            DataTable dt = dataTable;
            IRow rowhead = sheet1.CreateRow(0);
            string str = col;
            string[] strings = str.Split(',');
            if (!strings.Any(x => string.IsNullOrEmpty(x)))
            {
                for (int i = 0; i < strings.Length; i++)
                {

                    rowhead.CreateCell(i, CellType.String).SetCellValue(strings[i]);

                }
            }

            else
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                    rowhead.CreateCell(i, CellType.String).SetCellValue(dt.Columns[i].ColumnName);
            }
            int index = 1; for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dtRow = dt.Rows[i];
                IRow excelRow = sheet1.CreateRow(index++);
                for (int j = 0; j < dtRow.ItemArray.Length; j++)
                {
                    excelRow.CreateCell(j).SetCellValue(dtRow[j].ToString());
                }


            }
            MemoryStream ms = new MemoryStream();
            workbook.Write(ms);
            string title = "报表";
            HttpContext.Current.Response.AddHeader("Content-Disposition", string.Format("attachment;filename={0}.xlsx", HttpUtility.UrlEncode(title + "_" + DateTime.Now.ToString("yyyy-MM-dd"), System.Text.Encoding.UTF8)));
            HttpContext.Current.Response.BinaryWrite(ms.ToArray());
            HttpContext.Current.Response.End();
            work = null;
            ms.Close();
            ms.Dispose();

        }
    }
}
