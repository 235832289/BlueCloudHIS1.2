using System;
namespace HIS.Model
{
	/// <summary>
	/// ʵ����MZ_INVOICE ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class MZ_INVOICE
	{
		public MZ_INVOICE()
		{}
		#region Model
		private int _id;
		private int _invoice_type;
		private int _employee_id;
		private int _start_no;
		private int _end_no;
		private int _current_no;
		private int _status;
		private DateTime _allot_date;
		private int _allot_user;
        private string _perfChar;

        public string PerfChar
        {
            get
            {
                return _perfChar;
            }
            set
            {
                _perfChar = value;
            }
        }
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int INVOICE_TYPE
		{
			set{ _invoice_type=value;}
			get{return _invoice_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int EMPLOYEE_ID
		{
			set{ _employee_id=value;}
			get{return _employee_id;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		public int START_NO
		{
			set{ _start_no=value;}
			get{return _start_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int END_NO
		{
			set{ _end_no=value;}
			get{return _end_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CURRENT_NO
		{
			set{ _current_no=value;}
			get{return _current_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int STATUS
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ALLOT_DATE
		{
			set{ _allot_date=value;}
			get{return _allot_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ALLOT_USER
		{
			set{ _allot_user=value;}
			get{return _allot_user;}
		}
		#endregion Model

	}
}

