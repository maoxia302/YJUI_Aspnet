using System;
namespace YJUI.Model
{
    /// <summary>
    /// ui_org:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ui_org
    {
        public ui_org()
        { }
        #region Model
        private Guid _id;
        private Guid _fatherid;
        private string _orgcode;
        private string _orgname;
        private string _icon;
        private string _attr_a;
        private string _attr_b;
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
        public Guid fatherid
        {
            set { _fatherid = value; }
            get { return _fatherid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string orgcode
        {
            set { _orgcode = value; }
            get { return _orgcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string orgname
        {
            set { _orgname = value; }
            get { return _orgname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string icon
        {
            set { _icon = value; }
            get { return _icon; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string attr_a
        {
            set { _attr_a = value; }
            get { return _attr_a; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string attr_b
        {
            set { _attr_b = value; }
            get { return _attr_b; }
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

