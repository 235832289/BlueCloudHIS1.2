using System;
namespace HIS.Model
{
	/// <summary>
	/// ʵ����YP_DoseDic ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class YP_DoseDic
	{
        /// <summary>
        /// ���캯��
        /// </summary>
		public YP_DoseDic()
		{}
		#region Model
		private int _dosedicid;
		private int _typedicid;
        private YP_TypeDic _typedic;
		private string _dosename;
		private string _pym;
		private string _wbm;
		/// <summary>
		/// ���͵��ʶID
		/// </summary>
		public int DoseDicID
		{
			set
            {
                _dosedicid=value;
            }
			get
            {
                return _dosedicid;
            }
		}
		/// <summary>
		/// ���Ͷ�Ӧ����
		/// </summary>
        public YP_TypeDic TypeDic
		{
            set 
            {
                _typedic = value; 
            }
            get 
            { 
                return _typedic; 
            }
		}
		/// <summary>
		/// 
		/// </summary>
		public int TypeDicID
		{
			set{ _typedicid=value;}
			get{return _typedicid;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string DoseName
		{
			set
            { 
                _dosename=value;
            }
			get
            {
                return _dosename;
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

