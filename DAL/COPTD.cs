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
    public class COPTD
    {

        private static COPTD bll = null;
        public static COPTD Current
        {
            get
            {
                if (bll == null)
                    bll = new COPTD();
                return bll;
            }
        }
        /// <summary>
        /// 获取单个model
        /// </summary>
        /// <param name="td001"></param>
        /// <param name="td002"></param>
        /// <param name="td003"></param>
        /// <returns></returns>
        public Model.COPTD CoptcModel(string td001, string td002,string td003)
        {
            string sql = string.Format("select * from COPTD where 1=1 and TD001='{0}' and TD002='{1}' and TD003='{2}'", td001, td002,td003);
            using (SqlConnection conn = new SqlConnection(ConnStrManage.WSGCDB))
            {
                return conn.Query<Model.COPTD>(sql).FirstOrDefault();
            }


        }
        /// <summary>
        /// 获取一条订单的单身所有信息
        /// </summary>
        /// <param name="db"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public PageableData<Model.COPTD> CoptdList(string db,string dh)
        {
            PageableData<Model.COPTD> result = null;
            string sql = string.Format("select* from COPTD where 1 = 1 and TD001 = '{0}' and TD002 = '{1}'", db, dh);
            using (SqlConnection conn = new SqlConnection(ConnStrManage.WSGCDB))
            {
                var reader = conn.Query<Model.COPTD>(sql.ToString(), null);
                result = new PageableData<Model.COPTD>()
                {
                    total = reader.Count(),
                    rows = reader
                };
            }
            return result;
        }

        public   IEnumerable<Model.COPTD> GetCOPTDs(string db, string dh)
        {
            string sql = string.Format("select* from COPTD where 1 = 1 and TD001 = '{0}' and TD002 = '{1}'", db, dh);
            using (SqlConnection conn = new SqlConnection(ConnStrManage.WSGCDB))
            {
               
              return  conn.Query<Model.COPTD>(sql.ToString(), null);
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
        public PageableData<Model.COPTD> GetPageList(string strWhere, string orderby, int startIndex, int endIndex)
        {
            PageableData<Model.COPTD> result = null;
            string totalsql = string.Format("select  count(*) from COPTD where 1=1 and  {0}", strWhere);
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT *  FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.TD002 desc");
            }
            strSql.Append(")AS Row, T.*  from COPTD T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);

            using (SqlConnection conn = new SqlConnection(ConnStrManage.WSGCDB))
            {
                var reader = conn.Query<Model.COPTD>(strSql.ToString(), null);
                result = new PageableData<Model.COPTD>()
                {
                    total = conn.Query<int>(totalsql).FirstOrDefault(),
                    rows = reader
                };
            }
            return result;
        }

    }
}
