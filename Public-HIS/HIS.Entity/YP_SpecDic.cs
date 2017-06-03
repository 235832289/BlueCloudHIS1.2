using System;

namespace HIS.Model
{
	/// <summary>
	/// ʵ����YP_SpecDic ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class YP_SpecDic
	{
		public YP_SpecDic()
		{}
		#region Model
		private int _specdicid;
		private string _chemname;
		private string _name;
		private string _nameremark;
		private string _latinname;
		private decimal _dosenum;
		private int _doseunitid;
		private int _unitid;
		private YP_UnitDic _doseunit;
        private YP_UnitDic _unit;
		private int _packnum;
		private int _packunitid;
        private YP_UnitDic _packunit;
		private decimal _usenum;
		private string _curedisease;
		private string _spec;
		private string _remark;
		private int _pharmacology;
		private int _recipelvl;
		private DateTime _regtime;
		private int _useway;
		private int _del_flag;
		private string _gbcode;
		private int _typedicid;
		private int _ctypedicid;
		private int _dosedicid;
		private YP_TypeDic _typedic;
		private YP_DoseDic _dosedic;
		/// <summary>
		/// ����ʶID
		/// </summary>
		public int SpecDicID
		{
			set
            { 
                _specdicid=value;
            }
			get
            {
                return _specdicid;
            }
		}
		/// <summary>
		/// ��ѧ����
		/// </summary>
		public string ChemName
		{
			set
            { 
                _chemname=value;
            }
			get
            {
                return _chemname;
            }
		}
		/// <summary>
		/// ��Ʒ����
		/// </summary>
		public string Name
		{
			set
            {
                _name=value;
            }
			get
            {
                return _name;
            }
		}
		/// <summary>
		/// ��Ʒ����ע
		/// </summary>
		public string NameRemark
		{
			set
            { 
                _nameremark=value;
            }
			get
            {
                return _nameremark;
            }
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string LatinName
		{
			set
            { 
                _latinname=value;
            }
			get
            {
                return _latinname;
            }
		}
		/// <summary>
		/// ����ϵ��
		/// </summary>
		public decimal DoseNum
		{
			set
            { 
                _dosenum=value;
            }
			get
            {
                return _dosenum;
            }
		}
		/// <summary>
		/// 
		/// </summary>
		public int DoseUnit
		{
			set{ _doseunitid=value;}
			get{return _doseunitid;}
		}
		/// <summary>
		/// ������λ
		/// </summary>
        public YP_UnitDic DoseUnitEntity
		{
			set
            { 
                _doseunit=value;
            }
			get
            {
                return _doseunit;
            }
		}
		/// <summary>
		/// 
		/// </summary>
		public int Unit
		{
			set{ _unitid=value;}
			get{return _unitid;}
		}
		/// <summary>
		/// ��С��λ
		/// </summary>
        public YP_UnitDic UnitEntity
		{
			set
            { 
                _unit=value;
            }
			get
            {
                return _unit;
            }
		}
		/// <summary>
		/// ��װ����
		/// </summary>
		public int PackNum
		{
			set
            {
                _packnum=value;
            }
			get
            {
                return _packnum;
            }
		}
		/// <summary>
		/// 
		/// </summary>
		public int PackUnit
		{
			set{ _packunitid=value;}
			get{return _packunitid;}
		}
		/// <summary>
		/// ��װ��λ
		/// </summary>
        public YP_UnitDic PackUnitEntity
		{
			set
            {
                _packunit=value;
            }
			get
            {
                return _packunit;
            }
		}
		/// <summary>
		/// ʹ������
		/// </summary>
		public decimal UseNum
		{
			set
            {
                _usenum=value;
            }
			get
            {
                return _usenum;
            }
		}
		/// <summary>
		/// ���β�֢
		/// </summary>
		public string CureDisease
		{
			set
            {
                _curedisease=value;
            }
			get
            {
                return _curedisease;
            }
		}
		/// <summary>
		/// �������
		/// </summary>
		public string Spec
		{
			set
            {
                _spec=value;
            }
			get
            {
                return _spec;
            }
		}
		/// <summary>
		/// ��ע
		/// </summary>
		public string Remark
		{
			set
            {
                _remark=value;
            }
			get
            {
                return _remark;
            }
		}
		/// <summary>
		/// ҩ�����
		/// </summary>
		public int Pharmacology
		{
			set
            { 
                _pharmacology=value;
            }
			get
            {
                return _pharmacology;
            }
		}
		/// <summary>
		/// ��������
		/// </summary>
		public int RecipeLvl
		{
			set
            {
                _recipelvl=value;
            }
			get
            {
                return _recipelvl;
            }
		}
		/// <summary>
		/// �Ǽ�ʱ��
		/// </summary>
		public DateTime RegTime
		{
			set
            {
                _regtime=value;
            }
			get
            {
                return _regtime;
            }
		}
		/// <summary>
		/// ʹ�÷���
		/// </summary>
		public int UseWay
		{
			set
            { 
                _useway=value;
            }
			get
            {
                return _useway;
            }
		}
		/// <summary>
		/// ɾ����ʶ
		/// </summary>
		public int Del_Flag
		{
			set
            {
                _del_flag=value;
            }
			get
            {
                return _del_flag;
            }
		}
		/// <summary>
		/// ���ұ���
		/// </summary>
		public string GBCode
		{
			set
            {
                _gbcode=value;
            }
			get
            {
                return _gbcode;
            }
		}
		/// <summary>
		/// 
		/// </summary>
		public int TypeDicID
		{
			set{ _typedicid=value;}
			get{return _typedicid;}
		}
		/// <summary>
		/// ҩƷ����
		/// </summary>
        public YP_TypeDic TypeDicEntity
		{
			set
            {
                _typedic=value;
            }
			get
            {
                return _typedic;
            }
		}
		/// <summary>
		/// 
		/// </summary>
		public int CTypeDIc
		{
			set{ _ctypedicid=value;}
			get{return _ctypedicid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int DoseDicID
		{
			set
            {
                _dosedicid=value;
            }
			get
            {
                return _dosedicid;
            }
		}
		/// <summary>
		/// ҩƷ����
		/// </summary>
        public YP_DoseDic DoseDicEntity
		{
			set
            { 
                _dosedic=value;
            }
			get
            {
                return _dosedic;
            }
		}
		#endregion Model

	}
}

