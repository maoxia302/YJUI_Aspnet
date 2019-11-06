using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using YJUI.DBUtility;//Please add references
namespace YJUI.DAL
{
    /// <summary>
    /// 数据访问类:chuyun
    /// </summary>
    public partial class chuyun
    {
        public chuyun()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from chuyun");
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
        public bool Add(YJUI.Model.chuyun model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into chuyun(");
            strSql.Append("riqi,tzr,fenku,tzrdh,dth,dhdq,khmc,dhwl,wldh,wldz,bz,shr,shrtel,js,ph,yfje)");
            strSql.Append(" values (");
            strSql.Append("@riqi,@tzr,@fenku,@tzrdh,@dth,@dhdq,@khmc,@dhwl,@wldh,@wldz,@bz,@shr,@shrtel,@js,@ph,@yfje)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@riqi", SqlDbType.DateTime),
                    new SqlParameter("@tzr", SqlDbType.VarChar,50),
                    new SqlParameter("@fenku", SqlDbType.VarChar,50),
                    new SqlParameter("@tzrdh", SqlDbType.VarChar,50),
                    new SqlParameter("@dth", SqlDbType.VarChar,50),
                    new SqlParameter("@dhdq", SqlDbType.VarChar,50),
                    new SqlParameter("@khmc", SqlDbType.VarChar,50),
                    new SqlParameter("@dhwl", SqlDbType.VarChar,50),
                    new SqlParameter("@wldh", SqlDbType.VarChar,50),
                    new SqlParameter("@wldz", SqlDbType.VarChar,200),
                    new SqlParameter("@bz", SqlDbType.VarChar,200),
                    new SqlParameter("@shr", SqlDbType.VarChar,200),
                    new SqlParameter("@shrtel", SqlDbType.VarChar,200),
                    new SqlParameter("@js", SqlDbType.VarChar,200),
                    new SqlParameter("@ph", SqlDbType.VarChar,200),
                    new SqlParameter("@yfje", SqlDbType.VarChar,200)



            };
            parameters[0].Value = model.riqi;
            parameters[1].Value = model.tzr;
            parameters[2].Value = model.Fenku;
            parameters[3].Value = model.tzrdh;
            parameters[4].Value = model.dth;
            parameters[5].Value = model.dhdq;
            parameters[6].Value = model.khmc;
            parameters[7].Value = model.dhwl;
            parameters[8].Value = model.wldh;
            parameters[9].Value = model.wldz;
            parameters[10].Value = model.bz;
            parameters[11].Value = model.shr;
            parameters[12].Value = model.shrtel;
            parameters[13].Value = model.js;
            parameters[14].Value = model.ph;
            parameters[15].Value = model.yfje;

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
        public bool Update(YJUI.Model.chuyun model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update chuyun set ");
            strSql.Append("riqi=@riqi,");
            strSql.Append("tzr=@tzr,");
            strSql.Append("tzrdh=@tzrdh,");
            strSql.Append("dth=@dth,");
            strSql.Append("dhdq=@dhdq,");
            strSql.Append("khmc=@khmc,");
            strSql.Append("dhwl=@dhwl,");
            strSql.Append("wldh=@wldh,");
            strSql.Append("wldz=@wldz,");
            strSql.Append("shrtel=@shrtel,");
            strSql.Append("js=@js,");
            strSql.Append("yfje=@yfje,");
            strSql.Append("ph=@ph,");
            strSql.Append("bz=@bz,");
            strSql.Append("thr=@thr,");
            strSql.Append("thsj=@thsj,");
            strSql.Append("sfth=@sfth,");
            strSql.Append("fee=@fee,");
            strSql.Append("wlfl=@wlfl,");
            strSql.Append("CreatedTime=@CreatedTime");

            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@riqi", SqlDbType.DateTime),
                    new SqlParameter("@tzr", SqlDbType.VarChar,50),
                    new SqlParameter("@tzrdh", SqlDbType.VarChar,50),
                    new SqlParameter("@dth", SqlDbType.VarChar,50),
                    new SqlParameter("@dhdq", SqlDbType.VarChar,50),
                    new SqlParameter("@khmc", SqlDbType.VarChar,50),
                    new SqlParameter("@dhwl", SqlDbType.VarChar,50),
                    new SqlParameter("@wldh", SqlDbType.VarChar,50),
                    new SqlParameter("@wldz", SqlDbType.VarChar,200),
                    new SqlParameter("@shrtel", SqlDbType.VarChar,50),
                    new SqlParameter("@js", SqlDbType.VarChar,50),
                    new SqlParameter("@yfje", SqlDbType.VarChar,50),
                    new SqlParameter("@ph", SqlDbType.VarChar,50),
                    new SqlParameter("@bz", SqlDbType.Text),
                    new SqlParameter("@thr", SqlDbType.VarChar,50),
                    new SqlParameter("@thsj", SqlDbType.VarChar,50),
                    new SqlParameter("@sfth", SqlDbType.VarChar,50),
                    new SqlParameter("@fee", SqlDbType.VarChar,50),
                    new SqlParameter("@CreatedTime", SqlDbType.DateTime),
                    new SqlParameter("@ID", SqlDbType.Int,4),
                    new SqlParameter("@wlfl", SqlDbType.VarChar,50),
             new SqlParameter("@shr", SqlDbType.VarChar,50)};
            parameters[0].Value = model.riqi;
            parameters[1].Value = model.tzr;
            parameters[2].Value = model.tzrdh;
            parameters[3].Value = model.dth;
            parameters[4].Value = model.dhdq;
            parameters[5].Value = model.khmc;
            parameters[6].Value = model.dhwl;
            parameters[7].Value = model.wldh;
            parameters[8].Value = model.wldz;
            parameters[9].Value = model.shrtel;
            parameters[10].Value = model.js;
            parameters[11].Value = model.yfje;
            parameters[12].Value = model.ph;
            parameters[13].Value = model.bz;
            parameters[14].Value = model.thr;
            parameters[15].Value = model.thsj;
            parameters[16].Value = model.sfth;
            parameters[17].Value = model.fee;
            parameters[18].Value = DateTime.Now;
            parameters[19].Value = model.ID;
            parameters[20].Value = model.shr;
            parameters[21].Value = model.Wlfl;

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
        public bool Add_ZhiJian(YJUI.Model.chuyun model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update chuyun set ");
            strSql.Append("zhijian=@zhijian,");
            strSql.Append("zjdate=@zjdate  ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@zhijian", SqlDbType.VarChar,50),
                    new SqlParameter("@zjdate", SqlDbType.DateTime),
                    new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Zhijian;
            parameters[1].Value = model.Zjdate;
            parameters[2].Value = model.ID;
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
            strSql.Append("delete from chuyun ");
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
            strSql.Append("delete from chuyun ");
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
        public YJUI.Model.chuyun GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,riqi,tzr,tzrdh,dth,dhdq,khmc,dhwl,wldh,wldz,shr,shrtel,js,yfje,ph,bz,thr,thsj,sfth,fee,CreatedTime from chuyun ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int,4)
            };
            parameters[0].Value = ID;

