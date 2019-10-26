using System;
using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;
using YJUI.BLL;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// ui_menu 的摘要说明
    /// </summary>
    public class ui_menu : IHttpHandler, IReadOnlySessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string type = context.Request.QueryString["type"] ?? "";
            if (context.Session["user"] == null)
            {
                context.Response.Write("nosession");
                return;
            }
            else if (!string.IsNullOrEmpty(type))
            {
                string uid = context.Request.QueryString["uid"];
                string strJson = new BLL.ui_menu().getJson(type);
                context.Response.Write(strJson);
                context.Response.End();
            }
            //
            else if (context.Request.Params["action"] == "user")
            {
                string json = new BLL.ui_user().GetUser();
                context.Response.Write(json);
            }
            else if (context.Request.Params["action"] == "all")
            {
                string json = new BLL.ui_menu().getJSONMenu();
                context.Response.Write(json);
            }
             
            else if (context.Request.Params["action"] == "add")
            {
                Model.ui_menu model = new Model.ui_menu();

                model.menuorder = int.Parse(context.Request["menuorder"]);
                model.fatherid = int.Parse(context.Request["fatherid"]);
                model.menuname = context.Request["menuname"];
                model.icon = context.Request["icon"];
                model.url = context.Request["url"];
                model.crdate = DateTime.Now;
                if (new BLL.ui_menu().Add(model)>0)
                {
                    context.Response.Write("ok");
                }
            }
            else if (context.Request.Params["action"] == "update")
            {
                Model.ui_menu model = new Model.ui_menu();
                model.id = int.Parse(context.Request["id"]);
                model.menuorder = int.Parse(context.Request["menuorder"]);
                model.fatherid = int.Parse(context.Request["fatherid"]);
                model.menuname = context.Request["menuname"];
                model.icon = context.Request["icon"];
                model.url = context.Request["url"];
                model.crdate = DateTime.Now;
                if (new BLL.ui_menu().Update(model))
                {
                    context.Response.Write("ok");
                }
            }
            else if (context.Request.Params["action"] == "del")
            {
                Model.ui_menu model = new Model.ui_menu();
                model.id = int.Parse(context.Request["id"]);
                if (new BLL.ui_menu().Delete(model.id))
                {
                    context.Response.Write("ok");
                }
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