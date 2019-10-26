using System;
using System.Data;
using System.Collections.Generic;
using YJUI.Common;
using YJUI.Model;
namespace YJUI.BLL
{
    /// <summary>
    /// shiwu
    /// </summary>
    public partial class shiwu
    {
        private readonly YJUI.DAL.shiwu dal = new YJUI.DAL.shiwu();
        public shiwu()
        { }
        #region  BasicMethod
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
        public bool Add(YJUI.Model.shiwu model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YJUI.Model.shiwu model)
        {
            return dal.Jianhe(model);
        }

        public bool Chuli(YJUI.Model.shiwu model)
        {
            return dal.Chuli(model);
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
        public YJUI.Model.shiwu GetModel(int ID)
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
        public List<YJUI.Model.shiwu> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YJUI.Model.shiwu> DataTableToList(DataTable dt)
        {
            List<YJUI.Model.shiwu> modelList = new List<YJUI.Model.shiwu>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                YJUI.Model.shiwu model;
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
        public string GetJsonShiWu(int PageSize, int PageIndex, string strWhere)
        {
            int total;
            int counts;
            // GetList(string tblName, string fldName, int pageSize, int page, string fldSort, string strCondition, string ID, out int pageCount, out int Counts)
            DataTable dt = dal.GetList("shiwu", "*", PageSize, PageIndex, "ID", "1", strWhere, "ID", "0", out counts, out total);
            string strjson = Common.JsonHelper.ToJson(dt);
            if (total == 0)
            {
                return "{\"total\": \"0\",\"rows\":\"[]\"}";
            }
            return "{\"total\": " + total.ToString() + ",\"rows\":" + strjson + "}";
        }

        public bool Jianhe(YJUI.Model.shiwu model)
        {
            return dal.Jianhe(model);
        }

        public bool PingJia(YJUI.Model.shiwu model)
        {
            return dal.PingJia(model);
        }

        public bool DiSanFang(YJUI.Model.shiwu model)
        {
            return dal.DiSanFang(model);
        }

        #endregion  ExtensionMethod
    }
}

