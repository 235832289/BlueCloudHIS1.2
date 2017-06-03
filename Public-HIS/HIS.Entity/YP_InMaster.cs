using System;
namespace HIS.Model
{
    /// <summary>
    /// ����ͷ
    /// </summary>
    public class YP_InMaster:BillMaster
    {
        public YP_InMaster()
        {
        }
        #region Model
        private int _masterinstorageid;
        private int _opmanid;
        private int _audit_flag;
        private int _del_flag;
        private string _remark;
        private DateTime _audittime;
        private int _auditpeopleid;
        private DateTime _regtime;
        private int _regpeopleid;
        private int _billnum;
        private decimal _stockfee;
        private decimal _retailfee;
        private decimal _tradefee;
        private string _invoicenum;
        private DateTime _invoicedate;
        private DateTime _billdate;
        private int _supportdicid;
        private YP_SupportDic _supportdic;
        private int _delivernum;
        private int _pay_flag;
        private string _optype;
        private int _deptid;
        /// <summary>
        /// ����ʶID
        /// </summary>
        public int MasterInStorageID
        {
            set
            {
                _masterinstorageid = value;
            }
            get
            {
                return _masterinstorageid;
            }
        }
        /// <summary>
        /// ������Ա��Ϣ
        /// </summary>
        public int OpManID
        {
            set
            {
                _opmanid = value;
            }
            get
            {
                return _opmanid;
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
        /// �������
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
        /// �����Ա
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
        /// �Ǽ���Ա
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
        /// ���۽��
        /// </summary>
        public decimal StockFee
        {
            set
            {
                _stockfee = value;
            }
            get
            {
                return _stockfee;
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
        /// �������
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
        public DateTime InvoiceDate
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
        /// 
        /// </summary>
        public int SupportDicID
        {
            set
            {
                _supportdicid = value;
            }
            get
            {
                return _supportdicid;
            }
        }
        /// <summary>
        /// ��Ӧ����Ϣ
        /// </summary>
        public YP_SupportDic SupportDic
        {
            set
            {
                _supportdic = value;
            }
            get
            {
                return _supportdic;
            }
        }
        /// <summary>
        /// �ͻ��˱��
        /// </summary>
        public int DeliverNum
        {
            set
            {
                _delivernum = value;
            }
            get
            {
                return _delivernum;
            }
        }
        /// <summary>
        /// �����ʶ
        /// </summary>
        public int Pay_Flag
        {
            set
            {
                _pay_flag = value;
            }
            get
            {
                return _pay_flag;
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
        #endregion Model

    }
}

