using System;
namespace YJUI.Model
{
    /// <summary>
    /// ui_user_org:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ui_user_org
    {
        public ui_user_org()
        { }
        #region Model
        private int _id;
        private Guid _ui_user_id;
        private Guid _ui_org_id;
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
        public Guid ui_user_id
        {
            set { _ui_user_id = value; }
            get { return _ui_user_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid ui_org_id
        {
            set { _ui_org_id = value; }
            get { return _ui_org_id; }
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

