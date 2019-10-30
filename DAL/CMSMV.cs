using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using YJUI.DBUtility;//Please add references
namespace YJUI.DAL
{
    /// <summary>
    /// 数据访问类:CMSMV
    /// </summary>
    public partial class CMSMV
    {
        public CMSMV()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string MV001)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CMSMV");
            strSql.Append(" where MV001=@MV001 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@MV001", SqlDbType.Char,10)           };
            parameters[0].Value = MV001;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YJUI.Model.CMSMV model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CMSMV(");
            strSql.Append("COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,MV001,MV002,MV003,MV004,MV005,MV006,MV007,MV008,MV009,MV010,MV011,MV012,MV013,MV014,MV015,MV016,MV017,MV018,MV019,MV020,MV021,MV022,MV023,MV024,MV025,MV026,MV027,MV028,MV029,MV030,MV031,MV032,MV033,MV034,MV035,MV036,MV037,MV038,MV039,MV040,MV041,MV042,MV043,MV044,MV045,MV046,MV047,MV048,MV049,MV050,MV051,MV052,MV053,MV054,MV055,MV056,MV057,MV058,MV059,MV060,MV061,MV062,MV063,MV064,MV065,MV066,MV067,MV068,MV069,MV070,MV071,MV072,MV073,MV074,MV075,MV076,MV077,MV078,MV079,MV080,MV081,MV082,MV083,MV084,MV085,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62)");
            strSql.Append(" values (");
            strSql.Append("@COMPANY,@CREATOR,@USR_GROUP,@CREATE_DATE,@MODIFIER,@MODI_DATE,@FLAG,@MV001,@MV002,@MV003,@MV004,@MV005,@MV006,@MV007,@MV008,@MV009,@MV010,@MV011,@MV012,@MV013,@MV014,@MV015,@MV016,@MV017,@MV018,@MV019,@MV020,@MV021,@MV022,@MV023,@MV024,@MV025,@MV026,@MV027,@MV028,@MV029,@MV030,@MV031,@MV032,@MV033,@MV034,@MV035,@MV036,@MV037,@MV038,@MV039,@MV040,@MV041,@MV042,@MV043,@MV044,@MV045,@MV046,@MV047,@MV048,@MV049,@MV050,@MV051,@MV052,@MV053,@MV054,@MV055,@MV056,@MV057,@MV058,@MV059,@MV060,@MV061,@MV062,@MV063,@MV064,@MV065,@MV066,@MV067,@MV068,@MV069,@MV070,@MV071,@MV072,@MV073,@MV074,@MV075,@MV076,@MV077,@MV078,@MV079,@MV080,@MV081,@MV082,@MV083,@MV084,@MV085,@UDF01,@UDF02,@UDF03,@UDF04,@UDF05,@UDF06,@UDF51,@UDF52,@UDF53,@UDF54,@UDF55,@UDF56,@UDF07,@UDF08,@UDF09,@UDF10,@UDF11,@UDF12,@UDF57,@UDF58,@UDF59,@UDF60,@UDF61,@UDF62)");
            SqlParameter[] parameters = {
                    new SqlParameter("@COMPANY", SqlDbType.Char,10),
                    new SqlParameter("@CREATOR", SqlDbType.Char,10),
                    new SqlParameter("@USR_GROUP", SqlDbType.Char,10),
                    new SqlParameter("@CREATE_DATE", SqlDbType.Char,17),
                    new SqlParameter("@MODIFIER", SqlDbType.Char,10),
                    new SqlParameter("@MODI_DATE", SqlDbType.Char,17),
                    new SqlParameter("@FLAG", SqlDbType.Decimal,5),
                    new SqlParameter("@MV001", SqlDbType.Char,10),
                    new SqlParameter("@MV002", SqlDbType.Char,10),
                    new SqlParameter("@MV003", SqlDbType.Char,10),
                    new SqlParameter("@MV004", SqlDbType.Char,6),
                    new SqlParameter("@MV005", SqlDbType.Char,8),
                    new SqlParameter("@MV006", SqlDbType.Char,6),
                    new SqlParameter("@MV007", SqlDbType.Char,1),
                    new SqlParameter("@MV008", SqlDbType.Char,8),
                    new SqlParameter("@MV009", SqlDbType.Char,18),
                    new SqlParameter("@MV010", SqlDbType.Char,1),
                    new SqlParameter("@MV011", SqlDbType.Char,1),
                    new SqlParameter("@MV012", SqlDbType.Char,8),
                    new SqlParameter("@MV013", SqlDbType.Char,72),
                    new SqlParameter("@MV014", SqlDbType.Char,1),
                    new SqlParameter("@MV015", SqlDbType.Char,20),
                    new SqlParameter("@MV016", SqlDbType.Char,20),
                    new SqlParameter("@MV017", SqlDbType.Char,60),
                    new SqlParameter("@MV018", SqlDbType.Char,10),
                    new SqlParameter("@MV019", SqlDbType.Char,72),
                    new SqlParameter("@MV020", SqlDbType.VarChar,255),
                    new SqlParameter("@MV021", SqlDbType.Char,8),
                    new SqlParameter("@MV022", SqlDbType.Char,8),
                    new SqlParameter("@MV023", SqlDbType.Char,8),
                    new SqlParameter("@MV024", SqlDbType.Char,1),
                    new SqlParameter("@MV025", SqlDbType.Char,10),
                    new SqlParameter("@MV026", SqlDbType.Char,1),
                    new SqlParameter("@MV027", SqlDbType.Char,3),
                    new SqlParameter("@MV028", SqlDbType.Char,10),
                    new SqlParameter("@MV029", SqlDbType.Char,10),
                    new SqlParameter("@MV030", SqlDbType.Char,10),
                    new SqlParameter("@MV031", SqlDbType.Decimal,5),
                    new SqlParameter("@MV032", SqlDbType.Char,1),
                    new SqlParameter("@MV033", SqlDbType.Decimal,9),
                    new SqlParameter("@MV034", SqlDbType.Char,1),
                    new SqlParameter("@MV035", SqlDbType.Char,10),
                    new SqlParameter("@MV036", SqlDbType.Char,30),
                    new SqlParameter("@MV037", SqlDbType.Decimal,5),
                    new SqlParameter("@MV038", SqlDbType.Char,1),
                    new SqlParameter("@MV039", SqlDbType.Decimal,9),
                    new SqlParameter("@MV040", SqlDbType.Decimal,5),
                    new SqlParameter("@MV041", SqlDbType.Char,1),
                    new SqlParameter("@MV042", SqlDbType.Char,1),
                    new SqlParameter("@MV043", SqlDbType.Decimal,9),
                    new SqlParameter("@MV044", SqlDbType.Char,1),
                    new SqlParameter("@MV045", SqlDbType.Decimal,9),
                    new SqlParameter("@MV046", SqlDbType.VarChar,255),
                    new SqlParameter("@MV047", SqlDbType.Char,30),
                    new SqlParameter("@MV048", SqlDbType.Char,8),
                    new SqlParameter("@MV049", SqlDbType.Char,8),
                    new SqlParameter("@MV050", SqlDbType.Char,8),
                    new SqlParameter("@MV051", SqlDbType.Char,12),
                    new SqlParameter("@MV052", SqlDbType.Char,8),
                    new SqlParameter("@MV053", SqlDbType.Char,8),
                    new SqlParameter("@MV054", SqlDbType.Char,2),
                    new SqlParameter("@MV055", SqlDbType.Decimal,9),
                    new SqlParameter("@MV056", SqlDbType.Decimal,9),
                    new SqlParameter("@MV057", SqlDbType.Char,12),
                    new SqlParameter("@MV058", SqlDbType.Char,10),
                    new SqlParameter("@MV059", SqlDbType.Char,8),
                    new SqlParameter("@MV060", SqlDbType.Char,8),
                    new SqlParameter("@MV061", SqlDbType.Char,1),
                    new SqlParameter("@MV062", SqlDbType.Char,20),
                    new SqlParameter("@MV063", SqlDbType.VarChar,255),
                    new SqlParameter("@MV064", SqlDbType.Char,1),
                    new SqlParameter("@MV065", SqlDbType.Char,12),
                    new SqlParameter("@MV066", SqlDbType.Char,1),
                    new SqlParameter("@MV067", SqlDbType.Char,10),
                    new SqlParameter("@MV068", SqlDbType.Char,10),
                    new SqlParameter("@MV069", SqlDbType.Char,6),
                    new SqlParameter("@MV070", SqlDbType.Char,10),
                    new SqlParameter("@MV071", SqlDbType.Char,6),
                    new SqlParameter("@MV072", SqlDbType.Char,6),
                    new SqlParameter("@MV073", SqlDbType.Char,6),
                    new SqlParameter("@MV074", SqlDbType.Char,60),
                    new SqlParameter("@MV075", SqlDbType.Char,10),
                    new SqlParameter("@MV076", SqlDbType.Char,10),
                    new SqlParameter("@MV077", SqlDbType.Char,1),
                    new SqlParameter("@MV078", SqlDbType.Char,8),
                    new SqlParameter("@MV079", SqlDbType.VarChar,30),
                    new SqlParameter("@MV080", SqlDbType.Decimal,9),
                    new SqlParameter("@MV081", SqlDbType.Decimal,9),
                    new SqlParameter("@MV082", SqlDbType.Decimal,9),
                    new SqlParameter("@MV083", SqlDbType.Char,10),
                    new SqlParameter("@MV084", SqlDbType.Char,30),
                    new SqlParameter("@MV085", SqlDbType.Char,1),
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
            parameters[7].Value = model.MV001;
            parameters[8].Value = model.MV002;
            parameters[9].Value = model.MV003;
            parameters[10].Value = model.MV004;
            parameters[11].Value = model.MV005;
            parameters[12].Value = model.MV006;
            parameters[13].Value = model.MV007;
            parameters[14].Value = model.MV008;
            parameters[15].Value = model.MV009;
            parameters[16].Value = model.MV010;
            parameters[17].Value = model.MV011;
            parameters[18].Value = model.MV012;
            parameters[19].Value = model.MV013;
            parameters[20].Value = model.MV014;
            parameters[21].Value = model.MV015;
            parameters[22].Value = model.MV016;
            parameters[23].Value = model.MV017;
            parameters[24].Value = model.MV018;
            parameters[25].Value = model.MV019;
            parameters[26].Value = model.MV020;
            parameters[27].Value = model.MV021;
            parameters[28].Value = model.MV022;
            parameters[29].Value = model.MV023;
            parameters[30].Value = model.MV024;
            parameters[31].Value = model.MV025;
            parameters[32].Value = model.MV026;
            parameters[33].Value = model.MV027;
            parameters[34].Value = model.MV028;
            parameters[35].Value = model.MV029;
            parameters[36].Value = model.MV030;
            parameters[37].Value = model.MV031;
            parameters[38].Value = model.MV032;
            parameters[39].Value = model.MV033;
            parameters[40].Value = model.MV034;
            parameters[41].Value = model.MV035;
            parameters[42].Value = model.MV036;
            parameters[43].Value = model.MV037;
            parameters[44].Value = model.MV038;
            parameters[45].Value = model.MV039;
            parameters[46].Value = model.MV040;
            parameters[47].Value = model.MV041;
            parameters[48].Value = model.MV042;
            parameters[49].Value = model.MV043;
            parameters[50].Value = model.MV044;
            parameters[51].Value = model.MV045;
            parameters[52].Value = model.MV046;
            parameters[53].Value = model.MV047;
            parameters[54].Value = model.MV048;
            parameters[55].Value = model.MV049;
            parameters[56].Value = model.MV050;
            parameters[57].Value = model.MV051;
            parameters[58].Value = model.MV052;
            parameters[59].Value = model.MV053;
            parameters[60].Value = model.MV054;
            parameters[61].Value = model.MV055;
            parameters[62].Value = model.MV056;
            parameters[63].Value = model.MV057;
            parameters[64].Value = model.MV058;
            parameters[65].Value = model.MV059;
            parameters[66].Value = model.MV060;
            parameters[67].Value = model.MV061;
            parameters[68].Value = model.MV062;
            parameters[69].Value = model.MV063;
            parameters[70].Value = model.MV064;
            parameters[71].Value = model.MV065;
            parameters[72].Value = model.MV066;
            parameters[73].Value = model.MV067;
            parameters[74].Value = model.MV068;
            parameters[75].Value = model.MV069;
            parameters[76].Value = model.MV070;
            parameters[77].Value = model.MV071;
            parameters[78].Value = model.MV072;
            parameters[79].Value = model.MV073;
            parameters[80].Value = model.MV074;
            parameters[81].Value = model.MV075;
            parameters[82].Value = model.MV076;
            parameters[83].Value = model.MV077;
            parameters[84].Value = model.MV078;
            parameters[85].Value = model.MV079;
            parameters[86].Value = model.MV080;
            parameters[87].Value = model.MV081;
            parameters[88].Value = model.MV082;
            parameters[89].Value = model.MV083;
            parameters[90].Value = model.MV084;
            parameters[91].Value = model.MV085;
            parameters[92].Value = model.UDF01;
            parameters[93].Value = model.UDF02;
            parameters[94].Value = model.UDF03;
            parameters[95].Value = model.UDF04;
            parameters[96].Value = model.UDF05;
            parameters[97].Value = model.UDF06;
            parameters[98].Value = model.UDF51;
            parameters[99].Value = model.UDF52;
            parameters[100].Value = model.UDF53;
            parameters[101].Value = model.UDF54;
            parameters[102].Value = model.UDF55;
            parameters[103].Value = model.UDF56;
            parameters[104].Value = model.UDF07;
            parameters[105].Value = model.UDF08;
            parameters[106].Value = model.UDF09;
            parameters[107].Value = model.UDF10;
            parameters[108].Value = model.UDF11;
            parameters[109].Value = model.UDF12;
            parameters[110].Value = model.UDF57;
            parameters[111].Value = model.UDF58;
            parameters[112].Value = model.UDF59;
            parameters[113].Value = model.UDF60;
            parameters[114].Value = model.UDF61;
            parameters[115].Value = model.UDF62;

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
        public bool Update(YJUI.Model.CMSMV model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CMSMV set ");
            strSql.Append("COMPANY=@COMPANY,");
            strSql.Append("CREATOR=@CREATOR,");
            strSql.Append("USR_GROUP=@USR_GROUP,");
            strSql.Append("CREATE_DATE=@CREATE_DATE,");
            strSql.Append("MODIFIER=@MODIFIER,");
            strSql.Append("MODI_DATE=@MODI_DATE,");
            strSql.Append("FLAG=@FLAG,");
            strSql.Append("MV003=@MV003,");
            strSql.Append("MV005=@MV005,");
            strSql.Append("MV006=@MV006,");
            strSql.Append("MV007=@MV007,");
            strSql.Append("MV008=@MV008,");
            strSql.Append("MV009=@MV009,");
            strSql.Append("MV010=@MV010,");
            strSql.Append("MV011=@MV011,");
            strSql.Append("MV012=@MV012,");
            strSql.Append("MV013=@MV013,");
            strSql.Append("MV014=@MV014,");
            strSql.Append("MV015=@MV015,");
            strSql.Append("MV016=@MV016,");
            strSql.Append("MV017=@MV017,");
            strSql.Append("MV018=@MV018,");
            strSql.Append("MV019=@MV019,");
            strSql.Append("MV020=@MV020,");
            strSql.Append("MV021=@MV021,");
            strSql.Append("MV022=@MV022,");
            strSql.Append("MV023=@MV023,");
            strSql.Append("MV024=@MV024,");
            strSql.Append("MV025=@MV025,");
            strSql.Append("MV026=@MV026,");
            strSql.Append("MV027=@MV027,");
            strSql.Append("MV028=@MV028,");
            strSql.Append("MV029=@MV029,");
            strSql.Append("MV030=@MV030,");
            strSql.Append("MV031=@MV031,");
            strSql.Append("MV032=@MV032,");
            strSql.Append("MV033=@MV033,");
            strSql.Append("MV034=@MV034,");
            strSql.Append("MV035=@MV035,");
            strSql.Append("MV036=@MV036,");
            strSql.Append("MV037=@MV037,");
            strSql.Append("MV038=@MV038,");
            strSql.Append("MV039=@MV039,");
            strSql.Append("MV040=@MV040,");
            strSql.Append("MV041=@MV041,");
            strSql.Append("MV042=@MV042,");
            strSql.Append("MV043=@MV043,");
            strSql.Append("MV044=@MV044,");
            strSql.Append("MV045=@MV045,");
            strSql.Append("MV046=@MV046,");
            strSql.Append("MV047=@MV047,");
            strSql.Append("MV048=@MV048,");
            strSql.Append("MV049=@MV049,");
            strSql.Append("MV050=@MV050,");
            strSql.Append("MV051=@MV051,");
            strSql.Append("MV052=@MV052,");
            strSql.Append("MV053=@MV053,");
            strSql.Append("MV054=@MV054,");
            strSql.Append("MV055=@MV055,");
            strSql.Append("MV056=@MV056,");
            strSql.Append("MV057=@MV057,");
            strSql.Append("MV058=@MV058,");
            strSql.Append("MV059=@MV059,");
            strSql.Append("MV060=@MV060,");
            strSql.Append("MV061=@MV061,");
            strSql.Append("MV062=@MV062,");
            strSql.Append("MV063=@MV063,");
            strSql.Append("MV064=@MV064,");
            strSql.Append("MV065=@MV065,");
            strSql.Append("MV066=@MV066,");
            strSql.Append("MV067=@MV067,");
            strSql.Append("MV068=@MV068,");
            strSql.Append("MV069=@MV069,");
            strSql.Append("MV070=@MV070,");
            strSql.Append("MV071=@MV071,");
            strSql.Append("MV072=@MV072,");
            strSql.Append("MV073=@MV073,");
            strSql.Append("MV074=@MV074,");
            strSql.Append("MV075=@MV075,");
            strSql.Append("MV076=@MV076,");
            strSql.Append("MV077=@MV077,");
            strSql.Append("MV078=@MV078,");
            strSql.Append("MV079=@MV079,");
            strSql.Append("MV080=@MV080,");
            strSql.Append("MV081=@MV081,");
            strSql.Append("MV082=@MV082,");
            strSql.Append("MV083=@MV083,");
            strSql.Append("MV084=@MV084,");
            strSql.Append("MV085=@MV085,");
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
            strSql.Append(" where MV001=@MV001 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@COMPANY", SqlDbType.Char,10),
                    new SqlParameter("@CREATOR", SqlDbType.Char,10),
                    new SqlParameter("@USR_GROUP", SqlDbType.Char,10),
                    new SqlParameter("@CREATE_DATE", SqlDbType.Char,17),
                    new SqlParameter("@MODIFIER", SqlDbType.Char,10),
                    new SqlParameter("@MODI_DATE", SqlDbType.Char,17),
                    new SqlParameter("@FLAG", SqlDbType.Decimal,5),
                    new SqlParameter("@MV003", SqlDbType.Char,10),
                    new SqlParameter("@MV005", SqlDbType.Char,8),
                    new SqlParameter("@MV006", SqlDbType.Char,6),
                    new SqlParameter("@MV007", SqlDbType.Char,1),
                    new SqlParameter("@MV008", SqlDbType.Char,8),
                    new SqlParameter("@MV009", SqlDbType.Char,18),
                    new SqlParameter("@MV010", SqlDbType.Char,1),
                    new SqlParameter("@MV011", SqlDbType.Char,1),
                    new SqlParameter("@MV012", SqlDbType.Char,8),
                    new SqlParameter("@MV013", SqlDbType.Char,72),
                    new SqlParameter("@MV014", SqlDbType.Char,1),
                    new SqlParameter("@MV015", SqlDbType.Char,20),
                    new SqlParameter("@MV016", SqlDbType.Char,20),
                    new SqlParameter("@MV017", SqlDbType.Char,60),
                    new SqlParameter("@MV018", SqlDbType.Char,10),
                    new SqlParameter("@MV019", SqlDbType.Char,72),
                    new SqlParameter("@MV020", SqlDbType.VarChar,255),
                    new SqlParameter("@MV021", SqlDbType.Char,8),
                    new SqlParameter("@MV022", SqlDbType.Char,8),
                    new SqlParameter("@MV023", SqlDbType.Char,8),
                    new SqlParameter("@MV024", SqlDbType.Char,1),
                    new SqlParameter("@MV025", SqlDbType.Char,10),
                    new SqlParameter("@MV026", SqlDbType.Char,1),
                    new SqlParameter("@MV027", SqlDbType.Char,3),
                    new SqlParameter("@MV028", SqlDbType.Char,10),
                    new SqlParameter("@MV029", SqlDbType.Char,10),
                    new SqlParameter("@MV030", SqlDbType.Char,10),
                    new SqlParameter("@MV031", SqlDbType.Decimal,5),
                    new SqlParameter("@MV032", SqlDbType.Char,1),
                    new SqlParameter("@MV033", SqlDbType.Decimal,9),
                    new SqlParameter("@MV034", SqlDbType.Char,1),
                    new SqlParameter("@MV035", SqlDbType.Char,10),
                    new SqlParameter("@MV036", SqlDbType.Char,30),
                    new SqlParameter("@MV037", SqlDbType.Decimal,5),
                    new SqlParameter("@MV038", SqlDbType.Char,1),
                    new SqlParameter("@MV039", SqlDbType.Decimal,9),
                    new SqlParameter("@MV040", SqlDbType.Decimal,5),
                    new SqlParameter("@MV041", SqlDbType.Char,1),
                    new SqlParameter("@MV042", SqlDbType.Char,1),
                    new SqlParameter("@MV043", SqlDbType.Decimal,9),
                    new SqlParameter("@MV044", SqlDbType.Char,1),
                    new SqlParameter("@MV045", SqlDbType.Decimal,9),
                    new SqlParameter("@MV046", SqlDbType.VarChar,255),
                    new SqlParameter("@MV047", SqlDbType.Char,30),
                    new SqlParameter("@MV048", SqlDbType.Char,8),
                    new SqlParameter("@MV049", SqlDbType.Char,8),
                    new SqlParameter("@MV050", SqlDbType.Char,8),
                    new SqlParameter("@MV051", SqlDbType.Char,12),
                    new SqlParameter("@MV052", SqlDbType.Char,8),
                    new SqlParameter("@MV053", SqlDbType.Char,8),
                    new SqlParameter("@MV054", SqlDbType.Char,2),
                    new SqlParameter("@MV055", SqlDbType.Decimal,9),
                    new SqlParameter("@MV056", SqlDbType.Decimal,9),
                    new SqlParameter("@MV057", SqlDbType.Char,12),
                    new SqlParameter("@MV058", SqlDbType.Char,10),
                    new SqlParameter("@MV059", SqlDbType.Char,8),
                    new SqlParameter("@MV060", SqlDbType.Char,8),
                    new SqlParameter("@MV061", SqlDbType.Char,1),
                    new SqlParameter("@MV062", SqlDbType.Char,20),
                    new SqlParameter("@MV063", SqlDbType.VarChar,255),
                    new SqlParameter("@MV064", SqlDbType.Char,1),
                    new SqlParameter("@MV065", SqlDbType.Char,12),
                    new SqlParameter("@MV066", SqlDbType.Char,1),
                    new SqlParameter("@MV067", SqlDbType.Char,10),
                    new SqlParameter("@MV068", SqlDbType.Char,10),
                    new SqlParameter("@MV069", SqlDbType.Char,6),
                    new SqlParameter("@MV070", SqlDbType.Char,10),
                    new SqlParameter("@MV071", SqlDbType.Char,6),
                    new SqlParameter("@MV072", SqlDbType.Char,6),
                    new SqlParameter("@MV073", SqlDbType.Char,6),
                    new SqlParameter("@MV074", SqlDbType.Char,60),
                    new SqlParameter("@MV075", SqlDbType.Char,10),
                    new SqlParameter("@MV076", SqlDbType.Char,10),
                    new SqlParameter("@MV077", SqlDbType.Char,1),
                    new SqlParameter("@MV078", SqlDbType.Char,8),
                    new SqlParameter("@MV079", SqlDbType.VarChar,30),
                    new SqlParameter("@MV080", SqlDbType.Decimal,9),
                    new SqlParameter("@MV081", SqlDbType.Decimal,9),
                    new SqlParameter("@MV082", SqlDbType.Decimal,9),
                    new SqlParameter("@MV083", SqlDbType.Char,10),
                    new SqlParameter("@MV084", SqlDbType.Char,30),
                    new SqlParameter("@MV085", SqlDbType.Char,1),
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
                    new SqlParameter("@MV001", SqlDbType.Char,10),
                    new SqlParameter("@MV002", SqlDbType.Char,10),
                    new SqlParameter("@MV004", SqlDbType.Char,6)};
            parameters[0].Value = model.COMPANY;
            parameters[1].Value = model.CREATOR;
            parameters[2].Value = model.USR_GROUP;
            parameters[3].Value = model.CREATE_DATE;
            parameters[4].Value = model.MODIFIER;
            parameters[5].Value = model.MODI_DATE;
            parameters[6].Value = model.FLAG;
            parameters[7].Value = model.MV003;
            parameters[8].Value = model.MV005;
            parameters[9].Value = model.MV006;
            parameters[10].Value = model.MV007;
            parameters[11].Value = model.MV008;
            parameters[12].Value = model.MV009;
            parameters[13].Value = model.MV010;
            parameters[14].Value = model.MV011;
            parameters[15].Value = model.MV012;
            parameters[16].Value = model.MV013;
            parameters[17].Value = model.MV014;
            parameters[18].Value = model.MV015;
            parameters[19].Value = model.MV016;
            parameters[20].Value = model.MV017;
            parameters[21].Value = model.MV018;
            parameters[22].Value = model.MV019;
            parameters[23].Value = model.MV020;
            parameters[24].Value = model.MV021;
            parameters[25].Value = model.MV022;
            parameters[26].Value = model.MV023;
            parameters[27].Value = model.MV024;
            parameters[28].Value = model.MV025;
            parameters[29].Value = model.MV026;
            parameters[30].Value = model.MV027;
            parameters[31].Value = model.MV028;
            parameters[32].Value = model.MV029;
            parameters[33].Value = model.MV030;
            parameters[34].Value = model.MV031;
            parameters[35].Value = model.MV032;
            parameters[36].Value = model.MV033;
            parameters[37].Value = model.MV034;
            parameters[38].Value = model.MV035;
            parameters[39].Value = model.MV036;
            parameters[40].Value = model.MV037;
            parameters[41].Value = model.MV038;
            parameters[42].Value = model.MV039;
            parameters[43].Value = model.MV040;
            parameters[44].Value = model.MV041;
            parameters[45].Value = model.MV042;
            parameters[46].Value = model.MV043;
            parameters[47].Value = model.MV044;
            parameters[48].Value = model.MV045;
            parameters[49].Value = model.MV046;
            parameters[50].Value = model.MV047;
            parameters[51].Value = model.MV048;
            parameters[52].Value = model.MV049;
            parameters[53].Value = model.MV050;
            parameters[54].Value = model.MV051;
            parameters[55].Value = model.MV052;
            parameters[56].Value = model.MV053;
            parameters[57].Value = model.MV054;
            parameters[58].Value = model.MV055;
            parameters[59].Value = model.MV056;
            parameters[60].Value = model.MV057;
            parameters[61].Value = model.MV058;
            parameters[62].Value = model.MV059;
            parameters[63].Value = model.MV060;
            parameters[64].Value = model.MV061;
            parameters[65].Value = model.MV062;
            parameters[66].Value = model.MV063;
            parameters[67].Value = model.MV064;
            parameters[68].Value = model.MV065;
            parameters[69].Value = model.MV066;
            parameters[70].Value = model.MV067;
            parameters[71].Value = model.MV068;
            parameters[72].Value = model.MV069;
            parameters[73].Value = model.MV070;
            parameters[74].Value = model.MV071;
            parameters[75].Value = model.MV072;
            parameters[76].Value = model.MV073;
            parameters[77].Value = model.MV074;
            parameters[78].Value = model.MV075;
            parameters[79].Value = model.MV076;
            parameters[80].Value = model.MV077;
            parameters[81].Value = model.MV078;
            parameters[82].Value = model.MV079;
            parameters[83].Value = model.MV080;
            parameters[84].Value = model.MV081;
            parameters[85].Value = model.MV082;
            parameters[86].Value = model.MV083;
            parameters[87].Value = model.MV084;
            parameters[88].Value = model.MV085;
            parameters[89].Value = model.UDF01;
            parameters[90].Value = model.UDF02;
            parameters[91].Value = model.UDF03;
            parameters[92].Value = model.UDF04;
            parameters[93].Value = model.UDF05;
            parameters[94].Value = model.UDF06;
            parameters[95].Value = model.UDF51;
            parameters[96].Value = model.UDF52;
            parameters[97].Value = model.UDF53;
            parameters[98].Value = model.UDF54;
            parameters[99].Value = model.UDF55;
            parameters[100].Value = model.UDF56;
            parameters[101].Value = model.UDF07;
            parameters[102].Value = model.UDF08;
            parameters[103].Value = model.UDF09;
            parameters[104].Value = model.UDF10;
            parameters[105].Value = model.UDF11;
            parameters[106].Value = model.UDF12;
            parameters[107].Value = model.UDF57;
            parameters[108].Value = model.UDF58;
            parameters[109].Value = model.UDF59;
            parameters[110].Value = model.UDF60;
            parameters[111].Value = model.UDF61;
            parameters[112].Value = model.UDF62;
            parameters[113].Value = model.MV001;
            parameters[114].Value = model.MV002;
            parameters[115].Value = model.MV004;

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
        public bool Delete(string MV001)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CMSMV ");
            strSql.Append(" where MV001=@MV001 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@MV001", SqlDbType.Char,10)           };
            parameters[0].Value = MV001;

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
        public bool DeleteList(string MV001list)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CMSMV ");
            strSql.Append(" where MV001 in (" + MV001list + ")  ");
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
        public YJUI.Model.CMSMV GetModel(string MV001)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,MV001,MV002,MV003,MV004,MV005,MV006,MV007,MV008,MV009,MV010,MV011,MV012,MV013,MV014,MV015,MV016,MV017,MV018,MV019,MV020,MV021,MV022,MV023,MV024,MV025,MV026,MV027,MV028,MV029,MV030,MV031,MV032,MV033,MV034,MV035,MV036,MV037,MV038,MV039,MV040,MV041,MV042,MV043,MV044,MV045,MV046,MV047,MV048,MV049,MV050,MV051,MV052,MV053,MV054,MV055,MV056,MV057,MV058,MV059,MV060,MV061,MV062,MV063,MV064,MV065,MV066,MV067,MV068,MV069,MV070,MV071,MV072,MV073,MV074,MV075,MV076,MV077,MV078,MV079,MV080,MV081,MV082,MV083,MV084,MV085,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62 from CMSMV ");
            strSql.Append(" where MV001=@MV001 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@MV001", SqlDbType.Char,10)           };
            parameters[0].Value = MV001;

            YJUI.Model.CMSMV model = new YJUI.Model.CMSMV();
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
        public YJUI.Model.CMSMV DataRowToModel(DataRow row)
        {
            YJUI.Model.CMSMV model = new YJUI.Model.CMSMV();
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
                if (row["MV001"] != null)
                {
                    model.MV001 = row["MV001"].ToString();
                }
                if (row["MV002"] != null)
                {
                    model.MV002 = row["MV002"].ToString();
                }
                if (row["MV003"] != null)
                {
                    model.MV003 = row["MV003"].ToString();
                }
                if (row["MV004"] != null)
                {
                    model.MV004 = row["MV004"].ToString();
                }
                if (row["MV005"] != null)
                {
                    model.MV005 = row["MV005"].ToString();
                }
                if (row["MV006"] != null)
                {
                    model.MV006 = row["MV006"].ToString();
                }
                if (row["MV007"] != null)
                {
                    model.MV007 = row["MV007"].ToString();
                }
                if (row["MV008"] != null)
                {
                    model.MV008 = row["MV008"].ToString();
                }
                if (row["MV009"] != null)
                {
                    model.MV009 = row["MV009"].ToString();
                }
                if (row["MV010"] != null)
                {
                    model.MV010 = row["MV010"].ToString();
                }
                if (row["MV011"] != null)
                {
                    model.MV011 = row["MV011"].ToString();
                }
                if (row["MV012"] != null)
                {
                    model.MV012 = row["MV012"].ToString();
                }
                if (row["MV013"] != null)
                {
                    model.MV013 = row["MV013"].ToString();
                }
                if (row["MV014"] != null)
                {
                    model.MV014 = row["MV014"].ToString();
                }
                if (row["MV015"] != null)
                {
                    model.MV015 = row["MV015"].ToString();
                }
                if (row["MV016"] != null)
                {
                    model.MV016 = row["MV016"].ToString();
                }
                if (row["MV017"] != null)
                {
                    model.MV017 = row["MV017"].ToString();
                }
                if (row["MV018"] != null)
                {
                    model.MV018 = row["MV018"].ToString();
                }
                if (row["MV019"] != null)
                {
                    model.MV019 = row["MV019"].ToString();
                }
                if (row["MV020"] != null)
                {
                    model.MV020 = row["MV020"].ToString();
                }
                if (row["MV021"] != null)
                {
                    model.MV021 = row["MV021"].ToString();
                }
                if (row["MV022"] != null)
                {
                    model.MV022 = row["MV022"].ToString();
                }
                if (row["MV023"] != null)
                {
                    model.MV023 = row["MV023"].ToString();
                }
                if (row["MV024"] != null)
                {
                    model.MV024 = row["MV024"].ToString();
                }
                if (row["MV025"] != null)
                {
                    model.MV025 = row["MV025"].ToString();
                }
                if (row["MV026"] != null)
                {
                    model.MV026 = row["MV026"].ToString();
                }
                if (row["MV027"] != null)
                {
                    model.MV027 = row["MV027"].ToString();
                }
                if (row["MV028"] != null)
                {
                    model.MV028 = row["MV028"].ToString();
                }
                if (row["MV029"] != null)
                {
                    model.MV029 = row["MV029"].ToString();
                }
                if (row["MV030"] != null)
                {
                    model.MV030 = row["MV030"].ToString();
                }
                if (row["MV031"] != null && row["MV031"].ToString() != "")
                {
                    model.MV031 = decimal.Parse(row["MV031"].ToString());
                }
                if (row["MV032"] != null)
                {
                    model.MV032 = row["MV032"].ToString();
                }
                if (row["MV033"] != null && row["MV033"].ToString() != "")
                {
                    model.MV033 = decimal.Parse(row["MV033"].ToString());
                }
                if (row["MV034"] != null)
                {
                    model.MV034 = row["MV034"].ToString();
                }
                if (row["MV035"] != null)
                {
                    model.MV035 = row["MV035"].ToString();
                }
                if (row["MV036"] != null)
                {
                    model.MV036 = row["MV036"].ToString();
                }
                if (row["MV037"] != null && row["MV037"].ToString() != "")
                {
                    model.MV037 = decimal.Parse(row["MV037"].ToString());
                }
                if (row["MV038"] != null)
                {
                    model.MV038 = row["MV038"].ToString();
                }
                if (row["MV039"] != null && row["MV039"].ToString() != "")
                {
                    model.MV039 = decimal.Parse(row["MV039"].ToString());
                }
                if (row["MV040"] != null && row["MV040"].ToString() != "")
                {
                    model.MV040 = decimal.Parse(row["MV040"].ToString());
                }
                if (row["MV041"] != null)
                {
                    model.MV041 = row["MV041"].ToString();
                }
                if (row["MV042"] != null)
                {
                    model.MV042 = row["MV042"].ToString();
                }
                if (row["MV043"] != null && row["MV043"].ToString() != "")
                {
                    model.MV043 = decimal.Parse(row["MV043"].ToString());
                }
                if (row["MV044"] != null)
                {
                    model.MV044 = row["MV044"].ToString();
                }
                if (row["MV045"] != null && row["MV045"].ToString() != "")
                {
                    model.MV045 = decimal.Parse(row["MV045"].ToString());
                }
                if (row["MV046"] != null)
                {
                    model.MV046 = row["MV046"].ToString();
                }
                if (row["MV047"] != null)
                {
                    model.MV047 = row["MV047"].ToString();
                }
                if (row["MV048"] != null)
                {
                    model.MV048 = row["MV048"].ToString();
                }
                if (row["MV049"] != null)
                {
                    model.MV049 = row["MV049"].ToString();
                }
                if (row["MV050"] != null)
                {
                    model.MV050 = row["MV050"].ToString();
                }
                if (row["MV051"] != null)
                {
                    model.MV051 = row["MV051"].ToString();
                }
                if (row["MV052"] != null)
                {
                    model.MV052 = row["MV052"].ToString();
                }
                if (row["MV053"] != null)
                {
                    model.MV053 = row["MV053"].ToString();
                }
                if (row["MV054"] != null)
                {
                    model.MV054 = row["MV054"].ToString();
                }
                if (row["MV055"] != null && row["MV055"].ToString() != "")
                {
                    model.MV055 = decimal.Parse(row["MV055"].ToString());
                }
                if (row["MV056"] != null && row["MV056"].ToString() != "")
                {
                    model.MV056 = decimal.Parse(row["MV056"].ToString());
                }
                if (row["MV057"] != null)
                {
                    model.MV057 = row["MV057"].ToString();
                }
                if (row["MV058"] != null)
                {
                    model.MV058 = row["MV058"].ToString();
                }
                if (row["MV059"] != null)
                {
                    model.MV059 = row["MV059"].ToString();
                }
                if (row["MV060"] != null)
                {
                    model.MV060 = row["MV060"].ToString();
                }
                if (row["MV061"] != null)
                {
                    model.MV061 = row["MV061"].ToString();
                }
                if (row["MV062"] != null)
                {
                    model.MV062 = row["MV062"].ToString();
                }
                if (row["MV063"] != null)
                {
                    model.MV063 = row["MV063"].ToString();
                }
                if (row["MV064"] != null)
                {
                    model.MV064 = row["MV064"].ToString();
                }
                if (row["MV065"] != null)
                {
                    model.MV065 = row["MV065"].ToString();
                }
                if (row["MV066"] != null)
                {
                    model.MV066 = row["MV066"].ToString();
                }
                if (row["MV067"] != null)
                {
                    model.MV067 = row["MV067"].ToString();
                }
                if (row["MV068"] != null)
                {
                    model.MV068 = row["MV068"].ToString();
                }
                if (row["MV069"] != null)
                {
                    model.MV069 = row["MV069"].ToString();
                }
                if (row["MV070"] != null)
                {
                    model.MV070 = row["MV070"].ToString();
                }
                if (row["MV071"] != null)
                {
                    model.MV071 = row["MV071"].ToString();
                }
                if (row["MV072"] != null)
                {
                    model.MV072 = row["MV072"].ToString();
                }
                if (row["MV073"] != null)
                {
                    model.MV073 = row["MV073"].ToString();
                }
                if (row["MV074"] != null)
                {
                    model.MV074 = row["MV074"].ToString();
                }
                if (row["MV075"] != null)
                {
                    model.MV075 = row["MV075"].ToString();
                }
                if (row["MV076"] != null)
                {
                    model.MV076 = row["MV076"].ToString();
                }
                if (row["MV077"] != null)
                {
                    model.MV077 = row["MV077"].ToString();
                }
                if (row["MV078"] != null)
                {
                    model.MV078 = row["MV078"].ToString();
                }
                if (row["MV079"] != null)
                {
                    model.MV079 = row["MV079"].ToString();
                }
                if (row["MV080"] != null && row["MV080"].ToString() != "")
                {
                    model.MV080 = decimal.Parse(row["MV080"].ToString());
                }
                if (row["MV081"] != null && row["MV081"].ToString() != "")
                {
                    model.MV081 = decimal.Parse(row["MV081"].ToString());
                }
                if (row["MV082"] != null && row["MV082"].ToString() != "")
                {
                    model.MV082 = decimal.Parse(row["MV082"].ToString());
                }
                if (row["MV083"] != null)
                {
                    model.MV083 = row["MV083"].ToString();
                }
                if (row["MV084"] != null)
                {
                    model.MV084 = row["MV084"].ToString();
                }
                if (row["MV085"] != null)
                {
                    model.MV085 = row["MV085"].ToString();
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
            strSql.Append("select COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,MV001,MV002,MV003,MV004,MV005,MV006,MV007,MV008,MV009,MV010,MV011,MV012,MV013,MV014,MV015,MV016,MV017,MV018,MV019,MV020,MV021,MV022,MV023,MV024,MV025,MV026,MV027,MV028,MV029,MV030,MV031,MV032,MV033,MV034,MV035,MV036,MV037,MV038,MV039,MV040,MV041,MV042,MV043,MV044,MV045,MV046,MV047,MV048,MV049,MV050,MV051,MV052,MV053,MV054,MV055,MV056,MV057,MV058,MV059,MV060,MV061,MV062,MV063,MV064,MV065,MV066,MV067,MV068,MV069,MV070,MV071,MV072,MV073,MV074,MV075,MV076,MV077,MV078,MV079,MV080,MV081,MV082,MV083,MV084,MV085,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62 ");
            strSql.Append(" FROM CMSMV ");
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
            strSql.Append(" COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,MV001,MV002,MV003,MV004,MV005,MV006,MV007,MV008,MV009,MV010,MV011,MV012,MV013,MV014,MV015,MV016,MV017,MV018,MV019,MV020,MV021,MV022,MV023,MV024,MV025,MV026,MV027,MV028,MV029,MV030,MV031,MV032,MV033,MV034,MV035,MV036,MV037,MV038,MV039,MV040,MV041,MV042,MV043,MV044,MV045,MV046,MV047,MV048,MV049,MV050,MV051,MV052,MV053,MV054,MV055,MV056,MV057,MV058,MV059,MV060,MV061,MV062,MV063,MV064,MV065,MV066,MV067,MV068,MV069,MV070,MV071,MV072,MV073,MV074,MV075,MV076,MV077,MV078,MV079,MV080,MV081,MV082,MV083,MV084,MV085,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62 ");
            strSql.Append(" FROM CMSMV ");
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
            strSql.Append("select count(1) FROM CMSMV ");
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
                strSql.Append("order by T.MV001 desc");
            }
            strSql.Append(")AS Row, T.*  from CMSMV T ");
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

