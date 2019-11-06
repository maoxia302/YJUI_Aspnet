using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using YJUI.DBUtility;//Please add references
namespace YJUI.DAL
{
    /// <summary>
    /// 数据访问类:CMSMC
    /// </summary>
    public partial class CMSMC
    {
        public CMSMC()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string MC001)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CMSMC");
            strSql.Append(" where MC001=@MC001 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@MC001", SqlDbType.Char,10)           };
            parameters[0].Value = MC001;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YJUI.Model.CMSMC model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CMSMC(");
            strSql.Append("COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,MC001,MC002,MC003,MC004,MC005,MC006,MC007,MC008,MC009,MC010,MC011,MC012,MC013,MC014,MC015,MC016,MC017,MC018,MC019,MC020,MC021,MC022,MC023,MC024,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62)");
            strSql.Append(" values (");
            strSql.Append("@COMPANY,@CREATOR,@USR_GROUP,@CREATE_DATE,@MODIFIER,@MODI_DATE,@FLAG,@MC001,@MC002,@MC003,@MC004,@MC005,@MC006,@MC007,@MC008,@MC009,@MC010,@MC011,@MC012,@MC013,@MC014,@MC015,@MC016,@MC017,@MC018,@MC019,@MC020,@MC021,@MC022,@MC023,@MC024,@UDF01,@UDF02,@UDF03,@UDF04,@UDF05,@UDF06,@UDF51,@UDF52,@UDF53,@UDF54,@UDF55,@UDF56,@UDF07,@UDF08,@UDF09,@UDF10,@UDF11,@UDF12,@UDF57,@UDF58,@UDF59,@UDF60,@UDF61,@UDF62)");
            SqlParameter[] parameters = {
                    new SqlParameter("@COMPANY", SqlDbType.Char,10),
                    new SqlParameter("@CREATOR", SqlDbType.Char,10),
                    new SqlParameter("@USR_GROUP", SqlDbType.Char,10),
                    new SqlParameter("@CREATE_DATE", SqlDbType.Char,17),
                    new SqlParameter("@MODIFIER", SqlDbType.Char,10),
                    new SqlParameter("@MODI_DATE", SqlDbType.Char,17),
                    new SqlParameter("@FLAG", SqlDbType.Decimal,5),
                    new SqlParameter("@MC001", SqlDbType.Char,10),
                    new SqlParameter("@MC002", SqlDbType.Char,20),
                    new SqlParameter("@MC003", SqlDbType.Char,6),
                    new SqlParameter("@MC004", SqlDbType.Char,1),
                    new SqlParameter("@MC005", SqlDbType.Char,1),
                    new SqlParameter("@MC006", SqlDbType.Char,1),
                    new SqlParameter("@MC007", SqlDbType.VarChar,255),
                    new SqlParameter("@MC008", SqlDbType.Char,1),
                    new SqlParameter("@MC009", SqlDbType.Char,72),
                    new SqlParameter("@MC010", SqlDbType.Char,20),
                    new SqlParameter("@MC011", SqlDbType.Char,20),
                    new SqlParameter("@MC012", SqlDbType.Decimal,5),
                    new SqlParameter("@MC013", SqlDbType.Decimal,5),
                    new SqlParameter("@MC014", SqlDbType.Decimal,5),
                    new SqlParameter("@MC015", SqlDbType.Decimal,5),
                    new SqlParameter("@MC016", SqlDbType.Char,1),
                    new SqlParameter("@MC017", SqlDbType.Char,12),
                    new SqlParameter("@MC018", SqlDbType.Char,1),
                    new SqlParameter("@MC019", SqlDbType.Char,1),
                    new SqlParameter("@MC020", SqlDbType.Char,8),
                    new SqlParameter("@MC021", SqlDbType.VarChar,30),
                    new SqlParameter("@MC022", SqlDbType.Decimal,9),
                    new SqlParameter("@MC023", SqlDbType.Decimal,9),
                    new SqlParameter("@MC024", SqlDbType.Decimal,9),
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
            parameters[7].Value = model.MC001;
            parameters[8].Value = model.MC002;
            parameters[9].Value = model.MC003;
            parameters[10].Value = model.MC004;
            parameters[11].Value = model.MC005;
            parameters[12].Value = model.MC006;
            parameters[13].Value = model.MC007;
            parameters[14].Value = model.MC008;
            parameters[15].Value = model.MC009;
            parameters[16].Value = model.MC010;
            parameters[17].Value = model.MC011;
            parameters[18].Value = model.MC012;
            parameters[19].Value = model.MC013;
            parameters[20].Value = model.MC014;
            parameters[21].Value = model.MC015;
            parameters[22].Value = model.MC016;
            parameters[23].Value = model.MC017;
            parameters[24].Value = model.MC018;
            parameters[25].Value = model.MC019;
            parameters[26].Value = model.MC020;
            parameters[27].Value = model.MC021;
            parameters[28].Value = model.MC022;
            parameters[29].Value = model.MC023;
            parameters[30].Value = model.MC024;
            parameters[31].Value = model.UDF01;
            parameters[32].Value = model.UDF02;
            parameters[33].Value = model.UDF03;
            parameters[34].Value = model.UDF04;
            parameters[35].Value = model.UDF05;
            parameters[36].Value = model.UDF06;
            parameters[37].Value = model.UDF51;
            parameters[38].Value = model.UDF52;
            parameters[39].Value = model.UDF53;
            parameters[40].Value = model.UDF54;
            parameters[41].Value = model.UDF55;
            parameters[42].Value = model.UDF56;
            parameters[43].Value = model.UDF07;
            parameters[44].Value = model.UDF08;
            parameters[45].Value = model.UDF09;
            parameters[46].Value = model.UDF10;
            parameters[47].Value = model.UDF11;
            parameters[48].Value = model.UDF12;
            parameters[49].Value = model.UDF57;
            parameters[50].Value = model.UDF58;
            parameters[51].Value = model.UDF59;
            parameters[52].Value = model.UDF60;
            parameters[53].Value = model.UDF61;
            parameters[54].Value = model.UDF62;

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
        public bool Update(YJUI.Model.CMSMC model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CMSMC set ");
            strSql.Append("COMPANY=@COMPANY,");
            strSql.Append("CREATOR=@CREATOR,");
            strSql.Append("USR_GROUP=@USR_GROUP,");
            strSql.Append("CREATE_DATE=@CREATE_DATE,");
            strSql.Append("MODIFIER=@MODIFIER,");
            strSql.Append("MODI_DATE=@MODI_DATE,");
            strSql.Append("FLAG=@FLAG,");
            strSql.Append("MC002=@MC002,");
            strSql.Append("MC003=@MC003,");
            strSql.Append("MC004=@MC004,");
            strSql.Append("MC005=@MC005,");
            strSql.Append("MC006=@MC006,");
            strSql.Append("MC007=@MC007,");
            strSql.Append("MC008=@MC008,");
            strSql.Append("MC009=@MC009,");
            strSql.Append("MC010=@MC010,");
            strSql.Append("MC011=@MC011,");
            strSql.Append("MC012=@MC012,");
            strSql.Append("MC013=@MC013,");
            strSql.Append("MC014=@MC014,");
            strSql.Append("MC015=@MC015,");
            strSql.Append("MC016=@MC016,");
            strSql.Append("MC017=@MC017,");
            strSql.Append("MC018=@MC018,");
            strSql.Append("MC019=@MC019,");
            strSql.Append("MC020=@MC020,");
            strSql.Append("MC021=@MC021,");
            strSql.Append("MC022=@MC022,");
            strSql.Append("MC023=@MC023,");
            strSql.Append("MC024=@MC024,");
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
            strSql.Append(" where MC001=@MC001 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@COMPANY", SqlDbType.Char,10),
                    new SqlParameter("@CREATOR", SqlDbType.Char,10),
                    new SqlParameter("@USR_GROUP", SqlDbType.Char,10),
                    new SqlParameter("@CREATE_DATE", SqlDbType.Char,17),
                    new SqlParameter("@MODIFIER", SqlDbType.Char,10),
                    new SqlParameter("@MODI_DATE", SqlDbType.Char,17),
                    new SqlParameter("@FLAG", SqlDbType.Decimal,5),
                    new SqlParameter("@MC002", SqlDbType.Char,20),
                    new SqlParameter("@MC003", SqlDbType.Char,6),
                    new SqlParameter("@MC004", SqlDbType.Char,1),
                    new SqlParameter("@MC005", SqlDbType.Char,1),
                    new SqlParameter("@MC006", SqlDbType.Char,1),
                    new SqlParameter("@MC007", SqlDbType.VarChar,255),
                    new SqlParameter("@MC008", SqlDbType.Char,1),
                    new SqlParameter("@MC009", SqlDbType.Char,72),
                    new SqlParameter("@MC010", SqlDbType.Char,20),
                    new SqlParameter("@MC011", SqlDbType.Char,20),
                    new SqlParameter("@MC012", SqlDbType.Decimal,5),
                    new SqlParameter("@MC013", SqlDbType.Decimal,5),
                    new SqlParameter("@MC014", SqlDbType.Decimal,5),
                    new SqlParameter("@MC015", SqlDbType.Decimal,5),
                    new SqlParameter("@MC016", SqlDbType.Char,1),
                    new SqlParameter("@MC017", SqlDbType.Char,12),
                    new SqlParameter("@MC018", SqlDbType.Char,1),
                    new SqlParameter("@MC019", SqlDbType.Char,1),
                    new SqlParameter("@MC020", SqlDbType.Char,8),
                    new SqlParameter("@MC021", SqlDbType.VarChar,30),
                    new SqlParameter("@MC022", SqlDbType.Decimal,9),
                    new SqlParameter("@MC023", SqlDbType.Decimal,9),
                    new SqlParameter("@MC024", SqlDbType.Decimal,9),
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
                    new SqlParameter("@MC001", SqlDbType.Char,10)};
            parameters[0].Value = model.COMPANY;
            parameters[1].Value = model.CREATOR;
            parameters[2].Value = model.USR_GROUP;
            parameters[3].Value = model.CREATE_DATE;
            parameters[4].Value = model.MODIFIER;
            parameters[5].Value = model.MODI_DATE;
            parameters[6].Value = model.FLAG;
            parameters[7].Value = model.MC002;
            parameters[8].Value = model.MC003;
            parameters[9].Value = model.MC004;
            parameters[10].Value = model.MC005;
            parameters[11].Value = model.MC006;
            parameters[12].Value = model.MC007;
            parameters[13].Value = model.MC008;
            parameters[14].Value = model.MC009;
            parameters[15].Value = model.MC010;
            parameters[16].Value = model.MC011;
            parameters[17].Value = model.MC012;
            parameters[18].Value = model.MC013;
            parameters[19].Value = model.MC014;
            parameters[20].Value = model.MC015;
            parameters[21].Value = model.MC016;
            parameters[22].Value = model.MC017;
            parameters[23].Value = model.MC018;
            parameters[24].Value = model.MC019;
            parameters[25].Value = model.MC020;
            parameters[26].Value = model.MC021;
            parameters[27].Value = model.MC022;
            parameters[28].Value = model.MC023;
            parameters[29].Value = model.MC024;
            parameters[30].Value = model.UDF01;
            parameters[31].Value = model.UDF02;
            parameters[32].Value = model.UDF03;
            parameters[33].Value = model.UDF04;
            parameters[34].Value = model.UDF05;
            parameters[35].Value = model.UDF06;
            parameters[36].Value = model.UDF51;
            parameters[37].Value = model.UDF52;
            parameters[38].Value = model.UDF53;
            parameters[39].Value = model.UDF54;
            parameters[40].Value = model.UDF55;
            parameters[41].Value = model.UDF56;
            parameters[42].Value = model.UDF07;
            parameters[43].Value = model.UDF08;
            parameters[44].Value = model.UDF09;
            parameters[45].Value = model.UDF10;
            parameters[46].Value = model.UDF11;
            parameters[47].Value = model.UDF12;
            parameters[48].Value = model.UDF57;
            parameters[49].Value = model.UDF58;
            parameters[50].Value = model.UDF59;
            parameters[51].Value = model.UDF60;
            parameters[52].Value = model.UDF61;
            parameters[53].Value = model.UDF62;
            parameters[54].Value = model.MC001;

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
        public bool Delete(string MC001)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CMSMC ");
            strSql.Append(" where MC001=@MC001 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@MC001", SqlDbType.Char,10)           };
            parameters[0].Value = MC001;

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
        public bool DeleteList(string MC001list)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CMSMC ");
            strSql.Append(" where MC001 in (" + MC001list + ")  ");
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
        public YJUI.Model.CMSMC GetModel(string MC001)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,MC001,MC002,MC003,MC004,MC005,MC006,MC007,MC008,MC009,MC010,MC011,MC012,MC013,MC014,MC015,MC016,MC017,MC018,MC019,MC020,MC021,MC022,MC023,MC024,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62 from CMSMC ");
            strSql.Append(" where MC001=@MC001 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@MC001", SqlDbType.Char,10)           };
            parameters[0].Value = MC001;

            YJUI.Model.CMSMC model = new YJUI.Model.CMSMC();
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
        public YJUI.Model.CMSMC DataRowToModel(DataRow row)
        {
            YJUI.Model.CMSMC model = new YJUI.Model.CMSMC();
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
                if (row["MC001"] != null)
                {
                    model.MC001 = row["MC001"].ToString();
                }
                if (row["MC002"] != null)
                {
                    model.MC002 = row["MC002"].ToString();
                }
                if (row["MC003"] != null)
                {
                    model.MC003 = row["MC003"].ToString();
                }
                if (row["MC004"] != null)
                {
                    model.MC004 = row["MC004"].ToString();
                }
                if (row["MC005"] != null)
                {
                    model.MC005 = row["MC005"].ToString();
                }
                if (row["MC006"] != null)
                {
                    model.MC006 = row["MC006"].ToString();
                }
                if (row["MC007"] != null)
                {
                    model.MC007 = row["MC007"].ToString();
                }
                if (row["MC008"] != null)
                {
                    model.MC008 = row["MC008"].ToString();
                }
                if (row["MC009"] != null)
                {
                    model.MC009 = row["MC009"].ToString();
                }
                if (row["MC010"] != null)
                {
                    model.MC010 = row["MC010"].ToString();
                }
                if (row["MC011"] != null)
                {
                    model.MC011 = row["MC011"].ToString();
                }
                if (row["MC012"] != null && row["MC012"].ToString() != "")
                {
                    model.MC012 = decimal.Parse(row["MC012"].ToString());
                }
                if (row["MC013"] != null && row["MC013"].ToString() != "")
                {
                    model.MC013 = decimal.Parse(row["MC013"].ToString());
                }
                if (row["MC014"] != null && row["MC014"].ToString() != "")
                {
                    model.MC014 = decimal.Parse(row["MC014"].ToString());
                }
                if (row["MC015"] != null && row["MC015"].ToString() != "")
                {
                    model.MC015 = decimal.Parse(row["MC015"].ToString());
                }
                if (row["MC016"] != null)
                {
                    model.MC016 = row["MC016"].ToString();
                }
                if (row["MC017"] != null)
                {
                    model.MC017 = row["MC017"].ToString();
                }
                if (row["MC018"] != null)
                {
                    model.MC018 = row["MC018"].ToString();
                }
                if (row["MC019"] != null)
                {
                    model.MC019 = row["MC019"].ToString();
                }
                if (row["MC020"] != null)
                {
                    model.MC020 = row["MC020"].ToString();
                }
                if (row["MC021"] != null)
                {
                    model.MC021 = row["MC021"].ToString();
                }
                if (row["MC022"] != null && row["MC022"].ToString() != "")
                {
                    model.MC022 = decimal.Parse(row["MC022"].ToString());
                }
                if (row["MC023"] != null && row["MC023"].ToString() != "")
                {
                    model.MC023 = decimal.Parse(row["MC023"].ToString());
                }
                if (row["MC024"] != null && row["MC024"].ToString() != "")
                {
                    model.MC024 = decimal.Parse(row["MC024"].ToString());
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
            strSql.Append("select COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,MC001,MC002,MC003,MC004,MC005,MC006,MC007,MC008,MC009,MC010,MC011,MC012,MC013,MC014,MC015,MC016,MC017,MC018,MC019,MC020,MC021,MC022,MC023,MC024,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62 ");
            strSql.Append(" FROM CMSMC ");
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
            strSql.Append(" COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,MC001,MC002,MC003,MC004,MC005,MC006,MC007,MC008,MC009,MC010,MC011,MC012,MC013,MC014,MC015,MC016,MC017,MC018,MC019,MC020,MC021,MC022,MC023,MC024,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62 ");
            strSql.Append(" FROM CMSMC ");
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
            strSql.Append("select count(1) FROM CMSMC ");
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
                strSql.Append("order by T.MC001 desc");
            }
            strSql.Append(")AS Row, T.*  from CMSMC T ");
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

