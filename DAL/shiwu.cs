using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using YJUI.DBUtility;

//Please add references
namespace YJUI.DAL
{
    /// <summary>
    /// 数据访问类:shiwu
    /// </summary>
    public partial class shiwu
    {
        public shiwu()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from shiwu");
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
        public bool Add(YJUI.Model.shiwu model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into shiwu(");
            strSql.Append("fkDate,fkPerson,supportDep,fkDesc)");
            strSql.Append(" values (");
            strSql.Append("@fkDate,@fkPerson,@supportDep,@fkDesc)");
            SqlParameter[] parameters = {
					new SqlParameter("@fkDate", SqlDbType.DateTime),
					new SqlParameter("@fkPerson", SqlDbType.VarChar,50),
					new SqlParameter("@supportDep", SqlDbType.VarChar,50),
					new SqlParameter("@fkDesc", SqlDbType.Text)
				};
            parameters[0].Value = model.fkDate;
            parameters[1].Value = model.fkPerson;
            parameters[2].Value = model.supportDep;
            parameters[3].Value = model.fkDesc;
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
        public bool Update(YJUI.Model.shiwu model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update shiwu set ");
            strSql.Append("fkDate=@fkDate,");
            strSql.Append("fkPerson=@fkPerson,");
            strSql.Append("supportDep=@supportDep,");
            strSql.Append("fkDesc=@fkDesc,");
            strSql.Append("receiveDep=@receiveDep,");
            strSql.Append("receivePerson=@receivePerson,");
            strSql.Append("receiveDate=@receiveDate,");
            strSql.Append("tempGaishan=@tempGaishan,");
            strSql.Append("cqFangan=@cqFangan,");
            strSql.Append("cqDate=@cqDate,");
            strSql.Append("endDesc=@endDesc,");
            strSql.Append("endDate=@endDate,");
            strSql.Append("lsResult=@lsResult,");
            strSql.Append("lsDep=@lsDep,");
            strSql.Append("lsDate=@lsDate,");
            strSql.Append("myPingjia=@myPingjia,");
            strSql.Append("myPerson=@myPerson,");
            strSql.Append("myDate=@myDate,");
            strSql.Append("dsJianhe=@dsJianhe,");
            strSql.Append("dsPerson=@dsPerson,");
            strSql.Append("dsDate=@dsDate");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@fkDate", SqlDbType.DateTime),
					new SqlParameter("@fkPerson", SqlDbType.VarChar,50),
					new SqlParameter("@supportDep", SqlDbType.VarChar,50),
					new SqlParameter("@fkDesc", SqlDbType.Text),
					new SqlParameter("@receiveDep", SqlDbType.VarChar,50),
					new SqlParameter("@receivePerson", SqlDbType.VarChar,50),
					new SqlParameter("@receiveDate", SqlDbType.DateTime),
					new SqlParameter("@tempGaishan", SqlDbType.NVarChar,200),
					new SqlParameter("@cqFangan", SqlDbType.NVarChar,200),
					new SqlParameter("@cqDate", SqlDbType.DateTime),
					new SqlParameter("@endDesc", SqlDbType.Text),
					new SqlParameter("@endDate", SqlDbType.VarChar,50),
					new SqlParameter("@lsResult", SqlDbType.VarChar,100),
					new SqlParameter("@lsDep", SqlDbType.Char,10),
					new SqlParameter("@lsDate", SqlDbType.DateTime),
					new SqlParameter("@myPingjia", SqlDbType.VarChar,50),
					new SqlParameter("@myPerson", SqlDbType.VarChar,50),
					new SqlParameter("@myDate", SqlDbType.DateTime),
					new SqlParameter("@dsJianhe", SqlDbType.VarChar,50),
					new SqlParameter("@dsPerson", SqlDbType.VarChar,50),
					new SqlParameter("@dsDate", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.fkDate;
            parameters[1].Value = model.fkPerson;
            parameters[2].Value = model.supportDep;
            parameters[3].Value = model.fkDesc;
            parameters[4].Value = model.receiveDep;
            parameters[5].Value = model.receivePerson;
            parameters[6].Value = model.receiveDate;
            parameters[7].Value = model.tempGaishan;
            parameters[8].Value = model.cqFangan;
            parameters[9].Value = model.cqDate;
            parameters[10].Value = model.endDesc;
            parameters[11].Value = model.endDate;
            parameters[12].Value = model.lsResult;
            parameters[13].Value = model.lsDep;
            parameters[14].Value = model.lsDate;
            parameters[15].Value = model.myPingjia;
            parameters[16].Value = model.myPerson;
            parameters[17].Value = model.myDate;
            parameters[18].Value = model.dsJianhe;
            parameters[19].Value = model.dsPerson;
            parameters[20].Value = model.dsDate;
            parameters[21].Value = model.ID;

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
        /// 问题处理
        /// </summary>
        public bool Chuli(YJUI.Model.shiwu model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update shiwu set ");
            strSql.Append("receiveDep=@receiveDep,");
            strSql.Append("receivePerson=@receivePerson,");
            strSql.Append("receiveDate=@receiveDate,");
            strSql.Append("tempGaishan=@tempGaishan,");
            strSql.Append("cqFangan=@cqFangan,");
            strSql.Append("cqDate=@cqDate,");
            strSql.Append("endDate=@endDate ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@receiveDep", SqlDbType.VarChar,50),
					new SqlParameter("@receivePerson", SqlDbType.VarChar,50),
					new SqlParameter("@receiveDate", SqlDbType.DateTime),
					new SqlParameter("@tempGaishan", SqlDbType.NVarChar,200),
					new SqlParameter("@cqFangan", SqlDbType.NVarChar,200),
					new SqlParameter("@cqDate", SqlDbType.DateTime),
					new SqlParameter("@endDate", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
        
            parameters[0].Value = model.receiveDep;
            parameters[1].Value = model.receivePerson;
            parameters[2].Value = model.receiveDate;
            parameters[3].Value = model.tempGaishan;
            parameters[4].Value = model.cqFangan;
            parameters[5].Value = model.cqDate;
            parameters[6].Value = model.ID;
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
        /// 领导检核
        /// </summary>
        public bool Jianhe(YJUI.Model.shiwu model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update shiwu set ");
          
            strSql.Append("lsResult=@lsResult,");
            strSql.Append("lsDep=@lsDep,");
            strSql.Append("lsDate=@lsDate");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					
					new SqlParameter("@lsResult", SqlDbType.VarChar,100),
					new SqlParameter("@lsDep", SqlDbType.Char,10),
					new SqlParameter("@lsDate", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
          
            parameters[0].Value = model.lsResult;
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
        public bool DiSanFang(YJUI.Model.shiwu model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update shiwu set ");
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
        /// 满意评价操作
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool PingJia(YJUI.Model.shiwu model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update shiwu set ");
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
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shiwu ");
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
            strSql.Append("delete from shiwu ");
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
        public YJUI.Model.shiwu GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,fkDate,fkPerson,supportDep,fkDesc,receiveDep,receivePerson,receiveDate,tempGaishan,cqFangan,cqDate,endDesc,endDate,lsResult,lsDep,lsDate,myPingjia,myPerson,myDate,dsJianhe,dsPerson,dsDate from shiwu ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            YJUI.Model.shiwu model = new YJUI.Model.shiwu();
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
        public YJUI.Model.shiwu DataRowToModel(DataRow row)
        {
            YJUI.Model.shiwu model = new YJUI.Model.shiwu();
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
                if (row["supportDep"] != null)
                {
                    model.supportDep = row["supportDep"].ToString();
                }
                if (row["fkDesc"] != null)
                {
                    model.fkDesc = row["fkDesc"].ToString();
                }
                if (row["receiveDep"] != null)
                {
                    model.receiveDep = row["receiveDep"].ToString();
                }
                if (row["receivePerson"] != null)
                {
                    model.receivePerson = row["receivePerson"].ToString();
                }
                if (row["receiveDate"] != null && row["receiveDate"].ToString() != "")
                {
                    model.receiveDate = DateTime.Parse(row["receiveDate"].ToString());
                }
                if (row["tempGaishan"] != null)
                {
                    model.tempGaishan = row["tempGaishan"].ToString();
                }
                if (row["cqFangan"] != null)
                {
                    model.cqFangan = row["cqFangan"].ToString();
                }
                if (row["cqDate"] != null && row["cqDate"].ToString() != "")
                {
                    model.cqDate = DateTime.Parse(row["cqDate"].ToString());
                }
                if (row["endDesc"] != null)
                {
                    model.endDesc = row["endDesc"].ToString();
                }
                if (row["endDate"] != null)
                {
                    model.endDate = row["endDate"].ToString();
                }
                if (row["lsResult"] != null)
                {
                    model.lsResult = row["lsResult"].ToString();
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
            strSql.Append("select ID,fkDate,fkPerson,supportDep,fkDesc,receiveDep,receivePerson,receiveDate,tempGaishan,cqFangan,cqDate,endDesc,endDate,lsResult,lsDep,lsDate,myPingjia,myPerson,myDate,dsJianhe,dsPerson,dsDate ");
            strSql.Append(" FROM shiwu ");
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
            strSql.Append(" ID,fkDate,fkPerson,supportDep,fkDesc,receiveDep,receivePerson,receiveDate,tempGaishan,cqFangan,cqDate,endDesc,endDate,lsResult,lsDep,lsDate,myPingjia,myPerson,myDate,dsJianhe,dsPerson,dsDate ");
            strSql.Append(" FROM shiwu ");
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
            strSql.Append("select count(1) FROM shiwu ");
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
            strSql.Append(")AS Row, T.*  from shiwu T ");
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
        #endregion  ExtensionMethod
    }
}

