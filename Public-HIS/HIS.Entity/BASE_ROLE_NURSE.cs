using System;
namespace HIS.Model
{
	/// <summary>
	/// ʵ����BASE_ROLE_NURSE ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class BASE_ROLE_NURSE
	{
		public BASE_ROLE_NURSE()
		{}
		#region Model
        private int  _nurse_id;
		private int _dept_id;
        private int _employee_id;
		private string _password;
		/// <summary>
		/// 
		/// </summary>
        public int NURSE_ID
		{
			set{ _nurse_id=value;}
			get{return _nurse_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int DEPT_ID
		{
			set{ _dept_id=value;}
			get{return _dept_id;}
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
		public string PASSWORD
		{
			set{ _password=value;}
			get{return _password;}
		}
		#endregion Model

	}
}

