using System;
namespace YJUI.Model
{
    /// <summary>
    /// ui_bzgs:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ui_bzgs
    {
        public ui_bzgs()
        { }
        #region Model
        private int _id;
        private string _name;
        private string _gongshi;
        private string _remark;
        private DateTime? _crdate;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string gongshi
        {
            set { _gongshi = value; }
            get { return _gongshi; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? crdate
        {
            set { _crdate = value; }
            get { return _crdate; }
        }
        #endregion Model

    }
}

