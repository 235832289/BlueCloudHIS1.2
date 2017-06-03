using System;
namespace HIS .Model
{
    /// <summary>
    /// ʵ����YF_OutMaster ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    public class YP_OutMaster:BillMaster
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        public YP_OutMaster()
        {
        }
        #region Model
        private int _masteroutstorageid;
        private string _remark;
        private int _del_flag;
        private int _audit_flag;
        private DateTime _audittime;
        private int _auditpeopleid;
        private DateTime _regtime;
        private int _regpeopleid;
        private int _billnum;
        private decimal _outfee;
        private decimal _retailfee;
        private decimal _tradefee;
        private string _invoicenum;
        private string _invoicedate;
        private DateTime _billdate;
        private string _optype;
        private int _relationnum;
        private int _deptid;
        private int _outdeptid;
        /// <summary>
        /// �����ͷ��ʶID
        /// </summary>
        public int MasterOutStorageID
        {
            set
            {
                _masteroutstorageid = value;
            }
            get
            {
                return _masteroutstorageid;
            }
        }
        /// <summary>
        /// ��ע
        /// </summary>
        public string ReMark
        {
            set
            {
                _remark = value;
            }
            get
            {
                return _remark;
            }
        }
        /// <summary>
        /// ɾ����ʶ
        /// </summary>
        public int Del_Flag
        {
            set
            {
                _del_flag = value;
            }
            get
            {
                return _del_flag;
            }
        }
        /// <summary>
        /// ��˱�ʶ
        /// </summary>
        public int Audit_Flag
        {
            set
            {
                _audit_flag = value;
            }
            get
            {
                return _audit_flag;
            }
        }
        /// <summary>
        /// ���ʱ��
        /// </summary>
        public DateTime AuditTime
        {
            set
            {
                _audittime = value;
            }
            get
            {
                return _audittime;
            }
        }
        /// <summary>
        /// �����Ա��Ϣ
        /// </summary>
        public int AuditPeopleID
        {
            set
            {
                _auditpeopleid = value;
            }
            get
            {
                return _auditpeopleid;
            }
        }
        /// <summary>
        /// �Ǽ�ʱ��
        /// </summary>
        public DateTime RegTime
        {
            set
            {
                _regtime = value;
            }
            get
            {
                return _regtime;
            }
        }
        /// <summary>
        /// �Ǽ�����Ϣ
        /// </summary>
        public int RegPeopleID
        {
            set
            {
                _regpeopleid = value;
            }
            get
            {
                return _regpeopleid;
            }
        }
        /// <summary>
        /// ���ݺ�
        /// </summary>
        public int BillNum
        {
            set
            {
                _billnum = value;
            }
            get
            {
                return _billnum;
            }
        }
        /// <summary>
        /// ������
        /// </summary>
        public decimal OutFee
        {
            set
            {
                _outfee = value;
            }
            get
            {
                return _outfee;
            }
        }
        /// <summary>
        /// �������۽��
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
        /// �����������
        /// </summary>
        public decimal TradeFee
        {
            set
            {
                _tradefee = value;
            }
            get
            {
                return _tradefee;
            }
        }
        /// <summary>
        /// ��Ʊ��
        /// </summary>
        public string InvoiceNum
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
        /// ��Ʊ����
        /// </summary>
        public string InvoiceDate
        {
            set
            {
                _invoicedate = value;
            }
            get
            {
                return _invoicedate;
            }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public DateTime BillDate
        {
            set
            {
                _billdate = value;
            }
            get
            {
                return _billdate;
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
        /// <summary>
        /// ��Ӧҩ�����뵥���ݺ�
        /// </summary>
        public int RelationNum
        {
            set
            {
                _relationnum = value;
            }
            get
            {
                return _relationnum;
            }
        }
        /// <summary>
        /// ��ҩ����
        /// </summary>
        public int OutDeptId
        {
            set
            {
                _outdeptid = value;
            }
            get
            {
                return _outdeptid;
            }
        }
        #endregion Model

    }
}

