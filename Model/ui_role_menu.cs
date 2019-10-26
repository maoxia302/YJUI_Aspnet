using System;
namespace YJUI.Model
{
    /// <summary>
    /// ui_role_menu:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ui_role_menu
    {
        public ui_role_menu()
        { }
        #region Model
        private int _id;
        private Guid _ui_role_id;
        private int? _ui_menu_id;
        private DateTime? _crdate = DateTime.Now;
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
        public Guid ui_role_id
        {
            set { _ui_role_id = value; }
            get { return _ui_role_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ui_menu_id
        {
            set { _ui_menu_id = value; }
            get { return _ui_menu_id; }
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

