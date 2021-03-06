﻿using System;
using System.Data;
using System.Net.Sockets;
using System.Text;
using System.Data.SqlClient;
using YJUI.DBUtility;//Please add references
namespace YJUI.DAL
{
    /// <summary>
    /// 数据访问类:neibutaizhang
    /// </summary>
    public partial class neibutaizhang
    {
        public neibutaizhang()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from neibutaizhang");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YJUI.Model.neibutaizhang model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into neibutaizhang(");
            strSql.Append("fkDate,fkPerson,fkDep,wtDep,fkDesc,fkItem,fkArea,fkCustomer,fkPic,DepCat)");
            strSql.Append(" values (");
            strSql.Append("@fkDate,@fkPerson,@fkDep,@wtDep,@fkDesc,@fkItem,@fkArea,@fkCustomer,@fkPic,@DepCat)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@fkDate", SqlDbType.DateTime),
					new SqlParameter("@fkPerson", SqlDbType.VarChar,50),
                    new SqlParameter("@fkDep", SqlDbType.VarChar,50),
                    new SqlParameter("@wtDep", SqlDbType.VarChar,50),
					new SqlParameter("@fkDesc", SqlDbType.Text),
                    new SqlParameter("@fkItem", SqlDbType.VarChar,50),
                     new SqlParameter("@fkArea", SqlDbType.VarChar,200),
                      new SqlParameter("@fkCustomer", SqlDbType.VarChar,200),
                      new SqlParameter("@fkPic", SqlDbType.VarChar,200),
                       new SqlParameter("@DepCat", SqlDbType.VarChar,200),
            };
            parameters[0].Value = model.fkDate;
            parameters[1].Value = model.fkPerson;
            parameters[2].Value = model.FkDep;
            parameters[3].Value = model.wtDep;
            parameters[4].Value = model.fkDesc;
            parameters[5].Value = model.fkItem;
            parameters[6].Value = model.fkArea;
            parameters[7].Value = model.fkCustomer;
            parameters[8].Value = model.FkPic;
            parameters[9].Value = model.DepCat;
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
        public bool Update(YJUI.Model.neibutaizhang model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update neibutaizhang set ");
            strSql.Append("dyDep=@dyDep,");
            strSql.Append("dyPerson=@dyPerson,");
            strSql.Append("dyDate=@dyDate,");
            strSql.Append("dyGaishan=@dyGaishan,");
            strSql.Append("cqFangan=@cqFangan,");
            strSql.Append("IsEnd=@IsEnd,");
            strSql.Append("cqDate=@cqDate");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@dyDep", SqlDbType.VarChar,50),
					new SqlParameter("@dyPerson", SqlDbType.VarChar,50),
					new SqlParameter("@dyDate", SqlDbType.DateTime),
					new SqlParameter("@dyGaishan", SqlDbType.NVarChar,200),
					new SqlParameter("@cqFangan", SqlDbType.NVarChar,200),
                    new SqlParameter("@IsEnd", SqlDbType.NVarChar,50),
                    new SqlParameter("@cqDate", SqlDbType.DateTime),
                    new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.dyDep;
            parameters[1].Value = model.dyPerson;
            parameters[2].Value = model.dyDate;
            parameters[3].Value = model.dyGaishan;
            parameters[4].Value = model.cqFangan;
            parameters[5].Value = model.IsEnd;
            parameters[6].Value = model.cqDate;
            parameters[7].Value = model.ID;
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
        /// 落实检核
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>

        public bool Update_luoshijianhe(YJUI.Model.neibutaizhang model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update neibutaizhang set ");
            strSql.Append("lsJianhe=@lsJianhe,");
            strSql.Append("lsDep=@lsDep,");
            strSql.Append("lsDate=@lsDate");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@lsJianhe", SqlDbType.Text),
					new SqlParameter("@lsDep", SqlDbType.VarChar,50),
					new SqlParameter("@lsDate", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.lsJianhe;
            parameters[1].Value = model.lsDep;
            parameters[2].Value = model.lsDate;
            parameters[3].Value = model.ID;
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
        /// 满意度调查
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>

        public bool Update_manyidudiaocha(YJUI.Model.neibutaizhang model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update neibutaizhang set ");
            strSql.Append("myPingjia=@myPingjia,");
            strSql.Append("myPerson=@myPerson,");
            strSql.Append("myDate=@myDate");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@myPingjia", SqlDbType.VarChar,50),
					new SqlParameter("@myPerson", SqlDbType.VarChar,50),
					new SqlParameter("@myDate", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.myPingjia;
            parameters[1].Value = model.myPerson;
            parameters[2].Value = model.myDate;
            parameters[3].Value = model.ID;
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
        /// 第三方检核
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>

        public bool Update_disanfangjianhe(YJUI.Model.neibutaizhang model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update neibutaizhang set ");
            strSql.Append("dsJianhe=@dsJianhe,");
            strSql.Append("dsPerson=@dsPerson,");
            strSql.Append("dsDate=@dsDate");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@dsJianhe", SqlDbType.VarChar,50),
					new SqlParameter("@dsPerson", SqlDbType.VarChar,50),
					new SqlParameter("@dsDate", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.dsJianhe;
            parameters[1].Value = model.dsPerson;
            parameters[2].Value = model.dsDate;
            parameters[3].Value = model.ID;
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
        public bool Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from neibutaizhang ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

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
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from neibutaizhang ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
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
        public YJUI.Model.neibutaizhang GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,fkDate,fkPerson,wtDep,fkDesc,dyDep,dyPerson,dyDate,dyGaishan,cqFangan,cqDate,lsJianhe,lsDep,lsDate,myPingjia,myPerson,myDate,dsJianhe,dsPerson,dsDate from neibutaizhang ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            YJUI.Model.neibutaizhang model = new YJUI.Model.neibutaizhang();
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
        public YJUI.Model.neibutaizhang DataRowToModel(DataRow row)
        {
            YJUI.Model.neibutaizhang model = new YJUI.Model.neibutaizhang();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["fkDate"] != null && row["fkDate"].ToString() != "")
                {
                    model.fkDate = DateTime.Parse(row["fkDate"].ToString());
                }
                if (row["fkPerson"] != null)
                {
                    model.fkPerson = row["fkPerson"].ToString();
                }
                if (row["wtDep"] != null)
                {
                    model.wtDep = row["wtDep"].ToString();
                }
                if (row["fkDesc"] != null)
                {
                    model.fkDesc = row["fkDesc"].ToString();
                }
                if (row["dyDep"] != null)
                {
                    model.dyDep = row["dyDep"].ToString();
                }
                if (row["dyPerson"] != null)
                {
                    model.dyPerson = row["dyPerson"].ToString();
                }
                if (row["dyDate"] != null && row["dyDate"].ToString() != "")
                {
                    model.dyDate = DateTime.Parse(row["dyDate"].ToString());
                }
                if (row["dyGaishan"] != null)
                {
                    model.dyGaishan = row["dyGaishan"].ToString();
                }
                if (row["cqFangan"] != null)
                {
                    model.cqFangan = row["cqFangan"].ToString();
                }
                if (row["cqDate"] != null && row["cqDate"].ToString() != "")
                {
                    model.cqDate = DateTime.Parse(row["cqDate"].ToString());
                }
                if (row["lsJianhe"] != null)
                {
                    model.lsJianhe = row["lsJianhe"].ToString();
                }
                if (row["lsDep"] != null)
                {
                    model.lsDep = row["lsDep"].ToString();
                }
                if (row["lsDate"] != null && row["lsDate"].ToString() != "")
                {
                    model.lsDate = DateTime.Parse(row["lsDate"].ToString());
                }
                if (row["myPingjia"] != null)
                {
                    model.myPingjia = row["myPingjia"].ToString();
                }
                if (row["myPerson"] != null)
                {
                    model.myPerson = row["myPerson"].ToString();
                }
                if (row["myDate"] != null && row["myDate"].ToString() != "")
                {
                    model.myDate = DateTime.Parse(row["myDate"].ToString());
                }
                if (row["dsJianhe"] != null)
                {
                    model.dsJianhe = row["dsJianhe"].ToString();
                }
                if (row["dsPerson"] != null)
                {
                    model.dsPerson = row["dsPerson"].ToString();
                }
                if (row["dsDate"] != null && row["dsDate"].ToString() != "")
                {
                    model.dsDate = DateTime.Parse(row["dsDate"].ToString());
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
            strSql.Append("select ID,fkDate,fkPerson,wtDep,fkDesc,dyDep,dyPerson,dyDate,dyGaishan,cqFangan,cqDate,lsJianhe,lsDep,lsDate,myPingjia,myPerson,myDate,dsJianhe,dsPerson,dsDate ");
            strSql.Append(" FROM neibutaizhang ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public IDataReader neiBuTaiZhangGetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,fkDate,fkPerson,fkDep,fkItem,fkArea,fkCustomer,wtDep,fkDesc,dyDep,dyPerson,dyDate,dyGaishan,cqFangan,cqDate,lsJianhe,lsDep,lsDate,myPingjia,myPerson,myDate,dsJianhe,dsPerson,dsDate ");
            strSql.Append("  FROM neibutaizhang ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.ExecuteReader(strSql.ToString());
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
            strSql.Append(" ID,fkDate,fkPerson,wtDep,fkDesc,dyDep,dyPerson,dyDate,dyGaishan,cqFangan,cqDate,lsJianhe,lsDep,lsDate,myPingjia,myPerson,myDate,dsJianhe,dsPerson,dsDate ");
            strSql.Append(" FROM neibutaizhang ");
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
            strSql.Append("select count(1) FROM neibutaizhang ");
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
                strSql.Append("order by T.ID desc");
            }
            strSql.Append(")AS Row, T.*  from neibutaizhang T ");
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

        public DataTable GetList(int PageSize,int PageIndex,string strWhere,string fldName,string strOrder)
        {
            System.Text.StringBuilder sb=new StringBuilder();
            sb.Append(string.Format("select top {0} {1}  from  neibutaizhang",PageSize,fldName));
            sb.Append(" where ( ID not in");
            //sb.Append(string.Format("WHERE {0}  and (ID NOT IN", strWhere));
            sb.Append(string.Format("(select top {0} ID  from neibutaizhang  where {1}",PageSize*(PageIndex-1),strWhere));
            sb.Append(string.Format(" order By {0}))", strOrder));
            sb.Append(string.Format(" order by {0}",strOrder));
            return DbHelperSQL.Query(sb.ToString()).Tables[0];
        }

        /// <summary>
        /// 查询分页
        /// </summary>
        /// <param name="tblName"></param>
        /// <param name="fldName"></param>
        /// <param name="pageSize"></param>
        /// <param name="page"></param>
        /// <param name="fldSort"></param>
        /// <param name="Sort"></param>
        /// <param name="strCondition"></param>
        /// <param name="ID"></param>
        /// <param name="Dist"></param>
        /// <param name="pageCount"></param>
        /// <param name="Counts"></param>
        /// <returns></returns>
        public DataTable GetList(string tblName, string fldName, int pageSize, int page, string fldSort, string Sort, string strCondition, string ID, string Dist, out int pageCount, out int Counts)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@tblName",SqlDbType.NVarChar), 
                new SqlParameter("@fldName",SqlDbType.NVarChar),
                new SqlParameter("@pageSize",SqlDbType.Int),
                new SqlParameter("@page",SqlDbType.Int),
                new SqlParameter("@fldSort",SqlDbType.NVarChar),
                new SqlParameter("@Sort",SqlDbType.NVarChar),
                new SqlParameter("@strCondition",SqlDbType.NVarChar),
                new SqlParameter("@ID",SqlDbType.NVarChar),
                new SqlParameter("@Dist",SqlDbType.NVarChar),
                new SqlParameter("@pageCount",SqlDbType.Int), 
                new SqlParameter("@Counts",SqlDbType.Int)
            };
            parameters[0].Value = tblName;
            parameters[1].Value = fldName;
            parameters[2].Value = pageSize;
            parameters[3].Value = page;
            parameters[4].Value = fldSort;
            parameters[5].Value = Sort;
            parameters[6].Value = strCondition;
            parameters[7].Value = ID;
            parameters[8].Value = Dist;
            parameters[9].Direction = ParameterDirection.Output;
            parameters[10].Direction = ParameterDirection.Output;
            DataTable table = DbHelperSQL.RunProcedure("zhao_fenye", parameters, "table").Tables[0];
            pageCount = int.Parse(parameters[9].Value.ToString());
            Counts = int.Parse(parameters[10].Value.ToString());
            return table;
        }

        public int getDataCount(string strWhere)
        {
            string sql = string.Format("select count(ID) from neibutaizhang where {0} ", strWhere);
            return Convert.ToInt32(DbHelperSQL.GetSingle(sql));
        }


        #endregion  ExtensionMethod
    }
}

