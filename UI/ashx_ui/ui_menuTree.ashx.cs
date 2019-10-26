using System;
using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// Summary description for ui_menuTree
    /// </summary>
    public class ui_menuTree : IHttpHandler,IReadOnlySessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Session["user"] == null)
            {
                context.Response.Write("nosession");
                context.Response.End();
            }
            string guid = context.Request.QueryString["guid"];
            string strJsonTree = new BLL.ui_menu().getJsonTree(guid);
            context.Response.Write(strJsonTree);
            context.Response.End();
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