using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
namespace YJUI.DBUtility
{
    public class ConnStrManage
    {
        private static ConnStrManage _instance;
        private string _VocenDB;
        private string _TuJiDB;
        private string _V2013DB;
        private string _NEWV2013DB;//12帐套vocen2013帐套
        private string _WsgcDB;//沃森工厂
        private string _WssybDB;//沃森事业部数据

        public static string NEWV2013DB
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConnStrManage();
                }
                return _instance._NEWV2013DB;
            }
        }

        public static string V2013DB
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConnStrManage();
                }
                return _instance._V2013DB;
            }
        }

        public static string TuJiDB
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConnStrManage();
                }
                return _instance._TuJiDB;
            }
        }
        public static string WSGCDB
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConnStrManage();
                }
                return _instance._WsgcDB;
            }
        }
        public static string WSSYBDB
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConnStrManage();
                }
                return _instance._WssybDB;
            }
        }

        private ConnStrManage()
        {
            _VocenDB = ConfigurationManager.ConnectionStrings["SQLConnStringVOCEN"].ConnectionString;
            _TuJiDB = ConfigurationManager.ConnectionStrings["SQLConnStringTUJI2019"].ConnectionString;
            _V2013DB = ConfigurationManager.ConnectionStrings["SQLConnString"].ConnectionString;
            _NEWV2013DB = ConfigurationManager.ConnectionStrings["SQLConnString_New"].ConnectionString;
            _WsgcDB = ConfigurationManager.ConnectionStrings["WsgcSQLConnString"].ConnectionString;
            _WssybDB = ConfigurationManager.ConnectionStrings["WssybSQLConnString"].ConnectionString;

        }
    }
}
