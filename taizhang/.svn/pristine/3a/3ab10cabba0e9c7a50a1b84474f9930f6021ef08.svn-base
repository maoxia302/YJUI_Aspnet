using System;
using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;
using System.Xml;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// Summary description for getsession
    /// </summary>
    public class getsession : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Session["user"] == null)
            {
                context.Response.Write("nosession");
                context.Response.End();
            }
            else
            {
                Model.ui_user model = (Model.ui_user)context.Session["user"];
                context.Response.Write(Common.JsonHelper.ToJson(model));
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