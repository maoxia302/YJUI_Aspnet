using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YJUI.DAL
{
    public class ADMMD
    {
        private static ADMMD dal = null;
        public static ADMMD Current
        {
            get
            {
                if (dal == null)
                    dal = new ADMMD();
                return dal;
            }
        }

        public string  admmds(string tbname)
        {
            return DBUtility.ErpUtil.getTbField(tbname);
        }
    }
}
