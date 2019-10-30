using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YJUI.DBUtility
{
   public class ErpUtil
    {
        public ErpUtil() { }

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
        public static string GetErpNum(string table, string columnName, string SingleName, string orderNoField, string datecolumnName, string date)
        {
            string sql = string.Format("select max({0}) from {1} where {2}='{3}' and  {4}='{5}' ", orderNoField, table, columnName, SingleName, datecolumnName, date);
            string str6 = VOCEN2018DbHelperSQL.Query(sql).Tables[0].Rows[0][0].ToString();
            if (str6 == "")
            {
                return (date + "001");
            }
            int num = int.Parse(str6.ToString().Substring(8, 3)) + 1;
            return (str6.ToString().Substring(0, 8) + num.ToString().PadLeft(3, '0'));
        }
        #endregion
    }
}
