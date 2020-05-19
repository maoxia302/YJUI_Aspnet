using System;
using System.Data;
using System.Collections.Generic;
using YJUI.Common;
using YJUI.Model;
namespace YJUI.BLL
{
    /// <summary>
    /// ui_guzhang
    /// </summary>
    public partial class ui_guzhang
    {
        private readonly YJUI.DAL.ui_guzhang dal = new YJUI.DAL.ui_guzhang();
        public ui_guzhang()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            return dal.Exists(id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(YJUI.Model.ui_guzhang model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YJUI.Model.ui_guzhang model)
        {
            return dal.Update(model);
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
        public YJUI.Model.ui_guzhang GetModel(int id)
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
        public List<YJUI.Model.ui_guzhang> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YJUI.Model.ui_guzhang> DataTableToList(DataTable dt)
        {
            List<YJUI.Model.ui_guzhang> modelList = new List<YJUI.Model.ui_guzhang>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                YJUI.Model.ui_guzhang model;
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
        /// <summary>
        /// 获取JSON格式的故障名称
        /// </summary>
        /// <returns></returns>
        public string GetGuZhangToJson()
        {
            DataTable dt = dal.GetList("   typeid=1").Tables[0];
            return Common.JsonHelper.ToJson(dt);
        }
        /// <summary>
        /// 获取JSON格式的故障名称
        /// </summary>
        /// <returns></returns>
        public string GetGuZhangJianToJson()
        {
            DataTable dt = dal.GetList("   typeid=2").Tables[0];
            return Common.JsonHelper.ToJson(dt);
        }
        /// <summary>
        /// 获取JSON格式的故障名称
        /// </summary>
        /// <returns></returns>
        public string GetFaDongJiXingHaoToJson()
        {
            DataTable dt = dal.GetList("   typeid=3").Tables[0];
            return Common.JsonHelper.ToJson(dt);
        }
        /// <summary>
        /// 获取JSON格式的故障名称
        /// </summary>
        /// <returns></returns>
        public string GetItemToJson()
        {
            DataTable dt = dal.GetList("   typeid=4").Tables[0];
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("msg", "success");
            dic.Add("data", dt);
            return Common.JsonHelper.ObjToJson(dic);
        }
        public string GetItemToJson1()
        {
            DataTable dt = dal.GetList("   typeid=4").Tables[0];
            //Dictionary<string, object> dic = new Dictionary<string, object>();
            //dic.Add("msg", "success");
            //dic.Add("data", dt);
            return Common.JsonHelper.ObjToJson(dt);
        }
        public string GetDepToJson()
        {
            DataTable dt = dal.GetList("   typeid=5").Tables[0];
            return Common.JsonHelper.ToJson(dt);
        }
        public string GetPersonToJson()
        {
            DataTable dt = dal.GetList("   typeid=6").Tables[0];
            return Common.JsonHelper.ToJson(dt);
        }
        public string GetBrandToJson()
        {
            DataTable dt = dal.GetList("   typeid=7").Tables[0];
            return Common.JsonHelper.ToJson(dt);
        }
        public string GetDepCatToJson()
        {
            DataTable dt = dal.GetList("   typeid=8").Tables[0];
            return Common.JsonHelper.ToJson(dt);
        }
        public string GetDepItemToJson()
        {
            DataTable dt = dal.GetList("   typeid=9").Tables[0];
            return Common.JsonHelper.ToJson(dt);
        }
        #endregion  ExtensionMethod
    }
}

