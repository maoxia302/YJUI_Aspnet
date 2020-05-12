using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.SessionState;
using System.Xml;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// Summary description for getsession
    /// </summary>
    public class getsession : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
           // log(context.Session["user"].ToString());
            if (context.Session["user"] == null)
            {
                // context.Response.Write("nosession");
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic.Add("msg","nosession");
                //log(context.Session["user"].ToString());
                string json = Common.JsonHelper.ObjToJson(dic);
                context.Response.Write(json);
                context.Response.End();
            }
            else
            {
                Model.ui_user model = (Model.ui_user)context.Session["user"];
                context.Response.Write(Common.JsonHelper.ToJson(model));

                context.Response.End();
            }
        }
        public void log(string log)
        {
            string path = System.Web.HttpContext.Current.Request.MapPath("/");
            FileStream fs = new FileStream(@path + "log.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(log);
            sw.Close();
            fs.Close();
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