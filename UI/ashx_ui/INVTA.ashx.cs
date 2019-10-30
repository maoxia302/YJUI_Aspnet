using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// INVTA 的摘要说明
    /// </summary>
    public class INVTA : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Session["user"] == null)
            {
                context.Response.Write("请登录！");
                return;
            }
            #region 查询
            else if (context.Request.Params["action"] == "searchErpNum")
            {
                var danbie = context.Request.Params["orderId"];
                
                var date = context.Request.Params["tim"];
                date = date.Replace("-","");
                string strjson = new BLL.INVTA().GetInvtaErpNum(danbie, date);
                context.Response.Write(strjson);
                context.Response.End();
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