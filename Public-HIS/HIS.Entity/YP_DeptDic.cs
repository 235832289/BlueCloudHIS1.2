using System;
namespace HIS.Model
{
	/// <summary>
	///ҩ������
	/// </summary>
	public class YP_DeptDic
	{
		public YP_DeptDic()
		{}
		#region Model
		private int _deptdicid;
		private string _deptname;
		private string _depttype1;
		private string _depttype2;
		private int _use_flag;
		private int _deptid;
		/// <summary>
		/// ҩ�����ңɣ�
		/// </summary>
		public int DeptDicID
		{
			set
            {
                _deptdicid=value;
            }
			get
            {
                return _deptdicid;
            }
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string DeptName
		{
			set
            { 
                _deptname=value;
            }
			get
            {
                return _deptname;
            }
		}
		/// <summary>
		/// �������ͣ�
		/// </summary>
		public string DeptType1
		{
			set
            {
                _depttype1=value;
            }
			get
            {
                return _depttype1;
            }
		}
		/// <summary>
		/// �������ͣ�
		/// </summary>
		public string DeptType2
		{
			set
            {
                _depttype2=value;
            }
			get
            {
                return _depttype2;
            }
		}
		/// <summary>
		/// ʹ�ñ�ʶ
		/// </summary>
		public int Use_Flag
		{
			set
            {
                _use_flag=value;
            }
			get
            {
                return _use_flag;
            }
		}
		/// <summary>
		/// ���ţɣ�
		/// </summary>
		public int DeptID
		{
			set
            {
                _deptid=value;
            }
			get
            {
                return _deptid;
            }
		}
		#endregion Model

	}
}

