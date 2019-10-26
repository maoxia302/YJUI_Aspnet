using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using YJUI.DBUtility;//Please add references
namespace YJUI.DAL
{
    /// <summary>
    /// 数据访问类:TUJI
    /// </summary>
    public partial class Tuji
    {

        public Tuji()
        { }


        #region 添加台账信息
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YJUI.Model.TUJI model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TUJI(");
            strSql.Append("tjxh,fdjh,zjsj,jhbx,gzfsdq,dls,xlc,lxr,xlctel,xxfksj,xxfkr,gzxx,gznr)");
            strSql.Append(" values (");
            strSql.Append("@tjxh,@fdjh,@zjsj,@jhbx,@gzfsdq,@dls,@xlc,@lxr,@xlctel,@xxfksj,@xxfkr,@gzxx,@gznr)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@tjxh", SqlDbType.VarChar,50),
					new SqlParameter("@fdjh", SqlDbType.VarChar,50),
					new SqlParameter("@zjsj", SqlDbType.VarChar,50),
					new SqlParameter("@jhbx", SqlDbType.Char,10),
					new SqlParameter("@gzfsdq", SqlDbType.VarChar,50),
					new SqlParameter("@dls", SqlDbType.VarChar,50),
					new SqlParameter("@xlc", SqlDbType.VarChar,50),
					new SqlParameter("@lxr", SqlDbType.VarChar,50),
					new SqlParameter("@xlctel", SqlDbType.VarChar,50),
					new SqlParameter("@xxfksj", SqlDbType.VarChar,50),
					new SqlParameter("@xxfkr", SqlDbType.VarChar,50),
					new SqlParameter("@gzxx", SqlDbType.VarChar,400),
					new SqlParameter("@gznr", SqlDbType.Text)};
            parameters[0].Value = model.tjxh;
            parameters[1].Value = model.fdjh;
            parameters[2].Value = model.zjrq;
            parameters[3].Value = model.jhbx;
            parameters[4].Value = model.gzfsdq;
            parameters[5].Value = model.dls;
            parameters[6].Value = model.xlc;
            parameters[7].Value = model.lxr;
            parameters[8].Value = model.xlctel;
            parameters[9].Value = model.xxfksj;
            parameters[10].Value = model.xxfkr;
            parameters[11].Value = model.gzxx;
            parameters[12].Value = model.gznr;
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
        #endregion

