using System;
using System.Data;
using System.Collections.Generic;
using YJUI.Model;
using YJUI.Common;
namespace YJUI.BLL
{
    /// <summary>
    /// ui_diaobo
    /// </summary>
    public partial class ui_diaobo
    {
        private readonly YJUI.DAL.ui_diaobo dal = new YJUI.DAL.ui_diaobo();
        public ui_diaobo()
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
        public int Add(YJUI.Model.ui_diaobo model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YJUI.Model.ui_diaobo model)
        {
            return dal.Update(model);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update_sfdh(YJUI.Model.ui_diaobo model)
        {
            return dal.Update_sfdh(model);
        }
        public bool Update_sfzr(YJUI.Model.ui_diaobo model)
        {
            return dal.Update_sfrz(model);
        }


        public int AddDiaoBo(string zhangtao,string yuandanbie, string yuandanhao, string xindanhao, string bumen, string beizhu, string zhuanchuku, string zhuanruku)
        {
            return dal.AddDiaoBo(zhangtao,yuandanbie, yuandanhao, xindanhao, bumen, beizhu, zhuanchuku, zhuanruku);
        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update_clzk(YJUI.Model.ui_diaobo model)
        {
            return dal.Update_clzk(model);
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
        public YJUI.Model.ui_diaobo GetModel(int ID)
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
        public List<YJUI.Model.ui_diaobo> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YJUI.Model.ui_diaobo> DataTableToList(DataTable dt)
        {
            List<YJUI.Model.ui_diaobo> modelList = new List<YJUI.Model.ui_diaobo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                YJUI.Model.ui_diaobo model;
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
        #endregion  BasicMethod
        #region  ExtensionMethod
        public string getJsondiaobo(int PageSize, int PageIndex, string strWhere)
        {
            int total = dal.getDataCount(strWhere);
            if (total == 0)
            {
                return "{\"total\": 0 ,\"rows\":[]}";
            }
            //总记录数
            int maxpage = (total / PageSize) + (total % PageSize == 0 ? 0 : 1);
            PageIndex = PageIndex <= maxpage ? PageIndex : maxpage;
            DataTable dt = dal.GetList(PageSize, PageIndex, strWhere, "*", "ID desc");
            string strjson = Common.JsonHelper.ToJson(dt);
            return "{\"total\": " + total.ToString() + ",\"rows\":" + strjson + "}";
        }
        #endregion  ExtensionMethod
    }
}