            YJUI.Model.chuyun model = new YJUI.Model.chuyun();
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
        public YJUI.Model.chuyun DataRowToModel(DataRow row)
        {
            YJUI.Model.chuyun model = new YJUI.Model.chuyun();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["riqi"] != null && row["riqi"].ToString() != "")
                {
                    model.riqi = DateTime.Parse(row["riqi"].ToString());
                }
                if (row["tzr"] != null)
                {
                    model.tzr = row["tzr"].ToString();
                }
                if (row["tzrdh"] != null)
                {
                    model.tzrdh = row["tzrdh"].ToString();
                }
                if (row["dth"] != null)
                {
                    model.dth = row["dth"].ToString();
                }
                if (row["dhdq"] != null)
                {
                    model.dhdq = row["dhdq"].ToString();
                }
                if (row["khmc"] != null)
                {
                    model.khmc = row["khmc"].ToString();
                }
                if (row["dhwl"] != null)
                {
                    model.dhwl = row["dhwl"].ToString();
                }
                if (row["wldh"] != null)
                {
                    model.wldh = row["wldh"].ToString();
                }
                if (row["wldz"] != null)
                {
                    model.wldz = row["wldz"].ToString();
                }
                if (row["shr"] != null)
                {
                    model.shr = row["shr"].ToString();
                }
                if (row["shrtel"] != null)
                {
                    model.shrtel = row["shrtel"].ToString();
                }
                if (row["js"] != null)
                {
                    model.js = row["js"].ToString();
                }
                if (row["yfje"] != null)
                {
                    model.yfje = row["yfje"].ToString();
                }
                if (row["ph"] != null)
                {
                    model.ph = row["ph"].ToString();
                }
                if (row["bz"] != null)
                {
                    model.bz = row["bz"].ToString();
                }
                if (row["thr"] != null)
                {
                    model.thr = row["thr"].ToString();
                }
                if (row["thsj"] != null)
                {
                    model.thsj = row["thsj"].ToString();
                }
                if (row["sfth"] != null)
                {
                    model.sfth = row["sfth"].ToString();
                }
                if (row["fee"] != null)
                {
                    model.fee = row["fee"].ToString();
                }
                if (row["CreatedTime"] != null && row["CreatedTime"].ToString() != "")
                {
                    model.CreatedTime = DateTime.Parse(row["CreatedTime"].ToString());
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
            strSql.Append("select ID,riqi,tzr,tzrdh,dth,dhdq,khmc,dhwl,wldh,wldz,shr,shrtel,js,yfje,ph,bz,thr,thsj,sfth,fee,CreatedTime ");
            strSql.Append(" FROM chuyun ");
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
            strSql.Append(" ID,riqi,tzr,tzrdh,dth,dhdq,khmc,dhwl,wldh,wldz,shr,shrtel,js,yfje,ph,bz,thr,thsj,sfth,fee,CreatedTime ");
            strSql.Append(" FROM chuyun ");
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
            strSql.Append("select count(1) FROM chuyun ");
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
            strSql.Append(")AS Row, T.*  from chuyun T ");
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
        /// 
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="PageIndex"></param>
        /// <param name="strWhere"></param>
        /// <param name="fldName"></param>
        /// <param name="strOrder"></param>
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

        public IDataReader ChuYunToDataReader(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            ////   string cs = "序号,通知日期,通知人,分库,提货类别" +
            //"到货地区,客户名称,到货物流,物流分类,物流电话，物流地址" +
            //"收货人,收货人电话,件数," +// 问题检核
            //"金额,票号,备注" +//
            //"提货人,提货时间,是否提货,实际运费金额,质检签收日期,提货总用时,是否超时";
            strSql.Append("select  [ID],[riqi] ,[tzr] ,[fenku] ,[dth] ,[dhdq]");
            strSql.Append(" , [khmc],[dhwl] ,[wlfl] ,[wldh] ,[wldz]");
            strSql.Append(", [shr],[shrtel] ,[js] ,[yfje] ,[ph],[bz]");
            strSql.Append(", [thr],[thsj] ,[sfth] ,[fee] ,[CreatedTime],[zjdate]");

            strSql.Append("   FROM [chuyun] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.ExecuteReader(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}

