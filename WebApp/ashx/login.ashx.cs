using System;
using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// Summary description for login
    /// </summary>
    public class login : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            try
            {
                if (context.Request.Params["action"] == "login")
                {
                    if (context.Session["user"] != null)
                    {
                        Model.ui_user model = (Model.ui_user)context.Session["user"];
                        if (model.account != context.Request.Params["uname"])
                        {
                            context.Response.Write("此浏览器已经有其他用户登录！");
                            return;
                        }
                    }

                    string uname = context.Request.Params["uname"];
                    string pwd = context.Request.Params["pwd"];
                    Model.ui_user Loginer = new BLL.ui_user().Login(uname, pwd);
                    if (Loginer == null)
                    {
                        context.Response.Write("3");
                    }
                    else
                    {
                        context.Session["user"] = Loginer;
                        context.Response.Write("ok");
                    }
                }
                else if (context.Request.Params["action"] == "loginout")
                {
                    context.Session["user"] = null;
                    context.Response.Write("ok");
                }

            }
            catch (Exception ex)
            {
                context.Response.Write(ex.Message);
            }
            finally
            {
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