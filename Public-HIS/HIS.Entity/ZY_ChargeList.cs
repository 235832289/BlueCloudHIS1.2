using System;
namespace HIS.Model
{
	/// <summary>
	/// �շ���
	/// </summary>
	public class ZY_ChargeList
	{
		public ZY_ChargeList()
		{}
		#region Model
		private int _chargelistid;
		private int _patid;
        private int _patlistid;
		private string _cureno;
		private string _billno;
		private string _oldbillno;
		private int _feetype;
		private decimal _total_fee;
		private string _chargecode;
		private DateTime _costdate;
		private int _delete_flag;
		private int _accountid;
		private int _record_flag;
		/// <summary>
		/// ID
		/// </summary>
		public int ChargeListID
		{
			set{ _chargelistid=value;}
			get{return _chargelistid;}
		}
		/// <summary>
        /// ����ID
		/// </summary>
		public int PatID
		{
			set{ _patid=value;}
			get{return _patid;}
		}
		/// <summary>
		/// סԺ��
		/// </summary>
		public string CureNo
		{
			set{ _cureno=value;}
			get{return _cureno;}
		}
        /// <summary>
        /// סԺ����ID
        ///
        /// </summary>
        public int PatListID
        {
            set { _patlistid = value; }
            get { return _patlistid; }
        }
		/// <summary>
		/// ���ݺ�
		/// </summary>
		public string BillNo
		{
			set{ _billno=value;}
			get{return _billno;}
		}
		/// <summary>
		/// �ϵ��ݺ�
		/// </summary>
		public string OldBillNo
		{
			set{ _oldbillno=value;}
			get{return _oldbillno;}
		}
		/// <summary>
		/// ��������ֽ�or POS��
		/// </summary>
		public int FeeType
		{
			set{ _feetype=value;}
			get{return _feetype;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public decimal Total_Fee
		{
			set{ _total_fee=value;}
			get{return _total_fee;}
		}
		/// <summary>
		/// �շ��˴���
		/// </summary>
		public string ChargeCode
		{
			set{ _chargecode=value;}
			get{return _chargecode;}
		}
		/// <summary>
		/// �շ�ʱ��
		/// </summary>
		public DateTime CostDate
		{
			set{ _costdate=value;}
			get{return _costdate;}
		}
		/// <summary>
		/// �Ƿ���Ч(����ID)
		/// </summary>
		public int Delete_Flag
		{
			set{ _delete_flag=value;}
			get{return _delete_flag;}
		}
		/// <summary>
		/// �����˴���
		/// </summary>
		public int AccountID
		{
			set{ _accountid=value;}
			get{return _accountid;}
		}
		/// <summary>
		/// ��¼״̬
		/// </summary>
		public int Record_Flag
		{
			set{ _record_flag=value;}
			get{return _record_flag;}
		}
		#endregion Model

	}
}

