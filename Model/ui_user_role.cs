using System;
namespace YJUI.Model
{
    /// <summary>
    /// ui_user_role:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ui_user_role
    {
        public ui_user_role()
        { }
        #region Model
        private int _id;
        private Guid _ui_user_id;
        private Guid _ui_role_id;
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
        public Guid ui_role_id
        {
            set { _ui_role_id = value; }
            get { return _ui_role_id; }
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

