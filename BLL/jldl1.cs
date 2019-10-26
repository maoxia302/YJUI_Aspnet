using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using YJUI.Common;
using YJUI.Model;

namespace YJUI.BLL
{
    /// <summary>
    /// jldl1
    /// </summary>
    public partial class jldl1
    {
        private readonly YJUI.DAL.jldl1 dal = new YJUI.DAL.jldl1();
        public jldl1()
        { }
        #region  BasicMethod

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YJUI.Model.jldl1 model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YJUI.Model.jldl1 model)
        {
            return dal.Update(model);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update_ceshi(YJUI.Model.jldl1 model)
        {
            return dal.Update_ceshi(model);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update_zrbm(YJUI.Model.jldl1 model)
        {
            return dal.Update_zrbm(model);
        }
        /// <summary>
        /// 领导审批
        /// </summary>
        public bool Update_zrbmsh(YJUI.Model.jldl1 model)
        {
            return dal.Update_zrbmsh(model);
        }
        /// <summary>
        /// 回访实际情况
        /// </summary>
        public bool Update_hfsjqk(YJUI.Model.jldl1 model)
        {
            return dal.Update_hfsjqk(model);
        }
        /// <summary>
        /// 第三方检核
        /// </summary>
        public bool Update_dsfjh(YJUI.Model.jldl1 model)
        {
            return dal.Update_dsfjh(model);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {

            return dal.Delete(ID);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public YJUI.Model.jldl1 GetModel(int ID)
        {

            return dal.GetModel(ID);
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
        public List<YJUI.Model.jldl1> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YJUI.Model.jldl1> DataTableToList(DataTable dt)
        {
            List<YJUI.Model.jldl1> modelList = new List<YJUI.Model.jldl1>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                YJUI.Model.jldl1 model;
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

        #endregion  BasicMethod

        #region  ExtensionMethod
        public string getJsonjldl1(int PageSize, int PageIndex, string strWhere)
        {
            int total = dal.getDataCount(strWhere); //总记录数
            int maxpage = (total/PageSize) + (total%PageSize == 0 ? 0 : 1);
            PageIndex = PageIndex <= maxpage ? PageIndex : maxpage;
            DataTable dt = dal.GetList(PageSize, PageIndex, strWhere, "*", "ID desc");
            string strjson = Common.JsonHelper.ToJson(dt);
            return "{\"total\": " + total.ToString() + ",\"rows\":" + strjson + "}";
        }
        #endregion  ExtensionMethod
    }
   
}
