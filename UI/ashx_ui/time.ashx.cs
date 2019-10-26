using System;
using System.Collections.Generic;
using System.Web;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// time 的摘要说明
    /// </summary>
    public class time : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            System.Timers.Timer timer = new System.Timers.Timer();
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