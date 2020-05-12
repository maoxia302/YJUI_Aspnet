using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YJUI.BLL
{
   public class PURTD
    {
        public PURTD() { }
        //单例模式
        private static PURTD bll = null;
        public static PURTD Current
        {
            get
            {
                if (bll == null)
                    bll = new PURTD();
                return bll;
            }
        }
        public IEnumerable<Model.Dtos.PurtdDto>  GetPurtdList(string db, string dh)
        {
            return DAL.PURTD.Current.GetPurtdList(db, dh);
        }
    }
}
