using System;
namespace YJUI.Model
{
    /// <summary>
    /// ui_menu:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ui_menu
    {
        public ui_menu()
        { }
        #region Model
        private int _id;
        private int? _menuorder;
        private int? _fatherid;
        private string _menuname;
        private string _icon;
        private string _url;
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
        public int? menuorder
        {
            set { _menuorder = value; }
            get { return _menuorder; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? fatherid
        {
            set { _fatherid = value; }
            get { return _fatherid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string menuname
        {
            set { _menuname = value; }
            get { return _menuname; }
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
        public string url
        {
            set { _url = value; }
            get { return _url; }
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

