using System;

namespace HIS.MZ_BLL.Print
{
	/// <summary>
	/// IInvoice ��ժҪ˵����
	/// </summary>
	public interface IInvoice
	{
		/// <summary>
		/// ��Ʊ��
		/// </summary>
		string InvoiceNo{ get; set;}
		/// <summary>
		/// ��������
		/// </summary>
		string PatientName{ get; set;}
		/// <summary>
		/// ����
		/// </summary>
		string DepartmentName{ get; set;}
		/// <summary>
		/// ��
		/// </summary>
		int Year{ get; set;}
		/// <summary>
		/// ��
		/// </summary>
		int Month{ get; set;}
		/// <summary>
		/// ��
		/// </summary>
		int Day{ get; set;}
		/// <summary>
		/// �տ�Ա
		/// </summary>
		string Payee{ get ; set ;}
		/// <summary>
		/// �ϼƽ��(Сд)
		/// </summary>
		decimal TotalMoneyNum{ get; set; }
		/// <summary>
		/// �ϼƽ��(��д)
		/// </summary>
		string TotalMoneyCN{ get ; set;}
        /// <summary>
        /// ������Ϣ
        /// </summary>
        string OtherInfo
        {
            get;
            set;
        }
		/// <summary>
		/// ��ӡ
		/// </summary>
		void Print();
        /// <summary>
        /// Ԥ��
        /// </summary>
        void Preview();
	}
}
