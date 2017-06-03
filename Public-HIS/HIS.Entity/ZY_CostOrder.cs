using System;
namespace HIS.Model
{
	/// <summary>
	/// ������ϸ
	/// </summary>
	public class ZY_CostOrder
	{
		public ZY_CostOrder()
		{}
		#region Model
		private int _costorderid;
		private int _patid;
		private int _patlistid;
		private int _costid;
		private string _ticketnum;
		private string _ticketcode;
		private string _bigitemcode;
		private decimal _total_fee;
		/// <summary>
		/// ID
		/// </summary>
		public int CostOrderID
		{
			set{ _costorderid=value;}
			get{return _costorderid;}
		}
		/// <summary>
		/// ����iD
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
		/// ��������id
		/// </summary>
		public int CostID
		{
			set{ _costid=value;}
			get{return _costid;}
		}
		/// <summary>
		/// ����Ʊ��ˮ��
		/// </summary>
		public string TicketNum
		{
			set{ _ticketnum=value;}
			get{return _ticketnum;}
		}
		/// <summary>
		/// ����Ʊ��
		/// </summary>
		public string TicketCode
		{
			set{ _ticketcode=value;}
			get{return _ticketcode;}
		}
		/// <summary>
		/// ����Ŀ����
		/// </summary>
		public string BigItemCode
		{
			set{ _bigitemcode=value;}
			get{return _bigitemcode;}
		}
		/// <summary>
		/// �ܷ���
		/// </summary>
		public decimal Total_Fee
		{
			set{ _total_fee=value;}
			get{return _total_fee;}
		}
		#endregion Model

	}
}

