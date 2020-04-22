using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YJUI.Common;
using YJUI.Model;

namespace YJUI.BLL
{
   public   class COPTC
    {
        private static COPTC bll = null;
        public static COPTC Current
        {
            get
            {
                if (bll == null)
                    bll = new COPTC();
                return bll;
            }
        }
        public COPTC() { }

        public PageableData<Model.COPTC> GetPageList(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return DAL.COPTC.Current.GetPageList(strWhere, orderby, startIndex, endIndex);
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
        /// 获取一条数据实体类
        /// </summary>
        /// <param name="tc001"></param>
        /// <param name="tc002"></param>
        /// <returns></returns>
        public Model.COPTC CoptcModel(string tc001, string tc002)

        {
            return DAL.COPTC.Current.CoptcModel(tc001,tc002);

        }
        public string GetCoptcToJson(Model.COPTC model)
        {
            return Common.JsonHelper.ObjToJson(model);

        }


    }
}
