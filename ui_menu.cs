﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using YJUI.DBUtility;//Please add references
namespace YJUI.DAL
{
    /// <summary>
    /// 数据访问类:ui_menu
    /// </summary>
    public partial class ui_menu
    {
        public ui_menu()
        { }
        #region  BasicMethod


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(YJUI.Model.ui_menu model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ui_menu(");
            strSql.Append("menuorder,fatherid,menuname,icon,url,crdate)");
            strSql.Append(" values (");
            strSql.Append("@menuorder,@fatherid,@menuname,@icon,@url,@crdate)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@menuorder", SqlDbType.Int,4),
					new SqlParameter("@fatherid", SqlDbType.Int,4),
					new SqlParameter("@menuname", SqlDbType.NVarChar,50),
					new SqlParameter("@icon", SqlDbType.NVarChar,50),
					new SqlParameter("@url", SqlDbType.NVarChar,200),
					new SqlParameter("@crdate", SqlDbType.DateTime)};
            parameters[0].Value = model.menuorder;
            parameters[1].Value = model.fatherid;
            parameters[2].Value = model.menuname;
            parameters[3].Value = model.icon;
            parameters[4].Value = model.url;
            parameters[5].Value = model.crdate;

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
        public bool Update(YJUI.Model.ui_menu model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_menu set ");
            strSql.Append("menuorder=@menuorder,");
            strSql.Append("fatherid=@fatherid,");
            strSql.Append("menuname=@menuname,");
            strSql.Append("icon=@icon,");
            strSql.Append("url=@url,");
            strSql.Append("crdate=@crdate");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@menuorder", SqlDbType.Int,4),
					new SqlParameter("@fatherid", SqlDbType.Int,4),
					new SqlParameter("@menuname", SqlDbType.NVarChar,50),
					new SqlParameter("@icon", SqlDbType.NVarChar,50),
					new SqlParameter("@url", SqlDbType.NVarChar,200),
					new SqlParameter("@crdate", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = model.menuorder;
            parameters[1].Value = model.fatherid;
            parameters[2].Value = model.menuname;
            parameters[3].Value = model.icon;
            parameters[4].Value = model.url;
            parameters[5].Value = model.crdate;
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
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ui_menu ");
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
            strSql.Append("delete from ui_menu ");
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
        public YJUI.Model.ui_menu GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,menuorder,fatherid,menuname,icon,url,crdate from ui_menu ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            YJUI.Model.ui_menu model = new YJUI.Model.ui_menu();
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
        public YJUI.Model.ui_menu DataRowToModel(DataRow row)
        {
            YJUI.Model.ui_menu model = new YJUI.Model.ui_menu();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["menuorder"] != null && row["menuorder"].ToString() != "")
                {
                    model.menuorder = int.Parse(row["menuorder"].ToString());
                }
                if (row["fatherid"] != null && row["fatherid"].ToString() != "")
                {
                    model.fatherid = int.Parse(row["fatherid"].ToString());
                }
                if (row["menuname"] != null)
                {
                    model.menuname = row["menuname"].ToString();
                }
                if (row["icon"] != null)
                {
                    model.icon = row["icon"].ToString();
                }
                if (row["url"] != null)
                {
                    model.url = row["url"].ToString();
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
            strSql.Append("select id,menuorder,fatherid,menuname,icon,url,crdate ");
            strSql.Append(" FROM ui_menu ");
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
            strSql.Append(" id,menuorder,fatherid,menuname,icon,url,crdate ");
            strSql.Append(" FROM ui_menu ");
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
            strSql.Append("select count(1) FROM ui_menu ");
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
            strSql.Append(")AS Row, T.*  from ui_menu T ");
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
            parameters[0].Value = "ui_menu";
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

        #endregion  ExtensionMethod
    }
}

