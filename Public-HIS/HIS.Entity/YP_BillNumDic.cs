using System;
namespace HIS .Model
{
    /// <summary>
    /// ʵ����YP_BillNumDic ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    public class YP_BillNumDic
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        public YP_BillNumDic()
        {
        }
        #region Model
        private int _billnumdicid;
        private string _optype;
        private int _billnum;
        private int _deptid;
        /// <summary>
        /// ���ݺű�ʶID
        /// </summary>
        public int BillNumDicID
        {
            set
            {
                _billnumdicid = value;
            }
            get
            {
                return _billnumdicid;
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

