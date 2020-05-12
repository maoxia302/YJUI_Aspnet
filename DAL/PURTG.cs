using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using YJUI.DBUtility;
using YJUI.Model;

namespace YJUI.DAL
{
   public class PURTG
    {
        public PURTG() { }
        private static PURTG dal = null;
        public static PURTG Current
        {
            get
            {
                if (dal == null)
                    dal = new PURTG();
                return dal;
            }
        }
        /// <summary>
        /// 获取一条进货单记录
        /// </summary>
        /// <param name="db"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public Model.PURTG GetSingleModel(string db,string dh) {
            string sql = string.Format("select * from PURTG where TG001='{0}' and TG002='{1}'", db, dh);
            using (SqlConnection conn = new SqlConnection(ConnStrManage.WSGCDB))
            {
                return conn.Query<Model.PURTG>(sql).FirstOrDefault();
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
        public PageableData<Model.PURTG> GetPageList(string strWhere, string orderby, int startIndex, int endIndex)
        {
            PageableData<Model.PURTG> result = null;
            string totalsql = string.Format("select  count(*) from PURTG where 1=1 and  {0}", strWhere);
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
            strSql.Append(")AS Row, T.*  from PURTG T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);

            using (SqlConnection conn = new SqlConnection(ConnStrManage.WSGCDB))
            {
                var reader = conn.Query<Model.PURTG>(strSql.ToString(), null);
                result = new PageableData<Model.PURTG>()
                {
                    total = conn.Query<int>(totalsql).FirstOrDefault(),
                    rows = reader
                };
            }
            return result;
        }
        /// <summary>
        /// 传入单别获取单号
        /// </summary>
        /// <param name="danbie"></param>
        /// <returns></returns>
        public string GetPurtgErpNo(string danbie)
        {
            return ErpUtil.GetErpNum("PURTG", "TG001", danbie, "TG002", "TG014");
        }

        public bool Insert(Model.PURTG model)
        {
            StringBuilder strSql = new StringBuilder();//insert 语句 
            strSql.Append("insert into PURTG(");
            strSql.Append("COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,TG001,TG002,TG003,TG004,TG005,TG006,TG007,TG008,TG009,TG010,TG011,TG012,TG013,TG014,TG015,TG016,TG017,TG018,TG019,TG020,TG021,TG022,TG023,TG024,TG025,TG026,TG027,TG028,TG029,TG030,TG031,TG032,TG033,TG034,TG035,TG036,TG037,TG038,TG039,TG040,TG041,TG042,TG043,TG044,TG045,TG046,TG047,TG048,TG049,TG050,TG051,TG052,TG053,TG054,TG055,TG056,TG057,TG058,TG059,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62)");
            strSql.Append(" values (");
            strSql.Append("@COMPANY,@CREATOR,@USR_GROUP,@CREATE_DATE,@MODIFIER,@MODI_DATE,@FLAG,@TG001,@TG002,@TG003,@TG004,@TG005,@TG006,@TG007,@TG008,@TG009,@TG010,@TG011,@TG012,@TG013,@TG014,@TG015,@TG016,@TG017,@TG018,@TG019,@TG020,@TG021,@TG022,@TG023,@TG024,@TG025,@TG026,@TG027,@TG028,@TG029,@TG030,@TG031,@TG032,@TG033,@TG034,@TG035,@TG036,@TG037,@TG038,@TG039,@TG040,@TG041,@TG042,@TG043,@TG044,@TG045,@TG046,@TG047,@TG048,@TG049,@TG050,@TG051,@TG052,@TG053,@TG054,@TG055,@TG056,@TG057,@TG058,@TG059,@UDF01,@UDF02,@UDF03,@UDF04,@UDF05,@UDF06,@UDF51,@UDF52,@UDF53,@UDF54,@UDF55,@UDF56,@UDF07,@UDF08,@UDF09,@UDF10,@UDF11,@UDF12,@UDF57,@UDF58,@UDF59,@UDF60,@UDF61,@UDF62)");
            using (SqlConnection conn = new SqlConnection(ConnStrManage.WSGCDB))
            {
                return conn.Execute(strSql.ToString(), model) > 0;
            }
        }

    }
}
