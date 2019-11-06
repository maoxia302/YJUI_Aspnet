using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// INVMB 的摘要说明
    /// </summary>
    public class INVMB : IHttpHandler, IRequiresSessionState
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
                string strWhere = " 1=1";
                int pageindex = int.Parse(context.Request["page"]);
                int pagesize = int.Parse(context.Request.Params["rows"]);
                string strjson = new BLL.INVMB().GetListToJson(strWhere, "", (pageindex - 1) * pagesize, pageindex * pagesize);
                context.Response.Write(strjson);
            }
        }
        #endregion

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}