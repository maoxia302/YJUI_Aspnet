using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
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
        public void BulkCopySheJi(DataTable dt)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SQLConnString_New"].ToString();
            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connectionString))
            {
                bulkCopy.DestinationTableName = "ui_shejitaizhang"; //插入目标表
                bulkCopy.ColumnMappings.Add("产品小组", "Pteam");
                bulkCopy.ColumnMappings.Add("提报日期", "SubmitDate");
                bulkCopy.ColumnMappings.Add("预计完成时间", "PreTime");
                bulkCopy.ColumnMappings.Add("产品名称", "Item");
                bulkCopy.ColumnMappings.Add("OEM", "oem");
                bulkCopy.ColumnMappings.Add("规格/适用车型", "Specification");
                bulkCopy.ColumnMappings.Add("单位", "Unit");
                bulkCopy.ColumnMappings.Add("新品类", "NewCategory");
                bulkCopy.ColumnMappings.Add("新品号", "NewItem");
                bulkCopy.ColumnMappings.Add("品牌", "Brand");
                bulkCopy.ColumnMappings.Add("打标", "Marking");
                bulkCopy.ColumnMappings.Add("打标信息厂家代码", "Markfactory");
                bulkCopy.ColumnMappings.Add("产品标签", "ItemLable");
                bulkCopy.ColumnMappings.Add("包装", "Packing");
                bulkCopy.ColumnMappings.Add("包装类型", "PackingType");
                bulkCopy.ColumnMappings.Add("包装尺寸", "PackageSize");
                bulkCopy.ColumnMappings.Add("包装标签", "PackageLabel");
                bulkCopy.ColumnMappings.Add("物流箱", "Box");
                bulkCopy.ColumnMappings.Add("物流箱尺寸", "BoxSize");
                bulkCopy.ColumnMappings.Add("外箱标签", "OuterLabel");
                bulkCopy.ColumnMappings.Add("备注", "Remark");
                bulkCopy.WriteToServer(dt); //数据源表
            }




        }
    }
}