        #region 修改台账信息
        public bool update(YJUI.Model.TUJI model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update  TUJI set");
            strSql.Append("  tjxh=@tjxh,fdjh=@fdjh,zjsj=@zjsj,jhbx=@jhbx,gzfsdq=@gzfsdq,dls=@dls,xlc=@xlc,lxr=@lxr,xlctel=@xlctel,xxfksj=@xxfksj,xxfkr=@xxfkr,gzxx=@gzxx,gznr=@gznr");
            strSql.Append(" where ID=@ID ");

            SqlParameter[] parameters = {
					new SqlParameter("@tjxh", SqlDbType.VarChar,50),
					new SqlParameter("@fdjh", SqlDbType.VarChar,50),
					new SqlParameter("@zjsj", SqlDbType.VarChar,50),
					new SqlParameter("@jhbx", SqlDbType.Char,10),
					new SqlParameter("@gzfsdq", SqlDbType.VarChar,50),
					new SqlParameter("@dls", SqlDbType.VarChar,50),
					new SqlParameter("@xlc", SqlDbType.VarChar,50),
					new SqlParameter("@lxr", SqlDbType.VarChar,50),
					new SqlParameter("@xlctel", SqlDbType.VarChar,50),
					new SqlParameter("@xxfksj", SqlDbType.VarChar,50),
					new SqlParameter("@xxfkr", SqlDbType.VarChar,50),
					new SqlParameter("@gzxx", SqlDbType.VarChar,400),
					new SqlParameter("@gznr", SqlDbType.Text),
                    new SqlParameter("@ID",SqlDbType.Int)};
            parameters[0].Value = model.tjxh;
            parameters[1].Value = model.fdjh;
            parameters[2].Value = model.zjrq;
            parameters[3].Value = model.jhbx;
            parameters[4].Value = model.gzfsdq;
            parameters[5].Value = model.dls;
            parameters[6].Value = model.xlc;
            parameters[7].Value = model.lxr;
            parameters[8].Value = model.xlctel;
            parameters[9].Value = model.xxfksj;
            parameters[10].Value = model.xxfkr;
            parameters[11].Value = model.gzxx;
            parameters[12].Value = model.gznr;
            parameters[13].Value = model.ID;
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
        #endregion




        #region 响应信息填写

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool XiangYing(YJUI.Model.TUJI model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TUJI set ");
            strSql.Append("fenlei=@fenlei,");
            strSql.Append("jjfh=@jjfh,");
            strSql.Append("gzms=@gzms,");
            strSql.Append("zdfx=@zdfx,");
            strSql.Append("gznr=@gznr,");
            strSql.Append("zpje=@zpje,");
            strSql.Append("xxzrr=@xxzrr,");
            strSql.Append("shclsj=@shclsj,");
            strSql.Append("shclyj=@shclyj ");
            strSql.Append("  where ID=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@fenlei",SqlDbType.VarChar,50),//1,分类 
                    new SqlParameter("@jjfh",SqlDbType.VarChar,50),//1,旧件返还
                    new SqlParameter("@gzms",SqlDbType.VarChar,500), //2,故障内容描述
                    new SqlParameter("@zdfx",SqlDbType.VarChar,500), //3,诊断分析
                    new SqlParameter("@gznr",SqlDbType.VarChar,500), //4,诊断内容
                    new SqlParameter("@zpje",SqlDbType.VarChar,50),//5,质赔金额 
                    new SqlParameter("@xxzrr", SqlDbType.VarChar,50),//6,售后处理人
					new SqlParameter("@shclsj", SqlDbType.VarChar,50),//7,售后处理时间
					new SqlParameter("@shclyj", SqlDbType.Text),   //8,售后处理意见售后完成情况
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.fenlei;
            parameters[1].Value = model.jjfh;
            parameters[2].Value = model.gzms;
            parameters[3].Value = model.zdfx;
            parameters[4].Value = model.gznr;
            parameters[5].Value = model.zpje;
            parameters[6].Value = model.xxzrr;
            parameters[7].Value = model.shclsj;
            parameters[8].Value = model.shclyj;
            parameters[9].Value = model.ID;


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
        #endregion

        #region 客服回访结果
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool HuiFang(YJUI.Model.TUJI model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TUJI set ");
            strSql.Append("thhfjg=@thhfjg ");
            strSql.Append("  where ID=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@thhfjg",SqlDbType.Text),//1,回访结果填写
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.thhfjg;
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

        #endregion

        #region 到货填写
        /// <summary>
        /// 到货填写
        /// </summary>
        public bool DaoHuo(YJUI.Model.TUJI model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TUJI set ");
            strSql.Append("dhqr=@dhqr,");
            strSql.Append("dhrq=@dhrq");

            strSql.Append("  where ID=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@dhqr",SqlDbType.VarChar),//到货确认
                    new SqlParameter("@dhrq",SqlDbType.VarChar), //到货日期
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.dhqr;
            parameters[1].Value = model.dhrq;
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

        #endregion

        #region 分库收货日期
        /// <summary>
        /// 分库收货日期
        /// </summary>
        public bool FenKuDaoHuo(YJUI.Model.TUJI model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TUJI set ");
            strSql.Append("fkname=@fkname,");
            strSql.Append("fkdhrq=@fkdhrq");

            strSql.Append("  where ID=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@fkname",SqlDbType.VarChar),//分库名称
                    new SqlParameter("@fkdhrq",SqlDbType.VarChar), //分库到货日期
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.fkname;
            parameters[1].Value = model.fkdhrq;
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



        #endregion
        #region 总库收货日期
        public bool ZkDaoHuo(YJUI.Model.TUJI model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TUJI set ");
            strSql.Append("dhrq=@dhrq");
            strSql.Append("  where ID=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@dhrq",SqlDbType.VarChar), //分库到货日期
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.dhrq;
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


        #endregion

        #region 工厂收货日期
        public bool GcDaoHuo(YJUI.Model.TUJI model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TUJI set ");
            strSql.Append("gongchangshrq=@gongchangshrq");
            strSql.Append("  where ID=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@gongchangshrq",SqlDbType.DateTime), //分库到货日期
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.gongchangshrq;
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
        #endregion

        #region 拆检反馈
        /// <summary>
        /// 拆检反馈
        /// </summary>
        public bool ChaiJian(YJUI.Model.TUJI model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TUJI set ");
            strSql.Append("cjrq=@cjrq,");
            strSql.Append("cjr=@cjr,");
            strSql.Append("cjfk=@cjfk,");
            strSql.Append("gzbw=@gzbw,");
            strSql.Append("zlpd=@zlpd,");
            strSql.Append("shcjqr=@shcjqr");
            strSql.Append("  where ID=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@cjrq",SqlDbType.VarChar),//
                    new SqlParameter("@cjr",SqlDbType.VarChar),//
                    new SqlParameter("@cjfk",SqlDbType.VarChar),//
                    new SqlParameter("@gzbw",SqlDbType.VarChar),//
                    new SqlParameter("@zlpd",SqlDbType.VarChar), 
                    new SqlParameter("@shcjqr",SqlDbType.VarChar), 
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.cjrq;
            parameters[1].Value = model.cjr;
            parameters[2].Value = model.cjfk;//拆检结果
            parameters[3].Value = model.gzbw;
            parameters[4].Value = model.zlpd;
            parameters[5].Value = model.shcjqr;
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

        #endregion

        #region 问题整改
        /// <summary>
        /// 问题整改
        /// </summary>
        public bool ZhengGai(YJUI.Model.TUJI model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TUJI set ");
            strSql.Append("gjzrr=@gjzrr,");
            strSql.Append("gjfa=@gjfa,");
            strSql.Append("gjrq=@gjrq,");

            strSql.Append("kcclcs=@kcclcs,");
            strSql.Append("kcwcrq=@kcwcrq,");
            strSql.Append("gysclcs=@gysclcs,");
            strSql.Append("gyswcrq=@gyswcrq,");
            strSql.Append("nblcgs=@nblcgs,");
            strSql.Append("nblcwcrq=@nblcwcrq,");

            strSql.Append("qtgjcs=@qtgjcs,");
            strSql.Append("qtwcrq=@qtwcrq,");
            strSql.Append("bs=@bs");

            strSql.Append("  where ID=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@gjzrr",SqlDbType.VarChar),//
                    new SqlParameter("@gjfa",SqlDbType.Text),//
                    new SqlParameter("@gjrq",SqlDbType.VarChar),//
                    new SqlParameter("@kcclcs",SqlDbType.Text),//
                    new SqlParameter("@kcwcrq",SqlDbType.VarChar), 
                    new SqlParameter("@gysclcs",SqlDbType.Text),//
                    new SqlParameter("@gyswcrq",SqlDbType.VarChar),//
                    new SqlParameter("@nblcgs",SqlDbType.Text),//
                    new SqlParameter("@nblcwcrq",SqlDbType.VarChar),//
                    new SqlParameter("@qtgjcs",SqlDbType.Text),//
                    new SqlParameter("@qtwcrq",SqlDbType.VarChar),//
                    new SqlParameter("@bs",SqlDbType.NVarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.gjzrr;
            parameters[1].Value = model.gjfa;
            parameters[2].Value = model.gjrq;//拆检结果
            parameters[3].Value = model.kcclcs;
            parameters[4].Value = model.kcwcrq;
            parameters[5].Value = model.gysclcs;
            parameters[6].Value = model.gyswcrq;
            parameters[7].Value = model.nblcgs;
            parameters[8].Value = model.nblcwcrq;
            parameters[9].Value = model.qtgjcs;
            parameters[10].Value = model.qtwcrq;
            parameters[11].Value = model.bs;
            parameters[12].Value = model.ID;
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

        #endregion

        #region 产品部确认
        /// <summary>
        /// 产品部确认
        /// </summary>
        public bool ChanPinBu(YJUI.Model.TUJI model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TUJI set ");
            strSql.Append("cpbqr=@cpbqr,");
            strSql.Append("cpbrq=@cpbrq");
            strSql.Append("  where ID=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@cpbqr",SqlDbType.VarChar,500),//
                    new SqlParameter("@cpbrq",SqlDbType.VarChar),//
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.cpbqr;
            parameters[1].Value = model.cpbrq;
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
        #endregion

        #region 工厂确认
        /// <summary>
        /// 工厂确认
        /// </summary>
        public bool GongChang(YJUI.Model.TUJI model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TUJI set ");
            strSql.Append("gcqr=@gcqr,");
            strSql.Append("gcqrrq=@gcqrrq");
            strSql.Append("  where ID=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@gcqr",SqlDbType.VarChar,500),//
                    new SqlParameter("@gcqrrq",SqlDbType.VarChar),//
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.gcqr;
            parameters[1].Value = model.gcqrrq;
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
        #endregion

        #region  ExtensionMethod
        public DataTable GetList(int PageSize, int PageIndex, string strWhere, string fldName, string strOrder)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format(" SELECT TOP {0} {1} FROM TUJI ", PageSize, fldName));
            sb.Append(string.Format("WHERE {0}  and (ID NOT IN", strWhere));
            sb.Append(string.Format(" (SELECT TOP {0} ID FROM TUJI where {1}", PageSize * (PageIndex - 1), strWhere));
            sb.Append(string.Format(" ORDER BY {0}))", strOrder));
            sb.Append(string.Format(" ORDER BY {0}", strOrder));
            return DbHelperSQL.Query(sb.ToString()).Tables[0];
        }
        public int getDataCount(string strWhere)
        {
            string sql = string.Format("select count(*) from  TUJI where {0}", strWhere);
            return Convert.ToInt32(DbHelperSQL.GetSingle(sql));
        }
        #endregion  ExtensionMethod
    }
}

