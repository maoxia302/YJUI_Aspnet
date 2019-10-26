using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.SessionState;
using System.Data.SqlClient;
using YJUI.DBUtility;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// search 的摘要说明
    /// </summary>
    public class search : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //var loginer = context.Session["user"].ToString();
            try
            {
                if (context.Session["user"] == null)
                {
                    context.Response.Write("noseion");
                    return;

                }else if (context.Request.QueryString["action"] == "user_search")
                {
                    string sqltext = "select * from ui_user ";
                    string key = context.Request.Params["txt_search"].Trim();
                    List <string> whereList=new List<string>();
                    List<SqlParameter> parameters=new List<SqlParameter>();
                    if (!string.IsNullOrEmpty(key))
                    {
                        whereList.Add("  account like @account   or  xingming like @xingming  ");
                        SqlParameter parameter=new SqlParameter();
                        parameters.Add(new SqlParameter("@account","%"+key+"%"));
                        parameters.Add(new SqlParameter("@xingming", "%" + key + "%"));

                    }
                    if (whereList.Count > 0)
                    {
                        string strWhere = string.Join("  ", whereList.ToArray());
                    }





                }

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

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}