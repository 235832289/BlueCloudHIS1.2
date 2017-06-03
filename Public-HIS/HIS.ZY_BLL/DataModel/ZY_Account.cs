using System;
namespace HIS.ZY_BLL.DataModel
{
	/// <summary>
	/// ������
	/// </summary>
    public partial class ZY_Account
	{

		#region Model
		private int _accountid;
        private int _accountType;
		private DateTime _lastdate;
        private decimal _wticketfee;
        private decimal _bticketfee;
		private int _wticketnum;
		private int _bticketnum;
		private decimal _total_fee;
		private decimal _cash_fee;
		private decimal _pos_fee;
		private string _accountcode;
		private DateTime _accountdate;
        private decimal _costFee;
        private decimal _faoverFee;
        private int _printNum;
		/// <summary>
		/// ID
		/// </summary>
		public int AccountID
		{
			set{ _accountid=value;}
			get{return _accountid;}
		}

        /// <summary>
        /// ��������
        /// </summary>
        public int AccountType
        {
            set { _accountType = value; }
            get { return _accountType; }
        }

		/// <summary>
		/// ��һ�ν���ʱ��
		/// </summary>
		public DateTime LastDate
		{
			set{ _lastdate=value;}
			get{return _lastdate;}
		}
        /// <summary>
        /// ��ЧƱ���ܶ�
        /// </summary>
        public decimal WTicketFee
        {
            set { _wticketfee = value; }
            get { return _wticketfee; }
        }
		/// <summary>
		/// ��ЧƱ����
		/// </summary>
		public int WTicketNum
		{
			set{ _wticketnum=value;}
			get{return _wticketnum;}
		}
        /// <summary>
        /// ��ЧƱ���ܶ�
        /// </summary>
        public decimal BTicketFee
        {
            set { _bticketfee = value; }
            get { return _bticketfee; }
        }
		/// <summary>
		/// ��ЧƱ����
		/// </summary>
		public int BTicketNum
		{
			set{ _bticketnum=value;}
			get{return _bticketnum;}
		}
		/// <summary>
		/// �ܷ���
		/// </summary>
		public decimal Total_Fee
		{
			set{ _total_fee=value;}
			get{return _total_fee;}
		}
		/// <summary>
		/// �ֽ��ܶ�
		/// </summary>
		public decimal Cash_Fee
		{
			set{ _cash_fee=value;}
			get{return _cash_fee;}
		}
		/// <summary>
		/// pos�ܶ�
		/// </summary>
		public decimal POS_Fee
		{
			set{ _pos_fee=value;}
			get{return _pos_fee;}
		}
		/// <summary>
		/// �����˴���
		/// </summary>
		public string AccountCode
		{
			set{ _accountcode=value;}
			get{return _accountcode;}
		}
		/// <summary>
		/// ����ʱ��
		/// </summary>
		public DateTime AccountDate
		{
			set{ _accountdate=value;}
			get{return _accountdate;}
		}
        /// <summary>
        /// ���˷���
        /// </summary>
        public decimal CostFee
        {
            set { _costFee = value; }
            get { return _costFee; }
        }
        /// <summary>
        /// �Żݷ���
        /// </summary>
        public decimal FaoverFee
        {
            set { _faoverFee = value; }
            get { return _faoverFee; }
        }
        /// <summary>
        /// ��ӡ����
        /// </summary>
        public int PrintNum
        {
            set { _printNum = value; }
            get { return _printNum; }
        }
        
		#endregion Model

	}
}

