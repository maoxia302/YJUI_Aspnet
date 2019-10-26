using System;
using System.Data;
using System.Collections.Generic;
using YJUI.Common;
using YJUI.Model;
namespace YJUI.BLL
{
    /// <summary>
    /// ui_zydtaizhang
    /// </summary>
    public partial class ui_zydtaizhang
    {
        private readonly YJUI.DAL.ui_zydtaizhang dal = new YJUI.DAL.ui_zydtaizhang();
        public ui_zydtaizhang()
        { }
        #region  基本方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            return dal.Exists(ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YJUI.Model.ui_zydtaizhang model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YJUI.Model.ui_zydtaizhang model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {

            return dal.Delete(ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            return dal.DeleteList(IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public YJUI.Model.ui_zydtaizhang GetModel(int ID)
        {

            return dal.GetModel(ID);
        }

        public bool Update_luoshijianhe(YJUI.Model.ui_zydtaizhang model)
        {
            return dal.Update_luoshijianhe(model);
        }

        public bool Update_manyidudiaocha(YJUI.Model.ui_zydtaizhang model)
        {
            return dal.Update_manyidudiaocha(model);
        }

        public bool Update_disanfangjianhe(YJUI.Model.ui_zydtaizhang model)
        {
            return dal.Update_disanfangjianhe(model);

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
        public List<YJUI.Model.ui_zydtaizhang> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YJUI.Model.ui_zydtaizhang> DataTableToList(DataTable dt)
        {
            List<YJUI.Model.ui_zydtaizhang> modelList = new List<YJUI.Model.ui_zydtaizhang>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                YJUI.Model.ui_zydtaizhang model;
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

        #region  ExtensionMetho

        public string GetJsonZydTaizhang(int PageSize, int PageIndex, string strWhere)
        {
            int total;
            int counts;
           // GetList(string tblName, string fldName, int pageSize, int page, string fldSort, string strCondition, string ID, out int pageCount, out int Counts)
            DataTable dt = dal.GetList("ui_zydtaizhang", "*", PageSize, PageIndex, "ID", "1", strWhere, "ID", "0", out counts, out total);
            string strjson = Common.JsonHelper.ToJson(dt);
            return "{\"total\": " + total.ToString() + ",\"rows\":" + strjson + "}";
        }
        #endregion  ExtensionMethod
    }
}

