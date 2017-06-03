using System;
namespace HIS .Model
{
    /// <summary>
    /// ҩ�������ʷ��¼
    /// </summary>
    public class YP_AccountHis
    {
        public YP_AccountHis()
        {
        }
        #region Model
        private int _accounthistoryid;
        private int _accountyear;
        private int _accountmonth;
        private DateTime _begintime;
        private DateTime _endtime;
        private int _regman;
        private DateTime _regtime;
        private int _deptid;
        /// <summary>
        /// ���˼�¼��ʶID
        /// </summary>
        public int AccountHistoryID
        {
            set
            {
                _accounthistoryid = value;
            }
            get
            {
                return _accounthistoryid;
            }
        }
        /// <summary>
        /// ������
        /// </summary>
        public int AccountYear
        {
            set
            {
                _accountyear = value;
            }
            get
            {
                return _accountyear;
            }
        }
        /// <summary>
        /// ����·�
        /// </summary>
        public int AccountMonth
        {
            set
            {
                _accountmonth = value;
            }
            get
            {
                return _accountmonth;
            }
        }
        /// <summary>
        /// ��ʼʱ��
        /// </summary>
        public DateTime BeginTime
        {
            set
            {
                _begintime = value;
            }
            get
            {
                return _begintime;
            }
        }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime EndTime
        {
            set
            {
                _endtime = value;
            }
            get
            {
                return _endtime;
            }
        }
        /// <summary>
        /// ������Ա
        /// </summary>
        public int RegMan
        {
            set
            {
                _regman = value;
            }
            get
            {
                return _regman;
            }
        }
        /// <summary>
        /// ����ʱ��
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
        /// �Ǽǲ���
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

