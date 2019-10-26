using System;
namespace YJUI.Model
{
    /// <summary>
    /// chuyun:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class chuyun
    {
        public chuyun()
        { }
        #region Model
        private int _id;
        private DateTime? _riqi;
        private string _tzr;
        private string _fenku;
        private string _tzrdh;
        private string _dth;
        private string _dhdq;
        private string _khmc;
        private string _dhwl;
        private string _wldh;
        private string _wldz;
        private string _shr;
        private string _shrtel;
        private string _js;
        private string _yfje;
        private string _ph;
        private string _bz;
        private string _thr;
        private string _thsj;
        private string _sfth;
        private string _fee;
        private DateTime? _createdtime = DateTime.Now;
        private string _siji;
        private DateTime? _zjdate = DateTime.Now;
        private string _zhijian;
        private string _wlfl;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 通知日期
        /// </summary>
        public DateTime? riqi
        {
            set { _riqi = value; }
            get { return _riqi; }
        }
        /// <summary>
        /// 通知人
        /// </summary>
        public string tzr
        {
            set { _tzr = value; }
            get { return _tzr; }
        }
        /// <summary>
        /// 通知人电话
        /// </summary>
        public string tzrdh
        {
            set { _tzrdh = value; }
            get { return _tzrdh; }
        }
        /// <summary>
        /// 到退货
        /// </summary>
        public string dth
        {
            set { _dth = value; }
            get { return _dth; }
        }
        /// <summary>
        /// 到货地区
        /// </summary>
        public string dhdq
        {
            set { _dhdq = value; }
            get { return _dhdq; }
        }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string khmc
        {
            set { _khmc = value; }
            get { return _khmc; }
        }
        /// <summary>
        /// 到货物流
        /// </summary>
        public string dhwl
        {
            set { _dhwl = value; }
            get { return _dhwl; }
        }
        /// <summary>
        /// 物流电话
        /// </summary>
        public string wldh
        {
            set { _wldh = value; }
            get { return _wldh; }
        }
        /// <summary>
        /// wldz
        /// </summary>
        public string wldz
        {
            set { _wldz = value; }
            get { return _wldz; }
        }
        /// <summary>
        /// 收货人
        /// </summary>
        public string shr
        {
            set { _shr = value; }
            get { return _shr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string shrtel
        {
            set { _shrtel = value; }
            get { return _shrtel; }
        }
        /// <summary>
        /// 件数
        /// </summary>
        public string js
        {
            set { _js = value; }
            get { return _js; }
        }
        /// <summary>
        /// 运费金额
        /// </summary>
        public string yfje
        {
            set { _yfje = value; }
            get { return _yfje; }
        }
        /// <summary>
        /// 票号
        /// </summary>
        public string ph
        {
            set { _ph = value; }
            get { return _ph; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string bz
        {
            set { _bz = value; }
            get { return _bz; }
        }
        /// <summary>
        /// 提贷人
        /// </summary>
        public string thr
        {
            set { _thr = value; }
            get { return _thr; }
        }
        /// <summary>
        /// 提货时间
        /// </summary>
        public string thsj
        {
            set { _thsj = value; }
            get { return _thsj; }
        }
        /// <summary>
        /// 是否提货
        /// </summary>
        public string sfth
        {
            set { _sfth = value; }
            get { return _sfth; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string fee
        {
            set { _fee = value; }
            get { return _fee; }
        }
        /// <summary>
        /// 实际运费金额操作时间
        /// </summary>
        public DateTime? CreatedTime
        {
            set { _createdtime = value; }
            get { return _createdtime; }
        }

        public string Fenku
        {
            set { _fenku = value; }
            get { return _fenku;}
        }
        /// <summary>
        /// 司机姓名
        /// </summary>
        public string Siji
        {
            get
            {
                return _siji;
            }

            set
            {
                _siji = value;
            }
        }
        /// <summary>
        /// 质检签收日期
        /// </summary>
        public DateTime? Zjdate
        {
            get
            {
                return _zjdate;
            }
            set
            {
                _zjdate = value;
            }
        }
        /// <summary>
        /// 质检姓名
        /// </summary>
        public string Zhijian
        {
            get
            {
                return _zhijian;
            }

            set
            {
                _zhijian = value;
            }
        }

        public string Wlfl
        {
            get
            {
                return _wlfl;
            }

            set
            {
                _wlfl = value;
            }
        }
        #endregion Model

    }
}

