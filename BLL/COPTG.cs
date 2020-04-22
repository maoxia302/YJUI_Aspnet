using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YJUI.Common;
using YJUI.Model;

namespace YJUI.BLL
{
    public class COPTG
    {
        public COPTG() { }
        //单例模式
        private static COPTG bll = null;
        public static COPTG Current
        {
            get
            {
                if (bll == null)
                    bll = new COPTG();
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
        public PageableData<Model.COPTG> GetPageList(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return DAL.COPTG.Current.GetPageList(strWhere, orderby, startIndex, endIndex);
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="danbie"></param>
        /// <returns></returns>
        public string GetCoptgErpNo(string danbie) {
            return DAL.COPTG.Current.GetCoptgErpNo(danbie);
        }


    }
}
