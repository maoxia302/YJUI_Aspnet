using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// ui_guzhang 的摘要说明
    /// </summary>
    public class ui_guzhang : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Request.QueryString["action"] == "getall")
            {
                string guzhang = new BLL.ui_guzhang().GetGuZhangToJson();
                context.Response.Write(guzhang);
                context.Response.End();
            }else if (context.Request.Params["action"] == "guzhangjian")
                {
                    string guzhang = new BLL.ui_guzhang().GetGuZhangJianToJson();
                    context.Response.Write(guzhang);
                    context.Response.End();
                }
            else if (context.Request.Params["action"] == "tjxh")
            {
                string guzhang = new BLL.ui_guzhang().GetFaDongJiXingHaoToJson();
                context.Response.Write(guzhang);
                context.Response.End();
            }
            //反馈所属项目
            else if (context.Request.Params["action"] == "getItem")
            {
                string guzhang = new BLL.ui_guzhang().GetItemToJson();
                context.Response.Write(guzhang);
                context.Response.End();
            }
            else if (context.Request.Params["action"] == "ht_dep")
            {
                string guzhang = new BLL.ui_guzhang().GetDepToJson();
                context.Response.Write(guzhang);
                context.Response.End();
            }
            else if (context.Request.Params["action"] == "ht_person")
            {
                string guzhang = new BLL.ui_guzhang().GetPersonToJson();
                context.Response.Write(guzhang);
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