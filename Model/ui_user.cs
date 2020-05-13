using System;
namespace YJUI.Model
{
    /// <summary>
    /// ui_user:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ui_user
    {
        public ui_user()
        { }
        #region Model
        private Guid _id;
        private string _account;
        private string _password;
        private string _xingming;
        private string _sex;
        private string _depid;
        private string _depname;
        private string _pTeam;
        private string _birth;
        private string _sfz;
        private string _tel;
        private string _dizhi;
        private string _email;
        private string _qq;
        private DateTime? _crdate;
        /// <summary>
        /// 
        /// </summary>
        public Guid id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string account
        {
            set { _account = value; }
            get { return _account; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string password
        {
            set { _password = value; }
            get { return _password; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string xingming
        {
            set { _xingming = value; }
            get { return _xingming; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string birth
        {
            set { _birth = value; }
            get { return _birth; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sfz
        {
            set { _sfz = value; }
            get { return _sfz; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string tel
        {
            set { _tel = value; }
            get { return _tel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dizhi
        {
            set { _dizhi = value; }
            get { return _dizhi; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string qq
        {
            set { _qq = value; }
            get { return _qq; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? crdate
        {
            set { _crdate = value; }
            get { return _crdate; }
        }
        /// <summary>
        /// 部门ID
        /// </summary>
        public string depid
        {
            get
            {
                return _depid;
            }

            set
            {
                _depid = value;
            }
        }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string depname
        {
            get
            {
                return _depname;
            }
            set
            {
                _depname = value;
            }
        }

        public string pTeam
        {
            get
            {
                return _pTeam;
            }

            set
            {
                _pTeam = value;
            }
        }
        #endregion Model

    }
}

