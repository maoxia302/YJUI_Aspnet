using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using YJUI.DBUtility;

namespace YJUI.DAL
{
   public class PURTD
    {
        public PURTD() { }
        private static PURTD dal = null;
        public static PURTD Current
        {
            get
            {
                if (dal == null)
                    dal = new PURTD();
                return dal;
            }
        }

        public IEnumerable<Model.Dtos.PurtdDto>  GetPurtdList(string db, string dh)
        {
            string sql = string.Format("select * from PURTD where TD001='{0}' and TD002='{1}'", db, dh);
            using (SqlConnection conn = new SqlConnection(ConnStrManage.WSGCDB))
            {
                return conn.Query<Model.Dtos.PurtdDto>(sql);
            }
        }
        /// <summary>
    }
}
