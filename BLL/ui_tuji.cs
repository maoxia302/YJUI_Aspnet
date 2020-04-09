using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using YJUI.Common;
using YJUI.Model;

namespace YJUI.BLL
{
   public partial class ui_tuji
    {
        private readonly YJUI.DAL.ui_tuji dal = new YJUI.DAL.ui_tuji();
        public ui_tuji() { }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public PageableData<Model.ui_tuji> GetPageList(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetPageList(strWhere, orderby, startIndex, endIndex);
        }

        public string GetListToJson(string strWhere, string orderby, int startIndex, int endIndex)
        {
            var pageableData = GetPageList(strWhere, orderby, startIndex, endIndex);
            return JsonHelper.ObjToJson(pageableData);
        }
        public bool Insert(Model.ui_tuji model)
        {
           return dal.Insert(model);
        }


        public bool Zhuanxiang_add(Model.ui_tuji model) {
            return dal.Zhuanxiang_add(model);
        }
        public bool Houtai_add(Model.ui_tuji model) {
            return dal.Houtai_add(model);
        }
        public bool Kefu_add(Model.ui_tuji model) {
            return dal.Kefu_add(model);
        }

        public DataSet GetReport(string condition) {
            return dal.GetReport(condition);
        }

        public IEnumerable<Model.ui_tuji> list(string bdate, string edate, string fk_person, string fk_type)
        {
            return dal.list(bdate, edate, fk_person, fk_type);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bdate"></param>
        /// <param name="edate"></param>
        /// <param name="fk_person"></param>
        /// <param name="fk_type"></param>
        /// <returns></returns>
        public string ToJson(string bdate, string edate, string fk_person, string fk_type)
        {
            return JsonHelper.ObjToJson(list(bdate, edate, fk_person, fk_type));
        }

    }
}
