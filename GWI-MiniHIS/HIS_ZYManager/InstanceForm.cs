using System;
using System.Windows.Forms;
using GWMHIS.BussinessLogicLayer.Interfaces;
using HIS.SYSTEM.PubicBaseClasses;
using HIS_ZYManager.InvoiceManager;
using HIS_ZYManager.��ѯͳ��;

namespace HIS_ZYManager
{
	/// <summary>
	/// InstanceForm ��ժҪ˵����
	/// ������ÿ��DLL�������ʵĽӿں�����
	/// ���Ʋ��ܸģ�������Сд��
	/// </summary>
	public class InstanceForm : IXcObject
	{
		private string _functionName;
		private string _chineseName;
		private long _currentUserId;
		private long _currentDeptId;
		private long _menuId;
		private Form _mdiParent;

		public InstanceForm()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
			_functionName="";
			_chineseName="";
			_currentUserId=-1;
			_currentDeptId=-1;
			_menuId=-1;
			_mdiParent=null;
		}

		#region IXcObject ��Ա(һ��Ҫ�ڴ�ʵ��)

		#region ����
		/// <summary>
		/// ʵ�������庯������
		/// </summary>
		public string FunctionName
		{
			get
			{
				return _functionName;
			}
			set 
			{
				_functionName=value;
			}
		}
		/// <summary>
		/// ������������
		/// </summary>
		public string ChineseName
		{
			get
			{
				return _chineseName;
			}
			set 
			{
				_chineseName=value;
			}
		}
		/// <summary>
		/// ��ǰ����ԱID
		/// </summary>
		public long CurrentUserId
		{
			get
			{
				return _currentUserId;
			}
			set 
			{
				_currentUserId=value;
			}
		}
		/// <summary>
		/// ��ǰ��������ID
		/// </summary>
		public long CurrentDeptId
		{
			get
			{
				return _currentDeptId;
			}
			set 
			{
				_currentDeptId=value;
			}
		}
		/// <summary>
		/// �˵�ID
		/// </summary>
		public long MenuId
		{
			get
			{
				return _menuId;
			}
			set 
			{
				_menuId=value;
			}
		}
		/// <summary>
		/// �˵�ID
		/// </summary>
		public Form MdiParent
		{
			get
			{
				return _mdiParent;
			}
			set 
			{
				_mdiParent=value;
			}
		}
		#endregion
            
