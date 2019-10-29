using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using YJUI.DBUtility;//Please add references
namespace YJUI.DAL
{
    /// <summary>
    /// 数据访问类:INVMB
    /// </summary>
    public partial class INVMB
    {
        public INVMB()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string MB001)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from INVMB");
            strSql.Append(" where MB001=@MB001 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@MB001", SqlDbType.Char,20)           };
            parameters[0].Value = MB001;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YJUI.Model.INVMB model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into INVMB(");
            strSql.Append("COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,MB001,MB002,MB003,MB004,MB005,MB006,MB007,MB008,MB009,MB010,MB011,MB012,MB013,MB014,MB015,MB016,MB017,MB018,MB019,MB020,MB021,MB022,MB023,MB024,MB025,MB026,MB027,MB028,MB029,MB030,MB031,MB032,MB033,MB034,MB035,MB036,MB037,MB038,MB039,MB040,MB041,MB042,MB043,MB044,MB045,MB046,MB047,MB048,MB049,MB050,MB051,MB052,MB053,MB054,MB055,MB056,MB057,MB058,MB059,MB060,MB061,MB062,MB063,MB064,MB065,MB066,MB067,MB068,MB069,MB070,MB071,MB072,MB073,MB074,MB075,MB076,MB077,MB078,MB079,MB080,MB081,MB082,MB083,MB084,MB085,MB086,MB087,MB088,MB089,MB090,MB091,MB092,MB093,MB094,MB095,MB096,MB100,MB101,MB102,MB103,MB104,MB105,MB106,MB107,MB108,MB109,MB110,MB111,MB112,MB113,MB114,MB115,MB116,MB117,MB118,MB119,MB120,MB121,MB122,MB123,MB124,MB125,MB126,MB127,MB128,MB129,MB130,MB131,MB132,MB133,MB134,MB135,MB136,MB137,MB138,MB139,MB140,MB141,MB142,MB143,MB144,MB145,MB146,MB147,MB148,MB149,MB150,MB151,MB152,MB179,MB180,MB181,MB182,MB183,MB184,MB185,MB186,MB187,MB188,MB189,MB190,MB191,MB192,MB193,MB194,MB195,MB196,MB197,MB198,MB199,MB401,MB402,MB403,MB404,MB405,MB406,MB407,MB408,MB409,MB410,MB411,MB412,MB413,MB414,MB415,MB416,MB417,MB418,MB419,MB420,MB421,MB422,MB423,MB424,MB425,MB426,MB427,MB428,MB429,MB430,MB431,MB432,MB433,MB434,MB435,MB436,MB437,MB438,MB439,MB440,MB441,MB442,MB443,MB444,MB445,MB446,MB447,MB448,MB449,MB450,MB451,MB452,MBD01,MBD02,MBE01,MB453,MB454,MBH01,MBH02,MBH03,MB455,MB456,MB457,MB458,MB459,MB460,MB461,MB462,MB463,MB464,MB465,MB466,MB467,MB468,MB469,MB470,MB471,MB472,MB473,MB474,MB475,MBL01,MBL02,MBL03,MBL04,MB476,MB477,MB478,MB479,MB480,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62)");
            strSql.Append(" values (");
            strSql.Append("@COMPANY,@CREATOR,@USR_GROUP,@CREATE_DATE,@MODIFIER,@MODI_DATE,@FLAG,@MB001,@MB002,@MB003,@MB004,@MB005,@MB006,@MB007,@MB008,@MB009,@MB010,@MB011,@MB012,@MB013,@MB014,@MB015,@MB016,@MB017,@MB018,@MB019,@MB020,@MB021,@MB022,@MB023,@MB024,@MB025,@MB026,@MB027,@MB028,@MB029,@MB030,@MB031,@MB032,@MB033,@MB034,@MB035,@MB036,@MB037,@MB038,@MB039,@MB040,@MB041,@MB042,@MB043,@MB044,@MB045,@MB046,@MB047,@MB048,@MB049,@MB050,@MB051,@MB052,@MB053,@MB054,@MB055,@MB056,@MB057,@MB058,@MB059,@MB060,@MB061,@MB062,@MB063,@MB064,@MB065,@MB066,@MB067,@MB068,@MB069,@MB070,@MB071,@MB072,@MB073,@MB074,@MB075,@MB076,@MB077,@MB078,@MB079,@MB080,@MB081,@MB082,@MB083,@MB084,@MB085,@MB086,@MB087,@MB088,@MB089,@MB090,@MB091,@MB092,@MB093,@MB094,@MB095,@MB096,@MB100,@MB101,@MB102,@MB103,@MB104,@MB105,@MB106,@MB107,@MB108,@MB109,@MB110,@MB111,@MB112,@MB113,@MB114,@MB115,@MB116,@MB117,@MB118,@MB119,@MB120,@MB121,@MB122,@MB123,@MB124,@MB125,@MB126,@MB127,@MB128,@MB129,@MB130,@MB131,@MB132,@MB133,@MB134,@MB135,@MB136,@MB137,@MB138,@MB139,@MB140,@MB141,@MB142,@MB143,@MB144,@MB145,@MB146,@MB147,@MB148,@MB149,@MB150,@MB151,@MB152,@MB179,@MB180,@MB181,@MB182,@MB183,@MB184,@MB185,@MB186,@MB187,@MB188,@MB189,@MB190,@MB191,@MB192,@MB193,@MB194,@MB195,@MB196,@MB197,@MB198,@MB199,@MB401,@MB402,@MB403,@MB404,@MB405,@MB406,@MB407,@MB408,@MB409,@MB410,@MB411,@MB412,@MB413,@MB414,@MB415,@MB416,@MB417,@MB418,@MB419,@MB420,@MB421,@MB422,@MB423,@MB424,@MB425,@MB426,@MB427,@MB428,@MB429,@MB430,@MB431,@MB432,@MB433,@MB434,@MB435,@MB436,@MB437,@MB438,@MB439,@MB440,@MB441,@MB442,@MB443,@MB444,@MB445,@MB446,@MB447,@MB448,@MB449,@MB450,@MB451,@MB452,@MBD01,@MBD02,@MBE01,@MB453,@MB454,@MBH01,@MBH02,@MBH03,@MB455,@MB456,@MB457,@MB458,@MB459,@MB460,@MB461,@MB462,@MB463,@MB464,@MB465,@MB466,@MB467,@MB468,@MB469,@MB470,@MB471,@MB472,@MB473,@MB474,@MB475,@MBL01,@MBL02,@MBL03,@MBL04,@MB476,@MB477,@MB478,@MB479,@MB480,@UDF01,@UDF02,@UDF03,@UDF04,@UDF05,@UDF06,@UDF51,@UDF52,@UDF53,@UDF54,@UDF55,@UDF56,@UDF07,@UDF08,@UDF09,@UDF10,@UDF11,@UDF12,@UDF57,@UDF58,@UDF59,@UDF60,@UDF61,@UDF62)");
            SqlParameter[] parameters = {
                    new SqlParameter("@COMPANY", SqlDbType.Char,10),
                    new SqlParameter("@CREATOR", SqlDbType.Char,10),
                    new SqlParameter("@USR_GROUP", SqlDbType.Char,10),
                    new SqlParameter("@CREATE_DATE", SqlDbType.Char,17),
                    new SqlParameter("@MODIFIER", SqlDbType.Char,10),
                    new SqlParameter("@MODI_DATE", SqlDbType.Char,17),
                    new SqlParameter("@FLAG", SqlDbType.Decimal,5),
                    new SqlParameter("@MB001", SqlDbType.Char,20),
                    new SqlParameter("@MB002", SqlDbType.VarChar,60),
                    new SqlParameter("@MB003", SqlDbType.VarChar,60),
                    new SqlParameter("@MB004", SqlDbType.Char,4),
                    new SqlParameter("@MB005", SqlDbType.Char,6),
                    new SqlParameter("@MB006", SqlDbType.Char,6),
                    new SqlParameter("@MB007", SqlDbType.Char,6),
                    new SqlParameter("@MB008", SqlDbType.Char,6),
                    new SqlParameter("@MB009", SqlDbType.VarChar,255),
                    new SqlParameter("@MB010", SqlDbType.Char,20),
                    new SqlParameter("@MB011", SqlDbType.Char,4),
                    new SqlParameter("@MB012", SqlDbType.Char,10),
                    new SqlParameter("@MB013", SqlDbType.Char,20),
                    new SqlParameter("@MB014", SqlDbType.Decimal,9),
                    new SqlParameter("@MB015", SqlDbType.Char,4),
                    new SqlParameter("@MB016", SqlDbType.Char,4),
                    new SqlParameter("@MB017", SqlDbType.Char,10),
                    new SqlParameter("@MB018", SqlDbType.Char,10),
                    new SqlParameter("@MB019", SqlDbType.Char,1),
                    new SqlParameter("@MB020", SqlDbType.Char,1),
                    new SqlParameter("@MB021", SqlDbType.Char,4),
                    new SqlParameter("@MB022", SqlDbType.Char,1),
                    new SqlParameter("@MB023", SqlDbType.Decimal,5),
                    new SqlParameter("@MB024", SqlDbType.Decimal,5),
                    new SqlParameter("@MB025", SqlDbType.Char,1),
                    new SqlParameter("@MB026", SqlDbType.Char,2),
                    new SqlParameter("@MB027", SqlDbType.Char,1),
                    new SqlParameter("@MB028", SqlDbType.VarChar,255),
                    new SqlParameter("@MB029", SqlDbType.Char,20),
                    new SqlParameter("@MB030", SqlDbType.Char,8),
                    new SqlParameter("@MB031", SqlDbType.Char,8),
                    new SqlParameter("@MB032", SqlDbType.Char,10),
                    new SqlParameter("@MB033", SqlDbType.Char,1),
                    new SqlParameter("@MB034", SqlDbType.Char,1),
                    new SqlParameter("@MB035", SqlDbType.Char,4),
                    new SqlParameter("@MB036", SqlDbType.Decimal,9),
                    new SqlParameter("@MB037", SqlDbType.Decimal,9),
                    new SqlParameter("@MB038", SqlDbType.Decimal,9),
                    new SqlParameter("@MB039", SqlDbType.Decimal,9),
                    new SqlParameter("@MB040", SqlDbType.Decimal,9),
                    new SqlParameter("@MB041", SqlDbType.Decimal,9),
                    new SqlParameter("@MB042", SqlDbType.Char,1),
                    new SqlParameter("@MB043", SqlDbType.Char,1),
                    new SqlParameter("@MB044", SqlDbType.Char,1),
                    new SqlParameter("@MB045", SqlDbType.Decimal,5),
                    new SqlParameter("@MB046", SqlDbType.Decimal,9),
                    new SqlParameter("@MB047", SqlDbType.Decimal,9),
                    new SqlParameter("@MB048", SqlDbType.Char,4),
                    new SqlParameter("@MB049", SqlDbType.Decimal,9),
                    new SqlParameter("@MB050", SqlDbType.Decimal,9),
                    new SqlParameter("@MB051", SqlDbType.Decimal,9),
                    new SqlParameter("@MB052", SqlDbType.Char,1),
                    new SqlParameter("@MB053", SqlDbType.Decimal,9),
                    new SqlParameter("@MB054", SqlDbType.Decimal,9),
                    new SqlParameter("@MB055", SqlDbType.Decimal,9),
                    new SqlParameter("@MB056", SqlDbType.Decimal,9),
                    new SqlParameter("@MB057", SqlDbType.Decimal,9),
                    new SqlParameter("@MB058", SqlDbType.Decimal,9),
                    new SqlParameter("@MB059", SqlDbType.Decimal,9),
                    new SqlParameter("@MB060", SqlDbType.Decimal,9),
                    new SqlParameter("@MB061", SqlDbType.Decimal,9),
                    new SqlParameter("@MB062", SqlDbType.Decimal,9),
                    new SqlParameter("@MB063", SqlDbType.Decimal,9),
                    new SqlParameter("@MB064", SqlDbType.Decimal,9),
                    new SqlParameter("@MB065", SqlDbType.Decimal,9),
                    new SqlParameter("@MB066", SqlDbType.Char,1),
                    new SqlParameter("@MB067", SqlDbType.Char,10),
                    new SqlParameter("@MB068", SqlDbType.Char,10),
                    new SqlParameter("@MB069", SqlDbType.Decimal,9),
                    new SqlParameter("@MB070", SqlDbType.Decimal,9),
                    new SqlParameter("@MB071", SqlDbType.Decimal,9),
                    new SqlParameter("@MB072", SqlDbType.Char,4),
                    new SqlParameter("@MB073", SqlDbType.Decimal,9),
                    new SqlParameter("@MB074", SqlDbType.Decimal,9),
                    new SqlParameter("@MB075", SqlDbType.Decimal,9),
                    new SqlParameter("@MB076", SqlDbType.Decimal,5),
                    new SqlParameter("@MB077", SqlDbType.Char,6),
                    new SqlParameter("@MB078", SqlDbType.Decimal,5),
                    new SqlParameter("@MB079", SqlDbType.Decimal,5),
                    new SqlParameter("@MB080", SqlDbType.Char,20),
                    new SqlParameter("@MB081", SqlDbType.Char,4),
                    new SqlParameter("@MB082", SqlDbType.Decimal,5),
                    new SqlParameter("@MB083", SqlDbType.Char,1),
                    new SqlParameter("@MB084", SqlDbType.Decimal,5),
                    new SqlParameter("@MB085", SqlDbType.Char,1),
                    new SqlParameter("@MB086", SqlDbType.Decimal,5),
                    new SqlParameter("@MB087", SqlDbType.Char,1),
                    new SqlParameter("@MB088", SqlDbType.Decimal,5),
                    new SqlParameter("@MB089", SqlDbType.Decimal,9),
                    new SqlParameter("@MB090", SqlDbType.Char,4),
                    new SqlParameter("@MB091", SqlDbType.Char,1),
                    new SqlParameter("@MB092", SqlDbType.Char,1),
                    new SqlParameter("@MB093", SqlDbType.Decimal,9),
                    new SqlParameter("@MB094", SqlDbType.Decimal,9),
                    new SqlParameter("@MB095", SqlDbType.Decimal,9),
                    new SqlParameter("@MB096", SqlDbType.Decimal,5),
                    new SqlParameter("@MB100", SqlDbType.Char,1),
                    new SqlParameter("@MB101", SqlDbType.Char,1),
                    new SqlParameter("@MB102", SqlDbType.Char,1),
                    new SqlParameter("@MB103", SqlDbType.Char,1),
                    new SqlParameter("@MB104", SqlDbType.Char,1),
                    new SqlParameter("@MB105", SqlDbType.Char,1),
                    new SqlParameter("@MB106", SqlDbType.Char,1),
                    new SqlParameter("@MB107", SqlDbType.Char,1),
                    new SqlParameter("@MB108", SqlDbType.Char,1),
                    new SqlParameter("@MB109", SqlDbType.Char,1),
                    new SqlParameter("@MB110", SqlDbType.Char,20),
                    new SqlParameter("@MB111", SqlDbType.Decimal,5),
                    new SqlParameter("@MB112", SqlDbType.Char,60),
                    new SqlParameter("@MB113", SqlDbType.Char,1),
                    new SqlParameter("@MB114", SqlDbType.Char,1),
                    new SqlParameter("@MB115", SqlDbType.Char,1),
                    new SqlParameter("@MB116", SqlDbType.Char,1),
                    new SqlParameter("@MB117", SqlDbType.Char,1),
                    new SqlParameter("@MB118", SqlDbType.Char,1),
                    new SqlParameter("@MB119", SqlDbType.Char,1),
                    new SqlParameter("@MB120", SqlDbType.Char,1),
                    new SqlParameter("@MB121", SqlDbType.Char,30),
                    new SqlParameter("@MB122", SqlDbType.Char,30),
                    new SqlParameter("@MB123", SqlDbType.Char,30),
                    new SqlParameter("@MB124", SqlDbType.Char,30),
                    new SqlParameter("@MB125", SqlDbType.Char,60),
                    new SqlParameter("@MB126", SqlDbType.Char,1),
                    new SqlParameter("@MB127", SqlDbType.Char,1),
                    new SqlParameter("@MB128", SqlDbType.Char,60),
                    new SqlParameter("@MB129", SqlDbType.Char,60),
                    new SqlParameter("@MB130", SqlDbType.Char,60),
                    new SqlParameter("@MB131", SqlDbType.Char,20),
                    new SqlParameter("@MB132", SqlDbType.Char,20),
                    new SqlParameter("@MB133", SqlDbType.Char,20),
                    new SqlParameter("@MB134", SqlDbType.VarChar,255),
                    new SqlParameter("@MB135", SqlDbType.VarChar,255),
                    new SqlParameter("@MB136", SqlDbType.Char,1),
                    new SqlParameter("@MB137", SqlDbType.Char,1),
                    new SqlParameter("@MB138", SqlDbType.Char,10),
                    new SqlParameter("@MB139", SqlDbType.Char,8),
                    new SqlParameter("@MB140", SqlDbType.Char,1),
                    new SqlParameter("@MB141", SqlDbType.Char,1),
                    new SqlParameter("@MB142", SqlDbType.Char,12),
                    new SqlParameter("@MB143", SqlDbType.Char,10),
                    new SqlParameter("@MB144", SqlDbType.Char,1),
                    new SqlParameter("@MB145", SqlDbType.Char,1),
                    new SqlParameter("@MB146", SqlDbType.Char,10),
                    new SqlParameter("@MB147", SqlDbType.Decimal,5),
                    new SqlParameter("@MB148", SqlDbType.Char,4),
                    new SqlParameter("@MB149", SqlDbType.Char,4),
                    new SqlParameter("@MB150", SqlDbType.Char,10),
                    new SqlParameter("@MB151", SqlDbType.Decimal,5),
                    new SqlParameter("@MB152", SqlDbType.Decimal,5),
                    new SqlParameter("@MB179", SqlDbType.Char,10),
                    new SqlParameter("@MB180", SqlDbType.Char,60),
                    new SqlParameter("@MB181", SqlDbType.Char,60),
                    new SqlParameter("@MB182", SqlDbType.Char,60),
                    new SqlParameter("@MB183", SqlDbType.Char,60),
                    new SqlParameter("@MB184", SqlDbType.Char,60),
                    new SqlParameter("@MB185", SqlDbType.Char,60),
                    new SqlParameter("@MB186", SqlDbType.Char,60),
                    new SqlParameter("@MB187", SqlDbType.Char,60),
                    new SqlParameter("@MB188", SqlDbType.Char,60),
                    new SqlParameter("@MB189", SqlDbType.Char,60),
                    new SqlParameter("@MB190", SqlDbType.Char,60),
                    new SqlParameter("@MB191", SqlDbType.Char,60),
                    new SqlParameter("@MB192", SqlDbType.Char,60),
                    new SqlParameter("@MB193", SqlDbType.Char,60),
                    new SqlParameter("@MB194", SqlDbType.Char,60),
                    new SqlParameter("@MB195", SqlDbType.Char,60),
                    new SqlParameter("@MB196", SqlDbType.Char,60),
                    new SqlParameter("@MB197", SqlDbType.Char,60),
                    new SqlParameter("@MB198", SqlDbType.Char,60),
                    new SqlParameter("@MB199", SqlDbType.Char,60),
                    new SqlParameter("@MB401", SqlDbType.Decimal,5),
                    new SqlParameter("@MB402", SqlDbType.Decimal,5),
                    new SqlParameter("@MB403", SqlDbType.Decimal,5),
                    new SqlParameter("@MB404", SqlDbType.Decimal,9),
                    new SqlParameter("@MB405", SqlDbType.Char,1),
                    new SqlParameter("@MB406", SqlDbType.Char,3),
                    new SqlParameter("@MB407", SqlDbType.Char,1),
                    new SqlParameter("@MB408", SqlDbType.Char,4),
                    new SqlParameter("@MB409", SqlDbType.Char,10),
                    new SqlParameter("@MB410", SqlDbType.Decimal,9),
                    new SqlParameter("@MB411", SqlDbType.Char,1),
                    new SqlParameter("@MB412", SqlDbType.Char,10),
                    new SqlParameter("@MB413", SqlDbType.Char,1),
                    new SqlParameter("@MB414", SqlDbType.Char,10),
                    new SqlParameter("@MB415", SqlDbType.Decimal,9),
                    new SqlParameter("@MB416", SqlDbType.Decimal,9),
                    new SqlParameter("@MB417", SqlDbType.Decimal,9),
                    new SqlParameter("@MB418", SqlDbType.Decimal,9),
                    new SqlParameter("@MB419", SqlDbType.Decimal,9),
                    new SqlParameter("@MB420", SqlDbType.Decimal,9),
                    new SqlParameter("@MB421", SqlDbType.Char,1),
                    new SqlParameter("@MB422", SqlDbType.Char,10),
                    new SqlParameter("@MB423", SqlDbType.Char,1),
                    new SqlParameter("@MB424", SqlDbType.Char,10),
                    new SqlParameter("@MB425", SqlDbType.Decimal,5),
                    new SqlParameter("@MB426", SqlDbType.Decimal,5),
                    new SqlParameter("@MB427", SqlDbType.Decimal,5),
                    new SqlParameter("@MB428", SqlDbType.Decimal,9),
                    new SqlParameter("@MB429", SqlDbType.Decimal,9),
                    new SqlParameter("@MB430", SqlDbType.Decimal,9),
                    new SqlParameter("@MB431", SqlDbType.Decimal,9),
                    new SqlParameter("@MB432", SqlDbType.Decimal,9),
                    new SqlParameter("@MB433", SqlDbType.Decimal,9),
                    new SqlParameter("@MB434", SqlDbType.Decimal,9),
                    new SqlParameter("@MB435", SqlDbType.Char,1),
                    new SqlParameter("@MB436", SqlDbType.Char,8),
                    new SqlParameter("@MB437", SqlDbType.VarChar,30),
                    new SqlParameter("@MB438", SqlDbType.Decimal,9),
                    new SqlParameter("@MB439", SqlDbType.Decimal,9),
                    new SqlParameter("@MB440", SqlDbType.Decimal,9),
                    new SqlParameter("@MB441", SqlDbType.Char,1),
                    new SqlParameter("@MB442", SqlDbType.Char,1),
                    new SqlParameter("@MB443", SqlDbType.Char,1),
                    new SqlParameter("@MB444", SqlDbType.Char,4),
                    new SqlParameter("@MB445", SqlDbType.Char,6),
                    new SqlParameter("@MB446", SqlDbType.Decimal,5),
                    new SqlParameter("@MB447", SqlDbType.Decimal,5),
                    new SqlParameter("@MB448", SqlDbType.Decimal,5),
                    new SqlParameter("@MB449", SqlDbType.Decimal,5),
                    new SqlParameter("@MB450", SqlDbType.Char,1),
                    new SqlParameter("@MB451", SqlDbType.Char,8),
                    new SqlParameter("@MB452", SqlDbType.Decimal,9),
                    new SqlParameter("@MBD01", SqlDbType.Char,1),
                    new SqlParameter("@MBD02", SqlDbType.Char,1),
                    new SqlParameter("@MBE01", SqlDbType.Char,10),
                    new SqlParameter("@MB453", SqlDbType.Char,30),
                    new SqlParameter("@MB454", SqlDbType.Char,1),
                    new SqlParameter("@MBH01", SqlDbType.Char,1),
                    new SqlParameter("@MBH02", SqlDbType.Char,10),
                    new SqlParameter("@MBH03", SqlDbType.Char,10),
                    new SqlParameter("@MB455", SqlDbType.Char,1),
                    new SqlParameter("@MB456", SqlDbType.Char,6),
                    new SqlParameter("@MB457", SqlDbType.Char,6),
                    new SqlParameter("@MB458", SqlDbType.Char,6),
                    new SqlParameter("@MB459", SqlDbType.Char,6),
                    new SqlParameter("@MB460", SqlDbType.Char,6),
                    new SqlParameter("@MB461", SqlDbType.Char,6),
                    new SqlParameter("@MB462", SqlDbType.Char,6),
                    new SqlParameter("@MB463", SqlDbType.Char,6),
                    new SqlParameter("@MB464", SqlDbType.Char,6),
                    new SqlParameter("@MB465", SqlDbType.Char,6),
                    new SqlParameter("@MB466", SqlDbType.Char,6),
                    new SqlParameter("@MB467", SqlDbType.Char,6),
                    new SqlParameter("@MB468", SqlDbType.Char,6),
                    new SqlParameter("@MB469", SqlDbType.Char,6),
                    new SqlParameter("@MB470", SqlDbType.Char,6),
                    new SqlParameter("@MB471", SqlDbType.Char,6),
                    new SqlParameter("@MB472", SqlDbType.Char,6),
                    new SqlParameter("@MB473", SqlDbType.Char,6),
                    new SqlParameter("@MB474", SqlDbType.Char,6),
                    new SqlParameter("@MB475", SqlDbType.Char,6),
                    new SqlParameter("@MBL01", SqlDbType.Decimal,5),
                    new SqlParameter("@MBL02", SqlDbType.Char,1),
                    new SqlParameter("@MBL03", SqlDbType.Char,1),
                    new SqlParameter("@MBL04", SqlDbType.Char,1),
                    new SqlParameter("@MB476", SqlDbType.Decimal,5),
                    new SqlParameter("@MB477", SqlDbType.Char,1),
                    new SqlParameter("@MB478", SqlDbType.Char,1),
                    new SqlParameter("@MB479", SqlDbType.Char,1),
                    new SqlParameter("@MB480", SqlDbType.Char,10),
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
            parameters[7].Value = model.MB001;
            parameters[8].Value = model.MB002;
            parameters[9].Value = model.MB003;
            parameters[10].Value = model.MB004;
            parameters[11].Value = model.MB005;
            parameters[12].Value = model.MB006;
            parameters[13].Value = model.MB007;
            parameters[14].Value = model.MB008;
            parameters[15].Value = model.MB009;
            parameters[16].Value = model.MB010;
            parameters[17].Value = model.MB011;
            parameters[18].Value = model.MB012;
            parameters[19].Value = model.MB013;
            parameters[20].Value = model.MB014;
            parameters[21].Value = model.MB015;
            parameters[22].Value = model.MB016;
            parameters[23].Value = model.MB017;
            parameters[24].Value = model.MB018;
            parameters[25].Value = model.MB019;
            parameters[26].Value = model.MB020;
            parameters[27].Value = model.MB021;
            parameters[28].Value = model.MB022;
            parameters[29].Value = model.MB023;
            parameters[30].Value = model.MB024;
            parameters[31].Value = model.MB025;
            parameters[32].Value = model.MB026;
            parameters[33].Value = model.MB027;
            parameters[34].Value = model.MB028;
            parameters[35].Value = model.MB029;
            parameters[36].Value = model.MB030;
            parameters[37].Value = model.MB031;
            parameters[38].Value = model.MB032;
            parameters[39].Value = model.MB033;
            parameters[40].Value = model.MB034;
            parameters[41].Value = model.MB035;
            parameters[42].Value = model.MB036;
            parameters[43].Value = model.MB037;
            parameters[44].Value = model.MB038;
            parameters[45].Value = model.MB039;
            parameters[46].Value = model.MB040;
            parameters[47].Value = model.MB041;
            parameters[48].Value = model.MB042;
            parameters[49].Value = model.MB043;
            parameters[50].Value = model.MB044;
            parameters[51].Value = model.MB045;
            parameters[52].Value = model.MB046;
            parameters[53].Value = model.MB047;
            parameters[54].Value = model.MB048;
            parameters[55].Value = model.MB049;
            parameters[56].Value = model.MB050;
            parameters[57].Value = model.MB051;
            parameters[58].Value = model.MB052;
            parameters[59].Value = model.MB053;
            parameters[60].Value = model.MB054;
            parameters[61].Value = model.MB055;
            parameters[62].Value = model.MB056;
            parameters[63].Value = model.MB057;
            parameters[64].Value = model.MB058;
            parameters[65].Value = model.MB059;
            parameters[66].Value = model.MB060;
            parameters[67].Value = model.MB061;
            parameters[68].Value = model.MB062;
            parameters[69].Value = model.MB063;
            parameters[70].Value = model.MB064;
            parameters[71].Value = model.MB065;
            parameters[72].Value = model.MB066;
            parameters[73].Value = model.MB067;
            parameters[74].Value = model.MB068;
            parameters[75].Value = model.MB069;
            parameters[76].Value = model.MB070;
            parameters[77].Value = model.MB071;
            parameters[78].Value = model.MB072;
            parameters[79].Value = model.MB073;
            parameters[80].Value = model.MB074;
            parameters[81].Value = model.MB075;
            parameters[82].Value = model.MB076;
            parameters[83].Value = model.MB077;
            parameters[84].Value = model.MB078;
            parameters[85].Value = model.MB079;
            parameters[86].Value = model.MB080;
            parameters[87].Value = model.MB081;
            parameters[88].Value = model.MB082;
            parameters[89].Value = model.MB083;
            parameters[90].Value = model.MB084;
            parameters[91].Value = model.MB085;
            parameters[92].Value = model.MB086;
            parameters[93].Value = model.MB087;
            parameters[94].Value = model.MB088;
            parameters[95].Value = model.MB089;
            parameters[96].Value = model.MB090;
            parameters[97].Value = model.MB091;
            parameters[98].Value = model.MB092;
            parameters[99].Value = model.MB093;
            parameters[100].Value = model.MB094;
            parameters[101].Value = model.MB095;
            parameters[102].Value = model.MB096;
            parameters[103].Value = model.MB100;
            parameters[104].Value = model.MB101;
            parameters[105].Value = model.MB102;
            parameters[106].Value = model.MB103;
            parameters[107].Value = model.MB104;
            parameters[108].Value = model.MB105;
            parameters[109].Value = model.MB106;
            parameters[110].Value = model.MB107;
            parameters[111].Value = model.MB108;
            parameters[112].Value = model.MB109;
            parameters[113].Value = model.MB110;
            parameters[114].Value = model.MB111;
            parameters[115].Value = model.MB112;
            parameters[116].Value = model.MB113;
            parameters[117].Value = model.MB114;
            parameters[118].Value = model.MB115;
            parameters[119].Value = model.MB116;
            parameters[120].Value = model.MB117;
            parameters[121].Value = model.MB118;
            parameters[122].Value = model.MB119;
            parameters[123].Value = model.MB120;
            parameters[124].Value = model.MB121;
            parameters[125].Value = model.MB122;
            parameters[126].Value = model.MB123;
            parameters[127].Value = model.MB124;
            parameters[128].Value = model.MB125;
            parameters[129].Value = model.MB126;
            parameters[130].Value = model.MB127;
            parameters[131].Value = model.MB128;
            parameters[132].Value = model.MB129;
            parameters[133].Value = model.MB130;
            parameters[134].Value = model.MB131;
            parameters[135].Value = model.MB132;
            parameters[136].Value = model.MB133;
            parameters[137].Value = model.MB134;
            parameters[138].Value = model.MB135;
            parameters[139].Value = model.MB136;
            parameters[140].Value = model.MB137;
            parameters[141].Value = model.MB138;
            parameters[142].Value = model.MB139;
            parameters[143].Value = model.MB140;
            parameters[144].Value = model.MB141;
            parameters[145].Value = model.MB142;
            parameters[146].Value = model.MB143;
            parameters[147].Value = model.MB144;
            parameters[148].Value = model.MB145;
            parameters[149].Value = model.MB146;
            parameters[150].Value = model.MB147;
            parameters[151].Value = model.MB148;
            parameters[152].Value = model.MB149;
            parameters[153].Value = model.MB150;
            parameters[154].Value = model.MB151;
            parameters[155].Value = model.MB152;
            parameters[156].Value = model.MB179;
            parameters[157].Value = model.MB180;
            parameters[158].Value = model.MB181;
            parameters[159].Value = model.MB182;
            parameters[160].Value = model.MB183;
            parameters[161].Value = model.MB184;
            parameters[162].Value = model.MB185;
            parameters[163].Value = model.MB186;
            parameters[164].Value = model.MB187;
            parameters[165].Value = model.MB188;
            parameters[166].Value = model.MB189;
            parameters[167].Value = model.MB190;
            parameters[168].Value = model.MB191;
            parameters[169].Value = model.MB192;
            parameters[170].Value = model.MB193;
            parameters[171].Value = model.MB194;
            parameters[172].Value = model.MB195;
            parameters[173].Value = model.MB196;
            parameters[174].Value = model.MB197;
            parameters[175].Value = model.MB198;
            parameters[176].Value = model.MB199;
            parameters[177].Value = model.MB401;
            parameters[178].Value = model.MB402;
            parameters[179].Value = model.MB403;
            parameters[180].Value = model.MB404;
            parameters[181].Value = model.MB405;
            parameters[182].Value = model.MB406;
            parameters[183].Value = model.MB407;
            parameters[184].Value = model.MB408;
            parameters[185].Value = model.MB409;
            parameters[186].Value = model.MB410;
            parameters[187].Value = model.MB411;
            parameters[188].Value = model.MB412;
            parameters[189].Value = model.MB413;
            parameters[190].Value = model.MB414;
            parameters[191].Value = model.MB415;
            parameters[192].Value = model.MB416;
            parameters[193].Value = model.MB417;
            parameters[194].Value = model.MB418;
            parameters[195].Value = model.MB419;
            parameters[196].Value = model.MB420;
            parameters[197].Value = model.MB421;
            parameters[198].Value = model.MB422;
            parameters[199].Value = model.MB423;
            parameters[200].Value = model.MB424;
            parameters[201].Value = model.MB425;
            parameters[202].Value = model.MB426;
            parameters[203].Value = model.MB427;
            parameters[204].Value = model.MB428;
            parameters[205].Value = model.MB429;
            parameters[206].Value = model.MB430;
            parameters[207].Value = model.MB431;
            parameters[208].Value = model.MB432;
            parameters[209].Value = model.MB433;
            parameters[210].Value = model.MB434;
            parameters[211].Value = model.MB435;
            parameters[212].Value = model.MB436;
            parameters[213].Value = model.MB437;
            parameters[214].Value = model.MB438;
            parameters[215].Value = model.MB439;
            parameters[216].Value = model.MB440;
            parameters[217].Value = model.MB441;
            parameters[218].Value = model.MB442;
            parameters[219].Value = model.MB443;
            parameters[220].Value = model.MB444;
            parameters[221].Value = model.MB445;
            parameters[222].Value = model.MB446;
            parameters[223].Value = model.MB447;
            parameters[224].Value = model.MB448;
            parameters[225].Value = model.MB449;
            parameters[226].Value = model.MB450;
            parameters[227].Value = model.MB451;
            parameters[228].Value = model.MB452;
            parameters[229].Value = model.MBD01;
            parameters[230].Value = model.MBD02;
            parameters[231].Value = model.MBE01;
            parameters[232].Value = model.MB453;
            parameters[233].Value = model.MB454;
            parameters[234].Value = model.MBH01;
            parameters[235].Value = model.MBH02;
            parameters[236].Value = model.MBH03;
            parameters[237].Value = model.MB455;
            parameters[238].Value = model.MB456;
            parameters[239].Value = model.MB457;
            parameters[240].Value = model.MB458;
            parameters[241].Value = model.MB459;
            parameters[242].Value = model.MB460;
            parameters[243].Value = model.MB461;
            parameters[244].Value = model.MB462;
            parameters[245].Value = model.MB463;
            parameters[246].Value = model.MB464;
            parameters[247].Value = model.MB465;
            parameters[248].Value = model.MB466;
            parameters[249].Value = model.MB467;
            parameters[250].Value = model.MB468;
            parameters[251].Value = model.MB469;
            parameters[252].Value = model.MB470;
            parameters[253].Value = model.MB471;
            parameters[254].Value = model.MB472;
            parameters[255].Value = model.MB473;
            parameters[256].Value = model.MB474;
            parameters[257].Value = model.MB475;
            parameters[258].Value = model.MBL01;
            parameters[259].Value = model.MBL02;
            parameters[260].Value = model.MBL03;
            parameters[261].Value = model.MBL04;
            parameters[262].Value = model.MB476;
            parameters[263].Value = model.MB477;
            parameters[264].Value = model.MB478;
            parameters[265].Value = model.MB479;
            parameters[266].Value = model.MB480;
            parameters[267].Value = model.UDF01;
            parameters[268].Value = model.UDF02;
            parameters[269].Value = model.UDF03;
            parameters[270].Value = model.UDF04;
            parameters[271].Value = model.UDF05;
            parameters[272].Value = model.UDF06;
            parameters[273].Value = model.UDF51;
            parameters[274].Value = model.UDF52;
            parameters[275].Value = model.UDF53;
            parameters[276].Value = model.UDF54;
            parameters[277].Value = model.UDF55;
            parameters[278].Value = model.UDF56;
            parameters[279].Value = model.UDF07;
            parameters[280].Value = model.UDF08;
            parameters[281].Value = model.UDF09;
            parameters[282].Value = model.UDF10;
            parameters[283].Value = model.UDF11;
            parameters[284].Value = model.UDF12;
            parameters[285].Value = model.UDF57;
            parameters[286].Value = model.UDF58;
            parameters[287].Value = model.UDF59;
            parameters[288].Value = model.UDF60;
            parameters[289].Value = model.UDF61;
            parameters[290].Value = model.UDF62;

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
        public bool Update(YJUI.Model.INVMB model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update INVMB set ");
            strSql.Append("COMPANY=@COMPANY,");
            strSql.Append("CREATOR=@CREATOR,");
            strSql.Append("USR_GROUP=@USR_GROUP,");
            strSql.Append("CREATE_DATE=@CREATE_DATE,");
            strSql.Append("MODIFIER=@MODIFIER,");
            strSql.Append("MODI_DATE=@MODI_DATE,");
            strSql.Append("FLAG=@FLAG,");
            strSql.Append("MB003=@MB003,");
            strSql.Append("MB004=@MB004,");
            strSql.Append("MB005=@MB005,");
            strSql.Append("MB006=@MB006,");
            strSql.Append("MB007=@MB007,");
            strSql.Append("MB008=@MB008,");
            strSql.Append("MB009=@MB009,");
            strSql.Append("MB010=@MB010,");
            strSql.Append("MB011=@MB011,");
            strSql.Append("MB012=@MB012,");
            strSql.Append("MB013=@MB013,");
            strSql.Append("MB014=@MB014,");
            strSql.Append("MB015=@MB015,");
            strSql.Append("MB016=@MB016,");
            strSql.Append("MB017=@MB017,");
            strSql.Append("MB018=@MB018,");
            strSql.Append("MB019=@MB019,");
            strSql.Append("MB020=@MB020,");
            strSql.Append("MB021=@MB021,");
            strSql.Append("MB022=@MB022,");
            strSql.Append("MB023=@MB023,");
            strSql.Append("MB024=@MB024,");
            strSql.Append("MB027=@MB027,");
            strSql.Append("MB028=@MB028,");
            strSql.Append("MB029=@MB029,");
            strSql.Append("MB030=@MB030,");
            strSql.Append("MB031=@MB031,");
            strSql.Append("MB032=@MB032,");
            strSql.Append("MB033=@MB033,");
            strSql.Append("MB034=@MB034,");
            strSql.Append("MB035=@MB035,");
            strSql.Append("MB036=@MB036,");
            strSql.Append("MB037=@MB037,");
            strSql.Append("MB038=@MB038,");
            strSql.Append("MB039=@MB039,");
            strSql.Append("MB040=@MB040,");
            strSql.Append("MB041=@MB041,");
            strSql.Append("MB042=@MB042,");
            strSql.Append("MB043=@MB043,");
            strSql.Append("MB044=@MB044,");
            strSql.Append("MB045=@MB045,");
            strSql.Append("MB046=@MB046,");
            strSql.Append("MB047=@MB047,");
            strSql.Append("MB048=@MB048,");
            strSql.Append("MB049=@MB049,");
            strSql.Append("MB050=@MB050,");
            strSql.Append("MB051=@MB051,");
            strSql.Append("MB052=@MB052,");
            strSql.Append("MB053=@MB053,");
            strSql.Append("MB054=@MB054,");
            strSql.Append("MB055=@MB055,");
            strSql.Append("MB056=@MB056,");
            strSql.Append("MB057=@MB057,");
            strSql.Append("MB058=@MB058,");
            strSql.Append("MB059=@MB059,");
            strSql.Append("MB060=@MB060,");
            strSql.Append("MB061=@MB061,");
            strSql.Append("MB062=@MB062,");
            strSql.Append("MB063=@MB063,");
            strSql.Append("MB064=@MB064,");
            strSql.Append("MB065=@MB065,");
            strSql.Append("MB066=@MB066,");
            strSql.Append("MB067=@MB067,");
            strSql.Append("MB068=@MB068,");
            strSql.Append("MB069=@MB069,");
            strSql.Append("MB070=@MB070,");
            strSql.Append("MB071=@MB071,");
            strSql.Append("MB072=@MB072,");
            strSql.Append("MB073=@MB073,");
            strSql.Append("MB074=@MB074,");
            strSql.Append("MB075=@MB075,");
            strSql.Append("MB076=@MB076,");
            strSql.Append("MB077=@MB077,");
            strSql.Append("MB078=@MB078,");
            strSql.Append("MB079=@MB079,");
            strSql.Append("MB080=@MB080,");
            strSql.Append("MB081=@MB081,");
            strSql.Append("MB082=@MB082,");
            strSql.Append("MB083=@MB083,");
            strSql.Append("MB084=@MB084,");
            strSql.Append("MB085=@MB085,");
            strSql.Append("MB086=@MB086,");
            strSql.Append("MB087=@MB087,");
            strSql.Append("MB088=@MB088,");
            strSql.Append("MB089=@MB089,");
            strSql.Append("MB090=@MB090,");
            strSql.Append("MB091=@MB091,");
            strSql.Append("MB092=@MB092,");
            strSql.Append("MB093=@MB093,");
            strSql.Append("MB094=@MB094,");
            strSql.Append("MB095=@MB095,");
            strSql.Append("MB096=@MB096,");
            strSql.Append("MB100=@MB100,");
            strSql.Append("MB101=@MB101,");
            strSql.Append("MB102=@MB102,");
            strSql.Append("MB103=@MB103,");
            strSql.Append("MB104=@MB104,");
            strSql.Append("MB105=@MB105,");
            strSql.Append("MB106=@MB106,");
            strSql.Append("MB107=@MB107,");
            strSql.Append("MB108=@MB108,");
            strSql.Append("MB109=@MB109,");
            strSql.Append("MB111=@MB111,");
            strSql.Append("MB112=@MB112,");
            strSql.Append("MB113=@MB113,");
            strSql.Append("MB114=@MB114,");
            strSql.Append("MB115=@MB115,");
            strSql.Append("MB116=@MB116,");
            strSql.Append("MB117=@MB117,");
            strSql.Append("MB118=@MB118,");
            strSql.Append("MB119=@MB119,");
            strSql.Append("MB120=@MB120,");
            strSql.Append("MB121=@MB121,");
            strSql.Append("MB122=@MB122,");
            strSql.Append("MB123=@MB123,");
            strSql.Append("MB124=@MB124,");
            strSql.Append("MB125=@MB125,");
            strSql.Append("MB126=@MB126,");
            strSql.Append("MB127=@MB127,");
            strSql.Append("MB128=@MB128,");
            strSql.Append("MB129=@MB129,");
            strSql.Append("MB130=@MB130,");
            strSql.Append("MB131=@MB131,");
            strSql.Append("MB132=@MB132,");
            strSql.Append("MB133=@MB133,");
            strSql.Append("MB134=@MB134,");
            strSql.Append("MB135=@MB135,");
            strSql.Append("MB136=@MB136,");
            strSql.Append("MB137=@MB137,");
            strSql.Append("MB138=@MB138,");
            strSql.Append("MB139=@MB139,");
            strSql.Append("MB140=@MB140,");
            strSql.Append("MB141=@MB141,");
            strSql.Append("MB142=@MB142,");
            strSql.Append("MB143=@MB143,");
            strSql.Append("MB144=@MB144,");
            strSql.Append("MB145=@MB145,");
            strSql.Append("MB146=@MB146,");
            strSql.Append("MB147=@MB147,");
            strSql.Append("MB148=@MB148,");
            strSql.Append("MB149=@MB149,");
            strSql.Append("MB150=@MB150,");
            strSql.Append("MB151=@MB151,");
            strSql.Append("MB152=@MB152,");
            strSql.Append("MB179=@MB179,");
            strSql.Append("MB180=@MB180,");
            strSql.Append("MB181=@MB181,");
            strSql.Append("MB182=@MB182,");
            strSql.Append("MB183=@MB183,");
            strSql.Append("MB184=@MB184,");
            strSql.Append("MB185=@MB185,");
            strSql.Append("MB186=@MB186,");
            strSql.Append("MB187=@MB187,");
            strSql.Append("MB188=@MB188,");
            strSql.Append("MB189=@MB189,");
            strSql.Append("MB190=@MB190,");
            strSql.Append("MB191=@MB191,");
            strSql.Append("MB192=@MB192,");
            strSql.Append("MB193=@MB193,");
            strSql.Append("MB194=@MB194,");
            strSql.Append("MB195=@MB195,");
            strSql.Append("MB196=@MB196,");
            strSql.Append("MB197=@MB197,");
            strSql.Append("MB198=@MB198,");
            strSql.Append("MB199=@MB199,");
            strSql.Append("MB401=@MB401,");
            strSql.Append("MB402=@MB402,");
            strSql.Append("MB403=@MB403,");
            strSql.Append("MB404=@MB404,");
            strSql.Append("MB405=@MB405,");
            strSql.Append("MB406=@MB406,");
            strSql.Append("MB407=@MB407,");
            strSql.Append("MB408=@MB408,");
            strSql.Append("MB409=@MB409,");
            strSql.Append("MB410=@MB410,");
            strSql.Append("MB411=@MB411,");
            strSql.Append("MB412=@MB412,");
            strSql.Append("MB413=@MB413,");
            strSql.Append("MB414=@MB414,");
            strSql.Append("MB415=@MB415,");
            strSql.Append("MB416=@MB416,");
            strSql.Append("MB417=@MB417,");
            strSql.Append("MB418=@MB418,");
            strSql.Append("MB419=@MB419,");
            strSql.Append("MB420=@MB420,");
            strSql.Append("MB421=@MB421,");
            strSql.Append("MB422=@MB422,");
            strSql.Append("MB423=@MB423,");
            strSql.Append("MB424=@MB424,");
            strSql.Append("MB425=@MB425,");
            strSql.Append("MB426=@MB426,");
            strSql.Append("MB427=@MB427,");
            strSql.Append("MB428=@MB428,");
            strSql.Append("MB429=@MB429,");
            strSql.Append("MB430=@MB430,");
            strSql.Append("MB431=@MB431,");
            strSql.Append("MB432=@MB432,");
            strSql.Append("MB433=@MB433,");
            strSql.Append("MB434=@MB434,");
            strSql.Append("MB435=@MB435,");
            strSql.Append("MB436=@MB436,");
            strSql.Append("MB437=@MB437,");
            strSql.Append("MB438=@MB438,");
            strSql.Append("MB439=@MB439,");
            strSql.Append("MB440=@MB440,");
            strSql.Append("MB441=@MB441,");
            strSql.Append("MB442=@MB442,");
            strSql.Append("MB443=@MB443,");
            strSql.Append("MB444=@MB444,");
            strSql.Append("MB445=@MB445,");
            strSql.Append("MB446=@MB446,");
            strSql.Append("MB447=@MB447,");
            strSql.Append("MB448=@MB448,");
            strSql.Append("MB449=@MB449,");
            strSql.Append("MB450=@MB450,");
            strSql.Append("MB451=@MB451,");
            strSql.Append("MB452=@MB452,");
            strSql.Append("MBD01=@MBD01,");
            strSql.Append("MBD02=@MBD02,");
            strSql.Append("MBE01=@MBE01,");
            strSql.Append("MB453=@MB453,");
            strSql.Append("MB454=@MB454,");
            strSql.Append("MBH01=@MBH01,");
            strSql.Append("MBH02=@MBH02,");
            strSql.Append("MBH03=@MBH03,");
            strSql.Append("MB455=@MB455,");
            strSql.Append("MB456=@MB456,");
            strSql.Append("MB457=@MB457,");
            strSql.Append("MB458=@MB458,");
            strSql.Append("MB459=@MB459,");
            strSql.Append("MB460=@MB460,");
            strSql.Append("MB461=@MB461,");
            strSql.Append("MB462=@MB462,");
            strSql.Append("MB463=@MB463,");
            strSql.Append("MB464=@MB464,");
            strSql.Append("MB465=@MB465,");
            strSql.Append("MB466=@MB466,");
            strSql.Append("MB467=@MB467,");
            strSql.Append("MB468=@MB468,");
            strSql.Append("MB469=@MB469,");
            strSql.Append("MB470=@MB470,");
            strSql.Append("MB471=@MB471,");
            strSql.Append("MB472=@MB472,");
            strSql.Append("MB473=@MB473,");
            strSql.Append("MB474=@MB474,");
            strSql.Append("MB475=@MB475,");
            strSql.Append("MBL01=@MBL01,");
            strSql.Append("MBL02=@MBL02,");
            strSql.Append("MBL03=@MBL03,");
            strSql.Append("MBL04=@MBL04,");
            strSql.Append("MB476=@MB476,");
            strSql.Append("MB477=@MB477,");
            strSql.Append("MB478=@MB478,");
            strSql.Append("MB479=@MB479,");
            strSql.Append("MB480=@MB480,");
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
            strSql.Append(" where MB001=@MB001 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@COMPANY", SqlDbType.Char,10),
                    new SqlParameter("@CREATOR", SqlDbType.Char,10),
                    new SqlParameter("@USR_GROUP", SqlDbType.Char,10),
                    new SqlParameter("@CREATE_DATE", SqlDbType.Char,17),
                    new SqlParameter("@MODIFIER", SqlDbType.Char,10),
                    new SqlParameter("@MODI_DATE", SqlDbType.Char,17),
                    new SqlParameter("@FLAG", SqlDbType.Decimal,5),
                    new SqlParameter("@MB003", SqlDbType.VarChar,60),
                    new SqlParameter("@MB004", SqlDbType.Char,4),
                    new SqlParameter("@MB005", SqlDbType.Char,6),
                    new SqlParameter("@MB006", SqlDbType.Char,6),
                    new SqlParameter("@MB007", SqlDbType.Char,6),
                    new SqlParameter("@MB008", SqlDbType.Char,6),
                    new SqlParameter("@MB009", SqlDbType.VarChar,255),
                    new SqlParameter("@MB010", SqlDbType.Char,20),
                    new SqlParameter("@MB011", SqlDbType.Char,4),
                    new SqlParameter("@MB012", SqlDbType.Char,10),
                    new SqlParameter("@MB013", SqlDbType.Char,20),
                    new SqlParameter("@MB014", SqlDbType.Decimal,9),
                    new SqlParameter("@MB015", SqlDbType.Char,4),
                    new SqlParameter("@MB016", SqlDbType.Char,4),
                    new SqlParameter("@MB017", SqlDbType.Char,10),
                    new SqlParameter("@MB018", SqlDbType.Char,10),
                    new SqlParameter("@MB019", SqlDbType.Char,1),
                    new SqlParameter("@MB020", SqlDbType.Char,1),
                    new SqlParameter("@MB021", SqlDbType.Char,4),
                    new SqlParameter("@MB022", SqlDbType.Char,1),
                    new SqlParameter("@MB023", SqlDbType.Decimal,5),
                    new SqlParameter("@MB024", SqlDbType.Decimal,5),
                    new SqlParameter("@MB027", SqlDbType.Char,1),
                    new SqlParameter("@MB028", SqlDbType.VarChar,255),
                    new SqlParameter("@MB029", SqlDbType.Char,20),
                    new SqlParameter("@MB030", SqlDbType.Char,8),
                    new SqlParameter("@MB031", SqlDbType.Char,8),
                    new SqlParameter("@MB032", SqlDbType.Char,10),
                    new SqlParameter("@MB033", SqlDbType.Char,1),
                    new SqlParameter("@MB034", SqlDbType.Char,1),
                    new SqlParameter("@MB035", SqlDbType.Char,4),
                    new SqlParameter("@MB036", SqlDbType.Decimal,9),
                    new SqlParameter("@MB037", SqlDbType.Decimal,9),
                    new SqlParameter("@MB038", SqlDbType.Decimal,9),
                    new SqlParameter("@MB039", SqlDbType.Decimal,9),
                    new SqlParameter("@MB040", SqlDbType.Decimal,9),
                    new SqlParameter("@MB041", SqlDbType.Decimal,9),
                    new SqlParameter("@MB042", SqlDbType.Char,1),
                    new SqlParameter("@MB043", SqlDbType.Char,1),
                    new SqlParameter("@MB044", SqlDbType.Char,1),
                    new SqlParameter("@MB045", SqlDbType.Decimal,5),
                    new SqlParameter("@MB046", SqlDbType.Decimal,9),
                    new SqlParameter("@MB047", SqlDbType.Decimal,9),
                    new SqlParameter("@MB048", SqlDbType.Char,4),
                    new SqlParameter("@MB049", SqlDbType.Decimal,9),
                    new SqlParameter("@MB050", SqlDbType.Decimal,9),
                    new SqlParameter("@MB051", SqlDbType.Decimal,9),
                    new SqlParameter("@MB052", SqlDbType.Char,1),
                    new SqlParameter("@MB053", SqlDbType.Decimal,9),
                    new SqlParameter("@MB054", SqlDbType.Decimal,9),
                    new SqlParameter("@MB055", SqlDbType.Decimal,9),
                    new SqlParameter("@MB056", SqlDbType.Decimal,9),
                    new SqlParameter("@MB057", SqlDbType.Decimal,9),
                    new SqlParameter("@MB058", SqlDbType.Decimal,9),
                    new SqlParameter("@MB059", SqlDbType.Decimal,9),
                    new SqlParameter("@MB060", SqlDbType.Decimal,9),
                    new SqlParameter("@MB061", SqlDbType.Decimal,9),
                    new SqlParameter("@MB062", SqlDbType.Decimal,9),
                    new SqlParameter("@MB063", SqlDbType.Decimal,9),
                    new SqlParameter("@MB064", SqlDbType.Decimal,9),
                    new SqlParameter("@MB065", SqlDbType.Decimal,9),
                    new SqlParameter("@MB066", SqlDbType.Char,1),
                    new SqlParameter("@MB067", SqlDbType.Char,10),
                    new SqlParameter("@MB068", SqlDbType.Char,10),
                    new SqlParameter("@MB069", SqlDbType.Decimal,9),
                    new SqlParameter("@MB070", SqlDbType.Decimal,9),
                    new SqlParameter("@MB071", SqlDbType.Decimal,9),
                    new SqlParameter("@MB072", SqlDbType.Char,4),
                    new SqlParameter("@MB073", SqlDbType.Decimal,9),
                    new SqlParameter("@MB074", SqlDbType.Decimal,9),
                    new SqlParameter("@MB075", SqlDbType.Decimal,9),
                    new SqlParameter("@MB076", SqlDbType.Decimal,5),
                    new SqlParameter("@MB077", SqlDbType.Char,6),
                    new SqlParameter("@MB078", SqlDbType.Decimal,5),
                    new SqlParameter("@MB079", SqlDbType.Decimal,5),
                    new SqlParameter("@MB080", SqlDbType.Char,20),
                    new SqlParameter("@MB081", SqlDbType.Char,4),
                    new SqlParameter("@MB082", SqlDbType.Decimal,5),
                    new SqlParameter("@MB083", SqlDbType.Char,1),
                    new SqlParameter("@MB084", SqlDbType.Decimal,5),
                    new SqlParameter("@MB085", SqlDbType.Char,1),
                    new SqlParameter("@MB086", SqlDbType.Decimal,5),
                    new SqlParameter("@MB087", SqlDbType.Char,1),
                    new SqlParameter("@MB088", SqlDbType.Decimal,5),
                    new SqlParameter("@MB089", SqlDbType.Decimal,9),
                    new SqlParameter("@MB090", SqlDbType.Char,4),
                    new SqlParameter("@MB091", SqlDbType.Char,1),
                    new SqlParameter("@MB092", SqlDbType.Char,1),
                    new SqlParameter("@MB093", SqlDbType.Decimal,9),
                    new SqlParameter("@MB094", SqlDbType.Decimal,9),
                    new SqlParameter("@MB095", SqlDbType.Decimal,9),
                    new SqlParameter("@MB096", SqlDbType.Decimal,5),
                    new SqlParameter("@MB100", SqlDbType.Char,1),
                    new SqlParameter("@MB101", SqlDbType.Char,1),
                    new SqlParameter("@MB102", SqlDbType.Char,1),
                    new SqlParameter("@MB103", SqlDbType.Char,1),
                    new SqlParameter("@MB104", SqlDbType.Char,1),
                    new SqlParameter("@MB105", SqlDbType.Char,1),
                    new SqlParameter("@MB106", SqlDbType.Char,1),
                    new SqlParameter("@MB107", SqlDbType.Char,1),
                    new SqlParameter("@MB108", SqlDbType.Char,1),
                    new SqlParameter("@MB109", SqlDbType.Char,1),
                    new SqlParameter("@MB111", SqlDbType.Decimal,5),
                    new SqlParameter("@MB112", SqlDbType.Char,60),
                    new SqlParameter("@MB113", SqlDbType.Char,1),
                    new SqlParameter("@MB114", SqlDbType.Char,1),
                    new SqlParameter("@MB115", SqlDbType.Char,1),
                    new SqlParameter("@MB116", SqlDbType.Char,1),
                    new SqlParameter("@MB117", SqlDbType.Char,1),
                    new SqlParameter("@MB118", SqlDbType.Char,1),
                    new SqlParameter("@MB119", SqlDbType.Char,1),
                    new SqlParameter("@MB120", SqlDbType.Char,1),
                    new SqlParameter("@MB121", SqlDbType.Char,30),
                    new SqlParameter("@MB122", SqlDbType.Char,30),
                    new SqlParameter("@MB123", SqlDbType.Char,30),
                    new SqlParameter("@MB124", SqlDbType.Char,30),
                    new SqlParameter("@MB125", SqlDbType.Char,60),
                    new SqlParameter("@MB126", SqlDbType.Char,1),
                    new SqlParameter("@MB127", SqlDbType.Char,1),
                    new SqlParameter("@MB128", SqlDbType.Char,60),
                    new SqlParameter("@MB129", SqlDbType.Char,60),
                    new SqlParameter("@MB130", SqlDbType.Char,60),
                    new SqlParameter("@MB131", SqlDbType.Char,20),
                    new SqlParameter("@MB132", SqlDbType.Char,20),
                    new SqlParameter("@MB133", SqlDbType.Char,20),
                    new SqlParameter("@MB134", SqlDbType.VarChar,255),
                    new SqlParameter("@MB135", SqlDbType.VarChar,255),
                    new SqlParameter("@MB136", SqlDbType.Char,1),
                    new SqlParameter("@MB137", SqlDbType.Char,1),
                    new SqlParameter("@MB138", SqlDbType.Char,10),
                    new SqlParameter("@MB139", SqlDbType.Char,8),
                    new SqlParameter("@MB140", SqlDbType.Char,1),
                    new SqlParameter("@MB141", SqlDbType.Char,1),
                    new SqlParameter("@MB142", SqlDbType.Char,12),
                    new SqlParameter("@MB143", SqlDbType.Char,10),
                    new SqlParameter("@MB144", SqlDbType.Char,1),
                    new SqlParameter("@MB145", SqlDbType.Char,1),
                    new SqlParameter("@MB146", SqlDbType.Char,10),
                    new SqlParameter("@MB147", SqlDbType.Decimal,5),
                    new SqlParameter("@MB148", SqlDbType.Char,4),
                    new SqlParameter("@MB149", SqlDbType.Char,4),
                    new SqlParameter("@MB150", SqlDbType.Char,10),
                    new SqlParameter("@MB151", SqlDbType.Decimal,5),
                    new SqlParameter("@MB152", SqlDbType.Decimal,5),
                    new SqlParameter("@MB179", SqlDbType.Char,10),
                    new SqlParameter("@MB180", SqlDbType.Char,60),
                    new SqlParameter("@MB181", SqlDbType.Char,60),
                    new SqlParameter("@MB182", SqlDbType.Char,60),
                    new SqlParameter("@MB183", SqlDbType.Char,60),
                    new SqlParameter("@MB184", SqlDbType.Char,60),
                    new SqlParameter("@MB185", SqlDbType.Char,60),
                    new SqlParameter("@MB186", SqlDbType.Char,60),
                    new SqlParameter("@MB187", SqlDbType.Char,60),
                    new SqlParameter("@MB188", SqlDbType.Char,60),
                    new SqlParameter("@MB189", SqlDbType.Char,60),
                    new SqlParameter("@MB190", SqlDbType.Char,60),
                    new SqlParameter("@MB191", SqlDbType.Char,60),
                    new SqlParameter("@MB192", SqlDbType.Char,60),
                    new SqlParameter("@MB193", SqlDbType.Char,60),
                    new SqlParameter("@MB194", SqlDbType.Char,60),
                    new SqlParameter("@MB195", SqlDbType.Char,60),
                    new SqlParameter("@MB196", SqlDbType.Char,60),
                    new SqlParameter("@MB197", SqlDbType.Char,60),
                    new SqlParameter("@MB198", SqlDbType.Char,60),
                    new SqlParameter("@MB199", SqlDbType.Char,60),
                    new SqlParameter("@MB401", SqlDbType.Decimal,5),
                    new SqlParameter("@MB402", SqlDbType.Decimal,5),
                    new SqlParameter("@MB403", SqlDbType.Decimal,5),
                    new SqlParameter("@MB404", SqlDbType.Decimal,9),
                    new SqlParameter("@MB405", SqlDbType.Char,1),
                    new SqlParameter("@MB406", SqlDbType.Char,3),
                    new SqlParameter("@MB407", SqlDbType.Char,1),
                    new SqlParameter("@MB408", SqlDbType.Char,4),
                    new SqlParameter("@MB409", SqlDbType.Char,10),
                    new SqlParameter("@MB410", SqlDbType.Decimal,9),
                    new SqlParameter("@MB411", SqlDbType.Char,1),
                    new SqlParameter("@MB412", SqlDbType.Char,10),
                    new SqlParameter("@MB413", SqlDbType.Char,1),
                    new SqlParameter("@MB414", SqlDbType.Char,10),
                    new SqlParameter("@MB415", SqlDbType.Decimal,9),
                    new SqlParameter("@MB416", SqlDbType.Decimal,9),
                    new SqlParameter("@MB417", SqlDbType.Decimal,9),
                    new SqlParameter("@MB418", SqlDbType.Decimal,9),
                    new SqlParameter("@MB419", SqlDbType.Decimal,9),
                    new SqlParameter("@MB420", SqlDbType.Decimal,9),
                    new SqlParameter("@MB421", SqlDbType.Char,1),
                    new SqlParameter("@MB422", SqlDbType.Char,10),
                    new SqlParameter("@MB423", SqlDbType.Char,1),
                    new SqlParameter("@MB424", SqlDbType.Char,10),
                    new SqlParameter("@MB425", SqlDbType.Decimal,5),
                    new SqlParameter("@MB426", SqlDbType.Decimal,5),
                    new SqlParameter("@MB427", SqlDbType.Decimal,5),
                    new SqlParameter("@MB428", SqlDbType.Decimal,9),
                    new SqlParameter("@MB429", SqlDbType.Decimal,9),
                    new SqlParameter("@MB430", SqlDbType.Decimal,9),
                    new SqlParameter("@MB431", SqlDbType.Decimal,9),
                    new SqlParameter("@MB432", SqlDbType.Decimal,9),
                    new SqlParameter("@MB433", SqlDbType.Decimal,9),
                    new SqlParameter("@MB434", SqlDbType.Decimal,9),
                    new SqlParameter("@MB435", SqlDbType.Char,1),
                    new SqlParameter("@MB436", SqlDbType.Char,8),
                    new SqlParameter("@MB437", SqlDbType.VarChar,30),
                    new SqlParameter("@MB438", SqlDbType.Decimal,9),
                    new SqlParameter("@MB439", SqlDbType.Decimal,9),
                    new SqlParameter("@MB440", SqlDbType.Decimal,9),
                    new SqlParameter("@MB441", SqlDbType.Char,1),
                    new SqlParameter("@MB442", SqlDbType.Char,1),
                    new SqlParameter("@MB443", SqlDbType.Char,1),
                    new SqlParameter("@MB444", SqlDbType.Char,4),
                    new SqlParameter("@MB445", SqlDbType.Char,6),
                    new SqlParameter("@MB446", SqlDbType.Decimal,5),
                    new SqlParameter("@MB447", SqlDbType.Decimal,5),
                    new SqlParameter("@MB448", SqlDbType.Decimal,5),
                    new SqlParameter("@MB449", SqlDbType.Decimal,5),
                    new SqlParameter("@MB450", SqlDbType.Char,1),
                    new SqlParameter("@MB451", SqlDbType.Char,8),
                    new SqlParameter("@MB452", SqlDbType.Decimal,9),
                    new SqlParameter("@MBD01", SqlDbType.Char,1),
                    new SqlParameter("@MBD02", SqlDbType.Char,1),
                    new SqlParameter("@MBE01", SqlDbType.Char,10),
                    new SqlParameter("@MB453", SqlDbType.Char,30),
                    new SqlParameter("@MB454", SqlDbType.Char,1),
                    new SqlParameter("@MBH01", SqlDbType.Char,1),
                    new SqlParameter("@MBH02", SqlDbType.Char,10),
                    new SqlParameter("@MBH03", SqlDbType.Char,10),
                    new SqlParameter("@MB455", SqlDbType.Char,1),
                    new SqlParameter("@MB456", SqlDbType.Char,6),
                    new SqlParameter("@MB457", SqlDbType.Char,6),
                    new SqlParameter("@MB458", SqlDbType.Char,6),
                    new SqlParameter("@MB459", SqlDbType.Char,6),
                    new SqlParameter("@MB460", SqlDbType.Char,6),
                    new SqlParameter("@MB461", SqlDbType.Char,6),
                    new SqlParameter("@MB462", SqlDbType.Char,6),
                    new SqlParameter("@MB463", SqlDbType.Char,6),
                    new SqlParameter("@MB464", SqlDbType.Char,6),
                    new SqlParameter("@MB465", SqlDbType.Char,6),
                    new SqlParameter("@MB466", SqlDbType.Char,6),
                    new SqlParameter("@MB467", SqlDbType.Char,6),
                    new SqlParameter("@MB468", SqlDbType.Char,6),
                    new SqlParameter("@MB469", SqlDbType.Char,6),
                    new SqlParameter("@MB470", SqlDbType.Char,6),
                    new SqlParameter("@MB471", SqlDbType.Char,6),
                    new SqlParameter("@MB472", SqlDbType.Char,6),
                    new SqlParameter("@MB473", SqlDbType.Char,6),
                    new SqlParameter("@MB474", SqlDbType.Char,6),
                    new SqlParameter("@MB475", SqlDbType.Char,6),
                    new SqlParameter("@MBL01", SqlDbType.Decimal,5),
                    new SqlParameter("@MBL02", SqlDbType.Char,1),
                    new SqlParameter("@MBL03", SqlDbType.Char,1),
                    new SqlParameter("@MBL04", SqlDbType.Char,1),
                    new SqlParameter("@MB476", SqlDbType.Decimal,5),
                    new SqlParameter("@MB477", SqlDbType.Char,1),
                    new SqlParameter("@MB478", SqlDbType.Char,1),
                    new SqlParameter("@MB479", SqlDbType.Char,1),
                    new SqlParameter("@MB480", SqlDbType.Char,10),
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
                    new SqlParameter("@MB001", SqlDbType.Char,20),
                    new SqlParameter("@MB002", SqlDbType.VarChar,60),
                    new SqlParameter("@MB025", SqlDbType.Char,1),
                    new SqlParameter("@MB026", SqlDbType.Char,2),
                    new SqlParameter("@MB110", SqlDbType.Char,20)};
            parameters[0].Value = model.COMPANY;
            parameters[1].Value = model.CREATOR;
            parameters[2].Value = model.USR_GROUP;
            parameters[3].Value = model.CREATE_DATE;
            parameters[4].Value = model.MODIFIER;
            parameters[5].Value = model.MODI_DATE;
            parameters[6].Value = model.FLAG;
            parameters[7].Value = model.MB003;
            parameters[8].Value = model.MB004;
            parameters[9].Value = model.MB005;
            parameters[10].Value = model.MB006;
            parameters[11].Value = model.MB007;
            parameters[12].Value = model.MB008;
            parameters[13].Value = model.MB009;
            parameters[14].Value = model.MB010;
            parameters[15].Value = model.MB011;
            parameters[16].Value = model.MB012;
            parameters[17].Value = model.MB013;
            parameters[18].Value = model.MB014;
            parameters[19].Value = model.MB015;
            parameters[20].Value = model.MB016;
            parameters[21].Value = model.MB017;
            parameters[22].Value = model.MB018;
            parameters[23].Value = model.MB019;
            parameters[24].Value = model.MB020;
            parameters[25].Value = model.MB021;
            parameters[26].Value = model.MB022;
            parameters[27].Value = model.MB023;
            parameters[28].Value = model.MB024;
            parameters[29].Value = model.MB027;
            parameters[30].Value = model.MB028;
            parameters[31].Value = model.MB029;
            parameters[32].Value = model.MB030;
            parameters[33].Value = model.MB031;
            parameters[34].Value = model.MB032;
            parameters[35].Value = model.MB033;
            parameters[36].Value = model.MB034;
            parameters[37].Value = model.MB035;
            parameters[38].Value = model.MB036;
            parameters[39].Value = model.MB037;
            parameters[40].Value = model.MB038;
            parameters[41].Value = model.MB039;
            parameters[42].Value = model.MB040;
            parameters[43].Value = model.MB041;
            parameters[44].Value = model.MB042;
            parameters[45].Value = model.MB043;
            parameters[46].Value = model.MB044;
            parameters[47].Value = model.MB045;
            parameters[48].Value = model.MB046;
            parameters[49].Value = model.MB047;
            parameters[50].Value = model.MB048;
            parameters[51].Value = model.MB049;
            parameters[52].Value = model.MB050;
            parameters[53].Value = model.MB051;
            parameters[54].Value = model.MB052;
            parameters[55].Value = model.MB053;
            parameters[56].Value = model.MB054;
            parameters[57].Value = model.MB055;
            parameters[58].Value = model.MB056;
            parameters[59].Value = model.MB057;
            parameters[60].Value = model.MB058;
            parameters[61].Value = model.MB059;
            parameters[62].Value = model.MB060;
            parameters[63].Value = model.MB061;
            parameters[64].Value = model.MB062;
            parameters[65].Value = model.MB063;
            parameters[66].Value = model.MB064;
            parameters[67].Value = model.MB065;
            parameters[68].Value = model.MB066;
            parameters[69].Value = model.MB067;
            parameters[70].Value = model.MB068;
            parameters[71].Value = model.MB069;
            parameters[72].Value = model.MB070;
            parameters[73].Value = model.MB071;
            parameters[74].Value = model.MB072;
            parameters[75].Value = model.MB073;
            parameters[76].Value = model.MB074;
            parameters[77].Value = model.MB075;
            parameters[78].Value = model.MB076;
            parameters[79].Value = model.MB077;
            parameters[80].Value = model.MB078;
            parameters[81].Value = model.MB079;
            parameters[82].Value = model.MB080;
            parameters[83].Value = model.MB081;
            parameters[84].Value = model.MB082;
            parameters[85].Value = model.MB083;
            parameters[86].Value = model.MB084;
            parameters[87].Value = model.MB085;
            parameters[88].Value = model.MB086;
            parameters[89].Value = model.MB087;
            parameters[90].Value = model.MB088;
            parameters[91].Value = model.MB089;
            parameters[92].Value = model.MB090;
            parameters[93].Value = model.MB091;
            parameters[94].Value = model.MB092;
            parameters[95].Value = model.MB093;
            parameters[96].Value = model.MB094;
            parameters[97].Value = model.MB095;
            parameters[98].Value = model.MB096;
            parameters[99].Value = model.MB100;
            parameters[100].Value = model.MB101;
            parameters[101].Value = model.MB102;
            parameters[102].Value = model.MB103;
            parameters[103].Value = model.MB104;
            parameters[104].Value = model.MB105;
            parameters[105].Value = model.MB106;
            parameters[106].Value = model.MB107;
            parameters[107].Value = model.MB108;
            parameters[108].Value = model.MB109;
            parameters[109].Value = model.MB111;
            parameters[110].Value = model.MB112;
            parameters[111].Value = model.MB113;
            parameters[112].Value = model.MB114;
            parameters[113].Value = model.MB115;
            parameters[114].Value = model.MB116;
            parameters[115].Value = model.MB117;
            parameters[116].Value = model.MB118;
            parameters[117].Value = model.MB119;
            parameters[118].Value = model.MB120;
            parameters[119].Value = model.MB121;
            parameters[120].Value = model.MB122;
            parameters[121].Value = model.MB123;
            parameters[122].Value = model.MB124;
            parameters[123].Value = model.MB125;
            parameters[124].Value = model.MB126;
            parameters[125].Value = model.MB127;
            parameters[126].Value = model.MB128;
            parameters[127].Value = model.MB129;
            parameters[128].Value = model.MB130;
            parameters[129].Value = model.MB131;
            parameters[130].Value = model.MB132;
            parameters[131].Value = model.MB133;
            parameters[132].Value = model.MB134;
            parameters[133].Value = model.MB135;
            parameters[134].Value = model.MB136;
            parameters[135].Value = model.MB137;
            parameters[136].Value = model.MB138;
            parameters[137].Value = model.MB139;
            parameters[138].Value = model.MB140;
            parameters[139].Value = model.MB141;
            parameters[140].Value = model.MB142;
            parameters[141].Value = model.MB143;
            parameters[142].Value = model.MB144;
            parameters[143].Value = model.MB145;
            parameters[144].Value = model.MB146;
            parameters[145].Value = model.MB147;
            parameters[146].Value = model.MB148;
            parameters[147].Value = model.MB149;
            parameters[148].Value = model.MB150;
            parameters[149].Value = model.MB151;
            parameters[150].Value = model.MB152;
            parameters[151].Value = model.MB179;
            parameters[152].Value = model.MB180;
            parameters[153].Value = model.MB181;
            parameters[154].Value = model.MB182;
            parameters[155].Value = model.MB183;
            parameters[156].Value = model.MB184;
            parameters[157].Value = model.MB185;
            parameters[158].Value = model.MB186;
            parameters[159].Value = model.MB187;
            parameters[160].Value = model.MB188;
            parameters[161].Value = model.MB189;
            parameters[162].Value = model.MB190;
            parameters[163].Value = model.MB191;
            parameters[164].Value = model.MB192;
            parameters[165].Value = model.MB193;
            parameters[166].Value = model.MB194;
            parameters[167].Value = model.MB195;
            parameters[168].Value = model.MB196;
            parameters[169].Value = model.MB197;
            parameters[170].Value = model.MB198;
            parameters[171].Value = model.MB199;
            parameters[172].Value = model.MB401;
            parameters[173].Value = model.MB402;
            parameters[174].Value = model.MB403;
            parameters[175].Value = model.MB404;
            parameters[176].Value = model.MB405;
            parameters[177].Value = model.MB406;
            parameters[178].Value = model.MB407;
            parameters[179].Value = model.MB408;
            parameters[180].Value = model.MB409;
            parameters[181].Value = model.MB410;
            parameters[182].Value = model.MB411;
            parameters[183].Value = model.MB412;
            parameters[184].Value = model.MB413;
            parameters[185].Value = model.MB414;
            parameters[186].Value = model.MB415;
            parameters[187].Value = model.MB416;
            parameters[188].Value = model.MB417;
            parameters[189].Value = model.MB418;
            parameters[190].Value = model.MB419;
            parameters[191].Value = model.MB420;
            parameters[192].Value = model.MB421;
            parameters[193].Value = model.MB422;
            parameters[194].Value = model.MB423;
            parameters[195].Value = model.MB424;
            parameters[196].Value = model.MB425;
            parameters[197].Value = model.MB426;
            parameters[198].Value = model.MB427;
            parameters[199].Value = model.MB428;
            parameters[200].Value = model.MB429;
            parameters[201].Value = model.MB430;
            parameters[202].Value = model.MB431;
            parameters[203].Value = model.MB432;
            parameters[204].Value = model.MB433;
            parameters[205].Value = model.MB434;
            parameters[206].Value = model.MB435;
            parameters[207].Value = model.MB436;
            parameters[208].Value = model.MB437;
            parameters[209].Value = model.MB438;
            parameters[210].Value = model.MB439;
            parameters[211].Value = model.MB440;
            parameters[212].Value = model.MB441;
            parameters[213].Value = model.MB442;
            parameters[214].Value = model.MB443;
            parameters[215].Value = model.MB444;
            parameters[216].Value = model.MB445;
            parameters[217].Value = model.MB446;
            parameters[218].Value = model.MB447;
            parameters[219].Value = model.MB448;
            parameters[220].Value = model.MB449;
            parameters[221].Value = model.MB450;
            parameters[222].Value = model.MB451;
            parameters[223].Value = model.MB452;
            parameters[224].Value = model.MBD01;
            parameters[225].Value = model.MBD02;
            parameters[226].Value = model.MBE01;
            parameters[227].Value = model.MB453;
            parameters[228].Value = model.MB454;
            parameters[229].Value = model.MBH01;
            parameters[230].Value = model.MBH02;
            parameters[231].Value = model.MBH03;
            parameters[232].Value = model.MB455;
            parameters[233].Value = model.MB456;
            parameters[234].Value = model.MB457;
            parameters[235].Value = model.MB458;
            parameters[236].Value = model.MB459;
            parameters[237].Value = model.MB460;
            parameters[238].Value = model.MB461;
            parameters[239].Value = model.MB462;
            parameters[240].Value = model.MB463;
            parameters[241].Value = model.MB464;
            parameters[242].Value = model.MB465;
            parameters[243].Value = model.MB466;
            parameters[244].Value = model.MB467;
            parameters[245].Value = model.MB468;
            parameters[246].Value = model.MB469;
            parameters[247].Value = model.MB470;
            parameters[248].Value = model.MB471;
            parameters[249].Value = model.MB472;
            parameters[250].Value = model.MB473;
            parameters[251].Value = model.MB474;
            parameters[252].Value = model.MB475;
            parameters[253].Value = model.MBL01;
            parameters[254].Value = model.MBL02;
            parameters[255].Value = model.MBL03;
            parameters[256].Value = model.MBL04;
            parameters[257].Value = model.MB476;
            parameters[258].Value = model.MB477;
            parameters[259].Value = model.MB478;
            parameters[260].Value = model.MB479;
            parameters[261].Value = model.MB480;
            parameters[262].Value = model.UDF01;
            parameters[263].Value = model.UDF02;
            parameters[264].Value = model.UDF03;
            parameters[265].Value = model.UDF04;
            parameters[266].Value = model.UDF05;
            parameters[267].Value = model.UDF06;
            parameters[268].Value = model.UDF51;
            parameters[269].Value = model.UDF52;
            parameters[270].Value = model.UDF53;
            parameters[271].Value = model.UDF54;
            parameters[272].Value = model.UDF55;
            parameters[273].Value = model.UDF56;
            parameters[274].Value = model.UDF07;
            parameters[275].Value = model.UDF08;
            parameters[276].Value = model.UDF09;
            parameters[277].Value = model.UDF10;
            parameters[278].Value = model.UDF11;
            parameters[279].Value = model.UDF12;
            parameters[280].Value = model.UDF57;
            parameters[281].Value = model.UDF58;
            parameters[282].Value = model.UDF59;
            parameters[283].Value = model.UDF60;
            parameters[284].Value = model.UDF61;
            parameters[285].Value = model.UDF62;
            parameters[286].Value = model.MB001;
            parameters[287].Value = model.MB002;
            parameters[288].Value = model.MB025;
            parameters[289].Value = model.MB026;
            parameters[290].Value = model.MB110;

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
        public bool Delete(string MB001)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from INVMB ");
            strSql.Append(" where MB001=@MB001 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@MB001", SqlDbType.Char,20)           };
            parameters[0].Value = MB001;

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
        public bool DeleteList(string MB001list)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from INVMB ");
            strSql.Append(" where MB001 in (" + MB001list + ")  ");
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
        public YJUI.Model.INVMB GetModel(string MB001)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,MB001,MB002,MB003,MB004,MB005,MB006,MB007,MB008,MB009,MB010,MB011,MB012,MB013,MB014,MB015,MB016,MB017,MB018,MB019,MB020,MB021,MB022,MB023,MB024,MB025,MB026,MB027,MB028,MB029,MB030,MB031,MB032,MB033,MB034,MB035,MB036,MB037,MB038,MB039,MB040,MB041,MB042,MB043,MB044,MB045,MB046,MB047,MB048,MB049,MB050,MB051,MB052,MB053,MB054,MB055,MB056,MB057,MB058,MB059,MB060,MB061,MB062,MB063,MB064,MB065,MB066,MB067,MB068,MB069,MB070,MB071,MB072,MB073,MB074,MB075,MB076,MB077,MB078,MB079,MB080,MB081,MB082,MB083,MB084,MB085,MB086,MB087,MB088,MB089,MB090,MB091,MB092,MB093,MB094,MB095,MB096,MB100,MB101,MB102,MB103,MB104,MB105,MB106,MB107,MB108,MB109,MB110,MB111,MB112,MB113,MB114,MB115,MB116,MB117,MB118,MB119,MB120,MB121,MB122,MB123,MB124,MB125,MB126,MB127,MB128,MB129,MB130,MB131,MB132,MB133,MB134,MB135,MB136,MB137,MB138,MB139,MB140,MB141,MB142,MB143,MB144,MB145,MB146,MB147,MB148,MB149,MB150,MB151,MB152,MB179,MB180,MB181,MB182,MB183,MB184,MB185,MB186,MB187,MB188,MB189,MB190,MB191,MB192,MB193,MB194,MB195,MB196,MB197,MB198,MB199,MB401,MB402,MB403,MB404,MB405,MB406,MB407,MB408,MB409,MB410,MB411,MB412,MB413,MB414,MB415,MB416,MB417,MB418,MB419,MB420,MB421,MB422,MB423,MB424,MB425,MB426,MB427,MB428,MB429,MB430,MB431,MB432,MB433,MB434,MB435,MB436,MB437,MB438,MB439,MB440,MB441,MB442,MB443,MB444,MB445,MB446,MB447,MB448,MB449,MB450,MB451,MB452,MBD01,MBD02,MBE01,MB453,MB454,MBH01,MBH02,MBH03,MB455,MB456,MB457,MB458,MB459,MB460,MB461,MB462,MB463,MB464,MB465,MB466,MB467,MB468,MB469,MB470,MB471,MB472,MB473,MB474,MB475,MBL01,MBL02,MBL03,MBL04,MB476,MB477,MB478,MB479,MB480,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62 from INVMB ");
            strSql.Append(" where MB001=@MB001 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@MB001", SqlDbType.Char,20)           };
            parameters[0].Value = MB001;

            YJUI.Model.INVMB model = new YJUI.Model.INVMB();
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
        public YJUI.Model.INVMB DataRowToModel(DataRow row)
        {
            YJUI.Model.INVMB model = new YJUI.Model.INVMB();
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
                if (row["MB001"] != null)
                {
                    model.MB001 = row["MB001"].ToString();
                }
                if (row["MB002"] != null)
                {
                    model.MB002 = row["MB002"].ToString();
                }
                if (row["MB003"] != null)
                {
                    model.MB003 = row["MB003"].ToString();
                }
                if (row["MB004"] != null)
                {
                    model.MB004 = row["MB004"].ToString();
                }
                if (row["MB005"] != null)
                {
                    model.MB005 = row["MB005"].ToString();
                }
                if (row["MB006"] != null)
                {
                    model.MB006 = row["MB006"].ToString();
                }
                if (row["MB007"] != null)
                {
                    model.MB007 = row["MB007"].ToString();
                }
                if (row["MB008"] != null)
                {
                    model.MB008 = row["MB008"].ToString();
                }
                if (row["MB009"] != null)
                {
                    model.MB009 = row["MB009"].ToString();
                }
                if (row["MB010"] != null)
                {
                    model.MB010 = row["MB010"].ToString();
                }
                if (row["MB011"] != null)
                {
                    model.MB011 = row["MB011"].ToString();
                }
                if (row["MB012"] != null)
                {
                    model.MB012 = row["MB012"].ToString();
                }
                if (row["MB013"] != null)
                {
                    model.MB013 = row["MB013"].ToString();
                }
                if (row["MB014"] != null && row["MB014"].ToString() != "")
                {
                    model.MB014 = decimal.Parse(row["MB014"].ToString());
                }
                if (row["MB015"] != null)
                {
                    model.MB015 = row["MB015"].ToString();
                }
                if (row["MB016"] != null)
                {
                    model.MB016 = row["MB016"].ToString();
                }
                if (row["MB017"] != null)
                {
                    model.MB017 = row["MB017"].ToString();
                }
                if (row["MB018"] != null)
                {
                    model.MB018 = row["MB018"].ToString();
                }
                if (row["MB019"] != null)
                {
                    model.MB019 = row["MB019"].ToString();
                }
                if (row["MB020"] != null)
                {
                    model.MB020 = row["MB020"].ToString();
                }
                if (row["MB021"] != null)
                {
                    model.MB021 = row["MB021"].ToString();
                }
                if (row["MB022"] != null)
                {
                    model.MB022 = row["MB022"].ToString();
                }
                if (row["MB023"] != null && row["MB023"].ToString() != "")
                {
                    model.MB023 = decimal.Parse(row["MB023"].ToString());
                }
                if (row["MB024"] != null && row["MB024"].ToString() != "")
                {
                    model.MB024 = decimal.Parse(row["MB024"].ToString());
                }
                if (row["MB025"] != null)
                {
                    model.MB025 = row["MB025"].ToString();
                }
                if (row["MB026"] != null)
                {
                    model.MB026 = row["MB026"].ToString();
                }
                if (row["MB027"] != null)
                {
                    model.MB027 = row["MB027"].ToString();
                }
                if (row["MB028"] != null)
                {
                    model.MB028 = row["MB028"].ToString();
                }
                if (row["MB029"] != null)
                {
                    model.MB029 = row["MB029"].ToString();
                }
                if (row["MB030"] != null)
                {
                    model.MB030 = row["MB030"].ToString();
                }
                if (row["MB031"] != null)
                {
                    model.MB031 = row["MB031"].ToString();
                }
                if (row["MB032"] != null)
                {
                    model.MB032 = row["MB032"].ToString();
                }
                if (row["MB033"] != null)
                {
                    model.MB033 = row["MB033"].ToString();
                }
                if (row["MB034"] != null)
                {
                    model.MB034 = row["MB034"].ToString();
                }
                if (row["MB035"] != null)
                {
                    model.MB035 = row["MB035"].ToString();
                }
                if (row["MB036"] != null && row["MB036"].ToString() != "")
                {
                    model.MB036 = decimal.Parse(row["MB036"].ToString());
                }
                if (row["MB037"] != null && row["MB037"].ToString() != "")
                {
                    model.MB037 = decimal.Parse(row["MB037"].ToString());
                }
                if (row["MB038"] != null && row["MB038"].ToString() != "")
                {
                    model.MB038 = decimal.Parse(row["MB038"].ToString());
                }
                if (row["MB039"] != null && row["MB039"].ToString() != "")
                {
                    model.MB039 = decimal.Parse(row["MB039"].ToString());
                }
                if (row["MB040"] != null && row["MB040"].ToString() != "")
                {
                    model.MB040 = decimal.Parse(row["MB040"].ToString());
                }
                if (row["MB041"] != null && row["MB041"].ToString() != "")
                {
                    model.MB041 = decimal.Parse(row["MB041"].ToString());
                }
                if (row["MB042"] != null)
                {
                    model.MB042 = row["MB042"].ToString();
                }
                if (row["MB043"] != null)
                {
                    model.MB043 = row["MB043"].ToString();
                }
                if (row["MB044"] != null)
                {
                    model.MB044 = row["MB044"].ToString();
                }
                if (row["MB045"] != null && row["MB045"].ToString() != "")
                {
                    model.MB045 = decimal.Parse(row["MB045"].ToString());
                }
                if (row["MB046"] != null && row["MB046"].ToString() != "")
                {
                    model.MB046 = decimal.Parse(row["MB046"].ToString());
                }
                if (row["MB047"] != null && row["MB047"].ToString() != "")
                {
                    model.MB047 = decimal.Parse(row["MB047"].ToString());
                }
                if (row["MB048"] != null)
                {
                    model.MB048 = row["MB048"].ToString();
                }
                if (row["MB049"] != null && row["MB049"].ToString() != "")
                {
                    model.MB049 = decimal.Parse(row["MB049"].ToString());
                }
                if (row["MB050"] != null && row["MB050"].ToString() != "")
                {
                    model.MB050 = decimal.Parse(row["MB050"].ToString());
                }
                if (row["MB051"] != null && row["MB051"].ToString() != "")
                {
                    model.MB051 = decimal.Parse(row["MB051"].ToString());
                }
                if (row["MB052"] != null)
                {
                    model.MB052 = row["MB052"].ToString();
                }
                if (row["MB053"] != null && row["MB053"].ToString() != "")
                {
                    model.MB053 = decimal.Parse(row["MB053"].ToString());
                }
                if (row["MB054"] != null && row["MB054"].ToString() != "")
                {
                    model.MB054 = decimal.Parse(row["MB054"].ToString());
                }
                if (row["MB055"] != null && row["MB055"].ToString() != "")
                {
                    model.MB055 = decimal.Parse(row["MB055"].ToString());
                }
                if (row["MB056"] != null && row["MB056"].ToString() != "")
                {
                    model.MB056 = decimal.Parse(row["MB056"].ToString());
                }
                if (row["MB057"] != null && row["MB057"].ToString() != "")
                {
                    model.MB057 = decimal.Parse(row["MB057"].ToString());
                }
                if (row["MB058"] != null && row["MB058"].ToString() != "")
                {
                    model.MB058 = decimal.Parse(row["MB058"].ToString());
                }
                if (row["MB059"] != null && row["MB059"].ToString() != "")
                {
                    model.MB059 = decimal.Parse(row["MB059"].ToString());
                }
                if (row["MB060"] != null && row["MB060"].ToString() != "")
                {
                    model.MB060 = decimal.Parse(row["MB060"].ToString());
                }
                if (row["MB061"] != null && row["MB061"].ToString() != "")
                {
                    model.MB061 = decimal.Parse(row["MB061"].ToString());
                }
                if (row["MB062"] != null && row["MB062"].ToString() != "")
                {
                    model.MB062 = decimal.Parse(row["MB062"].ToString());
                }
                if (row["MB063"] != null && row["MB063"].ToString() != "")
                {
                    model.MB063 = decimal.Parse(row["MB063"].ToString());
                }
                if (row["MB064"] != null && row["MB064"].ToString() != "")
                {
                    model.MB064 = decimal.Parse(row["MB064"].ToString());
                }
                if (row["MB065"] != null && row["MB065"].ToString() != "")
                {
                    model.MB065 = decimal.Parse(row["MB065"].ToString());
                }
                if (row["MB066"] != null)
                {
                    model.MB066 = row["MB066"].ToString();
                }
                if (row["MB067"] != null)
                {
                    model.MB067 = row["MB067"].ToString();
                }
                if (row["MB068"] != null)
                {
                    model.MB068 = row["MB068"].ToString();
                }
                if (row["MB069"] != null && row["MB069"].ToString() != "")
                {
                    model.MB069 = decimal.Parse(row["MB069"].ToString());
                }
                if (row["MB070"] != null && row["MB070"].ToString() != "")
                {
                    model.MB070 = decimal.Parse(row["MB070"].ToString());
                }
                if (row["MB071"] != null && row["MB071"].ToString() != "")
                {
                    model.MB071 = decimal.Parse(row["MB071"].ToString());
                }
                if (row["MB072"] != null)
                {
                    model.MB072 = row["MB072"].ToString();
                }
                if (row["MB073"] != null && row["MB073"].ToString() != "")
                {
                    model.MB073 = decimal.Parse(row["MB073"].ToString());
                }
                if (row["MB074"] != null && row["MB074"].ToString() != "")
                {
                    model.MB074 = decimal.Parse(row["MB074"].ToString());
                }
                if (row["MB075"] != null && row["MB075"].ToString() != "")
                {
                    model.MB075 = decimal.Parse(row["MB075"].ToString());
                }
                if (row["MB076"] != null && row["MB076"].ToString() != "")
                {
                    model.MB076 = decimal.Parse(row["MB076"].ToString());
                }
                if (row["MB077"] != null)
                {
                    model.MB077 = row["MB077"].ToString();
                }
                if (row["MB078"] != null && row["MB078"].ToString() != "")
                {
                    model.MB078 = decimal.Parse(row["MB078"].ToString());
                }
                if (row["MB079"] != null && row["MB079"].ToString() != "")
                {
                    model.MB079 = decimal.Parse(row["MB079"].ToString());
                }
                if (row["MB080"] != null)
                {
                    model.MB080 = row["MB080"].ToString();
                }
                if (row["MB081"] != null)
                {
                    model.MB081 = row["MB081"].ToString();
                }
                if (row["MB082"] != null && row["MB082"].ToString() != "")
                {
                    model.MB082 = decimal.Parse(row["MB082"].ToString());
                }
                if (row["MB083"] != null)
                {
                    model.MB083 = row["MB083"].ToString();
                }
                if (row["MB084"] != null && row["MB084"].ToString() != "")
                {
                    model.MB084 = decimal.Parse(row["MB084"].ToString());
                }
                if (row["MB085"] != null)
                {
                    model.MB085 = row["MB085"].ToString();
                }
                if (row["MB086"] != null && row["MB086"].ToString() != "")
                {
                    model.MB086 = decimal.Parse(row["MB086"].ToString());
                }
                if (row["MB087"] != null)
                {
                    model.MB087 = row["MB087"].ToString();
                }
                if (row["MB088"] != null && row["MB088"].ToString() != "")
                {
                    model.MB088 = decimal.Parse(row["MB088"].ToString());
                }
                if (row["MB089"] != null && row["MB089"].ToString() != "")
                {
                    model.MB089 = decimal.Parse(row["MB089"].ToString());
                }
                if (row["MB090"] != null)
                {
                    model.MB090 = row["MB090"].ToString();
                }
                if (row["MB091"] != null)
                {
                    model.MB091 = row["MB091"].ToString();
                }
                if (row["MB092"] != null)
                {
                    model.MB092 = row["MB092"].ToString();
                }
                if (row["MB093"] != null && row["MB093"].ToString() != "")
                {
                    model.MB093 = decimal.Parse(row["MB093"].ToString());
                }
                if (row["MB094"] != null && row["MB094"].ToString() != "")
                {
                    model.MB094 = decimal.Parse(row["MB094"].ToString());
                }
                if (row["MB095"] != null && row["MB095"].ToString() != "")
                {
                    model.MB095 = decimal.Parse(row["MB095"].ToString());
                }
                if (row["MB096"] != null && row["MB096"].ToString() != "")
                {
                    model.MB096 = decimal.Parse(row["MB096"].ToString());
                }
                if (row["MB100"] != null)
                {
                    model.MB100 = row["MB100"].ToString();
                }
                if (row["MB101"] != null)
                {
                    model.MB101 = row["MB101"].ToString();
                }
                if (row["MB102"] != null)
                {
                    model.MB102 = row["MB102"].ToString();
                }
                if (row["MB103"] != null)
                {
                    model.MB103 = row["MB103"].ToString();
                }
                if (row["MB104"] != null)
                {
                    model.MB104 = row["MB104"].ToString();
                }
                if (row["MB105"] != null)
                {
                    model.MB105 = row["MB105"].ToString();
                }
                if (row["MB106"] != null)
                {
                    model.MB106 = row["MB106"].ToString();
                }
                if (row["MB107"] != null)
                {
                    model.MB107 = row["MB107"].ToString();
                }
                if (row["MB108"] != null)
                {
                    model.MB108 = row["MB108"].ToString();
                }
                if (row["MB109"] != null)
                {
                    model.MB109 = row["MB109"].ToString();
                }
                if (row["MB110"] != null)
                {
                    model.MB110 = row["MB110"].ToString();
                }
                if (row["MB111"] != null && row["MB111"].ToString() != "")
                {
                    model.MB111 = decimal.Parse(row["MB111"].ToString());
                }
                if (row["MB112"] != null)
                {
                    model.MB112 = row["MB112"].ToString();
                }
                if (row["MB113"] != null)
                {
                    model.MB113 = row["MB113"].ToString();
                }
                if (row["MB114"] != null)
                {
                    model.MB114 = row["MB114"].ToString();
                }
                if (row["MB115"] != null)
                {
                    model.MB115 = row["MB115"].ToString();
                }
                if (row["MB116"] != null)
                {
                    model.MB116 = row["MB116"].ToString();
                }
                if (row["MB117"] != null)
                {
                    model.MB117 = row["MB117"].ToString();
                }
                if (row["MB118"] != null)
                {
                    model.MB118 = row["MB118"].ToString();
                }
                if (row["MB119"] != null)
                {
                    model.MB119 = row["MB119"].ToString();
                }
                if (row["MB120"] != null)
                {
                    model.MB120 = row["MB120"].ToString();
                }
                if (row["MB121"] != null)
                {
                    model.MB121 = row["MB121"].ToString();
                }
                if (row["MB122"] != null)
                {
                    model.MB122 = row["MB122"].ToString();
                }
                if (row["MB123"] != null)
                {
                    model.MB123 = row["MB123"].ToString();
                }
                if (row["MB124"] != null)
                {
                    model.MB124 = row["MB124"].ToString();
                }
                if (row["MB125"] != null)
                {
                    model.MB125 = row["MB125"].ToString();
                }
                if (row["MB126"] != null)
                {
                    model.MB126 = row["MB126"].ToString();
                }
                if (row["MB127"] != null)
                {
                    model.MB127 = row["MB127"].ToString();
                }
                if (row["MB128"] != null)
                {
                    model.MB128 = row["MB128"].ToString();
                }
                if (row["MB129"] != null)
                {
                    model.MB129 = row["MB129"].ToString();
                }
                if (row["MB130"] != null)
                {
                    model.MB130 = row["MB130"].ToString();
                }
                if (row["MB131"] != null)
                {
                    model.MB131 = row["MB131"].ToString();
                }
                if (row["MB132"] != null)
                {
                    model.MB132 = row["MB132"].ToString();
                }
                if (row["MB133"] != null)
                {
                    model.MB133 = row["MB133"].ToString();
                }
                if (row["MB134"] != null)
                {
                    model.MB134 = row["MB134"].ToString();
                }
                if (row["MB135"] != null)
                {
                    model.MB135 = row["MB135"].ToString();
                }
                if (row["MB136"] != null)
                {
                    model.MB136 = row["MB136"].ToString();
                }
                if (row["MB137"] != null)
                {
                    model.MB137 = row["MB137"].ToString();
                }
                if (row["MB138"] != null)
                {
                    model.MB138 = row["MB138"].ToString();
                }
                if (row["MB139"] != null)
                {
                    model.MB139 = row["MB139"].ToString();
                }
                if (row["MB140"] != null)
                {
                    model.MB140 = row["MB140"].ToString();
                }
                if (row["MB141"] != null)
                {
                    model.MB141 = row["MB141"].ToString();
                }
                if (row["MB142"] != null)
                {
                    model.MB142 = row["MB142"].ToString();
                }
                if (row["MB143"] != null)
                {
                    model.MB143 = row["MB143"].ToString();
                }
                if (row["MB144"] != null)
                {
                    model.MB144 = row["MB144"].ToString();
                }
                if (row["MB145"] != null)
                {
                    model.MB145 = row["MB145"].ToString();
                }
                if (row["MB146"] != null)
                {
                    model.MB146 = row["MB146"].ToString();
                }
                if (row["MB147"] != null && row["MB147"].ToString() != "")
                {
                    model.MB147 = decimal.Parse(row["MB147"].ToString());
                }
                if (row["MB148"] != null)
                {
                    model.MB148 = row["MB148"].ToString();
                }
                if (row["MB149"] != null)
                {
                    model.MB149 = row["MB149"].ToString();
                }
                if (row["MB150"] != null)
                {
                    model.MB150 = row["MB150"].ToString();
                }
                if (row["MB151"] != null && row["MB151"].ToString() != "")
                {
                    model.MB151 = decimal.Parse(row["MB151"].ToString());
                }
                if (row["MB152"] != null && row["MB152"].ToString() != "")
                {
                    model.MB152 = decimal.Parse(row["MB152"].ToString());
                }
                if (row["MB179"] != null)
                {
                    model.MB179 = row["MB179"].ToString();
                }
                if (row["MB180"] != null)
                {
                    model.MB180 = row["MB180"].ToString();
                }
                if (row["MB181"] != null)
                {
                    model.MB181 = row["MB181"].ToString();
                }
                if (row["MB182"] != null)
                {
                    model.MB182 = row["MB182"].ToString();
                }
                if (row["MB183"] != null)
                {
                    model.MB183 = row["MB183"].ToString();
                }
                if (row["MB184"] != null)
                {
                    model.MB184 = row["MB184"].ToString();
                }
                if (row["MB185"] != null)
                {
                    model.MB185 = row["MB185"].ToString();
                }
                if (row["MB186"] != null)
                {
                    model.MB186 = row["MB186"].ToString();
                }
                if (row["MB187"] != null)
                {
                    model.MB187 = row["MB187"].ToString();
                }
                if (row["MB188"] != null)
                {
                    model.MB188 = row["MB188"].ToString();
                }
                if (row["MB189"] != null)
                {
                    model.MB189 = row["MB189"].ToString();
                }
                if (row["MB190"] != null)
                {
                    model.MB190 = row["MB190"].ToString();
                }
                if (row["MB191"] != null)
                {
                    model.MB191 = row["MB191"].ToString();
                }
                if (row["MB192"] != null)
                {
                    model.MB192 = row["MB192"].ToString();
                }
                if (row["MB193"] != null)
                {
                    model.MB193 = row["MB193"].ToString();
                }
                if (row["MB194"] != null)
                {
                    model.MB194 = row["MB194"].ToString();
                }
                if (row["MB195"] != null)
                {
                    model.MB195 = row["MB195"].ToString();
                }
                if (row["MB196"] != null)
                {
                    model.MB196 = row["MB196"].ToString();
                }
                if (row["MB197"] != null)
                {
                    model.MB197 = row["MB197"].ToString();
                }
                if (row["MB198"] != null)
                {
                    model.MB198 = row["MB198"].ToString();
                }
                if (row["MB199"] != null)
                {
                    model.MB199 = row["MB199"].ToString();
                }
                if (row["MB401"] != null && row["MB401"].ToString() != "")
                {
                    model.MB401 = decimal.Parse(row["MB401"].ToString());
                }
                if (row["MB402"] != null && row["MB402"].ToString() != "")
                {
                    model.MB402 = decimal.Parse(row["MB402"].ToString());
                }
                if (row["MB403"] != null && row["MB403"].ToString() != "")
                {
                    model.MB403 = decimal.Parse(row["MB403"].ToString());
                }
                if (row["MB404"] != null && row["MB404"].ToString() != "")
                {
                    model.MB404 = decimal.Parse(row["MB404"].ToString());
                }
                if (row["MB405"] != null)
                {
                    model.MB405 = row["MB405"].ToString();
                }
                if (row["MB406"] != null)
                {
                    model.MB406 = row["MB406"].ToString();
                }
                if (row["MB407"] != null)
                {
                    model.MB407 = row["MB407"].ToString();
                }
                if (row["MB408"] != null)
                {
                    model.MB408 = row["MB408"].ToString();
                }
                if (row["MB409"] != null)
                {
                    model.MB409 = row["MB409"].ToString();
                }
                if (row["MB410"] != null && row["MB410"].ToString() != "")
                {
                    model.MB410 = decimal.Parse(row["MB410"].ToString());
                }
                if (row["MB411"] != null)
                {
                    model.MB411 = row["MB411"].ToString();
                }
                if (row["MB412"] != null)
                {
                    model.MB412 = row["MB412"].ToString();
                }
                if (row["MB413"] != null)
                {
                    model.MB413 = row["MB413"].ToString();
                }
                if (row["MB414"] != null)
                {
                    model.MB414 = row["MB414"].ToString();
                }
                if (row["MB415"] != null && row["MB415"].ToString() != "")
                {
                    model.MB415 = decimal.Parse(row["MB415"].ToString());
                }
                if (row["MB416"] != null && row["MB416"].ToString() != "")
                {
                    model.MB416 = decimal.Parse(row["MB416"].ToString());
                }
                if (row["MB417"] != null && row["MB417"].ToString() != "")
                {
                    model.MB417 = decimal.Parse(row["MB417"].ToString());
                }
                if (row["MB418"] != null && row["MB418"].ToString() != "")
                {
                    model.MB418 = decimal.Parse(row["MB418"].ToString());
                }
                if (row["MB419"] != null && row["MB419"].ToString() != "")
                {
                    model.MB419 = decimal.Parse(row["MB419"].ToString());
                }
                if (row["MB420"] != null && row["MB420"].ToString() != "")
                {
                    model.MB420 = decimal.Parse(row["MB420"].ToString());
                }
                if (row["MB421"] != null)
                {
                    model.MB421 = row["MB421"].ToString();
                }
                if (row["MB422"] != null)
                {
                    model.MB422 = row["MB422"].ToString();
                }
                if (row["MB423"] != null)
                {
                    model.MB423 = row["MB423"].ToString();
                }
                if (row["MB424"] != null)
                {
                    model.MB424 = row["MB424"].ToString();
                }
                if (row["MB425"] != null && row["MB425"].ToString() != "")
                {
                    model.MB425 = decimal.Parse(row["MB425"].ToString());
                }
                if (row["MB426"] != null && row["MB426"].ToString() != "")
                {
                    model.MB426 = decimal.Parse(row["MB426"].ToString());
                }
                if (row["MB427"] != null && row["MB427"].ToString() != "")
                {
                    model.MB427 = decimal.Parse(row["MB427"].ToString());
                }
                if (row["MB428"] != null && row["MB428"].ToString() != "")
                {
                    model.MB428 = decimal.Parse(row["MB428"].ToString());
                }
                if (row["MB429"] != null && row["MB429"].ToString() != "")
                {
                    model.MB429 = decimal.Parse(row["MB429"].ToString());
                }
                if (row["MB430"] != null && row["MB430"].ToString() != "")
                {
                    model.MB430 = decimal.Parse(row["MB430"].ToString());
                }
                if (row["MB431"] != null && row["MB431"].ToString() != "")
                {
                    model.MB431 = decimal.Parse(row["MB431"].ToString());
                }
                if (row["MB432"] != null && row["MB432"].ToString() != "")
                {
                    model.MB432 = decimal.Parse(row["MB432"].ToString());
                }
                if (row["MB433"] != null && row["MB433"].ToString() != "")
                {
                    model.MB433 = decimal.Parse(row["MB433"].ToString());
                }
                if (row["MB434"] != null && row["MB434"].ToString() != "")
                {
                    model.MB434 = decimal.Parse(row["MB434"].ToString());
                }
                if (row["MB435"] != null)
                {
                    model.MB435 = row["MB435"].ToString();
                }
                if (row["MB436"] != null)
                {
                    model.MB436 = row["MB436"].ToString();
                }
                if (row["MB437"] != null)
                {
                    model.MB437 = row["MB437"].ToString();
                }
                if (row["MB438"] != null && row["MB438"].ToString() != "")
                {
                    model.MB438 = decimal.Parse(row["MB438"].ToString());
                }
                if (row["MB439"] != null && row["MB439"].ToString() != "")
                {
                    model.MB439 = decimal.Parse(row["MB439"].ToString());
                }
                if (row["MB440"] != null && row["MB440"].ToString() != "")
                {
                    model.MB440 = decimal.Parse(row["MB440"].ToString());
                }
                if (row["MB441"] != null)
                {
                    model.MB441 = row["MB441"].ToString();
                }
                if (row["MB442"] != null)
                {
                    model.MB442 = row["MB442"].ToString();
                }
                if (row["MB443"] != null)
                {
                    model.MB443 = row["MB443"].ToString();
                }
                if (row["MB444"] != null)
                {
                    model.MB444 = row["MB444"].ToString();
                }
                if (row["MB445"] != null)
                {
                    model.MB445 = row["MB445"].ToString();
                }
                if (row["MB446"] != null && row["MB446"].ToString() != "")
                {
                    model.MB446 = decimal.Parse(row["MB446"].ToString());
                }
                if (row["MB447"] != null && row["MB447"].ToString() != "")
                {
                    model.MB447 = decimal.Parse(row["MB447"].ToString());
                }
                if (row["MB448"] != null && row["MB448"].ToString() != "")
                {
                    model.MB448 = decimal.Parse(row["MB448"].ToString());
                }
                if (row["MB449"] != null && row["MB449"].ToString() != "")
                {
                    model.MB449 = decimal.Parse(row["MB449"].ToString());
                }
                if (row["MB450"] != null)
                {
                    model.MB450 = row["MB450"].ToString();
                }
                if (row["MB451"] != null)
                {
                    model.MB451 = row["MB451"].ToString();
                }
                if (row["MB452"] != null && row["MB452"].ToString() != "")
                {
                    model.MB452 = decimal.Parse(row["MB452"].ToString());
                }
                if (row["MBD01"] != null)
                {
                    model.MBD01 = row["MBD01"].ToString();
                }
                if (row["MBD02"] != null)
                {
                    model.MBD02 = row["MBD02"].ToString();
                }
                if (row["MBE01"] != null)
                {
                    model.MBE01 = row["MBE01"].ToString();
                }
                if (row["MB453"] != null)
                {
                    model.MB453 = row["MB453"].ToString();
                }
                if (row["MB454"] != null)
                {
                    model.MB454 = row["MB454"].ToString();
                }
                if (row["MBH01"] != null)
                {
                    model.MBH01 = row["MBH01"].ToString();
                }
                if (row["MBH02"] != null)
                {
                    model.MBH02 = row["MBH02"].ToString();
                }
                if (row["MBH03"] != null)
                {
                    model.MBH03 = row["MBH03"].ToString();
                }
                if (row["MB455"] != null)
                {
                    model.MB455 = row["MB455"].ToString();
                }
                if (row["MB456"] != null)
                {
                    model.MB456 = row["MB456"].ToString();
                }
                if (row["MB457"] != null)
                {
                    model.MB457 = row["MB457"].ToString();
                }
                if (row["MB458"] != null)
                {
                    model.MB458 = row["MB458"].ToString();
                }
                if (row["MB459"] != null)
                {
                    model.MB459 = row["MB459"].ToString();
                }
                if (row["MB460"] != null)
                {
                    model.MB460 = row["MB460"].ToString();
                }
                if (row["MB461"] != null)
                {
                    model.MB461 = row["MB461"].ToString();
                }
                if (row["MB462"] != null)
                {
                    model.MB462 = row["MB462"].ToString();
                }
                if (row["MB463"] != null)
                {
                    model.MB463 = row["MB463"].ToString();
                }
                if (row["MB464"] != null)
                {
                    model.MB464 = row["MB464"].ToString();
                }
                if (row["MB465"] != null)
                {
                    model.MB465 = row["MB465"].ToString();
                }
                if (row["MB466"] != null)
                {
                    model.MB466 = row["MB466"].ToString();
                }
                if (row["MB467"] != null)
                {
                    model.MB467 = row["MB467"].ToString();
                }
                if (row["MB468"] != null)
                {
                    model.MB468 = row["MB468"].ToString();
                }
                if (row["MB469"] != null)
                {
                    model.MB469 = row["MB469"].ToString();
                }
                if (row["MB470"] != null)
                {
                    model.MB470 = row["MB470"].ToString();
                }
                if (row["MB471"] != null)
                {
                    model.MB471 = row["MB471"].ToString();
                }
                if (row["MB472"] != null)
                {
                    model.MB472 = row["MB472"].ToString();
                }
                if (row["MB473"] != null)
                {
                    model.MB473 = row["MB473"].ToString();
                }
                if (row["MB474"] != null)
                {
                    model.MB474 = row["MB474"].ToString();
                }
                if (row["MB475"] != null)
                {
                    model.MB475 = row["MB475"].ToString();
                }
                if (row["MBL01"] != null && row["MBL01"].ToString() != "")
                {
                    model.MBL01 = decimal.Parse(row["MBL01"].ToString());
                }
                if (row["MBL02"] != null)
                {
                    model.MBL02 = row["MBL02"].ToString();
                }
                if (row["MBL03"] != null)
                {
                    model.MBL03 = row["MBL03"].ToString();
                }
                if (row["MBL04"] != null)
                {
                    model.MBL04 = row["MBL04"].ToString();
                }
                if (row["MB476"] != null && row["MB476"].ToString() != "")
                {
                    model.MB476 = decimal.Parse(row["MB476"].ToString());
                }
                if (row["MB477"] != null)
                {
                    model.MB477 = row["MB477"].ToString();
                }
                if (row["MB478"] != null)
                {
                    model.MB478 = row["MB478"].ToString();
                }
                if (row["MB479"] != null)
                {
                    model.MB479 = row["MB479"].ToString();
                }
                if (row["MB480"] != null)
                {
                    model.MB480 = row["MB480"].ToString();
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
            strSql.Append("select COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,MB001,MB002,MB003,MB004,MB005,MB006,MB007,MB008,MB009,MB010,MB011,MB012,MB013,MB014,MB015,MB016,MB017,MB018,MB019,MB020,MB021,MB022,MB023,MB024,MB025,MB026,MB027,MB028,MB029,MB030,MB031,MB032,MB033,MB034,MB035,MB036,MB037,MB038,MB039,MB040,MB041,MB042,MB043,MB044,MB045,MB046,MB047,MB048,MB049,MB050,MB051,MB052,MB053,MB054,MB055,MB056,MB057,MB058,MB059,MB060,MB061,MB062,MB063,MB064,MB065,MB066,MB067,MB068,MB069,MB070,MB071,MB072,MB073,MB074,MB075,MB076,MB077,MB078,MB079,MB080,MB081,MB082,MB083,MB084,MB085,MB086,MB087,MB088,MB089,MB090,MB091,MB092,MB093,MB094,MB095,MB096,MB100,MB101,MB102,MB103,MB104,MB105,MB106,MB107,MB108,MB109,MB110,MB111,MB112,MB113,MB114,MB115,MB116,MB117,MB118,MB119,MB120,MB121,MB122,MB123,MB124,MB125,MB126,MB127,MB128,MB129,MB130,MB131,MB132,MB133,MB134,MB135,MB136,MB137,MB138,MB139,MB140,MB141,MB142,MB143,MB144,MB145,MB146,MB147,MB148,MB149,MB150,MB151,MB152,MB179,MB180,MB181,MB182,MB183,MB184,MB185,MB186,MB187,MB188,MB189,MB190,MB191,MB192,MB193,MB194,MB195,MB196,MB197,MB198,MB199,MB401,MB402,MB403,MB404,MB405,MB406,MB407,MB408,MB409,MB410,MB411,MB412,MB413,MB414,MB415,MB416,MB417,MB418,MB419,MB420,MB421,MB422,MB423,MB424,MB425,MB426,MB427,MB428,MB429,MB430,MB431,MB432,MB433,MB434,MB435,MB436,MB437,MB438,MB439,MB440,MB441,MB442,MB443,MB444,MB445,MB446,MB447,MB448,MB449,MB450,MB451,MB452,MBD01,MBD02,MBE01,MB453,MB454,MBH01,MBH02,MBH03,MB455,MB456,MB457,MB458,MB459,MB460,MB461,MB462,MB463,MB464,MB465,MB466,MB467,MB468,MB469,MB470,MB471,MB472,MB473,MB474,MB475,MBL01,MBL02,MBL03,MBL04,MB476,MB477,MB478,MB479,MB480,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62 ");
            strSql.Append(" FROM INVMB ");
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
            strSql.Append(" COMPANY,CREATOR,USR_GROUP,CREATE_DATE,MODIFIER,MODI_DATE,FLAG,MB001,MB002,MB003,MB004,MB005,MB006,MB007,MB008,MB009,MB010,MB011,MB012,MB013,MB014,MB015,MB016,MB017,MB018,MB019,MB020,MB021,MB022,MB023,MB024,MB025,MB026,MB027,MB028,MB029,MB030,MB031,MB032,MB033,MB034,MB035,MB036,MB037,MB038,MB039,MB040,MB041,MB042,MB043,MB044,MB045,MB046,MB047,MB048,MB049,MB050,MB051,MB052,MB053,MB054,MB055,MB056,MB057,MB058,MB059,MB060,MB061,MB062,MB063,MB064,MB065,MB066,MB067,MB068,MB069,MB070,MB071,MB072,MB073,MB074,MB075,MB076,MB077,MB078,MB079,MB080,MB081,MB082,MB083,MB084,MB085,MB086,MB087,MB088,MB089,MB090,MB091,MB092,MB093,MB094,MB095,MB096,MB100,MB101,MB102,MB103,MB104,MB105,MB106,MB107,MB108,MB109,MB110,MB111,MB112,MB113,MB114,MB115,MB116,MB117,MB118,MB119,MB120,MB121,MB122,MB123,MB124,MB125,MB126,MB127,MB128,MB129,MB130,MB131,MB132,MB133,MB134,MB135,MB136,MB137,MB138,MB139,MB140,MB141,MB142,MB143,MB144,MB145,MB146,MB147,MB148,MB149,MB150,MB151,MB152,MB179,MB180,MB181,MB182,MB183,MB184,MB185,MB186,MB187,MB188,MB189,MB190,MB191,MB192,MB193,MB194,MB195,MB196,MB197,MB198,MB199,MB401,MB402,MB403,MB404,MB405,MB406,MB407,MB408,MB409,MB410,MB411,MB412,MB413,MB414,MB415,MB416,MB417,MB418,MB419,MB420,MB421,MB422,MB423,MB424,MB425,MB426,MB427,MB428,MB429,MB430,MB431,MB432,MB433,MB434,MB435,MB436,MB437,MB438,MB439,MB440,MB441,MB442,MB443,MB444,MB445,MB446,MB447,MB448,MB449,MB450,MB451,MB452,MBD01,MBD02,MBE01,MB453,MB454,MBH01,MBH02,MBH03,MB455,MB456,MB457,MB458,MB459,MB460,MB461,MB462,MB463,MB464,MB465,MB466,MB467,MB468,MB469,MB470,MB471,MB472,MB473,MB474,MB475,MBL01,MBL02,MBL03,MBL04,MB476,MB477,MB478,MB479,MB480,UDF01,UDF02,UDF03,UDF04,UDF05,UDF06,UDF51,UDF52,UDF53,UDF54,UDF55,UDF56,UDF07,UDF08,UDF09,UDF10,UDF11,UDF12,UDF57,UDF58,UDF59,UDF60,UDF61,UDF62 ");
            strSql.Append(" FROM INVMB ");
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
            strSql.Append("select count(1) FROM INVMB ");
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
                strSql.Append("order by T.MB001 desc");
            }
            strSql.Append(")AS Row, T.*  from INVMB T ");
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

