using System;
namespace HIS .Model
{
    /// <summary>
    /// ʵ����YP_UnitDic ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    public class YP_UnitDic
    {
        public YP_UnitDic()
        {
        }
        #region Model
        private int _unitdicid;
        private string _unitname;
        private string _pym;
        private string _wbm;
        /// <summary>
        /// ��λ��ʶID
        /// </summary>
        public int UnitDicID
        {
            set
            {
                _unitdicid = value;
            }
            get
            {
                return _unitdicid;
            }
        }
        /// <summary>
        /// ��λ����
        /// </summary>
        public string UnitName
        {
            set
            {
                _unitname = value;
            }
            get
            {
                return _unitname;
            }
        }
        /// <summary>
        /// ��λƴ����
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
        /// ��λ�����
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
        #endregion Model

    }
}

