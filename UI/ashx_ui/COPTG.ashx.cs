using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// COPTG 的摘要说明
    /// </summary>
    public class COPTG : IHttpHandler
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
                var strjson = new BLL.COPTG().GetListToJson(strWhere, "", (pageindex - 1) * pagesize, pageindex * pagesize);
                context.Response.Write(strjson);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="type"></param>
        /// <param name="bdate"></param>
        /// <param name="edate"></param>
        /// <returns></returns>
        private static string NewMethod1(string strWhere, string type, string bdate, string edate)
        {
            if (!string.IsNullOrEmpty(bdate))
            {
                strWhere += string.Format("  and  CONVERT(varchar(100), fk_date, 21)>='{0}'", bdate);
            }
            if (!string.IsNullOrEmpty(edate))
            {
                strWhere += string.Format("  and  CONVERT(varchar(100), fk_date, 21)<='{0}'", edate);
            }
            if (!string.IsNullOrEmpty(type) || type == "undefined")
            {
                strWhere += string.Format("  and  fk_type='{0}'", type);
            }

            return strWhere;
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