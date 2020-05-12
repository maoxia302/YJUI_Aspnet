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

    public class PURTH
    {
        public PURTH() { }
        private static PURTH dal = null;
        public static PURTH Current
        {
            get
            {
                if (dal == null)
                    dal = new PURTH();
                return dal;
            }
        }
        public bool Insert(List<Model.PURTH> purths)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into PURTH(");
            strSql.Append("COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,TH001,TH002,TH003,TH004,TH005,TH006,TH007,TH008,TH009,TH010,TH011,TH012,TH013,TH014,TH015,TH016,TH017,TH018,TH019,TH020,TH021,TH022,TH023,TH024,TH025,TH026,TH027,TH028,TH029,TH030,TH031,TH032,TH033,TH034,TH035,TH036,TH037,TH038,TH039,TH040,TH041,TH042,TH043,TH044,TH045,TH046,TH047,TH048,TH049,TH050,TH051,TH052,TH053,TH054,TH055,TH056,TH057,TH058,TH059,TH060,TH061,TH062,TH063,TH064,TH065,TH066,TH067,TH068,TH069,TH070,TH071,TH072,TH073,TH074,TH075,TH076,TH077,TH078,TH079,TH080,THC01,THC02,THC03,THC04,THC05,THC06,THC07,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62)");
            strSql.Append(" values (");
            strSql.Append("@COMPANY,@CREATOR,@USR_GROUP,@CREATE_DATE,@MODIFIER,@MODI_DATE,@FLAG,@TH001,@TH002,@TH003,@TH004,@TH005,@TH006,@TH007,@TH008,@TH009,@TH010,@TH011,@TH012,@TH013,@TH014,@TH015,@TH016,@TH017,@TH018,@TH019,@TH020,@TH021,@TH022,@TH023,@TH024,@TH025,@TH026,@TH027,@TH028,@TH029,@TH030,@TH031,@TH032,@TH033,@TH034,@TH035,@TH036,@TH037,@TH038,@TH039,@TH040,@TH041,@TH042,@TH043,@TH044,@TH045,@TH046,@TH047,@TH048,@TH049,@TH050,@TH051,@TH052,@TH053,@TH054,@TH055,@TH056,@TH057,@TH058,@TH059,@TH060,@TH061,@TH062,@TH063,@TH064,@TH065,@TH066,@TH067,@TH068,@TH069,@TH070,@TH071,@TH072,@TH073,@TH074,@TH075,@TH076,@TH077,@TH078,@TH079,@TH080,@THC01,@THC02,@THC03,@THC04,@THC05,@THC06,@THC07,@UDF01,@UDF02,@UDF03,@UDF04,@UDF05,@UDF06,@UDF51,@UDF52,@UDF53,@UDF54,@UDF55,@UDF56,@UDF07,@UDF08,@UDF09,@UDF10,@UDF11,@UDF12,@UDF57,@UDF58,@UDF59,@UDF60,@UDF61,@UDF62)");
            using (SqlConnection conn = new SqlConnection(ConnStrManage.WSGCDB))
            {
                return conn.Execute(strSql.ToString(), purths) > 0;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="purths"></param>
        /// <returns></returns>
        public IEnumerable<Model.PURTH> GetModelList(string db,string dh)
        {

            string sql = string.Format("select * from PURTH where TH001='{0}'and TH002={1}",db,dh);
            using (SqlConnection conn = new SqlConnection(ConnStrManage.WSGCDB))
            {
                return conn.Query<Model.PURTH>(sql);
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
        public PageableData<Model.COPTH> GetPageList(string strWhere, string orderby, int startIndex, int endIndex)
        {
            PageableData<Model.COPTH> result = null;
            string totalsql = string.Format("select  count(*) from COPTH where 1=1 and  {0}", strWhere);
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT *  FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.TH003 desc");
            }
            strSql.Append(")AS Row, T.*  from COPTH T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);

            using (SqlConnection conn = new SqlConnection(ConnStrManage.WSGCDB))
            {
                var reader = conn.Query<Model.COPTH>(strSql.ToString(), null);
                result = new PageableData<Model.COPTH>()
                {
                    total = conn.Query<int>(totalsql).FirstOrDefault(),
                    rows = reader
                };
            }
            return result;
        }


    }
}
