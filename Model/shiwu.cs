using System;
namespace YJUI.Model
{
    /// <summary>
    /// shiwu:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class shiwu
    {
        public shiwu()
        { }
        #region Model
        private int _id;
        private DateTime? _fkdate;
        private string _fkperson;
        private string _supportdep;
        private string _fkdesc;
        private string _receivedep;
        private string _receiveperson;
        private DateTime? _receivedate;
        private string _tempgaishan;
        private string _cqfangan;
        private DateTime? _cqdate;
        private string _enddesc;
        private string _enddate;
        private string _lsresult;
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
        public string supportDep
        {
            set { _supportdep = value; }
            get { return _supportdep; }
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
        public string receiveDep
        {
            set { _receivedep = value; }
            get { return _receivedep; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string receivePerson
        {
            set { _receiveperson = value; }
            get { return _receiveperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? receiveDate
        {
            set { _receivedate = value; }
            get { return _receivedate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string tempGaishan
        {
            set { _tempgaishan = value; }
            get { return _tempgaishan; }
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
        public string endDesc
        {
            set { _enddesc = value; }
            get { return _enddesc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string endDate
        {
            set { _enddate = value; }
            get { return _enddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string lsResult
        {
            set { _lsresult = value; }
            get { return _lsresult; }
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

