using System;
namespace HIS .Model
{
    /// <summary>
    /// ʵ����YF_Account ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    public class YP_Account
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        public YP_Account()
        {
        }
        #region Model
        private int _maccountid;
        private int _accountyear;
        private int _accountmonth;
        private int _accounttype;
        private decimal _retailprice;
        private decimal _stockprice;
        private string _optype;
        private int _billnum;
        private int _unitnum;
        private int _leastunit;
        private DateTime _regtime;
        private decimal _debitnum;
        private decimal _lendernum;
        private decimal _overnum;
        private decimal _debitfee;
        private decimal _lenderfee;
        private decimal _balancefee;
        private int _balance_flag;
        private int _accounthistoryid;
        private int _makerdicid;
        private YP_AccountHis _accounthistory;
        private YP_MakerDic _makerdic;
        private int _deptid;
        private int _orderid;

        public object Clone()
        {
            YP_Account newAccount = new YP_Account();
            newAccount._accounthistoryid = _accounthistoryid;
            newAccount._accountmonth = _accountmonth;
            newAccount._accounttype = _accounttype;
            newAccount._accountyear = _accountyear;
            newAccount._balance_flag = _balance_flag;
            newAccount._balancefee = _balancefee;
            newAccount._billnum = _billnum;
            newAccount._debitfee = _debitfee;
            newAccount._debitnum = _debitnum;
            newAccount._deptid = _deptid;
            newAccount._leastunit = _leastunit;
            newAccount._lenderfee = _lenderfee;
            newAccount._lendernum = _lendernum;
            newAccount._maccountid = _maccountid;
            newAccount._makerdicid = _makerdicid;
            newAccount._optype = _optype;
            newAccount._orderid = _orderid;
            newAccount._overnum = _overnum;
            newAccount._regtime = _regtime;
            newAccount._retailprice = _retailprice;
            newAccount._stockprice = _stockprice;
            newAccount._unitnum = _unitnum;
            return newAccount;
        }
        /// <summary>
        /// ̨�ʱ�ʶID
        /// </summary>
        public int MAccountID
        {
            set
            {
                _maccountid = value;
            }
            get
            {
                return _maccountid;
            }
        }
        /// <summary>
        /// ̨�����
        /// </summary>
        public int AccountYear
        {
            set
            {
                _accountyear = value;
            }
            get
            {
                return _accountyear;
            }
        }
        /// <summary>
        /// ̨���·�
        /// </summary>
        public int AccountMonth
        {
            set
            {
                _accountmonth = value;
            }
            get
            {
                return _accountmonth;
            }
        }
        /// <summary>
        /// ̨�����ͣ�0���ڳ���1����ĩ��2��������3��������
        /// </summary>
        public int AccountType
        {
            set
            {
                _accounttype = value;
            }
            get
            {
                return _accounttype;
            }
        }
        /// <summary>
        /// ���ۼ�
        /// </summary>
        public decimal RetailPrice
        {
            set
            {
                _retailprice = value;
            }
            get
            {
                return _retailprice;
            }
        }
        /// <summary>
        /// ������
        /// </summary>
        public decimal StockPrice
        {
            set
            {
                _stockprice = value;
            }
            get
            {
                return _stockprice;
            }
        }
        /// <summary>
        /// ҵ������
        /// </summary>
        public string OpType
        {
            set
            {
                _optype = value;
            }
            get
            {
                return _optype;
            }
        }
        /// <summary>
        /// ���ݺ�
        /// </summary>
        public int BillNum
        {
            set
            {
                _billnum = value;
            }
            get
            {
                return _billnum;
            }
        }
        /// <summary>
        /// ��λ����
        /// </summary>
        public int UnitNum
        {
            set
            {
                _unitnum = value;
            }
            get
            {
                return _unitnum;
            }
        }
        /// <summary>
        /// ��С��λ
        /// </summary>
        public int LeastUnit
        {
            set
            {
                _leastunit = value;
            }
            get
            {
                return _leastunit;
            }
        }
        /// <summary>
        /// �Ǽ�ʱ��
        /// </summary>
        public DateTime RegTime
        {
            set
            {
                _regtime = value;
            }
            get
            {
                return _regtime;
            }
        }
        /// <summary>
        /// �跽����
        /// </summary>
        public decimal DebitNum
        {
            set
            {
                _debitnum = value;
            }
            get
            {
                return _debitnum;
            }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public decimal LenderNum
        {
            set
            {
                _lendernum = value;
            }
            get
            {
                return _lendernum;
            }
        }
        /// <summary>
        /// �������
        /// </summary>
        public decimal OverNum
        {
            set
            {
                _overnum = value;
            }
            get
            {
                return _overnum;
            }
        }
        /// <summary>
        /// �跽���
        /// </summary>
        public decimal DebitFee
        {
            set
            {
                _debitfee = value;
            }
            get
            {
                return _debitfee;
            }
        }
        /// <summary>
        /// �������
        /// </summary>
        public decimal LenderFee
        {
            set
            {
                _lenderfee = value;
            }
            get
            {
                return _lenderfee;
            }
        }
        /// <summary>
        /// ���
        /// </summary>
        public decimal BalanceFee
        {
            set
            {
                _balancefee = value;
            }
            get
            {
                return _balancefee;
            }
        }
        /// <summary>
        /// �½��ʶ
        /// </summary>
        public int Balance_Flag
        {
            set
            {
                _balance_flag = value;
            }
            get
            {
                return _balance_flag;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int AccountHistoryID
        {
            set
            {
                _accounthistoryid = value;
            }
            get
            {
                return _accounthistoryid;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int MakerDicID
        {
            set
            {
                _makerdicid = value;
            }
            get
            {
                return _makerdicid;
            }
        }
        /// <summary>
        /// ������ʷ��ʶ
        /// </summary>
        public YP_AccountHis AccountHistory
        {
            set
            {
                _accounthistory = value;
            }
            get
            {
                return _accounthistory;
            }
        }
        /// <summary>
        /// ҩƷ������Ϣ
        /// </summary>
        public YP_MakerDic MakerDic
        {
            set
            {
                _makerdic = value;
            }
            get
            {
                return _makerdic;
            }
        }
        /// <summary>
        /// ������Ϣ
        /// </summary>
        public int DeptID
        {
            set
            {
                _deptid = value;
            }
            get
            {
                return _deptid;
            }
        }

        public int OrderID
        {
            set
            {
                _orderid = value;
            }
            get
            {
                return _orderid;
            }
        }
        #endregion Model

    }
}

