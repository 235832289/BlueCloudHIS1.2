using System;
namespace HIS .Model
{
    /// <summary>
    /// ʵ����YP_SupportDic ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    public class YP_SupportDic
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        public YP_SupportDic()
        {
        }
        #region Model
        private int _supportdicid;
        private string _name;
        private string _pym;
        private string _wbm;
        private string _linkman;
        private string _phone;
        private string _address;
        private int _del_flag;
        /// <summary>
        /// ��Ӧ�̱�ʶ�ɣ�
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
        /// ��Ӧ������
        /// </summary>
        public string Name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
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
        /// ��ϵ������
        /// </summary>
        public string LinkMan
        {
            set
            {
                _linkman = value;
            }
            get
            {
                return _linkman;
            }
        }
        /// <summary>
        /// ��ϵ�绰
        /// </summary>
        public string Phone
        {
            set
            {
                _phone = value;
            }
            get
            {
                return _phone;
            }
        }
        /// <summary>
        /// ��ַ
        /// </summary>
        public string Address
        {
            set
            {
                _address = value;
            }
            get
            {
                return _address;
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
        #endregion Model

    }
}

