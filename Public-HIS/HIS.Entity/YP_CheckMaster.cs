using System;
namespace HIS .Model
{
    /// <summary>
    /// �̵��ͷ
    /// </summary>
    public class YP_CheckMaster:BillMaster
    {
        public YP_CheckMaster()
        {
        }
        #region Model
        private int _mastercheckid;
        private int _billnum;
        private int _regpeopleid;
        private DateTime _regtime;
        private int _auditpeopleid;
        private DateTime _audittime;
        private string _remark;
        private int _del_flag;
        private int _audit_flag;
        private string _optype;
        private int _deptid;
        private int _auditnum;
        private decimal _moreretailfee;
        private decimal _moretradefee;
        private decimal _lessretailfee;
        private decimal _lesstradefee;

        /// <summary>
        /// �̵��ͷ��ʶID
        /// </summary>
        public int MasterCheckID
        {
            set
            {
                _mastercheckid = value;
            }
            get
            {
                return _mastercheckid;
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
        /// ��˵���
        /// </summary>
        public int AuditNum
        {
            set
            {
                _auditnum = value;
            }
            get
            {
                return _auditnum;
            }
        }

        /// <summary>
        /// ��Ӯ���۽��
        /// </summary>
        public decimal MoreRetailFee
        {
            set
            {
                _moreretailfee = value;
            }
            get
            {
                return _moreretailfee;
            }
        }

        /// <summary>
        /// ��ӯ�������
        /// </summary>
        public decimal MoreTradeFee
        {
            set
            {
                _moretradefee = value;
            }
            get
            {
                return _moretradefee;
            }
        }

        /// <summary>
        /// �̿����۽��
        /// </summary>
        public decimal LessRetailFee
        {
            set
            {
                _lessretailfee = value;
            }
            get
            {
                return _lessretailfee;
            }
        }

        /// <summary>
        /// �̿��������
        /// </summary>
        public decimal LessTradeFee
        {
            set
            {
                _lesstradefee = value;
            }
            get
            {
                return _lesstradefee;
            }
        }

        #endregion Model

    }
}

