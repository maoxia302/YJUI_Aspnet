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
    /// 数据访问类:jldl1
    /// </summary>
    public partial class jldl1
    {
        public jldl1()
        { }
        #region  BasicMethod


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YJUI.Model.jldl1 model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into jldl1(");
            strSql.Append("fksj,fkr,pj,fssj,fsdq,dls,dlsdh,xlcxx,fknr,fl,jjsfth,zrbm,zrr,ycclrq,plga,dkhcs,wcsj,kcclcs,kcwcrq,gysclcs,gysrq,nblcgygs,nblcwcrq,qtcs,qtcsrq,zrbmsp,dsfjh,hfsjqk,hfwcrq)");
            strSql.Append(" values (");
            strSql.Append("@fksj,@fkr,@pj,@fssj,@fsdq,@dls,@dlsdh,@xlcxx,@fknr,@fl,@jjsfth,@zrbm,@zrr,@ycclrq,@plga,@dkhcs,@wcsj,@kcclcs,@kcwcrq,@gysclcs,@gysrq,@nblcgygs,@nblcwcrq,@qtcs,@qtcsrq,@zrbmsp,@dsfjh,@hfsjqk,@hfwcrq)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@fksj", SqlDbType.DateTime),
					new SqlParameter("@fkr", SqlDbType.VarChar,50),
					new SqlParameter("@pj", SqlDbType.VarChar,50),
					new SqlParameter("@fssj", SqlDbType.VarChar,50),
					new SqlParameter("@fsdq", SqlDbType.VarChar,50),
					new SqlParameter("@dls", SqlDbType.VarChar,50),
					new SqlParameter("@dlsdh", SqlDbType.VarChar,50),
					new SqlParameter("@xlcxx", SqlDbType.VarChar,50),
					new SqlParameter("@fknr", SqlDbType.Text),
					new SqlParameter("@fl", SqlDbType.Char,10),
					new SqlParameter("@jjsfth", SqlDbType.Char,40),
					new SqlParameter("@zrbm", SqlDbType.Char,40),
					new SqlParameter("@zrr", SqlDbType.Char,40),
					new SqlParameter("@ycclrq", SqlDbType.VarChar,50),
					new SqlParameter("@plga", SqlDbType.Char,10),
					new SqlParameter("@dkhcs", SqlDbType.Text),
					new SqlParameter("@wcsj", SqlDbType.VarChar,100),
					new SqlParameter("@kcclcs", SqlDbType.Text),
					new SqlParameter("@kcwcrq", SqlDbType.VarChar,50),
					new SqlParameter("@gysclcs", SqlDbType.Text),
					new SqlParameter("@gysrq", SqlDbType.VarChar,50),
					new SqlParameter("@nblcgygs", SqlDbType.Text),
					new SqlParameter("@nblcwcrq", SqlDbType.VarChar,50),
					new SqlParameter("@qtcs", SqlDbType.Text),
					new SqlParameter("@qtcsrq", SqlDbType.VarChar,50),
					new SqlParameter("@zrbmsp", SqlDbType.VarChar,50),
					new SqlParameter("@dsfjh", SqlDbType.VarChar,50),
					new SqlParameter("@hfsjqk", SqlDbType.Text),
					new SqlParameter("@hfwcrq", SqlDbType.VarChar,50)};
            parameters[0].Value = model.fksj;
            parameters[1].Value = model.fkr;
            parameters[2].Value = model.pj;
            parameters[3].Value = model.fssj;
            parameters[4].Value = model.fsdq;
            parameters[5].Value = model.dls;
            parameters[6].Value = model.dlsdh;
            parameters[7].Value = model.xlcxx;
            parameters[8].Value = model.fknr;
            parameters[9].Value = model.fl;
            parameters[10].Value = model.jjsfth;
            parameters[11].Value = model.zrbm;
            parameters[12].Value = model.zrr;
            parameters[13].Value = model.ycclrq;
            parameters[14].Value = model.plga;
            parameters[15].Value = model.dkhcs;
            parameters[16].Value = model.wcsj;
            parameters[17].Value = model.kcclcs;
            parameters[18].Value = model.kcwcrq;
            parameters[19].Value = model.gysclcs;
            parameters[20].Value = model.gysrq;
            parameters[21].Value = model.nblcgygs;
            parameters[22].Value = model.nblcwcrq;
            parameters[23].Value = model.qtcs;
            parameters[24].Value = model.qtcsrq;
            parameters[25].Value = model.zrbmsp;
            parameters[26].Value = model.dsfjh;
            parameters[27].Value = model.hfsjqk;
            parameters[28].Value = model.hfwcrq;

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
        public bool Update(YJUI.Model.jldl1 model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update jldl1 set ");
            strSql.Append("fksj=@fksj,");
            strSql.Append("pj=@pj,");
            strSql.Append("fssj=@fssj,");
            strSql.Append("fsdq=@fsdq,");
            strSql.Append("dls=@dls,");
            strSql.Append("dlsdh=@dlsdh,");
            strSql.Append("xlcxx=@xlcxx,");
            strSql.Append("fknr=@fknr,");
            strSql.Append("fl=@fl,");
            strSql.Append("jjsfth=@jjsfth,");
            strSql.Append("zrbm=@zrbm,");
            strSql.Append("zrr=@zrr,");
            strSql.Append("ycclrq=@ycclrq,");
            strSql.Append("plga=@plga,");
            strSql.Append("dkhcs=@dkhcs,");
            strSql.Append("wcsj=@wcsj,");
            strSql.Append("kcclcs=@kcclcs,");
            strSql.Append("kcwcrq=@kcwcrq,");
            strSql.Append("gysclcs=@gysclcs,");
            strSql.Append("gysrq=@gysrq,");
            strSql.Append("nblcgygs=@nblcgygs,");
            strSql.Append("nblcwcrq=@nblcwcrq,");
            strSql.Append("qtcs=@qtcs,");
            strSql.Append("qtcsrq=@qtcsrq,");
            strSql.Append("zrbmsp=@zrbmsp,");
            strSql.Append("dsfjh=@dsfjh,");
            strSql.Append("hfsjqk=@hfsjqk,");
            strSql.Append("hfwcrq=@hfwcrq");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@fksj", SqlDbType.DateTime),
					new SqlParameter("@pj", SqlDbType.VarChar,50),
					new SqlParameter("@fssj", SqlDbType.VarChar,50),
					new SqlParameter("@fsdq", SqlDbType.VarChar,50),
					new SqlParameter("@dls", SqlDbType.VarChar,50),
					new SqlParameter("@dlsdh", SqlDbType.VarChar,50),
					new SqlParameter("@xlcxx", SqlDbType.VarChar,50),
					new SqlParameter("@fknr", SqlDbType.Text),
					new SqlParameter("@fl", SqlDbType.Char,10),
					new SqlParameter("@jjsfth", SqlDbType.Char,40),
					new SqlParameter("@zrbm", SqlDbType.Char,40),
					new SqlParameter("@zrr", SqlDbType.Char,40),
					new SqlParameter("@ycclrq", SqlDbType.VarChar,50),
					new SqlParameter("@plga", SqlDbType.Char,10),
					new SqlParameter("@dkhcs", SqlDbType.Text),
					new SqlParameter("@wcsj", SqlDbType.VarChar,100),
					new SqlParameter("@kcclcs", SqlDbType.Text),
					new SqlParameter("@kcwcrq", SqlDbType.VarChar,50),
					new SqlParameter("@gysclcs", SqlDbType.Text),
					new SqlParameter("@gysrq", SqlDbType.VarChar,50),
					new SqlParameter("@nblcgygs", SqlDbType.Text),
					new SqlParameter("@nblcwcrq", SqlDbType.VarChar,50),
					new SqlParameter("@qtcs", SqlDbType.Text),
					new SqlParameter("@qtcsrq", SqlDbType.VarChar,50),
					new SqlParameter("@zrbmsp", SqlDbType.VarChar,50),
					new SqlParameter("@dsfjh", SqlDbType.VarChar,50),
					new SqlParameter("@hfsjqk", SqlDbType.Text),
					new SqlParameter("@hfwcrq", SqlDbType.VarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@fkr", SqlDbType.VarChar,50)};
            parameters[0].Value = model.fksj;
            parameters[1].Value = model.pj;
            parameters[2].Value = model.fssj;
            parameters[3].Value = model.fsdq;
            parameters[4].Value = model.dls;
            parameters[5].Value = model.dlsdh;
            parameters[6].Value = model.xlcxx;
            parameters[7].Value = model.fknr;
            parameters[8].Value = model.fl;
            parameters[9].Value = model.jjsfth;
            parameters[10].Value = model.zrbm;
            parameters[11].Value = model.zrr;
            parameters[12].Value = model.ycclrq;
            parameters[13].Value = model.plga;
            parameters[14].Value = model.dkhcs;
            parameters[15].Value = model.wcsj;
            parameters[16].Value = model.kcclcs;
            parameters[17].Value = model.kcwcrq;
            parameters[18].Value = model.gysclcs;
            parameters[19].Value = model.gysrq;
            parameters[20].Value = model.nblcgygs;
            parameters[21].Value = model.nblcwcrq;
            parameters[22].Value = model.qtcs;
            parameters[23].Value = model.qtcsrq;
            parameters[24].Value = model.zrbmsp;
            parameters[25].Value = model.dsfjh;
            parameters[26].Value = model.hfsjqk;
            parameters[27].Value = model.hfwcrq;
            parameters[28].Value = model.ID;
            parameters[29].Value = model.fkr;

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
        /// 责任部门审批
        /// </summary>
        public bool Update_zrbm(YJUI.Model.jldl1 model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update jldl1 set ");
            strSql.Append("jjsfth=@jjsfth,");
            strSql.Append("zrbm=@zrbm,");
            strSql.Append("zrr=@zrr,");
            strSql.Append("ycclrq=@ycclrq,");
            strSql.Append("plga=@plga,");
            strSql.Append("dkhcs=@dkhcs,");
            strSql.Append("wcsj=@wcsj,");
            strSql.Append("kcclcs=@kcclcs,");
            strSql.Append("kcwcrq=@kcwcrq,");
            strSql.Append("gysclcs=@gysclcs,");
            strSql.Append("gysrq=@gysrq,");
            strSql.Append("nblcgygs=@nblcgygs,");
            strSql.Append("nblcwcrq=@nblcwcrq,");
            strSql.Append("qtcs=@qtcs,");
            strSql.Append("qtcsrq=@qtcsrq");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@jjsfth", SqlDbType.Char,40),
					new SqlParameter("@zrbm", SqlDbType.Char,40),
					new SqlParameter("@zrr", SqlDbType.Char,40),
					new SqlParameter("@ycclrq", SqlDbType.VarChar,50),
					new SqlParameter("@plga", SqlDbType.Char,10),
					new SqlParameter("@dkhcs", SqlDbType.Text),
					new SqlParameter("@wcsj", SqlDbType.VarChar,100),
					new SqlParameter("@kcclcs", SqlDbType.Text),
					new SqlParameter("@kcwcrq", SqlDbType.VarChar,50),
					new SqlParameter("@gysclcs", SqlDbType.Text),
					new SqlParameter("@gysrq", SqlDbType.VarChar,50),
					new SqlParameter("@nblcgygs", SqlDbType.Text),
					new SqlParameter("@nblcwcrq", SqlDbType.VarChar,50),
					new SqlParameter("@qtcs", SqlDbType.Text),
					new SqlParameter("@qtcsrq", SqlDbType.VarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.jjsfth;
            parameters[1].Value = model.zrbm;
            parameters[2].Value = model.zrr;
            parameters[3].Value = model.ycclrq;
            parameters[4].Value = model.plga;
            parameters[5].Value = model.dkhcs;
            parameters[6].Value = model.wcsj;
            parameters[7].Value = model.kcclcs;
            parameters[8].Value = model.kcwcrq;
            parameters[9].Value = model.gysclcs;
            parameters[10].Value = model.gysrq;
            parameters[11].Value = model.nblcgygs;
            parameters[12].Value = model.nblcwcrq;
            parameters[13].Value = model.qtcs;
            parameters[14].Value = model.qtcsrq;
            parameters[15].Value = model.ID;
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
        /// 回访实际情况
        /// </summary>
        public bool Update_hfsjqk(YJUI.Model.jldl1 model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update jldl1 set ");
            strSql.Append("hfsjqk=@hfsjqk,");
            strSql.Append("hfwcrq=@hfwcrq");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@hfsjqk",SqlDbType.Text),
                    new SqlParameter("@hfwcrq",SqlDbType.VarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.hfsjqk;
            parameters[1].Value = model.hfwcrq;
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
        /// 责任部门审批
        /// </summary>
        public bool Update_zrbmsh(YJUI.Model.jldl1 model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update jldl1 set ");
            strSql.Append("zrbmsp=@zrbmsp");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@zrbmsp",SqlDbType.VarChar,200),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.zrbmsp;
            parameters[1].Value = model.ID;
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
        public bool Update_dsfjh(YJUI.Model.jldl1 model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update jldl1 set ");
            strSql.Append("fl=@fl,");
            strSql.Append("dsfjh=@dsfjh");
            strSql.Append(" where ID=@ID");

            SqlParameter[] parameters = {
                    new SqlParameter("@fl",SqlDbType.VarChar,50), 
                    new SqlParameter("@dsfjh",SqlDbType.VarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.fl;
            parameters[1].Value = model.dsfjh;
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
        /// 更新一条数据
        /// </summary>
        public bool Update_ceshi(YJUI.Model.jldl1 model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update jldl1 set ");
            strSql.Append("fksj=@fksj,");
            strSql.Append("pj=@pj,");
            strSql.Append("fssj=@fssj,");
            strSql.Append("fsdq=@fsdq,");
            strSql.Append("dls=@dls,");
            strSql.Append("dlsdh=@dlsdh,");
            strSql.Append("xlcxx=@xlcxx,");
            strSql.Append("fknr=@fknr,");
            strSql.Append("fl=@fl,");
            strSql.Append("jjsfth=@jjsfth,");

            SqlParameter[] parameters = {

					new SqlParameter("@dls", SqlDbType.VarChar,50),
					new SqlParameter("@dlsdh", SqlDbType.VarChar,50)
                                        };
            parameters[4].Value = model.dls;
            parameters[5].Value = model.dlsdh;


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
            strSql.Append("delete from jldl1 ");
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
            strSql.Append("delete from jldl1 ");
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
        public YJUI.Model.jldl1 GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,fksj,fkr,pj,fssj,fsdq,dls,dlsdh,xlcxx,fknr,fl,jjsfth,zrbm,zrr,ycclrq,plga,dkhcs,wcsj,kcclcs,kcwcrq,gysclcs,gysrq,nblcgygs,nblcwcrq,qtcs,qtcsrq,zrbmsp,dsfjh,hfsjqk,hfwcrq from jldl1 ");
            strSql.Append(" where ID=@ID");
            strSql.Append("  order by DESC" );
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            YJUI.Model.jldl1 model = new YJUI.Model.jldl1();
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
        public YJUI.Model.jldl1 DataRowToModel(DataRow row)
        {
            YJUI.Model.jldl1 model = new YJUI.Model.jldl1();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["fksj"] != null && row["fksj"].ToString() != "")
                {
                    model.fksj = DateTime.Parse(row["fksj"].ToString());
                }
                if (row["fkr"] != null)
                {
                    model.fkr = row["fkr"].ToString();
                }
                if (row["pj"] != null)
                {
                    model.pj = row["pj"].ToString();
                }
                if (row["fssj"] != null)
                {
                    model.fssj = row["fssj"].ToString();
                }
                if (row["fsdq"] != null)
                {
                    model.fsdq = row["fsdq"].ToString();
                }
                if (row["dls"] != null)
                {
                    model.dls = row["dls"].ToString();
                }
                if (row["dlsdh"] != null)
                {
                    model.dlsdh = row["dlsdh"].ToString();
                }
                if (row["xlcxx"] != null)
                {
                    model.xlcxx = row["xlcxx"].ToString();
                }
                if (row["fknr"] != null)
                {
                    model.fknr = row["fknr"].ToString();
                }
                if (row["fl"] != null)
                {
                    model.fl = row["fl"].ToString();
                }
                if (row["jjsfth"] != null)
                {
                    model.jjsfth = row["jjsfth"].ToString();
                }
                if (row["zrbm"] != null)
                {
                    model.zrbm = row["zrbm"].ToString();
                }
                if (row["zrr"] != null)
                {
                    model.zrr = row["zrr"].ToString();
                }
                if (row["ycclrq"] != null)
                {
                    model.ycclrq = row["ycclrq"].ToString();
                }
                if (row["plga"] != null)
                {
                    model.plga = row["plga"].ToString();
                }
                if (row["dkhcs"] != null)
                {
                    model.dkhcs = row["dkhcs"].ToString();
                }
                if (row["wcsj"] != null)
                {
                    model.wcsj = row["wcsj"].ToString();
                }
                if (row["kcclcs"] != null)
                {
                    model.kcclcs = row["kcclcs"].ToString();
                }
                if (row["kcwcrq"] != null)
                {
                    model.kcwcrq = row["kcwcrq"].ToString();
                }
                if (row["gysclcs"] != null)
                {
                    model.gysclcs = row["gysclcs"].ToString();
                }
                if (row["gysrq"] != null)
                {
                    model.gysrq = row["gysrq"].ToString();
                }
                if (row["nblcgygs"] != null)
                {
                    model.nblcgygs = row["nblcgygs"].ToString();
                }
                if (row["nblcwcrq"] != null)
                {
                    model.nblcwcrq = row["nblcwcrq"].ToString();
                }
                if (row["qtcs"] != null)
                {
                    model.qtcs = row["qtcs"].ToString();
                }
                if (row["qtcsrq"] != null)
                {
                    model.qtcsrq = row["qtcsrq"].ToString();
                }
                if (row["zrbmsp"] != null)
                {
                    model.zrbmsp = row["zrbmsp"].ToString();
                }
                if (row["dsfjh"] != null)
                {
                    model.dsfjh = row["dsfjh"].ToString();
                }
                if (row["hfsjqk"] != null)
                {
                    model.hfsjqk = row["hfsjqk"].ToString();
                }
                if (row["hfwcrq"] != null)
                {
                    model.hfwcrq = row["hfwcrq"].ToString();
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
            strSql.Append("select ID,fksj,fkr,pj,fssj,fsdq,dls,dlsdh,xlcxx,fknr,fl,jjsfth,zrbm,zrr,ycclrq,plga,dkhcs,wcsj,kcclcs,kcwcrq,gysclcs,gysrq,nblcgygs,nblcwcrq,qtcs,qtcsrq,zrbmsp,dsfjh,hfsjqk,hfwcrq ");
            strSql.Append(" FROM jldl1 ");
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
            strSql.Append(" ID,fksj,fkr,pj,fssj,fsdq,dls,dlsdh,xlcxx,fknr,fl,jjsfth,zrbm,zrr,ycclrq,plga,dkhcs,wcsj,kcclcs,kcwcrq,gysclcs,gysrq,nblcgygs,nblcwcrq,qtcs,qtcsrq,zrbmsp,dsfjh,hfsjqk,hfwcrq ");
            strSql.Append(" FROM jldl1 ");
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
            strSql.Append("select count(1) FROM jldl1 ");
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
            strSql.Append(")AS Row, T.*  from jldl1 T ");
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

        public DataTable GetList(int PageSize, int PageIndex, string strWhere, string fldName, string strOrder)
        {
            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append(string.Format(" SELECT TOP {0} {1} FROM jldl1 ", PageSize, fldName));
            sb.Append(string.Format("WHERE {0}  and (ID NOT IN", strWhere));
            sb.Append(string.Format(" (SELECT TOP {0} ID FROM jldl1 where {1}", PageSize * (PageIndex - 1), strWhere));
            sb.Append(string.Format(" ORDER BY {0}))", strOrder));
            sb.Append(string.Format(" ORDER BY {0}", strOrder));
            return DbHelperSQL.Query(sb.ToString()).Tables[0];
        }

        public int getDataCount(string strWhere)
        {
            string sql = string.Format("select count(*) from  jldl1 where {0}", strWhere);
            return Convert.ToInt32(DbHelperSQL.GetSingle(sql));
        }
        #endregion  ExtensionMethod
    }
}
