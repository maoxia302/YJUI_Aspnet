using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// ui_tuji 的摘要说明
    /// </summary>
    public class ui_tuji : IHttpHandler, IReadOnlySessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            if (context.Session["user"] == null)
            {
                context.Response.Write("nosession");
                context.Response.End();
            }
            else if (context.Request.QueryString["action"] == "search")
            {
                string strWhere = "1=1  ";
                var type = context.Request.Params["type"];
                var bdate = context.Request.Params["bdate"];
                var edate = context.Request.Params["edate"];
                strWhere = NewMethod1(strWhere, type, bdate, edate);
                var pageindex = int.Parse(context.Request["page"]);
                var pagesize = int.Parse(context.Request.Params["rows"]);
                var strjson = new BLL.ui_tuji().GetListToJson(strWhere, "", (pageindex - 1) * pagesize, pageindex * pagesize);
                context.Response.Write(strjson);
            }
            else if (context.Request.Params["action"] == "add")
            {
                Model.ui_tuji model = new Model.ui_tuji();
                model.fk_date = DateTime.Now;


                model.fk_person = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                model.fk_dep = (context.Session["user"] as YJUI.Model.ui_user).depname;
                model.fk_area = context.Request.Params["fk_area"];
                model.fk_customer = context.Request.Params["fk_customer"];
                model.fk_type = context.Request.Params["fk_type"];
                model.fk_dec = context.Request.Params["fk_dec"];
                if (new BLL.ui_tuji().Insert(model))
                {
                    context.Response.Write("ok");
                }
            }
           else if (context.Request.Params["action"] == "zhuanxiang_add")
            {
                Model.ui_tuji model = new Model.ui_tuji();
                model.ID=int.Parse(context.Request.Params["ID"]);
                model.zx_look = context.Request.Params["zx_look"];
                model.zx_is= context.Request.Params["zx_is"];

                if (new BLL.ui_tuji().Zhuanxiang_add(model))
                {
                    context.Response.Write("ok");
                }
            }

            else if (context.Request.Params["action"] == "houtai_add")
            {
                Model.ui_tuji model = new Model.ui_tuji();
                model.ID = int.Parse(context.Request.Params["ID"]);
                model.ht_dep = context.Request.Params["ht_dep"];
                model.ht_person = context.Request.Params["ht_person"];
                model.ht_lqdate = DateTime.Now;
                model.ht_predate = DateTime.Parse(context.Request.Params["ht_predate"]);
                model.ht_status = context.Request.Params["ht_status"];
                if (new BLL.ui_tuji().Houtai_add(model))
                {
                    context.Response.Write("ok");
                }
            }
            else if (context.Request.Params["action"] == "kefu_add")
            {
                Model.ui_tuji model = new Model.ui_tuji();
                model.ID = int.Parse(context.Request.Params["ID"]);
                model.service = context.Request.Params["service"];
                model.service_date = DateTime.Parse(context.Request.Params["service_date"]);

                if (new BLL.ui_tuji().Kefu_add(model))
                {
                    context.Response.Write("ok");
                }
            }



            #region 导出

            if (context.Request.Params["action"] == "export")
            {

                string strWhere = "1=1  ";
                var type = context.Request.Params["type"];
                var bdate = context.Request.Params["bdate"];
                var edate = context.Request.Params["edate"];
                DataSet ds=  new BLL.ui_tuji().GetReport(NewMethod1( strWhere, type,  bdate,  edate));

              string str = "序号,反馈时间,反馈人,反馈部门,反馈地区,反馈客户,问题类型,反馈描述,专项调查,真问题呈现,后台支持团队,对接人员,领取时间,预计完成时间,问题处理状态,反馈客户,客服反馈给客户时间";
              Common.NpoiHelper.ToExcelByNpoi(ds.Tables[0], str);
            } 
            #endregion

        }

        private static string NewMethod1(string strWhere, string type, string bdate, string edate)
        {
            if (!string.IsNullOrEmpty(bdate))
            {
                strWhere += string.Format("  and  CONVERT(varchar(100), fk_date, 21)>='{0}'", bdate);
            }
            if (!string.IsNullOrEmpty(edate))
            {
                strWhere += string.Format("  and  CONVERT(varchar(100), fk_date, 21)<='{0}'", edate);
            }
            if (!string.IsNullOrEmpty(type) || type== "undefined")
            {
                strWhere += string.Format("  and  fk_type='{0}'", type);
            }

            return strWhere;
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