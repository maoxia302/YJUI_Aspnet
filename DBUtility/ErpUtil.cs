using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using Dapper;

namespace YJUI.DBUtility
{
   public static class ErpUtil
    {


        #region 根据单别，日期 获取ERP单号
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbName">指定表</param>
        /// <param name="columnName">单号列名</param>
        /// <param name="db">单别</param>
        /// <param name="orderNoField">单号列</param>
        /// <param name="dateField">单据日期列</param>
        /// <returns></returns>
        public static string GetErpNum(string tbName, string columnName, string db, string orderNoField,string dateField)
        {
            string str6 = "";
            string _date = DateTime.Now.ToString("yyMMdd");
            string date = DateTime.Now.ToString("yyyyMMdd");//当前日期

            string sql = string.Format("select max({0}) from {1} where {2}='{3}' and {4}={5}", orderNoField, tbName, columnName,db,dateField,date);
            using (SqlConnection conn = new SqlConnection(ConnStrManage.WSGCDB))
            {
                str6 = conn.Query<string>(sql).SingleOrDefault();
            }
            if (string.IsNullOrEmpty(str6))
            {
                return (_date + "00001");
            }
            int num = int.Parse(str6.ToString().Substring(8, 5)) + 1;
            return (str6.ToString().Substring(0, 8) + num.ToString().PadLeft(5, '0'));
        }





        #endregion




        #region 根据单别，日期 获取ERP单号

        /// <summary>
        /// 
        /// </summary>
        /// <param name="table"></param>
        /// <param name="columnName"></param>
        /// <param name="SingleName"></param>
        /// <param name="orderNoField"></param>
        /// <param name="datecolumnName"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string GetErpNum5(string table, string columnName, string SingleName, string orderNoField, string datecolumnName, string date)
        {
            string sql = string.Format("select max({0}) from {1} where {2}='{3}' and  {4}='{5}' ", orderNoField, table, columnName, SingleName, datecolumnName, date);
            string str6 = VOCEN2018DbHelperSQL.Query(sql).Tables[0].Rows[0][0].ToString();



            if (str6 == "")
            {
                return (date + "00001");
            }
            int num = int.Parse(str6.ToString().Substring(8, 6)) + 1;
            return (str6.ToString().Substring(0, 8) + num.ToString().PadLeft(6, '0'));
        }
        #endregion

        #region MyRegion
        /// <summary>
        /// List转DataTable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">集合</param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(this IEnumerable<T> list)
        {
            var type = typeof(T);

            var properties = type.GetProperties().ToList();

            var newDt = new DataTable(type.Name);

            properties.ForEach(propertie =>
            {
                Type columnType;
                if (propertie.PropertyType.IsGenericType && propertie.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    columnType = propertie.PropertyType.GetGenericArguments()[0];
                }
                else
                {
                    columnType = propertie.PropertyType;
                }

                newDt.Columns.Add(propertie.Name, columnType);
            });

            foreach (var item in list)
            {
                var newRow = newDt.NewRow();

                properties.ForEach(propertie =>
                {
                    newRow[propertie.Name] = propertie.GetValue(item, null) ?? DBNull.Value;
                });

                newDt.Rows.Add(newRow);
            }

            return newDt;
        }
        /// <summary>
        /// 批量插入
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="list">源数据</param>
        public static void BulkCopy<T>(IDbConnection conn, IEnumerable<T> list)
        {
            var dt = list.ToDataTable();
            using (conn)
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                using (var sqlbulkcopy = new SqlBulkCopy((SqlConnection)conn))
                {
                    sqlbulkcopy.DestinationTableName = dt.TableName;
                    for (var i = 0; i < dt.Columns.Count; i++)
                    {
                        sqlbulkcopy.ColumnMappings.Add(dt.Columns[i].ColumnName, dt.Columns[i].ColumnName);
                    }
                    sqlbulkcopy.WriteToServer(dt);
                }
            }
        }

        #endregion


        /// <summary>
        /// 
        /// </summary>
        /// <param name="log"></param>
        /// <param name="path"></param>
        public static void WriteLog(string log,string path)
        {
            FileStream fs = new FileStream(@path + "log.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(log);
            sw.Close();
            fs.Close();
        }


    }
}
