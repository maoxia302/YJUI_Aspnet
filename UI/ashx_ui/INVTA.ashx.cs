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
                    DataTable dt1 = ExcelHelper.ExcelToTable(filePath);
                    string[] arrPinhao = dt1.AsEnumerable().Select(d => d.Field<string>("品号")).ToArray();
                    string s = "'" + string.Join("','", dt1.AsEnumerable().Select(d => d.Field<string>("品号")).ToArray()) + "'";
                    IEnumerable<Model.INVMB> models = new BLL.INVMB().GetListByWhere(s);//根据品号，获取所有的品号信息

                    List<Model.INVTB> invtbList = new List<Model.INVTB>();
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        Model.INVTB model = new Model.INVTB();
                        model.TB001 = "";
                        model.TB002 = "";
                        model.TB003 = (i + 1).ToString().PadLeft(4, '0'); //4位数序号
                        model.TB004 = dt1.Rows[i]["品号"].ToString();
                        model.TB005 = models.Where(p => p.MB001.Trim() == model.TB004.Trim()).SingleOrDefault().MB002;
                        model.TB006 = models.Where(p => p.MB001.Trim() == model.TB004.Trim()).SingleOrDefault().MB003;
                        model.TB007 = decimal.Parse(dt1.Rows[i]["差异"].ToString());//数量
                        model.TB008 = models.Where(p => p.MB001.Trim() == model.TB004.Trim()).SingleOrDefault().MB004;//单位
                        model.TB009 = decimal.Parse(dt1.Rows[i]["差异"].ToString());//数量
                        if (models.Where(p => p.MB001.Trim() == model.TB004.Trim()).SingleOrDefault().MB064 != 0)
                        {
                            model.TB010 = models.Where(p => p.MB001.Trim() == model.TB004.Trim()).SingleOrDefault().MB065 / models.Where(p => p.MB001.Trim() == model.TB004.Trim()).SingleOrDefault().MB064;
                        }
                        else { model.TB010 = 0; }//单位成本 
                        model.TB011 = model.TB007* model.TB010; //金额
                        model.TB012 = model.TB004 = dt1.Rows[i]["仓库"].ToString(); ; //转出库
                        model.TB013 = ""; //转入库
                        model.TB014 = "********************"; //批号
                        model.TB015 = ""; //有效日期
                        model.TB016 = "";//复检日期
                        model.TB017 = "";//备注
                        model.TB018 = "N";//审核码
                        model.TB019 = "";//预留字段20200330
                        model.TB020 = "";//小单位
                        model.TB021 = ""; //项目编号
                        model.TB022 = 0;//包装数量
                        model.TB023 = "";//包装单位
                        model.TB024 = ""; //存储位置
                        model.TB025 = 0; // 已销毁数量
                        model.TB026 = 0; //件装

                        model.TB027 = 0; //件数
                        model.TB028 = ""; //批号说明
                        model.TB029 = "##########"; //转出库位
                        model.TB030 = ""; //转入库位
                        model.TB031 = ""; //生产日期
                        model.TB032 = ""; // 预留字段
                        model.TB033 = ""; // 预留字段
                        model.TB034 = ""; // 预留字段
                        model.TB035 = 0; // 预留字段
                        model.TB036 =0; // 预留字段
                        model.TB027 = 0; // 预留字段
                        invtbList.Add(model);
                    }
                    var qty = invtbList.Sum(p=>p.TB007);//求总数量
                    var amount= invtbList.Sum(p => p.TB011);//求总金额

                    //var query = from t in dt1.AsEnumerable()
                    //            join t2 in dataTable.AsEnumerable() on t.Field<string>("品号") equals t2.Field<string>("MB001").Trim()
                    //            into g
                    //            from t2 in g.DefaultIfEmpty()
                    //            select new
                    //            {
                    //                pinhao = t.Field<string>("品号"),
                    //                pinming = t.Field<string>("品名"),
                    //                guige = t.Field<string>("规格"),
                    //                oem = "",
                    //                shuliang = t.Field<string>("调账数量"),
                    //                dw = t2.Field<string>("MB004"),
                    //                xdw = "",
                    //                chengben = "",
                    //                money = "",//金额
                    //                cangku = t.Field<string>("仓库编码"),
                    //                ckName = t.Field<string>("仓库名称"),
                    //                pihao = "",
                    //                pihaoshuoming = "",
                    //                scDate = "",
                    //                yxDate = "",
                    //                fjDate = "",
                    //                xmbh = "",
                    //                bz = t.Field<string>("备注"),
                    //            };
                    //query.ToList().ForEach(q => dtC.Rows.Add(q.pinhao, q.pinming, q.guige, q.oem, q.shuliang, q.dw, q.xdw, q.chengben, q.money, q.cangku, q.ckName, q.pihao, q.pihaoshuoming, q.scDate, q.yxDate, q.fjDate, q.xmbh, q.bz));
                    //double sum = dtC.AsEnumerable().Select(d => Convert.ToDouble(d.Field<string>("数量"))).Sum();


                    string strjson = Common.JsonHelper.ObjToJson(invtbList);
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