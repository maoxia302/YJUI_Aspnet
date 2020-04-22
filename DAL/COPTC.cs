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
    public class COPTC
    {
        public COPTC() { }
        private static COPTC dal = null;
        public static COPTC Current
        {
            get
            {
                if (dal == null)
                    dal = new COPTC();
                return dal;
            }
        }

        public Model.COPTC CoptcModel(string tc001, string tc002)
        {
            string sql = string.Format("select * from COPTC where 1=1 and TC001='{0}' and TC002='{1}'", tc001, tc002);
            using (SqlConnection conn = new SqlConnection(ConnStrManage.WSGCDB))
            {
               return  conn.Query<Model.COPTC>(sql).FirstOrDefault();
            }


        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="orderby"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public PageableData<Model.COPTC> GetPageList(string strWhere, string orderby, int startIndex, int endIndex)
        {
            PageableData<Model.COPTC> result = null;
            string totalsql = string.Format("select  count(*) from COPTC where 1=1 and  {0}", strWhere);
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
            strSql.Append(")AS Row, T.*  from COPTC T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);

            using (SqlConnection conn = new SqlConnection(ConnStrManage.WSGCDB))
            {
                var reader = conn.Query<Model.COPTC>(strSql.ToString(), null);
                result = new PageableData<Model.COPTC>()
                {
                    total = conn.Query<int>(totalsql).FirstOrDefault(),
                    rows = reader
                };
            }
            return result;
        }
    }
}
