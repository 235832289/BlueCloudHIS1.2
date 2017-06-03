using System;
namespace HIS.Model
{
	/// <summary>
	/// ʵ����BASE_ROLE_DOCTOR ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class BASE_ROLE_DOCTOR
	{
		public BASE_ROLE_DOCTOR()
		{}
		#region Model
		private int  _doc_id;
        private int _employee_id;
		private int _dept_id;
		private string _ys_code;
		private int _cf_right;
		private int _mz_right;
		private int _dm_right;
		private string _ys_typeid;
		private string _password;
		/// <summary>
		/// 
		/// </summary>
        public int DOC_ID
		{
			set{ _doc_id=value;}
			get{return _doc_id;}
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
		public int DEPT_ID
		{
			set{ _dept_id=value;}
			get{return _dept_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YS_CODE
		{
			set{ _ys_code=value;}
			get{return _ys_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CF_RIGHT
		{
			set{ _cf_right=value;}
			get{return _cf_right;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int MZ_RIGHT
		{
			set{ _mz_right=value;}
			get{return _mz_right;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int DM_RIGHT
		{
			set{ _dm_right=value;}
			get{return _dm_right;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YS_TYPEID
		{
			set{ _ys_typeid=value;}
			get{return _ys_typeid;}
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

