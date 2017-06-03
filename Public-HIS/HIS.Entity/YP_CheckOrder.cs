using System;
namespace HIS.Model
{
	/// <summary>
	/// �̴���ϸ
	/// </summary>
	public class YP_CheckOrder:BillOrder,ICloneable
	{
		public YP_CheckOrder()
		{}
		#region Model
		private int _checkorderid;
		private int _storageid;
		private YP_Storage _storage;
		private int _deptid;

		private int _makerdicid;
		private int _billnum;
		private decimal _checknum;
		private decimal _cktradefee;
		private decimal _ckretailfee;
		private decimal _factnum;
		private decimal _fttradefee;
		private decimal _ftretailfee;
		private int _leastunitid;
		private YP_UnitDic _leastunit;
		private int _unitnum;
		private int _audit_flag;
		private DateTime _billtime;
		private decimal _retailprice;
		private decimal _tradeprice;
		private string _groupnum;
		private int _mastercheckid;
		private YP_CheckMaster _mastercheck;
		private string _batchNum;
        private DateTime _validityDate;

        public object Clone()
        {
            YP_CheckOrder newOrder = new YP_CheckOrder();
            newOrder._audit_flag = _audit_flag;
            newOrder._batchNum = _batchNum;
            newOrder._billnum = _billnum;
            newOrder._billtime = _billtime;
            newOrder._checknum = _checknum;
            newOrder._checkorderid = _checkorderid;
            newOrder._ckretailfee = _ckretailfee;
            newOrder._cktradefee = _cktradefee;
            newOrder._deptid = _deptid;
            newOrder._factnum = _factnum;
            newOrder._ftretailfee = _ftretailfee;
            newOrder._fttradefee = _fttradefee;
            newOrder._groupnum = _groupnum;
            newOrder._leastunitid = _leastunitid;
            newOrder._makerdicid = _makerdicid;
            newOrder._mastercheckid = _mastercheckid;
            newOrder._retailprice = _retailprice;
            newOrder._storageid = _storageid;
            newOrder._tradeprice = _tradeprice;
            newOrder._unitnum = _unitnum;
            newOrder.ValidityDate = _validityDate;
            return newOrder;
        }

		/// <summary>
		/// �̴���ϸ��ʶID
		/// </summary>
		public int CheckOrderID
		{
			set{ _checkorderid=value;}
			get{return _checkorderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int StorageID
		{
			set{ _storageid=value;}
			get{return _storageid;}
		}
		/// <summary>
		/// �����Ϣ
		/// </summary>
        public YP_Storage Storage
		{
			set{ _storage=value;}
			get{return _storage;}
		}
		/// <summary>
		/// ������Ϣ
		/// </summary>
		public int DeptID
		{
			set{ _deptid=value;}
			get{return _deptid;}
		}
		/// <summary>
		/// ҩƷ������Ϣ
		/// </summary>
		public int MakerDicID
		{
			set{ _makerdicid=value;}
			get{return _makerdicid;}
		}
		/// <summary>
		/// ���ݺ�
		/// </summary>
		public int BillNum
		{
			set{ _billnum=value;}
			get{return _billnum;}
		}
		/// <summary>
		/// �̵�����
		/// </summary>
		public decimal CheckNum
		{
			set{ _checknum=value;}
			get{return _checknum;}
		}
		/// <summary>
		/// �̴��������
		/// </summary>
		public decimal CKTradeFee
		{
			set{ _cktradefee=value;}
			get{return _cktradefee;}
		}
		/// <summary>
		/// �̴����۽��
		/// </summary>
		public decimal CKRetailFee
		{
			set{ _ckretailfee=value;}
			get{return _ckretailfee;}
		}
		/// <summary>
		/// ʵ������
		/// </summary>
		public decimal FactNum
		{
			set{ _factnum=value;}
			get{return _factnum;}
		}
		/// <summary>
		/// ʵ���������
		/// </summary>
		public decimal FTTradeFee
		{
			set{ _fttradefee=value;}
			get{return _fttradefee;}
		}
		/// <summary>
		/// ʵ�����۽��
		/// </summary>
		public decimal FTRetailFee
		{
			set{ _ftretailfee=value;}
			get{return _ftretailfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int LeastUnit
		{
			set{ _leastunitid=value;}
			get{return _leastunitid;}
		}
		/// <summary>
		/// ��С��λ
		/// </summary>
        public YP_UnitDic LeastUnitEntity
		{
			set{ _leastunit=value;}
			get{return _leastunit;}
		}
		/// <summary>
		/// ��λ����
		/// </summary>
		public int UnitNum
		{
			set{ _unitnum=value;}
			get{return _unitnum;}
		}
		/// <summary>
		/// ��˱�ʶ
		/// </summary>
		public int Audit_Flag
		{
			set{ _audit_flag=value;}
			get{return _audit_flag;}
		}
		/// <summary>
		/// ����ʱ��
		/// </summary>
		public DateTime BillTime
		{
			set{ _billtime=value;}
			get{return _billtime;}
		}
		/// <summary>
		/// ���ۼ۸�
		/// </summary>
		public decimal RetailPrice
		{
			set{ _retailprice=value;}
			get{return _retailprice;}
		}
		/// <summary>
		/// �����۸�
		/// </summary>
		public decimal TradePrice
		{
			set{ _tradeprice=value;}
			get{return _tradeprice;}
		}
		/// <summary>
		/// ҩƷ����
		/// </summary>
		public string GroupNum
		{
			set{ _groupnum=value;}
			get{return _groupnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int MasterCheckID
		{
			set{ _mastercheckid=value;}
			get{return _mastercheckid;}
		}
		/// <summary>
		/// �̵��ͷ��Ϣ
		/// </summary>
        public YP_CheckMaster MasterCheck
		{
			set{ _mastercheck=value;}
			get{return _mastercheck;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string BatchNum
		{
			set{ _batchNum=value;}
            get { return _batchNum; }
		}

        public DateTime ValidityDate
        {
            set { _validityDate = value; }
            get { return _validityDate; }
        }
		#endregion Model

	}
}

