using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using YJUI.DBUtility;//Please add references
namespace YJUI.DAL
{
    /// <summary>
    /// 数据访问类:ui_org
    /// </summary>
    public partial class ui_org
    {
        public ui_org()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ui_org");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YJUI.Model.ui_org model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ui_org(");
            strSql.Append("id,fatherid,orgcode,orgname,icon,attr_a,attr_b,crdate)");
            strSql.Append(" values (");
            strSql.Append("@id,@fatherid,@orgcode,@orgname,@icon,@attr_a,@attr_b,@crdate)");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@fatherid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@orgcode", SqlDbType.NVarChar,30),
					new SqlParameter("@orgname", SqlDbType.NVarChar,50),
					new SqlParameter("@icon", SqlDbType.VarChar,20),
					new SqlParameter("@attr_a", SqlDbType.NVarChar,30),
					new SqlParameter("@attr_b", SqlDbType.NVarChar,30),
					new SqlParameter("@crdate", SqlDbType.DateTime)};
            parameters[0].Value = Guid.NewGuid();
            if (model.fatherid != new Guid())
            {
                parameters[1].Value = model.fatherid;
            }
            else
            {
                parameters[1].Value = DBNull.Value;

            }
            // == new Guid() ? DBNull.Value : model.fatherid;

            parameters[2].Value = model.orgcode;
            parameters[3].Value = model.orgname;
            parameters[4].Value = model.icon;
            parameters[5].Value = model.attr_a;
            parameters[6].Value = model.attr_b;
            parameters[7].Value = model.crdate;

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
        public bool Update(YJUI.Model.ui_org model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_org set ");
            strSql.Append("fatherid=@fatherid,");
            strSql.Append("orgcode=@orgcode,");
            strSql.Append("orgname=@orgname,");
            strSql.Append("icon=@icon,");
            strSql.Append("attr_a=@attr_a,");
            strSql.Append("attr_b=@attr_b ");
            //  strSql.Append("crdate=@crdate");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@fatherid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@orgcode", SqlDbType.NVarChar,30),
					new SqlParameter("@orgname", SqlDbType.NVarChar,50),
					new SqlParameter("@icon", SqlDbType.VarChar,20),
					new SqlParameter("@attr_a", SqlDbType.NVarChar,30),
					new SqlParameter("@attr_b", SqlDbType.NVarChar,30),
					//new SqlParameter("@crdate", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.UniqueIdentifier,16)};
            if (model.fatherid != new Guid())
            {
                parameters[0].Value = model.fatherid;
            }
            else
            {
                parameters[0].Value = DBNull.Value;

            }
            parameters[1].Value = model.orgcode;
            parameters[2].Value = model.orgname;
            parameters[3].Value = model.icon;
            parameters[4].Value = model.attr_a;
            parameters[5].Value = model.attr_b;
            //  parameters[6].Value = model.crdate;
            parameters[6].Value = model.id;

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
            strSql.Append("delete from ui_org ");
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
            strSql.Append("delete from ui_org ");
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
        public YJUI.Model.ui_org GetModel(Guid id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,fatherid,orgcode,orgname,icon,attr_a,attr_b,crdate from ui_org ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = id;

            YJUI.Model.ui_org model = new YJUI.Model.ui_org();
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
        public YJUI.Model.ui_org DataRowToModel(DataRow row)
        {
            YJUI.Model.ui_org model = new YJUI.Model.ui_org();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = new Guid(row["id"].ToString());
                }
                if (row["fatherid"] != null && row["fatherid"].ToString() != "")
                {
                    model.fatherid = new Guid(row["fatherid"].ToString());
                }
                if (row["orgcode"] != null)
                {
                    model.orgcode = row["orgcode"].ToString();
                }
                if (row["orgname"] != null)
                {
                    model.orgname = row["orgname"].ToString();
                }
                if (row["icon"] != null)
                {
                    model.icon = row["icon"].ToString();
                }
                if (row["attr_a"] != null)
                {
                    model.attr_a = row["attr_a"].ToString();
                }
                if (row["attr_b"] != null)
                {
                    model.attr_b = row["attr_b"].ToString();
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
            strSql.Append("select id,fatherid,orgcode,orgname,icon,attr_a,attr_b,crdate ");
            strSql.Append(" FROM ui_org ");
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
            strSql.Append(" id,fatherid,orgcode,orgname,icon,attr_a,attr_b,crdate ");
            strSql.Append(" FROM ui_org ");
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
            strSql.Append("select count(1) FROM ui_org ");
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
            strSql.Append(")AS Row, T.*  from ui_org T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "ui_org";
            parameters[1].Value = "id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 通过用户id 获取该用户的组织集合
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable getOrgByUserid(object id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select r.id,r.orgname from  ui_user_org ur ");
            strSql.Append("left join ui_org r on r.id=ur.ui_org_id ");
            strSql.Append(" where ur.ui_user_id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = id;
            return DbHelperSQL.Query(strSql.ToString(), parameters).Tables[0];
        }
        #endregion  ExtensionMethod
    }
}

