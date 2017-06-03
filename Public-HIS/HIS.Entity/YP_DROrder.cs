using System;
namespace HIS .Model
{
    /// <summary>
    /// ʵ����YF_DROrder ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    public class YP_DROrder:BillOrder
    {
        public YP_DROrder()
        {
        }
        #region Model
        private int _orderdrugocid;
        private int _masterdrugocid;
        private YP_DRMaster _masterdrugoc;
        private int _invoicenum;
        private int _orderrecipeid;
        private string _inpatientid;
        private int _makerdicid;
        private YP_MakerDic _makerdic;
        private int _specdicid;
        private YP_SpecDic _specdic;
        private string _chemname;
        private int _leastunitid;
        private YP_UnitDic _leastunit;
        private int _unitnum;
        private decimal _drugocnum;
        private int _dosenum;
        private decimal _retailprice;
        private decimal _tradeprice;
        private decimal _retailfee;
        private decimal _tradefee;
        private int _drugoc_flag;
        private int _refundment_flag;
        private int _uniform_flag;
        private int _deptid;
        private int _uniformId;
        private int _curedeptid;

        /// <summary>
        /// ��������
        /// </summary>
        public int Curedeptid
        {
            get { return _curedeptid; }
            set { _curedeptid = value; }
        }
        /// <summary>
        /// ����ҩ��ϸ��ʶ�ɣ�
        /// </summary>
        public int OrderDrugOCID
        {
            set
            {
                _orderdrugocid = value;
            }
            get
            {
                return _orderdrugocid;
            }
        }
        /// <summary>
        /// ����ҩ��ͷ��Ϣ
        /// </summary>
        public YP_DRMaster MasterDrugOC
        {
            set
            {
                _masterdrugoc = value;
            }
            get
            {
                return _masterdrugoc;
            }
        }
        /// <summary>
        /// ����ҩ��ͷ��ʶ�ɣ�
        /// </summary>
        public int MasterDrugOCID
        {
            set
            {
                _masterdrugocid = value;
            }
            get
            {
                return _masterdrugocid;
            }
        }
        /// <summary>
        /// ��Ʊ��
        /// </summary>
        public int InvoiceNum
        {
            set
            {
                _invoicenum = value;
            }
            get
            {
                return _invoicenum;
            }
        }
        /// <summary>
        /// ������ϸID
        /// </summary>
        public int OrderRecipeID
        {
            set
            {
                _orderrecipeid = value;
            }
            get
            {
                return _orderrecipeid;
            }
        }
        /// <summary>
        /// סԺ��
        /// </summary>
        public string InpatientID
        {
            set
            {
                _inpatientid = value;
            }
            get
            {
                return _inpatientid;
            }
        }
        /// <summary>
        /// ���ұ�ʶ�ɣ�
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
        /// �����Ϣ
        /// </summary>
        public YP_SpecDic SpecDic
        {
            set
            {
                _specdic = value;
            }
            get
            {
                return _specdic;
            }
        }

        /// <summary>
        /// ����ʶID
        /// </summary>
        public int SpecDicID
        {
            set
            {
                _specdicid = value;
            }
            get
            {
                return _specdicid;
            }
        }
        /// <summary>
        /// ��ѧ����
        /// </summary>
        public string ChemName
        {
            set
            {
                _chemname = value;
            }
            get
            {
                return _chemname;
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
        /// ��С��λ��ʶ�ɣ�
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
        /// ����ҩ����
        /// </summary>
        public decimal DrugOCNum
        {
            set
            {
                _drugocnum = value;
            }
            get
            {
                return _drugocnum;
            }
        }
        /// <summary>
        /// ����
        /// </summary>
        public int DoseNum
        {
            set
            {
                _dosenum = value;
            }
            get
            {
                return _dosenum;
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
        /// �������
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
        /// ����ҩ��ʶ
        /// </summary>
        public int DrugOC_Flag
        {
            set
            {
                _drugoc_flag = value;
            }
            get
            {
                return _drugoc_flag;
            }
        }

        /// <summary>
        /// �˷ѱ�ʶ
        /// </summary>
        public int Refundment_Flag
        {
            set
            {
                _refundment_flag = value;
            }
            get
            {
                return _refundment_flag;
            }
        }
        /// <summary>
        /// ͳ���ʶ
        /// </summary>
        public int Uniform_Flag
        {
            set
            {
                _uniform_flag = value;
            }
            get
            {
                return _uniform_flag;
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

        public int UniformID
        {
            set
            {
                _uniformId = value;
            }
            get
            {
                return _uniformId;
            }
        }
        #endregion Model

    }
}

