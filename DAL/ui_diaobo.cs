using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using YJUI.DBUtility;

namespace YJUI.DAL
{
    /// <summary>
    /// 数据访问类:ui_diaobo
    /// </summary>
    public partial class ui_diaobo
    {
        public ui_diaobo()
        { }

        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ui_diaobo");
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
        public int Add(YJUI.Model.ui_diaobo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ui_diaobo(");
            strSql.Append("bmmc,db,dh,zrck,sfqh,qhbz,dhsj,sfrz)");
            strSql.Append(" values (");
            strSql.Append("@bmmc,@db,@dh,@zrck,@sfqh,@qhbz,@dhsj,@sfrz)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@bmmc", SqlDbType.NVarChar,50),
					new SqlParameter("@db", SqlDbType.NVarChar,50),
					new SqlParameter("@dh", SqlDbType.NVarChar,50),
					new SqlParameter("@zrck", SqlDbType.NVarChar,50),
					new SqlParameter("@sfqh", SqlDbType.NVarChar,50),
					new SqlParameter("@qhbz", SqlDbType.NVarChar,200),
					new SqlParameter("@dhsj", SqlDbType.DateTime),
					new SqlParameter("@sfrz", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.bmmc;
            parameters[1].Value = model.db;
            parameters[2].Value = model.dh;
            parameters[3].Value = model.zrck;
            parameters[4].Value = model.sfqh;
            parameters[5].Value = model.qhbz;
            parameters[6].Value = model.dhsj;
            parameters[7].Value = model.sfrz;

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
        public bool Update(YJUI.Model.ui_diaobo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_diaobo set ");
            strSql.Append("db=@db,");
            strSql.Append("dh=@dh,");
            strSql.Append("zrck=@zrck,");
            strSql.Append("sfqh=@sfqh,");
            strSql.Append("qhbz=@qhbz,");
            strSql.Append("dhsj=@dhsj,");
            strSql.Append("sfrz=@sfrz");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@db", SqlDbType.NVarChar,50),
					new SqlParameter("@dh", SqlDbType.NVarChar,50),
					new SqlParameter("@zrck", SqlDbType.NVarChar,50),
					new SqlParameter("@sfqh", SqlDbType.NVarChar,50),
					new SqlParameter("@qhbz", SqlDbType.NVarChar,200),
					new SqlParameter("@dhsj", SqlDbType.DateTime),
					new SqlParameter("@sfrz", SqlDbType.NVarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@bmmc", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.db;
            parameters[1].Value = model.dh;
            parameters[2].Value = model.zrck;
            parameters[3].Value = model.sfqh;
            parameters[4].Value = model.qhbz;
            parameters[5].Value = model.dhsj;
            parameters[6].Value = model.sfrz;
            parameters[7].Value = model.ID;
            parameters[8].Value = model.bmmc;

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
        /// 缺货处理
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update_sfdh(YJUI.Model.ui_diaobo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_diaobo set ");
            strSql.Append("sfqh=@sfqh,");
            strSql.Append("shr=@shr,");
            strSql.Append("qhbz=@qhbz,");
            strSql.Append("dhsj=@dhsj");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@sfqh", SqlDbType.NVarChar,50),
					new SqlParameter("@shr", SqlDbType.NVarChar,50),
					new SqlParameter("@qhbz", SqlDbType.NVarChar,200),
					new SqlParameter("@dhsj", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.sfqh;
            parameters[1].Value = model.shr;
            parameters[2].Value = model.qhbz;
            parameters[3].Value = model.dhsj;
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

        public bool Update_sfrz(YJUI.Model.ui_diaobo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_diaobo set ");
            strSql.Append("sfrz=@sfrz,");
            strSql.Append("rzr=@rzr,");
            strSql.Append("rzsj=@rzsj");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters =
            {
                new SqlParameter("@sfrz", SqlDbType.NVarChar, 50),
                new SqlParameter("@rzr", SqlDbType.NVarChar, 50),
                new SqlParameter("@rzsj", SqlDbType.DateTime),
                new SqlParameter("@ID", SqlDbType.Int, 4)
            };
            parameters[0].Value = model.sfrz;
            parameters[1].Value = model.rzr;
            parameters[2].Value = model.rzsj;
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
        public bool Update_clzk(YJUI.Model.ui_diaobo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_diaobo set ");
            strSql.Append("clzk=@clzk,");
            strSql.Append("bz=@bz,");
            strSql.Append("clsj=@clsj");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters =
            {
                new SqlParameter("@clzk", SqlDbType.NVarChar, 50),
                new SqlParameter("@bz", SqlDbType.VarChar, 500),
                new SqlParameter("@clsj", SqlDbType.DateTime),
                new SqlParameter("@ID", SqlDbType.Int, 4)
            };
            parameters[0].Value = model.clzk;
            parameters[1].Value = model.bz;
            parameters[2].Value = model.clsj;
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
            strSql.Append("delete from ui_diaobo ");
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
            strSql.Append("delete from ui_diaobo ");
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
        public YJUI.Model.ui_diaobo GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,bmmc,db,dh,zrck,sfqh,qhbz,dhsj,sfrz from ui_diaobo ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            YJUI.Model.ui_diaobo model = new YJUI.Model.ui_diaobo();
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
        public YJUI.Model.ui_diaobo DataRowToModel(DataRow row)
        {
            YJUI.Model.ui_diaobo model = new YJUI.Model.ui_diaobo();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["bmmc"] != null)
                {
                    model.bmmc = row["bmmc"].ToString();
                }
                if (row["db"] != null)
                {
                    model.db = row["db"].ToString();
                }
                if (row["dh"] != null)
                {
                    model.dh = row["dh"].ToString();
                }
                if (row["zrck"] != null)
                {
                    model.zrck = row["zrck"].ToString();
                }
                if (row["sfqh"] != null)
                {
                    model.sfqh = row["sfqh"].ToString();
                }
                if (row["qhbz"] != null)
                {
                    model.qhbz = row["qhbz"].ToString();
                }
                if (row["dhsj"] != null && row["dhsj"].ToString() != "")
                {
                    model.dhsj = DateTime.Parse(row["dhsj"].ToString());
                }
                if (row["sfrz"] != null)
                {
                    model.sfrz = row["sfrz"].ToString();
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
            strSql.Append("select ID,bmmc,db,dh,zrck,sfqh,qhbz,dhsj,sfrz ");
            strSql.Append(" FROM ui_diaobo ");
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
            strSql.Append(" ID,bmmc,db,dh,zrck,sfqh,qhbz,dhsj,sfrz ");
            strSql.Append(" FROM ui_diaobo ");
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
            strSql.Append("select count(1) FROM ui_diaobo ");
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

        public DataTable GetList(int PageSize, int PageIndex, string strWhere, string fldName, string strOrder)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format(" SELECT TOP {0} {1} FROM ui_diaobo ", PageSize, fldName));
            sb.Append(string.Format("WHERE {0}  and (ID NOT IN", strWhere));
            sb.Append(string.Format(" (SELECT TOP {0} ID FROM ui_diaobo where {1}", PageSize * (PageIndex - 1), strWhere));
            sb.Append(string.Format(" ORDER BY {0}))", strOrder));
            sb.Append(string.Format(" ORDER BY {0}", strOrder));
            return DbHelperSQL.Query(sb.ToString()).Tables[0];
        }
        public int getDataCount(string strWhere)
        {
            string sql = string.Format("select count(*) from  ui_diaobo where {0}", strWhere);
            return Convert.ToInt32(DbHelperSQL.GetSingle(sql));
        }
        /// <summary>
        /// 通过调拨平台添加一条调拨信息
        /// </summary>
        /// <param name="yuandanbie">原单别</param>
        /// <param name="yuandanhao">原单号</param>
        /// <param name="xindanhao">新单号</param>
        /// <param name="bumen">部门ID</param>
        /// <param name="beizhu">备注</param>
        /// <param name="zhuanchuku">转出库</param>
        /// <param name="zhuanruku">转入库</param>
        /// <returns></returns>
        public int AddDiaoBo(string zt,string yuandanbie, string yuandanhao, string xindanhao, string bumen, string beizhu, string zhuanchuku, string zhuanruku)
        {
            SqlParameter[] parameters = { 
                                            
                                             new SqlParameter("@yuandanbie",SqlDbType.NVarChar), 
                                             new SqlParameter("@yuandaohao",SqlDbType.NVarChar), 
                                             new SqlParameter("@xindanhao",SqlDbType.NVarChar), 
                                             new SqlParameter("@bumen",SqlDbType.NVarChar), 
                                             new SqlParameter("@beizhu",SqlDbType.NVarChar), 
                                             new SqlParameter("@zhuanchuku",SqlDbType.NVarChar), 
                                             new SqlParameter("@zhuanruku",SqlDbType.NVarChar),
                                             new SqlParameter("@zhangtao",SqlDbType.NVarChar)
                                        };
            parameters[0].Value = yuandanbie;
            parameters[1].Value = yuandanhao;
            parameters[2].Value = xindanhao;
            parameters[3].Value = bumen;
            parameters[4].Value = beizhu;
            parameters[5].Value = zhuanchuku;
            parameters[6].Value = zhuanruku;
            parameters[7].Value = zt;
            int row=DbHelperSQL.ExecuteStoredProcedure("updatedb", parameters);
            if (row> 0)
            {
                return 1;
            }
            else {
                return 0;
            }
        }





        #endregion  ExtensionMethod
    }
}

