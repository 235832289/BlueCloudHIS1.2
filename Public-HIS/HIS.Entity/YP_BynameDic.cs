using System;
namespace HIS .Model
{
    /// <summary>
    /// ʵ����YP_BynameDic ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    public class YP_BynameDic
    {
        public YP_BynameDic()
        {
        }
        #region Model
        private int _bynamedicid;
        private int _specdicid;
        private YP_SpecDic _specdic;
        private string _byname;
        private string _pym;
        private string _wbm;
        /// <summary>
        /// ҩƷ������ʶID
        /// </summary>
        public int BynameDicID
        {
            set
            {
                _bynamedicid = value;
            }
            get
            {
                return _bynamedicid;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int SpecDicID
        {
            set
            {
                _specdicid = value;
            }
            get
            {
                return _specdicid;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public YP_SpecDic SpecDic
        {
            set
            {
                _specdic = value;
            }
            get
            {
                return _specdic;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Byname
        {
            set
            {
                _byname = value;
            }
            get
            {
                return _byname;
            }
        }
        /// <summary>
        /// ����ƴ����
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
        /// ���������
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

