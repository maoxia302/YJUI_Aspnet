using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// LRPLA 的摘要说明
    /// </summary>
    public class LRPLA : IHttpHandler, IRequiresSessionState
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
                string sqlWhere = " 1=1";
                var bdate = context.Request.Params["bdate"];
                var edate = context.Request.Params["edate"];
                var isTiHuo = context.Request.Params["txt_word"];
                var ph = context.Request.Params["ph"];
                var dhwl = context.Request.Params["dhwl"];
               // sqlWhere = NewMethod(sqlWhere, bdate, edate, isTiHuo, ph, dhwl);//查询条件
                int pageindex = int.Parse(context.Request["page"]);
                int pagesize = int.Parse(context.Request.Params["rows"]);
                string strjson = new BLL.chuyun().GetJsonChuYun(pagesize, pageindex, sqlWhere);
                context.Response.Write(strjson);
            }
            #endregion
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