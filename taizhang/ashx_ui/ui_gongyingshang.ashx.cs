using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.SessionState;
using NPOI.HSSF.UserModel;
using NPOI.POIFS.Storage;
using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using YJUI.BLL;
namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// ui_gongyingshang 的摘要说明
    /// </summary>
    public class ui_gongyingshang : IHttpHandler, IReadOnlySessionState
    {
        BLL.ui_gongyingshang bll = new BLL.ui_gongyingshang();
        public void ProcessRequest(HttpContext context)
        {
            int stepid;
            context.Response.ContentType = "text/plain";
            try
            {
                if (context.Session["user"] == null)
                {
                    context.Response.Write("nosession");
                    return;
                }
                #region 查询
                else if (context.Request.QueryString["action"] == "search")
                {
                    string strWhere = "  1=1";
                    string key = context.Request.Params["txt_word"];
                    string bdate=context.Request.Params["begindate"];
                    string edate=context.Request.Params["enddate"];
                    if (!string.IsNullOrEmpty(key))
                    {
                        strWhere += string.Format(" and suppliername like '%{0}%'", key);
                    }
                    if (!string.IsNullOrEmpty(bdate))
                    {
                        strWhere += string.Format(" and regdate >={0}", bdate);
                    }
                    if (!string.IsNullOrEmpty(edate))
                    {
                        strWhere += string.Format(" and regdate <={0}", edate);
                    }
                    int pageindex = int.Parse(context.Request["page"]);
                    int pagesize = int.Parse(context.Request.Params["rows"]);
                    string strjson = new BLL.ui_gongyingshang().GetJsonGongYingShang(pagesize, pageindex, strWhere);
                    context.Response.Write(strjson);


                }
                #endregion
                #region 添加一个到货信息信息
                else if (context.Request.Params["action"] == "daohuo")
                {
                    DateTime dateTime = DateTime.Parse(context.Request.Params["arrdate"].ToString());
                    Model.ui_gongyingshang model = new Model.ui_gongyingshang();
                    model.id = int.Parse(context.Request.Params["id"]);
                    model.arrdate = DateTime.Parse(context.Request.Params["arrdate"].ToString());
                    model.arr_date = DateTime.Parse(DateTime.Now.ToString());
                    model.arrperson = (context.Session["user"] as YJUI.Model.ui_user).xingming;//登记人
                    model.arr_remark = context.Request.Params["arr_remark"];
                    model.flag = 19;
                   // model.lastdate = dateTime;
                    stepid = 1;//第1部更新卸货标准时间
                    if (new BLL.ui_gongyingshang().Add_DaoHuo(model))
                    {
                        //if (bll.UpdateStdDate(model.id, stepid)>0)
                        //{
                        //    context.Response.Write("ok");
                        //}   
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }
                #endregion

                #region 添加一个供应商信息
                else if (context.Request.Params["action"] == "add")
                {
                    // DateTime dateTime = DateTime.Parse(context.Request.Params["arrdate"].ToString());
                    Model.ui_gongyingshang model = new Model.ui_gongyingshang();
                    model.regdate = DateTime.Now;
                    model.yddate = DateTime.Parse(context.Request.Params["yddate"].ToString());
                    model.regperson = (context.Session["user"] as YJUI.Model.ui_user).xingming;//登记人
                    model.dep = context.Request.Params["dep"];
                    model.cate = context.Request.Params["cate"];
                    model.category = context.Request.Params["category"];
                    model.suppliername = context.Request.Params["suppliername"];
                    //model.suppliertel = context.Request.Params["suppliertel"];
                    //
                    model.total = decimal.Parse(context.Request.Params["total"]);
                    // model.totals = decimal.Parse(context.Request.Params["totals"]);
                    model.flag = 1;
                    //model.lastdate = dateTime;
                    if (new BLL.ui_gongyingshang().Add_info(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }
                #endregion
                #region 添加一个卸车信息信息
                else if (context.Request.Params["action"] == "xieche")
                {
                    DateTime dateTime = DateTime.Parse(context.Request.Params["uploadrealdate"].ToString());
                    Model.ui_gongyingshang model = new Model.ui_gongyingshang();
                    model.id = int.Parse(context.Request.Params["id"]);
                   // model.arrdate = DateTime.Parse(context.Request.Params["arrdate"].ToString());
                    model.uploadrealdate = dateTime;
                    model.uploaddate = DateTime.Parse(DateTime.Now.ToString());
                    model.uploadperson = (context.Session["user"] as YJUI.Model.ui_user).xingming;//登记人
                    model.uploadremark = context.Request.Params["uploadremark"];
                    model.flag = 2;
                    model.lastdate = dateTime;
                    stepid = 1;//第1部更新卸货标准时间
                    if (new BLL.ui_gongyingshang().Add_XieChe(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }
                #endregion

                #region 第三步骤：添加质检信息3
                else if (context.Request.Params["action"] == "zhijian")
                {
                    DateTime dateTime = DateTime.Parse(context.Request.Params["testrealdate"].ToString());
                    Model.ui_gongyingshang model = new Model.ui_gongyingshang();
                    model.id = int.Parse(context.Request.Params["id"]);
                    model.testrealdate = dateTime;
                    model.testperson = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    model.testremark = context.Request.Params["testremark"];
                    model.testdate = DateTime.Now;
                    model.flag = 3;
                    model.lastdate = dateTime;
                    stepid = 2;
                    if (new BLL.ui_gongyingshang().Add_ZhiJian(model))
                    {
                        //if (bll.UpdateStdDate(model.id, stepid) > 0)
                        //{
                        //    context.Response.Write("ok");
                        //} 
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }
                #endregion

                #region 第4-1部 添加未成品收货信息
                else if (context.Request.Params["action"] == "wshouhuo")
                {

                    DateTime dateTime = DateTime.Parse(context.Request.Params["wRecrealdate"].ToString());
                    Model.ui_gongyingshang model = new Model.ui_gongyingshang();
                    model.id = int.Parse(context.Request.Params["id"]);
                    model.wRecrealdate = dateTime;
                    model.wRecperson = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    // model.wRecnum = int.Parse(context.Request.Params["wRecnum"]);
                    //model.wRecnum = int.Parse(context.Request.Params["recnums"]);
                    model.wRecremark = context.Request.Params["wRecremark"];
                    model.wRecdate = DateTime.Now;
                    model.flag = 4;
                    model.lastdate = dateTime;
                    stepid = 3;
                    if (new BLL.ui_gongyingshang().Add_ShouHuo(model))
                    {
                        //if (bll.UpdateStdDate(model.id, stepid) > 0)
                        //{
                        //    context.Response.Write("ok");
                        //} 
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }
                #endregion

                #region 第4-2部 添加成品收货信息
                else if (context.Request.Params["action"] == "cshouhuo")
                {

                    DateTime dateTime = DateTime.Parse(context.Request.Params["cRecrealdate"].ToString());
                    Model.ui_gongyingshang model = new Model.ui_gongyingshang();
                    model.id = int.Parse(context.Request.Params["id"]);
                    model.cRecrealdate = dateTime;
                    model.cRecperson = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    //model.cRecnums = int.Parse(context.Request.Params["recnums"]);
                    //model.cRecnum = int.Parse(context.Request.Params["cRecnum"]);
                    model.cRecremark = context.Request.Params["cRecremark"];
                    model.cRecdate = DateTime.Now;
                    model.flag = 4;
                    model.lastdate = dateTime;
                    stepid = 4;
                    if (new BLL.ui_gongyingshang().Add_CshouHuo(model))
                    {
                        //if (bll.UpdateStdDate(model.id, stepid) > 0)
                        //{
                        //    context.Response.Write("ok");
                        //} 
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }
                #endregion

                #region 第4-3部 添加包装收货信息
                else if (context.Request.Params["action"] == "bshouhuo")
                {
                    DateTime dateTime = DateTime.Parse(context.Request.Params["bRecrealdate"].ToString());
                    Model.ui_gongyingshang model = new Model.ui_gongyingshang();
                    model.id = int.Parse(context.Request.Params["id"]);
                    model.bRecrealdate = dateTime;
                    model.bRecperson = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    //model.bRecnums = int.Parse(context.Request.Params["bRecnums"]);
                    //model.bRecnum = int.Parse(context.Request.Params["bRecnum"]);
                    model.bRecremark = context.Request.Params["bRecremark"];
                    model.bRecdate = DateTime.Now;
                    model.flag = 4;
                    model.lastdate = dateTime;
                    stepid = 5;
                    if (new BLL.ui_gongyingshang().Add_BshouHuo(model))
                    {
                        //if (bll.UpdateStdDate(model.id, stepid) > 0)
                        //{
                        //    context.Response.Write("ok");
                        //} 
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }
                #endregion

                #region 第4-4部 添加非自有收货信息
                else if (context.Request.Params["action"] == "fshouhuo")
                {
                    DateTime dateTime = DateTime.Parse(context.Request.Params["fRecrealdate"].ToString());
                    Model.ui_gongyingshang model = new Model.ui_gongyingshang();
                    model.id = int.Parse(context.Request.Params["id"]);
                    model.fRecrealdate = dateTime;
                    model.fRecperson = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    // model.fRecnums = int.Parse(context.Request.Params["recnums"]);
                    // model.fRecnum = int.Parse(context.Request.Params["fRecnum"]);
                    model.fRecremark = context.Request.Params["fRecremark"];
                    model.fRecdate = DateTime.Now;
                    model.flag = 4;
                    model.lastdate = dateTime;
                    stepid = 6;
                    if (new BLL.ui_gongyingshang().Add_FshouHuo(model))
                    {
                        //if (bll.UpdateStdDate(model.id, stepid) > 0)
                        //{
                        //    context.Response.Write("ok");
                        //} 
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }
                #endregion

                #region 第4-5部 添加赠品收货信息
                else if (context.Request.Params["action"] == "zshouhuo")
                {
                    DateTime dateTime = DateTime.Parse(context.Request.Params["zRecrealdate"].ToString());
                    Model.ui_gongyingshang model = new Model.ui_gongyingshang();
                    model.id = int.Parse(context.Request.Params["id"]);
                    model.zRecrealdate = dateTime;
                    model.zRecperson = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    // model.zRecnums = int.Parse(context.Request.Params["recnums"]);
                    // model.zRecnum = int.Parse(context.Request.Params["zRecnum"]);
                    model.zRecremark = context.Request.Params["zRecremark"];
                    model.zRecdate = DateTime.Now;
                    model.flag = 4;
                    model.lastdate = dateTime;
                    stepid = 7;
                    if (new BLL.ui_gongyingshang().Add_ZshouHuo(model))
                    {
                        //if (bll.UpdateStdDate(model.id, stepid) > 0)
                        //{
                        //    context.Response.Write("ok");
                        //} 
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }
                #endregion

                #region 未成品入库时间4-1-1
                else if (context.Request.Params["action"] == "weichengpin")
                {
                    Model.ui_gongyingshang model = new Model.ui_gongyingshang();
                    DateTime dateTime = DateTime.Parse(context.Request.Params["unfinishrealdate"].ToString());
                    model.id = int.Parse(context.Request.Params["id"]);
                    model.unfinishrealdate = dateTime;
                    model.unfinishperson = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    // model.unfinishnum = int.Parse(context.Request.Params["unfinishnum"]);
                    model.unfinishdate = DateTime.Parse(DateTime.Now.ToString());
                    model.unfinishremark = context.Request.Params["unfinishremark"];
                    model.flag = 4;
                    model.lastdate = dateTime;
                    stepid = 8;
                    if (new BLL.ui_gongyingshang().Add_WeiChengPin(model))
                    {
                        //if (bll.UpdateStdDate(model.id, stepid) > 0)
                        //{
                        //    context.Response.Write("ok");
                        //} 
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }
                #endregion

                #region 成品入库时间4-1-2
                else if (context.Request.Params["action"] == "chengpin")
                {
                    Model.ui_gongyingshang model = new Model.ui_gongyingshang();
                    DateTime dateTime = DateTime.Parse(context.Request.Params["finishrealdate"].ToString());
                    model.id = int.Parse(context.Request.Params["id"]);
                    model.finishrealdate = dateTime;
                    model.finishperson = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    // model.finishnum = int.Parse(context.Request.Params["finishnum"]);
                    model.finishremark = context.Request.Params["finishremark"];
                    model.finishdate = DateTime.Parse(DateTime.Now.ToString());
                    model.flag = 4;
                    model.lastdate = dateTime;
                    stepid = 9;
                    if (new BLL.ui_gongyingshang().Add_ChengPin(model))
                    {
                        //if (bll.UpdateStdDate(model.id, stepid) > 0)
                        //{
                        //    context.Response.Write("ok");
                        //} 
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }
                #endregion

                #region 4包装入库时间4-1-3
                else if (context.Request.Params["action"] == "baozhuang")
                {
                    DateTime dateTime = DateTime.Parse(context.Request.Params["packrealdate"].ToString());
                    Model.ui_gongyingshang model = new Model.ui_gongyingshang();
                    model.id = int.Parse(context.Request.Params["id"]);
                    model.packrealdate = dateTime;
                    model.packperson = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    // model.packnum = decimal.Parse(context.Request.Params["packnum"]);
                    model.packdate = DateTime.Parse(DateTime.Now.ToString());
                    model.packremark = context.Request.Params["packremark"];
                    model.flag = 4;
                    model.lastdate = dateTime;
                    stepid = 10;
                    if (new BLL.ui_gongyingshang().Add_BaoZhuang(model))
                    {
                        //if (bll.UpdateStdDate(model.id, stepid) > 0)
                        //{
                        //    context.Response.Write("ok");
                        //} 
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }
                #endregion

                #region 非自有入库时间4-1-4
                else if (context.Request.Params["action"] == "feiziyou")
                {
                    Model.ui_gongyingshang model = new Model.ui_gongyingshang();
                    DateTime dateTime = DateTime.Parse(context.Request.Params["noselfrealdate"].ToString());
                    model.id = int.Parse(context.Request.Params["id"]);
                    model.noselfrealdate = dateTime;
                    model.noselfperson = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    // model.noselfnum = int.Parse(context.Request.Params["noselfnum"]);
                    model.noselfdate = DateTime.Parse(DateTime.Now.ToString());
                    model.noselfremark = context.Request.Params["noselfremark"];
                    model.flag = 4;
                    model.lastdate = dateTime;
                    stepid = 11;
                    if (new BLL.ui_gongyingshang().Add_FeiZiYou(model))
                    {
                        //if (bll.UpdateStdDate(model.id, stepid) > 0)
                        //{
                        //    context.Response.Write("ok");
                        //} 
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }
                #endregion

                #region 赠品入库时间4-1-5
                else if (context.Request.Params["action"] == "zengpin")
                {
                    Model.ui_gongyingshang model = new Model.ui_gongyingshang();
                    DateTime dateTime = DateTime.Parse(context.Request.Params["giftrealdate"].ToString());
                    model.id = int.Parse(context.Request.Params["id"]);
                    model.giftrealdate = dateTime;
                    model.giftperson = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    // model.giftnum = int.Parse(context.Request.Params["giftnum"]);
                    model.giftdate = DateTime.Parse(DateTime.Now.ToString());
                    model.giftremark = context.Request.Params["giftremark"];
                    model.flag = 4;
                    model.lastdate = dateTime;
                    stepid = 12;
                    if (new BLL.ui_gongyingshang().Add_ZengPin(model))
                    {
                        //if (bll.UpdateStdDate(model.id, stepid) > 0)
                        //{
                        //    context.Response.Write("ok");
                        //} 
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }
                #endregion

                #region 不良品入库时间5-1
                else if (context.Request.Params["action"] == "buliangpin")
                {
                    Model.ui_gongyingshang model = new Model.ui_gongyingshang();
                    DateTime dateTime = DateTime.Parse(context.Request.Params["badrealdate"].ToString());
                    model.id = int.Parse(context.Request.Params["id"]);
                    model.badrealdate = dateTime;
                    model.badperson = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    // model.badnum = int.Parse(context.Request.Params["badnum"]);
                    model.baddate = DateTime.Parse(DateTime.Now.ToString());
                    model.badremark = context.Request.Params["badremark"];
                    model.flag = 5;
                    model.lastdate = dateTime;
                    stepid = 13;
                    if (new BLL.ui_gongyingshang().Add_BuLiangPin(model))
                    {
                        //if (bll.UpdateStdDate(model.id, stepid) > 0)
                        //{
                        //    context.Response.Write("ok");
                        //} 
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }
                #endregion

                #region 6重工入库时间
                else if (context.Request.Params["action"] == "chonggong")
                {
                    DateTime dateTime = DateTime.Parse(context.Request.Params["reworkrealdate"].ToString());
                    Model.ui_gongyingshang model = new Model.ui_gongyingshang();
                    model.id = int.Parse(context.Request.Params["id"]);
                    model.reworkrealdate = dateTime;
                    model.reworkperson = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    // model.reworknum = int.Parse(context.Request.Params["reworknum"]);
                    model.reworkremark = context.Request.Params["reworkremark"];
                    model.reworkdate = DateTime.Parse(DateTime.Now.ToString());
                    model.flag = 5;
                    //stepid = 14;
                    model.lastdate = dateTime;
                    if (new BLL.ui_gongyingshang().Add_ChongGong(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }
                #endregion

                //导出操作
                else if (context.Request.Params["action"] == "daochu")
                {
                    string begindate = context.Request.Params["begindate"];
                    string enddate = context.Request.Params["enddate"];
                    StringBuilder sb = new StringBuilder();
                    sb.Append("select id, regdate,regperson,yddate,dep,cate,category,suppliername,total,  ");
                    sb.Append(" uploadstddate,arrdate,uploadrealdate,uploadperson,uploaddate,uploadremark,");//卸车
                    sb.Append("testperson,testdate,teststddate,testrealdate,testremark,");//质检
                    sb.Append("wRecperson,wRecdate,wRecstddate,wRecrealdate,wRecremark,");//  "操作人,操作时间,标准完成时间,实际完成时间,备注,"+
                    sb.Append("cRecperson,cRecdate,cRecstddate,cRecrealdate,cRecremark,");
                    sb.Append("bRecperson,bRecdate,bRecstddate,bRecrealdate,bRecremark,");
                    sb.Append("fRecperson,fRecdate,fRecstddate,fRecrealdate,fRecremark,");
                    sb.Append("zRecperson,zRecdate,zRecstddate,zRecrealdate,zRecremark,");
                    sb.Append("unfinishperson,unfinishdate,unfinishstddate,unfinishrealdate,unfinishremark,");
                    sb.Append("finishperson,finishdate,finishstddate,finishrealdate,finishremark,");//实际入
                    sb.Append("packperson,packdate,packstddate,packrealdate,packremark,");
                    sb.Append("noselfperson,noselfdate,noselfstddate,noselfrealdate,noselfremark,");
                    sb.Append("giftperson,giftdate,giftstddate,giftrealdate,giftremark,");
                    sb.Append("badperson,baddate,badstddate,badrealdate,badremark,");
                    sb.Append("reworkperson,reworkdate,reworkstddate,reworkrealdate,reworkremark,");
                    sb.Append("checkremark,checkperson,checkdate  ");
                    sb.Append(" from ui_gongyingshang");
                    sb.Append("    order by id DESC ");
                    //SqlParameter[] parameters =
                    //                            {
                    //                                new SqlParameter("@begindate",SqlDbType.VarChar,50), 
                    //                                new SqlParameter("@enddate",SqlDbType.VarChar,50)
                    //                            };
                    //parameters[0].Value = Convert.ToDateTime(begindate);
                    //parameters[1].Value = Convert.ToDateTime(enddate);
                    HSSFWorkbook workbook = new HSSFWorkbook();
                    ISheet sheet1 = workbook.CreateSheet("sheet1");
                    SqlDataReader reader = ExeDataReader(sb.ToString(), CommandType.Text, null);
                    //样式据中
                    ICellStyle cellstyle = workbook.CreateCellStyle();
                    cellstyle.VerticalAlignment = VerticalAlignment.Center;
                    cellstyle.Alignment = HorizontalAlignment.Center;
                    //样式居中
                    IRow rowsRow = sheet1.CreateRow(0);
                    ICell cell0 = rowsRow.CreateCell(0);
                    cell0.CellStyle = cellstyle;
                    cell0.SetCellValue("基本信息");
                    ICell cell9 = rowsRow.CreateCell(9);
                    cell9.CellStyle = cellstyle;
                    cell9.SetCellValue("卸货信息");
                    ICell cell15 = rowsRow.CreateCell(15);
                    cell15.CellStyle = cellstyle;
                    cell15.SetCellValue("质检");
                    ICell cell20 = rowsRow.CreateCell(20);
                    cell20.CellStyle = cellstyle;
                    cell20.SetCellValue("未成品收货");
                    ICell cell25 = rowsRow.CreateCell(25);
                    cell25.CellStyle = cellstyle;
                    cell25.SetCellValue("成品收货");

                    ICell cell30 = rowsRow.CreateCell(30);
                    cell30.CellStyle = cellstyle;
                    cell30.SetCellValue("包装收货");


                    ICell cell35 = rowsRow.CreateCell(35);
                    cell35.CellStyle = cellstyle;
                    cell35.SetCellValue("非自有收货");

                    ICell cell40 = rowsRow.CreateCell(40);
                    cell40.CellStyle = cellstyle;
                    cell40.SetCellValue("赠品收货");

                    ICell cell45 = rowsRow.CreateCell(45);
                    cell45.CellStyle = cellstyle;
                    cell45.SetCellValue("未成品入库");

                    ICell cell50 = rowsRow.CreateCell(50);
                    cell50.CellStyle = cellstyle;
                    cell50.SetCellValue("成品入库");

                    ICell cell55 = rowsRow.CreateCell(55);
                    cell55.CellStyle = cellstyle;
                    cell55.SetCellValue("包装入库");

                    ICell cell60 = rowsRow.CreateCell(60);
                    cell60.CellStyle = cellstyle;
                    cell60.SetCellValue("非自有入库");

                    ICell cell65 = rowsRow.CreateCell(65);
                    cell65.CellStyle = cellstyle;
                    cell65.SetCellValue("赠品入库");

                    ICell cell70 = rowsRow.CreateCell(70);
                    cell70.CellStyle = cellstyle;
                    cell70.SetCellValue("不良品入库");

                    ICell cell75 = rowsRow.CreateCell(75);
                    cell75.CellStyle = cellstyle;
                    cell75.SetCellValue("重工库入库");
                    ICell cell76 = rowsRow.CreateCell(76);
                    cell76.CellStyle = cellstyle;
                    cell76.SetCellValue("总使用时间");
                    ICell cell85 = rowsRow.CreateCell(85);
                    cell85.CellStyle = cellstyle;
                    cell85.SetCellValue("违规抽查记录");
                    sheet1.AddMergedRegion(new CellRangeAddress(0, 0, 0, 8));
                    sheet1.AddMergedRegion(new CellRangeAddress(0, 0, 9, 14));
                    sheet1.AddMergedRegion(new CellRangeAddress(0, 0, 15, 19));
                    sheet1.AddMergedRegion(new CellRangeAddress(0, 0, 20, 24));
                    sheet1.AddMergedRegion(new CellRangeAddress(0, 0, 25, 29));
                    sheet1.AddMergedRegion(new CellRangeAddress(0, 0, 30, 34)); 
                    sheet1.AddMergedRegion(new CellRangeAddress(0, 0, 35, 39));
                    sheet1.AddMergedRegion(new CellRangeAddress(0, 0, 40, 44));
                    sheet1.AddMergedRegion(new CellRangeAddress(0, 0, 45, 49));
                    sheet1.AddMergedRegion(new CellRangeAddress(0, 0, 50, 54));
                    sheet1.AddMergedRegion(new CellRangeAddress(0, 0, 55, 59));
                    sheet1.AddMergedRegion(new CellRangeAddress(0, 0, 60, 64));
                    sheet1.AddMergedRegion(new CellRangeAddress(0, 0, 65, 69));
                    sheet1.AddMergedRegion(new CellRangeAddress(0, 0, 70, 74));
                    sheet1.AddMergedRegion(new CellRangeAddress(0, 0, 75, 79));
                    sheet1.AddMergedRegion(new CellRangeAddress(0, 0, 81, 84));

                    IRow rowhead = sheet1.CreateRow(1);
                    //循环表头
                    string cs = "序号,登记时间,登记人,预计送达时间,部门,分类,品类,厂家名称,总件数," +
                                "标准完成时间,实际到货时间,实际完成时间,操作人,操作时间,备注," +
                                "操作人,操作时间,标准完成时间,实际完成时间,备注,"+
                                "操作人,操作时间,标准完成时间,实际完成时间,备注,"+//
                                "标准完成时间,实际完成时间,操作人,操作时间,备注,"+
                                "标准完成时间,实际完成时间,操作人,操作时间,备注,"+
                                "标准完成时间,实际完成时间,操作人,操作时间,备注,"+
                                "标准完成时间,实际完成时间,操作人,操作时间,备注,"+
                                "标准完成时间,实际完成时间,操作人,操作时间,备注,"+
                                "标准完成时间,实际完成时间,操作人,操作时间,备注,"+
                                "标准完成时间,实际完成时间,操作人,操作时间,备注,"+
                                "标准完成时间,实际完成时间,操作人,操作时间,备注,"+
                                "标准完成时间,实际完成时间,操作人,操作时间,备注," +
                                "标准完成时间,实际完成时间,操作人,操作时间,备注," +
                                "标准完成时间,实际完成时间,操作人,操作时间,备注,"+
                                "总使用时间(分钟),"+
                                "原因,操作人,操作时间";

                    string[] str = cs.Split(',');//string.split(",");
                    for (int i = 0; i < str.Length; i++)
                    {
                        rowhead.CreateCell(i, CellType.String).SetCellValue(str[i]);
                    }
                    int index =2;
                    while (reader.Read())
                    {
                        IRow rowbody = sheet1.CreateRow(index);
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            ICell cellbody = rowbody.CreateCell(i);
                            cellbody.SetCellValue(reader[i].ToString());
                        }
                        index++;
                    }
                    //导出操作
                    MemoryStream ms = new MemoryStream();
                    workbook.Write(ms);
                    string title = "报表";
                    context.Response.AddHeader("Content-Disposition", string.Format("attachment;filename={0}.xls", HttpUtility.UrlEncode(title + "_" + DateTime.Now.ToString("yyyy-MM-dd"), System.Text.Encoding.UTF8)));
                    context.Response.BinaryWrite(ms.ToArray());
                    context.Response.End();
                    workbook = null;
                    ms.Close();
                    ms.Dispose();
                }

                #region 抽查

                else if (context.Request.Params["action"] == "choucha")
                {
                    Model.ui_gongyingshang model = new Model.ui_gongyingshang();
                    model.id = int.Parse(context.Request.Params["id"]);
                    model.checkperson = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    model.checkremark = context.Request.Params["checkremark"];
                    model.checkdate = DateTime.Parse(DateTime.Now.ToString());
                    if (new BLL.ui_gongyingshang().Add_ChouCha(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }

                #endregion

                #region 导出操作


                #endregion


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
        //查．读
        public static string connectionString = ConfigurationManager.ConnectionStrings["SQLConnString"].ToString();
        public static SqlDataReader ExeDataReader(string sql, CommandType type, params SqlParameter[] lists)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.CommandType = type;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            if (lists != null)
            {
                foreach (SqlParameter p in lists)
                {
                    cmd.Parameters.Add(p);
                }
            }

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
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