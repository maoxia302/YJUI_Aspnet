using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// CMSMV 的摘要说明
    /// </summary>
    public class CMSMV : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Session["user"] == null)
            {
                context.Response.Write("noseion");
                return;

            }
            #region 查询
            else if (context.Request.QueryString["action"] == "search")
            {
                string sqlWhere = " 1=1 ";
                string strjson = new BLL.CMSMV().GetCmsmvToJson(sqlWhere);
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