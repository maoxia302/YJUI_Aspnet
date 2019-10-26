using System;
namespace YJUI.Model
{
    /// <summary>
    /// ui_guzhang:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ui_guzhang
    {
        public ui_guzhang()
        { }
        #region Model
        private int _id;
        private int _typeid;
        private string _guzhang;
        private string _remark;
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
        public int typeid
        {
            set { _typeid = value; }
            get { return _typeid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string guzhang
        {
            set { _guzhang = value; }
            get { return _guzhang; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        #endregion Model

    }
}

