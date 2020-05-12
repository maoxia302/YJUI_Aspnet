using System;
using System.Collections.Generic;
using System.Web;
using Newtonsoft.Json.Linq;
namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// Summary description for ui_leftmenu
    /// </summary>
    public class ui_leftmenu : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            var param = context.Request.Params["param"];//获取localhost
            JObject obj = JObject.Parse(param);//解析成其他；
            var username = obj.Value<string>("userName");
            var pwd = obj.Value<string>("pwd");
            Model.ui_user Loginer = new BLL.ui_user().Login(username, pwd);
            string str = new YJUI.BLL.ui_menu().getJsonMenu(Loginer.id);
            context.Response.Write(str);
            context.Response.End();
           
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