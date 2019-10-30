using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using YJUI.DBUtility;//Please add references
namespace YJUI.DAL
{
    /// <summary>
    /// 数据访问类:CMSME
    /// </summary>
    public partial class CMSME
    {
        public CMSME()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ME001)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CMSME");
            strSql.Append(" where ME001=@ME001 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ME001", SqlDbType.Char,6)            };
            parameters[0].Value = ME001;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YJUI.Model.CMSME model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CMSME(");
            strSql.Append("COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,ME001,ME002,ME003,ME004,ME005,ME006,ME007,ME008,ME009,ME010,ME011,ME012,ME013,ME014,ME015,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62)");
            strSql.Append(" values (");
            strSql.Append("@COMPANY,@CREATOR,@USR_GROUP,@CREATE_DATE,@MODIFIER,@MODI_DATE,@FLAG,@ME001,@ME002,@ME003,@ME004,@ME005,@ME006,@ME007,@ME008,@ME009,@ME010,@ME011,@ME012,@ME013,@ME014,@ME015,@UDF01,@UDF02,@UDF03,@UDF04,@UDF05,@UDF06,@UDF51,@UDF52,@UDF53,@UDF54,@UDF55,@UDF56,@UDF07,@UDF08,@UDF09,@UDF10,@UDF11,@UDF12,@UDF57,@UDF58,@UDF59,@UDF60,@UDF61,@UDF62)");
            SqlParameter[] parameters = {
                    new SqlParameter("@COMPANY", SqlDbType.Char,10),
                    new SqlParameter("@CREATOR", SqlDbType.Char,10),
                    new SqlParameter("@USR_GROUP", SqlDbType.Char,10),
                    new SqlParameter("@CREATE_DATE", SqlDbType.Char,17),
                    new SqlParameter("@MODIFIER", SqlDbType.Char,10),
                    new SqlParameter("@MODI_DATE", SqlDbType.Char,17),
                    new SqlParameter("@FLAG", SqlDbType.Decimal,5),
                    new SqlParameter("@ME001", SqlDbType.Char,6),
                    new SqlParameter("@ME002", SqlDbType.Char,20),
                    new SqlParameter("@ME003", SqlDbType.VarChar,255),
                    new SqlParameter("@ME004", SqlDbType.Char,20),
                    new SqlParameter("@ME005", SqlDbType.Char,1),
                    new SqlParameter("@ME006", SqlDbType.Char,1),
                    new SqlParameter("@ME007", SqlDbType.Char,12),
                    new SqlParameter("@ME008", SqlDbType.Char,1),
                    new SqlParameter("@ME009", SqlDbType.Char,1),
                    new SqlParameter("@ME010", SqlDbType.Char,8),
                    new SqlParameter("@ME011", SqlDbType.VarChar,30),
                    new SqlParameter("@ME012", SqlDbType.Decimal,9),
                    new SqlParameter("@ME013", SqlDbType.Decimal,9),
                    new SqlParameter("@ME014", SqlDbType.Decimal,9),
                    new SqlParameter("@ME015", SqlDbType.Char,1),
                    new SqlParameter("@UDF01", SqlDbType.VarChar,255),
                    new SqlParameter("@UDF02", SqlDbType.VarChar,255),
                    new SqlParameter("@UDF03", SqlDbType.VarChar,255),
                    new SqlParameter("@UDF04", SqlDbType.VarChar,255),
                    new SqlParameter("@UDF05", SqlDbType.VarChar,255),
                    new SqlParameter("@UDF06", SqlDbType.VarChar,255),
                    new SqlParameter("@UDF51", SqlDbType.Decimal,9),
                    new SqlParameter("@UDF52", SqlDbType.Decimal,9),
                    new SqlParameter("@UDF53", SqlDbType.Decimal,9),
                    new SqlParameter("@UDF54", SqlDbType.Decimal,9),
                    new SqlParameter("@UDF55", SqlDbType.Decimal,9),
                    new SqlParameter("@UDF56", SqlDbType.Decimal,9),
                    new SqlParameter("@UDF07", SqlDbType.VarChar,255),
                    new SqlParameter("@UDF08", SqlDbType.VarChar,255),
                    new SqlParameter("@UDF09", SqlDbType.VarChar,255),
                    new SqlParameter("@UDF10", SqlDbType.VarChar,255),
                    new SqlParameter("@UDF11", SqlDbType.VarChar,255),
                    new SqlParameter("@UDF12", SqlDbType.VarChar,255),
                    new SqlParameter("@UDF57", SqlDbType.Decimal,9),
                    new SqlParameter("@UDF58", SqlDbType.Decimal,9),
                    new SqlParameter("@UDF59", SqlDbType.Decimal,9),
                    new SqlParameter("@UDF60", SqlDbType.Decimal,9),
                    new SqlParameter("@UDF61", SqlDbType.Decimal,9),
                    new SqlParameter("@UDF62", SqlDbType.Decimal,9)};
            parameters[0].Value = model.COMPANY;
            parameters[1].Value = model.CREATOR;
            parameters[2].Value = model.USR_GROUP;
            parameters[3].Value = model.CREATE_DATE;
            parameters[4].Value = model.MODIFIER;
            parameters[5].Value = model.MODI_DATE;
            parameters[6].Value = model.FLAG;
            parameters[7].Value = model.ME001;
            parameters[8].Value = model.ME002;
            parameters[9].Value = model.ME003;
            parameters[10].Value = model.ME004;
            parameters[11].Value = model.ME005;
            parameters[12].Value = model.ME006;
            parameters[13].Value = model.ME007;
            parameters[14].Value = model.ME008;
            parameters[15].Value = model.ME009;
            parameters[16].Value = model.ME010;
            parameters[17].Value = model.ME011;
            parameters[18].Value = model.ME012;
            parameters[19].Value = model.ME013;
            parameters[20].Value = model.ME014;
            parameters[21].Value = model.ME015;
            parameters[22].Value = model.UDF01;
            parameters[23].Value = model.UDF02;
            parameters[24].Value = model.UDF03;
            parameters[25].Value = model.UDF04;
            parameters[26].Value = model.UDF05;
            parameters[27].Value = model.UDF06;
            parameters[28].Value = model.UDF51;
            parameters[29].Value = model.UDF52;
            parameters[30].Value = model.UDF53;
            parameters[31].Value = model.UDF54;
            parameters[32].Value = model.UDF55;
            parameters[33].Value = model.UDF56;
            parameters[34].Value = model.UDF07;
            parameters[35].Value = model.UDF08;
            parameters[36].Value = model.UDF09;
            parameters[37].Value = model.UDF10;
            parameters[38].Value = model.UDF11;
            parameters[39].Value = model.UDF12;
            parameters[40].Value = model.UDF57;
            parameters[41].Value = model.UDF58;
            parameters[42].Value = model.UDF59;
            parameters[43].Value = model.UDF60;
            parameters[44].Value = model.UDF61;
            parameters[45].Value = model.UDF62;

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
        public bool Update(YJUI.Model.CMSME model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CMSME set ");
            strSql.Append("COMPANY=@COMPANY,");
            strSql.Append("CREATOR=@CREATOR,");
            strSql.Append("USR_GROUP=@USR_GROUP,");
            strSql.Append("CREATE_DATE=@CREATE_DATE,");
            strSql.Append("MODIFIER=@MODIFIER,");
            strSql.Append("MODI_DATE=@MODI_DATE,");
            strSql.Append("FLAG=@FLAG,");
            strSql.Append("ME002=@ME002,");
            strSql.Append("ME003=@ME003,");
            strSql.Append("ME004=@ME004,");
            strSql.Append("ME005=@ME005,");
            strSql.Append("ME006=@ME006,");
            strSql.Append("ME007=@ME007,");
            strSql.Append("ME008=@ME008,");
            strSql.Append("ME009=@ME009,");
            strSql.Append("ME010=@ME010,");
            strSql.Append("ME011=@ME011,");
            strSql.Append("ME012=@ME012,");
            strSql.Append("ME013=@ME013,");
            strSql.Append("ME014=@ME014,");
            strSql.Append("ME015=@ME015,");
            strSql.Append("UDF01=@UDF01,");
            strSql.Append("UDF02=@UDF02,");
            strSql.Append("UDF03=@UDF03,");
            strSql.Append("UDF04=@UDF04,");
            strSql.Append("UDF05=@UDF05,");
            strSql.Append("UDF06=@UDF06,");
            strSql.Append("UDF51=@UDF51,");
            strSql.Append("UDF52=@UDF52,");
            strSql.Append("UDF53=@UDF53,");
            strSql.Append("UDF54=@UDF54,");
            strSql.Append("UDF55=@UDF55,");
            strSql.Append("UDF56=@UDF56,");
            strSql.Append("UDF07=@UDF07,");
            strSql.Append("UDF08=@UDF08,");
            strSql.Append("UDF09=@UDF09,");
            strSql.Append("UDF10=@UDF10,");
            strSql.Append("UDF11=@UDF11,");
            strSql.Append("UDF12=@UDF12,");
            strSql.Append("UDF57=@UDF57,");
            strSql.Append("UDF58=@UDF58,");
            strSql.Append("UDF59=@UDF59,");
            strSql.Append("UDF60=@UDF60,");
            strSql.Append("UDF61=@UDF61,");
            strSql.Append("UDF62=@UDF62");
            strSql.Append(" where ME001=@ME001 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@COMPANY", SqlDbType.Char,10),
                    new SqlParameter("@CREATOR", SqlDbType.Char,10),
                    new SqlParameter("@USR_GROUP", SqlDbType.Char,10),
                    new SqlParameter("@CREATE_DATE", SqlDbType.Char,17),
                    new SqlParameter("@MODIFIER", SqlDbType.Char,10),
                    new SqlParameter("@MODI_DATE", SqlDbType.Char,17),
                    new SqlParameter("@FLAG", SqlDbType.Decimal,5),
                    new SqlParameter("@ME002", SqlDbType.Char,20),
                    new SqlParameter("@ME003", SqlDbType.VarChar,255),
                    new SqlParameter("@ME004", SqlDbType.Char,20),
                    new SqlParameter("@ME005", SqlDbType.Char,1),
                    new SqlParameter("@ME006", SqlDbType.Char,1),
                    new SqlParameter("@ME007", SqlDbType.Char,12),
                    new SqlParameter("@ME008", SqlDbType.Char,1),
                    new SqlParameter("@ME009", SqlDbType.Char,1),
                    new SqlParameter("@ME010", SqlDbType.Char,8),
                    new SqlParameter("@ME011", SqlDbType.VarChar,30),
                    new SqlParameter("@ME012", SqlDbType.Decimal,9),
                    new SqlParameter("@ME013", SqlDbType.Decimal,9),
                    new SqlParameter("@ME014", SqlDbType.Decimal,9),
                    new SqlParameter("@ME015", SqlDbType.Char,1),
                    new SqlParameter("@UDF01", SqlDbType.VarChar,255),
                    new SqlParameter("@UDF02", SqlDbType.VarChar,255),
                    new SqlParameter("@UDF03", SqlDbType.VarChar,255),
                    new SqlParameter("@UDF04", SqlDbType.VarChar,255),
                    new SqlParameter("@UDF05", SqlDbType.VarChar,255),
                    new SqlParameter("@UDF06", SqlDbType.VarChar,255),
                    new SqlParameter("@UDF51", SqlDbType.Decimal,9),
                    new SqlParameter("@UDF52", SqlDbType.Decimal,9),
                    new SqlParameter("@UDF53", SqlDbType.Decimal,9),
                    new SqlParameter("@UDF54", SqlDbType.Decimal,9),
                    new SqlParameter("@UDF55", SqlDbType.Decimal,9),
                    new SqlParameter("@UDF56", SqlDbType.Decimal,9),
                    new SqlParameter("@UDF07", SqlDbType.VarChar,255),
                    new SqlParameter("@UDF08", SqlDbType.VarChar,255),
                    new SqlParameter("@UDF09", SqlDbType.VarChar,255),
                    new SqlParameter("@UDF10", SqlDbType.VarChar,255),
                    new SqlParameter("@UDF11", SqlDbType.VarChar,255),
                    new SqlParameter("@UDF12", SqlDbType.VarChar,255),
                    new SqlParameter("@UDF57", SqlDbType.Decimal,9),
                    new SqlParameter("@UDF58", SqlDbType.Decimal,9),
                    new SqlParameter("@UDF59", SqlDbType.Decimal,9),
                    new SqlParameter("@UDF60", SqlDbType.Decimal,9),
                    new SqlParameter("@UDF61", SqlDbType.Decimal,9),
                    new SqlParameter("@UDF62", SqlDbType.Decimal,9),
                    new SqlParameter("@ME001", SqlDbType.Char,6)};
            parameters[0].Value = model.COMPANY;
            parameters[1].Value = model.CREATOR;
            parameters[2].Value = model.USR_GROUP;
            parameters[3].Value = model.CREATE_DATE;
            parameters[4].Value = model.MODIFIER;
            parameters[5].Value = model.MODI_DATE;
            parameters[6].Value = model.FLAG;
            parameters[7].Value = model.ME002;
            parameters[8].Value = model.ME003;
            parameters[9].Value = model.ME004;
            parameters[10].Value = model.ME005;
            parameters[11].Value = model.ME006;
            parameters[12].Value = model.ME007;
            parameters[13].Value = model.ME008;
            parameters[14].Value = model.ME009;
            parameters[15].Value = model.ME010;
            parameters[16].Value = model.ME011;
            parameters[17].Value = model.ME012;
            parameters[18].Value = model.ME013;
            parameters[19].Value = model.ME014;
            parameters[20].Value = model.ME015;
            parameters[21].Value = model.UDF01;
            parameters[22].Value = model.UDF02;
            parameters[23].Value = model.UDF03;
            parameters[24].Value = model.UDF04;
            parameters[25].Value = model.UDF05;
            parameters[26].Value = model.UDF06;
            parameters[27].Value = model.UDF51;
            parameters[28].Value = model.UDF52;
            parameters[29].Value = model.UDF53;
            parameters[30].Value = model.UDF54;
            parameters[31].Value = model.UDF55;
            parameters[32].Value = model.UDF56;
            parameters[33].Value = model.UDF07;
            parameters[34].Value = model.UDF08;
            parameters[35].Value = model.UDF09;
            parameters[36].Value = model.UDF10;
            parameters[37].Value = model.UDF11;
            parameters[38].Value = model.UDF12;
            parameters[39].Value = model.UDF57;
            parameters[40].Value = model.UDF58;
            parameters[41].Value = model.UDF59;
            parameters[42].Value = model.UDF60;
            parameters[43].Value = model.UDF61;
            parameters[44].Value = model.UDF62;
            parameters[45].Value = model.ME001;

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
        public bool Delete(string ME001)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CMSME ");
            strSql.Append(" where ME001=@ME001 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ME001", SqlDbType.Char,6)            };
            parameters[0].Value = ME001;

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
        public bool DeleteList(string ME001list)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CMSME ");
            strSql.Append(" where ME001 in (" + ME001list + ")  ");
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
        public YJUI.Model.CMSME GetModel(string ME001)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,ME001,ME002,ME003,ME004,ME005,ME006,ME007,ME008,ME009,ME010,ME011,ME012,ME013,ME014,ME015,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62 from CMSME ");
            strSql.Append(" where ME001=@ME001 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ME001", SqlDbType.Char,6)            };
            parameters[0].Value = ME001;

            YJUI.Model.CMSME model = new YJUI.Model.CMSME();
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
        public YJUI.Model.CMSME DataRowToModel(DataRow row)
        {
            YJUI.Model.CMSME model = new YJUI.Model.CMSME();
            if (row != null)
            {
                if (row["COMPANY"] != null)
                {
                    model.COMPANY = row["COMPANY"].ToString();
                }
                if (row["CREATOR"] != null)
                {
                    model.CREATOR = row["CREATOR"].ToString();
                }
                if (row["USR_GROUP"] != null)
                {
                    model.USR_GROUP = row["USR_GROUP"].ToString();
                }
                if (row["CREATE_DATE"] != null)
                {
                    model.CREATE_DATE = row["CREATE_DATE"].ToString();
                }
                if (row["MODIFIER"] != null)
                {
                    model.MODIFIER = row["MODIFIER"].ToString();
                }
                if (row["MODI_DATE"] != null)
                {
                    model.MODI_DATE = row["MODI_DATE"].ToString();
                }
                if (row["FLAG"] != null && row["FLAG"].ToString() != "")
                {
                    model.FLAG = decimal.Parse(row["FLAG"].ToString());
                }
                if (row["ME001"] != null)
                {
                    model.ME001 = row["ME001"].ToString();
                }
                if (row["ME002"] != null)
                {
                    model.ME002 = row["ME002"].ToString();
                }
                if (row["ME003"] != null)
                {
                    model.ME003 = row["ME003"].ToString();
                }
                if (row["ME004"] != null)
                {
                    model.ME004 = row["ME004"].ToString();
                }
                if (row["ME005"] != null)
                {
                    model.ME005 = row["ME005"].ToString();
                }
                if (row["ME006"] != null)
                {
                    model.ME006 = row["ME006"].ToString();
                }
                if (row["ME007"] != null)
                {
                    model.ME007 = row["ME007"].ToString();
                }
                if (row["ME008"] != null)
                {
                    model.ME008 = row["ME008"].ToString();
                }
                if (row["ME009"] != null)
                {
                    model.ME009 = row["ME009"].ToString();
                }
                if (row["ME010"] != null)
                {
                    model.ME010 = row["ME010"].ToString();
                }
                if (row["ME011"] != null)
                {
                    model.ME011 = row["ME011"].ToString();
                }
                if (row["ME012"] != null && row["ME012"].ToString() != "")
                {
                    model.ME012 = decimal.Parse(row["ME012"].ToString());
                }
                if (row["ME013"] != null && row["ME013"].ToString() != "")
                {
                    model.ME013 = decimal.Parse(row["ME013"].ToString());
                }
                if (row["ME014"] != null && row["ME014"].ToString() != "")
                {
                    model.ME014 = decimal.Parse(row["ME014"].ToString());
                }
                if (row["ME015"] != null)
                {
                    model.ME015 = row["ME015"].ToString();
                }
                if (row["UDF01"] != null)
                {
                    model.UDF01 = row["UDF01"].ToString();
                }
                if (row["UDF02"] != null)
                {
                    model.UDF02 = row["UDF02"].ToString();
                }
                if (row["UDF03"] != null)
                {
                    model.UDF03 = row["UDF03"].ToString();
                }
                if (row["UDF04"] != null)
                {
                    model.UDF04 = row["UDF04"].ToString();
                }
                if (row["UDF05"] != null)
                {
                    model.UDF05 = row["UDF05"].ToString();
                }
                if (row["UDF06"] != null)
                {
                    model.UDF06 = row["UDF06"].ToString();
                }
                if (row["UDF51"] != null && row["UDF51"].ToString() != "")
                {
                    model.UDF51 = decimal.Parse(row["UDF51"].ToString());
                }
                if (row["UDF52"] != null && row["UDF52"].ToString() != "")
                {
                    model.UDF52 = decimal.Parse(row["UDF52"].ToString());
                }
                if (row["UDF53"] != null && row["UDF53"].ToString() != "")
                {
                    model.UDF53 = decimal.Parse(row["UDF53"].ToString());
                }
                if (row["UDF54"] != null && row["UDF54"].ToString() != "")
                {
                    model.UDF54 = decimal.Parse(row["UDF54"].ToString());
                }
                if (row["UDF55"] != null && row["UDF55"].ToString() != "")
                {
                    model.UDF55 = decimal.Parse(row["UDF55"].ToString());
                }
                if (row["UDF56"] != null && row["UDF56"].ToString() != "")
                {
                    model.UDF56 = decimal.Parse(row["UDF56"].ToString());
                }
                if (row["UDF07"] != null)
                {
                    model.UDF07 = row["UDF07"].ToString();
                }
                if (row["UDF08"] != null)
                {
                    model.UDF08 = row["UDF08"].ToString();
                }
                if (row["UDF09"] != null)
                {
                    model.UDF09 = row["UDF09"].ToString();
                }
                if (row["UDF10"] != null)
                {
                    model.UDF10 = row["UDF10"].ToString();
                }
                if (row["UDF11"] != null)
                {
                    model.UDF11 = row["UDF11"].ToString();
                }
                if (row["UDF12"] != null)
                {
                    model.UDF12 = row["UDF12"].ToString();
                }
                if (row["UDF57"] != null && row["UDF57"].ToString() != "")
                {
                    model.UDF57 = decimal.Parse(row["UDF57"].ToString());
                }
                if (row["UDF58"] != null && row["UDF58"].ToString() != "")
                {
                    model.UDF58 = decimal.Parse(row["UDF58"].ToString());
                }
                if (row["UDF59"] != null && row["UDF59"].ToString() != "")
                {
                    model.UDF59 = decimal.Parse(row["UDF59"].ToString());
                }
                if (row["UDF60"] != null && row["UDF60"].ToString() != "")
                {
                    model.UDF60 = decimal.Parse(row["UDF60"].ToString());
                }
                if (row["UDF61"] != null && row["UDF61"].ToString() != "")
                {
                    model.UDF61 = decimal.Parse(row["UDF61"].ToString());
                }
                if (row["UDF62"] != null && row["UDF62"].ToString() != "")
                {
                    model.UDF62 = decimal.Parse(row["UDF62"].ToString());
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
            strSql.Append("select COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,ME001,ME002,ME003,ME004,ME005,ME006,ME007,ME008,ME009,ME010,ME011,ME012,ME013,ME014,ME015,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62 ");
            strSql.Append(" FROM CMSME ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return VOCEN2018DbHelperSQL.Query(strSql.ToString());
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
            strSql.Append(" COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,ME001,ME002,ME003,ME004,ME005,ME006,ME007,ME008,ME009,ME010,ME011,ME012,ME013,ME014,ME015,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62 ");
            strSql.Append(" FROM CMSME ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return VOCEN2018DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM CMSME ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = VOCEN2018DbHelperSQL.GetSingle(strSql.ToString());
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
                strSql.Append("order by T.ME001 desc");
            }
            strSql.Append(")AS Row, T.*  from CMSME T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return VOCEN2018DbHelperSQL.Query(strSql.ToString());

        }


        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

