using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using YJUI.Common;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// shejitaizhang 的摘要说明
    /// </summary>
    public class shejitaizhang : IHttpHandler, IReadOnlySessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/json";
            string strWhere = "1=1  ";
            if (context.Request.QueryString["action"] == "search")
            {

                //var type = context.Request.Params["type"];
                //var bdate = context.Request.Params["bdate"];
                //var edate = context.Request.Params["edate"];
                //strWhere = NewMethod1(strWhere, type, bdate, edate);
                var pageindex = int.Parse(context.Request["page"]);
                var pagesize = int.Parse(context.Request.Params["rows"]);
                var strjson = BLL.ui_shejitaizhang.Current.GetListToJson(strWhere, "", (pageindex - 1) * pagesize, pageindex * pagesize);
                context.Response.Write(strjson);
                context.Response.End();
            }
            else if (context.Request.Params["action"] == "import")
            {
                HttpFileCollection files = context.Request.Files;
                HttpPostedFile hpFile = context.Request.Files[0];
                string filePath = "../UploadFile";
                if (hpFile.ContentLength > 0)
                {
            
                        string fileName = System.IO.Path.GetFileName(hpFile.FileName);
                        filePath = context.Server.MapPath(filePath + "/" + fileName);
                        hpFile.SaveAs(filePath);
                        DataTable dt1 = ExcelHelper.ExcelToTable(filePath, 2);
                        dt1.Columns.Add("产品小组");
                        dt1.Columns.Add("提报日期");
                        dt1.Columns.Add("预计完成时间");

                        // 赋值
                        for (var i = 0; i < dt1.Rows.Count; i++)
                        {
                            dt1.Rows[i]["产品小组"] = "a";
                            dt1.Rows[i]["提报日期"] = DateTime.Now;
                            if (dt1.Rows[i]["新品类"].ToString() == "Y")
                            {
                                dt1.Rows[i]["预计完成时间"] = DateTime.Now.AddDays(10);
                            }
                            if (dt1.Rows[i]["新品号"].ToString() == "Y")
                            {
                                dt1.Rows[i]["预计完成时间"] = DateTime.Now.AddDays(5);
                            }
                        }
                        BLL.ui_shejitaizhang.Current.BulkCopySheJi(dt1);
                    Dictionary<string, object> dic = new Dictionary<string, object>();
                    dic.Add("msg", "ok");
                    string strjson = Common.JsonHelper.ObjToJson(dic);
                    context.Response.Write(strjson);
                }

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