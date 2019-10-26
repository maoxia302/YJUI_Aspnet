using System;
using System.Collections.Generic;
using System.Net.Configuration;
using System.Text;
using System.Web;
using System.Web.SessionState;
using NPOI.SS.Formula.Functions;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// ui_diaobo 的摘要说明
    /// </summary>
    public class ui_diaobo : IHttpHandler,IReadOnlySessionState
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
                    StringBuilder sb = new StringBuilder();
                    string diaobo = context.Request.Params["diaobo_search"];
                    if (string.IsNullOrEmpty(diaobo) == true)
                    {
                        sb.Append(" 1=1");
                    }
                    else
                    {
                        sb.AppendFormat("  bmmc like '%{0}%' or dh like '%{1}%' ", diaobo, diaobo);
                    }
                    string strWhere = sb.ToString();
                    int pageindex = int.Parse(context.Request["page"]);
                    int pagesize = int.Parse(context.Request.Params["rows"]);
                    string strjson = new BLL.ui_diaobo().getJsondiaobo(pagesize, pageindex, strWhere);
                    context.Response.Write(strjson);
                }
                else if (context.Request.QueryString["action"] == "search2")
                {
                    string begindate = context.Request["txt_begindate"];
                    string enddate = context.Request["txt_enddate"];
                    string chk = context.Request.Params["chk_key"];
                    string key = context.Request.Params["txt_key"];
                    StringBuilder sb = new StringBuilder();
                    string diaobo = context.Request.Params["diaobo_search"];
                    string strWhere ="1=1  ";
                    if (string.IsNullOrEmpty(begindate) == false)
                    {
                        strWhere += string.Format(" and convert(char(10),dhsj,120)>={0}", begindate);
                    }
                    if (string.IsNullOrEmpty(enddate) == false)
                    {
                        strWhere += string.Format(" and convert(char(10),dhsj,120)<={0}", enddate);
                    }
                    if (string.IsNullOrEmpty(key) == false && chk == "true")
                    {
                        strWhere = strWhere + string.Format(" and zrck like '%{0}%' or shr like '%{1}%' or dh like '%{2}%' or dbsj like '%{3}%' ", key, key, key, key);
                    }
                    int pageindex = int.Parse(context.Request["page"]);
                    int pagesize = int.Parse(context.Request.Params["rows"]);
                    string strjson = new BLL.ui_diaobo().getJsondiaobo(pagesize, pageindex, strWhere);
                    context.Response.Write(strjson);
                }

                #region 是否入库查询
                else if (context.Request.QueryString["action"] == "search3")
                {
                    string begindate = context.Request["bdate"];
                    string enddate = context.Request["edate"];
                    string chk = context.Request.Params["chk"];
                    string key = context.Request.Params["txt_word"];
                    StringBuilder sb = new StringBuilder();
                    string diaobo = context.Request.Params["diaobo_search"];
                    if (string.IsNullOrEmpty(begindate) == true && string.IsNullOrEmpty(enddate) == true)
                    {
                        sb.Append(" 1=1");
                    }
                    else if (string.IsNullOrEmpty(begindate) == false && string.IsNullOrEmpty(enddate) == false)
                    {
                        sb.AppendFormat(" convert(char(10),dhsj,120)  between '{0}' and '{1}'", begindate, enddate);
                    }
                    else if (string.IsNullOrEmpty(begindate) == false)
                    {
                        sb.AppendFormat("  convert(char(10),dhsj,120)='{0}'", begindate);
                    }
                    string strWhere = sb.ToString();
                    if (chk == "true" && string.IsNullOrEmpty(key) == false)
                    {
                        strWhere = strWhere + string.Format(" and zrck like '%{0}%' or shr like '%{1}%' or dh like '%{2}%' or dbsj like '%{3}%' ", key, key, key,key);
                    }
                    int pageindex = int.Parse(context.Request["page"]);
                    int pagesize = int.Parse(context.Request.Params["rows"]);
                    string strjson = new BLL.ui_diaobo().getJsondiaobo(pagesize, pageindex, strWhere);
                    context.Response.Write(strjson);
                } 
                #endregion

                else if (context.Request.QueryString["action"] == "search4")
                {
                    string begindate = context.Request["txtbenindate"];
                    string enddate = context.Request["txtenddate"];
                    string chk = context.Request.Params["chk"];
                    string key = context.Request.Params["txtkey"];
                    StringBuilder sb = new StringBuilder();
                    string diaobo = context.Request.Params["diaobo_search"];
                    if (string.IsNullOrEmpty(begindate) == true && string.IsNullOrEmpty(enddate) == true)
                    {
                        sb.Append(" 1=1");
                    }
                    else if (string.IsNullOrEmpty(begindate) == false && string.IsNullOrEmpty(enddate) == false)
                    {
                        sb.AppendFormat("convert(char(10),dhsj,120) between '{0}' and '{1}'", begindate, enddate);
                    }
                    else if (string.IsNullOrEmpty(begindate) == false)
                    {
                        sb.AppendFormat("  convert(char(10),dhsj,120)='{0}'", begindate);
                    }
                    string strWhere = sb.ToString();
                    if (chk == "true" && string.IsNullOrEmpty(key) == false)
                    {
                        strWhere = strWhere + string.Format(" and zrck like '%{0}%' or shr like '%{1}%' or dh like '%{2}%'", key, key, key);
                    }
                    int pageindex = int.Parse(context.Request["page"]);
                    int pagesize = int.Parse(context.Request.Params["rows"]);
                    string strjson = new BLL.ui_diaobo().getJsondiaobo(pagesize, pageindex, strWhere);
                    context.Response.Write(strjson);
                }
                else if (context.Request.Params["action"] == "add_diaobo")
                {
                    Model.ui_diaobo model=new Model.ui_diaobo();
                    model.ID = int.Parse(context.Request.Params["ID"]);//获取ID
                    model.sfqh = context.Request.Params["sfqh"];//是否缺货
                    model.shr = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    model.qhbz = context.Request.Params["qhbz"];//缺货备注
                    model.dhsj = DateTime.Now; //到货时间
                    if (new BLL.ui_diaobo().Update_sfdh(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }

                #region 挑拨是否入账，生成2017帐套调拨单

                //是否入账
                else if (context.Request.Params["action"] == "add_sfrz")
                {
                    BLL.ui_diaobo bll = new BLL.ui_diaobo();
                    Model.ui_diaobo model = new Model.ui_diaobo();
                    model.ID = int.Parse(context.Request.Params["ID"]);//获取ID
                    model.sfrz = context.Request.Params["sfrz"];//是否缺货
                    model.rzr = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    model.rzsj = DateTime.Now; ; //到货时间

                    var yuandanbie = context.Request.Params["yuandanbie"];
                    var yuandanhao = context.Request.Params["yuandanhao"];
                    var xindanbie = context.Request.Params["xindanbie"];
                    var xindanhao = context.Request.Params["xindanhao"];
                    var bumen = context.Request.Params["bumen"];
                    var diaochucangku = context.Request.Params["diaochucangku"];
                    var diaorucangku = context.Request.Params["diaorucangku"];
                    var beizhu = context.Request.Params["beizhu"];
                    var zhangtao = context.Request.Params["zhangtao"];

                   int r= bll.AddDiaoBo(zhangtao,yuandanbie, yuandanhao,xindanhao, bumen,beizhu, diaochucangku, diaorucangku);
                   if (r > 0)
                   {
                       if (new BLL.ui_diaobo().Update_sfzr(model))
                       {
                           context.Response.Write("ok");

                       }
                       else {
                           context.Response.Write("err");
                       }
               
                   }        
                   else{
                          context.Response.Write("err");
                       }
              
                } 
                #endregion

                    //
                #region 处理状况
                else if (context.Request.Params["action"] == "add_clzk")
                {
                    Model.ui_diaobo model = new Model.ui_diaobo();
                    model.ID = int.Parse(context.Request.Params["ID"]);//获取ID
                    model.clzk = context.Request.Params["clzk"];//是否缺货
                    //model.rzr = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    model.bz = context.Request.Params["bz"];
                    model.clsj = DateTime.Now; ; //到货时间
                    if (new BLL.ui_diaobo().Update_clzk(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                } 
                #endregion



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