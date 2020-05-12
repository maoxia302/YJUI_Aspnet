using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YJUI.Model;

namespace YJUI.BLL
{
   public  class COPTD
    {
        private static COPTD bll = null;
        public static COPTD Current
        {
            get
            {
                if (bll == null)
                    bll = new COPTD();
                return bll;
            }
        }
        public COPTD() { }

        public string coptdToJson(string db, string dh)
        {
            string strjson = Common.JsonHelper.ObjToJson(GetCOPTDs(db, dh));
             return "{\"rows\":" + strjson + "}";
        }

        public IEnumerable<Model.COPTD> GetCOPTDs(string db, string dh) {
            return DAL.COPTD.Current.GetCOPTDs(db, dh);

        }
    }
}
