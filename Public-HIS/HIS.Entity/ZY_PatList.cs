using System;
namespace HIS.Model
{
	/// <summary>
	/// סԺ����
	/// </summary>
	public class ZY_PatList
	{
		public ZY_PatList()
		{}
		#region Model
		private int _patlistid;
		private string _cureno;
		private int _patid;
        private string _patientcode;
		private string _curedeptcode;
		private string _curedoccode;
		private string _origindeptcode;
		private string _origindoccode;
		private string _pattype;
		private string _diseasecode;
		private string _diseasename;
		private DateTime _curedate;
		private string _currdeptcode;
		private string _bedcode;
		private string _curestate;
		private int _out_flag;
		private string _outdiagncode;
		private string _outdiagnname;
		private DateTime _outdate;
		private int _realivenum;
		private DateTime _markdate;
		private string _markempcode;
        private string _Nccm_NO;
        private string _DbName;
        private decimal _DbFee;
        private PatientInfo _patientInfo;
		/// <summary>
		/// ID
        /// 
		/// </summary>
		public int PatListID
		{
			set{ _patlistid=value;}
			get{return _patlistid;}
		}
		/// <summary>
        /// סԺ��
		/// </summary>
		public string CureNo
		{
			set{ _cureno=value;}
			get{return _cureno;}
		}
		/// <summary>
        /// ����ID
		/// </summary>
		public int PatID
		{
			set{ _patid=value;}
			get{return _patid;}
		}
        /// <summary>
        /// �������ʹ��루ҽ����ũ�ϡ��Էѵȣ�
        /// </summary>
        public string PatientCode
        {
            set { _patientcode = value; }
            get { return _patientcode; }
        }
		/// <summary>
        /// ��Ժ���Ҵ���
		/// </summary>
		public string CureDeptCode
		{
			set{ _curedeptcode=value;}
			get{return _curedeptcode;}
		}
		/// <summary>
        /// ����ҽ������
		/// </summary>
		public string CureDocCode
		{
			set{ _curedoccode=value;}
			get{return _curedoccode;}
		}
		/// <summary>
        /// ������Ҵ���
		/// </summary>
		public string OriginDeptCode
		{
			set{ _origindeptcode=value;}
			get{return _origindeptcode;}
		}
		/// <summary>
        /// ����ҽ������
		/// </summary>
		public string OriginDocCode
		{
			set{ _origindoccode=value;}
			get{return _origindoccode;}
		}
		/// <summary>
        /// ��������
		/// </summary>
		public string PatType
		{
			set{ _pattype=value;}
			get{return _pattype;}
		}
		/// <summary>
        /// ��������
		/// </summary>
		public string DiseaseCode
		{
			set{ _diseasecode=value;}
			get{return _diseasecode;}
		}
		/// <summary>
        /// ��������
		/// </summary>
		public string DiseaseName
		{
			set{ _diseasename=value;}
			get{return _diseasename;}
		}
		/// <summary>
        /// ��Ժ����
		/// </summary>
		public DateTime CureDate
		{
			set{ _curedate=value;}
			get{return _curedate;}
		}
		/// <summary>
        /// ��ǰ���Ҵ���(��Ժ����)
		/// </summary>
		public string CurrDeptCode
		{
			set{ _currdeptcode=value;}
			get{return _currdeptcode;}
		}
		/// <summary>
        /// ��λ����
		/// </summary>
		public string BedCode
		{
			set{ _bedcode=value;}
			get{return _bedcode;}
		}
		/// <summary>
        /// ��Ժ״̬������Σ�ء�һ�㡢������
		/// </summary>
		public string CureState
		{
			set{ _curestate=value;}
			get{return _curestate;}
		}
		/// <summary>
        /// ��Ժ״̬����ת��
		/// </summary>
		public int Out_Flag
		{
			set{ _out_flag=value;}
			get{return _out_flag;}
		}
		/// <summary>
        /// ��Ժ��ϴ���
		/// </summary>
		public string OutDiagnCode
		{
			set{ _outdiagncode=value;}
			get{return _outdiagncode;}
		}
		/// <summary>
        /// ��Ժ�������
		/// </summary>
		public string OutDiagnName
		{
			set{ _outdiagnname=value;}
			get{return _outdiagnname;}
		}
		/// <summary>
        /// ��Ժʱ��
		/// </summary>
		public DateTime OutDate
		{
			set{ _outdate=value;}
			get{return _outdate;}
		}
		/// <summary>
        /// ʵ��סԺ����
		/// </summary>
		public int ReaLiveNum
		{
			set{ _realivenum=value;}
			get{return _realivenum;}
		}
		/// <summary>
        /// �Ǽ�ʱ��
		/// </summary>
		public DateTime MarkDate
		{
			set{ _markdate=value;}
			get{return _markdate;}
		}
		/// <summary>
        /// �Ǽ���
		/// </summary>
		public string MarkEmpCode
		{
			set{ _markempcode=value;}
			get{return _markempcode;}
		}
        /// <summary>
        /// ������Ϣ
        /// </summary>
        public PatientInfo PatientInfo
        {
            set { _patientInfo = value; }
            get
            {
                if (_patientInfo == null)
                    _patientInfo = HIS.SYSTEM.Core.BindEntity<PatientInfo>.CreateInstanceDAL(HIS.SYSTEM.Core.BaseBLL.oleDb).GetModel(PatID);
                return _patientInfo;
            }
        }
        /// <summary>
        /// ũ�ϱ���
        /// </summary>
        public string Nccm_NO
        {
            get
            {
                return _Nccm_NO;
            }
            set
            {
                _Nccm_NO = value;
            }
        }
        /// <summary>
        /// ������
        /// </summary>
        public string DbName
        {
            get
            {
                return _DbName;
            }
            set
            {
                _DbName = value;
            }
        }
        /// <summary>
        /// �������
        /// </summary>
        public decimal DbFee
        {
            get
            {
                return _DbFee;
            }
            set
            {
                _DbFee = value;
            }
        }
		#endregion Model

	}
}

