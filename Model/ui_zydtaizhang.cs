using System;
namespace YJUI.Model
{
    /// <summary>
    /// ui_zydtaizhang:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ui_zydtaizhang
    {
        public ui_zydtaizhang()
        { }
        #region Model
        private int _id;
        private DateTime? _fkdate;
        private string _fkperson;
        private string _wtdep;
        private string _fkdesc;
        private string _dydep;
        private string _dyperson;
        private DateTime? _dydate;
        private string _dygaishan;
        private string _cqfangan;
        private DateTime? _cqdate;
        private string _lsjianhe;
        private string _lsdep;
        private DateTime? _lsdate;
        private string _mypingjia;
        private string _myperson;
        private DateTime? _mydate;
        private string _dsjianhe;
        private string _dsperson;
        private DateTime? _dsdate;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? fkDate
        {
            set { _fkdate = value; }
            get { return _fkdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string fkPerson
        {
            set { _fkperson = value; }
            get { return _fkperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string wtDep
        {
            set { _wtdep = value; }
            get { return _wtdep; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string fkDesc
        {
            set { _fkdesc = value; }
            get { return _fkdesc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dyDep
        {
            set { _dydep = value; }
            get { return _dydep; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dyPerson
        {
            set { _dyperson = value; }
            get { return _dyperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? dyDate
        {
            set { _dydate = value; }
            get { return _dydate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dyGaishan
        {
            set { _dygaishan = value; }
            get { return _dygaishan; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string cqFangan
        {
            set { _cqfangan = value; }
            get { return _cqfangan; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? cqDate
        {
            set { _cqdate = value; }
            get { return _cqdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string lsJianhe
        {
            set { _lsjianhe = value; }
            get { return _lsjianhe; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string lsDep
        {
            set { _lsdep = value; }
            get { return _lsdep; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? lsDate
        {
            set { _lsdate = value; }
            get { return _lsdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string myPingjia
        {
            set { _mypingjia = value; }
            get { return _mypingjia; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string myPerson
        {
            set { _myperson = value; }
            get { return _myperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? myDate
        {
            set { _mydate = value; }
            get { return _mydate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dsJianhe
        {
            set { _dsjianhe = value; }
            get { return _dsjianhe; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dsPerson
        {
            set { _dsperson = value; }
            get { return _dsperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? dsDate
        {
            set { _dsdate = value; }
            get { return _dsdate; }
        }
        #endregion Model

    }
}

