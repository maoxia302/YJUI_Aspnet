using System;
using System.Collections.Generic;
using System.Web;
using YJUI.BLL;
using System.Web.SessionState;
using YJUI.Model;
namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// ui_neibutaizhang 的摘要说明
    /// </summary>
    public class ui_neibutaizhang : IHttpHandler,IReadOnlySessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            try
            {
                if (context.Session["user"]==null)
                {
                    context.Response.Write("nosession");
                    return;
                }
                #region 查询
                else if (context.Request.QueryString["action"] == "search")
                {
                    string strWhere = "1=1  ";
                    string bdate = context.Request.Params["begindate"];
                    string edate = context.Request.Params["enddate"];
                    string word = context.Request.Params["txt_search"];

                    if (!string.IsNullOrEmpty(bdate))
                    {
                        strWhere += string.Format(" and  fkDate>='{0}'", bdate);
                    }
                    if (!string.IsNullOrEmpty(edate))
                    {
                        strWhere += string.Format(" and  fkDate<='{0}'", edate);
                    }
                    if (!string.IsNullOrEmpty(word))
                    {
                        strWhere += string.Format(" and fkPerson like '%{0}%'", word);
                    }

                    int pageindex = int.Parse(context.Request["page"]);
                    int pagesize = int.Parse(context.Request.Params["rows"]);
                    string strjson = new BLL.neibutaizhang().GetJsonneibuTaizhang(pagesize, pageindex, strWhere);
                    context.Response.Write(strjson);
                } 
                #endregion

                #region 添加
                else if (context.Request.Params["action"] == "add")
                {
                    Model.neibutaizhang model = new Model.neibutaizhang();
                    model.fkDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                    model.fkPerson = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    model.wtDep = context.Request.Params["wtDep"];
                    model.fkDesc = context.Request.Params["fkDesc"];

                    if (new BLL.neibutaizhang().Add(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                } 
                #endregion

                #region 问题处理添加
                else if (context.Request.Params["action"] == "wentichuli_add")
                {
                    Model.neibutaizhang model = new Model.neibutaizhang();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.dyDep = context.Request.Params["dyDep"];
                    model.dyPerson = context.Request.Params["dyPerson"];
                    string dyDate = context.Request.Params["dyDate"];
                    model.dyDate = DateTime.Parse(dyDate);
                    model.dyGaishan = context.Request.Params["dyGaishan"];
                    model.cqFangan = context.Request.Params["cqFangan"];
                    model.cqDate = Convert.ToDateTime(context.Request.Params["cqDate"]);
                    if (new BLL.neibutaizhang().Update(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }

                } 
                #endregion

                else if (context.Request.Params["action"] == "luoshijianhe_add")
                {
                    Model.neibutaizhang model = new Model.neibutaizhang();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.lsDep = context.Request.Params["lsDep"];
                    model.lsJianhe = context.Request.Params["lsJianhe"];
                    string lsdate= context.Request.Params["lsDate"];
                    model.lsDate = DateTime.Parse(lsdate);
                    if (new BLL.neibutaizhang().Update_luoshijianhe(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }

                }
                else if (context.Request.Params["action"] == "manyidupingjia_add")
                {
                    Model.neibutaizhang model = new Model.neibutaizhang();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.myPingjia = context.Request.Params["myPingjia"];
                    model.myPerson = context.Request.Params["myPerson"];
                    string mydate = context.Request.Params["myDate"];
                    model.myDate = DateTime.Parse(mydate);
                    if (new BLL.neibutaizhang().Update_manyidudiaocha(model))
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
                    Model.neibutaizhang model = new Model.neibutaizhang();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.dsJianhe = context.Request.Params["dsJianhe"];
                    model.dsPerson = context.Request.Params["dsPerson"];
                    string dsdate = context.Request.Params["dsDate"];
                    model.dsDate = DateTime.Parse(dsdate);
                    if (new BLL.neibutaizhang().Update_disanfangjianhe(model))
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
                context.Response.Write(ex);
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