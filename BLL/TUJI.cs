using System;
using System.Data;
using System.Collections.Generic;
using YJUI.Common;
using YJUI.Model;
namespace YJUI.BLL
{
    /// <summary>
    /// TUJI
    /// </summary>
    public partial class Tuji
    {
        private readonly YJUI.DAL.Tuji dal = new YJUI.DAL.Tuji();
        public Tuji()
        { }
        #region  基本方法
        /// <summary>
        /// 增加一条记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add(YJUI.Model.TUJI model)
        {
            return dal.Add(model);
        }
        /// <summary>
        /// 响应时间
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool XiangYing(YJUI.Model.TUJI model)
        {
            return dal.XiangYing(model);
        }
        /// <summary>
        /// 回访
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool HuiFang(YJUI.Model.TUJI model)
        {
            return dal.HuiFang(model);
        }
        /// <summary>
        /// 到货
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool DaoHuo(YJUI.Model.TUJI model)
        {
            return dal.GcDaoHuo(model);
        }

        public bool ChaiJian(YJUI.Model.TUJI model)
        {
            return dal.ChaiJian(model);
        }

        public bool ZhengGai(YJUI.Model.TUJI model)
        {
            return dal.ZhengGai(model);
        }

        public bool ChanPinBu(YJUI.Model.TUJI model)
        {
            return dal.ChanPinBu(model);
        }
        public bool GongChang(YJUI.Model.TUJI model)
        {
            return dal.GongChang(model);
        }
        public bool FenKuDaoHuo(YJUI.Model.TUJI model)
        {
            return dal.FenKuDaoHuo(model);
        }
        public bool ZkDaoHuo(YJUI.Model.TUJI model)
        {
            return dal.ZkDaoHuo(model);
        }
        /// <summary>
        /// 工厂到货
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool GcDaoHuo(YJUI.Model.TUJI model)
        {
            return dal.GcDaoHuo(model);
        }

        public bool update(YJUI.Model.TUJI model) 
        {
            return dal.update(model);
        }

        #endregion  基本方法
        #region  ExtensionMethod
        public string getJsonTUJI(int PageSize, int PageIndex, string strWhere)
        {
            int total = dal.getDataCount(strWhere);//总记录数
            int maxpage = (total / PageSize) + (total % PageSize == 0 ? 0 : 1);
            PageIndex = PageIndex <= maxpage ? PageIndex : maxpage;

            DataTable dt = dal.GetList(PageSize, PageIndex, strWhere, "*", "ID desc");
            string strjson = Common.JsonHelper.ToJson(dt);
            return "{\"total\": " + total.ToString() + ",\"rows\":" + strjson + "}";
        }

        #endregion  ExtensionMethod
    }
}

