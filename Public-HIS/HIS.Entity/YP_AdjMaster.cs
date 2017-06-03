using System;
namespace HIS .Model
{
    /// <summary>
    /// ���۵���ͷ
    /// </summary>
    public class YP_AdjMaster:BillMaster
    {
        public YP_AdjMaster()
        {
        }
        #region Model
        private int _masteradjpriceid;
        private int _billnum;
        private int _regpeople;
        private DateTime _regtime;
        private string _remark;
        private string _adjcode;
        private DateTime _exetime;
        private int _audit_flag;
        private int _del_flag;
        private string _optype;
        private int _over_flag;
        private int _deptid;
        /// <summary>
        /// ���۱�ͷ��ʶID
        /// </summary>
        public int MasterAdjPriceID
        {
            set
            {
                _masteradjpriceid = value;
            }
            get
            {
                return _masteradjpriceid;
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
        public int RegPeople
        {
            set
            {
                _regpeople = value;
            }
            get
            {
                return _regpeople;
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
        /// ��ע
        /// </summary>
        public string Remark
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
        /// �����ĺ�
        /// </summary>
        public string AdjCode
        {
            set
            {
                _adjcode = value;
            }
            get
            {
                return _adjcode;
            }
        }
        /// <summary>
        /// ִ������
        /// </summary>
        public DateTime ExeTime
        {
            set
            {
                _exetime = value;
            }
            get
            {
                return _exetime;
            }
        }
        /// <summary>
        /// ����ִ�б�ʶ
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
        /// ��ɱ�ʶ
        /// </summary>
        public int Over_Flag
        {
            set
            {
                _over_flag = value;
            }
            get
            {
                return _over_flag;
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

