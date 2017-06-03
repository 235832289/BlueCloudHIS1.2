using System;

namespace HIS.ZY_BLL.DataModel
{
	/// <summary>
	/// ��������
	/// </summary>
    public partial class ZY_CostMaster 
    {
        #region Model
        private int _costmasterid;
        private int _patid;
        private int _patlistid;
        private int _ntype;
        private DateTime _discharge_date;
        private DateTime _discharge_bdate;
        private DateTime _discharge_edate;
        private string _ticketnum;
        private string _ticketcode;
        private string _chargecode;
        private decimal _total_fee;
        private decimal _deptosit_fee;
        private decimal _self_fee;
        private decimal _village_fee;
        private decimal _favor_fee;
        private decimal _reality_fee;
        private decimal _pos_fee;
        private decimal _money_fee;
        private int _ticket_flag;
        private DateTime _costdate;
        private int _delete_flag;
        private int _accountid;
        private int _record_flag;
        private int _oldid;
        private string _Nccm_NO;
        private int _village_Type;
        private string _PatType;
        private string _WorkUnit;
        private decimal _WorkUnit_Fee;
        private decimal _NotWorkUnit_Fee;
        private decimal _Ration_Fee;
        private decimal _MoreRation_Fee;
        private decimal _SelfDrug_Fee;

        /// <summary>
        /// ID
        /// </summary>
        public int CostMasterID
        {
            set { _costmasterid = value; }
            get { return _costmasterid; }
        }
        /// <summary>
        /// ����ID
        /// </summary>
        public int PatID
        {
            set { _patid = value; }
            get { return _patid; }
        }
        /// <summary>
        /// סԺ����ID
        /// </summary>
        public int PatListID
        {
            set { _patlistid = value; }
            get { return _patlistid; }
        }
        /// <summary>
        /// �������ͣ���;����Ժ��Ƿ�ѣ�
        /// </summary>
        public int Ntype
        {
            set { _ntype = value; }
            get { return _ntype; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public DateTime Discharge_date
        {
            set { _discharge_date = value; }
            get { return _discharge_date; }
        }
        /// <summary>
        /// ���㿪ʼ����
        /// </summary>
        public DateTime Discharge_bdate
        {
            set { _discharge_bdate = value; }
            get { return _discharge_bdate; }
        }
        /// <summary>
        /// �����������
        /// </summary>
        public DateTime Discharge_edate
        {
            set { _discharge_edate = value; }
            get { return _discharge_edate; }
        }
        /// <summary>
        /// ��Ʊ��ˮ��
        /// </summary>
        public string TicketNum
        {
            set { _ticketnum = value; }
            get { return _ticketnum; }
        }
        /// <summary>
        /// ��Ʊ��
        /// </summary>
        public string TicketCode
        {
            set { _ticketcode = value; }
            get { return _ticketcode; }
        }
        /// <summary>
        /// ������
        /// </summary>
        public string ChargeCode
        {
            set { _chargecode = value; }
            get { return _chargecode; }
        }
        /// <summary>
        /// �ܷ���
        /// </summary>
        public decimal Total_Fee
        {
            set { _total_fee = value; }
            get { return _total_fee; }
        }
        /// <summary>
        ///Ԥ����
        /// </summary>
        public decimal Deptosit_Fee
        {
            set { _deptosit_fee = value; }
            get { return _deptosit_fee; }
        }
        /// <summary>
        /// �Ը����
        /// </summary>
        public decimal Self_Fee
        {
            set { _self_fee = value; }
            get { return _self_fee; }
        }
        /// <summary>
        /// ���˽��
        /// </summary>
        public decimal Village_Fee
        {
            set { _village_fee = value; }
            get { return _village_fee; }
        }
        /// <summary>
        /// �Żݽ��
        /// </summary>
        public decimal Favor_Fee
        {
            set { _favor_fee = value; }
            get { return _favor_fee; }
        }
        /// <summary>
        /// ʵ�ս��
        /// </summary>
        public decimal Reality_Fee
        {
            set { _reality_fee = value; }
            get { return _reality_fee; }
        }
        /// <summary>
        /// pos���
        /// </summary>
        public decimal Pos_Fee
        {
            set { _pos_fee = value; }
            get { return _pos_fee; }
        }
        /// <summary>
        /// �ֽ���
        /// </summary>
        public decimal Money_Fee
        {
            set { _money_fee = value; }
            get { return _money_fee; }
        }
        /// <summary>
        /// ��ӡ��Ʊ��ʽ
        /// </summary>
        public int Ticket_Flag
        {
            set { _ticket_flag = value; }
            get { return _ticket_flag; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public DateTime CostDate
        {
            set { _costdate = value; }
            get { return _costdate; }
        }
        /// <summary>
        /// �Ƿ���Ч
        /// </summary>
        public int Delete_Flag
        {
            set { _delete_flag = value; }
            get { return _delete_flag; }
        }
        /// <summary>
        /// ������id
        /// </summary>
        public int AccountID
        {
            set { _accountid = value; }
            get { return _accountid; }
        }
        /// <summary>
        /// ��¼״̬
        /// </summary>
        public int Record_Flag
        {
            set { _record_flag = value; }
            get { return _record_flag; }
        }
        /// <summary>
        /// ����ԭ��ID
        /// </summary>
        public int OldID
        {
            set { _oldid = value; }
            get { return _oldid; }
        }

        /// <summary>
        /// ũ�ϱ���
        /// </summary>
        public string Nccm_NO
        {
            get
            {
                return _Nccm_NO;
            }
            set
            {
                _Nccm_NO = value;
            }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public int Village_Type
        {
            get
            {
                return _village_Type;
            }
            set
            {
                _village_Type = value;
            }
        }

        /// <summary>
        /// ��������
        /// </summary>
        public string PatType
        {
            get
            {
                return _PatType;
            }
            set
            {
                _PatType = value;
            }
        }

        /// <summary>
        /// ���˵�λ
        /// </summary>
        public string WorkUnit
        {
            get
            {
                return _WorkUnit;
            }
            set
            {
                _WorkUnit = value;
            }
        }
        /// <summary>
        /// ��λ���˽��
        /// </summary>
        public decimal WorkUnit_Fee
        {
            get
            {
                return _WorkUnit_Fee;
            }
            set
            {
                _WorkUnit_Fee = value;
            }
        }

        public decimal NotWorkUnit_Fee
        {
            get
            {
                return _NotWorkUnit_Fee;
            }
            set
            {
                _NotWorkUnit_Fee = value;
            }
        }

        public decimal Ration_Fee
        {
            get
            {
                return _Ration_Fee;
            }
            set
            {
                _Ration_Fee = value;
            }
        }

        public decimal MoreRation_Fee
        {
            get
            {
                return _MoreRation_Fee;
            }
            set
            {
                _MoreRation_Fee = value;
            }
        }
        /// <summary>
        /// �Է���ҩ���
        /// </summary>
        public decimal SelfDrug_Fee
        {
            get
            {
                return _SelfDrug_Fee;
            }
            set
            {
                _SelfDrug_Fee = value;
            }
        }
        #endregion Model

    }
}

