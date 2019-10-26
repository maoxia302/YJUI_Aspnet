using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Web;
using System.Web.SessionState;
using System.Data;
using NPOI.POIFS.Storage;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// Summary description for ui_user
    /// </summary>
    public class ui_user : IHttpHandler, IReadOnlySessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            try
            {
                if (context.Session["user"] == null)
                {
                    context.Response.Write("nosession");
                    return;
                }
                else if (context.Request.QueryString["action"] == "search")
                {
                    StringBuilder sb = new StringBuilder();
                    string key = context.Request.Params["txt_search"];
                    List<string> whereList = new List<string>();
                    if (string.IsNullOrEmpty(key) == false)
                    {
                        whereList.Add(" (account like '%" + key + "%' or xingming like '%" + key + "%')");
                    }
                    string strWhere = "";
                    string strSql = string.Join(" and  ", whereList.ToArray());
                    if (strSql.Length > 1)
                    {
                        strWhere += strSql;
                    }
                    else
                    {
                        strWhere = "1=1";
                    }
                    int pageindex = int.Parse(context.Request["page"]);
                    int pagesize = int.Parse(context.Request.Params["rows"]);
                    string strjson = new BLL.ui_user().getJsonUser(pagesize, pageindex, strWhere);
                    context.Response.Write(strjson);



                }

                else if (context.Request.Params["action"] == "add")
                {
                    Model.ui_user model = new Model.ui_user();
                    model.id = Guid.NewGuid();
                    model.account = context.Request.Params["account"];
                    model.password = context.Request.Params["password"];
                    model.xingming = context.Request.Params["xingming"];
                    model.sex = context.Request.Params["sex"];
                    model.birth = context.Request.Params["birth"];
                    model.sfz = context.Request.Params["sfz"];
                    model.tel = context.Request.Params["tel"];
                    model.dizhi = context.Request.Params["dizhi"];
                    model.email = context.Request.Params["email"];
                    model.qq = context.Request.Params["qq"];
                    model.crdate = DateTime.Now;
                    string user_role = context.Request["cb_role"];
                    string user_org = context.Request["ct_org"];
                    if (new BLL.ui_user().Add(model, user_role, user_org))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }

                }
                else if (context.Request.Params["action"] == "edit")
                {
                    Model.ui_user model = new Model.ui_user();
                    model.id = new Guid(context.Request.Params["id"]);
                    model.account = context.Request.Params["account"];
                    model.password = context.Request.Params["password"];
                    model.xingming = context.Request.Params["xingming"];
                    model.sex = context.Request.Params["sex"];
                    model.birth = context.Request.Params["birth"];
                    model.sfz = context.Request.Params["sfz"];
                    model.tel = context.Request.Params["tel"];
                    model.dizhi = context.Request.Params["dizhi"];
                    model.email = context.Request.Params["email"];
                    model.qq = context.Request.Params["qq"];

                    if (new BLL.ui_user().Update(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }

                }
                else if (context.Request.Params["action"] == "dele")
                {
                    string id = context.Request.Params["id"].Trim(',');

                    if (new BLL.ui_user().DeleteList(id))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }


                }
                else if (context.Request.Params["action"] == "setrole")
                {
                    string ids = context.Request.Params["ID"].Trim(',');
                    string role = context.Request.Params["cb_role"] ?? "";
                    if (new BLL.ui_user().setrole(ids, role))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }
                else if (context.Request.Params["action"] == "setorg")
                {
                    string ids = context.Request.Params["id"].Trim(',');
                    string orgs = context.Request.Params["ct_org"] ?? "";
                    if (new BLL.ui_user().setorg(ids, orgs))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }
                else if (context.Request.Params["action"] == "user")
                {
                    string json = new BLL.ui_user().GetUser();
                    context.Response.Write(json);
                    
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
