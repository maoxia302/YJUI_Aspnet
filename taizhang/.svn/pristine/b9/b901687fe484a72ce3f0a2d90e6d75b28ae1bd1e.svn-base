using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text.RegularExpressions;


namespace YJUI.UI.themes
{
    public partial class icon_show_dom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] iconcss = File.ReadAllLines(MapPath("icon.css"));
            //string aaa = "111";
            List<string> icons = new List<string>();
            for (int i = 0; i < iconcss.Length; i++)
            {
                if (!string.IsNullOrEmpty(iconcss[i]))
                {
                    if (iconcss[i].Substring(0, 1) == ".")
                    {
                        icons.Add(iconcss[i]);
                    }
                }
            }
           

        }
    }
}