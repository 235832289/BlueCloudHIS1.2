using System;
namespace HIS.Model
{
    /// <summary>
    /// �������
    /// </summary>
	public class Mz_Doc_CommonDiagnosis
    {
        /// <summary>
        /// �������
        /// </summary>
        public Mz_Doc_CommonDiagnosis()
        {
        }

        #region Model
        private int _commondiagnosisid;    //�������ID
        private string _diagnosis_code;  //��ϴ���
        private string _diagnosis_name;  //�������
        private string _py_code;         //ƴ����
        private string _wb_code;         //�����
        private int _record_doc;         //����ҽ��
        private int _frequency;          //ʹ��Ƶ��
        private int _delete_bit;         //ɾ����־

        /// <summary>
        /// �������ID
		/// </summary>
		public int CommonDiagnosisId
		{
            get { return _commondiagnosisid; }
            set { _commondiagnosisid = value; }

		}

		/// <summary>
        /// ��ϴ���
		/// </summary>
		public string Diagnosis_Code
		{
			get{return _diagnosis_code;}
			set{_diagnosis_code = value ;}

		}
		
		/// <summary>
        /// �������
		/// </summary>
		public string Diagnosis_Name
		{
			get{return _diagnosis_name;}
			set{_diagnosis_name = value ;}

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
        /// ����ҽ��
		/// </summary>
		public int Record_Doc
		{
			get{return _record_doc;}
			set{_record_doc = value ;}

		}
		
		/// <summary>
        /// ʹ��Ƶ��
		/// </summary>
		public int Frequency
		{
			get{return _frequency;}
			set{_frequency = value ;}

		}
		
		/// <summary>
        /// ɾ����־
		/// </summary>
		public int Delete_Bit
		{
			get{return _delete_bit;}
			set{_delete_bit = value ;}

        }
        #endregion Model
    }
}
