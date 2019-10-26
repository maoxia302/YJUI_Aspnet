using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using YJUI.BLL;
namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// quanxian 的摘要说明
    /// </summary>
    public class quanxian : IHttpHandler, IReadOnlySessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Request.QueryString["action"] == "quanxian")
            {
                var userid = Guid.Parse(context.Request.Params["userid"]);
                BLL.quanxian bll = new BLL.quanxian();
                string strjson=bll.getJsonRight(userid);
                context.Response.Write(strjson);
            }
                //取flag的值
            else if (context.Request.Params["action"] == "isshow")
            {
                int id = int.Parse(context.Request.Params["id"]);
                BLL.ui_gongyingshang bll=new BLL.ui_gongyingshang();
                var flag = bll.GetFlagById(id);


                context.Response.Write(flag);
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