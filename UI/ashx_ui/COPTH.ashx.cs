using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// COPTH 的摘要说明
    /// </summary>
    public class COPTH : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
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
    }
}