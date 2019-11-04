using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.SessionState;
using YJUI.Common;
using YJUI.DBUtility;


namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// INVTA 的摘要说明
    /// </summary>
    public class INVTA : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Session["user"] == null)
            {
                context.Response.Write("请登录！");
                return;
            }
            #region 查询
            else if (context.Request.Params["action"] == "searchErpNum")
            {
                var danbie = context.Request.Params["orderId"];

                var date = context.Request.Params["tim"];
                date = date.Replace("-", "");
                string strjson = new BLL.INVTA().GetInvtaErpNum(danbie, date);
                context.Response.Write(strjson);
                context.Response.End();
            }
            #endregion

            #region 批量导入操作
            else if (context.Request.Params["action"] == "import")
            {

                HttpFileCollection files = context.Request.Files;
                //if (files.Count > 0)
                //{
                //    context.Response.Write("有文件");

                //}
                HttpPostedFile hpFile = context.Request.Files[0];


                string filePath = "../UploadFile";
                if (hpFile.ContentLength > 0)
                {
                    string fileName = System.IO.Path.GetFileName(hpFile.FileName);
                    filePath = context.Server.MapPath(filePath + "/" + fileName);
                    hpFile.SaveAs(filePath);
                    // DataTable dt = ExcelHelper.ExcelToDataSet("sheet1", filePath);
                    DataTable dt1 = ExcelHelper.ExcelToTable(filePath);
                    DataTable dtC = new DataTable();
                    dtC.Columns.Add("品号");
                    dtC.Columns.Add("品名");
                    dtC.Columns.Add("规格");
                    dtC.Columns.Add("OEM");
                    dtC.Columns.Add("数量");
                    dtC.Columns.Add("单位");
                    dtC.Columns.Add("小单位");
                    dtC.Columns.Add("单位成本");
                    dtC.Columns.Add("金额");
                    dtC.Columns.Add("仓库编码");
                    dtC.Columns.Add("仓库名称");
                    dtC.Columns.Add("批号");
                    dtC.Columns.Add("品号说明");
                    dtC.Columns.Add("生产日期");
                    dtC.Columns.Add("有效日期");
                    dtC.Columns.Add("复检日期");
                    dtC.Columns.Add("项目编号");
                    dtC.Columns.Add("备注");







                    string[] arrPinhao = dt1.AsEnumerable().Select(d => d.Field<string>("品号")).ToArray();

                    string s = "'" + string.Join("','", dt1.AsEnumerable().Select(d => d.Field<string>("品号")).ToArray()) + "'";
                    string sql = string.Format("select MB001,MB002,MB003,MB004,MB064,MB065,MB072 from INVMB where MB001 in({0})", s);
                    DataTable dataTable = VOCEN2018DbHelperSQL.Query(sql).Tables[0];
                    var query = from t in dt1.AsEnumerable()
                                join t2 in dataTable.AsEnumerable() on t.Field<string>("品号") equals t2.Field<string>("MB001").Trim()
                                into g
                                from t2 in g.DefaultIfEmpty()
                                select new
                                {
                                    pinhao = t.Field<string>("品号"),
                                    pinming = t.Field<string>("品名"),
                                    guige = t.Field<string>("规格"),
                                    oem = "",
                                    shuliang = t.Field<string>("调账数量"),
                                    dw = t2.Field<string>("MB004"),
                                    xdw = "",
                                    chengben = "",
                                    money = "",//金额
                                    cangku = t.Field<string>("仓库编码"),
                                    ckName = t.Field<string>("仓库名称"),
                                    pihao = "",
                                    pihaoshuoming = "",
                                    scDate = "",
                                    yxDate = "",
                                    fjDate = "",
                                    xmbh = "",
                                    bz = t.Field<string>("备注"),
                                };
                    query.ToList().ForEach(q => dtC.Rows.Add(q.pinhao, q.pinming, q.guige, q.oem, q.shuliang, q.dw, q.xdw, q.chengben, q.money, q.cangku, q.ckName, q.pihao, q.pihaoshuoming, q.scDate, q.yxDate, q.fjDate, q.xmbh, q.bz));
                    double sum = dtC.AsEnumerable().Select(d => Convert.ToDouble(d.Field<string>("数量"))).Sum();
                    string strjson = Common.JsonHelper.ToJson(dtC);
                   // context.Response.Write("{\"rows\":" + strjson + ",\"footer\":[{ \"品号\":\"合计:\",\"数量\":" + sum + "}]}");
                    context.Response.Write("{\"rows\":" + strjson + "}");

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