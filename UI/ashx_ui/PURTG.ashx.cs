using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// PURTG 的摘要说明
    /// </summary>
    public class PURTG : IHttpHandler, IRequiresSessionState
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
                var strjson = BLL.PURTG.Current.GetListToJson(strWhere, "", (pageindex - 1) * pagesize, pageindex * pagesize);
                context.Response.Write(strjson);
                context.Response.End();
            }
            else if (context.Request.Params["action"] == "GetSingle") {
                var db = context.Request.Params["db"];
                var dh = context.Request.Params["dh"];
                Model.PURTG purtg = BLL.PURTG.Current.GetSingleModel(db,dh);//单头
                IEnumerable<Model.PURTH> purths = BLL.PURTH.Current.GetModelList(db,dh);
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic.Add("purtg",purtg);
                dic.Add("purth", purths);
                string strjson = Common.JsonHelper.ObjToJson(dic);
                context.Response.Write(strjson);
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