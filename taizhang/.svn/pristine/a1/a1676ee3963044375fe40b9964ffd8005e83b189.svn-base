using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using YJUI.DBUtility;
namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// export 的摘要说明
    /// </summary>
    public class export : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            if (context.Request.QueryString["action"] == "export_tuji")
            {
                var selectDate = context.Request.Params["selectDate"];//选择日期类型
                string begindate = context.Request.Params["begindate"];//开始时间
                string enddate = context.Request.Params["enddate"];//结束时间
                string sql = @"SELECT [ID]
                                      ,[tjxh]
                                      ,[fdjh]
                                      ,[zjsj]
                                      ,[jhbx]
                                      ,[gzfsdq]
                                      ,[dls]
                                      ,[xlc]
                                      ,[lxr]
                                      ,[xlctel]
                                      ,[xxfksj]
                                      ,[xxfkr]
                                      ,[gzxx]
                                      ,[fenlei]
                                      ,[gzms]
                                      ,[shclsj]
                                      ,[zdfx]
                                      ,[gznr]
                                      ,[zpje]
                                      ,[xxzrr]
                                      ,[shclyj]
                                       ,[thhfjg]
                                      ,[jjfh]
                                      ,[fkname]
                                      ,[fkdhrq]
                                      ,[dhrq]
                                      ,[gongchangshrq]
                                      ,[cjrq]
                                      ,[cjr]
                                      ,[cjfk]
                                      ,[gzbw]
                                      ,[zlpd]
                                      ,[shcjqr]
                                      ,[gjzrr]
                                      ,[gjfa]
                                      ,[gjrq]
                                      ,[kcclcs]
                                      ,[kcwcrq]
                                      ,[gysclcs]
                                      ,[gyswcrq]
                                      ,[nblcgs]
                                      ,[nblcwcrq]
                                      ,[qtgjcs]
                                      ,[qtwcrq]
                                      ,[bs]
                                      ,[cpbqr]
                                      ,[cpbrq]
                                      ,[gcqr]
                                      ,[gcqrrq]
                                      FROM [VOCEN2013].[dbo].[TUJI] where 1=1  ";
                if (begindate != null)
                {
                    sql += string.Format("  and   {0} >= '{1}'", selectDate, begindate);

                }
                if (enddate != null)
                {
                    sql += string.Format("  and {0}<='{1}'", selectDate, enddate);
                }
                sql += "  order by ID desc";
                HSSFWorkbook workbook = new HSSFWorkbook();
                ISheet sheet1 = workbook.CreateSheet("sheet1");
                SqlDataReader reader = DbHelperSQL.ExecuteReader(sql, null);
                IRow rowhead = sheet1.CreateRow(0);
                string cs = "序号,凸机型号,发动机号,装机时间,激活保修,代理地址,代理商,修理厂," +
                            "联系人,联系电话,反馈时间,反馈人,故障现象描述,分类,故障类型," +
                            "售后处理时间,诊断分析,售后处理结果,故障件,售后处理人,售后完成情况,回访结果,旧件返还,分库名称,分库到货日期," +
                            "总库到货日期,工厂到货日期," +

                            "拆解日期,拆解人,拆解结果,故障部位,质量判断,售后拆检结果确认,改进责任人,初步改进方案," +
                            "改进日期,库存处理措施,完成日期,供应商处理措施,完成日期,内部流程工艺改善,完成日期,其他改进措施,完成日期,结束," +
                            "产品部确认,产品部确认日期,工厂确认,工厂确认日期";

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

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}