		#region ����
		/// <summary>
		/// ���ݺ�������ʵ��������
		/// </summary>
		public void InstanceXcForm()
		{
			if(_functionName=="")
			{
				throw new Exception("��������������Ϊ�գ�");
			}
			 
			switch(_functionName)
			{
                case "Fxc_FrmRegister":
                    FrmRegister frmreg = new FrmRegister(_currentUserId, _currentDeptId, _chineseName);
                    if (_mdiParent != null)
                    {
                        frmreg.MdiParent = _mdiParent;
                    }
                    frmreg.WindowState = FormWindowState.Maximized;
                    frmreg.Show();
					break;
                case "Fxc_FrmPresManager_Charge":
                    FrmPresManager frmpresC = new FrmPresManager(_currentUserId, _currentDeptId, _chineseName,0);
                    if (_mdiParent != null)
                    {
                        frmpresC.MdiParent = _mdiParent;
                    }
                    frmpresC.WindowState = FormWindowState.Maximized;
                    frmpresC.Show();
                    break;
                case "Fxc_FrmPresManager":

                    FrmPresManager frmpres = new FrmPresManager(_currentUserId, _currentDeptId, _chineseName, 1);
                    if (_mdiParent != null)
                    {
                        frmpres.MdiParent = _mdiParent;
                    }
                    frmpres.WindowState = FormWindowState.Maximized;
                    frmpres.Show();
                    break;
                case "Fxc_FrmPresManager_IsOper":
                    FrmPresManager frmpresO = new FrmPresManager(_currentUserId, _currentDeptId, _chineseName, 1,true);
                    if (_mdiParent != null)
                    {
                        frmpresO.MdiParent = _mdiParent;
                    }
                    frmpresO.WindowState = FormWindowState.Maximized;
                    frmpresO.Show();
                    break;
                case "Fxc_FrmCharge":
                    FrmCharge frmcharge = new FrmCharge();
                    frmcharge.currentDeptId = _currentDeptId;
                    frmcharge.currentUserId = _currentUserId;
                    frmcharge.chineseName = _chineseName;

                    if (_mdiParent != null)
                    {
                        frmcharge.MdiParent = _mdiParent;
                    }
                    frmcharge.WindowState = FormWindowState.Maximized;
                    frmcharge.Show();
					
					break;
                case "Fxc_FrmAccount":
                    FrmAccount frmaccount = new FrmAccount(_currentUserId, _currentDeptId, _chineseName);

                    if (_mdiParent != null)
                    {
                        frmaccount.MdiParent = _mdiParent;
                    }
                    frmaccount.WindowState = FormWindowState.Maximized;
                    frmaccount.Show();
                    break;
                case "Fxc_FrmCost":
                    FrmCost frmCost = new FrmCost();
                    frmCost.currentDeptId = _currentDeptId;
                    frmCost.currentUserId = _currentUserId;
                    frmCost.chineseName = _chineseName;
                    if (_mdiParent != null)
                    {
                        frmCost.MdiParent = _mdiParent;
                    }
                    frmCost.WindowState = FormWindowState.Maximized;
                    frmCost.Show();
                    break;
                case "Fxc_FrmTicketManage":
                    FrmTicketManage frmtm = new FrmTicketManage();
                    frmtm.currentDeptId = _currentDeptId;
                    frmtm.currentUserId = _currentUserId;
                    frmtm.chineseName = _chineseName;
                    if (_mdiParent != null)
                    {
                        frmtm.MdiParent = _mdiParent;
                    }
                    frmtm.WindowState = FormWindowState.Maximized;
                    frmtm.Show();
                    break;
                case "Fxc_FrmCostList":
                    FrmCostList frmcl = new FrmCostList();
                    frmcl.currentDeptId = _currentDeptId;
                    frmcl.currentUserId = _currentUserId;
                    frmcl.chineseName = _chineseName;
                    if (_mdiParent != null)
                    {
                        frmcl.MdiParent = _mdiParent;
                    }
                    frmcl.WindowState = FormWindowState.Maximized;
                    frmcl.Show();
                    break;
                case "Fxc_FrmItemList":
                    FrmItemList frmil = null;
                    frmil = new FrmItemList(_currentUserId, _currentDeptId, _chineseName);
                    if (_mdiParent != null)
                    {
                        frmil.MdiParent = _mdiParent;
                    }
                    frmil.WindowState = FormWindowState.Maximized;
                    frmil.Show();
                    break;
                case "Fxc_FrmDeptRpt":
                    FrmDeptRpt frmdr = new FrmDeptRpt(_currentUserId, _currentDeptId, _chineseName);
                    frmdr.type = 0;
                    if (_mdiParent != null)
                    {
                        frmdr.MdiParent = _mdiParent;
                    }
                    frmdr.WindowState = FormWindowState.Maximized;
                    frmdr.Show();
                    break;
                case "Fxc_FrmPresDeptRpt":
                    FrmDeptRpt frmpresdr = new FrmDeptRpt(_currentUserId, _currentDeptId, _chineseName);
                    frmpresdr.type = 1;
                    if (_mdiParent != null)
                    {
                        frmpresdr.MdiParent = _mdiParent;
                    }
                    frmpresdr.WindowState = FormWindowState.Maximized;
                    frmpresdr.Show();
                    break;
                case "Fxc_FrmPresDocRpt":
                    FrmDeptRpt frmpresdr1 = new FrmDeptRpt(_currentUserId, _currentDeptId, _chineseName);
                    frmpresdr1.type = 2;
                    if (_mdiParent != null)
                    {
                        frmpresdr1.MdiParent = _mdiParent;
                    }
                    frmpresdr1.WindowState = FormWindowState.Maximized;
                    frmpresdr1.Show();
                    break;
                case "Fxc_FrmRegister_NotCharge":
                    FrmRegister frmreg1 = new FrmRegister(_currentUserId, _currentDeptId, _chineseName,false);
                    if (_mdiParent != null)
                    {
                        frmreg1.MdiParent = _mdiParent;
                    }
                    frmreg1.WindowState = FormWindowState.Maximized;
                    frmreg1.Show();
                    break;
                case "Fxc_FrmPatRpt":
                    FrmPatientRpt frmpr = new FrmPatientRpt(_currentUserId, _currentDeptId, _chineseName);
                    if (_mdiParent != null)
                    {
                        frmpr.MdiParent = _mdiParent;
                    }
                    frmpr.WindowState = FormWindowState.Maximized;
                    frmpr.Show();
                    break;
                case "Fxc_FrmDoc":
                    FrmPresManager frmpres1 = new FrmPresManager(_currentUserId, _currentDeptId, _chineseName, 1);
                    if (_mdiParent != null)
                    {
                        frmpres1.MdiParent = _mdiParent;
                    }
                    frmpres1.WindowState = FormWindowState.Maximized;
                    frmpres1.Show();
                    break;
                case "Fxc_CostOverSee0":
                    Form form = CostOverSee.UsualMethod.GetCostOverSeeForm(0, HIS.SYSTEM.Core.EntityConfig.WorkID);
                    if (_mdiParent != null)
                    {
                        form.MdiParent = _mdiParent;
                    }
                    form.WindowState = FormWindowState.Maximized;
                    form.Show();
                    break;
                case "Fxc_CostOverSee1":
                    Form form1 = CostOverSee.UsualMethod.GetCostOverSeeForm(1, HIS.SYSTEM.Core.EntityConfig.WorkID);
                    if (_mdiParent != null)
                    {
                        form1.MdiParent = _mdiParent;
                    }
                    form1.WindowState = FormWindowState.Maximized;
                    form1.Show();
                    break;
                case "Fxc_FrmAllAccount":
                    FrmAllAccount frmAllAccount = new FrmAllAccount(_currentUserId, _currentDeptId, _chineseName);
                    if (_mdiParent != null)
                    {
                        frmAllAccount.MdiParent = _mdiParent;
                    }
                    frmAllAccount.WindowState = FormWindowState.Maximized;
                    frmAllAccount.Show();
                    break;
                case "Fxc_FrmClearPatData":
                    FrmClearPatData frmCpd = new FrmClearPatData();
                    frmCpd.currentDeptId = _currentDeptId;
                    frmCpd.currentUserId = _currentUserId;
                    frmCpd.chineseName = _chineseName;

                    if (_mdiParent != null)
                    {
                        frmCpd.MdiParent = _mdiParent;
                    }
                    frmCpd.WindowState = FormWindowState.Maximized;
                    frmCpd.Show();
                    break;
                case "Fxc_FrmSetting":
                    FrmSetting fs = new FrmSetting();
                    fs.ShowDialog();
                    break;
                case "Fxc_FrmTicketRpt":
                    FrmTicketRpt ftr = new FrmTicketRpt(_currentUserId, _currentDeptId, _chineseName);
                    if (_mdiParent != null)
                    {
                        ftr.MdiParent = _mdiParent;
                    }
                    ftr.WindowState = FormWindowState.Maximized;
                    ftr.Show();
                    break;
                case "Fxc_FrmFeeRpt":
                    FrmFeeRpt ffr = new FrmFeeRpt(_currentUserId, _currentDeptId, _chineseName);
                    if (_mdiParent != null)
                    {
                        ffr.MdiParent = _mdiParent;
                    }
                    ffr.WindowState = FormWindowState.Maximized;
                    ffr.Show();
                    break;
                case "Fun_ZY_InvoiceManager":
                    FrmInvoiceManager frmInvoiceManager = new FrmInvoiceManager(_chineseName, _currentUserId);
                    if (_mdiParent != null)
                    {
                        frmInvoiceManager.MdiParent = _mdiParent;
                    }
                    frmInvoiceManager.WindowState = FormWindowState.Maximized;
                    frmInvoiceManager.BringToFront();
                    frmInvoiceManager.Show();
                    break;
                case "Fxc_FrmStatDrugMessage":
                    FrmStatDrugMessage frmSdm = new FrmStatDrugMessage(_currentUserId, _currentDeptId, _chineseName);
                    if (_mdiParent != null)
                    {
                        frmSdm.MdiParent = _mdiParent;
                    }
                    frmSdm.WindowState = FormWindowState.Maximized;
                    frmSdm.Show();
                    break;
                case "Fxc_FrmStatDrugMessage_IsOper":
                    FrmStatDrugMessage frmSdmO = new FrmStatDrugMessage(_currentUserId, _currentDeptId, _chineseName,true);
                    if (_mdiParent != null)
                    {
                        frmSdmO.MdiParent = _mdiParent;
                    }
                    frmSdmO.WindowState = FormWindowState.Maximized;
                    frmSdmO.Show();
                    break;
                case "Fxc_FrmCollectDrug":
                    FrmCollectDrug frmColldrug = new FrmCollectDrug(_currentUserId, _currentDeptId, _chineseName, false);
                    if (_mdiParent != null)
                    {
                        frmColldrug.MdiParent = _mdiParent;
                    }
                    frmColldrug.WindowState = FormWindowState.Maximized;
                    frmColldrug.Show();
                    break;

                case "Fxc_FrmCollectDrug_IsOper":
                    FrmCollectDrug frmColldrug0 = new FrmCollectDrug(_currentUserId, _currentDeptId, _chineseName, true);
                    if (_mdiParent != null)
                    {
                        frmColldrug0.MdiParent = _mdiParent;
                    }
                    frmColldrug0.WindowState = FormWindowState.Maximized;
                    frmColldrug0.Show();
                    break;

                case "Fxc_FrmPatientNum":
                    FrmPatientNum frmPNum = new FrmPatientNum(_currentUserId, _currentDeptId, _chineseName);
                    if (_mdiParent != null)
                    {
                        frmPNum.MdiParent = _mdiParent;
                    }
                    frmPNum.WindowState = FormWindowState.Maximized;
                    frmPNum.Show();
                    break;
                case "Fxc_FrmChargeRpt":
                    FrmChargeRpt frmCRpt = new FrmChargeRpt(_currentUserId, _currentDeptId, _chineseName);
                    if (_mdiParent != null)
                    {
                        frmCRpt.MdiParent = _mdiParent;
                    }
                    frmCRpt.WindowState = FormWindowState.Maximized;
                    frmCRpt.Show();
                    break;
                case "Fxc_FrmPatFeeRpt":
                    FrmPatFeeRpt frmPatFr = new FrmPatFeeRpt(_currentUserId, _currentDeptId, _chineseName);
                    if (_mdiParent != null)
                    {
                        frmPatFr.MdiParent = _mdiParent;
                    }
                    frmPatFr.WindowState = FormWindowState.Maximized;
                    frmPatFr.Show();
                    break;
                case "Fxc_FrmInPatientRpt":
                    FrmInPatientRpt frminpatrpt = new FrmInPatientRpt(_currentUserId, _currentDeptId, _chineseName);
                    if (_mdiParent != null)
                    {
                        frminpatrpt.MdiParent = _mdiParent;
                    }
                    frminpatrpt.WindowState = FormWindowState.Maximized;
                    frminpatrpt.Show();
                    break;
                case "Fxc_FrmOutPatientRpt":
                    FrmOutPatientRpt frmoutpatrpt = new FrmOutPatientRpt(_currentUserId, _currentDeptId, _chineseName);
                    if (_mdiParent != null)
                    {
                        frmoutpatrpt.MdiParent = _mdiParent;
                    }
                    frmoutpatrpt.WindowState = FormWindowState.Maximized;
                    frmoutpatrpt.Show();
                    break;
				default :
					throw new Exception("�����������ƴ���");
			}
		
		}
		/// <summary>
		/// ��ø�Dll����Ϣ
		/// </summary>
		/// <returns></returns>
		public ObjectInfo GetDllInfo()
		{
			ObjectInfo objectInfo;
            objectInfo.Name = "HIS_ZYManager";
			objectInfo.Text="סԺϵͳ";
			objectInfo.Remark="��ԺסԺ�����ۼ���";
			return objectInfo;
		}
		/// <summary>
		/// ��ø�Dll��������������Ϣ
		/// </summary>
		/// <returns></returns>
		public ObjectInfo[] GetFunctionsInfo()
		{
			ObjectInfo[] objectInfos=new ObjectInfo[29];

			objectInfos[0].Name="Fxc_FrmRegister";
			objectInfos[0].Text="��Ժ�Ǽ�";
            objectInfos[0].Remark = "��Ժ�Ǽ�";

			objectInfos[1].Name="Fxc_FrmPresManager";
			objectInfos[1].Text="���ۼ���";
            objectInfos[1].Remark = "���ۼ���";

            objectInfos[2].Name = "Fxc_FrmCharge";
            objectInfos[2].Text = "Ԥ�������";
            objectInfos[2].Remark = "סԺԤ�������";

            objectInfos[3].Name = "Fxc_FrmAccount";
            objectInfos[3].Text = "�������";
            objectInfos[3].Remark = "�������";

            objectInfos[4].Name = "Fxc_FrmCost";
            objectInfos[4].Text = "���ý���";
            objectInfos[4].Remark = "���ý���";

            objectInfos[5].Name = "Fxc_FrmTicketManage";
            objectInfos[5].Text = "�����¼";
            objectInfos[5].Remark = "�����¼";

            objectInfos[6].Name = "Fxc_FrmPresManager_Charge";
            objectInfos[6].Text = "ҩ������";
            objectInfos[6].Remark = "ҩ������";

            objectInfos[7].Name = "Fxc_FrmCostList";
            objectInfos[7].Text = "���ó���";
            objectInfos[7].Remark = "���ó���";

            objectInfos[8].Name = "Fxc_FrmItemList";
            objectInfos[8].Text = "�����嵥";
            objectInfos[8].Remark = "�����嵥";

            objectInfos[9].Name = "Fxc_FrmPresManager_IsOper";
            objectInfos[9].Text = "�����Ҽ���";
            objectInfos[9].Remark = "�����Ҽ���";

            objectInfos[10].Name = "Fxc_FrmRegister_NotCharge";
            objectInfos[10].Text = "��Ժ�Ǽ�(�����շ�)";
            objectInfos[10].Remark = "��Ժ�Ǽ�(�����շ�)";

          

            objectInfos[11].Name = "Fxc_FrmDoc";
            objectInfos[11].Text = "סԺҽ��/��ʿվ";
            objectInfos[11].Remark = "סԺҽ��/��ʿվ";

            objectInfos[12].Name = "Fxc_CostOverSee0";
            objectInfos[12].Text = "ũ�ϲ��˷��ò�ѯ";
            objectInfos[12].Remark = "ũ�ϲ��˷��ò�ѯ";

            objectInfos[13].Name = "Fxc_CostOverSee1";
            objectInfos[13].Text = "ũ�ϲ��˷���ʵʱ��ѯ";
            objectInfos[13].Remark = "ũ�ϲ��˷���ʵʱ��ѯ";

            objectInfos[14].Name = "Fxc_FrmAllAccount";
            objectInfos[14].Text = "סԺ��������";
            objectInfos[14].Remark = "סԺ��������";

            objectInfos[15].Name = "Fxc_FrmClearPatData";
            objectInfos[15].Text = "����סԺ����һ������";
            objectInfos[15].Remark = "����סԺ����һ������";

            objectInfos[16].Name = "Fxc_FrmSetting";
            objectInfos[16].Text = "סԺ��������";
            objectInfos[16].Remark = "סԺ��������";

            objectInfos[17].Name = "Fxc_FrmTicketRpt";
            objectInfos[17].Text = "סԺ��Ʊͳ��";
            objectInfos[17].Remark = "סԺ��Ʊͳ��";

            objectInfos[18].Name = "Fxc_FrmFeeRpt";
            objectInfos[18].Text = "סԺ����ͳ��";
            objectInfos[18].Remark = "סԺ����ͳ��";

            objectInfos[19].Name = "Fun_ZY_InvoiceManager";
            objectInfos[19].Text = "סԺ��Ʊ����";
            objectInfos[19].Remark = "סԺ��Ʊ����";


            objectInfos[20].Name = "Fxc_FrmStatDrugMessage";
            objectInfos[20].Text = "ͳ��ҩƷ���ݹ���";
            objectInfos[20].Remark = "ͳ��ҩƷ���ݹ���";

            objectInfos[21].Name = "Fxc_FrmStatDrugMessage_IsOper";
            objectInfos[21].Text = "������ͳ��ҩƷ���ݹ���";
            objectInfos[21].Remark = "������ͳ��ҩƷ���ݹ���";

            objectInfos[22].Name = "Fxc_FrmCollectDrug";
            objectInfos[22].Text = "��ʿ������ҩ";
            objectInfos[22].Remark = "��ʿ������ҩ";

            objectInfos[23].Name = "Fxc_FrmCollectDrug_IsOper";
            objectInfos[23].Text = "�����һ�����ҩ";
            objectInfos[23].Remark = "�����һ�����ҩ";

            objectInfos[24].Name = "Fxc_FrmPatientNum";
            objectInfos[24].Text = "סԺ�����˴�ͳ��";
            objectInfos[24].Remark = "סԺ�����˴�ͳ��";


            objectInfos[25].Name = "Fxc_FrmChargeRpt";
            objectInfos[25].Text = "סԺԤ����ͳ��";
            objectInfos[25].Remark = "סԺԤ����ͳ��";

            objectInfos[26].Name = "Fxc_FrmPatFeeRpt";
            objectInfos[26].Text = "סԺ��������ͳ��";
            objectInfos[26].Remark = "סԺ��������ͳ��";

            objectInfos[27].Name = "Fxc_FrmInPatientRpt";
            objectInfos[27].Text = "��Ժ����̨��";
            objectInfos[27].Remark = "��Ժ����̨��";

            objectInfos[28].Name = "Fxc_FrmOutPatientRpt";
            objectInfos[28].Text = "��Ժ����̨��";
            objectInfos[28].Remark = "��Ժ����̨��";

			return objectInfos;
		}
		#endregion
		
		#endregion
	}
}
