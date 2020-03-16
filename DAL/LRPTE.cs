using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using YJUI.DBUtility;//Please add references
namespace YJUI.DAL
{
    /// <summary>
    /// 数据访问类:LRPTE
    /// </summary>
    public partial class LRPTE
    {
        public LRPTE()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string TE003, string TE004, string TE005, string TE006, string TE007, string TE009, string TE001, string TE002)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from LRPTE");
            strSql.Append(" where TE003=@TE003 and TE004=@TE004 and TE005=@TE005 and TE006=@TE006 and TE007=@TE007 and TE009=@TE009 and TE001=@TE001 and TE002=@TE002 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@TE003", SqlDbType.Char,8),
                    new SqlParameter("@TE004", SqlDbType.Char,10),
                    new SqlParameter("@TE005", SqlDbType.Char,1),
                    new SqlParameter("@TE006", SqlDbType.Char,5),
                    new SqlParameter("@TE007", SqlDbType.Char,8),
                    new SqlParameter("@TE009", SqlDbType.Char,4),
                    new SqlParameter("@TE001", SqlDbType.Char,20),
                    new SqlParameter("@TE002", SqlDbType.Char,20)           };
            parameters[0].Value = TE003;
            parameters[1].Value = TE004;
            parameters[2].Value = TE005;
            parameters[3].Value = TE006;
            parameters[4].Value = TE007;
            parameters[5].Value = TE009;
            parameters[6].Value = TE001;
            parameters[7].Value = TE002;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YJUI.Model.LRPTE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into LRPTE(");
            strSql.Append("COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,TE001,TE002,TE003,TE004,TE005,TE006,TE007,TE008,TE009,TE010,TE011,TE012,TE013,TE014,TE015,TE016,TE017,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62)");
            strSql.Append(" values (");
            strSql.Append("@COMPANY,@CREATOR,@USR_GROUP,@CREATE_DATE,@MODIFIER,@MODI_DATE,@FLAG,@TE001,@TE002,@TE003,@TE004,@TE005,@TE006,@TE007,@TE008,@TE009,@TE010,@TE011,@TE012,@TE013,@TE014,@TE015,@TE016,@TE017,@UDF01,@UDF02,@UDF03,@UDF04,@UDF05,@UDF06,@UDF51,@UDF52,@UDF53,@UDF54,@UDF55,@UDF56,@UDF07,@UDF08,@UDF09,@UDF10,@UDF11,@UDF12,@UDF57,@UDF58,@UDF59,@UDF60,@UDF61,@UDF62)");
            SqlParameter[] parameters = {
                    new SqlParameter("@COMPANY", SqlDbType.Char,10),
                    new SqlParameter("@CREATOR", SqlDbType.Char,10),
                    new SqlParameter("@USR_GROUP", SqlDbType.Char,10),
                    new SqlParameter("@CREATE_DATE", SqlDbType.Char,17),
                    new SqlParameter("@MODIFIER", SqlDbType.Char,10),
                    new SqlParameter("@MODI_DATE", SqlDbType.Char,17),
                    new SqlParameter("@FLAG", SqlDbType.Decimal,5),
                    new SqlParameter("@TE001", SqlDbType.Char,20),
                    new SqlParameter("@TE002", SqlDbType.Char,20),
                    new SqlParameter("@TE003", SqlDbType.Char,8),
                    new SqlParameter("@TE004", SqlDbType.Char,10),
                    new SqlParameter("@TE005", SqlDbType.Char,1),
                    new SqlParameter("@TE006", SqlDbType.Char,5),
                    new SqlParameter("@TE007", SqlDbType.Char,8),
                    new SqlParameter("@TE008", SqlDbType.Decimal,9),
                    new SqlParameter("@TE009", SqlDbType.Char,4),
                    new SqlParameter("@TE010", SqlDbType.Decimal,9),
                    new SqlParameter("@TE011", SqlDbType.Char,1),
                    new SqlParameter("@TE012", SqlDbType.Char,1),
                    new SqlParameter("@TE013", SqlDbType.Char,8),
                    new SqlParameter("@TE014", SqlDbType.VarChar,30),
                    new SqlParameter("@TE015", SqlDbType.Decimal,9),
                    new SqlParameter("@TE016", SqlDbType.Decimal,9),
                    new SqlParameter("@TE017", SqlDbType.Decimal,9),
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
            parameters[7].Value = model.TE001;
            parameters[8].Value = model.TE002;
            parameters[9].Value = model.TE003;
            parameters[10].Value = model.TE004;
            parameters[11].Value = model.TE005;
            parameters[12].Value = model.TE006;
            parameters[13].Value = model.TE007;
            parameters[14].Value = model.TE008;
            parameters[15].Value = model.TE009;
            parameters[16].Value = model.TE010;
            parameters[17].Value = model.TE011;
            parameters[18].Value = model.TE012;
            parameters[19].Value = model.TE013;
            parameters[20].Value = model.TE014;
            parameters[21].Value = model.TE015;
            parameters[22].Value = model.TE016;
            parameters[23].Value = model.TE017;
            parameters[24].Value = model.UDF01;
            parameters[25].Value = model.UDF02;
            parameters[26].Value = model.UDF03;
            parameters[27].Value = model.UDF04;
            parameters[28].Value = model.UDF05;
            parameters[29].Value = model.UDF06;
            parameters[30].Value = model.UDF51;
            parameters[31].Value = model.UDF52;
            parameters[32].Value = model.UDF53;
            parameters[33].Value = model.UDF54;
            parameters[34].Value = model.UDF55;
            parameters[35].Value = model.UDF56;
            parameters[36].Value = model.UDF07;
            parameters[37].Value = model.UDF08;
            parameters[38].Value = model.UDF09;
            parameters[39].Value = model.UDF10;
            parameters[40].Value = model.UDF11;
            parameters[41].Value = model.UDF12;
            parameters[42].Value = model.UDF57;
            parameters[43].Value = model.UDF58;
            parameters[44].Value = model.UDF59;
            parameters[45].Value = model.UDF60;
            parameters[46].Value = model.UDF61;
            parameters[47].Value = model.UDF62;

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
        public bool Update(YJUI.Model.LRPTE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update LRPTE set ");
            strSql.Append("COMPANY=@COMPANY,");
            strSql.Append("CREATOR=@CREATOR,");
            strSql.Append("USR_GROUP=@USR_GROUP,");
            strSql.Append("CREATE_DATE=@CREATE_DATE,");
            strSql.Append("MODIFIER=@MODIFIER,");
            strSql.Append("MODI_DATE=@MODI_DATE,");
            strSql.Append("FLAG=@FLAG,");
            strSql.Append("TE008=@TE008,");
            strSql.Append("TE010=@TE010,");
            strSql.Append("TE011=@TE011,");
            strSql.Append("TE012=@TE012,");
            strSql.Append("TE013=@TE013,");
            strSql.Append("TE014=@TE014,");
            strSql.Append("TE015=@TE015,");
            strSql.Append("TE016=@TE016,");
            strSql.Append("TE017=@TE017,");
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
            strSql.Append(" where TE003=@TE003 and TE004=@TE004 and TE005=@TE005 and TE006=@TE006 and TE007=@TE007 and TE009=@TE009 and TE001=@TE001 and TE002=@TE002 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@COMPANY", SqlDbType.Char,10),
                    new SqlParameter("@CREATOR", SqlDbType.Char,10),
                    new SqlParameter("@USR_GROUP", SqlDbType.Char,10),
                    new SqlParameter("@CREATE_DATE", SqlDbType.Char,17),
                    new SqlParameter("@MODIFIER", SqlDbType.Char,10),
                    new SqlParameter("@MODI_DATE", SqlDbType.Char,17),
                    new SqlParameter("@FLAG", SqlDbType.Decimal,5),
                    new SqlParameter("@TE008", SqlDbType.Decimal,9),
                    new SqlParameter("@TE010", SqlDbType.Decimal,9),
                    new SqlParameter("@TE011", SqlDbType.Char,1),
                    new SqlParameter("@TE012", SqlDbType.Char,1),
                    new SqlParameter("@TE013", SqlDbType.Char,8),
                    new SqlParameter("@TE014", SqlDbType.VarChar,30),
                    new SqlParameter("@TE015", SqlDbType.Decimal,9),
                    new SqlParameter("@TE016", SqlDbType.Decimal,9),
                    new SqlParameter("@TE017", SqlDbType.Decimal,9),
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
                    new SqlParameter("@TE001", SqlDbType.Char,20),
                    new SqlParameter("@TE002", SqlDbType.Char,20),
                    new SqlParameter("@TE003", SqlDbType.Char,8),
                    new SqlParameter("@TE004", SqlDbType.Char,10),
                    new SqlParameter("@TE005", SqlDbType.Char,1),
                    new SqlParameter("@TE006", SqlDbType.Char,5),
                    new SqlParameter("@TE007", SqlDbType.Char,8),
                    new SqlParameter("@TE009", SqlDbType.Char,4)};
            parameters[0].Value = model.COMPANY;
            parameters[1].Value = model.CREATOR;
            parameters[2].Value = model.USR_GROUP;
            parameters[3].Value = model.CREATE_DATE;
            parameters[4].Value = model.MODIFIER;
            parameters[5].Value = model.MODI_DATE;
            parameters[6].Value = model.FLAG;
            parameters[7].Value = model.TE008;
            parameters[8].Value = model.TE010;
            parameters[9].Value = model.TE011;
            parameters[10].Value = model.TE012;
            parameters[11].Value = model.TE013;
            parameters[12].Value = model.TE014;
            parameters[13].Value = model.TE015;
            parameters[14].Value = model.TE016;
            parameters[15].Value = model.TE017;
            parameters[16].Value = model.UDF01;
            parameters[17].Value = model.UDF02;
            parameters[18].Value = model.UDF03;
            parameters[19].Value = model.UDF04;
            parameters[20].Value = model.UDF05;
            parameters[21].Value = model.UDF06;
            parameters[22].Value = model.UDF51;
            parameters[23].Value = model.UDF52;
            parameters[24].Value = model.UDF53;
            parameters[25].Value = model.UDF54;
            parameters[26].Value = model.UDF55;
            parameters[27].Value = model.UDF56;
            parameters[28].Value = model.UDF07;
            parameters[29].Value = model.UDF08;
            parameters[30].Value = model.UDF09;
            parameters[31].Value = model.UDF10;
            parameters[32].Value = model.UDF11;
            parameters[33].Value = model.UDF12;
            parameters[34].Value = model.UDF57;
            parameters[35].Value = model.UDF58;
            parameters[36].Value = model.UDF59;
            parameters[37].Value = model.UDF60;
            parameters[38].Value = model.UDF61;
            parameters[39].Value = model.UDF62;
            parameters[40].Value = model.TE001;
            parameters[41].Value = model.TE002;
            parameters[42].Value = model.TE003;
            parameters[43].Value = model.TE004;
            parameters[44].Value = model.TE005;
            parameters[45].Value = model.TE006;
            parameters[46].Value = model.TE007;
            parameters[47].Value = model.TE009;

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
        public bool Delete(string TE003, string TE004, string TE005, string TE006, string TE007, string TE009, string TE001, string TE002)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from LRPTE ");
            strSql.Append(" where TE003=@TE003 and TE004=@TE004 and TE005=@TE005 and TE006=@TE006 and TE007=@TE007 and TE009=@TE009 and TE001=@TE001 and TE002=@TE002 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@TE003", SqlDbType.Char,8),
                    new SqlParameter("@TE004", SqlDbType.Char,10),
                    new SqlParameter("@TE005", SqlDbType.Char,1),
                    new SqlParameter("@TE006", SqlDbType.Char,5),
                    new SqlParameter("@TE007", SqlDbType.Char,8),
                    new SqlParameter("@TE009", SqlDbType.Char,4),
                    new SqlParameter("@TE001", SqlDbType.Char,20),
                    new SqlParameter("@TE002", SqlDbType.Char,20)           };
            parameters[0].Value = TE003;
            parameters[1].Value = TE004;
            parameters[2].Value = TE005;
            parameters[3].Value = TE006;
            parameters[4].Value = TE007;
            parameters[5].Value = TE009;
            parameters[6].Value = TE001;
            parameters[7].Value = TE002;

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
        public YJUI.Model.LRPTE GetModel(string TE003, string TE004, string TE005, string TE006, string TE007, string TE009, string TE001, string TE002)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,TE001,TE002,TE003,TE004,TE005,TE006,TE007,TE008,TE009,TE010,TE011,TE012,TE013,TE014,TE015,TE016,TE017,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62 from LRPTE ");
            strSql.Append(" where TE003=@TE003 and TE004=@TE004 and TE005=@TE005 and TE006=@TE006 and TE007=@TE007 and TE009=@TE009 and TE001=@TE001 and TE002=@TE002 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@TE003", SqlDbType.Char,8),
                    new SqlParameter("@TE004", SqlDbType.Char,10),
                    new SqlParameter("@TE005", SqlDbType.Char,1),
                    new SqlParameter("@TE006", SqlDbType.Char,5),
                    new SqlParameter("@TE007", SqlDbType.Char,8),
                    new SqlParameter("@TE009", SqlDbType.Char,4),
                    new SqlParameter("@TE001", SqlDbType.Char,20),
                    new SqlParameter("@TE002", SqlDbType.Char,20)           };
            parameters[0].Value = TE003;
            parameters[1].Value = TE004;
            parameters[2].Value = TE005;
            parameters[3].Value = TE006;
            parameters[4].Value = TE007;
            parameters[5].Value = TE009;
            parameters[6].Value = TE001;
            parameters[7].Value = TE002;

            YJUI.Model.LRPTE model = new YJUI.Model.LRPTE();
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
        public YJUI.Model.LRPTE DataRowToModel(DataRow row)
        {
            YJUI.Model.LRPTE model = new YJUI.Model.LRPTE();
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
                if (row["TE001"] != null)
                {
                    model.TE001 = row["TE001"].ToString();
                }
                if (row["TE002"] != null)
                {
                    model.TE002 = row["TE002"].ToString();
                }
                if (row["TE003"] != null)
                {
                    model.TE003 = row["TE003"].ToString();
                }
                if (row["TE004"] != null)
                {
                    model.TE004 = row["TE004"].ToString();
                }
                if (row["TE005"] != null)
                {
                    model.TE005 = row["TE005"].ToString();
                }
                if (row["TE006"] != null)
                {
                    model.TE006 = row["TE006"].ToString();
                }
                if (row["TE007"] != null)
                {
                    model.TE007 = row["TE007"].ToString();
                }
                if (row["TE008"] != null && row["TE008"].ToString() != "")
                {
                    model.TE008 = decimal.Parse(row["TE008"].ToString());
                }
                if (row["TE009"] != null)
                {
                    model.TE009 = row["TE009"].ToString();
                }
                if (row["TE010"] != null && row["TE010"].ToString() != "")
                {
                    model.TE010 = decimal.Parse(row["TE010"].ToString());
                }
                if (row["TE011"] != null)
                {
                    model.TE011 = row["TE011"].ToString();
                }
                if (row["TE012"] != null)
                {
                    model.TE012 = row["TE012"].ToString();
                }
                if (row["TE013"] != null)
                {
                    model.TE013 = row["TE013"].ToString();
                }
                if (row["TE014"] != null)
                {
                    model.TE014 = row["TE014"].ToString();
                }
                if (row["TE015"] != null && row["TE015"].ToString() != "")
                {
                    model.TE015 = decimal.Parse(row["TE015"].ToString());
                }
                if (row["TE016"] != null && row["TE016"].ToString() != "")
                {
                    model.TE016 = decimal.Parse(row["TE016"].ToString());
                }
                if (row["TE017"] != null && row["TE017"].ToString() != "")
                {
                    model.TE017 = decimal.Parse(row["TE017"].ToString());
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
            strSql.Append("select COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,TE001,TE002,TE003,TE004,TE005,TE006,TE007,TE008,TE009,TE010,TE011,TE012,TE013,TE014,TE015,TE016,TE017,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62 ");
            strSql.Append(" FROM LRPTE ");
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
            strSql.Append(" COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,TE001,TE002,TE003,TE004,TE005,TE006,TE007,TE008,TE009,TE010,TE011,TE012,TE013,TE014,TE015,TE016,TE017,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62 ");
            strSql.Append(" FROM LRPTE ");
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
            strSql.Append("select count(1) FROM LRPTE ");
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
                strSql.Append("order by T.TE002 desc");
            }
            strSql.Append(")AS Row, T.*  from LRPTE T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "LRPTE";
			parameters[1].Value = "TE002";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

