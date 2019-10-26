using System;
using System.Data;
using System.Collections.Generic;
using YJUI.Model;
using System.Text;
namespace YJUI.BLL
{
    /// <summary>
    /// ui_menu
    /// </summary>
    public partial class ui_menu
    {
        private readonly YJUI.DAL.ui_menu dal = new YJUI.DAL.ui_menu();
        public ui_menu()
        { }
        #region  BasicMethod

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(YJUI.Model.ui_menu model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YJUI.Model.ui_menu model)
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
        public YJUI.Model.ui_menu GetModel(int id)
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
        public List<YJUI.Model.ui_menu> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YJUI.Model.ui_menu> DataTableToList(DataTable dt)
        {
            List<YJUI.Model.ui_menu> modelList = new List<YJUI.Model.ui_menu>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                YJUI.Model.ui_menu model;
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
        public string getJson(string type)
        {
            DataTable dt = dal.GetList("1=1 ").Tables[0];
            dt.Columns["fatherid"].ColumnName = "_parentId";
            dt.Columns["icon"].ColumnName = "iconCls";
            string strJson = Common.JsonHelper.ToJson(dt);
            if (type =="tree")
            {
                return strJson;
            }
            else
            {
                return "{\"rows\":" + strJson + "}";

            }
        }

        /// <summary>
        /// 根据操作员权限所对应的json格式字符串
        /// </summary>
        /// <returns></returns>
        public string getJsonMenu(Guid userid)
        {
            DataTable dt_main = dal.getUserMenu(userid);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            DataRow[] rows = dt_main.Select("fatherid=0");

            if (rows.Length > 0)
            {
                sb.Append("{ \"menus\": [");
                for (int i = 0; i < rows.Length; i++)
                {
                    DataRow[] r_list = dt_main.Select(string.Format(" fatherid={0}", rows[i]["ui_menu_id"]));
                    if (r_list.Length > 0)
                    {
                        sb.Append("{ \"menuid\": \"" + rows[i]["ui_menu_id"].ToString() + "\", \"icon\": \"" + rows[i]["icon"].ToString() + "\", \"menuname\": \"" + rows[i]["menuname"].ToString() + "\",\"menus\": [");
                        for (int j = 0; j < r_list.Length; j++)
                        {
                            sb.Append("{ \"menuid\": \"" + r_list[j]["ui_menu_id"].ToString() + "\", \"menuname\": \"" + r_list[j]["menuname"].ToString() + "\", \"icon\": \"" + r_list[j]["icon"].ToString() + "\", \"url\": \"" + r_list[j]["url"].ToString() + "\" },");
                        }
                        //去，
                        sb.Remove(sb.Length - 1, 1);
                        sb.Append("]},");
                    }
                }
                //去，
                sb.Remove(sb.Length - 1, 1);
                sb.Append("]}");
            }
            return sb.ToString();
        }
        /// <summary>
        /// 所有菜单
        /// </summary>
        /// <returns></returns>
        public string getJsonTree()
        {
            DataTable dt_main = dal.GetList("fatherid=0  order by menuorder").Tables[0];
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("[{\"text\":\"导航菜单\",\"children\":[");
            if (dt_main.Rows.Count > 0)
            {
                for (int i = 0; i < dt_main.Rows.Count; i++)
                {
                    sb.Append("{\"id\":\"" + dt_main.Rows[i]["id"].ToString() + "\",\"text\":\"" + dt_main.Rows[i]["menuname"].ToString() + "\",\"iconCls\":\"" + dt_main.Rows[i]["icon"].ToString() + "\",\"children\":[");
                    //
                    string sqlwhere = string.Format("fatherid={0} order by menuorder", dt_main.Rows[i]["id"].ToString());
                    DataTable dt_list = dal.GetList(sqlwhere).Tables[0];
                    for (int j = 0; j < dt_list.Rows.Count; j++)
                    {
                        sb.Append("{\"id\":\"" + dt_list.Rows[j]["id"].ToString() + "\",\"text\":\"" + dt_list.Rows[j]["menuname"].ToString() + "\",\"iconCls\":\"" + dt_list.Rows[j]["icon"].ToString() + "\"},");
                    }
                    if (dt_list.Rows.Count > 0)
                    {
                        sb.Remove(sb.Length - 1, 1);
                    }
                    sb.Append("]},");
                }
                sb.Remove(sb.Length - 1, 1);
            }

            sb.Append("]}]");
            return sb.ToString();
        }
        /// 某个用户带权限功菜单列表
        /// </summary>
        /// <param name="guid">用户guid</param>
        /// <returns></returns>
        public string getJsonTree(string guid)
        {
            DataTable dt_main = dal.GetRole_menu_right("fatherid=0 and ui_role_id='" + guid + "'  order by menuorder").Tables[0];
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("[{\"text\":\"导航菜单\",\"children\":[");
            if (dt_main.Rows.Count > 0)
            {
                for (int i = 0; i < dt_main.Rows.Count; i++)
                {
                    sb.Append("{\"id\":\"" + dt_main.Rows[i]["ui_menu_id"].ToString() + "\",\"text\":\"" + dt_main.Rows[i]["menuname"].ToString() + "\",\"iconCls\":\"" + dt_main.Rows[i]["icon"].ToString() + "\",\"children\":[");
                    //
                    string sqlwhere = string.Format("fatherid={0} and  ui_role_id='{1}' order by menuorder", dt_main.Rows[i]["ui_menu_id"].ToString(), guid);
                    DataTable dt_list = dal.GetRole_menu_right(sqlwhere).Tables[0];
                    for (int j = 0; j < dt_list.Rows.Count; j++)
                    {
                        sb.Append("{\"id\":\"" + dt_list.Rows[j]["ui_menu_id"].ToString() + "\",\"text\":\"" + dt_list.Rows[j]["menuname"].ToString() + "\",\"iconCls\":\"" + dt_list.Rows[j]["icon"].ToString() + "\",\"checked\":" + dt_list.Rows[j]["roleright"].ToString() + "},");
                    }
                    if (dt_list.Rows.Count > 0)
                    {
                        sb.Remove(sb.Length - 1, 1);
                    }
                    sb.Append("]},");
                }
                sb.Remove(sb.Length - 1, 1);
            }

            sb.Append("]}]");
            return sb.ToString();
        }



        /// <summary>
        /// 根据DataTable生成Json树结构
        /// </summary>
        /// <param name="tabel">数据源</param>
        /// <param name="idCol">ID列</param>
        /// <param name="txtCol">Text列</param>
        /// <param name="rela">关系字段</param>
        /// <param name="pId">父ID</param>
        StringBuilder result = new StringBuilder();
        StringBuilder sb = new StringBuilder();
        private void GetTreeJsonByTable(DataTable tabel, string idCol, string txtCol, string rela, object pId)
        {
            result.Append(sb.ToString());
            sb.Clear();
            if (tabel.Rows.Count > 0)
            {
                sb.Append("[");
                string filer = string.Format("{0}='{1}'", rela, pId);
                DataRow[] rows = tabel.Select(filer);
                if (rows.Length > 0)
                {
                    foreach (DataRow row in rows)
                    {
                        sb.Append("{\"id\":\"" + row[idCol] + "\",\"text\":\"" + row[txtCol] + "\",\"state\":\"open\"");
                        if (tabel.Select(string.Format("{0}='{1}'", rela, row[idCol])).Length > 0)
                        {
                            sb.Append(",\"children\":");
                            GetTreeJsonByTable(tabel, idCol, txtCol, rela, row[idCol]);
                            result.Append(sb.ToString());
                            sb.Clear();
                        }
                        result.Append(sb.ToString());
                        sb.Clear();
                        sb.Append("},");
                    }
                    sb = sb.Remove(sb.Length - 1, 1);
                }
                sb.Append("]");
                result.Append(sb.ToString());
                sb.Clear();
            }
        }
        public string  getJSONMenu() 
        {
            DataTable dt = dal.getMenu();
            return Common.JsonHelper.ToJson(dt);
           
        }



        #endregion  ExtensionMethod
    }
}

