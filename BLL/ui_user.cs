using System;
using System.Data;
using System.Collections.Generic;
using YJUI.Common;
using YJUI.Model;
namespace YJUI.BLL
{
    /// <summary>
    /// ui_user
    /// </summary>
    public partial class ui_user
    {
        private readonly YJUI.DAL.ui_user dal = new YJUI.DAL.ui_user();
        public ui_user()
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
        public bool Add(YJUI.Model.ui_user model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YJUI.Model.ui_user model)
        {
            if (dal.GetList("account='" + model.account + "' and ID<>'" + model.id + "'").Tables[0].Rows.Count > 0)
            {
                Exception ex = new Exception("账号重复！");
                throw ex;
            }
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
        public YJUI.Model.ui_user GetModel(Guid id)
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
        public List<YJUI.Model.ui_user> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YJUI.Model.ui_user> DataTableToList(DataTable dt)
        {
            List<YJUI.Model.ui_user> modelList = new List<YJUI.Model.ui_user>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                YJUI.Model.ui_user model;
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
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string getJsonUser(int PageSize, int PageIndex, string strWhere)
        {
            int total = dal.getDataCount(strWhere);//总记录数
            int maxpage = (total / PageSize) + (total % PageSize == 0 ? 0 : 1);
            PageIndex = PageIndex <= maxpage ? PageIndex : maxpage;
            DataTable dt = dal.GetList(PageSize, PageIndex, strWhere, "*", "xingming");
            dt.Columns.Add(new DataColumn("userrole"));
            dt.Columns.Add(new DataColumn("userorg"));
            DAL.ui_org dal_org = new DAL.ui_org();
            DAL.ui_role dal_role = new DAL.ui_role();
            Common.ColumeToString cts = new ColumeToString();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["userorg"] = cts.Convent(dal_org.getOrgByUserid(dt.Rows[i]["ID"]), 1); 
                dt.Rows[i]["userrole"] = cts.Convent(dal_role.getRoleByUserid(dt.Rows[i]["ID"]), 1);
            }
            string strjson = Common.JsonHelper.ToJson(dt);
            return "{\"total\": " + total.ToString() + ",\"rows\":" + strjson + "}";
        }

        public string GetUser()
        {
            DataTable dt = dal.GetList().Tables[0];
            int total=dal.getDataCount("1=1");
            string strjson = Common.JsonHelper.ToJson(dt);
            return "{\"total\": " + total.ToString() + ",\"rows\":" + strjson + "}";
        }

        /// <summary>
        /// 插入用户和用户的 角色、组织
        /// </summary>
        /// <param name="model">用户</param>
        /// <param name="user_role">角色</param>
        /// <param name="user_org">组织</param>
        /// <returns></returns>
        public bool Add(YJUI.Model.ui_user model, string user_role, string user_org)
        {
            if (dal.ExistsUser(model.account))
            {
                Exception ex = new Exception("账号重复！");
                throw ex;
            }


            List<Model.ui_user_role> T_ui_role = new List<ui_user_role>();
            List<Model.ui_user_org> T_ui_org = new List<ui_user_org>();
            if (!string.IsNullOrEmpty(user_role))
            {
                for (int i = 0; i < user_role.Split(',').Length; i++)
                {
                    Model.ui_user_role model_user_role = new ui_user_role();
                    model_user_role.ui_user_id = model.id;
                    model_user_role.ui_role_id = new Guid(user_role.Split(',')[i]);
                    model_user_role.crdate = DateTime.Now;
                    T_ui_role.Add(model_user_role);
                }
            }

            if (!string.IsNullOrEmpty(user_org))
            {
                for (int i = 0; i < user_org.Split(',').Length; i++)
                {
                    Model.ui_user_org model_user_org = new ui_user_org();
                    model_user_org.ui_user_id = model.id;
                    model_user_org.ui_org_id = new Guid(user_org.Split(',')[i]);
                    model_user_org.crdate = DateTime.Now;
                    T_ui_org.Add(model_user_org);
                }
            }
            return dal.Add(model, T_ui_role, T_ui_org);
        }

        /// <summary>
        /// 批量为用户设置角色
        /// </summary>
        /// <param name="users">用户id 以逗号分隔</param>
        /// <param name="roles">用户角色id 以逗号分隔</param>
        /// <returns></returns>
        public bool setrole(string users, string roles)
        {

            return dal.setrole(users.Split(','), roles.Split(','));
        }

        /// <summary>
        /// 批量为用户设置组织
        /// </summary>
        /// <param name="users">用户id 以逗号分隔</param>
        /// <param name="roles">用户角色id 以逗号分隔</param>
        /// <returns></returns>
        public bool setorg(string users, string orgs)
        {

            return dal.setorg(users.Split(','), orgs.Split(','));
        }

        public Model.ui_user Login(string acc, string pwd)
        {
            return dal.Login(acc, pwd);
        }



        #endregion  ExtensionMethod
    }
}

