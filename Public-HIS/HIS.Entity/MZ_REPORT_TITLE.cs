using System;
namespace HIS.Model
{
	/// <summary>
	/// ʵ����MZ_REPORT_TITLE ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class MZ_REPORT_TITLE
	{
		public MZ_REPORT_TITLE()
		{}
		#region Model
		private string _report_name;
		private string _title_name;
		private int _sortno;
		private int _fixcol;
		/// <summary>
		/// 
		/// </summary>
		public string REPORT_NAME
		{
			set{ _report_name=value;}
			get{return _report_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TITLE_NAME
		{
			set{ _title_name=value;}
			get{return _title_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SORTNO
		{
			set{ _sortno=value;}
			get{return _sortno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int FIXCOL
		{
			set{ _fixcol=value;}
			get{return _fixcol;}
		}
		#endregion Model

	}
}

