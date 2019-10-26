using System;
using System.Collections.Generic;
using System.Web.SessionState;
using System.Web;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// datalist 的摘要说明
    /// </summary>
    public class datalist : IHttpHandler, IReadOnlySessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string json = new BLL.ui_user().GetUser();
            context.Response.Write(json);
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