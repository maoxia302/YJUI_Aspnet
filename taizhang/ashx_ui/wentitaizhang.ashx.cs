using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// shiwu 的摘要说明
    /// </summary>
    public class wentitaizhang : IHttpHandler, IReadOnlySessionState
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
                    var selectDate = context.Request.Params["selectDate"];
                    var bdate = context.Request.Params["bdate"];
                    var edate = context.Request.Params["edate"];
                    var txtword = context.Request.Params["words"];
                    //convert(char(10),dhsj,120)
                    string sqlWhere = " 1=1";
                    if (string.IsNullOrEmpty(bdate) != true)
                    {
                        sqlWhere += string.Format("  and fkDate>='{0}'", bdate);
                    }
                    if (string.IsNullOrEmpty(edate) != true)
                    {
                        sqlWhere += string.Format("  and  fkDate<='{0}'", edate);
                    }
                    if (string.IsNullOrEmpty(txtword) == false)
                    {
                        //代理商 or 修理厂，反馈人，故障现象
                        sqlWhere +=
                            string.Format(
                                " and  (fkPerson like '%{0}%' or ID like '%{1}%' or supportDep like '%{2}%' or receiveDep like '%{3}%' or receivePerson like '%{4}%')",
                                txtword, txtword, txtword, txtword, txtword);
                        // sqlStr.AppendFormat(" and  (fdjh like '%{0}%' or ID like '%{1}%' or xxfkr like '%{2}%' or dls like '%{3}%' or gzxx like '%{4}%')", txtword, txtword, txtword, txtword,txtword);  
                    }
                    int pageindex = int.Parse(context.Request["page"]);
                    int pagesize = int.Parse(context.Request.Params["rows"]);
                    string strjson = new BLL.shiwu().GetJsonShiWu(pagesize, pageindex, sqlWhere);
                    context.Response.Write(strjson);
                }

                #region 添加
                else if (context.Request.Params["action"] == "add")
                {
                    Model.shiwu model = new Model.shiwu();
                    model.fkDate = DateTime.Now;
                    model.fkPerson = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    model.supportDep = context.Request.Params["supportDep"];
                    model.fkDesc = context.Request.Params["fkDesc"];
                    if (new BLL.shiwu().Add(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }
                #endregion

                #region 问题处理
                else if (context.Request.Params["action"] == "wentichuli_add")
                {
                    Model.shiwu model=new Model.shiwu();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.receiveDep = context.Request.Params["dyDep"];
                    model.receivePerson = context.Request.Params["dyPerson"];
                    var a = context.Request.Params["receiveDate"];
                   // model.receiveDate =DateTime.Parse(context.Request.Params["receiveDate"]??DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    model.receiveDate = DateTime.Now;
                    model.tempGaishan = context.Request.Params["dyGaishan"];
                    model.cqFangan = context.Request.Params["cqFangan"];
                    model.cqDate = DateTime.Parse(context.Request.Params["cqDate"] == "" ? DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") : context.Request.Params["cqDate"]);
                    model.endDesc = context.Request.Params["endDesc"];
                    model.endDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    if (new BLL.shiwu().Chuli(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }

                }
                #endregion

                #region  落实检核
                else if (context.Request.Params["action"] == "luoshijianhe_add")
                {
                    Model.shiwu model = new Model.shiwu();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.lsDep = context.Request.Params["lsDep"];
                    model.lsResult = context.Request.Params["lsResult"];
                    model.lsDate = DateTime.Now;
                    if (new BLL.shiwu().Jianhe(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }
                #endregion
                else if (context.Request.Params["action"] == "manyidupingjia_add")
                {
                    Model.shiwu model = new Model.shiwu();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.myPingjia = context.Request.Params["myPingjia"];
                    model.myPerson = context.Request.Params["myPerson"];
                    string mydate = context.Request.Params["myDate"];
                    model.myDate = DateTime.Parse(mydate);
                    if (new BLL.shiwu().PingJia(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }

                else if (context.Request.Params["action"] == "disanfangjianhe_add")
                {
                    Model.shiwu model = new Model.shiwu();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.dsJianhe = context.Request.Params["dsJianhe"];
                    model.dsPerson = context.Request.Params["dsPerson"];
                    model.dsDate = DateTime.Now;
                    if (new BLL.shiwu().DiSanFang(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }


            }
            catch (Exception)
            {
                
                throw;
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