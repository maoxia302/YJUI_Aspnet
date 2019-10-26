using System;
namespace YJUI.Model
{
    /// <summary>
    /// renkuan:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class renkuan
    {
        public renkuan()
        { }
        #region Model
        private int _id;
        private DateTime? _wdate;
        private string _bankinfo;
        private string _tmode;
        private string _hfee;
        private string _hmoney;
        private string _cremark;
        private string _customer;
        private string _employee;
        private string _kremark;
        private string _state;
        private string _qremark;
        private string _customerid;
        private string _orderid;
        private string _szje;
        private string _rkriqi;
        private DateTime? _crdate;
        private string _flag = "0";
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
        public DateTime? WDate
        {
            set { _wdate = value; }
            get { return _wdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BankInfo
        {
            set { _bankinfo = value; }
            get { return _bankinfo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TMode
        {
            set { _tmode = value; }
            get { return _tmode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string HFee
        {
            set { _hfee = value; }
            get { return _hfee; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Hmoney
        {
            set { _hmoney = value; }
            get { return _hmoney; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CRemark
        {
            set { _cremark = value; }
            get { return _cremark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Customer
        {
            set { _customer = value; }
            get { return _customer; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Employee
        {
            set { _employee = value; }
            get { return _employee; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string KRemark
        {
            set { _kremark = value; }
            get { return _kremark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string State
        {
            set { _state = value; }
            get { return _state; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string QRemark
        {
            set { _qremark = value; }
            get { return _qremark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CustomerID
        {
            set { _customerid = value; }
            get { return _customerid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OrderID
        {
            set { _orderid = value; }
            get { return _orderid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SZJE
        {
            set { _szje = value; }
            get { return _szje; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RKriqi
        {
            set { _rkriqi = value; }
            get { return _rkriqi; }
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
        /// 
        /// </summary>
        public string flag
        {
            set { _flag = value; }
            get { return _flag; }
        }
        #endregion Model

    }
}

