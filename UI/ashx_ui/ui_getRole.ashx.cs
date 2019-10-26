using System;
using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// Summary description for ui_getRole
    /// </summary>
    public class ui_getRole : IHttpHandler, IReadOnlySessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Session["user"] == null)
            {
                context.Response.Write("nosession");
                context.Response.End();
            }
            if (context.Request.QueryString["action"] == "getall")
            {
                string jsonRole = new BLL.ui_role().getJsonRole();
                context.Response.Write(jsonRole);
                context.Response.End();
            }

            if (context.Request.QueryString["action"] == "all")
            {
                Guid roleid = Guid.Parse(context.Request.Params["txt"]);
                string jsonRole = new BLL.ui_role().AllMenuAndRole(roleid);
                context.Response.Write(jsonRole);
                context.Response.End();
            }

            else if (context.Request.QueryString["action"] == "add")
            {
                string roleName = context.Request.QueryString["roleName"];
                string roleBeizhu = context.Request.QueryString["roleBeizhu"] ?? "";
                //string roleMenu = context.Request.QueryString["roleMenu"];
                Model.ui_role model = new Model.ui_role();
                model.rolename = roleName;
                model.beizhu = roleBeizhu;
                model.crdate = DateTime.Now;
                if (new BLL.ui_role().Add(model))
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
            else if (context.Request.QueryString["action"] == "setRole")
            {
                string RoleId = context.Request.QueryString["RoleId"];
                string roleMenu = context.Request.QueryString["roleMenu"] ?? "";
                if (new BLL.ui_role().setRole(RoleId, roleMenu))
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
            else if (context.Request.QueryString["action"] == "edit")
            {
                Model.ui_role model = new Model.ui_role();
                model.id = new Guid(context.Request.QueryString["roleid"]);
                model.rolename = context.Request.QueryString["rolename"];
                model.beizhu = context.Request.QueryString["beizhu"] ?? "";
                if (new BLL.ui_role().Update(model))
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
            else if (context.Request.QueryString["action"] == "dele")
            {
                Guid id = new Guid(context.Request.QueryString["roleid"]);
                if (new BLL.ui_role().Delete(id))
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

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}