using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YJUI.Common;
using YJUI.Model;

namespace YJUI.BLL
{
  public  class PURTG
    {

        //单例模式
        private static PURTG bll = null;
        public static PURTG Current
        {
            get
            {
                if (bll == null)
                    bll = new PURTG();
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
        public PageableData<Model.PURTG> GetPageList(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return DAL.PURTG.Current.GetPageList(strWhere, orderby, startIndex, endIndex);
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
        public string GetPurtgErpNo(string db)
        {
            return DAL.PURTG.Current.GetPurtgErpNo(db);
        }
        public bool Insert(Model.PURTG model)
        {
            return DAL.PURTG.Current.Insert(model);
        }
        /// <summary>
        /// 获取一条记录
        /// </summary>
        /// <param name="db"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public Model.PURTG GetSingleModel(string db, string dh)
        {
            return DAL.PURTG.Current.GetSingleModel(db,dh);
        }
        }
}
