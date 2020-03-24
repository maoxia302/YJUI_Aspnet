using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using YJUI.DBUtility;//Please add references
using YJUI.Model;
using Dapper;
using System.Linq;
using System.Configuration;
using System.Collections.Generic;

namespace YJUI.DAL
{
    public partial class ui_tuji
    {
        public ui_tuji() { }
        const string INSERT = "INSERT INTO [ui_tuji]([fk_date],[fk_person],[fk_dep],[fk_area],[fk_customer],[fk_type],[fk_dec])" +
            "VALUES" +
            "(@fk_date,@fk_person,@fk_dep,@fk_area,@fk_customer,@fk_type,@fk_dec)";
        public PageableData<Model.ui_tuji> GetPageList(string strWhere, string orderby, int startIndex, int endIndex)
        {
            PageableData<Model.ui_tuji> result = null;
            string totalsql = string.Format("select  count(*) from ui_tuji where 1=1 and  {0}", strWhere);
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT *  FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.ID desc");
            }
            strSql.Append(")AS Row, T.*  from ui_tuji T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);

            using (SqlConnection conn = new SqlConnection(ConnStrManage.NEWV2013DB))
            {
                var reader = conn.Query<Model.ui_tuji>(strSql.ToString(), null);
                result = new PageableData<Model.ui_tuji>()
                {
                    total = conn.Query<int>(totalsql).FirstOrDefault(),
                    rows = reader
                };
            }
            return result;
        }

        public bool Insert(Model.ui_tuji model)
        {
            using (SqlConnection conn = new SqlConnection(ConnStrManage.NEWV2013DB))
            {
                return conn.Execute(INSERT, model) > 0;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Zhuanxiang_add(Model.ui_tuji model) {
            string sql = @"update ui_tuji
                           set [zx_look] = @zx_look,[zx_is] = @zx_is where ID=@ID" ;
            using (SqlConnection conn = new SqlConnection(ConnStrManage.NEWV2013DB))
            {
                return conn.Execute(sql, model) > 0;
            }


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Houtai_add(Model.ui_tuji model)
        {
            string sql = @"update ui_tuji
                           set 
                            [ht_dep] = @ht_dep
                           ,[ht_person] = @ht_person
                           ,[ht_lqdate]=@ht_lqdate
                           ,[ht_predate]=@ht_predate
                           ,[ht_enddate]=@ht_enddate
                           ,[ht_status]=@ht_status
                           where ID=@ID";
            using (SqlConnection conn = new SqlConnection(ConnStrManage.NEWV2013DB))
            {
                return conn.Execute(sql, model) > 0;
            }


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Kefu_add(Model.ui_tuji model)
        {
            string sql = @"update ui_tuji
                           set 
                            [service]=@service
                           ,[service_date] = @service_date
                           where ID=@ID";
            using (SqlConnection conn = new SqlConnection(ConnStrManage.NEWV2013DB))
            {
                return conn.Execute(sql, model) > 0;
            }


        }

        public DataSet GetReport(string condition)
        {
            string sql = @"select  *  from [ui_tuji]";
            if (condition.Trim() != "")
            {
                sql+=" where " + condition;
            }
            using (SqlConnection conn = new SqlConnection(ConnStrManage.NEWV2013DB))
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }
    }
}
