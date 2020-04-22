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
   public class COPTG
    {
        public COPTG() { }
        private static COPTG dal = null;
        public static COPTG Current
        {
            get {
                if (dal == null)
                    dal = new COPTG();
                return dal;
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
        public PageableData<Model.COPTG> GetPageList(string strWhere, string orderby, int startIndex, int endIndex)
        {
            PageableData<Model.COPTG> result = null;
            string totalsql = string.Format("select  count(*) from COPTG where 1=1 and  {0}", strWhere);
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT *  FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.TG003 desc");
            }
            strSql.Append(")AS Row, T.*  from COPTG T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);

            using (SqlConnection conn = new SqlConnection(ConnStrManage.WSGCDB))
            {
                var reader = conn.Query<Model.COPTG>(strSql.ToString(), null);
                result = new PageableData<Model.COPTG>()
                {
                    total = conn.Query<int>(totalsql).FirstOrDefault(),
                    rows = reader
                };
            }
            return result;
        }
        /// <summary>
        /// 根据单别获取单号
        /// </summary>
        /// <param name="danbie"></param>
        /// <returns></returns>
        public string GetCoptgErpNo(string danbie)
        {
            return ErpUtil.GetErpNum("COPTG", "TG001", danbie, "TG002","TG042");
        }
        /// <summary>
        /// 获取一个实体coptg
        /// </summary>
        /// <param name="tg001"></param>
        /// <param name="tg002"></param>
        /// <returns></returns>
        public Model.COPTG GetSingleCoptg(string tg001,  string tg002)
        {
            string sql = string.Format("select * from COPTG where 1=1 and TG001='{0}' and TG002='{1}'", tg001, tg002);
            using (SqlConnection conn = new SqlConnection(ConnStrManage.WSGCDB))
            {
                return conn.Query<Model.COPTG>(sql).FirstOrDefault();
            }

        }


    }
}
