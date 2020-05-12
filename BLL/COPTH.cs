using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YJUI.Common;

namespace YJUI.BLL
{
   public  class COPTH
    {

        public COPTH() { }
        //单例模式
        private static COPTH bll = null;
        public static COPTH Current
        {
            get
            {
                if (bll == null)
                    bll = new COPTH();
                return bll;
            }
        }


        /// <summary>
        /// 根据单别单号，获取一个实体类数据
        /// </summary>
        /// <param name="db"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public IEnumerable<Model.COPTH> GetCOPTH(string db, string dh)
        {
            return DAL.COPTH.Current.GetCOPTH(db, dh);
        }


    }
}
