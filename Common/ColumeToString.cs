using System;
using System.Text;
using System.Data;

namespace YJUI.Common
{
    public class ColumeToString
    {
        public string Convent(DataTable dt, int r)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sb.Append(dt.Rows[i][r]);
                sb.Append(",");
            }
            return sb.ToString().Trim(',');
        }
    }
}
