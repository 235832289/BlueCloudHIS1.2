using System;
namespace HIS.Model
{
	/// <summary>
	/// ʵ����YP_TypeDic ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class YP_TypeDic
	{
		public YP_TypeDic()
		{}
		#region Model
		private int _typedicid;
		private string _typename;
		private string _pym;
		private string _wbm;
		/// <summary>
		/// ���ͱ�ʶID
		/// </summary>
		public int TypeDicID
		{
			set
            { 
                _typedicid=value;
            }
			get
            {
                return _typedicid;
            }
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string TypeName
		{
			set
            {
                _typename=value;
            }
			get
            {
                return _typename;
            }
		}
		/// <summary>
		/// ����ƴ����
		/// </summary>
		public string PYM
		{
			set
            {
                _pym=value;
            }
			get
            {
                return _pym;
            }
		}
		/// <summary>
		/// ���������
		/// </summary>
		public string WBM
		{
			set
            {
                _wbm=value;
            }
			get
            {
                return _wbm;
            }
		}
		#endregion Model

	}
}

