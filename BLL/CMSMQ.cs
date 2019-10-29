using System;
using System.Data;
using System.Collections.Generic;
using YJUI.Common;
using YJUI.Model;
namespace YJUI.BLL
{
    /// <summary>
    /// CMSMQ
    /// </summary>
    public partial class CMSMQ
    {
        private readonly YJUI.DAL.CMSMQ dal = new YJUI.DAL.CMSMQ();
        public CMSMQ()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string MQ001)
        {
            return dal.Exists(MQ001);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YJUI.Model.CMSMQ model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YJUI.Model.CMSMQ model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string MQ001)
        {

            return dal.Delete(MQ001);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string MQ001list)
        {
            return dal.DeleteList(MQ001list);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public YJUI.Model.CMSMQ GetModel(string MQ001)
        {

            return dal.GetModel(MQ001);
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
        public List<YJUI.Model.CMSMQ> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YJUI.Model.CMSMQ> DataTableToList(DataTable dt)
        {
            List<YJUI.Model.CMSMQ> modelList = new List<YJUI.Model.CMSMQ>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                YJUI.Model.CMSMQ model;
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
        public string GetCmsmqToJson(string strWhere)
        {
            DataTable dt = dal.GetList(strWhere).Tables[0];
            string strjson = Common.JsonHelper.ToJson(dt);
            return strjson;
        }



        #endregion  ExtensionMethod
    }
}

