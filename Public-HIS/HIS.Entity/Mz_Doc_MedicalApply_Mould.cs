using System;
namespace HIS.Model
{
    /// <summary>
    /// ҽ������ģ���
    /// </summary>
    public class Mz_Doc_MedicalApply_Mould
	{
		private int _id;
		/// <summary>
		///
		/// </summary>
		public int Id
		{
			get{return _id;}
			set{_id = value ;}

		}
        private int _medical_class;  //ҽ������
		/// <summary>
        /// ҽ������
		/// </summary>
        public int Medical_Class
		{
			get{return _medical_class;}
			set{_medical_class = value ;}

		}
        private string _element_name;  //Ԫ������
        /// <summary>
        /// Ԫ������
        /// </summary>
        public string Element_Name
        {
            get { return _element_name; }
            set { _element_name = value; }

        }
        private int _level;  //ģ�弶��
		/// <summary>
        /// ģ�弶��
		/// </summary>
		public int Level
		{
			get{return _level;}
			set{_level = value ;}

		}
        private int _create_emp;  //������
		/// <summary>
        /// ������
		/// </summary>
		public int Create_Emp
		{
			get{return _create_emp;}
			set{_create_emp = value ;}

		}
        private int _create_dept;  //��������
		/// <summary>
        /// ��������
		/// </summary>
		public int Create_Dept
		{
			get{return _create_dept;}
			set{_create_dept = value ;}

		}
        private string _content;  //����
		/// <summary>
        /// ����
		/// </summary>
		public string Content
		{
			get{return _content;}
			set{_content = value ;}

		}
	}
}
