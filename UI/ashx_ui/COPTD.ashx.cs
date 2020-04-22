using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// COPTD 的摘要说明
    /// </summary>
    public class COPTD : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Session["user"] == null)
            {
                context.Response.Write("nosession");
                context.Response.End();
            }
            else if (context.Request.QueryString["action"] == "search")
            {
                string strWhere = "1=1  ";
                //var type = context.Request.Params["type"];
                //var bdate = context.Request.Params["bdate"];
                //var edate = context.Request.Params["edate"];
                //strWhere = NewMethod1(strWhere, type, bdate, edate);
                var pageindex = int.Parse(context.Request["page"]);
                var pagesize = int.Parse(context.Request.Params["rows"]);
                var strjson = new BLL.COPTC().GetListToJson(strWhere, "", (pageindex - 1) * pagesize, pageindex * pagesize);
                context.Response.Write(strjson);
            }
            else if (context.Request.Params["action"] == "getCoptd") {

                var db = context.Request.Params["TC001"];
                var dh = context.Request.Params["TC002"];
                string strjson = new BLL.COPTD().coptdToJson(db,dh);
                context.Response.Write(strjson);
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