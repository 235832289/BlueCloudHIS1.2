using System;
namespace HIS .Model
{
    /// <summary>
    /// ʵ����YP_MedicareDic ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    public class YP_MedicareDic
    {
        public YP_MedicareDic()
        {
        }
        #region Model
        private int _medicaredicid;
        private string _medicarename;
        private string _pym;
        private string _wbm;
        private string _medicareremark;
        /// <summary>
        /// ҽ�����ͱ�ʶ�ɣ�
        /// </summary>
        public int MedicareDicID
        {
            set
            {
                _medicaredicid = value;
            }
            get
            {
                return _medicaredicid;
            }
        }
        /// <summary>
        /// ҽ����������
        /// </summary>
        public string MedicareName
        {
            set
            {
                _medicarename = value;
            }
            get
            {
                return _medicarename;
            }
        }
        /// <summary>
        /// ƴ����
        /// </summary>
        public string PYM
        {
            set
            {
                _pym = value;
            }
            get
            {
                return _pym;
            }
        }
        /// <summary>
        /// �����
        /// </summary>
        public string WBM
        {
            set
            {
                _wbm = value;
            }
            get
            {
                return _wbm;
            }
        }
        /// <summary>
        /// ��ע
        /// </summary>
        public string MedicareRemark
        {
            set
            {
                _medicareremark = value;
            }
            get
            {
                return _medicareremark;
            }
        }
        #endregion Model

    }
}

