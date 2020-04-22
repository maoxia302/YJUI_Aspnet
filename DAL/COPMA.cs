using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using YJUI.DBUtility;

namespace YJUI.DAL
{
    public class COPMA
    {
        public COPMA() { }
        /// <summary>
        /// 获取一条客户记录
        /// </summary>
        /// <param name="ma001"></param>
        /// <returns></returns>
        public Model.COPMA GetCopmaSingle(string ma001)
        {
          string  sql = string.Format("select * from COPMA where 1=1 and MA001={0}",ma001);
            using (SqlConnection conn = new SqlConnection(ConnStrManage.WSGCDB))
            {
                return conn.Query<Model.COPMA>(sql).FirstOrDefault();
            }
        }
    }
}
