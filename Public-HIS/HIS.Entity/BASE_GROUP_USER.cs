using System;
namespace HIS.Model
{
	/// <summary>
	/// ʵ����BASE_GROUP_USER ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class BASE_GROUP_USER
	{
		public BASE_GROUP_USER()
		{}
		#region Model
		private int _id;
		private int _user_id;
		private int _group_id;
		private string _memo;
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
		public int USER_ID
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int GROUP_ID
		{
			set{ _group_id=value;}
			get{return _group_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MEMO
		{
			set{ _memo=value;}
			get{return _memo;}
		}
		#endregion Model

	}
}

