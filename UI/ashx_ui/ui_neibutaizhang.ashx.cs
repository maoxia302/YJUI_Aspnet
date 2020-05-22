using System;
using System.Collections.Generic;
using System.Web;
using YJUI.BLL;
using System.Web.SessionState;
using YJUI.Model;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Web.Script.Serialization;
using System.Text;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// ui_neibutaizhang 的摘要说明
    /// </summary>
    public class ui_neibutaizhang : IHttpHandler,IReadOnlySessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            try
            {
                if (context.Session["user"]==null)
                {
                    context.Response.Write("nosession");
                    return;
                }
                #region 查询
                else if (context.Request.QueryString["action"] == "search")
                {
                    string strWhere = "1=1  ";
                    string bdate = context.Request.Params["bdate"];
                    string edate = context.Request.Params["edate"];
                    string word = context.Request.Params["txt_search"];
                    string depcat = context.Request.Params["DepCat"];//反馈部门
                    string dep = context.Request.Params["txt_dep"];//反馈部门
                    var fkItem= context.Request.Params["fkItem"];//反馈部门
                    strWhere = NewMethod(strWhere, bdate, edate, word, dep,fkItem, depcat);
                    int pageindex = int.Parse(context.Request["page"]);
                    int pagesize = int.Parse(context.Request.Params["rows"]);
                    string strjson = new BLL.neibutaizhang().GetJsonneibuTaizhang(pagesize, pageindex, strWhere);
                    context.Response.Write(strjson);
                }
                #endregion

                #region 添加
                else if (context.Request.Params["action"] == "add")
                {
                    Model.neibutaizhang model = new Model.neibutaizhang();
                    model.fkDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                    model.fkPerson = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    model.FkDep = (context.Session["user"] as YJUI.Model.ui_user).depname;
                    model.DepCat = context.Request.Params["DepCat"];
                    model.wtDep = context.Request.Params["wtDep"];
                    model.fkItem= context.Request.Params["fkItem"];
                    model.fkDesc = context.Request.Params["fkDesc"];
                    model.fkArea = context.Request.Params["fkArea"];

                    string pics= context.Request.Params["pics"];//
                    List<string> list = new JavaScriptSerializer().Deserialize<List<string>>(pics);
                    StringBuilder sb = new StringBuilder();
                    foreach (var item in list)
                    {
                        string[] img_array = item.Split(',');
                        byte[] arr = Convert.FromBase64String(img_array[1]);
                        string filePath = "../UploadFile";
                        string name = DateTime.Now.ToString("yyyyMMddHHmmssffff");
                        string file_name = HttpContext.Current.Server.MapPath(filePath + "/" + name);
                        using (MemoryStream ms = new MemoryStream(arr))
                        {
                            Bitmap bmp = new Bitmap(ms);
                            if (img_array[0].ToLower() == "data:image/jpeg;base64")
                            {
                                bmp.Save(file_name + ".jpg");
                                sb.Append(name + ".jpg"+",");
                            }
                            else if (img_array[0].ToLower() == "data:image/png;base64")
                            {
                                bmp.Save(file_name + ".png");
                                sb.Append(name + ".png"+",");
                            }
                        }
                    }
                    model.FkPic = sb.ToString();
                    model.fkCustomer = context.Request.Params["fkCustomer"];
                    if (new BLL.neibutaizhang().Add(model))
                    {
                        context.Response.Write("ok");
                }
                else
                {
                    context.Response.Write("err");
                }
            } 
                #endregion

                #region 问题处理添加
                else if (context.Request.Params["action"] == "wentichuli_add")
                {
                    Model.neibutaizhang model = new Model.neibutaizhang();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.dyDep = context.Request.Params["dyDep"];
                    model.dyPerson = context.Request.Params["dyPerson"];
                    string dyDate = context.Request.Params["dyDate"];
                    model.dyDate = DateTime.Parse(dyDate);
                    model.IsEnd= context.Request.Params["IsEnd"];
                    model.dyGaishan = context.Request.Params["dyGaishan"];
                    model.cqFangan = context.Request.Params["cqFangan"];
                    model.cqDate = Convert.ToDateTime(context.Request.Params["cqDate"]);
                    if (new BLL.neibutaizhang().Update(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }

                } 
                #endregion

                else if (context.Request.Params["action"] == "luoshijianhe_add")
                {
                    Model.neibutaizhang model = new Model.neibutaizhang();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.lsDep = context.Request.Params["lsDep"];
                    model.lsJianhe = context.Request.Params["lsJianhe"];
                    string lsdate= context.Request.Params["lsDate"];
                    model.lsDate = DateTime.Parse(lsdate);
                    if (new BLL.neibutaizhang().Update_luoshijianhe(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }

                }
                else if (context.Request.Params["action"] == "manyidupingjia_add")
                {
                    Model.neibutaizhang model = new Model.neibutaizhang();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.myPingjia = context.Request.Params["myPingjia"];
                    model.myPerson = context.Request.Params["myPerson"];
                    string mydate = context.Request.Params["myDate"];
                    model.myDate = DateTime.Parse(mydate);
                    if (new BLL.neibutaizhang().Update_manyidudiaocha(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }
                else if (context.Request.Params["action"] == "disanfangjianhe_add")
                {
                    Model.neibutaizhang model = new Model.neibutaizhang();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.dsJianhe = context.Request.Params["dsJianhe"];
                    model.dsPerson = context.Request.Params["dsPerson"];
                    string dsdate = context.Request.Params["dsDate"];
                    model.dsDate = DateTime.Parse(dsdate);
                    if (new BLL.neibutaizhang().Update_disanfangjianhe(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                }
                else if (context.Request.Params["action"] == "daochu")
                {
                   string sqlWhere = " 1=1";
                   string p = context.Request.Params["params"];
                   Dictionary<string,object> dic = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, object>>(p);
                    var bdate = dic["bdate"].ToString();
                    var fkItem = dic["fkItem"].ToString();
                    var DepCat = dic["DepCat"].ToString();
                    var word = dic["txt_search"].ToString();
                    var edate = dic["edate"].ToString();
                    var dep = dic["txt_dep"].ToString();
                    sqlWhere = NewMethod(sqlWhere, bdate, edate, word, dep,fkItem, DepCat);//查询条件
                    HSSFWorkbook workbook = new HSSFWorkbook();
                    ISheet sheet1 = workbook.CreateSheet("sheet1");
                    IDataReader reader = new BLL.neibutaizhang().neiBuTaiZhangGetList(sqlWhere);
                    IRow rowhead = sheet1.CreateRow(0);
                    //循环表头
                    //fkArea,fkCustomer,
                    //strSql.Append("select ID,fkDate,fkPerson,fkDep,fkItem,fkArea,fkCustomer,wtDep,fkDesc,
                    //dyDep,dyPerson,dyDate,dyGaishan,cqFangan,cqDate,
                    //lsJianhe,lsDep,lsDate,
                    //myPingjia,myPerson,myDate,
                    //dsJianhe,dsPerson,dsDate ");
                    string cs = "序号,反馈时间,反馈人,反馈部门,所属项目,反馈地区,反馈客户,问题部门,反馈描述," +
                          "领取部门,领取人,领取时间,临时改善,长期方案,长期时间," +
                          "落实检核,落实部门,落实时间," +
                          "满意评价,满意人,满意时间," +
                          "第三方检核,检核人,检核时间";
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
            catch (Exception ex)
            {
                context.Response.Write(ex);
            }
            finally
            {
                context.Response.End();
            }
        }

        public static string NewMethod(string strWhere, string bdate, string edate, string word, string dep,string fkItem,string depcat)
        {
            if (!string.IsNullOrEmpty(bdate))
            {
                strWhere += string.Format(" and  fkDate>='{0}'", bdate);
            }
            if (!string.IsNullOrEmpty(edate))
            {
                strWhere += string.Format(" and  fkDate<='{0}'", edate);
            }
            if (!string.IsNullOrEmpty(word))
            {
                strWhere += string.Format(" and fkPerson like '%{0}%'", word);
            }
            if (!string.IsNullOrEmpty(dep))
            {
                strWhere += string.Format(" and fkDep like '%{0}%'", dep);
            }
            if (!string.IsNullOrEmpty(fkItem))
            {
                strWhere += string.Format(" and fkItem='{0}'", fkItem);
            }
            if (!string.IsNullOrEmpty(depcat))
            {
                strWhere += string.Format(" and DepCat='{0}'", depcat);
            }

            return strWhere;
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