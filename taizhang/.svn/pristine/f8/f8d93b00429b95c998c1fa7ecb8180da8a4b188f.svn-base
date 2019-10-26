using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Web;
using System.Web.SessionState;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// ui_zydtaizhang 的摘要说明
    /// </summary>
    public class ui_zydtaizhang : IHttpHandler, IReadOnlySessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            try
            {
                if (context.Session["user"] == null)
                {
                    context.Response.Write("nosession");
                    return;
                }
                #region 查询列表
                else if (context.Request.QueryString["action"] == "search")
                {
                    string strWhere = "1=1  ";
                    string bdate = context.Request.Params["begindate"];
                    string edate = context.Request.Params["enddate"];
                    if (!string.IsNullOrEmpty(bdate))
                    {
                        //CONVERT(varchar(100), GETDATE(), 20)
                        strWhere += string.Format("  and  CONVERT(varchar(100), fkDate, 21)>='{0}'", bdate);
                    }
                    if (!string.IsNullOrEmpty(edate))
                    {
                        strWhere += string.Format("  and  CONVERT(varchar(100), fkDate, 21)<='{0}'", edate); 
                    }

                    int pageindex = int.Parse(context.Request["page"]);
                    int pagesize = int.Parse(context.Request.Params["rows"]);
                    string strjson = new BLL.ui_zydtaizhang().GetJsonZydTaizhang(pagesize, pageindex, strWhere);
                    context.Response.Write(strjson);
                } 
                #endregion

                #region 添加

                else if (context.Request.Params["action"] == "add")
                {
                    Model.ui_zydtaizhang model = new Model.ui_zydtaizhang();
                    model.fkDate = DateTime.Now;
                    model.fkPerson = (context.Session["user"] as YJUI.Model.ui_user).xingming;
                    model.wtDep = context.Request.Params["wtDep"];
                    model.fkDesc = context.Request.Params["fkDesc"];
                    if (new BLL.ui_zydtaizhang().Add(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }
                } 
                #endregion

                #region 问题处理
                else if (context.Request.Params["action"] == "wentichuli_add")
                {
                    Model.ui_zydtaizhang model = new Model.ui_zydtaizhang();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.dyDep = context.Request.Params["dyDep"];
                    model.dyPerson = context.Request.Params["dyPerson"];
                    string dyDate = context.Request.Params["dyDate"];
                    model.dyDate = DateTime.Parse(dyDate);
                    model.dyGaishan = context.Request.Params["dyGaishan"];
                    model.cqFangan = context.Request.Params["cqFangan"];
                    model.cqDate = Convert.ToDateTime(context.Request.Params["cqDate"]);
                    if (new BLL.ui_zydtaizhang().Update(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }

                } 
                #endregion

                #region 落实检核添加
                else if (context.Request.Params["action"] == "luoshijianhe_add")
                {
                    Model.ui_zydtaizhang model = new Model.ui_zydtaizhang();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.lsDep = context.Request.Params["lsDep"];
                    model.lsJianhe = context.Request.Params["lsJianhe"];
                    string lsdate = context.Request.Params["lsDate"];
                    model.lsDate = DateTime.Parse(lsdate);
                    if (new BLL.ui_zydtaizhang().Update_luoshijianhe(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }

                } 
                #endregion

                #region 满意度调查
                else if (context.Request.Params["action"] == "manyidupingjia_add")
                {
                    Model.ui_zydtaizhang model = new Model.ui_zydtaizhang();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.myPingjia = context.Request.Params["myPingjia"];
                    model.myPerson = context.Request.Params["myPerson"];
                    string mydate = context.Request.Params["myDate"];
                    model.myDate = DateTime.Parse(mydate);
                    if (new BLL.ui_zydtaizhang().Update_manyidudiaocha(model))
                    {
                        context.Response.Write("ok");
                    }
                    else
                    {
                        context.Response.Write("err");
                    }

                } 
                #endregion

                #region 第三方检核

                else if (context.Request.Params["action"] == "disanfangjianhe_add")
                {
                    Model.ui_zydtaizhang model = new Model.ui_zydtaizhang();
                    model.ID = int.Parse(context.Request.Params["ID"]);
                    model.dsJianhe = context.Request.Params["dsJianhe"];
                    model.dsPerson = context.Request.Params["dsPerson"];
                    string dsdate = context.Request.Params["dsDate"];
                    model.dsDate = DateTime.Parse(dsdate);
                    if (new BLL.ui_zydtaizhang().Update_disanfangjianhe(model))
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
                      //                  SELECT [ID]
                      //                    ,[fkDate]
                      //                    ,[fkPerson]
                      //                    ,[wtDep]
                      //                    ,[fkDesc]
                      //                    ,[dyDep]
                      //                    ,[dyPerson]
                      //                    ,[dyDate]
                      //                    ,[dyGaishan]
                      //                    ,[cqFangan]
                      //                    ,[cqDate]
                      //                    ,[lsJianhe]
                      //                    ,[lsDep]
                      //                    ,[lsDate]
                      //                    ,[myPingjia]
                      //                    ,[myPerson]
                      //                    ,[myDate]
                      //                    ,[dsJianhe]
                      //                    ,[dsPerson]
                      //                    ,[dsDate]
                      //FROM [VOCEN2013].[dbo].[ui_zydtaizhang]
                    sb.Append("select [ID],[fkDate] ,[fkPerson] ,[wtDep],[fkDesc] ");
                    sb.Append(",[dyDep] ,[dyPerson],[dyDate],[dyGaishan]  ,[cqFangan],[cqDate]");
                    sb.Append(",[lsJianhe],[lsDep] ,[lsDate]");
                    sb.Append(",[myPingjia],[myPerson],[myDate]");
                    sb.Append(",[dsJianhe],[dsPerson],[dsDate]");
                    HSSFWorkbook workbook = new HSSFWorkbook();
                    ISheet sheet1 = workbook.CreateSheet("sheet1");
                    SqlDataReader reader = ExeDataReader(sb.ToString(), CommandType.Text, null);
                    IRow rowhead = sheet1.CreateRow(1);
                    //循环表头
                    string cs = "序号,反馈时间,反馈人,问题部门,反馈描述" +
                                "领取部门,第一责任人,接收问题时间,临时改善,长期方案，改善完成时间" +
                                "落实检核,问题领取部门经理,落实时间," +// 问题检核
                                "满意评价,满意人,满意时间" +//
                                "第三方检核,第三方检核人,第三方检核时间";

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