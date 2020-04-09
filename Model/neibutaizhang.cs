using System;
namespace YJUI.Model
{
    /// <summary>
    /// neibutaizhang:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class neibutaizhang
    {
        public neibutaizhang()
        { }
        #region Model
        private int _id;
        private DateTime? _fkdate;
        private string _fkperson;
        private string _fkDep;
        private string _wtdep;
        private string _fkdesc;
        private string _dydep;
        private string _fkItem;
        private string _fkArea;
        private string _fkCustomer;

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
        /// 序号
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
        /// 反馈人
        /// </summary>
        public string fkPerson
        {
            set { _fkperson = value; }
            get { return _fkperson; }
        }
        /// <summary>
        /// 问题归属部门
        /// </summary>
        public string wtDep
        {
            set { _wtdep = value; }
            get { return _wtdep; }
        }
        /// <summary>
        /// 反馈描述
        /// </summary>
        public string fkDesc
        {
            set { _fkdesc = value; }
            get { return _fkdesc; }
        }
        /// <summary>
        /// 领取部门
        /// </summary>
        public string dyDep
        {
            set { _dydep = value; }
            get { return _dydep; }
        }
        /// <summary>
        /// 第一责任人
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
        /// 临时改善
        /// </summary>
        public string dyGaishan
        {
            set { _dygaishan = value; }
            get { return _dygaishan; }
        }
        /// <summary>
        /// 长期方案
        /// </summary>
        public string cqFangan
        {
            set { _cqfangan = value; }
            get { return _cqfangan; }
        }
        /// <summary>
        /// 改善时间
        /// </summary>
        public DateTime? cqDate
        {
            set { _cqdate = value; }
            get { return _cqdate; }
        }
        /// <summary>
        /// 落时检核
        /// </summary>
        public string lsJianhe
        {
            set { _lsjianhe = value; }
            get { return _lsjianhe; }
        }
        /// <summary>
        /// 落实部门
        /// </summary>
        public string lsDep
        {
            set { _lsdep = value; }
            get { return _lsdep; }
        }
        /// <summary>
        /// 落时时间
        /// </summary>
        public DateTime? lsDate
        {
            set { _lsdate = value; }
            get { return _lsdate; }
        }
        /// <summary>
        /// 满意评价
        /// </summary>
        public string myPingjia
        {
            set { _mypingjia = value; }
            get { return _mypingjia; }
        }
        /// <summary>
        /// 满意人
        /// </summary>
        public string myPerson
        {
            set { _myperson = value; }
            get { return _myperson; }
        }
        /// <summary>
        /// 满意日期
        /// </summary>
        public DateTime? myDate
        {
            set { _mydate = value; }
            get { return _mydate; }
        }
        /// <summary>
        /// 第三方简核
        /// </summary>
        public string dsJianhe
        {
            set { _dsjianhe = value; }
            get { return _dsjianhe; }
        }
        /// <summary>
        /// 第三方检核人
        /// </summary>
        public string dsPerson
        {
            set { _dsperson = value; }
            get { return _dsperson; }
        }
        /// <summary>
        /// 第三方简核时间
        /// </summary>
        public DateTime? dsDate
        {
            set { _dsdate = value; }
            get { return _dsdate; }
        }
        /// <summary>
        /// 反馈部门
        /// </summary>
        public string FkDep
        {
            get
            {
                return _fkDep;
            }

            set
            {
                _fkDep = value;
            }
        }

        public string fkItem
        {
            get
            {
                return _fkItem;
            }

            set
            {
                _fkItem = value;
            }
        }

        public string fkArea
        {
            get
            {
                return _fkArea;
            }

            set
            {
                _fkArea = value;
            }
        }

        public string fkCustomer
        {
            get
            {
                return _fkCustomer;
            }
            set
            {
                _fkCustomer = value;
            }
        }
        #endregion Model

    }
}

