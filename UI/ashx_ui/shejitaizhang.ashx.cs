using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.SessionState;
using YJUI.Common;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

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
            else if (context.Request.Params["action"] == "sheji_add") {
                var date = context.Request["DesignerTime"];
                string rows= context.Request["rows"];
                //DataTable dt = JsonConvert.DeserializeObject<DataTable>(context.Request.Params["rows"]);
                List<Model.ui_shejitaizhang> list = new JavaScriptSerializer().Deserialize<List<Model.ui_shejitaizhang>>(context.Request.Params["rows"]);
                List<Model.ui_shejitaizhang> l = new List<Model.ui_shejitaizhang>();
                foreach (var item in list)
                {
                    Model.ui_shejitaizhang model = new Model.ui_shejitaizhang();
                    model.ID = item.ID;
                    model.Designer = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    model.DesignerTime=DateTime.Parse(date);

                    l.Add(model);
                }
                if (BLL.ui_shejitaizhang.Current.update_sheji(l))
                {
                    context.Response.Write("ok");
                }
            }

            else if (context.Request.Params["action"] == "add_chanpin")
            {
                var Accept = context.Request["Accept"];//是否合格
                string rows = context.Request["rows"];
                //DataTable dt = JsonConvert.DeserializeObject<DataTable>(context.Request.Params["rows"]);
                List<Model.ui_shejitaizhang> list = new JavaScriptSerializer().Deserialize<List<Model.ui_shejitaizhang>>(context.Request.Params["rows"]);
                List<Model.ui_shejitaizhang> l = new List<Model.ui_shejitaizhang>();
                foreach (var item in list)
                {
                    Model.ui_shejitaizhang model = new Model.ui_shejitaizhang();
                    model.ID = item.ID;
                    model.Accept = Accept;
                    model.Accepter = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    model.AcceptDate = DateTime.Now;
                    l.Add(model);
                }
                if (BLL.ui_shejitaizhang.Current.add_chanpin(l))
                {
                    context.Response.Write("ok");
                }
            }
            else if (context.Request.Params["action"] == "add_shiyebu")
            {
                var ManagerAccept= context.Request["ManagerAccept"];
                string rows = context.Request["rows"];
                List<Model.ui_shejitaizhang> list = new JavaScriptSerializer().Deserialize<List<Model.ui_shejitaizhang>>(context.Request.Params["rows"]);
                List<Model.ui_shejitaizhang> l = new List<Model.ui_shejitaizhang>();
                foreach (var item in list)
                {
                    Model.ui_shejitaizhang model = new Model.ui_shejitaizhang();
                    model.ID = item.ID;
                    model.ManagerAccept = ManagerAccept;
                    model.Manager = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    model.ManagerDate = DateTime.Now;

                    l.Add(model);
                }
                if (BLL.ui_shejitaizhang.Current.add_shiyebu(l))
                {
                    context.Response.Write("ok");
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