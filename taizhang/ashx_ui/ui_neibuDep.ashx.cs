using System;
using System.Collections.Generic;
using System.Web;
using YJUI.DBUtility;
using YJUI.BLL;
using YJUI.Model;
using System.Web.SessionState;
namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// ui_neibuDep 的摘要说明
    /// </summary>
    public class ui_neibuDep : IHttpHandler, IReadOnlySessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            if (context.Session["user"] == null)
            {
                context.Response.Write("nosession");
                context.Response.End();
            }
            if (context.Request.QueryString["action"] == "getall")
            {
                string jsonNeiBuDep = new BLL.ui_neibuDep().getJsonNeiBuDep();

                context.Response.Write(jsonNeiBuDep);
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