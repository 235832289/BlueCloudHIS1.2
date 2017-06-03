using System;
namespace HIS.Model
{
    /// <summary>
    /// ҽ�������
    /// </summary>
    public class Mz_Doc_Medical_Apply
	{
		private int _applyid;
		/// <summary>
        /// ����ID
		/// </summary>
		public int ApplyId
		{
			get{return _applyid;}
			set{_applyid = value ;}

		}
		private int _patid;
		/// <summary>
        /// ����ID
		/// </summary>
		public int PatId
		{
			get{return _patid;}
			set{_patid = value ;}

		}
		private int _patlistid;
		/// <summary>
        /// ����ID
		/// </summary>
		public int PatListId
		{
			get{return _patlistid;}
			set{_patlistid = value ;}

		}
		private int _preslistid;
		/// <summary>
        /// ������ϸID
		/// </summary>
		public int PresListId
		{
			get{return _preslistid;}
			set{_preslistid = value ;}

		}
		private int _item_id;
		/// <summary>
        /// ��ĿID
		/// </summary>
		public int Item_Id
		{
			get{return _item_id;}
			set{_item_id = value ;}

		}
		private string _item_name;
		/// <summary>
        /// ��Ŀ����
		/// </summary>
		public string Item_Name
		{
			get{return _item_name;}
			set{_item_name = value ;}

		}
        private int _apply_type;
        /// <summary>
        /// ҽ���������ͣ�0=���飬1=��飬2=���ƣ�
        /// </summary>
        public int Apply_Type
        {
            get { return _apply_type; }
            set { _apply_type = value; }

        }
        private int _medical_class;
        /// <summary>
        /// ҽ����Ŀ����
        /// </summary>
        public int Medical_Class
        {
            get { return _medical_class; }
            set { _medical_class = value; }

        }
		private string _apply_content;
		/// <summary>
        /// ��������
		/// </summary>
		public string Apply_Content
		{
			get{return _apply_content;}
			set{_apply_content = value ;}

		}
		private int _apply_doc;
		/// <summary>
        /// ����ҽ��
		/// </summary>
		public int Apply_Doc
		{
			get{return _apply_doc;}
			set{_apply_doc = value ;}

		}
		private int _apply_dept;
		/// <summary>
        /// �������
		/// </summary>
		public int Apply_Dept
		{
			get{return _apply_dept;}
			set{_apply_dept = value ;}

		}
		private DateTime _apply_date;
		/// <summary>
        /// ����ʱ��
		/// </summary>
		public DateTime Apply_Date
		{
			get{return _apply_date;}
			set{_apply_date = value ;}

		}
		private int _apply_status;
		/// <summary>
        /// ����״̬
		/// </summary>
		public int Apply_Status
		{
			get{return _apply_status;}
			set{_apply_status = value ;}

		}
		private string _memo;
		/// <summary>
        /// ��ע
		/// </summary>
		public string Memo
		{
			get{return _memo;}
			set{_memo = value ;}

		}
	}
}
