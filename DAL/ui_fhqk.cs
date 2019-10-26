using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using YJUI.DBUtility;
namespace YJUI.DAL
{
    /// <summary>
    /// 数据访问类:ui_fhqk
    /// </summary>
    public partial class ui_fhqk
    {
        public ui_fhqk()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ui_fhqk");
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
        public int Add(YJUI.Model.ui_fhqk model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ui_fhqk(");
            strSql.Append("djmc,xhdh,khqc,zsl,xhje,fhck,sfdc,sfdb,sffc,fcsj,sfjd)");
            strSql.Append(" values (");
            strSql.Append("@djmc,@xhdh,@khqc,@zsl,@xhje,@fhck,@sfdc,@sfdb,@sffc,@fcsj,@sfjd)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@djmc", SqlDbType.Char,10),
					new SqlParameter("@xhdh", SqlDbType.Char,11),
					new SqlParameter("@khqc", SqlDbType.Char,72),
					new SqlParameter("@zsl", SqlDbType.Decimal,9),
					new SqlParameter("@xhje", SqlDbType.Decimal,9),
					new SqlParameter("@fhck", SqlDbType.Char,10),
					new SqlParameter("@sfdc", SqlDbType.Char,10),
					new SqlParameter("@sfdb", SqlDbType.Char,10),
					new SqlParameter("@sffc", SqlDbType.Char,10),
					new SqlParameter("@fcsj", SqlDbType.DateTime),
					new SqlParameter("@sfjd", SqlDbType.Char,10)};
            parameters[0].Value = model.djmc;
            parameters[1].Value = model.xhdh;
            parameters[2].Value = model.khqc;
            parameters[3].Value = model.zsl;
            parameters[4].Value = model.xhje;
            parameters[5].Value = model.fhck;
            parameters[6].Value = model.sfdc;
            parameters[7].Value = model.dcsj;
            parameters[8].Value = model.sffc;
            parameters[9].Value = model.fcsj;
            parameters[10].Value = model.sfjd;

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
        public bool Update_sfdc(YJUI.Model.ui_fhqk model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_fhqk set ");
            strSql.Append("sfdc=@sfdc,");//是否点出
            strSql.Append("dcsj=@dcsj,");//点出时间
            strSql.Append("sfjd=@sfjd,");//是否急单
            strSql.Append("beizhu=@beizhu");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@sfdc", SqlDbType.VarChar,50),
                    new SqlParameter("@dcsj",SqlDbType.VarChar,50), 
                    new SqlParameter("@sfjd", SqlDbType.VarChar,50),
                    new SqlParameter("@beizhu",SqlDbType.Text), 
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.sfdc;
            parameters[1].Value = model.dcsj;
            parameters[2].Value = model.sfjd;
            parameters[3].Value = model.beizhu;
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

        public bool Update_sffc(YJUI.Model.ui_fhqk model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_fhqk set ");
            strSql.Append("sffc=@sffc,");
            strSql.Append("fcsj=@fcsj,");
            strSql.Append("beizhu=@beizhu");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@sffc", SqlDbType.VarChar,50),
                    new SqlParameter("@fcsj", SqlDbType.VarChar,50),
                    new SqlParameter("@beizhu", SqlDbType.Text),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.sffc;
            parameters[1].Value = model.fcsj;
            parameters[2].Value = model.beizhu;
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
            strSql.Append("delete from ui_fhqk ");
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
            strSql.Append("delete from ui_fhqk ");
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
        public YJUI.Model.ui_fhqk GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,djmc,xhdh,khqc,zsl,xhje,fhck,sfdc,sfdb,sffc,fcsj,sfjd from ui_fhqk ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            YJUI.Model.ui_fhqk model = new YJUI.Model.ui_fhqk();
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
        public YJUI.Model.ui_fhqk DataRowToModel(DataRow row)
        {
            YJUI.Model.ui_fhqk model = new YJUI.Model.ui_fhqk();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["djmc"] != null)
                {
                    model.djmc = row["djmc"].ToString();
                }
                if (row["xhdh"] != null)
                {
                    model.xhdh = row["xhdh"].ToString();
                }
                if (row["khqc"] != null)
                {
                    model.khqc = row["khqc"].ToString();
                }
                if (row["zsl"] != null && row["zsl"].ToString() != "")
                {
                    model.zsl = decimal.Parse(row["zsl"].ToString());
                }
                if (row["xhje"] != null && row["xhje"].ToString() != "")
                {
                    model.xhje = decimal.Parse(row["xhje"].ToString());
                }
                if (row["fhck"] != null)
                {
                    model.fhck = row["fhck"].ToString();
                }
                if (row["sfdc"] != null)
                {
                    model.sfdc = row["sfdc"].ToString();
                }
                if (row["sfdb"] != null)
                {
                    model.dcsj = row["dcsj"].ToString();
                }
                if (row["sffc"] != null)
                {
                    model.sffc = row["sffc"].ToString();
                }
                if (row["fcsj"] != null && row["fcsj"].ToString() != "")
                {
                    model.fcsj = row["fcsj"].ToString();
                }
                if (row["sfjd"] != null)
                {
                    model.sfjd = row["sfjd"].ToString();
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
            strSql.Append("select ID,djmc,xhdh,khqc,zsl,xhje,fhck,sfdc,sfdb,sffc,fcsj,sfjd ");
            strSql.Append(" FROM ui_fhqk ");
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
            strSql.Append(" ID,djmc,xhdh,khqc,zsl,xhje,fhck,sfdc,sfdb,sffc,fcsj,sfjd ");
            strSql.Append(" FROM ui_fhqk ");
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
            strSql.Append("select count(1) FROM ui_fhqk ");
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
        /// 获得所有数据
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="PageIndex"></param>
        /// <param name="strWhere"></param>
        /// <param name="fldName"></param>
        /// <param name="strOrder"></param>
        /// <returns></returns>
        public DataTable GetList(int PageSize, int PageIndex, string strWhere, string fldName, string strOrder)
        {
            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append(string.Format(" SELECT TOP {0} {1} FROM ui_fhqk ", PageSize, fldName));
            //sb.Append(" WHERE (ID NOT IN");
            sb.Append(string.Format("WHERE {0}  and (ID NOT IN",strWhere));
            sb.Append(string.Format(" (SELECT TOP {0} ID FROM ui_fhqk where {1}", PageSize * (PageIndex - 1), strWhere));
            sb.Append(string.Format(" ORDER BY {0}))", strOrder));
            sb.Append(string.Format(" ORDER BY {0}", strOrder));
            return DbHelperSQL.Query(sb.ToString()).Tables[0];

        }
        public int getDataCount(string strWhere)
        {
            string sql = string.Format("select count(*) from  ui_fhqk where {0}", strWhere);
            return Convert.ToInt32(DbHelperSQL.GetSingle(sql));
        }



        #endregion  ExtensionMethod
    }
}
