using System;
using System.Runtime.Remoting;

namespace YJUI.Model
{
    /// <summary>
    /// ui_gongyingshang:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ui_gongyingshang
    {
        public ui_gongyingshang()
        { }
        #region Model
        private int _id;
        private DateTime? _regdate;
        private string _regperson;
        private DateTime? _arrdate;
        private DateTime? _arr_date;
        private string _arrperson;
        private string _arr_remark;
        private DateTime? _yddate;
        private string _dep;
        private string _cate;
        private string _category;
        private string _suppliername;
        private string _suppliertel;
        private decimal? _totals = 0M;
        private decimal? _total = 0M;
        private string _gremark;
        private DateTime? _uploadstddate;
        private DateTime? _uploadrealdate;
        private decimal? _uploadnum = 0M;
        private string _uploadperson;
        private DateTime? _uploaddate;
        private string _uploadremark;
        private DateTime? _wrecstddate;
        private DateTime? _wrecrealdate;
        private string _wrecperson;
        private decimal? _wrecnums;
        private decimal? _wrecnum = 0M;
        private string _wrecremark;
        private DateTime? _wrecdate;
        private DateTime? _crecstddate;
        private DateTime? _crecrealdate;
        private decimal? _crecnums = 0M;
        private decimal? _crecnum = 0M;
        private string _crecperson;
        private DateTime? _crecdate;
        private string _crecremark;
        private DateTime? _brecstddate;
        private DateTime? _brecrealdate;
        private decimal? _brecnums = 0M;
        private decimal? _brecnum = 0M;
        private string _brecperson;
        private string _brecremark;
        private DateTime? _brecdate;
        private DateTime? _frecstddate;
        private DateTime? _frecrealdate;
        private decimal? _frecnums = 0M;
        private decimal? _frecnum = 0M;
        private string _frecperson;
        private DateTime? _frecdate;
        private string _frecremark;
        private DateTime? _zrecstddate;
        private DateTime? _zrecrealdate;
        private string _zrecperson;
        private decimal? _zrecnums = 0M;
        private decimal? _zrecnum = 0M;
        private DateTime? _zrecdate;
        private string _zrecremark;
        private DateTime? _teststddate;
        private DateTime? _testrealdate;
        private string _testperson;
        private DateTime? _testdate;
        private string _testremark;
        private DateTime? _unfinishstddate;
        private DateTime? _unfinishrealdate;
        private decimal? _unfinishnum = 0M;
        private string _unfinishperson;
        private string _unfinishremark;
        private DateTime? _unfinishdate;
        private DateTime? _finishstddate;
        private DateTime? _finishrealdate;
        private decimal? _finishnum = 0M;
        private string _finishperson;
        private DateTime? _finishdate;
        private string _finishremark;
        private DateTime? _packstddate;
        private DateTime? _packrealdate;
        private decimal? _packnum = 0M;
        private string _packperson;
        private string _packremark;
        private DateTime? _packdate;
        private DateTime? _noselfstddate;
        private DateTime? _noselfrealdate;
        private decimal? _noselfnum = 0M;
        private string _noselfperson;
        private string _noselfremark;
        private DateTime? _noselfdate;
        //
        private DateTime? _giftstddate;
        private DateTime? _giftrealdate;
        private decimal? _giftnum;
        private string _giftperson;
        private string _giftremark;
        private DateTime? _giftdate;
        //
        private DateTime? _badstddate;
        private DateTime? _badrealdate;
        private decimal? _badnum = 0M;
        private string _badperson;
        private string _badremark;
        private DateTime? _baddate;
        private DateTime? _reworkstddate;
        private DateTime? _reworkrealdate;
        private decimal? _reworknum = 0M;
        private string _reworkperson;
        private string _reworkremark;
        private DateTime? _reworkdate;
        private DateTime? _totalstddate;
        private DateTime? _totalrealdate;
        private string _checkcontent;
        private string _checkperson;
        private string _checkremark;
        private DateTime? _checkdate;
        private int? _flag;
        private DateTime? _lastdate;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 登记时间
        /// </summary>
        public DateTime? regdate
        {
            set { _regdate = value; }
            get { return _regdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string regperson
        {
            set { _regperson = value; }
            get { return _regperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? arrdate
        {
            set { _arrdate = value; }
            get { return _arrdate; }
        }

        public DateTime? arr_date
        {
            set { _arr_date = value; }
            get { return _arrdate; }
        }

        public string arrperson
        {
            set { _arrperson = value; }
            get { return _arrperson; }
        }

        public string arr_remark
        {
            set { _arr_remark = value; }
            get { return _arr_remark; }
        }

        public DateTime? yddate
        {
            set { _yddate = value; }
            get { return _yddate; }

        }
        /// <summary>
        /// 
        /// </summary>
        public string dep
        {
            set { _dep = value; }
            get { return _dep; }
        }
        /// <summary>
        /// 成品分类
        /// </summary>
        public string cate
        {
            set { _cate = value; }
            get{ return _cate; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string category
        {
            set { _category = value; }
            get { return _category; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string suppliername
        {
            set { _suppliername = value; }
            get { return _suppliername; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string suppliertel
        {
            set { _suppliertel = value; }
            get { return _suppliertel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? totals
        {
            set { _totals = value; }
            get { return _totals; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? total
        {
            set { _total = value; }
            get { return _total; }
        }

        public string Gremark
        {
            set { _gremark = value; }
            get { return _gremark; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? uploadstddate
        {
            set { _uploadstddate = value; }
            get { return _uploadstddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? uploadrealdate
        {
            set { _uploadrealdate = value; }
            get { return _uploadrealdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? uploadnum
        {
            set { _uploadnum = value; }
            get { return _uploadnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string uploadperson
        {
            set { _uploadperson = value; }
            get { return _uploadperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? uploaddate
        {
            set { _uploaddate = value; }
            get { return _uploaddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string uploadremark
        {
            set { _uploadremark = value; }
            get { return _uploadremark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? wRecstddate
        {
            set { _wrecstddate = value; }
            get { return _wrecstddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? wRecrealdate
        {
            set { _wrecrealdate = value; }
            get { return _wrecrealdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string wRecperson
        {
            set { _wrecperson = value; }
            get { return _wrecperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? wRecnums
        {
            set { _wrecnums = value; }
            get { return _wrecnums; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? wRecnum
        {
            set { _wrecnum = value; }
            get { return _wrecnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string wRecremark
        {
            set { _wrecremark = value; }
            get { return _wrecremark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? wRecdate
        {
            set { _wrecdate = value; }
            get { return _wrecdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? cRecstddate
        {
            set { _crecstddate = value; }
            get { return _crecstddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? cRecrealdate
        {
            set { _crecrealdate = value; }
            get { return _crecrealdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cRecnums
        {
            set { _crecnums = value; }
            get { return _crecnums; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cRecnum
        {
            set { _crecnum = value; }
            get { return _crecnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string cRecperson
        {
            set { _crecperson = value; }
            get { return _crecperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? cRecdate
        {
            set { _crecdate = value; }
            get { return _crecdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string cRecremark
        {
            set { _crecremark = value; }
            get { return _crecremark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? bRecstddate
        {
            set { _brecstddate = value; }
            get { return _brecstddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? bRecrealdate
        {
            set { _brecrealdate = value; }
            get { return _brecrealdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? bRecnums
        {
            set { _brecnums = value; }
            get { return _brecnums; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? bRecnum
        {
            set { _brecnum = value; }
            get { return _brecnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string bRecperson
        {
            set { _brecperson = value; }
            get { return _brecperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string bRecremark
        {
            set { _brecremark = value; }
            get { return _brecremark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? bRecdate
        {
            set { _brecdate = value; }
            get { return _brecdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? fRecstddate
        {
            set { _frecstddate = value; }
            get { return _frecstddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? fRecrealdate
        {
            set { _frecrealdate = value; }
            get { return _frecrealdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? fRecnums
        {
            set { _frecnums = value; }
            get { return _frecnums; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? fRecnum
        {
            set { _frecnum = value; }
            get { return _frecnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string fRecperson
        {
            set { _frecperson = value; }
            get { return _frecperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? fRecdate
        {
            set { _frecdate = value; }
            get { return _frecdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string fRecremark
        {
            set { _frecremark = value; }
            get { return _frecremark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? zRecstddate
        {
            set { _zrecstddate = value; }
            get { return _zrecstddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? zRecrealdate
        {
            set { _zrecrealdate = value; }
            get { return _zrecrealdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string zRecperson
        {
            set { _zrecperson = value; }
            get { return _zrecperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? zRecnums
        {
            set { _zrecnums = value; }
            get { return _zrecnums; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? zRecnum
        {
            set { _zrecnum = value; }
            get { return _zrecnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? zRecdate
        {
            set { _zrecdate = value; }
            get { return _zrecdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string zRecremark
        {
            set { _zrecremark = value; }
            get { return _zrecremark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? teststddate
        {
            set { _teststddate = value; }
            get { return _teststddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? testrealdate
        {
            set { _testrealdate = value; }
            get { return _testrealdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string testperson
        {
            set { _testperson = value; }
            get { return _testperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? testdate
        {
            set { _testdate = value; }
            get { return _testdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string testremark
        {
            set { _testremark = value; }
            get { return _testremark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? unfinishstddate
        {
            set { _unfinishstddate = value; }
            get { return _unfinishstddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? unfinishrealdate
        {
            set { _unfinishrealdate = value; }
            get { return _unfinishrealdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? unfinishnum
        {
            set { _unfinishnum = value; }
            get { return _unfinishnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string unfinishperson
        {
            set { _unfinishperson = value; }
            get { return _unfinishperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string unfinishremark
        {
            set { _unfinishremark = value; }
            get { return _unfinishremark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? unfinishdate
        {
            set { _unfinishdate = value; }
            get { return _unfinishdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? finishstddate
        {
            set { _finishstddate = value; }
            get { return _finishstddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? finishrealdate
        {
            set { _finishrealdate = value; }
            get { return _finishrealdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? finishnum
        {
            set { _finishnum = value; }
            get { return _finishnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string finishperson
        {
            set { _finishperson = value; }
            get { return _finishperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? finishdate
        {
            set { _finishdate = value; }
            get { return _finishdate; }
        }

        public string finishremark {
            set { _finishremark = value; }
            get { return _finishremark; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? packstddate
        {
            set { _packstddate = value; }
            get { return _packstddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? packrealdate
        {
            set { _packrealdate = value; }
            get { return _packrealdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? packnum
        {
            set { _packnum = value; }
            get { return _packnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string packperson
        {
            set { _packperson = value; }
            get { return _packperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string packremark
        {
            set { _packremark = value; }
            get { return _packremark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? packdate
        {
            set { _packdate = value; }
            get { return _packdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? noselfstddate
        {
            set { _noselfstddate = value; }
            get { return _noselfstddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? noselfrealdate
        {
            set { _noselfrealdate = value; }
            get { return _noselfrealdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? noselfnum
        {
            set { _noselfnum = value; }
            get { return _noselfnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string noselfperson
        {
            set { _noselfperson = value; }
            get { return _noselfperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string noselfremark
        {
            set { _noselfremark = value; }
            get { return _noselfremark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? noselfdate
        {
            set { _noselfdate = value; }
            get { return _noselfdate; }
        }

        public DateTime? giftstddate {
            set { _giftstddate = value; }
            get { return _giftstddate; }
        }

        public DateTime? giftrealdate
        {
            set { _giftrealdate = value; }
            get { return _giftrealdate; }
        }
        public decimal? giftnum
        {
            set { _giftnum = value; }
            get { return _giftnum; }
        }

        public string giftperson
        {
            set { _giftperson = value; }
            get { return _giftperson; }
        }

        public string giftremark
        {
            set { _giftremark = value; }
            get { return _giftremark; }
        }

        public DateTime? giftdate
        {
            set { _giftdate = value; }
            get { return _giftdate; }
        }


        /// <summary>
        /// 
        /// </summary>
        public DateTime? badstddate
        {
            set { _badstddate = value; }
            get { return _badstddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? badrealdate
        {
            set { _badrealdate = value; }
            get { return _badrealdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? badnum
        {
            set { _badnum = value; }
            get { return _badnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string badperson
        {
            set { _badperson = value; }
            get { return _badperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string badremark
        {
            set { _badremark = value; }
            get { return _badremark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? baddate
        {
            set { _baddate = value; }
            get { return _baddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? reworkstddate
        {
            set { _reworkstddate = value; }
            get { return _reworkstddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? reworkrealdate
        {
            set { _reworkrealdate = value; }
            get { return _reworkrealdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? reworknum
        {
            set { _reworknum = value; }
            get { return _reworknum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string reworkperson
        {
            set { _reworkperson = value; }
            get { return _reworkperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string reworkremark
        {
            set { _reworkremark = value; }
            get { return _reworkremark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? reworkdate
        {
            set { _reworkdate = value; }
            get { return _reworkdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? totalstddate
        {
            set { _totalstddate = value; }
            get { return _totalstddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? totalrealdate
        {
            set { _totalrealdate = value; }
            get { return _totalrealdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string checkcontent
        {
            set { _checkcontent = value; }
            get { return _checkcontent; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string checkperson
        {
            set { _checkperson = value; }
            get { return _checkperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string checkremark
        {
            set { _checkremark = value; }
            get { return _checkremark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? checkdate
        {
            set { _checkdate = value; }
            get { return _checkdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? flag
        {
            set { _flag = value; }
            get { return _flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? lastdate
        {
            set { _lastdate = value; }
            get { return _lastdate; }
        }

        public DateTime? Yddate
        {
            get { return yddate; }
            set { yddate = value; }
        }

        #endregion Model

    }
}

