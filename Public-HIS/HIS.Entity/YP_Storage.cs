using System;
namespace HIS .Model
{
    /// <summary>
    /// ҩƷ���
    /// </summary>
    public class YP_Storage
    {
        public YP_Storage()
        {
        }
        #region Model
        private int _storageid;
        private int _makerdicid;
        private YP_MakerDic _makerdic;
        private decimal _currentnum;
        private string _place;
        private decimal _lstockprice;
        private DateTime _regtime;
        private decimal _upperlimit;
        private decimal _lowerlimit;
        private int _leastunitid;
        private YP_UnitDic _leastunit;
        private int _unitnum;
        private int _del_flag;
        private int _deptid;
        /// <summary>
        /// ҩƷ����ʶID
        /// </summary>
        public int StorageID
        {
            set
            {
                _storageid = value;
            }
            get
            {
                return _storageid;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int MakerDicID
        {
            set
            {
                _makerdicid = value;
            }
            get
            {
                return _makerdicid;
            }
        }
        /// <summary>
        /// ҩƷ������Ϣ
        /// </summary>
        public YP_MakerDic MakerDic
        {
            set
            {
                _makerdic = value;
            }
            get
            {
                return _makerdic;
            }
        }
        /// <summary>
        /// ��ǰ�����
        /// </summary>
        public decimal CurrentNum
        {
            set
            {
                _currentnum = value;
            }
            get
            {
                return _currentnum;
            }
        }
        /// <summary>
        /// ���λ��
        /// </summary>
        public string Place
        {
            set
            {
                _place = value;
            }
            get
            {
                return _place;
            }
        }
        /// <summary>
        /// �ϴν���
        /// </summary>
        public decimal LStockPrice
        {
            set
            {
                _lstockprice = value;
            }
            get
            {
                return _lstockprice;
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
        /// �������
        /// </summary>
        public decimal UpperLimit
        {
            set
            {
                _upperlimit = value;
            }
            get
            {
                return _upperlimit;
            }
        }
        /// <summary>
        /// �������
        /// </summary>
        public decimal LowerLimit
        {
            set
            {
                _lowerlimit = value;
            }
            get
            {
                return _lowerlimit;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int LeastUnit
        {
            set
            {
                _leastunitid = value;
            }
            get
            {
                return _leastunitid;
            }
        }
        /// <summary>
        /// ��С��λ
        /// </summary>
        public YP_UnitDic LeastUnitEntity
        {
            set
            {
                _leastunit = value;
            }
            get
            {
                return _leastunit;
            }
        }
        /// <summary>
        /// ��λ����
        /// </summary>
        public int UnitNum
        {
            set
            {
                _unitnum = value;
            }
            get
            {
                return _unitnum;
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

