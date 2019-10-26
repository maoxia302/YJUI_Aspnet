using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Web;
using System.Data.SqlClient;
using YJUI.UI;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// sql 的摘要说明
    /// </summary>
    public class sql : IHttpHandler
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["SQLConnString"].ToString();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            try
            {
                #region 进入调拨
                if (context.Request.QueryString["action"] == "diaobo")
                {

                    bool i = sql.ExeNonQuery("insert_db", CommandType.StoredProcedure, null);
                    if (i == true)
                    {
                        context.Response.Write("OK");
                    }
                    else
                    {
                        context.Response.Write("FALSE");
                    }
                } 
                #endregion


                #region 发货情况明细
                else if (context.Request.QueryString["action"] == "fhqk")
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(" insert into VOCEN2013..ui_fhqk(djmc,xhdh,xhrq,khbh,khqc,zsl,xhje,fhck)");
                    sb.Append(" select distinct MQ002,TG002,TG003,TG004,TG007,TG033 as 总数量,(TG045+TG046) as 总金额,MC002 from VOCEN2017..COPTG");
                    sb.Append(" left join VOCEN2017..COPTH on  TG001+TG002=TH001+TH002");
                    sb.Append(" left join VOCEN2017..CMSMC on  TH007=MC001");
                    sb.Append(" left join VOCEN2017..CMSMQ on MQ001=TG001");
                    sb.Append(" where  TG023='Y' and TG001=2301 ");
                    sb.Append("  and ((TG004+TG003+TG002) not in (select khbh+xhrq+xhdh from VOCEN2013..ui_fhqk))");
                    int i = ExecuteSql(sb.ToString());
                    if (i > 0)
                    {
                        context.Response.Write("OK");
                    }

                } 
                #endregion
            }
            catch (Exception ex)
            {

                context.Response.Write(ex.Message);
            }
            finally
            {
                context.Response.End();
            }

        }
        public static bool ExeNonQuery(string sql, CommandType type, params SqlParameter[] lists)
        {
            bool bFlag = false;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.CommandType = type;
                if (lists != null)
                {
                    foreach (SqlParameter p in lists)
                    {
                        cmd.Parameters.Add(p);
                    }
                }
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        bFlag = true;
                    }

                }
                catch { ;}
            }
            return bFlag;
        }


        public static int ExecuteSql(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                {
                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }
                        int rows = cmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        connection.Close();
                        throw e;
                    }
                }
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}