using System;
namespace HIS .Model
{
    public struct DrugInfo
    {
        public string chemname;
        public string spec;
        public string productname;
        public string medicarename;
    }
    /// <summary>
    /// ʵ����YP_MakerDic ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    public class YP_MakerDic
    {
        public YP_MakerDic()
        {
        }
        #region Model
        private int _makerdicid;
        private int _specdicid;
        public DrugInfo DrugInfo;
        private string _balenum;
        private string _barcode;
        private int _productid;
        private decimal _tradeprice;
        private decimal _hretailprice;
        private decimal _retailprice;
        private string _approvenum;
        private int _validitydate;
        private int _medicaredicid;
        private decimal _ownpayscale;
        private decimal _defrecscale;
        private decimal _defstockprice;
        private int _del_flag;
        private int _ownpay_flag;
        private int _virulent_flag;
        private int _narcotic_flag;
        private int _skintest_flag;
        private int _recipe_flag;
        private int _lunacy_flag;
        private int _costly_flag;
        private int _bigtransfu_flag;
        private int _gmp_flag;
        private int _medicare_flag;
        private int _useout_flag;
        private string _remark;
        private DateTime _regtime;
        private int _getway;
        private string _unifgettype;
        private int _medi_inverse;
        public int Medi_inverse
        {
            get 
            { 
                return _medi_inverse;
            }
            set 
            {
                _medi_inverse = value; 
            }
        }
        /// <summary>
        /// ���ҵ��ʶID
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
        /// 
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
        /// ����
        /// </summary>
        public string BaleNum
        {
            set
            {
                _balenum = value;
            }
            get
            {
                return _balenum;
            }
        }
        /// <summary>
        /// ������
        /// </summary>
        public string BarCode
        {
            set
            {
                _barcode = value;
            }
            get
            {
                return _barcode;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ProductID
        {
            set
            {
                _productid = value;
            }
            get
            {
                return _productid;
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
        /// ������ۼ�
        /// </summary>
        public decimal HRetailPrice
        {
            set
            {
                _hretailprice = value;
            }
            get
            {
                return _hretailprice;
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
        /// ��׼�ĺ�
        /// </summary>
        public string ApproveNum
        {
            set
            {
                _approvenum = value;
            }
            get
            {
                return _approvenum;
            }
        }
        /// <summary>
        /// ��Ч��
        /// </summary>
        public int ValidityDate
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
        /// 
        /// </summary>
        public int MedicareDicID
        {
            set
            {
                _medicaredicid = value;
            }
            get
            {
                return _medicaredicid;
            }
        }
        /// <summary>
        /// �Ը�����
        /// </summary>
        public decimal OwnpayScale
        {
            set
            {
                _ownpayscale = value;
            }
            get
            {
                return _ownpayscale;
            }
        }
        /// <summary>
        /// Ĭ�Ͽ���
        /// </summary>
        public decimal DefRecScale
        {
            set
            {
                _defrecscale = value;
            }
            get
            {
                return _defrecscale;
            }
        }
        /// <summary>
        /// Ĭ�Ͻ���
        /// </summary>
        public decimal DefStockPrice
        {
            set
            {
                _defstockprice = value;
            }
            get
            {
                return _defstockprice;
            }
        }
        /// <summary>
        /// ɾ����ʶ
        /// </summary>
        public int Del_Flag
        {
            set
            {
                _del_flag = value;
            }
            get
            {
                return _del_flag;
            }
        }
        /// <summary>
        /// �Էѱ�ʶ
        /// </summary>
        public int OwnPay_Flag
        {
            set
            {
                _ownpay_flag = value;
            }
            get
            {
                return _ownpay_flag;
            }
        }
        /// <summary>
        /// �綾��ʶ
        /// </summary>
        public int Virulent_Flag
        {
            set
            {
                _virulent_flag = value;
            }
            get
            {
                return _virulent_flag;
            }
        }
        /// <summary>
        /// �����ʶ
        /// </summary>
        public int Narcotic_Flag
        {
            set
            {
                _narcotic_flag = value;
            }
            get
            {
                return _narcotic_flag;
            }
        }
        /// <summary>
        /// Ƥ�Ա�ʶ
        /// </summary>
        public int Skintest_Flag
        {
            set
            {
                _skintest_flag = value;
            }
            get
            {
                return _skintest_flag;
            }
        }
        /// <summary>
        /// ������ҩ
        /// </summary>
        public int Recipe_Flag
        {
            set
            {
                _recipe_flag = value;
            }
            get
            {
                return _recipe_flag;
            }
        }
        /// <summary>
        /// ����ҩƷ��ʶ
        /// </summary>
        public int Lunacy_Flag
        {
            set
            {
                _lunacy_flag = value;
            }
            get
            {
                return _lunacy_flag;
            }
        }
        /// <summary>
        /// ����ҩƷ��ʶ
        /// </summary>
        public int Costly_Flag
        {
            set
            {
                _costly_flag = value;
            }
            get
            {
                return _costly_flag;
            }
        }
        /// <summary>
        /// ����Һ��ʶ
        /// </summary>
        public int Bigtransfu_Flag
        {
            set
            {
                _bigtransfu_flag = value;
            }
            get
            {
                return _bigtransfu_flag;
            }
        }
        /// <summary>
        /// GMP��ʶ
        /// </summary>
        public int GMP_Flag
        {
            set
            {
                _gmp_flag = value;
            }
            get
            {
                return _gmp_flag;
            }
        }
        /// <summary>
        /// ҽ����ʶ
        /// </summary>
        public int Medicare_Flag
        {
            set
            {
                _medicare_flag = value;
            }
            get
            {
                return _medicare_flag;
            }
        }
        /// <summary>
        /// ����ҩƷ��ʶ
        /// </summary>
        public int UseOut_Flag
        {
            set
            {
                _useout_flag = value;
            }
            get
            {
                return _useout_flag;
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
        /// ͣ�ñ�ʶ
        /// </summary>
        public int GetWay
        {
            set
            {
                _getway = value;
            }
            get
            {
                return _getway;
            }
        }
        /// <summary>
        /// ͳ������
        /// </summary>
        public string UnifGettype
        {
            set
            {
                _unifgettype = value;
            }
            get
            {
                return _unifgettype;
            }
        }
        #endregion Model

    }
}

