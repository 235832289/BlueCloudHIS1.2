using System;
namespace HIS.Model
{
	/// <summary>
	/// ʵ����BASE_STAT_ZYKJ ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class BASE_STAT_ZYKJ
	{
		public BASE_STAT_ZYKJ()
		{}
		#region Model
		private string _code;
		private string _item_name;
		private int _valid_flag;
		/// <summary>
		/// 
		/// </summary>
		public string CODE
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ITEM_NAME
		{
			set{ _item_name=value;}
			get{return _item_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int VALID_FLAG
		{
			set{ _valid_flag=value;}
			get{return _valid_flag;}
		}
		#endregion Model

	}
}

