using System;
using System.Data;
using System.Collections.Generic;
using YJUI.Common;
using YJUI.Model;
namespace YJUI.BLL
{
    /// <summary>
    /// LRPTE
    /// </summary>
    public partial class LRPTE
    {
        private readonly YJUI.DAL.LRPTE dal = new YJUI.DAL.LRPTE();
        public LRPTE()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string TE003, string TE004, string TE005, string TE006, string TE007, string TE009, string TE001, string TE002)
        {
            return dal.Exists(TE003, TE004, TE005, TE006, TE007, TE009, TE001, TE002);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YJUI.Model.LRPTE model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YJUI.Model.LRPTE model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string TE003, string TE004, string TE005, string TE006, string TE007, string TE009, string TE001, string TE002)
        {

            return dal.Delete(TE003, TE004, TE005, TE006, TE007, TE009, TE001, TE002);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public YJUI.Model.LRPTE GetModel(string TE003, string TE004, string TE005, string TE006, string TE007, string TE009, string TE001, string TE002)
        {

            return dal.GetModel(TE003, TE004, TE005, TE006, TE007, TE009, TE001, TE002);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YJUI.Model.LRPTE> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YJUI.Model.LRPTE> DataTableToList(DataTable dt)
        {
            List<YJUI.Model.LRPTE> modelList = new List<YJUI.Model.LRPTE>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                YJUI.Model.LRPTE model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

