using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using YJUI.DBUtility;//Please add references
namespace YJUI.DAL
{
    /// <summary>
    /// 数据访问类:CMSMQ
    /// </summary>
    public partial class CMSMQ
    {
        public CMSMQ()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string MQ001)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CMSMQ");
            strSql.Append(" where MQ001=@MQ001 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@MQ001", SqlDbType.Char,4)            };
            parameters[0].Value = MQ001;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YJUI.Model.CMSMQ model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CMSMQ(");
            strSql.Append("COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,MQ001,MQ002,MQ003,MQ004,MQ005,MQ006,MQ007,MQ008,MQ009,MQ010,MQ011,MQ012,MQ013,MQ014,MQ015,MQ016,MQ017,MQ018,MQ019,MQ020,MQ021,MQ022,MQ023,MQ024,MQ025,MQ026,MQ027,MQ028,MQ029,MQ030,MQ031,MQ032,MQ033,MQ034,MQ035,MQ036,MQ037,MQ038,MQ039,MQ040,MQ041,MQ042,MQ043,MQ044,MQ045,MQ046,MQ047,MQ048,MQ049,MQ050,MQ051,MQ052,MQ053,MQ054,MQ055,MQ056,MQ057,MQ058,MQ059,MQ060,MQ061,MQ062,MQ063,MQ064,MQ065,MQ066,MQ067,MQD01,MQD02,MQD03,MQD04,MQD05,MQD06,MQC01,MQC02,MQC03,MQC04,MQC05,MQ068,MQ069,MQ070,MQ071,MQ072,MQ073,MQI01,MQI02,MQ074,MQ075,MQ076,MQ077,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62)");
            strSql.Append(" values (");
            strSql.Append("@COMPANY,@CREATOR,@USR_GROUP,@CREATE_DATE,@MODIFIER,@MODI_DATE,@FLAG,@MQ001,@MQ002,@MQ003,@MQ004,@MQ005,@MQ006,@MQ007,@MQ008,@MQ009,@MQ010,@MQ011,@MQ012,@MQ013,@MQ014,@MQ015,@MQ016,@MQ017,@MQ018,@MQ019,@MQ020,@MQ021,@MQ022,@MQ023,@MQ024,@MQ025,@MQ026,@MQ027,@MQ028,@MQ029,@MQ030,@MQ031,@MQ032,@MQ033,@MQ034,@MQ035,@MQ036,@MQ037,@MQ038,@MQ039,@MQ040,@MQ041,@MQ042,@MQ043,@MQ044,@MQ045,@MQ046,@MQ047,@MQ048,@MQ049,@MQ050,@MQ051,@MQ052,@MQ053,@MQ054,@MQ055,@MQ056,@MQ057,@MQ058,@MQ059,@MQ060,@MQ061,@MQ062,@MQ063,@MQ064,@MQ065,@MQ066,@MQ067,@MQD01,@MQD02,@MQD03,@MQD04,@MQD05,@MQD06,@MQC01,@MQC02,@MQC03,@MQC04,@MQC05,@MQ068,@MQ069,@MQ070,@MQ071,@MQ072,@MQ073,@MQI01,@MQI02,@MQ074,@MQ075,@MQ076,@MQ077,@UDF01,@UDF02,@UDF03,@UDF04,@UDF05,@UDF06,@UDF51,@UDF52,@UDF53,@UDF54,@UDF55,@UDF56,@UDF07,@UDF08,@UDF09,@UDF10,@UDF11,@UDF12,@UDF57,@UDF58,@UDF59,@UDF60,@UDF61,@UDF62)");
            SqlParameter[] parameters = {
                    new SqlParameter("@COMPANY", SqlDbType.Char,10),
                    new SqlParameter("@CREATOR", SqlDbType.Char,10),
                    new SqlParameter("@USR_GROUP", SqlDbType.Char,10),
                    new SqlParameter("@CREATE_DATE", SqlDbType.Char,17),
                    new SqlParameter("@MODIFIER", SqlDbType.Char,10),
                    new SqlParameter("@MODI_DATE", SqlDbType.Char,17),
                    new SqlParameter("@FLAG", SqlDbType.Decimal,5),
                    new SqlParameter("@MQ001", SqlDbType.Char,4),
                    new SqlParameter("@MQ002", SqlDbType.Char,10),
                    new SqlParameter("@MQ003", SqlDbType.Char,2),
                    new SqlParameter("@MQ004", SqlDbType.Char,1),
                    new SqlParameter("@MQ005", SqlDbType.Decimal,5),
                    new SqlParameter("@MQ006", SqlDbType.Decimal,5),
                    new SqlParameter("@MQ007", SqlDbType.Decimal,5),
                    new SqlParameter("@MQ008", SqlDbType.Char,1),
                    new SqlParameter("@MQ009", SqlDbType.Char,20),
                    new SqlParameter("@MQ010", SqlDbType.Decimal,5),
                    new SqlParameter("@MQ011", SqlDbType.Char,1),
                    new SqlParameter("@MQ012", SqlDbType.Char,1),
                    new SqlParameter("@MQ013", SqlDbType.Char,1),
                    new SqlParameter("@MQ014", SqlDbType.Char,1),
                    new SqlParameter("@MQ015", SqlDbType.Char,1),
                    new SqlParameter("@MQ016", SqlDbType.Char,1),
                    new SqlParameter("@MQ017", SqlDbType.Char,1),
                    new SqlParameter("@MQ018", SqlDbType.Char,1),
                    new SqlParameter("@MQ019", SqlDbType.Char,1),
                    new SqlParameter("@MQ020", SqlDbType.Char,1),
                    new SqlParameter("@MQ021", SqlDbType.Char,4),
                    new SqlParameter("@MQ022", SqlDbType.VarChar,255),
                    new SqlParameter("@MQ023", SqlDbType.Char,10),
                    new SqlParameter("@MQ024", SqlDbType.Char,1),
                    new SqlParameter("@MQ025", SqlDbType.Char,6),
                    new SqlParameter("@MQ026", SqlDbType.Char,1),
                    new SqlParameter("@MQ027", SqlDbType.Char,6),
                    new SqlParameter("@MQ028", SqlDbType.Char,1),
                    new SqlParameter("@MQ029", SqlDbType.Char,1),
                    new SqlParameter("@MQ030", SqlDbType.Char,1),
                    new SqlParameter("@MQ031", SqlDbType.Char,1),
                    new SqlParameter("@MQ032", SqlDbType.Char,20),
                    new SqlParameter("@MQ033", SqlDbType.Char,1),
                    new SqlParameter("@MQ034", SqlDbType.Char,20),
                    new SqlParameter("@MQ035", SqlDbType.Char,1),
                    new SqlParameter("@MQ036", SqlDbType.Char,1),
                    new SqlParameter("@MQ037", SqlDbType.Decimal,9),
                    new SqlParameter("@MQ038", SqlDbType.Char,4),
                    new SqlParameter("@MQ039", SqlDbType.Char,1),
                    new SqlParameter("@MQ040", SqlDbType.Char,1),
                    new SqlParameter("@MQ041", SqlDbType.Char,1),
                    new SqlParameter("@MQ042", SqlDbType.Char,1),
                    new SqlParameter("@MQ043", SqlDbType.Char,1),
                    new SqlParameter("@MQ044", SqlDbType.Char,1),
                    new SqlParameter("@MQ045", SqlDbType.Char,1),
                    new SqlParameter("@MQ046", SqlDbType.Char,1),
                    new SqlParameter("@MQ047", SqlDbType.Char,1),
                    new SqlParameter("@MQ048", SqlDbType.Char,4),
                    new SqlParameter("@MQ049", SqlDbType.Char,1),
                    new SqlParameter("@MQ050", SqlDbType.Char,1),
                    new SqlParameter("@MQ051", SqlDbType.Char,1),
                    new SqlParameter("@MQ052", SqlDbType.Decimal,5),
                    new SqlParameter("@MQ053", SqlDbType.Decimal,5),
                    new SqlParameter("@MQ054", SqlDbType.Char,1),
                    new SqlParameter("@MQ055", SqlDbType.Char,8),
                    new SqlParameter("@MQ056", SqlDbType.VarChar,30),
                    new SqlParameter("@MQ057", SqlDbType.Decimal,9),
                    new SqlParameter("@MQ058", SqlDbType.Decimal,9),
                    new SqlParameter("@MQ059", SqlDbType.Decimal,9),
                    new SqlParameter("@MQ060", SqlDbType.Char,1),
                    new SqlParameter("@MQ061", SqlDbType.Char,1),
                    new SqlParameter("@MQ062", SqlDbType.Char,1),
                    new SqlParameter("@MQ063", SqlDbType.Char,4),
                    new SqlParameter("@MQ064", SqlDbType.Char,1),
                    new SqlParameter("@MQ065", SqlDbType.Char,1),
                    new SqlParameter("@MQ066", SqlDbType.Char,1),
                    new SqlParameter("@MQ067", SqlDbType.Char,1),
                    new SqlParameter("@MQD01", SqlDbType.Char,1),
                    new SqlParameter("@MQD02", SqlDbType.Char,1),
                    new SqlParameter("@MQD03", SqlDbType.Char,1),
                    new SqlParameter("@MQD04", SqlDbType.Char,1),
                    new SqlParameter("@MQD05", SqlDbType.Char,1),
                    new SqlParameter("@MQD06", SqlDbType.Char,1),
                    new SqlParameter("@MQC01", SqlDbType.Char,10),
                    new SqlParameter("@MQC02", SqlDbType.Char,1),
                    new SqlParameter("@MQC03", SqlDbType.Char,1),
                    new SqlParameter("@MQC04", SqlDbType.Char,1),
                    new SqlParameter("@MQC05", SqlDbType.Char,1),
                    new SqlParameter("@MQ068", SqlDbType.Char,1),
                    new SqlParameter("@MQ069", SqlDbType.Char,4),
                    new SqlParameter("@MQ070", SqlDbType.Char,1),
                    new SqlParameter("@MQ071", SqlDbType.Char,1),
                    new SqlParameter("@MQ072", SqlDbType.Char,1),
                    new SqlParameter("@MQ073", SqlDbType.Char,1),
                    new SqlParameter("@MQI01", SqlDbType.Char,1),
                    new SqlParameter("@MQI02", SqlDbType.Char,1),
                    new SqlParameter("@MQ074", SqlDbType.Char,8),
                    new SqlParameter("@MQ075", SqlDbType.Char,8),
                    new SqlParameter("@MQ076", SqlDbType.VarChar,30),
                    new SqlParameter("@MQ077", SqlDbType.Char,1),
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
            parameters[7].Value = model.MQ001;
            parameters[8].Value = model.MQ002;
            parameters[9].Value = model.MQ003;
            parameters[10].Value = model.MQ004;
            parameters[11].Value = model.MQ005;
            parameters[12].Value = model.MQ006;
            parameters[13].Value = model.MQ007;
            parameters[14].Value = model.MQ008;
            parameters[15].Value = model.MQ009;
            parameters[16].Value = model.MQ010;
            parameters[17].Value = model.MQ011;
            parameters[18].Value = model.MQ012;
            parameters[19].Value = model.MQ013;
            parameters[20].Value = model.MQ014;
            parameters[21].Value = model.MQ015;
            parameters[22].Value = model.MQ016;
            parameters[23].Value = model.MQ017;
            parameters[24].Value = model.MQ018;
            parameters[25].Value = model.MQ019;
            parameters[26].Value = model.MQ020;
            parameters[27].Value = model.MQ021;
            parameters[28].Value = model.MQ022;
            parameters[29].Value = model.MQ023;
            parameters[30].Value = model.MQ024;
            parameters[31].Value = model.MQ025;
            parameters[32].Value = model.MQ026;
            parameters[33].Value = model.MQ027;
            parameters[34].Value = model.MQ028;
            parameters[35].Value = model.MQ029;
            parameters[36].Value = model.MQ030;
            parameters[37].Value = model.MQ031;
            parameters[38].Value = model.MQ032;
            parameters[39].Value = model.MQ033;
            parameters[40].Value = model.MQ034;
            parameters[41].Value = model.MQ035;
            parameters[42].Value = model.MQ036;
            parameters[43].Value = model.MQ037;
            parameters[44].Value = model.MQ038;
            parameters[45].Value = model.MQ039;
            parameters[46].Value = model.MQ040;
            parameters[47].Value = model.MQ041;
            parameters[48].Value = model.MQ042;
            parameters[49].Value = model.MQ043;
            parameters[50].Value = model.MQ044;
            parameters[51].Value = model.MQ045;
            parameters[52].Value = model.MQ046;
            parameters[53].Value = model.MQ047;
            parameters[54].Value = model.MQ048;
            parameters[55].Value = model.MQ049;
            parameters[56].Value = model.MQ050;
            parameters[57].Value = model.MQ051;
            parameters[58].Value = model.MQ052;
            parameters[59].Value = model.MQ053;
            parameters[60].Value = model.MQ054;
            parameters[61].Value = model.MQ055;
            parameters[62].Value = model.MQ056;
            parameters[63].Value = model.MQ057;
            parameters[64].Value = model.MQ058;
            parameters[65].Value = model.MQ059;
            parameters[66].Value = model.MQ060;
            parameters[67].Value = model.MQ061;
            parameters[68].Value = model.MQ062;
            parameters[69].Value = model.MQ063;
            parameters[70].Value = model.MQ064;
            parameters[71].Value = model.MQ065;
            parameters[72].Value = model.MQ066;
            parameters[73].Value = model.MQ067;
            parameters[74].Value = model.MQD01;
            parameters[75].Value = model.MQD02;
            parameters[76].Value = model.MQD03;
            parameters[77].Value = model.MQD04;
            parameters[78].Value = model.MQD05;
            parameters[79].Value = model.MQD06;
            parameters[80].Value = model.MQC01;
            parameters[81].Value = model.MQC02;
            parameters[82].Value = model.MQC03;
            parameters[83].Value = model.MQC04;
            parameters[84].Value = model.MQC05;
            parameters[85].Value = model.MQ068;
            parameters[86].Value = model.MQ069;
            parameters[87].Value = model.MQ070;
            parameters[88].Value = model.MQ071;
            parameters[89].Value = model.MQ072;
            parameters[90].Value = model.MQ073;
            parameters[91].Value = model.MQI01;
            parameters[92].Value = model.MQI02;
            parameters[93].Value = model.MQ074;
            parameters[94].Value = model.MQ075;
            parameters[95].Value = model.MQ076;
            parameters[96].Value = model.MQ077;
            parameters[97].Value = model.UDF01;
            parameters[98].Value = model.UDF02;
            parameters[99].Value = model.UDF03;
            parameters[100].Value = model.UDF04;
            parameters[101].Value = model.UDF05;
            parameters[102].Value = model.UDF06;
            parameters[103].Value = model.UDF51;
            parameters[104].Value = model.UDF52;
            parameters[105].Value = model.UDF53;
            parameters[106].Value = model.UDF54;
            parameters[107].Value = model.UDF55;
            parameters[108].Value = model.UDF56;
            parameters[109].Value = model.UDF07;
            parameters[110].Value = model.UDF08;
            parameters[111].Value = model.UDF09;
            parameters[112].Value = model.UDF10;
            parameters[113].Value = model.UDF11;
            parameters[114].Value = model.UDF12;
            parameters[115].Value = model.UDF57;
            parameters[116].Value = model.UDF58;
            parameters[117].Value = model.UDF59;
            parameters[118].Value = model.UDF60;
            parameters[119].Value = model.UDF61;
            parameters[120].Value = model.UDF62;

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
        public bool Update(YJUI.Model.CMSMQ model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CMSMQ set ");
            strSql.Append("COMPANY=@COMPANY,");
            strSql.Append("CREATOR=@CREATOR,");
            strSql.Append("USR_GROUP=@USR_GROUP,");
            strSql.Append("CREATE_DATE=@CREATE_DATE,");
            strSql.Append("MODIFIER=@MODIFIER,");
            strSql.Append("MODI_DATE=@MODI_DATE,");
            strSql.Append("FLAG=@FLAG,");
            strSql.Append("MQ002=@MQ002,");
            strSql.Append("MQ003=@MQ003,");
            strSql.Append("MQ004=@MQ004,");
            strSql.Append("MQ005=@MQ005,");
            strSql.Append("MQ006=@MQ006,");
            strSql.Append("MQ007=@MQ007,");
            strSql.Append("MQ008=@MQ008,");
            strSql.Append("MQ009=@MQ009,");
            strSql.Append("MQ010=@MQ010,");
            strSql.Append("MQ011=@MQ011,");
            strSql.Append("MQ012=@MQ012,");
            strSql.Append("MQ013=@MQ013,");
            strSql.Append("MQ014=@MQ014,");
            strSql.Append("MQ015=@MQ015,");
            strSql.Append("MQ016=@MQ016,");
            strSql.Append("MQ017=@MQ017,");
            strSql.Append("MQ018=@MQ018,");
            strSql.Append("MQ019=@MQ019,");
            strSql.Append("MQ020=@MQ020,");
            strSql.Append("MQ021=@MQ021,");
            strSql.Append("MQ022=@MQ022,");
            strSql.Append("MQ023=@MQ023,");
            strSql.Append("MQ024=@MQ024,");
            strSql.Append("MQ025=@MQ025,");
            strSql.Append("MQ026=@MQ026,");
            strSql.Append("MQ027=@MQ027,");
            strSql.Append("MQ028=@MQ028,");
            strSql.Append("MQ029=@MQ029,");
            strSql.Append("MQ030=@MQ030,");
            strSql.Append("MQ031=@MQ031,");
            strSql.Append("MQ032=@MQ032,");
            strSql.Append("MQ033=@MQ033,");
            strSql.Append("MQ034=@MQ034,");
            strSql.Append("MQ035=@MQ035,");
            strSql.Append("MQ036=@MQ036,");
            strSql.Append("MQ037=@MQ037,");
            strSql.Append("MQ038=@MQ038,");
            strSql.Append("MQ039=@MQ039,");
            strSql.Append("MQ040=@MQ040,");
            strSql.Append("MQ041=@MQ041,");
            strSql.Append("MQ042=@MQ042,");
            strSql.Append("MQ043=@MQ043,");
            strSql.Append("MQ044=@MQ044,");
            strSql.Append("MQ045=@MQ045,");
            strSql.Append("MQ046=@MQ046,");
            strSql.Append("MQ047=@MQ047,");
            strSql.Append("MQ048=@MQ048,");
            strSql.Append("MQ049=@MQ049,");
            strSql.Append("MQ050=@MQ050,");
            strSql.Append("MQ051=@MQ051,");
            strSql.Append("MQ052=@MQ052,");
            strSql.Append("MQ053=@MQ053,");
            strSql.Append("MQ054=@MQ054,");
            strSql.Append("MQ055=@MQ055,");
            strSql.Append("MQ056=@MQ056,");
            strSql.Append("MQ057=@MQ057,");
            strSql.Append("MQ058=@MQ058,");
            strSql.Append("MQ059=@MQ059,");
            strSql.Append("MQ060=@MQ060,");
            strSql.Append("MQ061=@MQ061,");
            strSql.Append("MQ062=@MQ062,");
            strSql.Append("MQ063=@MQ063,");
            strSql.Append("MQ064=@MQ064,");
            strSql.Append("MQ065=@MQ065,");
            strSql.Append("MQ066=@MQ066,");
            strSql.Append("MQ067=@MQ067,");
            strSql.Append("MQD01=@MQD01,");
            strSql.Append("MQD02=@MQD02,");
            strSql.Append("MQD03=@MQD03,");
            strSql.Append("MQD04=@MQD04,");
            strSql.Append("MQD05=@MQD05,");
            strSql.Append("MQD06=@MQD06,");
            strSql.Append("MQC01=@MQC01,");
            strSql.Append("MQC02=@MQC02,");
            strSql.Append("MQC03=@MQC03,");
            strSql.Append("MQC04=@MQC04,");
            strSql.Append("MQC05=@MQC05,");
            strSql.Append("MQ068=@MQ068,");
            strSql.Append("MQ069=@MQ069,");
            strSql.Append("MQ070=@MQ070,");
            strSql.Append("MQ071=@MQ071,");
            strSql.Append("MQ072=@MQ072,");
            strSql.Append("MQ073=@MQ073,");
            strSql.Append("MQI01=@MQI01,");
            strSql.Append("MQI02=@MQI02,");
            strSql.Append("MQ074=@MQ074,");
            strSql.Append("MQ075=@MQ075,");
            strSql.Append("MQ076=@MQ076,");
            strSql.Append("MQ077=@MQ077,");
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
            strSql.Append(" where MQ001=@MQ001 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@COMPANY", SqlDbType.Char,10),
                    new SqlParameter("@CREATOR", SqlDbType.Char,10),
                    new SqlParameter("@USR_GROUP", SqlDbType.Char,10),
                    new SqlParameter("@CREATE_DATE", SqlDbType.Char,17),
                    new SqlParameter("@MODIFIER", SqlDbType.Char,10),
                    new SqlParameter("@MODI_DATE", SqlDbType.Char,17),
                    new SqlParameter("@FLAG", SqlDbType.Decimal,5),
                    new SqlParameter("@MQ002", SqlDbType.Char,10),
                    new SqlParameter("@MQ003", SqlDbType.Char,2),
                    new SqlParameter("@MQ004", SqlDbType.Char,1),
                    new SqlParameter("@MQ005", SqlDbType.Decimal,5),
                    new SqlParameter("@MQ006", SqlDbType.Decimal,5),
                    new SqlParameter("@MQ007", SqlDbType.Decimal,5),
                    new SqlParameter("@MQ008", SqlDbType.Char,1),
                    new SqlParameter("@MQ009", SqlDbType.Char,20),
                    new SqlParameter("@MQ010", SqlDbType.Decimal,5),
                    new SqlParameter("@MQ011", SqlDbType.Char,1),
                    new SqlParameter("@MQ012", SqlDbType.Char,1),
                    new SqlParameter("@MQ013", SqlDbType.Char,1),
                    new SqlParameter("@MQ014", SqlDbType.Char,1),
                    new SqlParameter("@MQ015", SqlDbType.Char,1),
                    new SqlParameter("@MQ016", SqlDbType.Char,1),
                    new SqlParameter("@MQ017", SqlDbType.Char,1),
                    new SqlParameter("@MQ018", SqlDbType.Char,1),
                    new SqlParameter("@MQ019", SqlDbType.Char,1),
                    new SqlParameter("@MQ020", SqlDbType.Char,1),
                    new SqlParameter("@MQ021", SqlDbType.Char,4),
                    new SqlParameter("@MQ022", SqlDbType.VarChar,255),
                    new SqlParameter("@MQ023", SqlDbType.Char,10),
                    new SqlParameter("@MQ024", SqlDbType.Char,1),
                    new SqlParameter("@MQ025", SqlDbType.Char,6),
                    new SqlParameter("@MQ026", SqlDbType.Char,1),
                    new SqlParameter("@MQ027", SqlDbType.Char,6),
                    new SqlParameter("@MQ028", SqlDbType.Char,1),
                    new SqlParameter("@MQ029", SqlDbType.Char,1),
                    new SqlParameter("@MQ030", SqlDbType.Char,1),
                    new SqlParameter("@MQ031", SqlDbType.Char,1),
                    new SqlParameter("@MQ032", SqlDbType.Char,20),
                    new SqlParameter("@MQ033", SqlDbType.Char,1),
                    new SqlParameter("@MQ034", SqlDbType.Char,20),
                    new SqlParameter("@MQ035", SqlDbType.Char,1),
                    new SqlParameter("@MQ036", SqlDbType.Char,1),
                    new SqlParameter("@MQ037", SqlDbType.Decimal,9),
                    new SqlParameter("@MQ038", SqlDbType.Char,4),
                    new SqlParameter("@MQ039", SqlDbType.Char,1),
                    new SqlParameter("@MQ040", SqlDbType.Char,1),
                    new SqlParameter("@MQ041", SqlDbType.Char,1),
                    new SqlParameter("@MQ042", SqlDbType.Char,1),
                    new SqlParameter("@MQ043", SqlDbType.Char,1),
                    new SqlParameter("@MQ044", SqlDbType.Char,1),
                    new SqlParameter("@MQ045", SqlDbType.Char,1),
                    new SqlParameter("@MQ046", SqlDbType.Char,1),
                    new SqlParameter("@MQ047", SqlDbType.Char,1),
                    new SqlParameter("@MQ048", SqlDbType.Char,4),
                    new SqlParameter("@MQ049", SqlDbType.Char,1),
                    new SqlParameter("@MQ050", SqlDbType.Char,1),
                    new SqlParameter("@MQ051", SqlDbType.Char,1),
                    new SqlParameter("@MQ052", SqlDbType.Decimal,5),
                    new SqlParameter("@MQ053", SqlDbType.Decimal,5),
                    new SqlParameter("@MQ054", SqlDbType.Char,1),
                    new SqlParameter("@MQ055", SqlDbType.Char,8),
                    new SqlParameter("@MQ056", SqlDbType.VarChar,30),
                    new SqlParameter("@MQ057", SqlDbType.Decimal,9),
                    new SqlParameter("@MQ058", SqlDbType.Decimal,9),
                    new SqlParameter("@MQ059", SqlDbType.Decimal,9),
                    new SqlParameter("@MQ060", SqlDbType.Char,1),
                    new SqlParameter("@MQ061", SqlDbType.Char,1),
                    new SqlParameter("@MQ062", SqlDbType.Char,1),
                    new SqlParameter("@MQ063", SqlDbType.Char,4),
                    new SqlParameter("@MQ064", SqlDbType.Char,1),
                    new SqlParameter("@MQ065", SqlDbType.Char,1),
                    new SqlParameter("@MQ066", SqlDbType.Char,1),
                    new SqlParameter("@MQ067", SqlDbType.Char,1),
                    new SqlParameter("@MQD01", SqlDbType.Char,1),
                    new SqlParameter("@MQD02", SqlDbType.Char,1),
                    new SqlParameter("@MQD03", SqlDbType.Char,1),
                    new SqlParameter("@MQD04", SqlDbType.Char,1),
                    new SqlParameter("@MQD05", SqlDbType.Char,1),
                    new SqlParameter("@MQD06", SqlDbType.Char,1),
                    new SqlParameter("@MQC01", SqlDbType.Char,10),
                    new SqlParameter("@MQC02", SqlDbType.Char,1),
                    new SqlParameter("@MQC03", SqlDbType.Char,1),
                    new SqlParameter("@MQC04", SqlDbType.Char,1),
                    new SqlParameter("@MQC05", SqlDbType.Char,1),
                    new SqlParameter("@MQ068", SqlDbType.Char,1),
                    new SqlParameter("@MQ069", SqlDbType.Char,4),
                    new SqlParameter("@MQ070", SqlDbType.Char,1),
                    new SqlParameter("@MQ071", SqlDbType.Char,1),
                    new SqlParameter("@MQ072", SqlDbType.Char,1),
                    new SqlParameter("@MQ073", SqlDbType.Char,1),
                    new SqlParameter("@MQI01", SqlDbType.Char,1),
                    new SqlParameter("@MQI02", SqlDbType.Char,1),
                    new SqlParameter("@MQ074", SqlDbType.Char,8),
                    new SqlParameter("@MQ075", SqlDbType.Char,8),
                    new SqlParameter("@MQ076", SqlDbType.VarChar,30),
                    new SqlParameter("@MQ077", SqlDbType.Char,1),
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
                    new SqlParameter("@MQ001", SqlDbType.Char,4)};
            parameters[0].Value = model.COMPANY;
            parameters[1].Value = model.CREATOR;
            parameters[2].Value = model.USR_GROUP;
            parameters[3].Value = model.CREATE_DATE;
            parameters[4].Value = model.MODIFIER;
            parameters[5].Value = model.MODI_DATE;
            parameters[6].Value = model.FLAG;
            parameters[7].Value = model.MQ002;
            parameters[8].Value = model.MQ003;
            parameters[9].Value = model.MQ004;
            parameters[10].Value = model.MQ005;
            parameters[11].Value = model.MQ006;
            parameters[12].Value = model.MQ007;
            parameters[13].Value = model.MQ008;
            parameters[14].Value = model.MQ009;
            parameters[15].Value = model.MQ010;
            parameters[16].Value = model.MQ011;
            parameters[17].Value = model.MQ012;
            parameters[18].Value = model.MQ013;
            parameters[19].Value = model.MQ014;
            parameters[20].Value = model.MQ015;
            parameters[21].Value = model.MQ016;
            parameters[22].Value = model.MQ017;
            parameters[23].Value = model.MQ018;
            parameters[24].Value = model.MQ019;
            parameters[25].Value = model.MQ020;
            parameters[26].Value = model.MQ021;
            parameters[27].Value = model.MQ022;
            parameters[28].Value = model.MQ023;
            parameters[29].Value = model.MQ024;
            parameters[30].Value = model.MQ025;
            parameters[31].Value = model.MQ026;
            parameters[32].Value = model.MQ027;
            parameters[33].Value = model.MQ028;
            parameters[34].Value = model.MQ029;
            parameters[35].Value = model.MQ030;
            parameters[36].Value = model.MQ031;
            parameters[37].Value = model.MQ032;
            parameters[38].Value = model.MQ033;
            parameters[39].Value = model.MQ034;
            parameters[40].Value = model.MQ035;
            parameters[41].Value = model.MQ036;
            parameters[42].Value = model.MQ037;
            parameters[43].Value = model.MQ038;
            parameters[44].Value = model.MQ039;
            parameters[45].Value = model.MQ040;
            parameters[46].Value = model.MQ041;
            parameters[47].Value = model.MQ042;
            parameters[48].Value = model.MQ043;
            parameters[49].Value = model.MQ044;
            parameters[50].Value = model.MQ045;
            parameters[51].Value = model.MQ046;
            parameters[52].Value = model.MQ047;
            parameters[53].Value = model.MQ048;
            parameters[54].Value = model.MQ049;
            parameters[55].Value = model.MQ050;
            parameters[56].Value = model.MQ051;
            parameters[57].Value = model.MQ052;
            parameters[58].Value = model.MQ053;
            parameters[59].Value = model.MQ054;
            parameters[60].Value = model.MQ055;
            parameters[61].Value = model.MQ056;
            parameters[62].Value = model.MQ057;
            parameters[63].Value = model.MQ058;
            parameters[64].Value = model.MQ059;
            parameters[65].Value = model.MQ060;
            parameters[66].Value = model.MQ061;
            parameters[67].Value = model.MQ062;
            parameters[68].Value = model.MQ063;
            parameters[69].Value = model.MQ064;
            parameters[70].Value = model.MQ065;
            parameters[71].Value = model.MQ066;
            parameters[72].Value = model.MQ067;
            parameters[73].Value = model.MQD01;
            parameters[74].Value = model.MQD02;
            parameters[75].Value = model.MQD03;
            parameters[76].Value = model.MQD04;
            parameters[77].Value = model.MQD05;
            parameters[78].Value = model.MQD06;
            parameters[79].Value = model.MQC01;
            parameters[80].Value = model.MQC02;
            parameters[81].Value = model.MQC03;
            parameters[82].Value = model.MQC04;
            parameters[83].Value = model.MQC05;
            parameters[84].Value = model.MQ068;
            parameters[85].Value = model.MQ069;
            parameters[86].Value = model.MQ070;
            parameters[87].Value = model.MQ071;
            parameters[88].Value = model.MQ072;
            parameters[89].Value = model.MQ073;
            parameters[90].Value = model.MQI01;
            parameters[91].Value = model.MQI02;
            parameters[92].Value = model.MQ074;
            parameters[93].Value = model.MQ075;
            parameters[94].Value = model.MQ076;
            parameters[95].Value = model.MQ077;
            parameters[96].Value = model.UDF01;
            parameters[97].Value = model.UDF02;
            parameters[98].Value = model.UDF03;
            parameters[99].Value = model.UDF04;
            parameters[100].Value = model.UDF05;
            parameters[101].Value = model.UDF06;
            parameters[102].Value = model.UDF51;
            parameters[103].Value = model.UDF52;
            parameters[104].Value = model.UDF53;
            parameters[105].Value = model.UDF54;
            parameters[106].Value = model.UDF55;
            parameters[107].Value = model.UDF56;
            parameters[108].Value = model.UDF07;
            parameters[109].Value = model.UDF08;
            parameters[110].Value = model.UDF09;
            parameters[111].Value = model.UDF10;
            parameters[112].Value = model.UDF11;
            parameters[113].Value = model.UDF12;
            parameters[114].Value = model.UDF57;
            parameters[115].Value = model.UDF58;
            parameters[116].Value = model.UDF59;
            parameters[117].Value = model.UDF60;
            parameters[118].Value = model.UDF61;
            parameters[119].Value = model.UDF62;
            parameters[120].Value = model.MQ001;

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
        public bool Delete(string MQ001)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CMSMQ ");
            strSql.Append(" where MQ001=@MQ001 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@MQ001", SqlDbType.Char,4)            };
            parameters[0].Value = MQ001;

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
        public bool DeleteList(string MQ001list)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CMSMQ ");
            strSql.Append(" where MQ001 in (" + MQ001list + ")  ");
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
        public YJUI.Model.CMSMQ GetModel(string MQ001)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,MQ001,MQ002,MQ003,MQ004,MQ005,MQ006,MQ007,MQ008,MQ009,MQ010,MQ011,MQ012,MQ013,MQ014,MQ015,MQ016,MQ017,MQ018,MQ019,MQ020,MQ021,MQ022,MQ023,MQ024,MQ025,MQ026,MQ027,MQ028,MQ029,MQ030,MQ031,MQ032,MQ033,MQ034,MQ035,MQ036,MQ037,MQ038,MQ039,MQ040,MQ041,MQ042,MQ043,MQ044,MQ045,MQ046,MQ047,MQ048,MQ049,MQ050,MQ051,MQ052,MQ053,MQ054,MQ055,MQ056,MQ057,MQ058,MQ059,MQ060,MQ061,MQ062,MQ063,MQ064,MQ065,MQ066,MQ067,MQD01,MQD02,MQD03,MQD04,MQD05,MQD06,MQC01,MQC02,MQC03,MQC04,MQC05,MQ068,MQ069,MQ070,MQ071,MQ072,MQ073,MQI01,MQI02,MQ074,MQ075,MQ076,MQ077,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62 from CMSMQ ");
            strSql.Append(" where MQ001=@MQ001 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@MQ001", SqlDbType.Char,4)            };
            parameters[0].Value = MQ001;

            YJUI.Model.CMSMQ model = new YJUI.Model.CMSMQ();
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
        public YJUI.Model.CMSMQ DataRowToModel(DataRow row)
        {
            YJUI.Model.CMSMQ model = new YJUI.Model.CMSMQ();
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
                if (row["MQ001"] != null)
                {
                    model.MQ001 = row["MQ001"].ToString();
                }
                if (row["MQ002"] != null)
                {
                    model.MQ002 = row["MQ002"].ToString();
                }
                if (row["MQ003"] != null)
                {
                    model.MQ003 = row["MQ003"].ToString();
                }
                if (row["MQ004"] != null)
                {
                    model.MQ004 = row["MQ004"].ToString();
                }
                if (row["MQ005"] != null && row["MQ005"].ToString() != "")
                {
                    model.MQ005 = decimal.Parse(row["MQ005"].ToString());
                }
                if (row["MQ006"] != null && row["MQ006"].ToString() != "")
                {
                    model.MQ006 = decimal.Parse(row["MQ006"].ToString());
                }
                if (row["MQ007"] != null && row["MQ007"].ToString() != "")
                {
                    model.MQ007 = decimal.Parse(row["MQ007"].ToString());
                }
                if (row["MQ008"] != null)
                {
                    model.MQ008 = row["MQ008"].ToString();
                }
                if (row["MQ009"] != null)
                {
                    model.MQ009 = row["MQ009"].ToString();
                }
                if (row["MQ010"] != null && row["MQ010"].ToString() != "")
                {
                    model.MQ010 = decimal.Parse(row["MQ010"].ToString());
                }
                if (row["MQ011"] != null)
                {
                    model.MQ011 = row["MQ011"].ToString();
                }
                if (row["MQ012"] != null)
                {
                    model.MQ012 = row["MQ012"].ToString();
                }
                if (row["MQ013"] != null)
                {
                    model.MQ013 = row["MQ013"].ToString();
                }
                if (row["MQ014"] != null)
                {
                    model.MQ014 = row["MQ014"].ToString();
                }
                if (row["MQ015"] != null)
                {
                    model.MQ015 = row["MQ015"].ToString();
                }
                if (row["MQ016"] != null)
                {
                    model.MQ016 = row["MQ016"].ToString();
                }
                if (row["MQ017"] != null)
                {
                    model.MQ017 = row["MQ017"].ToString();
                }
                if (row["MQ018"] != null)
                {
                    model.MQ018 = row["MQ018"].ToString();
                }
                if (row["MQ019"] != null)
                {
                    model.MQ019 = row["MQ019"].ToString();
                }
                if (row["MQ020"] != null)
                {
                    model.MQ020 = row["MQ020"].ToString();
                }
                if (row["MQ021"] != null)
                {
                    model.MQ021 = row["MQ021"].ToString();
                }
                if (row["MQ022"] != null)
                {
                    model.MQ022 = row["MQ022"].ToString();
                }
                if (row["MQ023"] != null)
                {
                    model.MQ023 = row["MQ023"].ToString();
                }
                if (row["MQ024"] != null)
                {
                    model.MQ024 = row["MQ024"].ToString();
                }
                if (row["MQ025"] != null)
                {
                    model.MQ025 = row["MQ025"].ToString();
                }
                if (row["MQ026"] != null)
                {
                    model.MQ026 = row["MQ026"].ToString();
                }
                if (row["MQ027"] != null)
                {
                    model.MQ027 = row["MQ027"].ToString();
                }
                if (row["MQ028"] != null)
                {
                    model.MQ028 = row["MQ028"].ToString();
                }
                if (row["MQ029"] != null)
                {
                    model.MQ029 = row["MQ029"].ToString();
                }
                if (row["MQ030"] != null)
                {
                    model.MQ030 = row["MQ030"].ToString();
                }
                if (row["MQ031"] != null)
                {
                    model.MQ031 = row["MQ031"].ToString();
                }
                if (row["MQ032"] != null)
                {
                    model.MQ032 = row["MQ032"].ToString();
                }
                if (row["MQ033"] != null)
                {
                    model.MQ033 = row["MQ033"].ToString();
                }
                if (row["MQ034"] != null)
                {
                    model.MQ034 = row["MQ034"].ToString();
                }
                if (row["MQ035"] != null)
                {
                    model.MQ035 = row["MQ035"].ToString();
                }
                if (row["MQ036"] != null)
                {
                    model.MQ036 = row["MQ036"].ToString();
                }
                if (row["MQ037"] != null && row["MQ037"].ToString() != "")
                {
                    model.MQ037 = decimal.Parse(row["MQ037"].ToString());
                }
                if (row["MQ038"] != null)
                {
                    model.MQ038 = row["MQ038"].ToString();
                }
                if (row["MQ039"] != null)
                {
                    model.MQ039 = row["MQ039"].ToString();
                }
                if (row["MQ040"] != null)
                {
                    model.MQ040 = row["MQ040"].ToString();
                }
                if (row["MQ041"] != null)
                {
                    model.MQ041 = row["MQ041"].ToString();
                }
                if (row["MQ042"] != null)
                {
                    model.MQ042 = row["MQ042"].ToString();
                }
                if (row["MQ043"] != null)
                {
                    model.MQ043 = row["MQ043"].ToString();
                }
                if (row["MQ044"] != null)
                {
                    model.MQ044 = row["MQ044"].ToString();
                }
                if (row["MQ045"] != null)
                {
                    model.MQ045 = row["MQ045"].ToString();
                }
                if (row["MQ046"] != null)
                {
                    model.MQ046 = row["MQ046"].ToString();
                }
                if (row["MQ047"] != null)
                {
                    model.MQ047 = row["MQ047"].ToString();
                }
                if (row["MQ048"] != null)
                {
                    model.MQ048 = row["MQ048"].ToString();
                }
                if (row["MQ049"] != null)
                {
                    model.MQ049 = row["MQ049"].ToString();
                }
                if (row["MQ050"] != null)
                {
                    model.MQ050 = row["MQ050"].ToString();
                }
                if (row["MQ051"] != null)
                {
                    model.MQ051 = row["MQ051"].ToString();
                }
                if (row["MQ052"] != null && row["MQ052"].ToString() != "")
                {
                    model.MQ052 = decimal.Parse(row["MQ052"].ToString());
                }
                if (row["MQ053"] != null && row["MQ053"].ToString() != "")
                {
                    model.MQ053 = decimal.Parse(row["MQ053"].ToString());
                }
                if (row["MQ054"] != null)
                {
                    model.MQ054 = row["MQ054"].ToString();
                }
                if (row["MQ055"] != null)
                {
                    model.MQ055 = row["MQ055"].ToString();
                }
                if (row["MQ056"] != null)
                {
                    model.MQ056 = row["MQ056"].ToString();
                }
                if (row["MQ057"] != null && row["MQ057"].ToString() != "")
                {
                    model.MQ057 = decimal.Parse(row["MQ057"].ToString());
                }
                if (row["MQ058"] != null && row["MQ058"].ToString() != "")
                {
                    model.MQ058 = decimal.Parse(row["MQ058"].ToString());
                }
                if (row["MQ059"] != null && row["MQ059"].ToString() != "")
                {
                    model.MQ059 = decimal.Parse(row["MQ059"].ToString());
                }
                if (row["MQ060"] != null)
                {
                    model.MQ060 = row["MQ060"].ToString();
                }
                if (row["MQ061"] != null)
                {
                    model.MQ061 = row["MQ061"].ToString();
                }
                if (row["MQ062"] != null)
                {
                    model.MQ062 = row["MQ062"].ToString();
                }
                if (row["MQ063"] != null)
                {
                    model.MQ063 = row["MQ063"].ToString();
                }
                if (row["MQ064"] != null)
                {
                    model.MQ064 = row["MQ064"].ToString();
                }
                if (row["MQ065"] != null)
                {
                    model.MQ065 = row["MQ065"].ToString();
                }
                if (row["MQ066"] != null)
                {
                    model.MQ066 = row["MQ066"].ToString();
                }
                if (row["MQ067"] != null)
                {
                    model.MQ067 = row["MQ067"].ToString();
                }
                if (row["MQD01"] != null)
                {
                    model.MQD01 = row["MQD01"].ToString();
                }
                if (row["MQD02"] != null)
                {
                    model.MQD02 = row["MQD02"].ToString();
                }
                if (row["MQD03"] != null)
                {
                    model.MQD03 = row["MQD03"].ToString();
                }
                if (row["MQD04"] != null)
                {
                    model.MQD04 = row["MQD04"].ToString();
                }
                if (row["MQD05"] != null)
                {
                    model.MQD05 = row["MQD05"].ToString();
                }
                if (row["MQD06"] != null)
                {
                    model.MQD06 = row["MQD06"].ToString();
                }
                if (row["MQC01"] != null)
                {
                    model.MQC01 = row["MQC01"].ToString();
                }
                if (row["MQC02"] != null)
                {
                    model.MQC02 = row["MQC02"].ToString();
                }
                if (row["MQC03"] != null)
                {
                    model.MQC03 = row["MQC03"].ToString();
                }
                if (row["MQC04"] != null)
                {
                    model.MQC04 = row["MQC04"].ToString();
                }
                if (row["MQC05"] != null)
                {
                    model.MQC05 = row["MQC05"].ToString();
                }
                if (row["MQ068"] != null)
                {
                    model.MQ068 = row["MQ068"].ToString();
                }
                if (row["MQ069"] != null)
                {
                    model.MQ069 = row["MQ069"].ToString();
                }
                if (row["MQ070"] != null)
                {
                    model.MQ070 = row["MQ070"].ToString();
                }
                if (row["MQ071"] != null)
                {
                    model.MQ071 = row["MQ071"].ToString();
                }
                if (row["MQ072"] != null)
                {
                    model.MQ072 = row["MQ072"].ToString();
                }
                if (row["MQ073"] != null)
                {
                    model.MQ073 = row["MQ073"].ToString();
                }
                if (row["MQI01"] != null)
                {
                    model.MQI01 = row["MQI01"].ToString();
                }
                if (row["MQI02"] != null)
                {
                    model.MQI02 = row["MQI02"].ToString();
                }
                if (row["MQ074"] != null)
                {
                    model.MQ074 = row["MQ074"].ToString();
                }
                if (row["MQ075"] != null)
                {
                    model.MQ075 = row["MQ075"].ToString();
                }
                if (row["MQ076"] != null)
                {
                    model.MQ076 = row["MQ076"].ToString();
                }
                if (row["MQ077"] != null)
                {
                    model.MQ077 = row["MQ077"].ToString();
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
            strSql.Append("select COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,MQ001,MQ002,MQ003,MQ004,MQ005,MQ006,MQ007,MQ008,MQ009,MQ010,MQ011,MQ012,MQ013,MQ014,MQ015,MQ016,MQ017,MQ018,MQ019,MQ020,MQ021,MQ022,MQ023,MQ024,MQ025,MQ026,MQ027,MQ028,MQ029,MQ030,MQ031,MQ032,MQ033,MQ034,MQ035,MQ036,MQ037,MQ038,MQ039,MQ040,MQ041,MQ042,MQ043,MQ044,MQ045,MQ046,MQ047,MQ048,MQ049,MQ050,MQ051,MQ052,MQ053,MQ054,MQ055,MQ056,MQ057,MQ058,MQ059,MQ060,MQ061,MQ062,MQ063,MQ064,MQ065,MQ066,MQ067,MQD01,MQD02,MQD03,MQD04,MQD05,MQD06,MQC01,MQC02,MQC03,MQC04,MQC05,MQ068,MQ069,MQ070,MQ071,MQ072,MQ073,MQI01,MQI02,MQ074,MQ075,MQ076,MQ077,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62 ");
            strSql.Append(" FROM CMSMQ ");
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
            strSql.Append(" COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,MQ001,MQ002,MQ003,MQ004,MQ005,MQ006,MQ007,MQ008,MQ009,MQ010,MQ011,MQ012,MQ013,MQ014,MQ015,MQ016,MQ017,MQ018,MQ019,MQ020,MQ021,MQ022,MQ023,MQ024,MQ025,MQ026,MQ027,MQ028,MQ029,MQ030,MQ031,MQ032,MQ033,MQ034,MQ035,MQ036,MQ037,MQ038,MQ039,MQ040,MQ041,MQ042,MQ043,MQ044,MQ045,MQ046,MQ047,MQ048,MQ049,MQ050,MQ051,MQ052,MQ053,MQ054,MQ055,MQ056,MQ057,MQ058,MQ059,MQ060,MQ061,MQ062,MQ063,MQ064,MQ065,MQ066,MQ067,MQD01,MQD02,MQD03,MQD04,MQD05,MQD06,MQC01,MQC02,MQC03,MQC04,MQC05,MQ068,MQ069,MQ070,MQ071,MQ072,MQ073,MQI01,MQI02,MQ074,MQ075,MQ076,MQ077,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62 ");
            strSql.Append(" FROM CMSMQ ");
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
            strSql.Append("select count(1) FROM CMSMQ ");
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
                strSql.Append("order by T.MQ001 desc");
            }
            strSql.Append(")AS Row, T.*  from CMSMQ T ");
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

