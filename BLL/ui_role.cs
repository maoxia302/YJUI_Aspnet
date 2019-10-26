using System;
using System.Data;
using System.Collections.Generic;

using YJUI.Model;
namespace YJUI.BLL
{
    /// <summary>
    /// ui_role
    /// </summary>
    public partial class ui_role
    {
        private readonly YJUI.DAL.ui_role dal = new YJUI.DAL.ui_role();
        public ui_role()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid id)
        {
            return dal.Exists(id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YJUI.Model.ui_role model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YJUI.Model.ui_role model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Guid id)
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
        public YJUI.Model.ui_role GetModel(Guid id)
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
        public List<YJUI.Model.ui_role> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YJUI.Model.ui_role> DataTableToList(DataTable dt)
        {
            List<YJUI.Model.ui_role> modelList = new List<YJUI.Model.ui_role>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                YJUI.Model.ui_role model;
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
        /// 获取json格式的role
        /// </summary>
        /// <returns></returns>
        public string getJsonRole()
        {
            DataTable dt = dal.GetList("1=1 order by crdate desc ").Tables[0];
            return Common.JsonHelper.ToJson(dt);
        }
        /// <summary>
        /// 增加一个角色，带操作权限,roleMenu 是以逗号分隔的ui_menu_id
        /// </summary>
        public bool Add(YJUI.Model.ui_role model, string roleMenu)
        {
            Guid role_id = Guid.NewGuid();
            model.id = role_id;
            List<Model.ui_role_menu> T_role_menu = new List<ui_role_menu>();
            if (!string.IsNullOrEmpty(roleMenu.Trim(',')))
            {
                string[] strs = roleMenu.Trim(',').Split(',');

                for (int i = 0; i < strs.Length; i++)
                {
                    Model.ui_role_menu m_role_menu = new ui_role_menu();

                    m_role_menu.ui_role_id = role_id;
                    m_role_menu.ui_menu_id = int.Parse(strs[i]);
                    m_role_menu.crdate = DateTime.Now;
                    T_role_menu.Add(m_role_menu);
                }
            }
            return dal.Add(model, T_role_menu);

        }

        public bool setRole(string roleid, string roleMenu)
        {

            DataTable dt_role_menu_old = new DAL.ui_role_menu().GetList(" ui_role_id='" + roleid + "' ").Tables[0];
            string[] strs_rolemenu = roleMenu.Trim(',').Split(',');
            List<Model.ui_role_menu> T_role_menu_add = new List<ui_role_menu>();
            List<Model.ui_role_menu> T_role_menu_dele = new List<ui_role_menu>();
            for (int i = 0; i < dt_role_menu_old.Rows.Count; i++)
            {
                if (Array.IndexOf(strs_rolemenu, dt_role_menu_old.Rows[i]["ui_menu_id"].ToString()) == -1) //新权限中不包含旧的，删除掉
                {
                    Model.ui_role_menu model = new ui_role_menu();
                    model.id = Convert.ToInt32(dt_role_menu_old.Rows[i]["id"]);
                    T_role_menu_dele.Add(model);
                }
            }

            if (!string.IsNullOrEmpty(roleMenu))
            {
                for (int j = 0; j < strs_rolemenu.Length; j++)
                {
                    if (dt_role_menu_old.Select("ui_menu_id=" + strs_rolemenu[j]).Length == 0)
                    {
                        Model.ui_role_menu model = new ui_role_menu();
                        model.ui_role_id = new Guid(roleid);
                        model.ui_menu_id = int.Parse(strs_rolemenu[j]);
                        model.crdate = DateTime.Now;
                        T_role_menu_add.Add(model);
                    }
                    // if(dt_role_menu_old.Columns["ui_menu_id"])
                }
            }

            return new DAL.ui_role_menu().mergeRoleMenu(T_role_menu_add, T_role_menu_dele);

        }

        public string AllMenuAndRole(Guid id)
        {
            DataTable dt = dal.AllMenuAndRole(id);
            string json= Common.JsonHelper.ToJson(dt);
            return "{\"rows\":" + json + "}";
        }

        #endregion  ExtensionMethod
    }
}

