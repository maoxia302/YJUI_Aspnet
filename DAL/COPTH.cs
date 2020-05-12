using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using YJUI.DBUtility;

namespace YJUI.DAL
{
   public class COPTH
    {
        public COPTH() { }
        private static COPTH dal = null;
        public static COPTH Current
        {
            get
            {
                if (dal == null)
                    dal = new COPTH();
                return dal;
            }
        }
        /// <summary>
        /// 根据单别获取单号
        /// </summary>
        /// <param name="danbie"></param>
        /// <returns></returns>
        public string GetCOPTHErpNo(string danbie)
        {
            return ErpUtil.GetErpNum("COPTH", "TG001", danbie, "TG002", "TG042");
        }
        /// <summary>
        /// 获取一个实体COPTH
        /// </summary>
        /// <param name="tg001"></param>
        /// <param name="tg002"></param>
        /// <returns></returns>
        public  IEnumerable<Model.COPTH> GetCOPTH(string db, string dh)
        {
            string sql = string.Format("select * from COPTH where 1=1 and TH001='{0}' and TH002='{1}'", db, dh);
            using (SqlConnection conn = new SqlConnection(ConnStrManage.WSGCDB))
            {
                return conn.Query<Model.COPTH>(sql);
            }

        }


    }
}
