using System;
namespace YJUI.Model
{
    /// <summary>
    /// ui_tuji:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ui_tuji
    {
        public ui_tuji()
        { }
        #region Model
        private int _id;
        private DateTime? _fk_date;
        private string _fk_person;
        private string _fk_dep;
        private string _fk_area;
        private string _fk_customer;
        private string _fk_type;
        private string _fk_dec;
        private string _zx_look;
        private string _zx_is;
        private string _ht_dep;
        private string _ht_person;
        private DateTime? _ht_lqdate;
        private DateTime? _ht_predate;
        private string _ht_status;
        private string _service;
        private DateTime? _service_date;
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
        public DateTime? fk_date
        {
            set { _fk_date = value; }
            get { return _fk_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string fk_person
        {
            set { _fk_person = value; }
            get { return _fk_person; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string fk_dep
        {
            set { _fk_dep = value; }
            get { return _fk_dep; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string fk_area
        {
            set { _fk_area = value; }
            get { return _fk_area; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string fk_customer
        {
            set { _fk_customer = value; }
            get { return _fk_customer; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string fk_type
        {
            set { _fk_type = value; }
            get { return _fk_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string fk_dec
        {
            set { _fk_dec = value; }
            get { return _fk_dec; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string zx_look
        {
            set { _zx_look = value; }
            get { return _zx_look; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string zx_is
        {
            set { _zx_is = value; }
            get { return _zx_is; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ht_dep
        {
            set { _ht_dep = value; }
            get { return _ht_dep; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ht_person
        {
            set { _ht_person = value; }
            get { return _ht_person; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ht_lqdate
        {
            set { _ht_lqdate = value; }
            get { return _ht_lqdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ht_predate
        {
            set { _ht_predate = value; }
            get { return _ht_predate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ht_status
        {
            set { _ht_status = value; }
            get { return _ht_status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string service
        {
            set { _service = value; }
            get { return _service; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? service_date
        {
            set { _service_date = value; }
            get { return _service_date; }
        }
        #endregion Model
    }
}

