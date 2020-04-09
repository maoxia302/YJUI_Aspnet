using System;
using System.Data;
using System.Collections.Generic;
using YJUI.Common;
using YJUI.Model;
namespace YJUI.BLL
{
    /// <summary>
    /// INVMB
    /// </summary>
    public partial class INVMB
    {
        private readonly YJUI.DAL.INVMB dal = new YJUI.DAL.INVMB();
        public INVMB()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string MB001)
        {
            return dal.Exists(MB001);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YJUI.Model.INVMB model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YJUI.Model.INVMB model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string MB001)
        {

            return dal.Delete(MB001);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string MB001list)
        {
            return dal.DeleteList(MB001list);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public YJUI.Model.INVMB GetModel(string MB001)
        {

            return dal.GetModel(MB001);
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
        public List<YJUI.Model.INVMB> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YJUI.Model.INVMB> DataTableToList(DataTable dt)
        {
            List<YJUI.Model.INVMB> modelList = new List<YJUI.Model.INVMB>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                YJUI.Model.INVMB model;
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
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex,ref  int total )
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex,ref total);
        }
        #endregion  BasicMethod

        #region  ExtensionMethod

        public string GetListToJson(string strWhere, string orderby, int startIndex, int endIndex)
        {
            int total = 0;
            DataTable dt = GetListByPage(strWhere, orderby, startIndex, endIndex, ref total).Tables[0];
            string strjson = Common.JsonHelper.ToJson(dt);
            return "{\"total\": " + total.ToString() + ",\"rows\":" + strjson + "}";
        }

        public IEnumerable<Model.INVMB> GetListByWhere(string strWhere) {
            return dal.GetListByWhere(strWhere);
        }
        #endregion  ExtensionMethod
    }
}

