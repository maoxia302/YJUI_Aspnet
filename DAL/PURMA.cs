using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using YJUI.DBUtility;
using YJUI.Model;

namespace YJUI.DAL
{
    public class PURMA
    {
        public PURMA() { }
        private static PURMA dal = null;
        public static PURMA Current
        {
            get
            {
                if (dal == null)
                    dal = new PURMA();
                return dal;
            }
        }

        public Model.PURMA GetPURMA(string ma001)
        {
            string sql = string.Format("select * from PURMA where MA001={0}", ma001);
            using (SqlConnection conn = new SqlConnection(ConnStrManage.WSGCDB))
            {
                return conn.Query<Model.PURMA>(sql).FirstOrDefault();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="orderby"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public PageableData<Model.PURMA> GetPageList(string strWhere, string orderby, int startIndex, int endIndex)
        {
            PageableData<Model.PURMA> result = null;
            string totalsql = string.Format("select  count(*) from PURMA where 1=1 and  {0}", strWhere);
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT *  FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.NA001 desc");
            }
            strSql.Append(")AS Row, T.*  from PURMA T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);

            using (SqlConnection conn = new SqlConnection(ConnStrManage.WSGCDB))
            {
                var reader = conn.Query<Model.PURMA>(strSql.ToString(), null);
                result = new PageableData<Model.PURMA>()
                {
                    total = conn.Query<int>(totalsql).FirstOrDefault(),
                    rows = reader
                };
            }
            return result;
        }
    }
}
