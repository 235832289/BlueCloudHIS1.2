using System;
namespace HIS.Model
{
	/// <summary>
	/// ʵ����YP_ProductDic ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class YP_ProductDic
	{
		public YP_ProductDic()
		{}
		#region Model
		private int _productid;
		private string _address;
		private string _productname;
		private string _pym;
		private string _wmb;
		private string _linkname;
		private string _linkphone;
		private int _del_flag;
		/// <summary>
		/// ���ұ�ʶ
		/// </summary>
		public int ProductID
		{
			set
            { 
                _productid=value;
            }
			get
            {
                return _productid;
            }
		}
		/// <summary>
		/// �����̵�ַ
		/// </summary>
		public string Address
		{
			set
            {
                _address=value;
            }
			get
            {
                return _address;
            }
		}
		/// <summary>
		/// ����������
		/// </summary>
		public string ProductName
		{
			set
            { 
                _productname=value;
            }
			get
            {
                return _productname;
            }
		}
		/// <summary>
		/// ƴ����
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
		/// �����
		/// </summary>
		public string WMB
		{
			set
            {
                _wmb=value;
            }
			get
            {
                return _wmb;
            }
		}
		/// <summary>
		/// ��ϵ������
		/// </summary>
		public string LinkName
		{
			set
            {
                _linkname=value;
            }
			get
            {
                return _linkname;
            }
		}
		/// <summary>
		/// ��ϵ�绰
		/// </summary>
		public string LinkPhone
		{
			set
            {
                _linkphone=value;
            }
			get
            {
                return _linkphone;
            }
		}
		/// <summary>
		/// ɾ����ʶ
		/// </summary>
		public int Del_Flag
		{
			set
            { 
                _del_flag=value;
            }
			get
            {
                return _del_flag;
            }
		}
		#endregion Model

	}
}

