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
   public class PURTC
    {
        public PURTC() { }
        private static PURTC dal = null;
        public static PURTC Current
        {
            get
            {
                if (dal == null)
                    dal = new PURTC();
                return dal;
            }
        }

        public Model.Dtos.PurtcDto GetPURTC(string db, string dh) {
            string sql = string.Format("select * from PURTC where TC001='{0}' and TC002='{1}'",db,dh);
            using (SqlConnection conn = new SqlConnection(ConnStrManage.WSGCDB))
            {
                return conn.Query<Model.Dtos.PurtcDto>(sql).FirstOrDefault();
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
        public PageableData<Model.PURTC> GetPageList(string strWhere, string orderby, int startIndex, int endIndex)
        {
            PageableData<Model.PURTC> result = null;
            string totalsql = string.Format("select  count(*) from PURTC where 1=1 and  {0}", strWhere);
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT *  FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.TC003 desc");
            }
            strSql.Append(")AS Row, T.*  from PURTC T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);

            using (SqlConnection conn = new SqlConnection(ConnStrManage.WSGCDB))
            {
                var reader = conn.Query<Model.PURTC>(strSql.ToString(), null);
                result = new PageableData<Model.PURTC>()
                {
                    total = conn.Query<int>(totalsql).FirstOrDefault(),
                    rows = reader
                };
            }
            return result;
        }

    }
}
