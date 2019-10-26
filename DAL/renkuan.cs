using System;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Data.SqlClient;
using YJUI.DBUtility;

namespace YJUI.DAL
{
    /// <summary>
    /// 数据访问类:renkuan
    /// </summary>
    public partial class renkuan
    {
        public renkuan()
        { }
        #region  BasicMethod


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YJUI.Model.renkuan model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into renkuan(");
            strSql.Append("WDate,BankInfo,HFee,Hmoney,Customer)");
            strSql.Append(" values (");
            strSql.Append("@WDate,@BankInfo,@HFee,@Hmoney,@Customer)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@WDate", SqlDbType.DateTime),
					new SqlParameter("@BankInfo", SqlDbType.VarChar,200),
					new SqlParameter("@HFee", SqlDbType.VarChar,53),
					new SqlParameter("@Hmoney", SqlDbType.VarChar,53),
					new SqlParameter("@Customer", SqlDbType.VarChar,2000)};
            parameters[0].Value = model.WDate;
            parameters[1].Value = model.BankInfo;
            parameters[2].Value = model.HFee;
            parameters[3].Value = model.Hmoney;
            parameters[4].Value = model.Customer;
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
        public bool Update(YJUI.Model.renkuan model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update renkuan set ");
            strSql.Append("BankInfo=@BankInfo,");
            strSql.Append("HFee=@HFee,");
            strSql.Append("Hmoney=@Hmoney,");
            strSql.Append("Customer=@Customer");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@BankInfo", SqlDbType.VarChar,200),
					new SqlParameter("@HFee", SqlDbType.VarChar,53),
					new SqlParameter("@Hmoney", SqlDbType.VarChar,53),
					new SqlParameter("@Customer", SqlDbType.VarChar,2000),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.BankInfo;
            parameters[1].Value = model.HFee;
            parameters[2].Value = model.Hmoney;
            parameters[3].Value = model.Customer;
            parameters[4].Value = model.ID;
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
            strSql.Append("delete from renkuan ");
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
            strSql.Append("delete from renkuan ");
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
        public YJUI.Model.renkuan GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,WDate,BankInfo,TMode,HFee,Hmoney,CRemark,Customer,Employee,KRemark,State,QRemark,CustomerID,OrderID,SZJE,RKriqi,crdate,flag from renkuan ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            YJUI.Model.renkuan model = new YJUI.Model.renkuan();
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
        public YJUI.Model.renkuan DataRowToModel(DataRow row)
        {
            YJUI.Model.renkuan model = new YJUI.Model.renkuan();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["WDate"] != null && row["WDate"].ToString() != "")
                {
                    model.WDate = DateTime.Parse(row["WDate"].ToString());
                }
                if (row["BankInfo"] != null)
                {
                    model.BankInfo = row["BankInfo"].ToString();
                }
                if (row["TMode"] != null)
                {
                    model.TMode = row["TMode"].ToString();
                }
                if (row["HFee"] != null)
                {
                    model.HFee = row["HFee"].ToString();
                }
                if (row["Hmoney"] != null)
                {
                    model.Hmoney = row["Hmoney"].ToString();
                }
                if (row["CRemark"] != null)
                {
                    model.CRemark = row["CRemark"].ToString();
                }
                if (row["Customer"] != null)
                {
                    model.Customer = row["Customer"].ToString();
                }
                if (row["Employee"] != null)
                {
                    model.Employee = row["Employee"].ToString();
                }
                if (row["KRemark"] != null)
                {
                    model.KRemark = row["KRemark"].ToString();
                }
                if (row["State"] != null)
                {
                    model.State = row["State"].ToString();
                }
                if (row["QRemark"] != null)
                {
                    model.QRemark = row["QRemark"].ToString();
                }
                if (row["CustomerID"] != null)
                {
                    model.CustomerID = row["CustomerID"].ToString();
                }
                if (row["OrderID"] != null)
                {
                    model.OrderID = row["OrderID"].ToString();
                }
                if (row["SZJE"] != null)
                {
                    model.SZJE = row["SZJE"].ToString();
                }
                if (row["RKriqi"] != null)
                {
                    model.RKriqi = row["RKriqi"].ToString();
                }
                if (row["crdate"] != null && row["crdate"].ToString() != "")
                {
                    model.crdate = DateTime.Parse(row["crdate"].ToString());
                }
                if (row["flag"] != null)
                {
                    model.flag = row["flag"].ToString();
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
            strSql.Append("select ID,WDate,BankInfo,TMode,HFee,Hmoney,CRemark,Customer,Employee,KRemark,State,QRemark,CustomerID,OrderID,SZJE,RKriqi,crdate,flag ");
            strSql.Append(" FROM renkuan ");
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
            strSql.Append(" ID,WDate,BankInfo,TMode,HFee,Hmoney,CRemark,Customer,Employee,KRemark,State,QRemark,CustomerID,OrderID,SZJE,RKriqi,crdate,flag ");
            strSql.Append(" FROM renkuan ");
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
            strSql.Append("select count(1) FROM renkuan ");
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
            strSql.Append(")AS Row, T.*  from renkuan T ");
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
            parameters[0].Value = "renkuan";
            parameters[1].Value = "ID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod
        public DataTable GetList(int PageSize, int PageIndex, string strWhere, string fldName, string strOrder)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format(" SELECT TOP {0} {1} FROM renkuan ", PageSize, fldName));
            sb.Append(string.Format("WHERE {0}  and (ID NOT IN", strWhere));
            sb.Append(string.Format(" (SELECT TOP {0} ID FROM renkuan where {1}", PageSize * (PageIndex - 1), strWhere));
            sb.Append(string.Format(" ORDER BY {0}))", strOrder));
            sb.Append(string.Format(" ORDER BY {0}", strOrder));
            return DbHelperSQL.Query(sb.ToString()).Tables[0];
        }
        /// <summary>
        /// 存储过程带out参数的分页方式
        /// </summary>
        /// <param name="fieldlist"></param>
        /// <param name="tablename"></param>
        /// <param name="where"></param>
        /// <param name="orderfield"></param>
        /// <param name="key"></param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <param name="recordcount"></param>
        /// <returns></returns>
        public DataTable GetPageList(string fieldlist, string tablename, string where, string orderfield, string key, int pageindex, int pagesize, out string recordcount)
        {
            SqlParameter[] parameters=new SqlParameter[]
            {
                new SqlParameter("@tbname",tablename),
                new SqlParameter("@FieldKey",key),
                new SqlParameter("@WhereString",where),
                new SqlParameter("@PageSize",pagesize),
                new SqlParameter("@PageCurrent",pageindex),
                new SqlParameter("@FieldShow",fieldlist),
                new SqlParameter("@FieldOrder",orderfield),
                new SqlParameter("@RecordCount",SqlDbType.VarChar,50)   
            };
            parameters[7].Direction = ParameterDirection.Output;
            DataTable dt= DbHelperSQL.RunProcedure("zhaolei_fenye", parameters,"table").Tables[0];
            recordcount = (string)parameters[7].Value;
            return dt;
        }

        public int getDataCount(string strWhere)
        {
            string sql = string.Format("select count(*) from  renkuan where {0}", strWhere);
            return Convert.ToInt32(DbHelperSQL.GetSingle(sql));
        }



        #endregion  ExtensionMethod
    }
}

