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


namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// ToExcel 的摘要说明
    /// </summary>
    public class ToExcel : IHttpHandler
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["SQLConnString"].ToString();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string begindate = context.Request.Params["begindate"];
            string enddate = context.Request.Params["enddate"];
           // string chk = context.Request.Params["chk"];
           // string search = context.Request.Params["txt_search"];
            StringBuilder sb = new StringBuilder();
            sb.Append("select ID,convert(char(10),fksj,120),fkr,pj,fssj,fsdq,dls,dlsdh,xlcxx,fknr,fl,jjsfth,zrbm,zrr,ycclrq,plga,dkhcs,wcsj,hfsjqk,hfwcrq,kcclcs,kcwcrq,gysclcs,gysrq,nblcgygs,nblcwcrq,qtcs,qtcsrq,zrbmsp,zrbmsp,dsfjh from jldl1 where ");
            sb.Append(" fksj between  @begindate  and  @enddate ");
            sb.Append("    order by ID DESC ");

            SqlParameter[] parameters =
            {
                new SqlParameter("@begindate",SqlDbType.VarChar,50), 
                new SqlParameter("@enddate",SqlDbType.VarChar,50)
            };
            parameters[0].Value = Convert.ToDateTime(begindate);
            parameters[1].Value = Convert.ToDateTime(enddate);
            HSSFWorkbook workbook = new HSSFWorkbook();
            ISheet sheet1 = workbook.CreateSheet("sheet1");
            SqlDataReader reader = ExeDataReader(sb.ToString(), CommandType.Text, parameters);
            IRow rowhead = sheet1.CreateRow(0);
            rowhead.CreateCell(0, CellType.String).SetCellValue("序号");
            rowhead.CreateCell(1, CellType.String).SetCellValue("反馈时间");
            rowhead.CreateCell(2, CellType.String).SetCellValue("反馈人");
            rowhead.CreateCell(3, CellType.String).SetCellValue("问题零部件");
            rowhead.CreateCell(4, CellType.String).SetCellValue("问题发生时间");
            rowhead.CreateCell(5, CellType.String).SetCellValue("发生地区");
            rowhead.CreateCell(6, CellType.String).SetCellValue("代理商");
            rowhead.CreateCell(7, CellType.String).SetCellValue("代理商电话");
            rowhead.CreateCell(8, CellType.String).SetCellValue("修理厂电话");
            rowhead.CreateCell(9, CellType.String).SetCellValue("反馈详细内容");
            rowhead.CreateCell(10, CellType.String).SetCellValue("分类");
            rowhead.CreateCell(11, CellType.String).SetCellValue("旧件是否退回");
            rowhead.CreateCell(12, CellType.String).SetCellValue("责任部门");
            rowhead.CreateCell(13, CellType.String).SetCellValue("责任人");
            rowhead.CreateCell(14, CellType.String).SetCellValue("第一次处理日期");
            rowhead.CreateCell(15, CellType.String).SetCellValue("批量/个案");
            rowhead.CreateCell(16, CellType.String).SetCellValue("对客户处理措施");
            rowhead.CreateCell(17, CellType.String).SetCellValue("完成日期");
            rowhead.CreateCell(18, CellType.String).SetCellValue("客服回访实际情况");
            rowhead.CreateCell(19, CellType.String).SetCellValue("完成日期");
            rowhead.CreateCell(20, CellType.String).SetCellValue("对库存处理措施");
            rowhead.CreateCell(21, CellType.String).SetCellValue("完成日期");
            rowhead.CreateCell(22, CellType.String).SetCellValue("对供应商处理措施");
            rowhead.CreateCell(23, CellType.String).SetCellValue("完成日期");
            rowhead.CreateCell(24, CellType.String).SetCellValue("内部流程工艺改善");
            rowhead.CreateCell(25, CellType.String).SetCellValue("完成日期");
            rowhead.CreateCell(26, CellType.String).SetCellValue("其它处理措施");
            rowhead.CreateCell(27, CellType.String).SetCellValue("完成日期");
            rowhead.CreateCell(28, CellType.String).SetCellValue("责任部门领导审批");
            rowhead.CreateCell(29, CellType.String).SetCellValue("第三方检核");
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
        //查．读
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