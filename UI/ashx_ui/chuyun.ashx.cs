using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// chuyun 的摘要说明
    /// </summary>
    public class chuyun : IHttpHandler, IRequiresSessionState
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
                string sqlWhere = " 1=1";
                var bdate = context.Request.Params["bdate"];
                var edate = context.Request.Params["edate"];
                var isTiHuo = context.Request.Params["txt_word"];
                var ph= context.Request.Params["ph"];
                var dhwl= context.Request.Params["dhwl"];
                sqlWhere = NewMethod(sqlWhere, bdate, edate, isTiHuo,ph,dhwl);//查询条件
                int pageindex = int.Parse(context.Request["page"]);
                int pagesize = int.Parse(context.Request.Params["rows"]);
                string strjson = new BLL.chuyun().GetJsonChuYun(pagesize, pageindex, sqlWhere);
                context.Response.Write(strjson);
            }
            #endregion

            #region 添加一条记录
            else if (context.Request.Params["action"] == "add")
            {
                Model.chuyun model = new Model.chuyun();
               // model.thr = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                model.tzr= (context.Session["user"] as YJUI.Model.ui_user).xingming;//通知人姓名
                model.riqi = DateTime.Now;
                model.Fenku = context.Request.Params["Fenku"];
                model.dth = context.Request.Params["dth"];
                model.dhdq= context.Request.Params["dhdq"];
                model.khmc = context.Request.Params["khmc"];
                model.dhwl = context.Request.Params["dhwl"];
                model.wldh = context.Request.Params["wldh"];
                model.wldz = context.Request.Params["wldz"];
                model.shr = context.Request.Params["shr"];
                model.shrtel= context.Request.Params["shrtel"];
                model.js = context.Request.Params["js"];
                model.yfje = context.Request.Params["yfje"];
                model.ph= context.Request.Params["ph"];
                model.bz= context.Request.Params["bz"];
                if (new BLL.chuyun().Add(model))
                {
                    context.Response.Write("ok");
                }
                else {
                    context.Response.Write("err");
                }
            }
            #endregion

            #region 司机填写
            else if (context.Request.Params["action"] == "siji")
            {
                Model.chuyun model = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<Model.chuyun>(context.Request.Params["param"]);
                model.Siji = (context.Session["user"] as YJUI.Model.ui_user).xingming;//司机姓名
                if (new BLL.chuyun().Update(model))
                {
                    context.Response.Write("ok");
                }
                else
                {
                    context.Response.Write("err");
                }
            }


            #endregion

            #region 质检填写
            else if (context.Request.Params["action"] == "zhijian")
            {
                Model.chuyun model = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<Model.chuyun>(context.Request.Params["param"]);
                model.Zhijian = (context.Session["user"] as YJUI.Model.ui_user).xingming;//司机姓名
                if (new BLL.chuyun().Add_ZhiJian(model))
                {
                    context.Response.Write("ok");
                }
                else
                {
                    context.Response.Write("err");
                }
            }



            #endregion

            else if (context.Request.Params["action"] == "daochu")
            {
                string sqlWhere = " 1=1";
                var bdate = context.Request.Params["bdate"];
                var edate = context.Request.Params["edate"];
                var isTiHuo = context.Request.Params["txt_word"];
                var ph = context.Request.Params["ph"];
                var dhwl = context.Request.Params["dhwl"];
                sqlWhere = NewMethod(sqlWhere, bdate, edate, isTiHuo, ph, dhwl);//查询条件
                HSSFWorkbook workbook = new HSSFWorkbook();
                ISheet sheet1 = workbook.CreateSheet("sheet1");
                IDataReader reader = new BLL.chuyun().ChuYunToDataReader(sqlWhere);
                IRow rowhead = sheet1.CreateRow(0);
                //循环表头
                string cs = "序号,通知日期,通知人,分库,提货类别," +
                            "到货地区,客户名称,到货物流,物流分类,物流电话,物流地址" +
                            ",收货人,收货人电话,件数" +// 问题检核
                            ",金额,票号,备注" +//
                            ",提货人,提货时间,是否提货,实际运费金额,质检签收日期,提货总用时,是否超时";

                string[] str = cs.Split(',');
                for (int i = 0; i < str.Length; i++)
                {
                    rowhead.CreateCell(i, CellType.String).SetCellValue(str[i]);
                }
                int index = 1;
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


        }
        private static string NewMethod(string sqlWhere, string bdate, string edate, string isTiHuo,string ph,string dhwl)
        {
            if (!string.IsNullOrEmpty(bdate))
            {
                sqlWhere += string.Format(" and riqi>= '{0}'", bdate);
            }
            if (!string.IsNullOrEmpty(edate))
            {
                sqlWhere += string.Format(" and riqi<= '{0}'", edate);
            }
            if (isTiHuo=="否")
            {
                sqlWhere += "and (sfth is null or sfth='')";
            }
            if (isTiHuo == "是")
            {
                sqlWhere += "and (sfth= '" + isTiHuo + "')";

            }
            if (isTiHuo == "全部")
            {
                sqlWhere += "     and (sfth is null or sfth= '是' or sfth='')";
            }
            if (!string.IsNullOrEmpty(ph)) {
                sqlWhere += string.Format("and ph like '%{0}%'",ph);
            }
            if (!string.IsNullOrEmpty(dhwl))
            {
                sqlWhere += string.Format("and dhwl like '%{0}%'", dhwl);
            }
            return sqlWhere;
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