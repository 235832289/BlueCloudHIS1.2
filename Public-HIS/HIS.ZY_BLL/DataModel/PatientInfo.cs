using System;

namespace HIS.ZY_BLL.DataModel
{
	/// <summary>
	/// ʵ����PatientInfo ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
    public partial class PatientInfo : HIS.ZY_BLL.DataModel.IPatientInfo
    {
        #region Model
        private int _patid;
        private string _patcode;
        private string _patname;
        private string _patsex;
        private string _pym;
        private string _wbm;
        private string _familycode;
        private string _medicard;
        private string _cureno;
        private int _curenum;
        private string _PatNumber;
        private DateTime _PatBriDate;
        private string _PatGroup;
        private string _PatTEL;
        private string _PatAddress;
        private string _PatCaseNo;
        private string _linkman;
        private string _linktel;
        private string _linkaddress;
        /// <summary>
        /// ID
        /// </summary>
        public int PatID
        {
            set { _patid = value; }
            get { return _patid; }
        }
        /// <summary>
        /// ���˴���
        /// </summary>
        public string PatCode
        {
            set { _patcode = value; }
            get { return _patcode; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public string PatName
        {
            set { _patname = value; }
            get { return _patname; }
        }
        /// <summary>
        /// �Ա�
        /// </summary>
        public string PatSex
        {
            set { _patsex = value; }
            get { return _patsex; }
        }
        /// <summary>
        /// ƴ����
        /// </summary>
        public string PYM
        {
            set { _pym = value; }
            get { return _pym; }
        }
        /// <summary>
        /// �����
        /// </summary>
        public string WBM
        {
            set { _wbm = value; }
            get { return _wbm; }
        }
        /// <summary>
        /// ��ͥ���
        /// </summary>
        public string FamilyCode
        {
            set { _familycode = value; }
            get { return _familycode; }
        }
        /// <summary>
        /// ҽ��֤����
        /// </summary>
        public string MediCard
        {
            set { _medicard = value; }
            get { return _medicard; }
        }
        /// <summary>
        /// סԺ��
        /// </summary>
        public string CureNo
        {
            set { _cureno = value; }
            get { return _cureno; }
        }
        /// <summary>
        /// סԺ����
        /// </summary>
        public int CureNum
        {
            set { _curenum = value; }
            get { return _curenum; }
        }
        /// <summary>
        /// ���֤��
        /// </summary>
        public string PatNumber
        {
            get { return _PatNumber; }
            set { _PatNumber = value; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public DateTime PatBriDate
        {
            get { return _PatBriDate; }
            set { _PatBriDate = value; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public string PatGroup
        {
            get { return _PatGroup; }
            set { _PatGroup = value; }
        }
        /// <summary>
        /// �绰
        /// </summary>
        public string PatTEL
        {
            get { return _PatTEL; }
            set { _PatTEL = value; }
        }
        /// <summary>
        /// ��ͥסַ
        /// </summary>
        public string PatAddress
        {
            get { return _PatAddress; }
            set { _PatAddress = value; }
        }
        /// <summary>
        /// ������
        /// </summary>
        public string PatCaseNo
        {
            get { return _PatCaseNo; }
            set { _PatCaseNo = value; }
        }
        /// <summary>
        /// ��ϵ��
        /// </summary>
        public string LinkMan
        {
            get { return _linkman; }
            set { _linkman = value; }
        }
        /// <summary>
        /// ��ϵ�绰
        /// </summary>
        public string LinkTel
        {
            get { return _linktel; }
            set { _linktel = value; }
        }
        /// <summary>
        /// ��ϵ��ַ
        /// </summary>
        public string LinkAddress
        {
            get { return _linkaddress; }
            set { _linkaddress = value; }
        }

        

        private string _PATJOB;
        /// <summary>
        /// ����ְҵ
        /// </summary>
        public string PATJOB
        {
            get
            {
                return _PATJOB;
            }
            set
            {
                _PATJOB = value;
            }
        }
        private string _ACCOUNTTYPE;
        /// <summary>
        /// ���㷽ʽ
        /// </summary>
        public string ACCOUNTTYPE
        {
            get
            {
                return _ACCOUNTTYPE;
            }
            set
            {
                _ACCOUNTTYPE = value;
            }
        }
        private string allergic;
        /// <summary>
        /// ����ʷ����
        /// </summary>
        public string ALLERGIC
        {
            get
            {
                return allergic;
            }
            set
            {
                allergic = value;
            }
        }
        #endregion Model
    }
}

