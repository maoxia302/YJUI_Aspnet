using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using System.Web;
using System.Web.SessionState;
using NPOI.SS.Formula.Functions;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// ui_jldl1 的摘要说明
    /// </summary>
    public class ui_jldl1 : IHttpHandler, IReadOnlySessionState
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
                    string begindate = context.Request.Params["bdate"];
                    string enddate = context.Request.Params["edate"];
                    string chk = context.Request.Params["chk"];
                    string search = context.Request.Params["txt_word"];
                    List<string> whereList=new List<string>();

                    if (!string.IsNullOrEmpty(begindate)  && !string.IsNullOrEmpty(enddate))
                    {
                        whereList.Add("fksj between '" + begindate + "' and  '" + enddate + "'");
                    }
                    else if (string.IsNullOrEmpty(begindate) == false)
                    {
                       whereList.Add("fksj='"+begindate+"'");
                    }

                    if (chk == "true" && string.IsNullOrEmpty(search) == false)
                    {
                        whereList.Add(" (fkr like '%" + search + "%' or dls like '%" + search + "%')");
                    }
                    string strWhere = "";
                    string strSql = string.Join(" and  ", whereList.ToArray());
                    if (strSql.Length > 1)
                    {
                        strWhere += strSql;
                    }
                    else
                    {
                        strWhere ="1=1";
                    }

                    int pageindex = int.Parse(context.Request["page"]);
                    int pagesize = int.Parse(context.Request.Params["rows"]);
                    string strjson = new BLL.jldl1().getJsonjldl1(pagesize, pageindex, strWhere);
                    context.Response.Write(strjson);
                }
                else if (context.Request.QueryString["action"] == "query")
                {
                    string begindate = context.Request.Params["b_date"];
                    string enddate = context.Request.Params["e_date"];
                    string chk = context.Request.Params["chk"];
                    string search = context.Request.Params["txt_word"];
                    List <string> whereList=new List<string>();
                    if (!string.IsNullOrEmpty(begindate) && !string.IsNullOrEmpty(enddate))
                    {
                        whereList.Add("fksj between '"+begindate+"' and  '"+enddate+"' ");
                    }
                    if (chk=="true")
                    {
                        whereList.Add(" (fkr like '%'+ '" + search + "'+'%' or dls like  '%'+ '" + search + "'+'%')  ");

                    }
                    string whereSql = string.Join(" and  ", whereList.ToArray());
                    string strWhere = "";
                    if (whereSql.Length > 0)
                    {
                        strWhere = strWhere + whereSql;

                    }
                    else
                    {
                        strWhere = "1=1";     
                    }
                    int pageindex = int.Parse(context.Request["page"]);
                    int pagesize = int.Parse(context.Request.Params["rows"]);
                    string strjson = new BLL.jldl1().getJsonjldl1(pagesize, pageindex, strWhere);
                    context.Response.Write(strjson);
                }
                else if (context.Request.Params["action"] == "add")
                {

                    Model.jldl1 model = new Model.jldl1();
                    model.fksj = System.DateTime.Now;
                    model.fkr = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    model.pj = context.Request.Params["pj"];
                    model.fssj = context.Request.Params["fssj"];
                    model.fsdq = context.Request.Params["fsdq"];
                    model.dls = context.Request.Params["dls"];
                    model.dlsdh = context.Request.Params["dlsdh"];
                    model.xlcxx = context.Request.Params["xlcxx"];
                    model.fknr = context.Request.Params["fknr"];
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

                else if (context.Request.Params["action"] == "edit")
                {
                    Model.jldl1 model = new Model.jldl1();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    //context.Response.Write(model);
                    //int id = int.Parse(context.Request.Params["ID"]);

                    //model = new BLL.jldl1().GetModel(id);


                    object obj = context.Request.Params["fksj"];
                    //model.fksj = Convert.ToDateTime(context.Request.Params["fksj"].ToString());
                    model.fkr = context.Request.Params["fkr"];
                    model.pj = context.Request.Params["pj"];
                    model.fssj = context.Request.Params["fssj"];
                    model.fsdq = context.Request.Params["fsdq"];
                    model.dls = context.Request.Params["dls"];
                    model.dlsdh = context.Request.Params["dlsdh"];
                    model.xlcxx = context.Request.Params["xlcxx"];
                    model.fknr = context.Request.Params["fknr"];
                    model.fl = context.Request.Params["fl"];
                    model.jjsfth = context.Request.Params["jjsfth"];
                    model.zrbm = context.Request.Params["zrbm"];
                    model.zrr = context.Request.Params["zrr"];
                    model.ycclrq = context.Request.Params["ycclrq"];
                    model.plga = context.Request.Params["plga"];
                    model.dkhcs = context.Request.Params["dkhcs"];
                    model.wcsj = context.Request.Params["wcsj"];
                    model.kcclcs = context.Request.Params["kcclcs"];
                    model.kcwcrq = context.Request.Params["kcwcrq"];
                    model.gysclcs = context.Request.Params["gysclcs"];
                    model.dsfjh = context.Request.Params["dsfjh"];

                    if (new BLL.jldl1().Update(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }


                }

                    //第三方审核
                else if (context.Request.Params["action"] == "edit_dsfjh")
                {
                    Model.jldl1 model = new Model.jldl1();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.fl = context.Request.Params["fl"];
                    model.dsfjh = context.Request.Params["dsfjh"];

                    if (new BLL.jldl1().Update_dsfjh(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }


                }
                else if (context.Request.Params["action"] == "edit_zrbm")
                {
                    Model.jldl1 model = new Model.jldl1();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.jjsfth = context.Request.Params["jjsfth"];
                    model.zrbm = context.Request.Params["zrbm"];
                    model.zrr = context.Request.Params["zrr"];
                    //第一次处理日期
                    model.ycclrq = Convert.ToString(DateTime.Now);
                    model.plga = context.Request.Params["plga"];
                    model.dkhcs = context.Request.Params["dkhcs"];
                    model.wcsj = context.Request.Params["wcsj"];
                    model.kcclcs = context.Request.Params["kcclcs"];
                    model.kcwcrq = context.Request.Params["kcwcrq"];
                    model.gysclcs = context.Request.Params["gysclcs"]; //供应商处理措施
                    model.gysrq = context.Request.Params["gysrq"]; //供应商完成日期
                    model.nblcgygs = context.Request.Params["nblcgygs"];
                    model.nblcwcrq = context.Request.Params["nblcwcrq"];
                    model.qtcs = context.Request.Params["qtcs"];
                    model.qtcsrq = context.Request.Params["qtcsrq"];


                    // model.dsfjh = context.Request.Params["dsfjh"];

                    if (new BLL.jldl1().Update_zrbm(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }


                }
                else if (context.Request.Params["action"] == "edit_zrbmsh")
                {
                    Model.jldl1 model = new Model.jldl1();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.zrbmsp = context.Request.Params["zrbmsp"];
                    if (new BLL.jldl1().Update_zrbmsh(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }


                }
                else if (context.Request.Params["action"] == "edit_kfhf")
                {
                    Model.jldl1 model = new Model.jldl1();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.hfsjqk = context.Request.Params["hfsjqk"];
                    model.hfwcrq = context.Request.Params["hfwcrq"];
                    if (new BLL.jldl1().Update_hfsjqk(model))
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