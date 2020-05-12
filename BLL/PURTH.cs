using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YJUI.BLL
{
    public class PURTH
    {

        public PURTH() { }
        private static PURTH bll = null;
        public static PURTH Current
        {
            get
            {
                if (bll == null)
                    bll = new PURTH();
                return bll;
            }
        }
        public bool Insert(List<Model.PURTH> purths)
        {
            return DAL.PURTH.Current.Insert(purths);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public IEnumerable<Model.PURTH> GetModelList(string db, string dh) {
            return DAL.PURTH.Current.GetModelList(db,dh);
        }
    }
}
