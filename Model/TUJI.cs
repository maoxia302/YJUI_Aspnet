using System;
namespace YJUI.Model
{
    /// <summary>
    /// TUJI:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class TUJI
    {
        public TUJI()
        { }
        #region Model
        private int _id;
        private string _tjxh;
        private string _fdjh;
        private string _zjsj;
        private string _jhbx;
        private string _gzfsdq;
        private string _dls;
        private string _xlc;
        private string _lxr;
        private string _xlctel;
        private string _xxfksj;
        private string _xxfkr;
        private string _gzxx;
        private string _fenlei;
        private string _gzms;
        private string _shclsj;
        private string _zdfx;
        private string _gznr;
        private string _zpje;
        private string _xxzrr;
        private string _jjfh;
        private string _shclyj;
        private string _fkname;
        private string _dhqr;
        private DateTime? _fkdhrq;
        private DateTime? _dhrq;
        private DateTime? _gongchangshrq;
        private string _gjfa;
        private string _gjzrr;
        private string _gjrq;
        private string _cjrq;
        private string _cjlsh;
        private string _cjr;
        private string _cjfk;
        private string _gzbw;
        private string _zlpd;
        private string _shcjqr;
        private string _bs;
        private string _bz;
        private string _thhfjg;
        private string _thfzr;
        private string _thsj;
        private string _thgjfa;
        private string _thzrr;
        private string _zzqr;
        private string _yiji;
        private string _erji;
        private string _kcclcs;
        private string _kcwcrq;
        private string _gysclcs;
        private string _gyswcrq;
        private string _nblcgs;
        private string _nblcwcrq;
        private string _qtgjcs;
        private string _qtwcrq;
        private string _gjjs;
        private string _cpbqr;
        private string _cpbrq;
        private string _gcqr;
        private string _gcqrrq;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 凸机型号
        /// </summary>
        public string tjxh
        {
            set { _tjxh = value; }
            get { return _tjxh; }
        }
        /// <summary>
        /// 发动机号
        /// </summary>
        public string fdjh
        {
            set { _fdjh = value; }
            get { return _fdjh; }
        }
        /// <summary>
        /// 装机时间
        /// </summary>
        public string zjrq
        {
            set { _zjsj = value; }
            get { return _zjsj; }
        }
        /// <summary>
        /// 激活保修
        /// </summary>
        public string jhbx
        {
            set { _jhbx = value; }
            get { return _jhbx; }
        }
        /// <summary>
        /// 代理地址（故障发生地区）
        /// </summary>
        public string gzfsdq
        {
            set { _gzfsdq = value; }
            get { return _gzfsdq; }
        }
        /// <summary>
        /// 代理商
        /// </summary>
        public string dls
        {
            set { _dls = value; }
            get { return _dls; }
        }
        /// <summary>
        /// 修理厂
        /// </summary>
        public string xlc
        {
            set { _xlc = value; }
            get { return _xlc; }
        }
        /// <summary>
        /// 联系人
        /// </summary>
        public string lxr
        {
            set { _lxr = value; }
            get { return _lxr; }
        }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string xlctel
        {
            set { _xlctel = value; }
            get { return _xlctel; }
        }
        /// <summary>
        /// 反馈时间
        /// </summary>
        public string xxfksj
        {
            set { _xxfksj = value; }
            get { return _xxfksj; }
        }
        /// <summary>
        /// 反馈人
        /// </summary>
        public string xxfkr
        {
            set { _xxfkr = value; }
            get { return _xxfkr; }
        }
        /// <summary>
        /// 故障现象
        /// </summary>
        public string gzxx
        {
            set { _gzxx = value; }
            get { return _gzxx; }
        }
        /// <summary>
        /// 分类
        /// </summary>
        public string fenlei
        {
            set { _fenlei = value; }
            get { return _fenlei; }
        }
        /// <summary>
        /// 故障描述
        /// </summary>
        public string gzms
        {
            set { _gzms = value; }
            get { return _gzms; }
        }
        /// <summary>
        /// 售后处理时间
        /// </summary>
        public string shclsj
        {
            set { _shclsj = value; }
            get { return _shclsj; }
        }
        /// <summary>
        /// 诊断分析
        /// </summary>
        public string zdfx
        {
            set { _zdfx = value; }
            get { return _zdfx; }
        }
        /// <summary>
        /// 诊断结果
        /// </summary>
        public string gznr
        {
            set { _gznr = value; }
            get { return _gznr; }
        }
        /// <summary>
        /// 质赔金额
        /// </summary>
        public string zpje
        {
            set { _zpje = value; }
            get { return _zpje; }
        }
        /// <summary>
        /// 信息责任人
        /// </summary>
        public string xxzrr
        {
            set { _xxzrr = value; }
            get { return _xxzrr; }
        }
        /// <summary>
        /// 旧件返还
        /// </summary>
        public string jjfh
        {
            set { _jjfh = value; }
            get { return _jjfh; }
        }
        /// <summary>
        /// 售后处理意见完成情况
        /// </summary>
        public string shclyj
        {
            set { _shclyj = value; }
            get { return _shclyj; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string fkname
        {
            set { _fkname = value; }
            get { return _fkname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dhqr
        {
            set { _dhqr = value; }
            get { return _dhqr; }
        }

        public DateTime? fkdhrq
        {
            set { _fkdhrq = value; }
            get { return _fkdhrq; }
        }

        /// <summary>
        /// 总库收货日期
        /// </summary>
        public DateTime? dhrq
        {
            set { _dhrq = value; }
            get { return _dhrq; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? gongchangshrq
        {
            set { _gongchangshrq = value; }
            get { return _gongchangshrq; }
        }
        /// <summary>
        /// 改进方案
        /// </summary>
        public string gjfa
        {
            set { _gjfa = value; }
            get { return _gjfa; }
        }
        /// <summary>
        /// 改进责任人
        /// </summary>
        public string gjzrr
        {
            set { _gjzrr = value; }
            get { return _gjzrr; }
        }
        /// <summary>
        /// 改进日期
        /// </summary>
        public string gjrq
        {
            set { _gjrq = value; }
            get { return _gjrq; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string cjrq
        {
            set { _cjrq = value; }
            get { return _cjrq; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string cjlsh
        {
            set { _cjlsh = value; }
            get { return _cjlsh; }
        }
        /// <summary>
        /// 拆检人
        /// </summary>
        public string cjr
        {
            set { _cjr = value; }
            get { return _cjr; }
        }
        /// <summary>
        /// 拆检结果
        /// </summary>
        public string cjfk
        {
            set { _cjfk = value; }
            get { return _cjfk; }
        }
        /// <summary>
        /// 故障部位
        /// </summary>
        public string gzbw
        {
            set { _gzbw = value; }
            get { return _gzbw; }
        }
        /// <summary>
        /// 质量判断
        /// </summary>
        public string zlpd
        {
            set { _zlpd = value; }
            get { return _zlpd; }
        }
        /// <summary>
        /// 售后拆解确认
        /// </summary>
        public string shcjqr
        {
            set { _shcjqr = value; }
            get { return _shcjqr; }
        }
        /// <summary>
        /// 结束
        /// </summary>
        public string bs
        {
            set { _bs = value; }
            get { return _bs; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string bz
        {
            set { _bz = value; }
            get { return _bz; }
        }
        /// <summary>
        /// 客服回访结果
        /// </summary>
        public string thhfjg
        {
            set { _thhfjg = value; }
            get { return _thhfjg; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string thfzr
        {
            set { _thfzr = value; }
            get { return _thfzr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string thsj
        {
            set { _thsj = value; }
            get { return _thsj; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string thgjfa
        {
            set { _thgjfa = value; }
            get { return _thgjfa; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string thzrr
        {
            set { _thzrr = value; }
            get { return _thzrr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string zzqr
        {
            set { _zzqr = value; }
            get { return _zzqr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string yiji
        {
            set { _yiji = value; }
            get { return _yiji; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string erji
        {
            set { _erji = value; }
            get { return _erji; }
        }
        /// <summary>
        /// 对库存处理措施
        /// </summary>
        public string kcclcs
        {
            set { _kcclcs = value; }
            get { return _kcclcs; }
        }
        /// <summary>
        /// 库存处理完成日期
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
        /// 供应商处理完成日期
        /// </summary>
        public string gyswcrq
        {
            set { _gyswcrq = value; }
            get { return _gyswcrq; }
        }
        /// <summary>
        /// 内部流程工艺改善
        /// </summary>
        public string nblcgs
        {
            set { _nblcgs = value; }
            get { return _nblcgs; }
        }
        /// <summary>
        /// 内部流程改善完成日期
        /// </summary>
        public string nblcwcrq
        {
            set { _nblcwcrq = value; }
            get { return _nblcwcrq; }
        }
        /// <summary>
        /// 其他处理措施
        /// </summary>
        public string qtgjcs
        {
            set { _qtgjcs = value; }
            get { return _qtgjcs; }
        }
        /// <summary>
        /// 其他处理完成日期
        /// </summary>
        public string qtwcrq
        {
            set { _qtwcrq = value; }
            get { return _qtwcrq; }
        }
        /// <summary>
        /// 改进是否结束
        /// </summary>
        public string gjjs
        {
            set { _gjjs = value; }
            get { return _gjjs; }
        }
        /// <summary>
        /// 产品部确认
        /// </summary>
        public string cpbqr
        {
            set { _cpbqr = value; }
            get { return _cpbqr; }
        }
        /// <summary>
        /// 产品部确认日期
        /// </summary>
        public string cpbrq
        {
            set { _cpbrq = value; }
            get { return _cpbrq; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string gcqr
        {
            set { _gcqr = value; }
            get { return _gcqr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string gcqrrq
        {
            set { _gcqrrq = value; }
            get { return _gcqrrq; }
        }
        #endregion Model

    }
}

