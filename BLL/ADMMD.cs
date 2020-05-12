using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YJUI.BLL
{
    public class ADMMD
    {
        private static ADMMD bll = null;
        public static ADMMD Current
        {
            get
            {
                if (bll == null)
                    bll = new ADMMD();
                return bll;
            }
        }

        public string admmds(string tbname)
        {
            return DAL.ADMMD.Current.admmds(tbname);
        }


    }
}
