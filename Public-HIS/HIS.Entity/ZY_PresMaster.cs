using System;
namespace HIS.Model
{
	/// <summary>
	/// ��������
	/// </summary>
	public class ZY_PresMaster
	{
		public ZY_PresMaster()
		{}
		#region Model
		private int _presmasterid;
		private int _patid;
		private int _patlistid;
		private string _prestype;
		private decimal _total_fee;
		private int _pres_flag;
		private DateTime _presdate;
		private int _del_flag;
		/// <summary>
		/// ID
		/// </summary>
		public int PresMasterID
		{
			set{ _presmasterid=value;}
			get{return _presmasterid;}
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
		/// סԺ����iD
		/// </summary>
		public int PatListID
		{
			set{ _patlistid=value;}
			get{return _patlistid;}
		}
		/// <summary>
		/// �������ͣ���ҩor��Ŀ��
		/// </summary>
		public string PresType
		{
			set{ _prestype=value;}
			get{return _prestype;}
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
        /// �������ͣ���ʱor���ڣ�
		/// </summary>
		public int Pres_Flag
		{
			set{ _pres_flag=value;}
			get{return _pres_flag;}
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
		/// �Ƿ���Ч
		/// </summary>
		public int Del_Flag
		{
			set{ _del_flag=value;}
			get{return _del_flag;}
		}
		#endregion Model

	}
}

