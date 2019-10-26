using System;
using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;
using System.Text;  
namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// ui_jldl1 的摘要说明
    /// </summary>
    public class ui_fhqk : IHttpHandler, IReadOnlySessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //var loginer = context.Session["user"].ToString();
            try
            {
                if (context.Session["user"] == null)
                {
                    context.Response.Write("noseion");
                    return;

                }
                else if (context.Request.QueryString["action"] == "search")
                {

                   // string strWhere = "1=1";
                    StringBuilder sb = new StringBuilder();
                    string ss = context.Request.Params["searchValue"];
                    if (string.IsNullOrEmpty(ss) == true)
                    {
                        sb.Append(" 1=1");
                    }
                    else
                    {
                        sb.AppendFormat("  xhdh like '%{0}%' or khqc like '%{1}%' ", ss, ss);    
                    }
                    string strWhere = sb.ToString();
                    int pageindex = int.Parse(context.Request["page"]);
                    int pagesize = int.Parse(context.Request.Params["rows"]);
                    string strjson = new BLL.ui_fhqk().getJsonfhqk(pagesize, pageindex, strWhere);
                    context.Response.Write(strjson);
                }
    
                else if (context.Request.Params["action"] == "edit_sfdc")
                {
                    Model.ui_fhqk model = new Model.ui_fhqk();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.sfdc = context.Request.Params["dianchu"];
                    model.dcsj = context.Request.Params["dcsj"];
                    model.sfjd = context.Request.Params["jidan"];
                    model.beizhu = context.Request.Params["beizhu"];

                   if(new BLL.ui_fhqk().Update_sfdc(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }


                }
                else if (context.Request.Params["action"] == "edit_sffc")
                {
                    Model.ui_fhqk model = new Model.ui_fhqk();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.sffc = context.Request.Params["siji"];
                    model.fcsj = context.Request.Params["fcsj"];
                    model.beizhu = context.Request.Params["beizhu"];

                    if (new BLL.ui_fhqk().Update_sffc(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }


                }

                else if (context.Request.Params["action"] == "edit_ceshi")
                {
                    Model.jldl1 model = new Model.jldl1();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.dls = context.Request.Params["dls"];
                    model.dlsdh = context.Request.Params["dlsdh"];

                    if (new BLL.jldl1().Update_zrbm(model))
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