using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YJUI.Common;
using YJUI.Model;

namespace YJUI.BLL
{
   public class PURMA
    {
        public PURMA() { }
        //单例模式
        private static PURMA bll = null;
        public static PURMA Current
        {
            get
            {
                if (bll == null)
                    bll = new PURMA();
                return bll;
            }
        }
        /// <summary>
        /// 分页list
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="orderby"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public PageableData<Model.PURMA> GetPageList(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return DAL.PURMA.Current.GetPageList(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 前台json
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="orderby"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public string GetListToJson(string strWhere, string orderby, int startIndex, int endIndex)
        {
            var pageableData = GetPageList(strWhere, orderby, startIndex, endIndex);
            return JsonHelper.ObjToJson(pageableData);
        }
        public Model.PURMA GetPURMA(string ma001)
        {
            return DAL.PURMA.Current.GetPURMA(ma001);
        }


    }
}
