using System;
using System.Collections.Generic;
using System.Text;

namespace YJUI.Model
{
    /// <summary>
    /// jldl1:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class jldl1
    {
        public jldl1()
        { }
        #region Model
        private int _id;
        private DateTime? _fksj;
        private string _fkr;
        private string _pj;
        private string _fssj;
        private string _fsdq;
        private string _dls;
        private string _dlsdh;
        private string _xlcxx;
        private string _fknr;
        private string _fl;
        private string _jjsfth;
        private string _zrbm;
        private string _zrr;
        private string _ycclrq;
        private string _plga;
        private string _dkhcs;
        private string _wcsj;
        private string _kcclcs;
        private string _kcwcrq;
        private string _gysclcs;
        private string _gysrq;
        private string _nblcgygs;
        private string _nblcwcrq;
        private string _qtcs;
        private string _qtcsrq;
        private string _zrbmsp;
        private string _dsfjh;
        private string _hfsjqk;
        private string _hfwcrq;
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
        public DateTime? fksj
        {
            set { _fksj = value; }
            get { return _fksj; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string fkr
        {
            set { _fkr = value; }
            get { return _fkr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pj
        {
            set { _pj = value; }
            get { return _pj; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string fssj
        {
            set { _fssj = value; }
            get { return _fssj; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string fsdq
        {
            set { _fsdq = value; }
            get { return _fsdq; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dls
        {
            set { _dls = value; }
            get { return _dls; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dlsdh
        {
            set { _dlsdh = value; }
            get { return _dlsdh; }
        }
        /// <summary>
        /// 修理厂电话
        /// </summary>
        public string xlcxx
        {
            set { _xlcxx = value; }
            get { return _xlcxx; }
        }
        /// <summary>
        /// 故障描述
        /// </summary>
        public string fknr
        {
            set { _fknr = value; }
            get { return _fknr; }
        }
        /// <summary>
        /// 分类
        /// </summary>
        public string fl
        {
            set { _fl = value; }
            get { return _fl; }
        }
        /// <summary>
        /// 旧件是否退回
        /// </summary>
        public string jjsfth
        {
            set { _jjsfth = value; }
            get { return _jjsfth; }
        }
        /// <summary>
        /// 责任部门
        /// </summary>
        public string zrbm
        {
            set { _zrbm = value; }
            get { return _zrbm; }
        }
        /// <summary>
        /// 责任人
        /// </summary>
        public string zrr
        {
            set { _zrr = value; }
            get { return _zrr; }
        }
        /// <summary>
        /// 第一次处理日期
        /// </summary>
        public string ycclrq
        {
            set { _ycclrq = value; }
            get { return _ycclrq; }
        }
        /// <summary>
        /// 批量个案
        /// </summary>
        public string plga
        {
            set { _plga = value; }
            get { return _plga; }
        }
        /// <summary>
        /// 对客户处理措施
        /// </summary>
        public string dkhcs
        {
            set { _dkhcs = value; }
            get { return _dkhcs; }
        }
        /// <summary>
        /// 完成日期
        /// </summary>
        public string wcsj
        {
            set { _wcsj = value; }
            get { return _wcsj; }
        }
        /// <summary>
        /// 库存处理措施
        /// </summary>
        public string kcclcs
        {
            set { _kcclcs = value; }
            get { return _kcclcs; }
        }
        /// <summary>
        /// 库存处理日期
        /// </summary>
        public string kcwcrq
        {
            set { _kcwcrq = value; }
            get { return _kcwcrq; }
        }
        /// <summary>
        /// 供应商处理措施
        /// </summary>
        public string gysclcs
        {
            set { _gysclcs = value; }
            get { return _gysclcs; }
        }
        /// <summary>
        /// 供应商完成日期
        /// </summary>
        public string gysrq
        {
            set { _gysrq = value; }
            get { return _gysrq; }
        }
        /// <summary>
        /// 内部流程工艺改善
        /// </summary>
        public string nblcgygs
        {
            set { _nblcgygs = value; }
            get { return _nblcgygs; }
        }
        /// <summary>
        /// 内部流程完成日期
        /// </summary>
        public string nblcwcrq
        {
            set { _nblcwcrq = value; }
            get { return _nblcwcrq; }
        }
        /// <summary>
        /// 其它措施
        /// </summary>
        public string qtcs
        {
            set { _qtcs = value; }
            get { return _qtcs; }
        }
        /// <summary>
        /// 其它措施日期
        /// </summary>
        public string qtcsrq
        {
            set { _qtcsrq = value; }
            get { return _qtcsrq; }
        }
        /// <summary>
        /// 责任部门领导审批
        /// </summary>
        public string zrbmsp
        {
            set { _zrbmsp = value; }
            get { return _zrbmsp; }
        }
        /// <summary>
        /// 第三方检核
        /// </summary>
        public string dsfjh
        {
            set { _dsfjh = value; }
            get { return _dsfjh; }
        }
        /// <summary>
        /// 回访实际情况
        /// </summary>
        public string hfsjqk
        {
            set { _hfsjqk = value; }
            get { return _hfsjqk; }
        }
        /// <summary>
        /// 回访完成日期
        /// </summary>
        public string hfwcrq
        {
            set { _hfwcrq = value; }
            get { return _hfwcrq; }
        }
        #endregion Model

    }
}
