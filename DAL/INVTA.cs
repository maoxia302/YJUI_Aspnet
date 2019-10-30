using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using YJUI.DBUtility;//Please add references
namespace YJUI.DAL
{
    /// <summary>
    /// 数据访问类:INVTA
    /// </summary>
    public partial class INVTA
    {
        public INVTA()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string TA001, string TA002)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from INVTA");
            strSql.Append(" where TA001=@TA001 and TA002=@TA002 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@TA001", SqlDbType.Char,4),
                    new SqlParameter("@TA002", SqlDbType.Char,11)           };
            parameters[0].Value = TA001;
            parameters[1].Value = TA002;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YJUI.Model.INVTA model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into INVTA(");
            strSql.Append("COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,TA001,TA002,TA003,TA004,TA005,TA006,TA007,TA008,TA009,TA010,TA011,TA012,TA013,TA014,TA015,TA016,TA017,TA018,TA019,TA020,TA021,TA022,TA023,TA024,TA025,TA026,TA027,TA028,TA029,TA030,TA031,TA032,TA033,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62,t)");
            strSql.Append(" values (");
            strSql.Append("@COMPANY,@CREATOR,@USR_GROUP,@CREATE_DATE,@MODIFIER,@MODI_DATE,@FLAG,@TA001,@TA002,@TA003,@TA004,@TA005,@TA006,@TA007,@TA008,@TA009,@TA010,@TA011,@TA012,@TA013,@TA014,@TA015,@TA016,@TA017,@TA018,@TA019,@TA020,@TA021,@TA022,@TA023,@TA024,@TA025,@TA026,@TA027,@TA028,@TA029,@TA030,@TA031,@TA032,@TA033,@UDF01,@UDF02,@UDF03,@UDF04,@UDF05,@UDF06,@UDF51,@UDF52,@UDF53,@UDF54,@UDF55,@UDF56,@UDF07,@UDF08,@UDF09,@UDF10,@UDF11,@UDF12,@UDF57,@UDF58,@UDF59,@UDF60,@UDF61,@UDF62,@t)");
            SqlParameter[] parameters = {
                    new SqlParameter("@COMPANY", SqlDbType.Char,10),
                    new SqlParameter("@CREATOR", SqlDbType.Char,10),
                    new SqlParameter("@USR_GROUP", SqlDbType.Char,10),
                    new SqlParameter("@CREATE_DATE", SqlDbType.Char,17),
                    new SqlParameter("@MODIFIER", SqlDbType.Char,10),
                    new SqlParameter("@MODI_DATE", SqlDbType.Char,17),
                    new SqlParameter("@FLAG", SqlDbType.Decimal,5),
                    new SqlParameter("@TA001", SqlDbType.Char,4),
                    new SqlParameter("@TA002", SqlDbType.Char,11),
                    new SqlParameter("@TA003", SqlDbType.Char,8),
                    new SqlParameter("@TA004", SqlDbType.Char,6),
                    new SqlParameter("@TA005", SqlDbType.VarChar,255),
                    new SqlParameter("@TA006", SqlDbType.Char,1),
                    new SqlParameter("@TA007", SqlDbType.Decimal,5),
                    new SqlParameter("@TA008", SqlDbType.Char,6),
                    new SqlParameter("@TA009", SqlDbType.Char,2),
                    new SqlParameter("@TA010", SqlDbType.Decimal,5),
                    new SqlParameter("@TA011", SqlDbType.Decimal,9),
                    new SqlParameter("@TA012", SqlDbType.Decimal,9),
                    new SqlParameter("@TA013", SqlDbType.Char,1),
                    new SqlParameter("@TA014", SqlDbType.Char,8),
                    new SqlParameter("@TA015", SqlDbType.Char,10),
                    new SqlParameter("@TA016", SqlDbType.Decimal,9),
                    new SqlParameter("@TA017", SqlDbType.Char,1),
                    new SqlParameter("@TA018", SqlDbType.Char,15),
                    new SqlParameter("@TA019", SqlDbType.VarChar,255),
                    new SqlParameter("@TA020", SqlDbType.VarChar,255),
                    new SqlParameter("@TA021", SqlDbType.Decimal,5),
                    new SqlParameter("@TA022", SqlDbType.Char,12),
                    new SqlParameter("@TA023", SqlDbType.Char,10),
                    new SqlParameter("@TA024", SqlDbType.Char,12),
                    new SqlParameter("@TA025", SqlDbType.Char,1),
                    new SqlParameter("@TA026", SqlDbType.Char,1),
                    new SqlParameter("@TA027", SqlDbType.Char,8),
                    new SqlParameter("@TA028", SqlDbType.VarChar,30),
                    new SqlParameter("@TA029", SqlDbType.Decimal,9),
                    new SqlParameter("@TA030", SqlDbType.Decimal,9),
                    new SqlParameter("@TA031", SqlDbType.Decimal,9),
                    new SqlParameter("@TA032", SqlDbType.Char,10),
                    new SqlParameter("@TA033", SqlDbType.Char,20),
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
                    new SqlParameter("@t", SqlDbType.Bit,1)};
            parameters[0].Value = model.COMPANY;
            parameters[1].Value = model.CREATOR;
            parameters[2].Value = model.USR_GROUP;
            parameters[3].Value = model.CREATE_DATE;
            parameters[4].Value = model.MODIFIER;
            parameters[5].Value = model.MODI_DATE;
            parameters[6].Value = model.FLAG;
            parameters[7].Value = model.TA001;
            parameters[8].Value = model.TA002;
            parameters[9].Value = model.TA003;
            parameters[10].Value = model.TA004;
            parameters[11].Value = model.TA005;
            parameters[12].Value = model.TA006;
            parameters[13].Value = model.TA007;
            parameters[14].Value = model.TA008;
            parameters[15].Value = model.TA009;
            parameters[16].Value = model.TA010;
            parameters[17].Value = model.TA011;
            parameters[18].Value = model.TA012;
            parameters[19].Value = model.TA013;
            parameters[20].Value = model.TA014;
            parameters[21].Value = model.TA015;
            parameters[22].Value = model.TA016;
            parameters[23].Value = model.TA017;
            parameters[24].Value = model.TA018;
            parameters[25].Value = model.TA019;
            parameters[26].Value = model.TA020;
            parameters[27].Value = model.TA021;
            parameters[28].Value = model.TA022;
            parameters[29].Value = model.TA023;
            parameters[30].Value = model.TA024;
            parameters[31].Value = model.TA025;
            parameters[32].Value = model.TA026;
            parameters[33].Value = model.TA027;
            parameters[34].Value = model.TA028;
            parameters[35].Value = model.TA029;
            parameters[36].Value = model.TA030;
            parameters[37].Value = model.TA031;
            parameters[38].Value = model.TA032;
            parameters[39].Value = model.TA033;
            parameters[40].Value = model.UDF01;
            parameters[41].Value = model.UDF02;
            parameters[42].Value = model.UDF03;
            parameters[43].Value = model.UDF04;
            parameters[44].Value = model.UDF05;
            parameters[45].Value = model.UDF06;
            parameters[46].Value = model.UDF51;
            parameters[47].Value = model.UDF52;
            parameters[48].Value = model.UDF53;
            parameters[49].Value = model.UDF54;
            parameters[50].Value = model.UDF55;
            parameters[51].Value = model.UDF56;
            parameters[52].Value = model.UDF07;
            parameters[53].Value = model.UDF08;
            parameters[54].Value = model.UDF09;
            parameters[55].Value = model.UDF10;
            parameters[56].Value = model.UDF11;
            parameters[57].Value = model.UDF12;
            parameters[58].Value = model.UDF57;
            parameters[59].Value = model.UDF58;
            parameters[60].Value = model.UDF59;
            parameters[61].Value = model.UDF60;
            parameters[62].Value = model.UDF61;
            parameters[63].Value = model.UDF62;
            parameters[64].Value = model.t;

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
        public bool Update(YJUI.Model.INVTA model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update INVTA set ");
            strSql.Append("COMPANY=@COMPANY,");
            strSql.Append("CREATOR=@CREATOR,");
            strSql.Append("USR_GROUP=@USR_GROUP,");
            strSql.Append("CREATE_DATE=@CREATE_DATE,");
            strSql.Append("MODIFIER=@MODIFIER,");
            strSql.Append("MODI_DATE=@MODI_DATE,");
            strSql.Append("FLAG=@FLAG,");
            strSql.Append("TA004=@TA004,");
            strSql.Append("TA005=@TA005,");
            strSql.Append("TA006=@TA006,");
            strSql.Append("TA007=@TA007,");
            strSql.Append("TA008=@TA008,");
            strSql.Append("TA009=@TA009,");
            strSql.Append("TA010=@TA010,");
            strSql.Append("TA011=@TA011,");
            strSql.Append("TA012=@TA012,");
            strSql.Append("TA013=@TA013,");
            strSql.Append("TA014=@TA014,");
            strSql.Append("TA015=@TA015,");
            strSql.Append("TA016=@TA016,");
            strSql.Append("TA017=@TA017,");
            strSql.Append("TA018=@TA018,");
            strSql.Append("TA019=@TA019,");
            strSql.Append("TA020=@TA020,");
            strSql.Append("TA021=@TA021,");
            strSql.Append("TA022=@TA022,");
            strSql.Append("TA023=@TA023,");
            strSql.Append("TA024=@TA024,");
            strSql.Append("TA025=@TA025,");
            strSql.Append("TA026=@TA026,");
            strSql.Append("TA027=@TA027,");
            strSql.Append("TA028=@TA028,");
            strSql.Append("TA029=@TA029,");
            strSql.Append("TA030=@TA030,");
            strSql.Append("TA031=@TA031,");
            strSql.Append("TA032=@TA032,");
            strSql.Append("TA033=@TA033,");
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
            strSql.Append("UDF62=@UDF62,");
            strSql.Append("t=@t");
            strSql.Append(" where TA001=@TA001 and TA002=@TA002 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@COMPANY", SqlDbType.Char,10),
                    new SqlParameter("@CREATOR", SqlDbType.Char,10),
                    new SqlParameter("@USR_GROUP", SqlDbType.Char,10),
                    new SqlParameter("@CREATE_DATE", SqlDbType.Char,17),
                    new SqlParameter("@MODIFIER", SqlDbType.Char,10),
                    new SqlParameter("@MODI_DATE", SqlDbType.Char,17),
                    new SqlParameter("@FLAG", SqlDbType.Decimal,5),
                    new SqlParameter("@TA004", SqlDbType.Char,6),
                    new SqlParameter("@TA005", SqlDbType.VarChar,255),
                    new SqlParameter("@TA006", SqlDbType.Char,1),
                    new SqlParameter("@TA007", SqlDbType.Decimal,5),
                    new SqlParameter("@TA008", SqlDbType.Char,6),
                    new SqlParameter("@TA009", SqlDbType.Char,2),
                    new SqlParameter("@TA010", SqlDbType.Decimal,5),
                    new SqlParameter("@TA011", SqlDbType.Decimal,9),
                    new SqlParameter("@TA012", SqlDbType.Decimal,9),
                    new SqlParameter("@TA013", SqlDbType.Char,1),
                    new SqlParameter("@TA014", SqlDbType.Char,8),
                    new SqlParameter("@TA015", SqlDbType.Char,10),
                    new SqlParameter("@TA016", SqlDbType.Decimal,9),
                    new SqlParameter("@TA017", SqlDbType.Char,1),
                    new SqlParameter("@TA018", SqlDbType.Char,15),
                    new SqlParameter("@TA019", SqlDbType.VarChar,255),
                    new SqlParameter("@TA020", SqlDbType.VarChar,255),
                    new SqlParameter("@TA021", SqlDbType.Decimal,5),
                    new SqlParameter("@TA022", SqlDbType.Char,12),
                    new SqlParameter("@TA023", SqlDbType.Char,10),
                    new SqlParameter("@TA024", SqlDbType.Char,12),
                    new SqlParameter("@TA025", SqlDbType.Char,1),
                    new SqlParameter("@TA026", SqlDbType.Char,1),
                    new SqlParameter("@TA027", SqlDbType.Char,8),
                    new SqlParameter("@TA028", SqlDbType.VarChar,30),
                    new SqlParameter("@TA029", SqlDbType.Decimal,9),
                    new SqlParameter("@TA030", SqlDbType.Decimal,9),
                    new SqlParameter("@TA031", SqlDbType.Decimal,9),
                    new SqlParameter("@TA032", SqlDbType.Char,10),
                    new SqlParameter("@TA033", SqlDbType.Char,20),
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
                    new SqlParameter("@t", SqlDbType.Bit,1),
                    new SqlParameter("@TA001", SqlDbType.Char,4),
                    new SqlParameter("@TA002", SqlDbType.Char,11),
                    new SqlParameter("@TA003", SqlDbType.Char,8)};
            parameters[0].Value = model.COMPANY;
            parameters[1].Value = model.CREATOR;
            parameters[2].Value = model.USR_GROUP;
            parameters[3].Value = model.CREATE_DATE;
            parameters[4].Value = model.MODIFIER;
            parameters[5].Value = model.MODI_DATE;
            parameters[6].Value = model.FLAG;
            parameters[7].Value = model.TA004;
            parameters[8].Value = model.TA005;
            parameters[9].Value = model.TA006;
            parameters[10].Value = model.TA007;
            parameters[11].Value = model.TA008;
            parameters[12].Value = model.TA009;
            parameters[13].Value = model.TA010;
            parameters[14].Value = model.TA011;
            parameters[15].Value = model.TA012;
            parameters[16].Value = model.TA013;
            parameters[17].Value = model.TA014;
            parameters[18].Value = model.TA015;
            parameters[19].Value = model.TA016;
            parameters[20].Value = model.TA017;
            parameters[21].Value = model.TA018;
            parameters[22].Value = model.TA019;
            parameters[23].Value = model.TA020;
            parameters[24].Value = model.TA021;
            parameters[25].Value = model.TA022;
            parameters[26].Value = model.TA023;
            parameters[27].Value = model.TA024;
            parameters[28].Value = model.TA025;
            parameters[29].Value = model.TA026;
            parameters[30].Value = model.TA027;
            parameters[31].Value = model.TA028;
            parameters[32].Value = model.TA029;
            parameters[33].Value = model.TA030;
            parameters[34].Value = model.TA031;
            parameters[35].Value = model.TA032;
            parameters[36].Value = model.TA033;
            parameters[37].Value = model.UDF01;
            parameters[38].Value = model.UDF02;
            parameters[39].Value = model.UDF03;
            parameters[40].Value = model.UDF04;
            parameters[41].Value = model.UDF05;
            parameters[42].Value = model.UDF06;
            parameters[43].Value = model.UDF51;
            parameters[44].Value = model.UDF52;
            parameters[45].Value = model.UDF53;
            parameters[46].Value = model.UDF54;
            parameters[47].Value = model.UDF55;
            parameters[48].Value = model.UDF56;
            parameters[49].Value = model.UDF07;
            parameters[50].Value = model.UDF08;
            parameters[51].Value = model.UDF09;
            parameters[52].Value = model.UDF10;
            parameters[53].Value = model.UDF11;
            parameters[54].Value = model.UDF12;
            parameters[55].Value = model.UDF57;
            parameters[56].Value = model.UDF58;
            parameters[57].Value = model.UDF59;
            parameters[58].Value = model.UDF60;
            parameters[59].Value = model.UDF61;
            parameters[60].Value = model.UDF62;
            parameters[61].Value = model.t;
            parameters[62].Value = model.TA001;
            parameters[63].Value = model.TA002;
            parameters[64].Value = model.TA003;

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
        public bool Delete(string TA001, string TA002)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from INVTA ");
            strSql.Append(" where TA001=@TA001 and TA002=@TA002 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@TA001", SqlDbType.Char,4),
                    new SqlParameter("@TA002", SqlDbType.Char,11)           };
            parameters[0].Value = TA001;
            parameters[1].Value = TA002;

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
        public YJUI.Model.INVTA GetModel(string TA001, string TA002)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,TA001,TA002,TA003,TA004,TA005,TA006,TA007,TA008,TA009,TA010,TA011,TA012,TA013,TA014,TA015,TA016,TA017,TA018,TA019,TA020,TA021,TA022,TA023,TA024,TA025,TA026,TA027,TA028,TA029,TA030,TA031,TA032,TA033,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62,t from INVTA ");
            strSql.Append(" where TA001=@TA001 and TA002=@TA002 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@TA001", SqlDbType.Char,4),
                    new SqlParameter("@TA002", SqlDbType.Char,11)           };
            parameters[0].Value = TA001;
            parameters[1].Value = TA002;

            YJUI.Model.INVTA model = new YJUI.Model.INVTA();
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
        public YJUI.Model.INVTA DataRowToModel(DataRow row)
        {
            YJUI.Model.INVTA model = new YJUI.Model.INVTA();
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
                if (row["TA001"] != null)
                {
                    model.TA001 = row["TA001"].ToString();
                }
                if (row["TA002"] != null)
                {
                    model.TA002 = row["TA002"].ToString();
                }
                if (row["TA003"] != null)
                {
                    model.TA003 = row["TA003"].ToString();
                }
                if (row["TA004"] != null)
                {
                    model.TA004 = row["TA004"].ToString();
                }
                if (row["TA005"] != null)
                {
                    model.TA005 = row["TA005"].ToString();
                }
                if (row["TA006"] != null)
                {
                    model.TA006 = row["TA006"].ToString();
                }
                if (row["TA007"] != null && row["TA007"].ToString() != "")
                {
                    model.TA007 = decimal.Parse(row["TA007"].ToString());
                }
                if (row["TA008"] != null)
                {
                    model.TA008 = row["TA008"].ToString();
                }
                if (row["TA009"] != null)
                {
                    model.TA009 = row["TA009"].ToString();
                }
                if (row["TA010"] != null && row["TA010"].ToString() != "")
                {
                    model.TA010 = decimal.Parse(row["TA010"].ToString());
                }
                if (row["TA011"] != null && row["TA011"].ToString() != "")
                {
                    model.TA011 = decimal.Parse(row["TA011"].ToString());
                }
                if (row["TA012"] != null && row["TA012"].ToString() != "")
                {
                    model.TA012 = decimal.Parse(row["TA012"].ToString());
                }
                if (row["TA013"] != null)
                {
                    model.TA013 = row["TA013"].ToString();
                }
                if (row["TA014"] != null)
                {
                    model.TA014 = row["TA014"].ToString();
                }
                if (row["TA015"] != null)
                {
                    model.TA015 = row["TA015"].ToString();
                }
                if (row["TA016"] != null && row["TA016"].ToString() != "")
                {
                    model.TA016 = decimal.Parse(row["TA016"].ToString());
                }
                if (row["TA017"] != null)
                {
                    model.TA017 = row["TA017"].ToString();
                }
                if (row["TA018"] != null)
                {
                    model.TA018 = row["TA018"].ToString();
                }
                if (row["TA019"] != null)
                {
                    model.TA019 = row["TA019"].ToString();
                }
                if (row["TA020"] != null)
                {
                    model.TA020 = row["TA020"].ToString();
                }
                if (row["TA021"] != null && row["TA021"].ToString() != "")
                {
                    model.TA021 = decimal.Parse(row["TA021"].ToString());
                }
                if (row["TA022"] != null)
                {
                    model.TA022 = row["TA022"].ToString();
                }
                if (row["TA023"] != null)
                {
                    model.TA023 = row["TA023"].ToString();
                }
                if (row["TA024"] != null)
                {
                    model.TA024 = row["TA024"].ToString();
                }
                if (row["TA025"] != null)
                {
                    model.TA025 = row["TA025"].ToString();
                }
                if (row["TA026"] != null)
                {
                    model.TA026 = row["TA026"].ToString();
                }
                if (row["TA027"] != null)
                {
                    model.TA027 = row["TA027"].ToString();
                }
                if (row["TA028"] != null)
                {
                    model.TA028 = row["TA028"].ToString();
                }
                if (row["TA029"] != null && row["TA029"].ToString() != "")
                {
                    model.TA029 = decimal.Parse(row["TA029"].ToString());
                }
                if (row["TA030"] != null && row["TA030"].ToString() != "")
                {
                    model.TA030 = decimal.Parse(row["TA030"].ToString());
                }
                if (row["TA031"] != null && row["TA031"].ToString() != "")
                {
                    model.TA031 = decimal.Parse(row["TA031"].ToString());
                }
                if (row["TA032"] != null)
                {
                    model.TA032 = row["TA032"].ToString();
                }
                if (row["TA033"] != null)
                {
                    model.TA033 = row["TA033"].ToString();
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
                if (row["t"] != null && row["t"].ToString() != "")
                {
                    if ((row["t"].ToString() == "1") || (row["t"].ToString().ToLower() == "true"))
                    {
                        model.t = true;
                    }
                    else
                    {
                        model.t = false;
                    }
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
            strSql.Append("select COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,TA001,TA002,TA003,TA004,TA005,TA006,TA007,TA008,TA009,TA010,TA011,TA012,TA013,TA014,TA015,TA016,TA017,TA018,TA019,TA020,TA021,TA022,TA023,TA024,TA025,TA026,TA027,TA028,TA029,TA030,TA031,TA032,TA033,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62,t ");
            strSql.Append(" FROM INVTA ");
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
            strSql.Append(" COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,TA001,TA002,TA003,TA004,TA005,TA006,TA007,TA008,TA009,TA010,TA011,TA012,TA013,TA014,TA015,TA016,TA017,TA018,TA019,TA020,TA021,TA022,TA023,TA024,TA025,TA026,TA027,TA028,TA029,TA030,TA031,TA032,TA033,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62,t ");
            strSql.Append(" FROM INVTA ");
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
            strSql.Append("select count(1) FROM INVTA ");
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
                strSql.Append("order by T.TA002 desc");
            }
            strSql.Append(")AS Row, T.*  from INVTA T ");
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
        /// 通过单别和日期生成ERP号
        /// </summary>
        /// <param name="danbie">单别</param>
        /// <param name="date">日期</param>
        /// <returns></returns>
        public string GetInvtaErpNum(string danbie,string date) {
            string num = null;
            if (danbie != null && date != null&&danbie!=""&&date!="")
            {
                // orderNoField, table, columnName, SingleName, datecolumnName, date
                num = ErpUtil.GetErpNum("INVTA",  "TA001", danbie,"TA002", "TA014", date);
            }
            return num;
        }
        #endregion  ExtensionMethod
    }
}

