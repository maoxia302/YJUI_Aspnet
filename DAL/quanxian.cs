using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using YJUI.DBUtility;
namespace YJUI.DAL
{
    public class quanxian
    {
        public quanxian()
        {
        }

        public DataTable GetAllRight(Guid id)
        {
            StringBuilder strSql=new StringBuilder();
            strSql.Append("select * from ui_user_right");
            strSql.Append(" where ");
            strSql.Append(" userid='" + id + "'");
            return DbHelperSQL.Query(strSql.ToString()).Tables[0];
        }
    }
}
