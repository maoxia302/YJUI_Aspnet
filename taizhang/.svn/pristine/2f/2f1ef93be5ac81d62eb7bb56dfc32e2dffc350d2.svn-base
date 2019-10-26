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
    /// neibu_toexcel 的摘要说明
    /// </summary>
    public class neibu_toexcel : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string begindate = context.Request.Params["begindate"];
            string enddate = context.Request.Params["enddate"];
            StringBuilder sb = new StringBuilder();
            sb.Append("select ID,convert(char(10),fkDate,120) as 反馈时间 ,fkPerson as 反馈人 ,wtDep as 问题部门," +
                      "fkDesc as 反馈描述,dyDep as 领取部门,dyPerson as 领取人,dyDate as 领取时间,dyGaishan as 临时改善," +
                      "cqFangan as 长期方案,cqDate as 长期时间,lsJianhe as 落实检核,lsDep as 落实部门," +
                      "lsDate as 落实时间,myPingjia 满意评价,myPerson as 满意人, myDate as 满意时间," +
                      "dsJianhe as 第三方检核,dsPerson as 检核人,dsDate as 检核时间 from neibutaizhang where ");
            sb.Append(" fkDate between  @begindate  and  @enddate ");
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
            SqlDataReader reader = DbHelperSQL.ExecuteReader(sb.ToString(), parameters);
            IRow rowhead = sheet1.CreateRow(0);
            rowhead.CreateCell(0, CellType.String).SetCellValue("序号");
            rowhead.CreateCell(1, CellType.String).SetCellValue("反馈时间");
            rowhead.CreateCell(2, CellType.String).SetCellValue("反馈人");
            rowhead.CreateCell(3, CellType.String).SetCellValue("问题部门");
            rowhead.CreateCell(4, CellType.String).SetCellValue("反馈描述");
            rowhead.CreateCell(5, CellType.String).SetCellValue("领取部门");
            rowhead.CreateCell(6, CellType.String).SetCellValue("领取人");
            rowhead.CreateCell(7, CellType.String).SetCellValue("领取时间");
            rowhead.CreateCell(8, CellType.String).SetCellValue("临时改善");
            rowhead.CreateCell(9, CellType.String).SetCellValue("长期方案");
            rowhead.CreateCell(10, CellType.String).SetCellValue("长期时间");
            rowhead.CreateCell(11, CellType.String).SetCellValue("落实检核");
            rowhead.CreateCell(12, CellType.String).SetCellValue("落实部门");
            rowhead.CreateCell(13, CellType.String).SetCellValue("落实时间");
            rowhead.CreateCell(14, CellType.String).SetCellValue("满意评价");
            rowhead.CreateCell(15, CellType.String).SetCellValue("满意人");
            rowhead.CreateCell(16, CellType.String).SetCellValue("满意时间");
            rowhead.CreateCell(17, CellType.String).SetCellValue("第三方检核");
            rowhead.CreateCell(18, CellType.String).SetCellValue("检核人");
            rowhead.CreateCell(19, CellType.String).SetCellValue("检核时间");
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

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}