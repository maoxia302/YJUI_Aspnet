using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// CMSMQ 的摘要说明
    /// </summary>
    public class CMSMQ : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            if (context.Session["user"] == null)
            {
                context.Response.Write("请登录！");
                return;
            }
            #region 查询
            else if (context.Request.QueryString["action"] == "search")
            {
                string sqlWhere = " 1=1 ";
                sqlWhere += " and MQ003='11'";
                string strjson = new BLL.CMSMQ().GetCmsmqToJson(sqlWhere);
                context.Response.Write(strjson);
                context.Response.End();
            }
            #endregion 



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