using System;
using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// Summary description for ui_org
    /// </summary>
    public class ui_org : IHttpHandler, IReadOnlySessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Session["user"] == null)
            {
                context.Response.Write("nosession");
                context.Response.End();
            }
            string type = context.Request.QueryString["type"] ?? "";
            if (!string.IsNullOrEmpty(type)) //数据
            {
                string strJson = new BLL.ui_org().getJson(type);
                context.Response.Write(strJson);
                context.Response.End();
            }
            else
            {
                string action = context.Request.Params["action"];
                if (action == "add")
                {
                    Model.ui_org model = new Model.ui_org();
                    if (!string.IsNullOrEmpty(context.Request.Params["cc"]))
                    {
                        model.fatherid = new Guid(context.Request.Params["cc"]);
                    }
                    model.icon = context.Request.Params["txt_icon"] ?? "";
                    model.orgname = context.Request.Params["txt_orgname"];
                    model.attr_a = context.Request.Params["attr_a"];
                    model.attr_b = context.Request.Params["attr_b"];
                    model.crdate = DateTime.Now;
                    if (new BLL.ui_org().Add(model))
                    {
                        context.Response.Write("ok");
                        context.Response.End();
                    }
                    else
                    {
                        context.Response.Write("err");
                        context.Response.End();
                    }

                }
                if (action == "edit")
                {
                    Model.ui_org model = new Model.ui_org();
                    if (!string.IsNullOrEmpty(context.Request.Params["_parentId"]))
                    {
                        model.fatherid = new Guid(context.Request.Params["_parentId"]);
                    }
                    model.icon = context.Request.Params["iconCls"] ?? "";
                    model.orgname = context.Request.Params["orgname"];
                    model.attr_a = context.Request.Params["attr_a"];
                    model.attr_b = context.Request.Params["attr_b"];
                    model.id = new Guid(context.Request.Params["id"]);
                    // model.crdate = DateTime.Now;
                    if (new BLL.ui_org().Update(model))
                    {
                        context.Response.Write("ok");
                        context.Response.End();
                    }
                    else
                    {
                        context.Response.Write("err");
                        context.Response.End();
                    }
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