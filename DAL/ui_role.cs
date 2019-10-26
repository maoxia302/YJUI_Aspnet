using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using YJUI.DBUtility;
using System.Collections;
namespace YJUI.DAL
{
    /// <summary>
    /// 数据访问类:ui_role
    /// </summary>
    public partial class ui_role
    {
        public ui_role()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ui_role");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YJUI.Model.ui_role model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ui_role(");
            strSql.Append("id,rolename,beizhu,crdate)");
            strSql.Append(" values (");
            strSql.Append("@id,@rolename,@beizhu,@crdate)");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@rolename", SqlDbType.NVarChar,50),
					new SqlParameter("@beizhu", SqlDbType.NVarChar,100),
					new SqlParameter("@crdate", SqlDbType.DateTime)};
            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.rolename;
            parameters[2].Value = model.beizhu;
            parameters[3].Value = model.crdate;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(YJUI.Model.ui_role model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_role set ");
            strSql.Append("rolename=@rolename,");
            strSql.Append("beizhu=@beizhu");

            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@rolename", SqlDbType.NVarChar,50),
					new SqlParameter("@beizhu", SqlDbType.NVarChar,100),
					new SqlParameter("@id", SqlDbType.UniqueIdentifier,16)};
            parameters[0].Value = model.rolename;
            parameters[1].Value = model.beizhu;
            parameters[2].Value = model.id;
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
        public bool Delete(Guid id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ui_role ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = id;
            Hashtable SQLStringList = new Hashtable();
            SQLStringList.Add(strSql, parameters);

            StringBuilder strSql1 = new StringBuilder();
            strSql1.Append("delete from ui_role_menu ");
            strSql1.Append(" where ui_role_id=@id ");
            SqlParameter[] parameters1 = {
					new SqlParameter("@id", SqlDbType.UniqueIdentifier,16)			};
            parameters1[0].Value = id;
            SQLStringList.Add(strSql1, parameters1);
            try
            {
                DbHelperSQL.ExecuteSqlTran(SQLStringList);
                return true;

            }
            catch (Exception e)
            {
                return false;
            }



            // int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            //if (rows > 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ui_role ");
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
        public YJUI.Model.ui_role GetModel(Guid id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,rolename,beizhu,crdate from ui_role ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = id;

            YJUI.Model.ui_role model = new YJUI.Model.ui_role();
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
        public YJUI.Model.ui_role DataRowToModel(DataRow row)
        {
            YJUI.Model.ui_role model = new YJUI.Model.ui_role();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = new Guid(row["id"].ToString());
                }
                if (row["rolename"] != null)
                {
                    model.rolename = row["rolename"].ToString();
                }
                if (row["beizhu"] != null)
                {
                    model.beizhu = row["beizhu"].ToString();
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
            strSql.Append("select id,rolename,beizhu,crdate ");
            strSql.Append(" FROM ui_role ");
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
            strSql.Append(" id,rolename,beizhu,crdate ");
            strSql.Append(" FROM ui_role ");
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
            strSql.Append("select count(1) FROM ui_role ");
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
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from ui_role T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }


        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YJUI.Model.ui_role m_role, List<Model.ui_role_menu> T_role_menu)
        {
            string guid = new Guid().ToString();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ui_role(");
            strSql.Append("id,rolename,beizhu,crdate)");
            strSql.Append(" values (");
            strSql.Append("@id,@rolename,@beizhu,@crdate)");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@rolename", SqlDbType.NVarChar,50),
					new SqlParameter("@beizhu", SqlDbType.NVarChar,100),
					new SqlParameter("@crdate", SqlDbType.DateTime)};
            parameters[0].Value = m_role.id;
            parameters[1].Value = m_role.rolename;
            parameters[2].Value = m_role.beizhu;
            parameters[3].Value = m_role.crdate;

            Hashtable SQLStringList = new Hashtable();

            SQLStringList.Add(strSql, parameters);
            foreach (Model.ui_role_menu m_role_menu in T_role_menu)
            {
                StringBuilder strSql1 = new StringBuilder();
                strSql1.Append("insert into ui_role_menu(");
                strSql1.Append("ui_role_id,ui_menu_id,crdate)");
                strSql1.Append(" values (");
                strSql1.Append("@ui_role_id,@ui_menu_id,@crdate)");
                strSql1.Append(";select @@IDENTITY");
                SqlParameter[] parameters1 = {
					new SqlParameter("@ui_role_id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@ui_menu_id", SqlDbType.Int,4),
					new SqlParameter("@crdate", SqlDbType.DateTime)};
                parameters1[0].Value = m_role_menu.ui_role_id;
                parameters1[1].Value = m_role_menu.ui_menu_id;
                parameters1[2].Value = m_role_menu.crdate;
                SQLStringList.Add(strSql1, parameters1);
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


        /// <summary>
        /// 通过用户id 获取该用户的角色集合
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable getRoleByUserid(object id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select r.id,r.rolename from  ui_user_role ur ");
            strSql.Append("left join ui_role r on r.id=ur.ui_role_id ");
            strSql.Append(" where ur.ui_user_id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = id;
            return DbHelperSQL.Query(strSql.ToString(), parameters).Tables[0];
        }

        /// <summary>
        /// 获取所有用户的权限
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
   

        public DataTable AllMenuAndRole(Guid id)
        {
            DataTable allDataTable = DbHelperSQL.Query("select * from ui_menu").Tables[0];
            DataTable roleTable = DbHelperSQL.Query("select * from ui_role_menu where ui_role_id='"+id+"'").Tables[0];
            allDataTable.Columns["fatherid"].ColumnName = "_parentId";
            allDataTable.Columns.Add("checkState");
            allDataTable.Columns.Add("checked");
            foreach (DataRow row in allDataTable.Rows)
            {
                //row["_parentId"] = row["fatherid"].ToString() == "0" ? "" : row["fatherid"].ToString();
                //row["_parentId"] = row["fatherid"].ToString();
                DataRow dr = roleTable.Select("ui_menu_id='" + row["id"] + "'").FirstOrDefault();
                if (dr == null)
                {
                    row["checkState"] = "";
                    row["checked"] = "";
                }
                else
                {
                    row["checkState"] = "true";
                    row["checked"] = "checked";
                }
            }





            return allDataTable;
        }



        #endregion  ExtensionMethod
    }
}

