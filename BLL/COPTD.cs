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
        /// <summary>
        /// 获取一条订单的所有单身
        /// </summary>
        /// <param name="db"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public PageableData<Model.COPTD> CoptdList(string db, string dh)
        {
            return DAL.COPTD.Current.CoptdList(db,dh);
        }
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
