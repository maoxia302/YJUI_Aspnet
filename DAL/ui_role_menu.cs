using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using YJUI.DBUtility;
using System.Collections.Generic;
using System.Collections;//Please add references
namespace YJUI.DAL
{
    /// <summary>
    /// 数据访问类:ui_role_menu
    /// </summary>
    public partial class ui_role_menu
    {
        public ui_role_menu()
        { }
        #region  BasicMethod


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(YJUI.Model.ui_role_menu model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ui_role_menu(");
            strSql.Append("ui_role_id,ui_menu_id,crdate)");
            strSql.Append(" values (");
            strSql.Append("@ui_role_id,@ui_menu_id,@crdate)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@ui_role_id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@ui_menu_id", SqlDbType.Int,4),
					new SqlParameter("@crdate", SqlDbType.DateTime)};
            parameters[0].Value = model.ui_role_id;
            parameters[1].Value = model.ui_menu_id;
            parameters[2].Value = model.crdate;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YJUI.Model.ui_role_menu model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_role_menu set ");
            strSql.Append("ui_role_id=@ui_role_id,");
            strSql.Append("ui_menu_id=@ui_menu_id,");
            strSql.Append("crdate=@crdate");
            strSql.Append(" where ID=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@ui_role_id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@ui_menu_id", SqlDbType.Int,4),
					new SqlParameter("@crdate", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = model.ui_role_id;
            parameters[1].Value = model.ui_menu_id;
            parameters[2].Value = model.crdate;
            parameters[3].Value = model.id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ui_role_menu ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ui_role_menu ");
            strSql.Append(" where id in (" + idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public YJUI.Model.ui_role_menu GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,ui_role_id,ui_menu_id,crdate from ui_role_menu ");
            strSql.Append(" where ID=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            YJUI.Model.ui_role_menu model = new YJUI.Model.ui_role_menu();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public YJUI.Model.ui_role_menu DataRowToModel(DataRow row)
        {
            YJUI.Model.ui_role_menu model = new YJUI.Model.ui_role_menu();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["ui_role_id"] != null && row["ui_role_id"].ToString() != "")
                {
                    model.ui_role_id = new Guid(row["ui_role_id"].ToString());
                }
                if (row["ui_menu_id"] != null && row["ui_menu_id"].ToString() != "")
                {
                    model.ui_menu_id = int.Parse(row["ui_menu_id"].ToString());
                }
                if (row["crdate"] != null && row["crdate"].ToString() != "")
                {
                    model.crdate = DateTime.Parse(row["crdate"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,ui_role_id,ui_menu_id,crdate ");
            strSql.Append(" FROM ui_role_menu ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" id,ui_role_id,ui_menu_id,crdate ");
            strSql.Append(" FROM ui_role_menu ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM ui_role_menu ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 更新某个用户的权限，添加新增的，移除删除的
        /// </summary>
        /// <returns></returns>
        public bool mergeRoleMenu(List<Model.ui_role_menu> T_role_menu_add, List<Model.ui_role_menu> T_role_menu_dele)
        {
            Hashtable SQLStringList = new Hashtable();
            for (int i = 0; i < T_role_menu_add.Count; i++)
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into ui_role_menu(");
                strSql.Append("ui_role_id,ui_menu_id,crdate)");
                strSql.Append(" values (");
                strSql.Append("@ui_role_id,@ui_menu_id,@crdate)");
                strSql.Append(";select @@IDENTITY");
                SqlParameter[] parameters = {
					new SqlParameter("@ui_role_id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@ui_menu_id", SqlDbType.Int,4),
					new SqlParameter("@crdate", SqlDbType.DateTime)};
                parameters[0].Value = T_role_menu_add[i].ui_role_id;
                parameters[1].Value = T_role_menu_add[i].ui_menu_id;
                parameters[2].Value = T_role_menu_add[i].crdate;
                SQLStringList.Add(strSql, parameters);

            }

            foreach (Model.ui_role_menu model in T_role_menu_dele)
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("delete from ui_role_menu ");
                strSql.Append(" where id=@id");
                SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
                parameters[0].Value = model.id;
                SQLStringList.Add(strSql, parameters);
            }
            try
            {
                DbHelperSQL.ExecuteSqlTran(SQLStringList);
                return true;

            }
            catch (Exception e)
            {
                return false;
            }

        }
        #endregion  ExtensionMethod
    }
}


