using System;
using System.Data;
using System.Collections.Generic;
using YJUI.Common;
using YJUI.Model;
namespace YJUI.BLL
{
    /// <summary>
    /// LRPTA
    /// </summary>
    public partial class LRPTA
    {
        private readonly YJUI.DAL.LRPTA dal = new YJUI.DAL.LRPTA();
        public LRPTA()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string TA003, string TA004, string TA026, string TA028, string TA050, string TA001, string TA002)
        {
            return dal.Exists(TA003, TA004, TA026, TA028, TA050, TA001, TA002);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YJUI.Model.LRPTA model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YJUI.Model.LRPTA model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string TA003, string TA004, string TA026, string TA028, string TA050, string TA001, string TA002)
        {

            return dal.Delete(TA003, TA004, TA026, TA028, TA050, TA001, TA002);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public YJUI.Model.LRPTA GetModel(string TA003, string TA004, string TA026, string TA028, string TA050, string TA001, string TA002)
        {

            return dal.GetModel(TA003, TA004, TA026, TA028, TA050, TA001, TA002);
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
        public List<YJUI.Model.LRPTA> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YJUI.Model.LRPTA> DataTableToList(DataTable dt)
        {
            List<YJUI.Model.LRPTA> modelList = new List<YJUI.Model.LRPTA>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                YJUI.Model.LRPTA model;
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

