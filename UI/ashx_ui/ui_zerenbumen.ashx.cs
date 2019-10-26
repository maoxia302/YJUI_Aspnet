using System;
using System.Collections.Generic;
using System.Web;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// ui_zerenbumen 的摘要说明
    /// </summary>
    public class ui_zerenbumen : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            try
            {
                if (context.Session["user"] == null)
                {
                    context.Response.Write("noseion");
                    return;

                }
                else if (context.Request.QueryString["action"] == "search")
                {
                    string strWhere = "1=1";
                    int pageindex = int.Parse(context.Request["page"]);
                    int pagesize = int.Parse(context.Request.Params["rows"]);
                    string strjson = new BLL.jldl1().getJsonjldl1(pagesize, pageindex, strWhere);
                    context.Response.Write(strjson);


                }
                else if (context.Request.Params["action"] == "add")
                {

                    Model.jldl1 model = new Model.jldl1();
                    model.fksj = DateTime.Now;
                    model.pj = context.Request.Params["pj"];
                    model.fssj = context.Request.Params["fssj"];
                    model.fsdq = context.Request.Params["fsdq"];
                    model.dls = context.Request.Params["dls"];
                    model.dlsdh = context.Request.Params["dlsdh"];
                    model.xlcxx = context.Request.Params["xlcxx"];
                    model.fknr = context.Request.Params["fknr"];
                    model.plga = context.Request.Params["plga"];
                    model.fl = context.Request.Params["fl"];

                    if (new BLL.jldl1().Add(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }

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