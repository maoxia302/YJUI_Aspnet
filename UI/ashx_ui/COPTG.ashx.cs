using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// COPTG 的摘要说明
    /// </summary>
    public class COPTG : IHttpHandler, IRequiresSessionState
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
                var strjson = BLL.COPTG.Current.GetListToJson(strWhere, "", (pageindex - 1) * pagesize, pageindex * pagesize);
                context.Response.Write(strjson);
                context.Response.End();
            }
            //获取一条数据传到前台
            else if (context.Request.Params["action"] == "GetCoptgh")
            {
                var db = context.Request.Params["db"];
                var dh = context.Request.Params["dh"];

                Model.COPTG coptg = BLL.COPTG.Current.GetSingleCoptg(db,dh);
                IEnumerable<Model.COPTH> copths = BLL.COPTH.Current.GetCOPTH(db, dh);
                var qty = copths.Sum(t => t.TH008);
                var amount = copths.Sum(t=>t.TH013);

                List<Dictionary<string, object>> l = new List<Dictionary<string, object>>();
                Dictionary<string, object> d = new Dictionary<string, object>();
                d.Add("TH003", "合计");
                d.Add("TH008", qty);
                d.Add("TH013", amount);
                l.Add(d);
                //foot结束
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic.Add("rows", copths);
                dic.Add("footer", l);
                Dictionary<string, object> d2 = new Dictionary<string, object>();
                d2.Add("coptg", coptg);
                d2.Add("copth", dic);

                string strjson = Common.JsonHelper.ObjToJson(d2);
                context.Response.Write(strjson);
                context.Response.End();







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