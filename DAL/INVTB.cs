using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using YJUI.DBUtility;//Please add references
namespace YJUI.DAL
{
    /// <summary>
    /// 数据访问类:INVTB
    /// </summary>
    public partial class INVTB
    {
        public INVTB()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string TB003, string TB001, string TB002)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from INVTB");
            strSql.Append(" where TB003=@TB003 and TB001=@TB001 and TB002=@TB002 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@TB003", SqlDbType.Char,4),
                    new SqlParameter("@TB001", SqlDbType.Char,4),
                    new SqlParameter("@TB002", SqlDbType.Char,11)           };
            parameters[0].Value = TB003;
            parameters[1].Value = TB001;
            parameters[2].Value = TB002;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YJUI.Model.INVTB model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into INVTB(");
            strSql.Append("COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,TB001,TB002,TB003,TB004,TB005,TB006,TB007,TB008,TB009,TB010,TB011,TB012,TB013,TB014,TB015,TB016,TB017,TB018,TB019,TB020,TB021,TB022,TB023,TB024,TB025,TB026,TB027,TB028,TB029,TB030,TB031,TB032,TB033,TB034,TB035,TB036,TB037,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62)");
            strSql.Append(" values (");
            strSql.Append("@COMPANY,@CREATOR,@USR_GROUP,@CREATE_DATE,@MODIFIER,@MODI_DATE,@FLAG,@TB001,@TB002,@TB003,@TB004,@TB005,@TB006,@TB007,@TB008,@TB009,@TB010,@TB011,@TB012,@TB013,@TB014,@TB015,@TB016,@TB017,@TB018,@TB019,@TB020,@TB021,@TB022,@TB023,@TB024,@TB025,@TB026,@TB027,@TB028,@TB029,@TB030,@TB031,@TB032,@TB033,@TB034,@TB035,@TB036,@TB037,@UDF01,@UDF02,@UDF03,@UDF04,@UDF05,@UDF06,@UDF51,@UDF52,@UDF53,@UDF54,@UDF55,@UDF56,@UDF07,@UDF08,@UDF09,@UDF10,@UDF11,@UDF12,@UDF57,@UDF58,@UDF59,@UDF60,@UDF61,@UDF62)");
            SqlParameter[] parameters = {
                    new SqlParameter("@COMPANY", SqlDbType.Char,10),
                    new SqlParameter("@CREATOR", SqlDbType.Char,10),
                    new SqlParameter("@USR_GROUP", SqlDbType.Char,10),
                    new SqlParameter("@CREATE_DATE", SqlDbType.Char,17),
                    new SqlParameter("@MODIFIER", SqlDbType.Char,10),
                    new SqlParameter("@MODI_DATE", SqlDbType.Char,17),
                    new SqlParameter("@FLAG", SqlDbType.Decimal,5),
                    new SqlParameter("@TB001", SqlDbType.Char,4),
                    new SqlParameter("@TB002", SqlDbType.Char,11),
                    new SqlParameter("@TB003", SqlDbType.Char,4),
                    new SqlParameter("@TB004", SqlDbType.Char,20),
                    new SqlParameter("@TB005", SqlDbType.VarChar,60),
                    new SqlParameter("@TB006", SqlDbType.VarChar,60),
                    new SqlParameter("@TB007", SqlDbType.Decimal,9),
                    new SqlParameter("@TB008", SqlDbType.Char,4),
                    new SqlParameter("@TB009", SqlDbType.Decimal,9),
                    new SqlParameter("@TB010", SqlDbType.Decimal,9),
                    new SqlParameter("@TB011", SqlDbType.Decimal,9),
                    new SqlParameter("@TB012", SqlDbType.Char,10),
                    new SqlParameter("@TB013", SqlDbType.Char,10),
                    new SqlParameter("@TB014", SqlDbType.Char,20),
                    new SqlParameter("@TB015", SqlDbType.Char,8),
                    new SqlParameter("@TB016", SqlDbType.Char,8),
                    new SqlParameter("@TB017", SqlDbType.VarChar,255),
                    new SqlParameter("@TB018", SqlDbType.Char,1),
                    new SqlParameter("@TB019", SqlDbType.Char,8),
                    new SqlParameter("@TB020", SqlDbType.Char,4),
                    new SqlParameter("@TB021", SqlDbType.Char,20),
                    new SqlParameter("@TB022", SqlDbType.Decimal,9),
                    new SqlParameter("@TB023", SqlDbType.Char,4),
                    new SqlParameter("@TB024", SqlDbType.Char,20),
                    new SqlParameter("@TB025", SqlDbType.Decimal,9),
                    new SqlParameter("@TB026", SqlDbType.Decimal,9),
                    new SqlParameter("@TB027", SqlDbType.Decimal,9),
                    new SqlParameter("@TB028", SqlDbType.VarChar,80),
                    new SqlParameter("@TB029", SqlDbType.Char,10),
                    new SqlParameter("@TB030", SqlDbType.Char,10),
                    new SqlParameter("@TB031", SqlDbType.Char,8),
                    new SqlParameter("@TB032", SqlDbType.Char,1),
                    new SqlParameter("@TB033", SqlDbType.Char,8),
                    new SqlParameter("@TB034", SqlDbType.VarChar,30),
                    new SqlParameter("@TB035", SqlDbType.Decimal,9),
                    new SqlParameter("@TB036", SqlDbType.Decimal,9),
                    new SqlParameter("@TB037", SqlDbType.Decimal,9),
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
            parameters[7].Value = model.TB001;
            parameters[8].Value = model.TB002;
            parameters[9].Value = model.TB003;
            parameters[10].Value = model.TB004;
            parameters[11].Value = model.TB005;
            parameters[12].Value = model.TB006;
            parameters[13].Value = model.TB007;
            parameters[14].Value = model.TB008;
            parameters[15].Value = model.TB009;
            parameters[16].Value = model.TB010;
            parameters[17].Value = model.TB011;
            parameters[18].Value = model.TB012;
            parameters[19].Value = model.TB013;
            parameters[20].Value = model.TB014;
            parameters[21].Value = model.TB015;
            parameters[22].Value = model.TB016;
            parameters[23].Value = model.TB017;
            parameters[24].Value = model.TB018;
            parameters[25].Value = model.TB019;
            parameters[26].Value = model.TB020;
            parameters[27].Value = model.TB021;
            parameters[28].Value = model.TB022;
            parameters[29].Value = model.TB023;
            parameters[30].Value = model.TB024;
            parameters[31].Value = model.TB025;
            parameters[32].Value = model.TB026;
            parameters[33].Value = model.TB027;
            parameters[34].Value = model.TB028;
            parameters[35].Value = model.TB029;
            parameters[36].Value = model.TB030;
            parameters[37].Value = model.TB031;
            parameters[38].Value = model.TB032;
            parameters[39].Value = model.TB033;
            parameters[40].Value = model.TB034;
            parameters[41].Value = model.TB035;
            parameters[42].Value = model.TB036;
            parameters[43].Value = model.TB037;
            parameters[44].Value = model.UDF01;
            parameters[45].Value = model.UDF02;
            parameters[46].Value = model.UDF03;
            parameters[47].Value = model.UDF04;
            parameters[48].Value = model.UDF05;
            parameters[49].Value = model.UDF06;
            parameters[50].Value = model.UDF51;
            parameters[51].Value = model.UDF52;
            parameters[52].Value = model.UDF53;
            parameters[53].Value = model.UDF54;
            parameters[54].Value = model.UDF55;
            parameters[55].Value = model.UDF56;
            parameters[56].Value = model.UDF07;
            parameters[57].Value = model.UDF08;
            parameters[58].Value = model.UDF09;
            parameters[59].Value = model.UDF10;
            parameters[60].Value = model.UDF11;
            parameters[61].Value = model.UDF12;
            parameters[62].Value = model.UDF57;
            parameters[63].Value = model.UDF58;
            parameters[64].Value = model.UDF59;
            parameters[65].Value = model.UDF60;
            parameters[66].Value = model.UDF61;
            parameters[67].Value = model.UDF62;

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
        public bool Update(YJUI.Model.INVTB model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update INVTB set ");
            strSql.Append("COMPANY=@COMPANY,");
            strSql.Append("CREATOR=@CREATOR,");
            strSql.Append("USR_GROUP=@USR_GROUP,");
            strSql.Append("CREATE_DATE=@CREATE_DATE,");
            strSql.Append("MODIFIER=@MODIFIER,");
            strSql.Append("MODI_DATE=@MODI_DATE,");
            strSql.Append("FLAG=@FLAG,");
            strSql.Append("TB004=@TB004,");
            strSql.Append("TB005=@TB005,");
            strSql.Append("TB006=@TB006,");
            strSql.Append("TB007=@TB007,");
            strSql.Append("TB008=@TB008,");
            strSql.Append("TB009=@TB009,");
            strSql.Append("TB010=@TB010,");
            strSql.Append("TB011=@TB011,");
            strSql.Append("TB012=@TB012,");
            strSql.Append("TB013=@TB013,");
            strSql.Append("TB014=@TB014,");
            strSql.Append("TB015=@TB015,");
            strSql.Append("TB016=@TB016,");
            strSql.Append("TB017=@TB017,");
            strSql.Append("TB018=@TB018,");
            strSql.Append("TB019=@TB019,");
            strSql.Append("TB020=@TB020,");
            strSql.Append("TB021=@TB021,");
            strSql.Append("TB022=@TB022,");
            strSql.Append("TB023=@TB023,");
            strSql.Append("TB024=@TB024,");
            strSql.Append("TB025=@TB025,");
            strSql.Append("TB026=@TB026,");
            strSql.Append("TB027=@TB027,");
            strSql.Append("TB028=@TB028,");
            strSql.Append("TB029=@TB029,");
            strSql.Append("TB030=@TB030,");
            strSql.Append("TB031=@TB031,");
            strSql.Append("TB032=@TB032,");
            strSql.Append("TB033=@TB033,");
            strSql.Append("TB034=@TB034,");
            strSql.Append("TB035=@TB035,");
            strSql.Append("TB036=@TB036,");
            strSql.Append("TB037=@TB037,");
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
            strSql.Append(" where TB003=@TB003 and TB001=@TB001 and TB002=@TB002 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@COMPANY", SqlDbType.Char,10),
                    new SqlParameter("@CREATOR", SqlDbType.Char,10),
                    new SqlParameter("@USR_GROUP", SqlDbType.Char,10),
                    new SqlParameter("@CREATE_DATE", SqlDbType.Char,17),
                    new SqlParameter("@MODIFIER", SqlDbType.Char,10),
                    new SqlParameter("@MODI_DATE", SqlDbType.Char,17),
                    new SqlParameter("@FLAG", SqlDbType.Decimal,5),
                    new SqlParameter("@TB004", SqlDbType.Char,20),
                    new SqlParameter("@TB005", SqlDbType.VarChar,60),
                    new SqlParameter("@TB006", SqlDbType.VarChar,60),
                    new SqlParameter("@TB007", SqlDbType.Decimal,9),
                    new SqlParameter("@TB008", SqlDbType.Char,4),
                    new SqlParameter("@TB009", SqlDbType.Decimal,9),
                    new SqlParameter("@TB010", SqlDbType.Decimal,9),
                    new SqlParameter("@TB011", SqlDbType.Decimal,9),
                    new SqlParameter("@TB012", SqlDbType.Char,10),
                    new SqlParameter("@TB013", SqlDbType.Char,10),
                    new SqlParameter("@TB014", SqlDbType.Char,20),
                    new SqlParameter("@TB015", SqlDbType.Char,8),
                    new SqlParameter("@TB016", SqlDbType.Char,8),
                    new SqlParameter("@TB017", SqlDbType.VarChar,255),
                    new SqlParameter("@TB018", SqlDbType.Char,1),
                    new SqlParameter("@TB019", SqlDbType.Char,8),
                    new SqlParameter("@TB020", SqlDbType.Char,4),
                    new SqlParameter("@TB021", SqlDbType.Char,20),
                    new SqlParameter("@TB022", SqlDbType.Decimal,9),
                    new SqlParameter("@TB023", SqlDbType.Char,4),
                    new SqlParameter("@TB024", SqlDbType.Char,20),
                    new SqlParameter("@TB025", SqlDbType.Decimal,9),
                    new SqlParameter("@TB026", SqlDbType.Decimal,9),
                    new SqlParameter("@TB027", SqlDbType.Decimal,9),
                    new SqlParameter("@TB028", SqlDbType.VarChar,80),
                    new SqlParameter("@TB029", SqlDbType.Char,10),
                    new SqlParameter("@TB030", SqlDbType.Char,10),
                    new SqlParameter("@TB031", SqlDbType.Char,8),
                    new SqlParameter("@TB032", SqlDbType.Char,1),
                    new SqlParameter("@TB033", SqlDbType.Char,8),
                    new SqlParameter("@TB034", SqlDbType.VarChar,30),
                    new SqlParameter("@TB035", SqlDbType.Decimal,9),
                    new SqlParameter("@TB036", SqlDbType.Decimal,9),
                    new SqlParameter("@TB037", SqlDbType.Decimal,9),
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
                    new SqlParameter("@TB001", SqlDbType.Char,4),
                    new SqlParameter("@TB002", SqlDbType.Char,11),
                    new SqlParameter("@TB003", SqlDbType.Char,4)};
            parameters[0].Value = model.COMPANY;
            parameters[1].Value = model.CREATOR;
            parameters[2].Value = model.USR_GROUP;
            parameters[3].Value = model.CREATE_DATE;
            parameters[4].Value = model.MODIFIER;
            parameters[5].Value = model.MODI_DATE;
            parameters[6].Value = model.FLAG;
            parameters[7].Value = model.TB004;
            parameters[8].Value = model.TB005;
            parameters[9].Value = model.TB006;
            parameters[10].Value = model.TB007;
            parameters[11].Value = model.TB008;
            parameters[12].Value = model.TB009;
            parameters[13].Value = model.TB010;
            parameters[14].Value = model.TB011;
            parameters[15].Value = model.TB012;
            parameters[16].Value = model.TB013;
            parameters[17].Value = model.TB014;
            parameters[18].Value = model.TB015;
            parameters[19].Value = model.TB016;
            parameters[20].Value = model.TB017;
            parameters[21].Value = model.TB018;
            parameters[22].Value = model.TB019;
            parameters[23].Value = model.TB020;
            parameters[24].Value = model.TB021;
            parameters[25].Value = model.TB022;
            parameters[26].Value = model.TB023;
            parameters[27].Value = model.TB024;
            parameters[28].Value = model.TB025;
            parameters[29].Value = model.TB026;
            parameters[30].Value = model.TB027;
            parameters[31].Value = model.TB028;
            parameters[32].Value = model.TB029;
            parameters[33].Value = model.TB030;
            parameters[34].Value = model.TB031;
            parameters[35].Value = model.TB032;
            parameters[36].Value = model.TB033;
            parameters[37].Value = model.TB034;
            parameters[38].Value = model.TB035;
            parameters[39].Value = model.TB036;
            parameters[40].Value = model.TB037;
            parameters[41].Value = model.UDF01;
            parameters[42].Value = model.UDF02;
            parameters[43].Value = model.UDF03;
            parameters[44].Value = model.UDF04;
            parameters[45].Value = model.UDF05;
            parameters[46].Value = model.UDF06;
            parameters[47].Value = model.UDF51;
            parameters[48].Value = model.UDF52;
            parameters[49].Value = model.UDF53;
            parameters[50].Value = model.UDF54;
            parameters[51].Value = model.UDF55;
            parameters[52].Value = model.UDF56;
            parameters[53].Value = model.UDF07;
            parameters[54].Value = model.UDF08;
            parameters[55].Value = model.UDF09;
            parameters[56].Value = model.UDF10;
            parameters[57].Value = model.UDF11;
            parameters[58].Value = model.UDF12;
            parameters[59].Value = model.UDF57;
            parameters[60].Value = model.UDF58;
            parameters[61].Value = model.UDF59;
            parameters[62].Value = model.UDF60;
            parameters[63].Value = model.UDF61;
            parameters[64].Value = model.UDF62;
            parameters[65].Value = model.TB001;
            parameters[66].Value = model.TB002;
            parameters[67].Value = model.TB003;

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
        public bool Delete(string TB003, string TB001, string TB002)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from INVTB ");
            strSql.Append(" where TB003=@TB003 and TB001=@TB001 and TB002=@TB002 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@TB003", SqlDbType.Char,4),
                    new SqlParameter("@TB001", SqlDbType.Char,4),
                    new SqlParameter("@TB002", SqlDbType.Char,11)           };
            parameters[0].Value = TB003;
            parameters[1].Value = TB001;
            parameters[2].Value = TB002;

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
        /// 得到一个对象实体
        /// </summary>
        public YJUI.Model.INVTB GetModel(string TB003, string TB001, string TB002)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,TB001,TB002,TB003,TB004,TB005,TB006,TB007,TB008,TB009,TB010,TB011,TB012,TB013,TB014,TB015,TB016,TB017,TB018,TB019,TB020,TB021,TB022,TB023,TB024,TB025,TB026,TB027,TB028,TB029,TB030,TB031,TB032,TB033,TB034,TB035,TB036,TB037,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62 from INVTB ");
            strSql.Append(" where TB003=@TB003 and TB001=@TB001 and TB002=@TB002 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@TB003", SqlDbType.Char,4),
                    new SqlParameter("@TB001", SqlDbType.Char,4),
                    new SqlParameter("@TB002", SqlDbType.Char,11)           };
            parameters[0].Value = TB003;
            parameters[1].Value = TB001;
            parameters[2].Value = TB002;

            YJUI.Model.INVTB model = new YJUI.Model.INVTB();
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
        public YJUI.Model.INVTB DataRowToModel(DataRow row)
        {
            YJUI.Model.INVTB model = new YJUI.Model.INVTB();
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
                if (row["TB001"] != null)
                {
                    model.TB001 = row["TB001"].ToString();
                }
                if (row["TB002"] != null)
                {
                    model.TB002 = row["TB002"].ToString();
                }
                if (row["TB003"] != null)
                {
                    model.TB003 = row["TB003"].ToString();
                }
                if (row["TB004"] != null)
                {
                    model.TB004 = row["TB004"].ToString();
                }
                if (row["TB005"] != null)
                {
                    model.TB005 = row["TB005"].ToString();
                }
                if (row["TB006"] != null)
                {
                    model.TB006 = row["TB006"].ToString();
                }
                if (row["TB007"] != null && row["TB007"].ToString() != "")
                {
                    model.TB007 = decimal.Parse(row["TB007"].ToString());
                }
                if (row["TB008"] != null)
                {
                    model.TB008 = row["TB008"].ToString();
                }
                if (row["TB009"] != null && row["TB009"].ToString() != "")
                {
                    model.TB009 = decimal.Parse(row["TB009"].ToString());
                }
                if (row["TB010"] != null && row["TB010"].ToString() != "")
                {
                    model.TB010 = decimal.Parse(row["TB010"].ToString());
                }
                if (row["TB011"] != null && row["TB011"].ToString() != "")
                {
                    model.TB011 = decimal.Parse(row["TB011"].ToString());
                }
                if (row["TB012"] != null)
                {
                    model.TB012 = row["TB012"].ToString();
                }
                if (row["TB013"] != null)
                {
                    model.TB013 = row["TB013"].ToString();
                }
                if (row["TB014"] != null)
                {
                    model.TB014 = row["TB014"].ToString();
                }
                if (row["TB015"] != null)
                {
                    model.TB015 = row["TB015"].ToString();
                }
                if (row["TB016"] != null)
                {
                    model.TB016 = row["TB016"].ToString();
                }
                if (row["TB017"] != null)
                {
                    model.TB017 = row["TB017"].ToString();
                }
                if (row["TB018"] != null)
                {
                    model.TB018 = row["TB018"].ToString();
                }
                if (row["TB019"] != null)
                {
                    model.TB019 = row["TB019"].ToString();
                }
                if (row["TB020"] != null)
                {
                    model.TB020 = row["TB020"].ToString();
                }
                if (row["TB021"] != null)
                {
                    model.TB021 = row["TB021"].ToString();
                }
                if (row["TB022"] != null && row["TB022"].ToString() != "")
                {
                    model.TB022 = decimal.Parse(row["TB022"].ToString());
                }
                if (row["TB023"] != null)
                {
                    model.TB023 = row["TB023"].ToString();
                }
                if (row["TB024"] != null)
                {
                    model.TB024 = row["TB024"].ToString();
                }
                if (row["TB025"] != null && row["TB025"].ToString() != "")
                {
                    model.TB025 = decimal.Parse(row["TB025"].ToString());
                }
                if (row["TB026"] != null && row["TB026"].ToString() != "")
                {
                    model.TB026 = decimal.Parse(row["TB026"].ToString());
                }
                if (row["TB027"] != null && row["TB027"].ToString() != "")
                {
                    model.TB027 = decimal.Parse(row["TB027"].ToString());
                }
                if (row["TB028"] != null)
                {
                    model.TB028 = row["TB028"].ToString();
                }
                if (row["TB029"] != null)
                {
                    model.TB029 = row["TB029"].ToString();
                }
                if (row["TB030"] != null)
                {
                    model.TB030 = row["TB030"].ToString();
                }
                if (row["TB031"] != null)
                {
                    model.TB031 = row["TB031"].ToString();
                }
                if (row["TB032"] != null)
                {
                    model.TB032 = row["TB032"].ToString();
                }
                if (row["TB033"] != null)
                {
                    model.TB033 = row["TB033"].ToString();
                }
                if (row["TB034"] != null)
                {
                    model.TB034 = row["TB034"].ToString();
                }
                if (row["TB035"] != null && row["TB035"].ToString() != "")
                {
                    model.TB035 = decimal.Parse(row["TB035"].ToString());
                }
                if (row["TB036"] != null && row["TB036"].ToString() != "")
                {
                    model.TB036 = decimal.Parse(row["TB036"].ToString());
                }
                if (row["TB037"] != null && row["TB037"].ToString() != "")
                {
                    model.TB037 = decimal.Parse(row["TB037"].ToString());
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
            strSql.Append("select COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,TB001,TB002,TB003,TB004,TB005,TB006,TB007,TB008,TB009,TB010,TB011,TB012,TB013,TB014,TB015,TB016,TB017,TB018,TB019,TB020,TB021,TB022,TB023,TB024,TB025,TB026,TB027,TB028,TB029,TB030,TB031,TB032,TB033,TB034,TB035,TB036,TB037,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62 ");
            strSql.Append(" FROM INVTB ");
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
            strSql.Append(" COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,TB001,TB002,TB003,TB004,TB005,TB006,TB007,TB008,TB009,TB010,TB011,TB012,TB013,TB014,TB015,TB016,TB017,TB018,TB019,TB020,TB021,TB022,TB023,TB024,TB025,TB026,TB027,TB028,TB029,TB030,TB031,TB032,TB033,TB034,TB035,TB036,TB037,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62 ");
            strSql.Append(" FROM INVTB ");
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
            strSql.Append("select count(1) FROM INVTB ");
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
                strSql.Append("order by T.TB002 desc");
            }
            strSql.Append(")AS Row, T.*  from INVTB T ");
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

        #endregion  ExtensionMethod
    }
}

