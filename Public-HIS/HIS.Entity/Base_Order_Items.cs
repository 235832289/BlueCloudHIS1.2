using System;
namespace HIS.Model
{
	public class Base_Order_Items
	{
        private int _order_id;
        private string _order_name;
        private string _order_unit;
        private int _order_type;
        private int _medical_class;
        private string _default_usage;
        private string _py_code;
        private string _wb_code;
        private string _d_code;
        private int _item_id;
        private int _tc_flag;
        private int _delete_bit;
        private DateTime _book_date;
        private DateTime _del_date;
        private string _bz;
		/// <summary>
		/// ҽ����ĿID
		/// </summary>
		public int Order_Id
		{
			get{return _order_id;}
			set{_order_id = value ;}

		}
		/// <summary>
        /// ����
		/// </summary>
		public string Order_Name
		{
			get{return _order_name;}
			set{_order_name = value ;}

		}
		/// <summary>
        /// ��λ
		/// </summary>
		public string Order_Unit
		{
			get{return _order_unit;}
			set{_order_unit = value ;}

		}
		/// <summary>
        /// ҽ������
		/// </summary>
		public int Order_Type
		{
			get{return _order_type;}
			set{_order_type = value ;}

		}
		/// <summary>
        /// ҽ����Ŀ����
		/// </summary>
		public int Medical_Class
		{
			get{return _medical_class;}
			set{_medical_class = value ;}

		}
		/// <summary>
        /// Ĭ���÷�
		/// </summary>
		public string Default_Usage
		{
			get{return _default_usage;}
			set{_default_usage = value ;}

		}
		/// <summary>
        /// ƴ����
		/// </summary>
		public string Py_Code
		{
			get{return _py_code;}
			set{_py_code = value ;}

		}
		/// <summary>
        /// �����
		/// </summary>
		public string Wb_Code
		{
			get{return _wb_code;}
			set{_wb_code = value ;}

		}
		/// <summary>
        /// ������
		/// </summary>
		public string D_Code
		{
			get{return _d_code;}
			set{_d_code = value ;}

		}
		/// <summary>
        /// �շ���Ŀ���ײ���ĿID
		/// </summary>
		public int Item_Id
		{
			get{return _item_id;}
			set{_item_id = value ;}

		}
		/// <summary>
        /// �ײͱ�־
		/// </summary>
		public int Tc_Flag
		{
			get{return _tc_flag;}
			set{_tc_flag = value ;}

		}
		/// <summary>
        /// ɾ�����
		/// </summary>
		public int Delete_Bit
		{
			get{return _delete_bit;}
			set{_delete_bit = value ;}

		}
		/// <summary>
        /// ��������
		/// </summary>
		public DateTime Book_Date
		{
			get{return _book_date;}
			set{_book_date = value ;}

		}
		/// <summary>
        /// ɾ������
		/// </summary>
		public DateTime Del_Date
		{
			get{return _del_date;}
			set{_del_date = value ;}

		}
		/// <summary>
        /// ��ע
		/// </summary>
		public string Bz
		{
			get{return _bz;}
			set{_bz = value ;}

		}
	}
}
