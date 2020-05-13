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
    /// 数据访问类:ui_user
    /// </summary>
    public partial class ui_user
    {
        public ui_user()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ui_user");
            strSql.Append(" where ID=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistsUser(string account)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ui_user");
            strSql.Append(" where account=@account ");
            SqlParameter[] parameters = {
					new SqlParameter("@account", SqlDbType.NVarChar,30)			};
            parameters[0].Value = account;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YJUI.Model.ui_user model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ui_user(");
            strSql.Append("ID,account,password,xingming,sex,birth,sfz,tel,dizhi,email,qq,crdate)");
            strSql.Append(" values (");
            strSql.Append("@id,@account,@password,@xingming,@sex,@birth,@sfz,@tel,@dizhi,@email,@qq,@crdate)");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@account", SqlDbType.NVarChar,30),
					new SqlParameter("@password", SqlDbType.NVarChar,36),
					new SqlParameter("@xingming", SqlDbType.NVarChar,30),
					new SqlParameter("@sex", SqlDbType.NVarChar,1),
					new SqlParameter("@birth", SqlDbType.NVarChar,10),
					new SqlParameter("@sfz", SqlDbType.VarChar,20),
					new SqlParameter("@tel", SqlDbType.VarChar,15),
					new SqlParameter("@dizhi", SqlDbType.NVarChar,100),
					new SqlParameter("@email", SqlDbType.VarChar,50),
					new SqlParameter("@qq", SqlDbType.VarChar,15),
					new SqlParameter("@crdate", SqlDbType.DateTime)};
            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.account;
            parameters[2].Value = model.password;
            parameters[3].Value = model.xingming;
            parameters[4].Value = model.sex;
            parameters[5].Value = model.birth;
            parameters[6].Value = model.sfz;
            parameters[7].Value = model.tel;
            parameters[8].Value = model.dizhi;
            parameters[9].Value = model.email;
            parameters[10].Value = model.qq;
            parameters[11].Value = model.crdate;

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
        public bool Update(YJUI.Model.ui_user model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_user set ");
            strSql.Append("account=@account,");
            strSql.Append("password=@password,");
            strSql.Append("xingming=@xingming,");
            strSql.Append("sex=@sex,");
            strSql.Append("birth=@birth,");
            strSql.Append("sfz=@sfz,");
            strSql.Append("tel=@tel,");
            strSql.Append("dizhi=@dizhi,");
            strSql.Append("email=@email,");
            strSql.Append("qq=@qq ");
            // strSql.Append("crdate=@crdate");
            strSql.Append(" where ID=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@account", SqlDbType.NVarChar,30),
					new SqlParameter("@password", SqlDbType.NVarChar,36),
					new SqlParameter("@xingming", SqlDbType.NVarChar,30),
					new SqlParameter("@sex", SqlDbType.NVarChar,1),
					new SqlParameter("@birth", SqlDbType.NVarChar,10),
					new SqlParameter("@sfz", SqlDbType.VarChar,20),
					new SqlParameter("@tel", SqlDbType.VarChar,15),
					new SqlParameter("@dizhi", SqlDbType.NVarChar,100),
					new SqlParameter("@email", SqlDbType.VarChar,50),
					new SqlParameter("@qq", SqlDbType.VarChar,15),
				//	new SqlParameter("@crdate", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.UniqueIdentifier,16)};
            parameters[0].Value = model.account;
            parameters[1].Value = model.password;
            parameters[2].Value = model.xingming;
            parameters[3].Value = model.sex;
            parameters[4].Value = model.birth;
            parameters[5].Value = model.sfz;
            parameters[6].Value = model.tel;
            parameters[7].Value = model.dizhi;
            parameters[8].Value = model.email;
            parameters[9].Value = model.qq;
            //  parameters[10].Value = model.crdate;
            parameters[10].Value = model.id;

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
            strSql.Append("delete from ui_user ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.UniqueIdentifier,16)			};
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
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            strSql.Append("delete from ui_user ");
            strSql.Append(" where id in (" + idlist + ")  ");

            strSql1.Append("delete from ui_user_role ");
            strSql1.Append(" where ui_user_id in (" + idlist + ")  ");


            strSql2.Append("delete from ui_user_org ");
            strSql2.Append(" where ui_user_id in (" + idlist + ")  ");

            List<String> SQLStringList = new List<string>();
            SQLStringList.Add(strSql.ToString());
            SQLStringList.Add(strSql1.ToString());
            SQLStringList.Add(strSql2.ToString());

            int rows = DbHelperSQL.ExecuteSqlTran(SQLStringList);
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
        public YJUI.Model.ui_user GetModel(Guid id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,account,password,xingming,sex,birth,sfz,tel,dizhi,email,qq,crdate from ui_user ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = id;

            YJUI.Model.ui_user model = new YJUI.Model.ui_user();
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
        public YJUI.Model.ui_user DataRowToModel(DataRow row)
        {
            YJUI.Model.ui_user model = new YJUI.Model.ui_user();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.id = new Guid(row["ID"].ToString());
                }
                if (row["account"] != null)
                {
                    model.account = row["account"].ToString();
                }
                if (row["password"] != null)
                {
                    model.password = row["password"].ToString();
                }
                if (row["xingming"] != null)
                {
                    model.xingming = row["xingming"].ToString();
                }
                if (row["sex"] != null)
                {
                    model.sex = row["sex"].ToString();
                }
                if (row["depid"] != null)
                {
                    model.depid = row["depid"].ToString();
                }
                if (row["depname"] != null)
                {
                    model.depname = row["depname"].ToString();
                }
                if (row["pTeam"] != null)
                {
                    model.pTeam = row["pTeam"].ToString();
                }
                if (row["birth"] != null)
                {
                    model.birth = row["birth"].ToString();
                }
                if (row["sfz"] != null)
                {
                    model.sfz = row["sfz"].ToString();
                }
                if (row["tel"] != null)
                {
                    model.tel = row["tel"].ToString();
                }
                if (row["dizhi"] != null)
                {
                    model.dizhi = row["dizhi"].ToString();
                }
                if (row["email"] != null)
                {
                    model.email = row["email"].ToString();
                }
                if (row["qq"] != null)
                {
                    model.qq = row["qq"].ToString();
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
        public DataSet GetList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID, account ");
            strSql.Append(" FROM ui_user ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,account,password,xingming,sex,birth,sfz,tel,dizhi,email,qq,crdate ");
            strSql.Append(" FROM ui_user ");
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
            strSql.Append(" ID,account,password,xingming,sex,birth,sfz,tel,dizhi,email,qq,crdate ");
            strSql.Append(" FROM ui_user ");
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
            strSql.Append("select count(1) FROM ui_user ");
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
            strSql.Append(")AS Row, T.*  from ui_user T ");
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
        public bool Add(YJUI.Model.ui_user model, List<Model.ui_user_role> T_ui_role, List<Model.ui_user_org> T_ui_org)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ui_user(");
            strSql.Append("ID,account,password,xingming,sex,birth,sfz,tel,dizhi,email,qq,crdate)");
            strSql.Append(" values (");
            strSql.Append("@id,@account,@password,@xingming,@sex,@birth,@sfz,@tel,@dizhi,@email,@qq,@crdate)");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@account", SqlDbType.NVarChar,30),
					new SqlParameter("@password", SqlDbType.NVarChar,36),
					new SqlParameter("@xingming", SqlDbType.NVarChar,30),
					new SqlParameter("@sex", SqlDbType.NVarChar,1),
					new SqlParameter("@birth", SqlDbType.NVarChar,10),
					new SqlParameter("@sfz", SqlDbType.VarChar,20),
					new SqlParameter("@tel", SqlDbType.VarChar,15),
					new SqlParameter("@dizhi", SqlDbType.NVarChar,100),
					new SqlParameter("@email", SqlDbType.VarChar,50),
					new SqlParameter("@qq", SqlDbType.VarChar,15),
					new SqlParameter("@crdate", SqlDbType.DateTime)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.account;
            parameters[2].Value = model.password;
            parameters[3].Value = model.xingming;
            parameters[4].Value = model.sex;
            parameters[5].Value = model.birth;
            parameters[6].Value = model.sfz;
            parameters[7].Value = model.tel;
            parameters[8].Value = model.dizhi;
            parameters[9].Value = model.email;
            parameters[10].Value = model.qq;
            parameters[11].Value = model.crdate;

            Hashtable SQLStringList = new Hashtable();
            SQLStringList.Add(strSql, parameters);
            foreach (Model.ui_user_role model_user_role in T_ui_role)
            {
                StringBuilder strSql1 = new StringBuilder();
                strSql1.Append("insert into ui_user_role(");
                strSql1.Append("ui_user_id,ui_role_id,crdate)");
                strSql1.Append(" values (");
                strSql1.Append("@ui_user_id,@ui_role_id,@crdate)");
                strSql1.Append(";select @@IDENTITY");
                SqlParameter[] parameters1 = {
					new SqlParameter("@ui_user_id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@ui_role_id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@crdate", SqlDbType.DateTime)};
                parameters1[0].Value = model_user_role.ui_user_id;
                parameters1[1].Value = model_user_role.ui_role_id;
                parameters1[2].Value = model.crdate;
                SQLStringList.Add(strSql1, parameters1);
            }
            foreach (Model.ui_user_org model_user_org in T_ui_org)
            {
                StringBuilder strSql2 = new StringBuilder();
                strSql2.Append("insert into ui_user_org(");
                strSql2.Append("ui_user_id,ui_org_id,crdate)");
                strSql2.Append(" values (");
                strSql2.Append("@ui_user_id,@ui_org_id,@crdate)");
                strSql2.Append(";select @@IDENTITY");
                SqlParameter[] parameters2 = {
					new SqlParameter("@ui_user_id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@ui_org_id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@crdate", SqlDbType.DateTime)};
                parameters2[0].Value = model_user_org.ui_user_id;
                parameters2[1].Value = model_user_org.ui_org_id;
                parameters2[2].Value = model.crdate;
                SQLStringList.Add(strSql2, parameters2);


            }




            try
            {
                DbHelperSQL.ExecuteSqlTran(SQLStringList);
                return true;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataTable GetList(int PageSize, int PageIndex, string strWhere, string fldName, string strOrder)
        {
            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append(string.Format(" SELECT TOP {0} {1} FROM ui_user ", PageSize, fldName));
            sb.Append(string.Format("WHERE {0}  and (ID NOT IN", strWhere));
            sb.Append(string.Format(" (SELECT TOP {0} ID FROM ui_user where {1}", PageSize * (PageIndex - 1), strWhere));
            sb.Append(string.Format(" ORDER BY {0}))", strOrder));
            sb.Append(string.Format(" ORDER BY {0}", strOrder));
            return DbHelperSQL.Query(sb.ToString()).Tables[0];
        }

        public int getDataCount(string strWhere)
        {
            string sql = string.Format("select count(*) from  ui_user where {0}", strWhere);
            return Convert.ToInt32(DbHelperSQL.GetSingle(sql));
        }
        public bool setrole(string[] users, string[] roles)
        {
            List<string> sql = new List<string>();
            foreach (string user in users)
            {
                string sql_dele = string.Format("delete from  ui_user_role where ui_user_id='{0}'", user);
                sql.Add(sql_dele);
                foreach (string role in roles)
                {
                    if (!string.IsNullOrEmpty(role))
                    {
                        string sql_insert = string.Format("insert into ui_user_role(ui_user_id,ui_role_id,crdate) values('{0}','{1}','{2}')", user, role, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        sql.Add(sql_insert);
                    }

                }
            }
            if (DbHelperSQL.ExecuteSqlTran(sql) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool setorg(string[] users, string[] orgs)
        {
            List<string> sql = new List<string>();
            foreach (string user in users)
            {
                string sql_dele = string.Format("delete from  ui_user_org where ui_user_id='{0}'", user);
                sql.Add(sql_dele);
                foreach (string org in orgs)
                {
                    if (!string.IsNullOrEmpty(org))
                    {
                        string sql_insert = string.Format("insert into ui_user_org(ui_user_id,ui_org_id,crdate) values('{0}','{1}','{2}')", user, org, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        sql.Add(sql_insert);
                    }

                }
            }
            if (DbHelperSQL.ExecuteSqlTran(sql) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Model.ui_user Login(string acc, string pwd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,account,password,depid,depname,pTeam,xingming,sex,birth,sfz,tel,dizhi,email,qq,crdate from ui_user ");
            strSql.Append(" where account=@account and password=@password ");
            SqlParameter[] parameters = {
					new SqlParameter("@account", SqlDbType.NVarChar,30)	,
                    new SqlParameter("@password", SqlDbType.NVarChar,30)	
                                        };
            parameters[0].Value = acc;
            parameters[1].Value = pwd;
            YJUI.Model.ui_user model = new YJUI.Model.ui_user();
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

        #endregion  ExtensionMethod
    }
}

