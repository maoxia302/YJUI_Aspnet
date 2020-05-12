using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.SessionState;
using Microsoft.SqlServer.Server;
using NPOI.SS.Formula.Functions;
using YJUI.BLL;
using YJUI.Model;
namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// TUJI 的摘要说明
    /// </summary>
    public class TUJI : IHttpHandler, IReadOnlySessionState
    {
        BLL.Tuji bll = new YJUI.BLL.Tuji();
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
                #region 查询
                else if (context.Request.QueryString["action"] == "search")
                {
                    var selectDate = context.Request.Params["selectDate"];
                    var bdate = context.Request.Params["bdate"];
                    var edate = context.Request.Params["edate"];
                    var txtword = context.Request.Params["txtWord"];
                    //convert(char(10),dhsj,120)
                    string sqlWhere = " 1=1";
                    if (string.IsNullOrEmpty(bdate) != true)
                    {
                        sqlWhere += string.Format("  and {0}>='{1}'", selectDate, bdate);
                    }
                    if (string.IsNullOrEmpty(edate) != true)
                    {
                        sqlWhere += string.Format("  and  {0}<='{1}'", selectDate, edate);
                    }
                    if (string.IsNullOrEmpty(txtword) == false)
                    {
                        //代理商 or 修理厂，反馈人，故障现象
                        sqlWhere +=
                            string.Format(
                                " and  (fdjh like '%{0}%' or ID like '%{1}%' or xxfkr like '%{2}%' or dls like '%{3}%' or gzxx like '%{4}%')",
                                txtword, txtword, txtword, txtword, txtword);
                        // sqlStr.AppendFormat(" and  (fdjh like '%{0}%' or ID like '%{1}%' or xxfkr like '%{2}%' or dls like '%{3}%' or gzxx like '%{4}%')", txtword, txtword, txtword, txtword,txtword);  
                    }

                    int pageindex = int.Parse(context.Request["page"]);
                    int pagesize = int.Parse(context.Request.Params["rows"]);
                    string strjson = new BLL.Tuji().getJsonTUJI(pagesize, pageindex, sqlWhere);
                    context.Response.Write(strjson);
                }
                #endregion

                #region 添加一条凸机台账信息
                else if (context.Request.Params["action"] == "add_info")
                {

                    Model.TUJI model = new Model.TUJI();
                    model.tjxh = context.Request.Params["tjxh"];//凸机型号
                    model.fdjh = context.Request.Params["fdjh"];//发动机号
                    model.zjrq = context.Request.Params["zjrq"];//装机日期
                    model.brand= context.Request.Params["brand"];//品牌
                    model.jhbx = context.Request.Params["jhbx"];//激活保修
                    model.jhbx = context.Request.Params["jhbx"];//代理地址
                    model.dls = context.Request.Params["dls"];//代理商
                    model.gzfsdq = context.Request.Params["gzfsdq"];
                    model.xlc = context.Request.Params["xlc"];//修理厂
                    model.lxr = context.Request.Params["lxr"];//联系人
                    model.xlctel = context.Request.Params["xlctel"];//联系人电话
                    model.gzxx = context.Request.Params["gzxx"];
                    model.xxfkr = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    model.xxfksj = Convert.ToString(DateTime.Now.ToString("yyyy-MM-dd"));//信息反馈时间
                    if (new BLL.Tuji().Add(model))
                    {
                        context.Response.Write("ok");
                    }
                }
                #endregion

                #region 修改一条凸机台账信息

                else if (context.Request.Params["action"] == "update")
                {

                    Model.TUJI model = new Model.TUJI();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.tjxh = context.Request.Params["tjxh"];//凸机型号
                    model.fdjh = context.Request.Params["fdjh"];//发动机号
                    model.zjrq = context.Request.Params["zjsj"];//装机日期
                    model.jhbx = context.Request.Params["jhbx"];//激活保修
                    model.jhbx = context.Request.Params["jhbx"];//代理地址
                    model.dls = context.Request.Params["dls"];//代理商
                    model.gzfsdq = context.Request.Params["gzfsdq"];
                    model.xlc = context.Request.Params["xlc"];//修理厂
                    model.lxr = context.Request.Params["lxr"];//联系人
                    model.xlctel = context.Request.Params["xlctel"];//联系人电话
                    model.gzxx = context.Request.Params["gzxx"];
                    model.xxfkr = context.Request.Params["xxfkr"];
                    model.xxfksj = Convert.ToString(DateTime.Now.ToString("yyyy-MM-dd"));//信息反馈时间
                    if (new BLL.Tuji().update(model))
                    {
                        context.Response.Write("ok");
                    }
                }
                #endregion

                #region 响应
                else if (context.Request.Params["action"] == "xiangying")
                {
                    Model.TUJI model = new Model.TUJI();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.fenlei = context.Request.Params["fenlei"];
                    model.gzms = context.Request.Params["gzfl"];//故障描述改成质量类故障分类
                    model.zdfx = context.Request.Params["zdfx"];//
                    model.jjfh = context.Request.Params["jjfh"];//旧件返还
                    model.zpje = context.Request.Params["guzhangjian"];//质赔金额改成故障件
                    model.gznr = context.Request.Params["gznr"];//诊断结果
                    model.shclsj = context.Request.Params["shclsj"];
                    model.shclyj = context.Request.Params["shclyj"];
                    model.xxzrr = context.Request.Params["xxzrr"];
                    if (new BLL.Tuji().XiangYing(model))
                    {
                        context.Response.Write("ok");
                    }
                }
                #endregion

                #region 回访满意度调查
                else if (context.Request.Params["action"] == "huifang")
                {
                    Model.TUJI model = new Model.TUJI();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.thhfjg = context.Request.Params["thhfjg"];
                    if (new BLL.Tuji().HuiFang(model))
                    {
                        context.Response.Write("ok");
                    }
                }
                #endregion

                #region 分库到货
                else if (context.Request.Params["action"] == "fenku")
                {
                    Model.TUJI model = new Model.TUJI();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.fkname = context.Request.Params["fkname"];
                    model.fkdhrq = DateTime.Parse(context.Request.Params["fkdhrq"]);
                    if (new BLL.Tuji().FenKuDaoHuo(model))
                    {
                        context.Response.Write("ok");
                    }

                }
                #endregion

                #region 总库到货
                else if (context.Request.Params["action"] == "zongku")
                {
                    Model.TUJI model = new Model.TUJI();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.dhrq = DateTime.Parse(context.Request.Params["dhrq"]);
                    if (new BLL.Tuji().ZkDaoHuo(model)) ;
                    {
                        context.Response.Write("ok");
                    }
                }
                #endregion

                #region 工厂到货
                else if (context.Request.Params["action"] == "gcdaohuo")
                {
                    Model.TUJI model = new Model.TUJI();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.gongchangshrq = DateTime.Parse(context.Request.Params["gongchangshrq"]);
                    if (new BLL.Tuji().GcDaoHuo(model)) ;
                    {
                        context.Response.Write("ok");
                    }
                }
                #endregion

                #region 拆检反馈

                else if (context.Request.Params["action"] == "chaijian")
                {
                    Model.TUJI model = new Model.TUJI();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.cjrq = context.Request.Params["cjrq"];
                    model.cjr = context.Request.Params["cjr"];
                    model.cjfk = context.Request.Params["cjfk"];
                    model.gzbw = context.Request.Params["gzbw"];
                    model.zlpd = context.Request.Params["zlpd"];
                    model.shcjqr = context.Request.Params["shcjqr"];
                    if (new BLL.Tuji().ChaiJian(model))
                    {
                        context.Response.Write("ok");
                    }
                }
                #endregion

                #region （问题整改）

                else if (context.Request.Params["action"] == "zhenggai")
                {
                    Model.TUJI model = new Model.TUJI();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.gjzrr = context.Request.Params["gjzrr"];
                    model.gjfa = context.Request.Params["gjfa"];
                    model.gjrq = context.Request.Params["gjrq"];
                    model.kcclcs = context.Request.Params["kcclcs"];
                    model.kcwcrq = context.Request.Params["kcwcrq"];
                    model.gysclcs = context.Request.Params["gysclcs"];
                    model.gyswcrq = context.Request.Params["gyswcrq"];
                    model.nblcgs = context.Request.Params["nblcgs"];
                    model.nblcwcrq = context.Request.Params["nblcwcrq"];
                    model.qtgjcs = context.Request.Params["qtgjcs"];
                    model.qtwcrq = context.Request.Params["qtwcrq"];
                    model.bs = context.Request.Params["bs"]; //结束
                    //model.gjjs = context.Request.Params["gjjs"];//改进是否
                    if (new BLL.Tuji().ZhengGai(model))
                    {
                        context.Response.Write("ok");
                    }
                }
                #endregion

                #region 产品部确认

                else if (context.Request.Params["action"] == "chanpinbu")
                {
                    Model.TUJI model = new Model.TUJI();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.cpbqr = context.Request.Params["cpbqr"];
                    model.cpbrq = context.Request.Params["cpbrq"];
                    if (new BLL.Tuji().ChanPinBu(model))
                    {
                        context.Response.Write("ok");
                    }
                }
                #endregion

                #region 工厂确认

                else if (context.Request.Params["action"] == "gongchang")
                {
                    Model.TUJI model = new Model.TUJI();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.gcqr = context.Request.Params["gcqr"];
                    model.gcqrrq = context.Request.Params["gcqrrq"];
                    if (new BLL.Tuji().GongChang(model))
                    {
                        context.Response.Write("ok");
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