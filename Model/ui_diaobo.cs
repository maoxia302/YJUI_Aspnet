using System;
namespace YJUI.Model
{
    /// <summary>
    /// ui_diaobo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ui_diaobo
    {
        public ui_diaobo()
        { }
        #region Model
        private int _id;
        private string _zhangtao;
        private string _bmmc;
        private string _db;
        private string _dh;
        private string _dbsj;
        private string _zrck;
        private string _sfqh;
        private string _shr;
        private string _qhbz;
        private DateTime? _dhsj;
        private string _sfrz;
        private string _rzr;
        private DateTime? _rzsj;
        private string _clzk;
        private string _bz;
        private DateTime? _clsj;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        public string zhangtao
        {
            set { _zhangtao = value;}
            get { return _zhangtao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string bmmc
        {
            set { _bmmc = value; }
            get { return _bmmc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string db
        {
            set { _db = value; }
            get { return _db; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dh
        {
            set { _dh = value; }
            get { return _dh; }
        }

        public string dbsj
        {
            set { _dbsj = value;}
            get { return _dbsj; }

        }

        /// <summary>
        /// 
        /// </summary>
        /// 
        public string zrck
        {
            set { _zrck = value; }
            get { return _zrck; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sfqh
        {
            set { _sfqh = value; }
            get { return _sfqh; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string shr
        {
            set { _shr = value; }
            get { return _shr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string qhbz
        {
            set { _qhbz = value; }
            get { return _qhbz; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? dhsj
        {
            set { _dhsj = value; }
            get { return _dhsj; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sfrz
        {
            set { _sfrz = value; }
            get { return _sfrz; }
        }
   
        /// <summary>
        /// 系统录入
        /// </summary>
        public string rzr
        {
            set { _rzr = value; }
            get { return _rzr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? rzsj
        {
            set { _rzsj = value; }
            get { return _rzsj; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string clzk
        {
            set { _clzk = value; }
            get { return _clzk; }
        }
        /// <summary>
        /// 处理备注
        /// </summary>
        public string bz
        {
            set { _bz = value; }
            get { return _bz; }
        }
        /// <summary>
        /// 处理时间
        /// </summary>
        public DateTime? clsj
        {
            set { _clsj = value; }
            get { return _clsj; }
        }
        #endregion Model

    }
}

