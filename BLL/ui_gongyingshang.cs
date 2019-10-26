using System;
using System.Data;
using System.Collections.Generic;
using YJUI.Model;
namespace YJUI.BLL
{
    /// <summary>
    /// ui_gongyingshang
    /// </summary>
    public partial class ui_gongyingshang
    {
        private readonly YJUI.DAL.ui_gongyingshang dal = new YJUI.DAL.ui_gongyingshang();
        public ui_gongyingshang()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            return dal.Exists(id);
        }

        public int GetFlagById(int id)
        {
            return dal.GetFlagById(id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>


        /// <summary>
        /// 增加一条供应商到货数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_info(YJUI.Model.ui_gongyingshang model)
        {
            return dal.Add_info(model);
        }
        /// <summary>
        /// 添加卸车信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_XieChe(YJUI.Model.ui_gongyingshang model)
        {
            return dal.Add_XieChe(model);
        }
        public bool Add_DaoHuo(YJUI.Model.ui_gongyingshang model)
        {
            return dal.Add_DaoHuo(model);
        }
        public bool Add_ShouHuo(YJUI.Model.ui_gongyingshang model)
        {
            return dal.Add_WshouHuo(model);
        }

        public bool Add_CshouHuo(YJUI.Model.ui_gongyingshang model)
        {
            return dal.Add_CshouHuo(model);
        }

        public bool Add_BshouHuo(YJUI.Model.ui_gongyingshang model)
        {
            return dal.Add_BshouHuo(model);
        }

        public bool Add_FshouHuo(YJUI.Model.ui_gongyingshang model)
        {
            return dal.Add_FshouHuo(model);
        }

        public bool Add_ZshouHuo(YJUI.Model.ui_gongyingshang model)
        {
            return dal.Add_ZshouHuo(model);
        }

        /// <summary>
        /// 质检信息添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_ZhiJian(YJUI.Model.ui_gongyingshang model)
        {
            return dal.Add_ZhiJian(model);
        }
        /// <summary>
        /// 未成品添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_WeiChengPin(YJUI.Model.ui_gongyingshang model)
        {
            return dal.Add_WeiChengPin(model);
        }
        /// <summary>
        /// 成品添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_ChengPin(YJUI.Model.ui_gongyingshang model)
        {
            return dal.Add_ChengPin(model);
        }
        /// <summary>
        /// 包装添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_BaoZhuang(YJUI.Model.ui_gongyingshang model)
        {
            return dal.Add_BaoZhuang(model);
        }
        /// <summary>
        /// 非自有
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_FeiZiYou(YJUI.Model.ui_gongyingshang model)
        {
            return dal.Add_FeiZiYou(model);
        }

        public bool Add_ZengPin(YJUI.Model.ui_gongyingshang model)
        {
            return dal.Add_ZengPin(model);
        }

        public int UpdateStdDate(int id, int stepid)
        {
            return dal.UpdateStdDate(id, stepid);
        }

        /// <summary>
        /// 添加不良品信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_BuLiangPin(YJUI.Model.ui_gongyingshang model)
        {
            return dal.Add_BuLiangPin(model);
        }

        /// <summary>
        /// 添加重工信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_ChongGong(YJUI.Model.ui_gongyingshang model)
        {
            return dal.Add_ChongGong(model);
        }

        public bool Add_ChouCha(YJUI.Model.ui_gongyingshang model)
        {
            return dal.Add_ChouCha(model);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {
            return dal.Delete(id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            return dal.DeleteList(idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public YJUI.Model.ui_gongyingshang GetModel(int id)
        {

            return dal.GetModel(id);
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
        public List<YJUI.Model.ui_gongyingshang> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YJUI.Model.ui_gongyingshang> DataTableToList(DataTable dt)
        {
            List<YJUI.Model.ui_gongyingshang> modelList = new List<YJUI.Model.ui_gongyingshang>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                YJUI.Model.ui_gongyingshang model;
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
        public string GetJsonGongYingShang(int PageSize, int PageIndex, string strWhere)
        {
            int total;
            int counts;
            // GetList(string tblName, string fldName, int pageSize, int page, string fldSort, string strCondition, string ID, out int pageCount, out int Counts)
            DataTable dt = dal.GetList("ui_gongyingshang", "*", PageSize, PageIndex, "id", "1", strWhere, "id", "0", out counts, out total);
            string strjson = Common.JsonHelper.ToJson(dt);
            return "{\"total\": " + total.ToString() + ",\"rows\":" + strjson + "}";
        }
        #endregion  ExtensionMethod
    }
}

