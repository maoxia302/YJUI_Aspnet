using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using YJUI.DBUtility;
using YJUI.Model;

namespace YJUI.DAL
{
   public  class ui_shejitaizhang
    {
        public ui_shejitaizhang() { }
        private static ui_shejitaizhang dal = null;
        public static ui_shejitaizhang Current
        {
            get
            {
                if (dal == null)
                    dal = new ui_shejitaizhang();
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
        public PageableData<Model.ui_shejitaizhang> GetPageList(string strWhere, string orderby, int startIndex, int endIndex)
        {
            PageableData<Model.ui_shejitaizhang> result = null;
            string totalsql = string.Format("select  count(*) from ui_shejitaizhang where 1=1 and  {0}", strWhere);
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
            strSql.Append(")AS Row, T.*  from ui_shejitaizhang  T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);

            using (SqlConnection conn = new SqlConnection(ConnStrManage.NEWV2013DB))
            {
                var reader = conn.Query<Model.ui_shejitaizhang>(strSql.ToString(), null);
                result = new PageableData<Model.ui_shejitaizhang>()
                {
                    total = conn.Query<int>(totalsql).FirstOrDefault(),
                    rows = reader
                };
            }
            return result;
        }
        public void BulkCopypSheJi(DataTable dt)
        {


            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(DbHelperSQL.connectionString))
            {
                bulkCopy.DestinationTableName = "ui_shejitaizhang"; //插入目标表
                bulkCopy.ColumnMappings.Add("品名", "pinMing");
                bulkCopy.ColumnMappings.Add("规格", "guiGe");
                bulkCopy.ColumnMappings.Add("品牌", "pinPai");
                bulkCopy.ColumnMappings.Add("包装需求数", "baoZhuangShu");
                bulkCopy.ColumnMappings.Add("包装单位", "danWei");
                bulkCopy.ColumnMappings.Add("备注", "remark");
                bulkCopy.WriteToServer(dt); //数据源表
            }




        }
    }
}
