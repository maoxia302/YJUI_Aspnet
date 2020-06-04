using System;
using System.Collections.Generic;
using System.Web;
using YJUI.BLL;
using YJUI.Model;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// ui_neibutaizhang 的摘要说明
    /// </summary>
    public class ui_neibutaizhang : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            try
            {
                //if (context.Session["user"]==null)
                //{
                //    // context.Response.Write("nosession");
                //    context.Response.Write("{\"msg\": \"nosession\"}");
                //    context.Response.End();
                //}
                #region 查询
                 if (context.Request.QueryString["action"] == "search")
                {
                    string strWhere = "1=1  ";
                    string bdate = context.Request.Params["bdate"];
                    string edate = context.Request.Params["edate"];
                    string word = context.Request.Params["fkPerson"];
                    string dep = context.Request.Params["txt_dep"];//反馈部门
                    string par= context.Request.Params["params"];//local
                    JObject obj = JObject.Parse(par);//解析成其他；
                    var username = obj.Value<string>("userName");
                    var pwd = obj.Value<string>("pwd");
                    var fkItem= context.Request.Params["fkItem"];  //反馈部门
                    strWhere = NewMethod(strWhere, bdate, edate, word, dep,fkItem);
                    int pageindex = int.Parse(context.Request["page"]);
                    int pagesize = 5;
                    string strjson = new BLL.neibutaizhang().GetJsonneibuTaizhang(pagesize, pageindex, strWhere);
                    context.Response.Write(strjson);
                }
                #endregion

                #region 添加
                else if (context.Request.Params["action"] == "add")
                {
                    Model.neibutaizhang model = new Model.neibutaizhang();
                    model.fkDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                    string par = context.Request.Params["params"];//local
                    JObject obj = JObject.Parse(par);//解析成其他；

                    var username = obj.Value<string>("userName");

                    var pwd = obj.Value<string>("pwd");
                    Model.ui_user Loginer = new BLL.ui_user().Login(username, pwd);//登录验证
                    model.fkPerson = Loginer.xingming;
                    model.FkDep = Loginer.depname;
                    model.wtDep = context.Request.Params["wtDep"];
                    model.fkItem= context.Request.Params["fkItem"];
                    model.fkDesc = context.Request.Params["fkDesc"];
                    model.fkArea = context.Request.Params["fkArea"];
                    model.fkCustomer = context.Request.Params["fkCustomer"];
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

        public static string NewMethod(string strWhere, string bdate, string edate, string word, string dep,string fkItem)
        {
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
            if (!string.IsNullOrEmpty(dep))
            {
                strWhere += string.Format(" and fkDep like '%{0}%'", dep);
            }
            if (!string.IsNullOrEmpty(fkItem))
            {
                strWhere += string.Format(" and fkItem='{0}'", fkItem);
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