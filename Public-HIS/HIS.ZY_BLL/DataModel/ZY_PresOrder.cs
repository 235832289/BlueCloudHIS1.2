using System;
namespace HIS.ZY_BLL.DataModel
{
	/// <summary>
	/// ������ϸ��
	/// </summary>
    public partial class ZY_PresOrder : HIS.ZY_BLL.DataModel.IZY_PresOrder
	{
		#region Model
        #region 
        private int _presorderid;
		private int _patid;
		private int _patlistid;
		private int _presmasterid;
		private int _itemid;
		private string _itemtype;
		private string _prestype;
		private string _itemname;
		private string _standard;
        private string _PackUnit;
		private string _unit;
		private decimal _relationnum;
		private decimal _buy_price;
		private decimal _sell_price;
		private decimal _amount;
		private int _presamount;
		private decimal _tolal_fee;
		private string _presdeptcode;
		private string _presdoccode;
		private string _execdeptcode;
		private string _chargecode;
		private DateTime _presdate;
		private DateTime _markdate;
		private DateTime _costdate;
		private int _order_flag;
		private int _charge_flag;
		private int _drug_flag;
		private int _delete_flag;
		private int _oldid;
		private int _record_flag;
		private int _costmasterid;
		private int _cost_flag;
		private int _passid;
        private decimal _comp_money;
        private int _group_id;
        private int _order_id;
        private int _order_type;
        #endregion
        /// <summary>
		/// 
		/// </summary>
		public int PresOrderID
		{
			set{ _presorderid=value;}
			get{return _presorderid;}
		}
		/// <summary>
		/// ID
		/// </summary>
		public int PatID
		{
			set{ _patid=value;}
			get{return _patid;}
		}
		/// <summary>
		/// סԺ����ID
		/// </summary>
		public int PatListID
		{
			set{ _patlistid=value;}
			get{return _patlistid;}
		}
		/// <summary>
		/// ��������ID
		/// </summary>
		public int PresMasterID
		{
			set{ _presmasterid=value;}
			get{return _presmasterid;}
		}
		/// <summary>
		/// ��ĿID
		/// </summary>
		public int ItemID
		{
			set{ _itemid=value;}
			get{return _itemid;}
		}
		/// <summary>
		/// ��Ŀ���ͣ�����ĿID��
		/// </summary>
		public string ItemType
		{
			set{ _itemtype=value;}
			get{return _itemtype;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string PresType
		{
			set{ _prestype=value;}
			get{return _prestype;}
		}
		/// <summary>
		/// ��Ŀ����
		/// </summary>
		public string ItemName
		{
			set{ _itemname=value;}
			get{return _itemname;}
		}
		/// <summary>
		/// ���
		/// </summary>
		public string Standard
		{
			set{ _standard=value;}
			get{return _standard;}
		}
        /// <summary>
        /// ��װ��λ
        /// </summary>
        public string PackUnit
        {
            set { _PackUnit = value; }
            get { return _PackUnit; }
        }
		/// <summary>
		/// ��λ
		/// </summary>
		public string Unit
		{
			set{ _unit=value;}
			get{return _unit;}
		}
		/// <summary>
		/// ����ϵ��
		/// </summary>
		public decimal RelationNum
		{
			set{ _relationnum=value;}
			get{return _relationnum;}
		}
		/// <summary>
		/// ������
		/// </summary>
		public decimal Buy_Price
		{
			set{ _buy_price=value;}
			get{return _buy_price;}
		}
		/// <summary>
		/// ���ۼ�
		/// </summary>
		public decimal Sell_Price
		{
			set{ _sell_price=value;}
			get{return _sell_price;}
		}
		/// <summary>
		/// ������
		/// </summary>
		public decimal Amount
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		/// <summary>
		/// ��ҩ����
		/// </summary>
		public int PresAmount
		{
			set{ _presamount=value;}
			get{return _presamount;}
		}
		/// <summary>
		/// �ܷ���
		/// </summary>
		public decimal Tolal_Fee
		{
			set{ _tolal_fee=value;}
			get{return _tolal_fee;}
		}
		/// <summary>
		/// �������Ҵ���(�������ڿ��ҡ���¼ת�ƿ���)
		/// </summary>
		public string PresDeptCode
		{
			set{ _presdeptcode=value;}
			get{return _presdeptcode;}
		}
		/// <summary>
		/// ����ҽ������
		/// </summary>
		public string PresDocCode
		{
			set{ _presdoccode=value;}
			get{return _presdoccode;}
		}
		/// <summary>
		/// ִ�п��Ҵ���
		/// </summary>
		public string ExecDeptCode
		{
			set{ _execdeptcode=value;}
			get{return _execdeptcode;}
		}
		/// <summary>
		/// �����˴���
		/// </summary>
		public string ChargeCode
		{
			set{ _chargecode=value;}
			get{return _chargecode;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public DateTime PresDate
		{
			set{ _presdate=value;}
			get{return _presdate;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public DateTime MarkDate
		{
			set{ _markdate=value;}
			get{return _markdate;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public DateTime CostDate
		{
			set{ _costdate=value;}
			get{return _costdate;}
		}
		/// <summary>
		/// �����ʶ
		/// </summary>
		public int Order_Flag
		{
			set{ _order_flag=value;}
			get{return _order_flag;}
		}
		/// <summary>
		/// �Ƿ����
		/// </summary>
		public int Charge_Flag
		{
			set{ _charge_flag=value;}
			get{return _charge_flag;}
		}
		/// <summary>
		/// �Ƿ�ҩ
		/// </summary>
		public int Drug_Flag
		{
			set{ _drug_flag=value;}
			get{return _drug_flag;}
		}
		/// <summary>
		/// �Ƿ���Ч
		/// </summary>
		public int Delete_Flag
		{
			set{ _delete_flag=value;}
			get{return _delete_flag;}
		}
		/// <summary>
		/// ��ID
		/// </summary>
		public int OldID
		{
			set{ _oldid=value;}
			get{return _oldid;}
		}
		/// <summary>
		/// ��¼״̬
		/// </summary>
		public int Record_Flag
		{
			set{ _record_flag=value;}
			get{return _record_flag;}
		}
		/// <summary>
		/// ��������ID
		/// </summary>
		public int CostMasterID
		{
			set{ _costmasterid=value;}
			get{return _costmasterid;}
		}
		/// <summary>
		/// �����ʶ
		/// </summary>
		public int Cost_Flag
		{
			set{ _cost_flag=value;}
			get{return _cost_flag;}
		}
		/// <summary>
		/// �ϴ�ID
		/// </summary>
		public int PassID
		{
			set{ _passid=value;}
			get{return _passid;}
		}
        /// <summary>
        /// ũ�ϲ�������
        /// </summary>
        public decimal Comp_Money
        {
            get
            {
                return _comp_money;
            }
            set
            {
                _comp_money = value;
            }
        }
        public int order_id
        {
            get
            {
                return _order_id;
            }
            set
            {
                _order_id = value;
            }
        }
        public int group_id
        {
            get
            {
                return _group_id;
            }
            set
            {
                _group_id = value;
            }
        }
        public int order_type
        {
            get
            {
                return _order_type;
            }
            set
            {
                _order_type = value;
            }
        }
		#endregion Model


        #region IZY_PresOrder ��Ա


        public void BackPres(System.Collections.Generic.List<IZY_PresOrder> zyPresOrderList)
        {
            throw new NotImplementedException();
        }

        public void BackPres(int zypresorderid, IZY_PresOrder zyPresOrder)
        {
            throw new NotImplementedException();
        }

        public void SavePres(System.Collections.Generic.List<IZY_PresOrder> zyPresOrderList)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

