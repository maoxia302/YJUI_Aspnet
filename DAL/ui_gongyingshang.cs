using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using YJUI.DBUtility;

namespace YJUI.DAL
{
    /// <summary>
    /// 数据访问类:ui_gongyingshang
    /// </summary>
    public partial class ui_gongyingshang
    {
        public ui_gongyingshang()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ui_gongyingshang");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 返回一个flag结果
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetFlagById(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select flag from ui_gongyingshang");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;
            DataTable dataTable = DbHelperSQL.Query(strSql.ToString(), parameters).Tables[0];
            //string value = dt.Rows[第几行]["字段名"].ToString(); 
            int value = int.Parse(dataTable.Rows[0]["flag"].ToString()); 
            return value;
        }
        /// <summary>
        /// 添加供应商到货信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_info(YJUI.Model.ui_gongyingshang model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ui_gongyingshang(");
            strSql.Append("regdate,regperson,yddate,dep,cate,category,suppliername,total,flag,lastdate)");
            strSql.Append(" values (");
            strSql.Append("@regdate,@regperson,@yddate,@dep,@cate,@category,@suppliername,@total,@flag,@lastdate)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters =
            {
                new SqlParameter("@regdate",SqlDbType.DateTime),
                //new SqlParameter("@arrdate",SqlDbType.DateTime),
                new SqlParameter("@yddate",SqlDbType.DateTime),
                new SqlParameter("@regperson",SqlDbType.VarChar,50),
                new SqlParameter("@dep",SqlDbType.VarChar,50),
                 new SqlParameter("@cate",SqlDbType.VarChar,50),
                new SqlParameter("@category",SqlDbType.VarChar,50),
                new SqlParameter("@suppliername",SqlDbType.VarChar,50),
                new SqlParameter("@total",SqlDbType.Decimal),
                new SqlParameter("@flag",SqlDbType.Int), 
                new SqlParameter("@lastdate",SqlDbType.DateTime)
            };
            parameters[0].Value = model.regdate;
            //parameters[1].Value = model.arrdate;
            parameters[1].Value = model.yddate;
            parameters[2].Value = model.regperson;
            parameters[3].Value = model.dep;
            parameters[4].Value = model.cate;
            parameters[5].Value = model.category;
            parameters[6].Value = model.suppliername;
            parameters[7].Value = model.total;
            parameters[8].Value = model.flag;
            parameters[9].Value = model.lastdate;
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
        /// 添加到货信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_DaoHuo(YJUI.Model.ui_gongyingshang model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_gongyingshang set  ");
            strSql.Append("arrdate=@arrdate,");
            strSql.Append("arrperson=@arrperson, ");
            strSql.Append("arr_date=@arr_date,");
            strSql.Append("arr_remark=@arr_remark,");
            strSql.Append("flag=@flag, ");
            strSql.Append("lastdate=@lastdate ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters =
            {
					new SqlParameter("@arrdate", SqlDbType.DateTime),
					new SqlParameter("@arrperson", SqlDbType.NVarChar,50),
                    new SqlParameter("@arr_date",SqlDbType.DateTime), 
                    new SqlParameter("@arr_remark", SqlDbType.NVarChar,200),
                    new SqlParameter("@flag",SqlDbType.Int), 
                    new SqlParameter("@lastdate",SqlDbType.DateTime), 
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = model.arrdate;
            parameters[1].Value = model.arrperson;
            parameters[2].Value = model.arr_date;
            parameters[3].Value = model.arr_remark;
            parameters[4].Value = model.flag;
            parameters[5].Value = model.lastdate;
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
        /// 添加卸车信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_XieChe(YJUI.Model.ui_gongyingshang model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_gongyingshang set ");
            strSql.Append("uploadrealdate=@uploadrealdate,");
            strSql.Append("uploadperson=@uploadperson,");
            strSql.Append("uploaddate=@uploaddate, ");
            strSql.Append("uploadremark=@uploadremark,");
            strSql.Append("flag=@flag, ");
            strSql.Append("lastdate=@lastdate ");
            strSql.Append(" where id=@id");

            SqlParameter[] parameters =
            {
					new SqlParameter("@uploadrealdate", SqlDbType.DateTime),
					new SqlParameter("@uploadperson", SqlDbType.NVarChar,50),
              
                    new SqlParameter("@uploaddate", SqlDbType.DateTime),
                    new SqlParameter("@uploadremark",SqlDbType.NVarChar,200), 
                    new SqlParameter("@flag",SqlDbType.Int), 
                    new SqlParameter("@lastdate",SqlDbType.DateTime), 
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = model.uploadrealdate;
            parameters[1].Value = model.uploadperson;
            parameters[2].Value = model.uploaddate;
            parameters[3].Value = model.uploadremark;
            parameters[4].Value = model.flag;
            parameters[5].Value = model.lastdate;
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
        #region 添加未成品收货信息
        /// <summary>
        /// 添加未成品收货信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_WshouHuo(YJUI.Model.ui_gongyingshang model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_gongyingshang set ");
            strSql.Append("wRecrealdate=@wRecrealdate,");
            strSql.Append("wRecperson=@wRecperson,");
            //strSql.Append("wRecnums=@wRecnums,");
           // strSql.Append("wRecnum=@wRecnum,");
            strSql.Append("wRecremark=@wRecremark,");
            strSql.Append("wRecdate=@wRecdate,");
            strSql.Append("flag=@flag,");
            strSql.Append("lastdate=@lastdate");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters =
            {
                    new SqlParameter("@wRecrealdate", SqlDbType.DateTime),
					new SqlParameter("@wRecperson", SqlDbType.NVarChar,50),
					//new SqlParameter("@wRecnum", SqlDbType.Decimal,9),
					new SqlParameter("@wRecremark", SqlDbType.NVarChar,200),
					new SqlParameter("@wRecdate", SqlDbType.DateTime),
                    new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@lastdate", SqlDbType.DateTime),
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = model.wRecrealdate;
            parameters[1].Value = model.wRecperson;
            // parameters[2].Value = model.wRecnums;
           // parameters[2].Value = model.wRecnum;
            parameters[2].Value = model.wRecremark;
            parameters[3].Value = model.wRecdate;
            parameters[4].Value = model.flag;
            parameters[5].Value = model.lastdate;
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
        #endregion

        #region 添加成品收货信息
        /// <summary>
        /// 添加成品收货信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_CshouHuo(YJUI.Model.ui_gongyingshang model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_gongyingshang set ");
            strSql.Append("cRecrealdate=@cRecrealdate,");
            strSql.Append("cRecperson=@cRecperson,");
            strSql.Append("cRecremark=@cRecremark,");
            strSql.Append("cRecdate=@cRecdate,");
            strSql.Append("flag=@flag,");
            strSql.Append("lastdate=@lastdate");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters =
            {
                    new SqlParameter("@cRecrealdate", SqlDbType.DateTime),
					new SqlParameter("@cRecperson", SqlDbType.NVarChar,50),
					new SqlParameter("@cRecremark", SqlDbType.NVarChar,200),
					new SqlParameter("@cRecdate", SqlDbType.DateTime),
                    new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@lastdate", SqlDbType.DateTime),
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = model.cRecrealdate;
            parameters[1].Value = model.cRecperson;
            parameters[2].Value = model.cRecremark;
            parameters[3].Value = model.cRecdate;
            parameters[4].Value = model.flag;
            parameters[5].Value = model.lastdate;
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
        #endregion

        #region 添加包装收货信息
        /// <summary>
        /// 添加包装收货信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_BshouHuo(YJUI.Model.ui_gongyingshang model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_gongyingshang set ");
            strSql.Append("bRecrealdate=@bRecrealdate,");
            strSql.Append("bRecperson=@bRecperson,");
            //strSql.Append("bRecnum=@bRecnum,");
            strSql.Append("bRecremark=@bRecremark,");
            strSql.Append("bRecdate=@bRecdate,");
            strSql.Append("flag=@flag,");
            strSql.Append("lastdate=@lastdate");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters =
            {
                    new SqlParameter("@bRecrealdate", SqlDbType.DateTime),
					new SqlParameter("@bRecperson", SqlDbType.NVarChar,50),
					//new SqlParameter("@bRecnum", SqlDbType.Decimal,9),
					new SqlParameter("@bRecremark", SqlDbType.NVarChar,200),
					new SqlParameter("@bRecdate", SqlDbType.DateTime),
                    new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@lastdate", SqlDbType.DateTime),
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = model.bRecrealdate;
            parameters[1].Value = model.bRecperson;
            // parameters[2].Value = model.wRecnums;
           // parameters[2].Value = model.bRecnum;
            parameters[2].Value = model.bRecremark;
            parameters[3].Value = model.bRecdate;
            parameters[4].Value = model.flag;
            parameters[5].Value = model.lastdate;
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
        #endregion

        #region 添加非自有收货信息
        /// <summary>
        /// 添加包装收货信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_FshouHuo(YJUI.Model.ui_gongyingshang model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_gongyingshang set ");
            strSql.Append("fRecrealdate=@fRecrealdate,");
            strSql.Append("fRecperson=@fRecperson,");
            //strSql.Append("fRecnum=@fRecnum,");
            strSql.Append("fRecremark=@fRecremark,");
            strSql.Append("fRecdate=@fRecdate,");
            strSql.Append("flag=@flag,");
            strSql.Append("lastdate=@lastdate");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters =
            {
                    new SqlParameter("@fRecrealdate", SqlDbType.DateTime),
					new SqlParameter("@fRecperson", SqlDbType.NVarChar,50),
					//new SqlParameter("@fRecnum", SqlDbType.Decimal,9),
					new SqlParameter("@fRecremark", SqlDbType.NVarChar,200),
					new SqlParameter("@fRecdate", SqlDbType.DateTime),
                    new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@lastdate", SqlDbType.DateTime),
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = model.fRecrealdate;
            parameters[1].Value = model.fRecperson;
            // parameters[2].Value = model.wRecnums;
            //parameters[2].Value = model.fRecnum;
            parameters[2].Value = model.fRecremark;
            parameters[3].Value = model.fRecdate;
            parameters[4].Value = model.flag;
            parameters[5].Value = model.lastdate;
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
        #endregion


        #region 添加非自有收货信息
        /// <summary>
        /// 添加包装收货信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_ZshouHuo(YJUI.Model.ui_gongyingshang model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_gongyingshang set ");
            strSql.Append("zRecrealdate=@zRecrealdate,");
            strSql.Append("zRecperson=@zRecperson,");
            //strSql.Append("zRecnum=@zRecnum,");
            strSql.Append("zRecremark=@zRecremark,");
            strSql.Append("zRecdate=@zRecdate,");
            strSql.Append("flag=@flag,");
            strSql.Append("lastdate=@lastdate");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters =
            {
                    new SqlParameter("@zRecrealdate", SqlDbType.DateTime),
					new SqlParameter("@zRecperson", SqlDbType.NVarChar,50),
					//new SqlParameter("@zRecnum", SqlDbType.Decimal,9),
					new SqlParameter("@zRecremark", SqlDbType.NVarChar,200),
					new SqlParameter("@zRecdate", SqlDbType.DateTime),
                    new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@lastdate", SqlDbType.DateTime),
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = model.zRecrealdate;
            parameters[1].Value = model.zRecperson;
            // parameters[2].Value = model.wRecnums;
            //parameters[2].Value = model.zRecnum;
            parameters[2].Value = model.zRecremark;
            parameters[3].Value = model.zRecdate;
            parameters[4].Value = model.flag;
            parameters[5].Value = model.lastdate;
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
        #endregion
        /// <summary>
        /// 第3部添加质检信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_ZhiJian(YJUI.Model.ui_gongyingshang model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_gongyingshang set ");
            strSql.Append("testrealdate=@testrealdate,");
            strSql.Append("testperson=@testperson,");
            strSql.Append("testdate=@testdate, ");
            strSql.Append("testremark=@testremark, ");
            strSql.Append("flag=@flag, ");
            strSql.Append("lastdate=@lastdate ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters =
            {
					new SqlParameter("@testrealdate", SqlDbType.DateTime),
					new SqlParameter("@testperson", SqlDbType.NVarChar,50),
					new SqlParameter("@testdate", SqlDbType.DateTime),
                    new SqlParameter("@testremark",SqlDbType.NVarChar,200), 
                    new SqlParameter("@flag",SqlDbType.Int,4), 
                    new SqlParameter("@lastdate",SqlDbType.DateTime), 
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = model.testrealdate;
            parameters[1].Value = model.testperson;
            parameters[2].Value = model.testdate;
            parameters[3].Value = model.testremark;
            parameters[4].Value = model.flag;
            parameters[5].Value = model.lastdate;
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
        /// 添加未成品信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_WeiChengPin(YJUI.Model.ui_gongyingshang model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_gongyingshang set ");
            strSql.Append("unfinishrealdate=@unfinishrealdate,");
            //strSql.Append("unfinishnum=@unfinishnum,");
            strSql.Append("unfinishperson=@unfinishperson,");
            strSql.Append("unfinishdate=@unfinishdate, ");
            strSql.Append("unfinishremark=@unfinishremark, ");
            strSql.Append("flag=@flag,");
            strSql.Append("lastdate=@lastdate ");

            strSql.Append(" where id=@id");
            SqlParameter[] parameters =
            {
					new SqlParameter("@unfinishrealdate", SqlDbType.DateTime),
					//new SqlParameter("@unfinishnum", SqlDbType.NVarChar,50),
					new SqlParameter("@unfinishperson", SqlDbType.NVarChar,50),
					new SqlParameter("@unfinishdate", SqlDbType.DateTime),
                    new SqlParameter("@unfinishremark",SqlDbType.NVarChar,200), 
                    new SqlParameter("@flag",SqlDbType.Int,4), 
                    new SqlParameter("@lastdate",SqlDbType.DateTime), 
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = model.unfinishrealdate;
            //parameters[1].Value = model.unfinishnum;
            parameters[1].Value = model.unfinishperson;
            parameters[2].Value = model.unfinishdate;
            parameters[3].Value = model.unfinishremark;
            parameters[4].Value = model.flag;
            parameters[5].Value = model.lastdate;
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
        /// 添加成品信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_ChengPin(YJUI.Model.ui_gongyingshang model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_gongyingshang set ");
            strSql.Append("finishrealdate=@finishrealdate,");
            //strSql.Append("finishnum=@finishnum,");
            strSql.Append("finishperson=@finishperson,");
            strSql.Append("finishdate=@finishdate,");
            strSql.Append("finishremark=@finishremark,");
            strSql.Append("flag=@flag,");
            strSql.Append("lastdate=@lastdate ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters =
            {
					new SqlParameter("@finishrealdate", SqlDbType.DateTime),
					//new SqlParameter("@finishnum", SqlDbType.NVarChar,50),
					new SqlParameter("@finishperson", SqlDbType.NVarChar,50),
					new SqlParameter("@finishdate", SqlDbType.DateTime),
                    new SqlParameter("@finishremark",SqlDbType.NVarChar,200), 
                    new SqlParameter("@flag",SqlDbType.Int,4), 
                    new SqlParameter("@lastdate",SqlDbType.DateTime), 
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = model.finishrealdate;
            //parameters[1].Value = model.finishnum;
            parameters[1].Value = model.finishperson;
            parameters[2].Value = model.finishdate;
            parameters[3].Value = model.finishremark;
            parameters[4].Value = model.flag;
            parameters[5].Value = model.lastdate;
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
        /// 添加成品信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_BaoZhuang(YJUI.Model.ui_gongyingshang model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_gongyingshang set ");
            strSql.Append("packrealdate=@packrealdate,");
           // strSql.Append("packnum=@packnum,");
            strSql.Append("packperson=@packperson,");
            strSql.Append("packdate=@packdate,");
            strSql.Append("packremark=@packremark,");
            strSql.Append("flag=@flag,");
            strSql.Append("lastdate=@lastdate ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters =
            {
					new SqlParameter("@packrealdate", SqlDbType.DateTime),
					//new SqlParameter("@packnum", SqlDbType.NVarChar,50),
					new SqlParameter("@packperson", SqlDbType.NVarChar,50),
					new SqlParameter("@packdate", SqlDbType.DateTime),
                    new SqlParameter("@packremark",SqlDbType.NVarChar,200), 
                    new SqlParameter("@flag",SqlDbType.Int,4), 
                    new SqlParameter("@lastdate",SqlDbType.DateTime), 
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = model.packrealdate;
            //parameters[1].Value = model.packnum;
            parameters[1].Value = model.packperson;
            parameters[2].Value = model.packdate;
            parameters[3].Value = model.packremark;
            parameters[4].Value = model.flag;
            parameters[5].Value = model.lastdate;
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
        /// 添加非自有信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_FeiZiYou(YJUI.Model.ui_gongyingshang model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_gongyingshang set ");
            strSql.Append("noselfrealdate=@noselfrealdate,");
            //strSql.Append("noselfnum=@noselfnum,");
            strSql.Append("noselfperson=@noselfperson,");
            strSql.Append("noselfdate=@noselfdate, ");
            strSql.Append("noselfremark=@noselfremark, ");
            strSql.Append("flag=@flag,");
            strSql.Append("lastdate=@lastdate ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters =
            {
					new SqlParameter("@noselfrealdate", SqlDbType.DateTime),
					//new SqlParameter("@noselfnum", SqlDbType.NVarChar,50),
					new SqlParameter("@noselfperson", SqlDbType.NVarChar,50),
					new SqlParameter("@noselfdate", SqlDbType.DateTime),
                    new SqlParameter("@noselfremark",SqlDbType.NVarChar,200), 
                    new SqlParameter("@flag",SqlDbType.Int,4), 
                    new SqlParameter("@lastdate",SqlDbType.DateTime), 
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = model.noselfrealdate;
            //parameters[1].Value = model.noselfnum;
            parameters[1].Value = model.noselfperson;
            parameters[2].Value = model.noselfdate;
            parameters[3].Value = model.noselfremark;
            parameters[4].Value = model.flag;
            parameters[5].Value = model.lastdate;
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
        /// 添加非自有信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_ZengPin(YJUI.Model.ui_gongyingshang model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_gongyingshang set ");
            strSql.Append("giftrealdate=@giftrealdate,");
           // strSql.Append("giftnum=@giftnum,");
            strSql.Append("giftperson=@giftperson,");
            strSql.Append("giftdate=@giftdate, ");
            strSql.Append("giftremark=@giftremark, ");
            strSql.Append("flag=@flag,");
            strSql.Append("lastdate=@lastdate ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters =
            {
					new SqlParameter("@giftrealdate", SqlDbType.DateTime),
					//new SqlParameter("@giftnum", SqlDbType.NVarChar,50),
					new SqlParameter("@giftperson", SqlDbType.NVarChar,50),
					new SqlParameter("@giftdate", SqlDbType.DateTime),
                    new SqlParameter("@giftremark",SqlDbType.NVarChar,200), 
                    new SqlParameter("@flag",SqlDbType.Int,4), 
                    new SqlParameter("@lastdate",SqlDbType.DateTime), 
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = model.giftrealdate;
            //parameters[1].Value = model.giftnum;
            parameters[1].Value = model.giftperson;
            parameters[2].Value = model.giftdate;
            parameters[3].Value = model.giftremark;
            parameters[4].Value = model.flag;
            parameters[5].Value = model.lastdate;
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
        /// 添加不良品信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_BuLiangPin(YJUI.Model.ui_gongyingshang model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_gongyingshang set ");
            strSql.Append("badrealdate=@badrealdate,");
            //strSql.Append("badnum=@badnum,");
            strSql.Append("badperson=@badperson,");
            strSql.Append("baddate=@baddate, ");
            strSql.Append("badremark=@badremark, ");
            strSql.Append("flag=@flag,");
            strSql.Append("lastdate=@lastdate ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters =
            {
					new SqlParameter("@badrealdate", SqlDbType.DateTime),
					//new SqlParameter("@badnum", SqlDbType.NVarChar,50),
					new SqlParameter("@badperson", SqlDbType.NVarChar,50),
					new SqlParameter("@baddate", SqlDbType.DateTime),
                    new SqlParameter("@badremark",SqlDbType.NVarChar,200), 
                    new SqlParameter("@flag",SqlDbType.Int,4), 
                    new SqlParameter("@lastdate",SqlDbType.DateTime),
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = model.badrealdate;
            //parameters[1].Value = model.badnum;
            parameters[1].Value = model.badperson;
            parameters[2].Value = model.baddate;
            parameters[3].Value = model.badremark;
            parameters[4].Value = model.flag;
            parameters[5].Value = model.lastdate;
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
        /// 添加重工信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_ChongGong(YJUI.Model.ui_gongyingshang model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_gongyingshang set ");
            strSql.Append("reworkrealdate=@reworkrealdate,");
            //strSql.Append("reworknum=@reworknum,");
            strSql.Append("reworkperson=@reworkperson,");
            strSql.Append("reworkdate=@reworkdate,");
            strSql.Append("reworkremark=@reworkremark,");
            strSql.Append("flag=@flag,");
            strSql.Append("lastdate=@lastdate ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters =
            {
					new SqlParameter("@reworkrealdate", SqlDbType.DateTime),
					//new SqlParameter("@reworknum", SqlDbType.NVarChar,50),
					new SqlParameter("@reworkperson", SqlDbType.NVarChar,50),
					new SqlParameter("@reworkdate", SqlDbType.DateTime),
                    new SqlParameter("@reworkremark",SqlDbType.NVarChar,200), 
                    new SqlParameter("@flag",SqlDbType.Int,4), 
                    new SqlParameter("@lastdate",SqlDbType.DateTime),
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = model.reworkrealdate;
           // parameters[1].Value = model.reworknum;
            parameters[1].Value = model.reworkperson;
            parameters[2].Value = model.reworkdate;
            parameters[3].Value = model.reworkremark;
            parameters[4].Value = model.flag;
            parameters[5].Value = model.lastdate;
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
        /// 添加重工信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add_ChouCha(YJUI.Model.ui_gongyingshang model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ui_gongyingshang set ");
            strSql.Append("checkperson=@checkperson,");
            strSql.Append("checkdate=@checkdate,");
            strSql.Append("checkremark=@checkremark");
            strSql.Append("  where id=@id");
            SqlParameter[] parameters =
            {
					new SqlParameter("@checkperson", SqlDbType.NVarChar,50),
					new SqlParameter("@checkdate", SqlDbType.DateTime),
                    new SqlParameter("@checkremark",SqlDbType.NVarChar,200), 
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = model.checkperson;
            parameters[1].Value = model.checkdate;
            parameters[2].Value = model.checkremark;
            parameters[3].Value = model.id;
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
            strSql.Append("delete from ui_gongyingshang ");
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
        /// 更新步骤的标准时间
        /// </summary>
        /// <param name="id">信息ID</param>
        /// <param name="stepid">步骤ID</param>
        /// <returns></returns>
        public int UpdateStdDate(int id, int stepid)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@id",SqlDbType.Int,4),
                new SqlParameter("@stepid",SqlDbType.Int,4) 
            };
            parameters[0].Value = id;
            parameters[1].Value = stepid;
            return DbHelperSQL.ExcuteCommandReturnInt("save_gongyingshang", CommandType.StoredProcedure, parameters);


        }


        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ui_gongyingshang ");
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
        public YJUI.Model.ui_gongyingshang GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,regdate,arrdate,dep,category,suppliername,suppliertel,total,uploadstddate,uploadrealdate,uploadnum,uploadperson,uploaddate,recstddate,recrealdate,recnum,recperson,recdate,teststddate,testrealdate,testperson,testdate,unfinishstddate,unfinishrealdate,unfinishnum,unfinishperson,unfinishdate,finishstddate,finishrealdate,finishnum,finishperson,finishdate,packstddate,packrealdate,packnum,packperson,packdate,noselfstddate,noselfrealdate,noselfnum,noselfperson,noselfdate,badstddate,badrealdate,badnum,badperson,baddate,reworkstddate,reworkrealdate,reworknum,reworkperson,reworkdate,totalstddate,totalrealdate,checkcontent,checkperson,checkdate from ui_gongyingshang ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            YJUI.Model.ui_gongyingshang model = new YJUI.Model.ui_gongyingshang();
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
        public YJUI.Model.ui_gongyingshang DataRowToModel(DataRow row)
        {
            YJUI.Model.ui_gongyingshang model = new YJUI.Model.ui_gongyingshang();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["regdate"] != null && row["regdate"].ToString() != "")
                {
                    model.regdate = DateTime.Parse(row["regdate"].ToString());
                }
                if (row["arrdate"] != null && row["arrdate"].ToString() != "")
                {
                    model.arrdate = DateTime.Parse(row["arrdate"].ToString());
                }
                if (row["dep"] != null)
                {
                    model.dep = row["dep"].ToString();
                }
                if (row["category"] != null)
                {
                    model.category = row["category"].ToString();
                }
                if (row["suppliername"] != null)
                {
                    model.suppliername = row["suppliername"].ToString();
                }
                if (row["suppliertel"] != null)
                {
                    model.suppliertel = row["suppliertel"].ToString();
                }
                if (row["uploadstddate"] != null && row["uploadstddate"].ToString() != "")
                {
                    model.uploadstddate = DateTime.Parse(row["uploadstddate"].ToString());
                }
                if (row["uploadrealdate"] != null && row["uploadrealdate"].ToString() != "")
                {
                    model.uploadrealdate = DateTime.Parse(row["uploadrealdate"].ToString());
                }
                if (row["uploadnum"] != null)
                {
                    model.uploadnum = int.Parse(row["uploadnum"].ToString());
                }
                if (row["uploadperson"] != null)
                {
                    model.uploadperson = row["uploadperson"].ToString();
                }
                if (row["uploaddate"] != null && row["uploaddate"].ToString() != "")
                {
                    model.uploaddate = DateTime.Parse(row["uploaddate"].ToString());
                }
                if (row["teststddate"] != null && row["teststddate"].ToString() != "")
                {
                    model.teststddate = DateTime.Parse(row["teststddate"].ToString());
                }
                if (row["testrealdate"] != null && row["testrealdate"].ToString() != "")
                {
                    model.testrealdate = DateTime.Parse(row["testrealdate"].ToString());
                }
                if (row["testperson"] != null)
                {
                    model.testperson = row["testperson"].ToString();
                }
                if (row["testdate"] != null && row["testdate"].ToString() != "")
                {
                    model.testdate = DateTime.Parse(row["testdate"].ToString());
                }
                if (row["unfinishstddate"] != null && row["unfinishstddate"].ToString() != "")
                {
                    model.unfinishstddate = DateTime.Parse(row["unfinishstddate"].ToString());
                }
                if (row["unfinishrealdate"] != null && row["unfinishrealdate"].ToString() != "")
                {
                    model.unfinishrealdate = DateTime.Parse(row["unfinishrealdate"].ToString());
                }
                if (row["unfinishnum"] != null)
                {
                    model.unfinishnum = int.Parse(row["unfinishnum"].ToString());
                }
                if (row["unfinishperson"] != null)
                {
                    model.unfinishperson = row["unfinishperson"].ToString();
                }
                if (row["unfinishdate"] != null && row["unfinishdate"].ToString() != "")
                {
                    model.unfinishdate = DateTime.Parse(row["unfinishdate"].ToString());
                }
                if (row["finishstddate"] != null && row["finishstddate"].ToString() != "")
                {
                    model.finishstddate = DateTime.Parse(row["finishstddate"].ToString());
                }
                if (row["finishrealdate"] != null && row["finishrealdate"].ToString() != "")
                {
                    model.finishrealdate = DateTime.Parse(row["finishrealdate"].ToString());
                }
                if (row["finishnum"] != null)
                {
                    model.finishnum = int.Parse(row["finishnum"].ToString());
                }
                if (row["finishperson"] != null)
                {
                    model.finishperson = row["finishperson"].ToString();
                }
                if (row["finishdate"] != null && row["finishdate"].ToString() != "")
                {
                    model.finishdate = DateTime.Parse(row["finishdate"].ToString());
                }
                if (row["packstddate"] != null && row["packstddate"].ToString() != "")
                {
                    model.packstddate = DateTime.Parse(row["packstddate"].ToString());
                }
                if (row["packrealdate"] != null && row["packrealdate"].ToString() != "")
                {
                    model.packrealdate = DateTime.Parse(row["packrealdate"].ToString());
                }
                if (row["packnum"] != null)
                {
                    model.packnum = int.Parse(row["packnum"].ToString());
                }
                if (row["packperson"] != null)
                {
                    model.packperson = row["packperson"].ToString();
                }
                if (row["packdate"] != null && row["packdate"].ToString() != "")
                {
                    model.packdate = DateTime.Parse(row["packdate"].ToString());
                }
                if (row["noselfstddate"] != null && row["noselfstddate"].ToString() != "")
                {
                    model.noselfstddate = DateTime.Parse(row["noselfstddate"].ToString());
                }
                if (row["noselfrealdate"] != null && row["noselfrealdate"].ToString() != "")
                {
                    model.noselfrealdate = DateTime.Parse(row["noselfrealdate"].ToString());
                }
                if (row["noselfnum"] != null)
                {
                    model.noselfnum = int.Parse(row["noselfnum"].ToString());
                }
                if (row["noselfperson"] != null)
                {
                    model.noselfperson = row["noselfperson"].ToString();
                }
                if (row["noselfdate"] != null && row["noselfdate"].ToString() != "")
                {
                    model.noselfdate = DateTime.Parse(row["noselfdate"].ToString());
                }
                if (row["badstddate"] != null && row["badstddate"].ToString() != "")
                {
                    model.badstddate = DateTime.Parse(row["badstddate"].ToString());
                }
                if (row["badrealdate"] != null && row["badrealdate"].ToString() != "")
                {
                    model.badrealdate = DateTime.Parse(row["badrealdate"].ToString());
                }
                if (row["badnum"] != null)
                {
                    model.badnum = int.Parse(row["badnum"].ToString());
                }
                if (row["badperson"] != null)
                {
                    model.badperson = row["badperson"].ToString();
                }
                if (row["baddate"] != null && row["baddate"].ToString() != "")
                {
                    model.baddate = DateTime.Parse(row["baddate"].ToString());
                }
                if (row["reworkstddate"] != null && row["reworkstddate"].ToString() != "")
                {
                    model.reworkstddate = DateTime.Parse(row["reworkstddate"].ToString());
                }
                if (row["reworkrealdate"] != null && row["reworkrealdate"].ToString() != "")
                {
                    model.reworkrealdate = DateTime.Parse(row["reworkrealdate"].ToString());
                }
                if (row["reworknum"] != null)
                {
                    model.reworknum = int.Parse(row["reworknum"].ToString());
                }
                if (row["reworkperson"] != null)
                {
                    model.reworkperson = row["reworkperson"].ToString();
                }
                if (row["reworkdate"] != null)
                {
                    model.reworkdate = DateTime.Parse(row["reworkdate"].ToString());
                }
                if (row["totalstddate"] != null && row["totalstddate"].ToString() != "")
                {
                    model.totalstddate = DateTime.Parse(row["totalstddate"].ToString());
                }
                if (row["totalrealdate"] != null && row["totalrealdate"].ToString() != "")
                {
                    model.totalrealdate = DateTime.Parse(row["totalrealdate"].ToString());
                }
                if (row["checkcontent"] != null)
                {
                    model.checkcontent = row["checkcontent"].ToString();
                }
                if (row["checkperson"] != null)
                {
                    model.checkperson = row["checkperson"].ToString();
                }
                if (row["checkdate"] != null && row["checkdate"].ToString() != "")
                {
                    model.checkdate = DateTime.Parse(row["checkdate"].ToString());
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
            strSql.Append("select id,regdate,arrdate,dep,category,suppliername,suppliertel,total,uploadstddate,uploadrealdate,uploadnum,uploadperson,uploaddate,recstddate,recrealdate,recnum,recperson,recdate,teststddate,testrealdate,testperson,testdate,unfinishstddate,unfinishrealdate,unfinishnum,unfinishperson,unfinishdate,finishstddate,finishrealdate,finishnum,finishperson,finishdate,packstddate,packrealdate,packnum,packperson,packdate,noselfstddate,noselfrealdate,noselfnum,noselfperson,noselfdate,badstddate,badrealdate,badnum,badperson,baddate,reworkstddate,reworkrealdate,reworknum,reworkperson,reworkdate,totalstddate,totalrealdate,checkcontent,checkperson,checkdate ");
            strSql.Append(" FROM ui_gongyingshang ");
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
            strSql.Append(" id,regdate,arrdate,dep,category,suppliername,suppliertel,total,uploadstddate,uploadrealdate,uploadnum,uploadperson,uploaddate,recstddate,recrealdate,recnum,recperson,recdate,teststddate,testrealdate,testperson,testdate,unfinishstddate,unfinishrealdate,unfinishnum,unfinishperson,unfinishdate,finishstddate,finishrealdate,finishnum,finishperson,finishdate,packstddate,packrealdate,packnum,packperson,packdate,noselfstddate,noselfrealdate,noselfnum,noselfperson,noselfdate,badstddate,badrealdate,badnum,badperson,baddate,reworkstddate,reworkrealdate,reworknum,reworkperson,reworkdate,totalstddate,totalrealdate,checkcontent,checkperson,checkdate ");
            strSql.Append(" FROM ui_gongyingshang ");
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
            strSql.Append("select count(1) FROM ui_gongyingshang ");
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
            strSql.Append(")AS Row, T.*  from ui_gongyingshang T ");
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
/// 存储过程分页查询
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


        public DataTable GetList(int PageSize, int PageIndex, string strWhere, string fldName, string strOrder)
        {
            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("select top {0} {1}  from  V_gongyingshang", PageSize, fldName));
            sb.Append(" where ( id not in");
            sb.Append(string.Format("(select top {0} id  from V_gongyingshang  where {1}", PageSize * (PageIndex - 1), strWhere));
            sb.Append(string.Format(" order By {0}))", strOrder));
            sb.Append(string.Format(" order by {0}", strOrder));
            return DbHelperSQL.Query(sb.ToString()).Tables[0];
        }
        public int getDataCount(string strWhere)
        {
            string sql = string.Format("select count(id) from V_gongyingshang where {0} ", strWhere);
            return Convert.ToInt32(DbHelperSQL.GetSingle(sql));
        }
        #endregion  ExtensionMethod
    }
}

