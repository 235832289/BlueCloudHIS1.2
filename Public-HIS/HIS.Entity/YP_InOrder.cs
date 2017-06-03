using System;
namespace HIS .Model
{
    /// <summary>
    /// ʵ����YF_InOrder ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    public class YP_InOrder:BillOrder
    {
        public YP_InOrder()
        {
        }
        #region Model
        private int _instorageid;
        private int _makerdicid;
        private YP_MakerDic _makerdic;
        private string _batchnum;
        private DateTime _validitydate;
        private decimal _recscale;
        private decimal _innum;
        private int _leastunitid;
        private YP_UnitDic _leastunit;
        private int _unitnum;
        private decimal _stockprice;
        private decimal _retailprice;
        private decimal _tradeprice;
        private decimal _stockfee;
        private decimal _retailfee;
        private decimal _tradefee;
        private int _billnum;
        private int _deptid;
        private string _remark;
        private int _audit_flag;
        private int _masterinstorageid;
        private YP_InMaster _masterinstorage;
        private string _delivernum;
        private decimal _currentnum;
        /// <summary>
        /// ����ʶID
        /// </summary>
        public int InStorageID
        {
            set
            {
                _instorageid = value;
            }
            get
            {
                return _instorageid;
            }
        }
        /// <summary>
        /// ���ұ�ʶID
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
        /// ������Ϣ
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
        /// ��������
        /// </summary>
        public string BatchNum
        {
            set
            {
                _batchnum = value;
            }
            get
            {
                return _batchnum;
            }
        }
        /// <summary>
        /// ��Ч��
        /// </summary>
        public DateTime ValidityDate
        {
            set
            {
                _validitydate = value;
            }
            get
            {
                return _validitydate;
            }
        }
        /// <summary>
        /// ����
        /// </summary>
        public decimal RecScale
        {
            set
            {
                _recscale = value;
            }
            get
            {
                return _recscale;
            }
        }
        /// <summary>
        /// �������
        /// </summary>
        public decimal InNum
        {
            set
            {
                _innum = value;
            }
            get
            {
                return _innum;
            }
        }
        /// <summary>
        /// ��С��λ��ʶ
        /// </summary>
        public int LeastUnit
        {
            set
            {
                _leastunitid = value;
            }
            get
            {
                return _leastunitid;
            }
        }
        /// <summary>
        /// ��С��λ
        /// </summary>
        public YP_UnitDic LeastUnitEntity
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
        /// ����
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
        public decimal TradePrice
        {
            set
            {
                _tradeprice = value;
            }
            get
            {
                return _tradeprice;
            }
        }
        /// <summary>
        /// �����
        /// </summary>
        public decimal StockFee
        {
            set
            {
                _stockfee = value;
            }
            get
            {
                return _stockfee;
            }
        }
        /// <summary>
        /// ���۽��
        /// </summary>
        public decimal RetailFee
        {
            set
            {
                _retailfee = value;
            }
            get
            {
                return _retailfee;
            }
        }
        /// <summary>
        /// �������
        /// </summary>
        public decimal TradeFee
        {
            set
            {
                _tradefee = value;
            }
            get
            {
                return _tradefee;
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
        /// ����ID
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
        /// <summary>
        /// ��ע
        /// </summary>
        public string Remark
        {
            set
            {
                _remark = value;
            }
            get
            {
                return _remark;
            }
        }
        /// <summary>
        /// ��˱�ʶ
        /// </summary>
        public int Audit_Flag
        {
            set
            {
                _audit_flag = value;
            }
            get
            {
                return _audit_flag;
            }
        }
        /// <summary>
        /// ����ͷ
        /// </summary>
        public int MasterInStorageID
        {
            set
            {
                _masterinstorageid = value;
            }
            get
            {
                return _masterinstorageid;
            }
        }
        /// <summary>
        /// ����ͷ
        /// </summary>
        public YP_InMaster MasterInStorage
        {
            set
            {
                _masterinstorage = value;
            }
            get
            {
                return _masterinstorage;
            }
        }
        /// <summary>
        /// �ͻ���
        /// </summary>
        public string DeliverNum
        {
            set
            {
                _delivernum = value;
            }
            get
            {
                return _delivernum;
            }
        }

        public decimal CurrentNum
        {
            set
            {
                _currentnum = value;
            }
            get
            {
                return _currentnum;
            }
        }
        #endregion Model

    }
}

