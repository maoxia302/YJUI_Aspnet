using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using YJUI.Common;
using YJUI.Model;

namespace YJUI.BLL
{
    public class ui_shejitaizhang
    {
        public ui_shejitaizhang() { }
        //单例模式
        private static ui_shejitaizhang bll = null;
        public static ui_shejitaizhang Current
        {
            get
            {
                if (bll == null)
                    bll = new ui_shejitaizhang();
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
        public PageableData<Model.ui_shejitaizhang> GetPageList(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return DAL.ui_shejitaizhang.Current.GetPageList(strWhere, orderby, startIndex, endIndex);
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

        public void BulkCopypSheJi(DataTable dt)
        {
            DAL.ui_shejitaizhang.Current.BulkCopypSheJi(dt);

        }
    }
}
