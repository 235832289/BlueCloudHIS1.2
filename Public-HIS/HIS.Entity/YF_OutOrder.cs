using System;
namespace HIS .Model
{
    /// <summary>
    /// ������ϸ
    /// </summary>
    public class YP_OutOrder:BillOrder
    {
        public YP_OutOrder()
        {
        }
        #region Model
        private int _outstorageid;
        private int _makerdicid;
        private YP_MakerDic _makerdic;
        private int _audit_flag;
        private string _remark;
        private int _billnum;
        private decimal _tradefee;
        private decimal _retailfee;
        private decimal _tradeprice;
        private decimal _retailprice;
        private int _unitnum;
        private int _leastunitid;
        private YP_UnitDic _leastunit;
        private decimal _outnum;
        private decimal _recscale;
        private DateTime _validitydate;
        private string _productnum;
        private string _outreason;
        private int _outdeptid;
        private int _masteroutstorageid;
        private YP_OutMaster _masteroutstorage;
        private int _deptid;
        private string _outdeptname;
        /// <summary>
        /// ������ϸ��ʶ�ɣ�
        /// </summary>
        public int OutStorageID
        {
            set
            {
                _outstorageid = value;
            }
            get
            {
                return _outstorageid;
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
        /// ���ҵ��ʶ�ɣ�
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
        /// �����۸�
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
        /// ���ۼ۸�
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
        /// ��С��λ��ʶID
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
        /// ��������
        /// </summary>
        public decimal OutNum
        {
            set
            {
                _outnum = value;
            }
            get
            {
                return _outnum;
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
        /// ��������
        /// </summary>
        public string ProductNum
        {
            set
            {
                _productnum = value;
            }
            get
            {
                return _productnum;
            }
        }

        /// <summary>
        /// �������ԭ��
        /// </summary>
        public string OutReason
        {
            set
            {
                _outreason = value;
            }
            get
            {
                return _outreason;
            }
        }
        /// <summary>
        /// ������ű�ʶ�ɣ�
        /// </summary>
        public int OutDeptID
        {
            set
            {
                _outdeptid = value;
            }
            get
            {
                return _outdeptid;
            }
        }
        /// <summary>
        /// �����ͷ��ʶ
        /// </summary>
        public int MasterOutStorageID
        {
            set
            {
                _masteroutstorageid = value;
            }
            get
            {
                return _masteroutstorageid;
            }
        }
        /// <summary>
        /// �����ͷ��Ϣ
        /// </summary>
        public YP_OutMaster MasterOutStorage
        {
            set
            {
                _masteroutstorage = value;
            }
            get
            {
                return _masteroutstorage;
            }
        }
        /// <summary>
        /// ���ұ�ʶ
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

        public string OutDeptName
        {
            set
            {
                _outdeptname = value;
            }
            get
            {
                return _outdeptname;
            }
        }
        #endregion Model

    }
}

