using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Web;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace YJUI.Common
{
    /// <summary>
    /// 导出Excel帮助类
    /// </summary>
    public class ExcelHelper
    {
        /// <summary>
        /// Excel检查版本
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static string ConnectionString(string fileName)
        {
            bool isExcel2003 = fileName.EndsWith(".xls");
            string connectionString = string.Format(
                isExcel2003
                    ? "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=Excel 8.0;"
                    : "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES\"",
                fileName);
            return connectionString;
        }
        /// <summary>
        /// Excel导入数据源
        /// </summary>
        /// <param name="sheet">sheet</param>
        /// <param name="filename">文件路径</param>
        /// <returns></returns>
        public static DataTable ExcelToDataSet(string sheet, string filename)
        {
            try
            {
                DataSet ds;
                OleDbConnection myConn = new OleDbConnection(ConnectionString(filename));
                string strCom = " SELECT * FROM [" + sheet + "$]";
                myConn.Open();
                OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
                ds = new DataSet();
                myCommand.Fill(ds);
                myConn.Close();
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static void ExportToCsv(DataTable dt, string strHeaderText, string fileName)
        {
            StringBuilder sb=new StringBuilder();
            int columns = dt.Columns.Count;
            string[] splitHeader = strHeaderText.Split(',');
            
            int headerlen = splitHeader.Length;

            int i = 0;

            for (i = 0; i <=dt.Columns.Count-1; i++)
            {
                if (i > 0)
                {
                    sb.Append(",");
                }
                if (i < headerlen)
                {
                    sb.Append(splitHeader[i]);
                }
                else
                {
                    sb.Append("未添加标题");
                }

            }
            sb.Append("\n");

            foreach (DataRow dr in dt.Rows)
            {
                for ( i = 0; i <=dt.Columns.Count-1; i++)
                {
                    if (i > 0)
                    {
                        sb.Append(",");
                       
                    }
                    sb.Append(dr[i].ToString());

                }sb.Append("\n");
            }
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(sb.ToString());byte[] outBuffer=new byte[buffer.Length+3];
            outBuffer[0] = (byte)0xEF;
            outBuffer[1] = (byte)0xBB;
            outBuffer[2] = (byte)0xBF;
            Array.Copy(buffer,0,outBuffer,3,buffer.Length);

            HttpResponse rs= System.Web.HttpContext.Current.Response;
            rs.ContentEncoding = System.Text.Encoding.UTF8;
            rs.AppendHeader("Content-Disposition","attachment;filename="+fileName);
            rs.ContentType = "application/ms-excel";
            rs.Write(Encoding.UTF8.GetString(outBuffer));
            rs.Flush();
            rs.End();
        }


        /// <summary>
        /// Excel导入成Datable
        /// </summary>
        /// <param name="file">导入路径(包含文件名与扩展名)</param>
        /// <returns></returns>
        public static  DataTable ExcelToTable(string file)
        {
            DataTable dt=new DataTable();
            IWorkbook workbook;
            var extension = Path.GetExtension(file);
            if (extension != null)
            {
                string fileExt = extension.ToLower();
                using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                {
                    if (fileExt == ".xlsx") { workbook = new XSSFWorkbook(fs); } else if (fileExt == ".xls") { workbook = new HSSFWorkbook(fs); } else { workbook = null; }
                    if (workbook == null) { return null; }
                    ISheet sheet = workbook.GetSheetAt(0);
                    sheet.ForceFormulaRecalculation = true;//即可实现自动将 Excel 的公式计算出来。
                    //表头
                    IRow header = sheet.GetRow(sheet.FirstRowNum);
                    List<int> columns = new List<int>();
                    for (int i = 0; i < header.LastCellNum; i++)
                    {
                        object obj = GetValueType(header.GetCell(i));
                        if (obj == null || obj.ToString() == string.Empty)
                        {
                            dt.Columns.Add(new DataColumn("Columns" + i.ToString()));
                        }
                        else
                            dt.Columns.Add(new DataColumn(obj.ToString()));
                        columns.Add(i);
                    }
                    for (int i = sheet.FirstRowNum + 1; i <= sheet.LastRowNum; i++)
                    {
                        DataRow dr = dt.NewRow();
                        bool hasValue = false;
                        foreach (int j in columns)
                        {
                            dr[j] = GetValueType(workbook,sheet.GetRow(i).GetCell(j));
                            if (dr[j] != null && dr[j].ToString() != string.Empty)
                            {
                                hasValue = true;
                            }
                        }
                        if (hasValue)
                        {
                            dt.Rows.Add(dr);
                        }
                    }

                }
            }
            return dt;
        }

        /// <summary>
        /// Excel导入成Datable
        /// </summary>
        /// <param name="file">导入路径(包含文件名与扩展名)</param>
        /// <returns></returns>
        public static DataTable ExcelToTable(string file,int headRow)
        {
            DataTable dt = new DataTable();
            IWorkbook workbook;
            var extension = Path.GetExtension(file);
            if (extension != null)
            {
                string fileExt = extension.ToLower();
                using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                {
                    if (fileExt == ".xlsx") { workbook = new XSSFWorkbook(fs); } else if (fileExt == ".xls") { workbook = new HSSFWorkbook(fs); } else { workbook = null; }
                    if (workbook == null) { return null; }
                    ISheet sheet = workbook.GetSheetAt(0);
                    sheet.ForceFormulaRecalculation = true;//即可实现自动将 Excel 的公式计算出来。
                    //表头
                    IRow header = sheet.GetRow(headRow);
                    List<int> columns = new List<int>();
                    for (int i = 0; i < header.LastCellNum; i++)
                    {
                        object obj = GetValueType(header.GetCell(i));
                        if (obj == null || obj.ToString() == string.Empty)
                        {
                            dt.Columns.Add(new DataColumn("Columns" + i.ToString()));
                        }
                        else
                            dt.Columns.Add(new DataColumn(obj.ToString()));
                        columns.Add(i);
                    }
                    for (int i = headRow + 1; i <= sheet.LastRowNum; i++)
                    {
                        DataRow dr = dt.NewRow();
                        bool hasValue = false;
                        foreach (int j in columns)
                        {
                            dr[j] = GetValueType(workbook, sheet.GetRow(i).GetCell(j));
                            if (dr[j] != null && dr[j].ToString() != string.Empty)
                            {
                                hasValue = true;
                            }
                        }
                        if (hasValue)
                        {
                            dt.Rows.Add(dr);
                        }
                    }

                }
            }
            return dt;
        }
        /// <summary>
        /// 获取单元格类型
        /// </summary>
        /// <param name="cell"></param>
        /// <returns></returns>
        private static object GetValueType(ICell cell)
        {
            if (cell == null)
                return null;
            switch (cell.CellType)
            {
                case CellType.Blank: //BLANK:  
                    return null;
                case CellType.Boolean: //BOOLEAN:  
                    return cell.BooleanCellValue;
                case CellType.Numeric: //NUMERIC:  
                    short format = cell.CellStyle.DataFormat;
                    if (format != 0) { return cell.DateCellValue; } else { return cell.NumericCellValue; }
                case CellType.String: //STRING:  
                    return cell.StringCellValue;
                case CellType.Error: //ERROR:  
                    return cell.ErrorCellValue;
                case CellType.Formula: //FORMULA: 
                default:
                    return "=" + cell.CellFormula;
            }
        }
        /// <summary>
        /// 获取单元格类型
        /// </summary>
        /// <param name="cell"></param>
        /// <returns></returns>
        private static object GetValueType(IWorkbook workbook,ICell cell)
        {
            HSSFFormulaEvaluator evalor = new HSSFFormulaEvaluator(workbook);
            if (cell == null)
                return null;
            switch (cell.CellType)
            {
                case CellType.Blank: //BLANK:  
                    return null;
                case CellType.Boolean: //BOOLEAN:  
                    return cell.BooleanCellValue;
                case CellType.Numeric: //NUMERIC:  
                    short format = cell.CellStyle.DataFormat;
                    if (format != 0) { return cell.DateCellValue; } else { return cell.NumericCellValue; }
                case CellType.String: //STRING:  
                    return cell.StringCellValue;
                case CellType.Error: //ERROR:  
                    return cell.ErrorCellValue;
                case CellType.Formula: //FORMULA: 
                    return evalor.EvaluateInCell(cell);
                default:
                    return "=" + cell.CellFormula;
            }
        }



    }
}
