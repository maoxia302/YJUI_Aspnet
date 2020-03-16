using System;
using System.Data;
using System.Collections.Generic;
using YJUI.Common;
using YJUI.Model;
namespace YJUI.BLL
{
    /// <summary>
    /// neibutaizhang
    /// </summary>
    public partial class neibutaizhang
    {
        private readonly YJUI.DAL.neibutaizhang dal = new YJUI.DAL.neibutaizhang();
        public neibutaizhang()
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
        public bool Add(YJUI.Model.neibutaizhang model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YJUI.Model.neibutaizhang model)
        {
            return dal.Update(model);
        }
        /// <summary>
        /// 落实检核
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update_luoshijianhe(YJUI.Model.neibutaizhang model)
        {
            return dal.Update_luoshijianhe(model);
        }
        /// <summary>
        /// 满意度调查
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update_manyidudiaocha(YJUI.Model.neibutaizhang model)
        {
            return dal.Update_manyidudiaocha(model);
        }
        public bool Update_disanfangjianhe(YJUI.Model.neibutaizhang model)
        {
            return dal.Update_disanfangjianhe(model);
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
        public YJUI.Model.neibutaizhang GetModel(int ID)
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
        public List<YJUI.Model.neibutaizhang> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YJUI.Model.neibutaizhang> DataTableToList(DataTable dt)
        {
            List<YJUI.Model.neibutaizhang> modelList = new List<YJUI.Model.neibutaizhang>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                YJUI.Model.neibutaizhang model;
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

        public string getJsonTaizhang(int PageSize,int PageIndex,string strWhere)
        {

            int total = dal.getDataCount(strWhere);
            int maxpage = (total/PageSize)+(total%PageSize==0 ? 0 : 1);
            PageIndex = PageIndex <= maxpage ? PageIndex : maxpage;
            DataTable dt = dal.GetList(PageSize,PageIndex,strWhere,"*","ID desc");
            string strjson = Common.JsonHelper.ToJson(dt);

            return "{\"total\": "+total.ToString()+",\"rows\":"+strjson+"}";


        }

        public string GetJsonneibuTaizhang(int PageSize, int PageIndex, string strWhere)
        {
            int total;
            int counts;
            // GetList(string tblName, string fldName, int pageSize, int page, string fldSort, string strCondition, string ID, out int pageCount, out int Counts)
            DataTable dt = dal.GetList("neibutaizhang", "*", PageSize, PageIndex, "ID", "1", strWhere, "ID", "0", out counts, out total);
            string strjson = Common.JsonHelper.ToJson(dt);
            if (total == 0)
            {
                return "{\"total\": \"0\",\"rows\":\"[]\"}";
            }
            return "{\"total\": " + total.ToString() + ",\"rows\":" + strjson + "}";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public IDataReader neiBuTaiZhangGetList(string strWhere) {
            return dal.neiBuTaiZhangGetList(strWhere);
        }

        #endregion  ExtensionMethod
    }
}

