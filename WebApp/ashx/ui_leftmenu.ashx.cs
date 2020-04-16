using System;
using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// Summary description for ui_leftmenu
    /// </summary>
    public class ui_leftmenu : IHttpHandler, IRequiresSessionState
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
                string str = new YJUI.BLL.ui_menu().getJsonMenu(model.id);
                context.Response.Write(str);
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