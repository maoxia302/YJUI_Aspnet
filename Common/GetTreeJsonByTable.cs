using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace YJUI.Common
{
    public class GetTreeJsonByTable
    {
        /// <summary>
        /// 根据DataTable生成Json树结构
        /// </summary>
        /// <param name="tabel">数据源</param>
        /// <param name="idCol">ID列</param>
        /// <param name="txtCol">Text列</param>
        /// <param name="rela">关系字段</param>
        /// <param name="pId">父ID</param>
        public StringBuilder result = new StringBuilder();
        private StringBuilder sb = new StringBuilder();
        public void getJson(DataTable tabel, string idCol, string txtCol, string rela, object pId)
        {
            result.Append(sb.ToString());
            sb.Length = 0;
            if (tabel.Rows.Count > 0)
            {
                sb.Append("[");
                string filer = string.Empty;
                if (pId == null)
                {
                    filer = string.Format("{0} is  null", rela, pId);
                }
                else
                {
                    filer = string.Format("{0}='{1}'", rela, pId);
                }
                DataRow[] rows = tabel.Select(filer);
                if (rows.Length > 0)
                {
                    foreach (DataRow row in rows)
                    {
                        sb.Append("{\"id\":\"" + row[idCol] + "\",\"text\":\"" + row[txtCol] + "\"");
                        if (tabel.Select(string.Format("{0}='{1}'", rela, row[idCol])).Length > 0)
                        {
                            sb.Append(",\"children\":");
                            getJson(tabel, idCol, txtCol, rela, row[idCol]);
                            result.Append(sb.ToString());
                            sb.Length = 0;
                        }
                        result.Append(sb.ToString());
                        sb.Length = 0;
                        sb.Append("},");
                    }
                    sb = sb.Remove(sb.Length - 1, 1);
                }
                sb.Append("]");
                result.Append(sb.ToString());
                sb.Length = 0;
            }
        }
    }
}
