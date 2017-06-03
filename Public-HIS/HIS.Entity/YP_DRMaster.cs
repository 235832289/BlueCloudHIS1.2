using System;
namespace HIS .Model
{
    /// <summary>
    /// ��/��ҩ��ͷ
    /// </summary>
    public class YP_DRMaster:BillMaster
    {
        public YP_DRMaster()
        {
        }
        #region Model
        private int _masterdrugocid;
        private decimal _retailfee;
        private int _invoicenum;
        private string _inpatientid;
        private int _recipeid;
        private int _recipenum;
        private string _patientno;
        private int _patientid;
        private string _patientname;
        private int _docid;
        private int _oppeopleid;
        private DateTime _optime;
        private int _charge_flag;
        private int _drugoc_flag;
        private string _optype;
        private decimal _receiptcode;
        private int _dosageman;
        private DateTime _chargedate;
        private int _chargeman;
        private int _deptid;
        private int _uniformid;
        /// <summary>
        /// ����ҩ��ͷ��ʶID
        /// </summary>
        public int MasterDrugOCID
        {
            set
            {
                _masterdrugocid = value;
            }
            get
            {
                return _masterdrugocid;
            }
        }
        /// <summary>
        /// ���۽��
        /// </summary>
        public decimal RetailFee
        {
            set
            {
                _retailfee = value;
            }
            get
            {
                return _retailfee;
            }
        }
        /// <summary>
        /// ��Ʊ��
        /// </summary>
        public int InvoiceNum
        {
            set
            {
                _invoicenum = value;
            }
            get
            {
                return _invoicenum;
            }
        }
        /// <summary>
        /// סԺ��
        /// </summary>
        public string InpatientID
        {
            set
            {
                _inpatientid = value;
            }
            get
            {
                return _inpatientid;
            }
        }
        /// <summary>
        /// ������Ϣ
        /// </summary>
        public int RecipeID
        {
            set
            {
                _recipeid = value;
            }
            get
            {
                return _recipeid;
            }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public int RecipeNum
        {
            set
            {
                _recipenum = value;
            }
            get
            {
                return _recipenum;
            }
        }
        /// <summary>
        /// ������
        /// </summary>
        public string PatientNo
        {
            set
            {
                _patientno = value;
            }
            get
            {
                return _patientno;
            }
        }
        /// <summary>
        /// ���˱��
        /// </summary>
        public int PatientID
        {
            set
            {
                _patientid = value;
            }
            get
            {
                return _patientid;
            }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public string PatientName
        {
            set
            {
                _patientname = value;
            }
            get
            {
                return _patientname;
            }
        }
        /// <summary>
        /// ҽ�����
        /// </summary>
        public int DocID
        {
            set
            {
                _docid = value;
            }
            get
            {
                return _docid;
            }
        }
        /// <summary>
        /// ��/��ҩ��Ա��Ϣ
        /// </summary>
        public int OPPeopleID
        {
            set
            {
                _oppeopleid = value;
            }
            get
            {
                return _oppeopleid;
            }
        }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime OPTime
        {
            set
            {
                _optime = value;
            }
            get
            {
                return _optime;
            }
        }
        /// <summary>
        /// ���˵���ʶ��
        /// </summary>
        public int Charge_Flag
        {
            set
            {
                _charge_flag = value;
            }
            get
            {
                return _charge_flag;
            }
        }
        /// <summary>
        /// ��/��ҩ��ʶ
        /// </summary>
        public int DrugOC_Flag
        {
            set
            {
                _drugoc_flag = value;
            }
            get
            {
                return _drugoc_flag;
            }
        }
        /// <summary>
        /// ҵ������
        /// </summary>
        public string OpType
        {
            set
            {
                _optype = value;
            }
            get
            {
                return _optype;
            }
        }
        /// <summary>
        /// �����վݺ�
        /// </summary>
        public decimal ReceiptCode
        {
            set
            {
                _receiptcode = value;
            }
            get
            {
                return _receiptcode;
            }
        }
        /// <summary>
        /// ��ҩ��
        /// </summary>
        public int DosageMan
        {
            set
            {
                _dosageman = value;
            }
            get
            {
                return _dosageman;
            }
        }
        /// <summary>
        /// �շ�����
        /// </summary>
        public DateTime ChargeDate
        {
            set
            {
                _chargedate = value;
            }
            get
            {
                return _chargedate;
            }
        }
        /// <summary>
        /// �շ���Ա��Ϣ
        /// </summary>
        public int ChargeMan
        {
            set
            {
                _chargeman = value;
            }
            get
            {
                return _chargeman;
            }
        }
        /// <summary>
        /// ������Ϣ
        /// </summary>
        public int DeptID
        {
            set
            {
                _deptid = value;
            }
            get
            {
                return _deptid;
            }
        }
        public int UniFormId
        {
            set
            {
                _uniformid = value;
            }
            get
            {
                return _uniformid;
            }
        }
        #endregion Model

    }
}

