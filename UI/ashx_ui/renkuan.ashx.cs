using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YJUI.BLL;
using YJUI.Model;
using System.Web.SessionState;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// renkuan 的摘要说明
    /// </summary>
    public class renkuan : IHttpHandler,IReadOnlySessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Session["user"] == null)
            {
                context.Response.Write("noseion");
                return;

            }
            #region 查询
            else if (context.Request.QueryString["action"] == "search")
            {
                //var selectDate = context.Request.Params["selectDate"];
                //var bdate = context.Request.Params["bdate"];
                //var edate = context.Request.Params["edate"];
                //var txtword = context.Request.Params["txtWord"];
                ////convert(char(10),dhsj,120)
                string sqlWhere = " 1=1";
                int pageindex = int.Parse(context.Request["page"]);
                int pagesize = int.Parse(context.Request.Params["rows"]);
                string strjson = new BLL.renkuan().GetJsonRenkuan1(pagesize, pageindex, sqlWhere);
                context.Response.Write(strjson);
            }
            #endregion 

            #region 添加款项
            else if (context.Request.Params["action"] == "add")
                {

                    Model.renkuan model = new Model.renkuan();
                    model.Hmoney = context.Request.Params["money"];
                    model.BankInfo = context.Request.Params["bankinfo"];
                    model.WDate = DateTime.Now;
                    model.HFee = context.Request.Params["fee"];
                    model.Customer = context.Request.Params["customer"];
                    //model.tjxh = context.Request.Params["tjxh"];//凸机型号
                    //model.fdjh = context.Request.Params["fdjh"];//发动机号
                    //model.zjrq = context.Request.Params["zjrq"];//装机日期
                    //model.jhbx = context.Request.Params["jhbx"];//激活保修
                    //model.jhbx = context.Request.Params["jhbx"];//代理地址
                    //model.dls= context.Request.Params["dls"];//代理商
                    //model.gzfsdq = context.Request.Params["gzfsdq"];
                    //model.xlc = context.Request.Params["xlc"];//修理厂
                    //model.lxr = context.Request.Params["lxr"];//联系人
                    //model.xlctel = context.Request.Params["xlctel"];//联系人电话
                    //model.gzxx = context.Request.Params["gzxx"];
                    //model.xxfkr = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    //model.xxfksj = Convert.ToString(DateTime.Now.ToString("yyyy-MM-dd"));//信息反馈时间
                    if (new BLL.renkuan().Add(model))
                    {
                        context.Response.Write("ok");
                    }
                }
            #endregion

            #region 修改认款

            else if (context.Request.Params["action"] == "update")
            {

                Model.renkuan model = new Model.renkuan();
                model.ID = int.Parse(context.Request.Params["ID"]);
                model.Hmoney = context.Request.Params["money"];
                model.BankInfo = context.Request.Params["bankinfo"];
                model.HFee = context.Request.Params["fee"];
                model.Customer = context.Request.Params["customer"];
                if (new BLL.renkuan().Update(model))
                {
                    context.Response.Write("ok");
                }
            }  
            #endregion

            #region 删除代码
            else if (context.Request.Params["action"] == "dele")
            {

                Model.renkuan model = new Model.renkuan();
                model.ID = int.Parse(context.Request.Params["ID"]);
                if (new BLL.renkuan().Delete(model.ID))
                {
                    context.Response.Write("ok");
                }
            }   
            #endregion
      

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