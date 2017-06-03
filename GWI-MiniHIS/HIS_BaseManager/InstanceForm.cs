using System;
using System.Windows.Forms;
using GWMHIS.BussinessLogicLayer.Interfaces;
using HIS.SYSTEM.PubicBaseClasses;
namespace HIS_BaseManager
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
		private object[] _communicateValue;
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

		#region IInnerCommunicate ��Ա(һ��Ҫ�ڴ�ʵ��)

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
		/// <summary>
		/// �ڲ�ͨ�Ų���
		/// </summary>
		public object[] CommunicateValue
		{
			get
			{
				return _communicateValue;
			}
			set 
			{
				_communicateValue=value;
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
            FrmGroupMenu fMain = null;

            string sql;
            

            GWMHIS.BussinessLogicLayer.Classes.User currentUser = new GWMHIS.BussinessLogicLayer.Classes.User( _currentUserId );
            GWMHIS.BussinessLogicLayer.Classes.Deptment currentDept = new GWMHIS.BussinessLogicLayer.Classes.Deptment(_currentDeptId);

			switch(_functionName)
			{
				case "Fun_base_modulemenu":
                    fMain = new FrmGroupMenu(_currentUserId, _currentDeptId, _chineseName);
					if(_mdiParent!=null)
					{
						fMain.MdiParent=_mdiParent;
					}
					fMain.WindowState=FormWindowState.Maximized;
					fMain.BringToFront();
					fMain.Show();
					break;

                case "Fxc_HisReport":
                    FrmHisReport frmhr = new FrmHisReport(_currentUserId, _currentDeptId, _chineseName);
                    if (_mdiParent != null)
                    {
                        frmhr.MdiParent = _mdiParent;
                    }
                    frmhr.WindowState = FormWindowState.Maximized;
                    frmhr.Show();
                    break;
                case "Fxc_DesReport":
                    FrmReportManager fm = new FrmReportManager();
                    fm.Show();
                    break;
                case "Fxc_FrmInForSerch":
                    FrmInforSerch fmIn = new FrmInforSerch(_chineseName);
                    if (_mdiParent != null)
                    {
                        fmIn.MdiParent = _mdiParent; 
                    }
                    fmIn.WindowState = FormWindowState.Maximized;
                    fmIn.Show();
                    break;
   

                #region ����ģ��
                
                case "Fun_GWM_EmpDeptSet":
                    FrmEmpDeptSetting fRywh = new FrmEmpDeptSetting( _currentUserId , _currentDeptId , _chineseName );
                    if (_mdiParent != null)
                    {
                        fRywh.MdiParent = _mdiParent;
                    }
                    fRywh.WindowState = FormWindowState.Maximized;
                    fRywh.BringToFront();
                    fRywh.Show();
                    break;
                #endregion

                case "Fun_Base_Service_Items":
                    HIS_BaseManager.FrmSFXM frmSfxm = new FrmSFXM( _chineseName , currentUser );
                    if ( _mdiParent != null )
                    {
                        frmSfxm.MdiParent = _mdiParent;
                    }
                    frmSfxm.WindowState = FormWindowState.Maximized;
                    frmSfxm.Show( );
                    break;
                case "Fun_FrmGBDictionary":
                    HIS_BaseManager.FrmGBDictionary frmSfxm1 = new FrmGBDictionary(_chineseName);
                    if (_mdiParent != null)
                    {
                        frmSfxm1.MdiParent = _mdiParent;
                    }
                    frmSfxm1.WindowState = FormWindowState.Maximized;
                    frmSfxm1.Show();
                    break;
                case "Fun_StatItem":
                    HIS_BaseManager.FrmStatItem frmStat = new FrmStatItem( _chineseName );
                    if ( _mdiParent != null )
                    {
                        frmStat.MdiParent = _mdiParent;
                    }
                    frmStat.WindowState = FormWindowState.Maximized;
                    frmStat.Show( );
                    break;
                case "Fun_Drug_Match":
                    HIS_BaseManager.FrmInsurMatch frmDrugMatch = new FrmInsurMatch(_chineseName, HIS.Base_BLL.Enums.MatchClass.ҩƷƥ�� ,currentUser );
                    if ( _mdiParent != null )
                    {
                        frmDrugMatch.MdiParent = _mdiParent;
                    }
                    frmDrugMatch.WindowState = FormWindowState.Maximized;
                    frmDrugMatch.Show();
                    break;
                case "Fun_Item_Match":
                    HIS_BaseManager.FrmInsurMatch frmItemMatch = new FrmInsurMatch( _chineseName , HIS.Base_BLL.Enums.MatchClass.��Ŀƥ�� , currentUser  );
                    if ( _mdiParent != null )
                    {
                        frmItemMatch.MdiParent = _mdiParent;
                    }
                    frmItemMatch.WindowState = FormWindowState.Maximized;
                    frmItemMatch.Show();
                    break;
                case "Fun_base_hospital_item":
                    HIS_BaseManager.FrmHospitalItems frmHospitalItems = new HIS_BaseManager.FrmHospitalItems( _chineseName , currentUser );
                    if ( _mdiParent != null )
                    {
                        frmHospitalItems.MdiParent = _mdiParent;
                    }
                    frmHospitalItems.WindowState = FormWindowState.Maximized;
                    frmHospitalItems.Show( );
                    break;
                case "Fun_base_template_hj":
                    HIS_BaseManager.FrmTemplate frmTemplate = new FrmTemplate( _chineseName , currentUser,currentDept ,0 );
                    if ( _mdiParent != null )
                    {
                        frmTemplate.MdiParent = _mdiParent;
                    }
                    frmTemplate.WindowState = FormWindowState.Maximized;
                    frmTemplate.Show( );
                    break;
                case "Fun_base_CreatePYWB":
                    HIS_BaseManager.FrmCreatePYWB frmPYWB = new FrmCreatePYWB( currentUser );
                    frmPYWB.ShowDialog( );
                    break;
                case "Fun_base_work_unit":
                    HIS_BaseManager.FrmWorkUnit frmWorkUnit = new FrmWorkUnit( _chineseName   );
                    if ( _mdiParent != null )
                    {
                        frmWorkUnit.MdiParent = _mdiParent;
                    }
                    frmWorkUnit.WindowState = FormWindowState.Maximized;
                    frmWorkUnit.Show( );
                    break;
                case "Fun_basedata_Vindicator":
                    HIS_BaseManager.��������ά��.FrmBaseDataVindicator frmBaseData = new HIS_BaseManager.��������ά��.FrmBaseDataVindicator( _chineseName, currentUser );
                    if ( _mdiParent != null )
                    {
                        frmBaseData.MdiParent = _mdiParent;
                    }
                    frmBaseData.WindowState = FormWindowState.Maximized;
                    frmBaseData.Show();
                    break;
                case "Fun_ParameterSetting":
                    HIS_BaseManager.FrmParameterSet frmParaset = new FrmParameterSet( _chineseName );
                    if ( _mdiParent != null )
                    {
                        frmParaset.MdiParent = _mdiParent;
                    }
                    frmParaset.WindowState = FormWindowState.Maximized;
                    frmParaset.Show();
                    
                    break;
                case "Fun_GH_BaseDataSet":
                    HIS_BaseManager.FrmRegBaseDataSet frmGhBaseDataSet = new HIS_BaseManager.FrmRegBaseDataSet();
                    frmGhBaseDataSet.ShowDialog();
                    break;
				default :
					throw new Exception("�����������ƴ���");
			}
		
		}
		/// <summary>
		/// ����һ��FORM����
		/// </summary>
		/// <returns></returns>
		public object GetObject()
		{
			return null;
		}
		/// <summary>
		/// ��ø�Dll����Ϣ
		/// </summary>
		/// <returns></returns>
		public ObjectInfo GetDllInfo()
		{
			ObjectInfo objectInfo;
            objectInfo.Name = "HIS_BaseManager";
			objectInfo.Text="��������ά��";
			objectInfo.Remark="";
			return objectInfo;
		}
		/// <summary>
		/// ��ø�Dll��������������Ϣ
		/// </summary>
		/// <returns></returns>
		public ObjectInfo[] GetFunctionsInfo()
		{
			ObjectInfo[] objectInfos=new ObjectInfo[17];
			

            objectInfos[0].Name = "Fxc_HisReport";
            objectInfos[0].Text = "�������";
            objectInfos[0].Remark = "";

            objectInfos[1].Name = "Fxc_DesReport";
            objectInfos[1].Text = "�������";
            objectInfos[1].Remark = "";

            objectInfos[2].Name = "Fun_GWM_EmpDeptSet";
            objectInfos[2].Text = "��Ա�ſ���Ϣ����";
            objectInfos[2].Remark = "������Ա�Ļ�����Ϣ����ְ���";

            objectInfos[3].Name = "Fxc_FrmInForSerch";
            objectInfos[3].Text = "���ϲ�ѯ";
            objectInfos[3].Remark = "";

            objectInfos[4].Name = "Fun_Base_Service_Items";
            objectInfos[4].Text = "����ҽ�Ʒ�����Ŀά��";
            objectInfos[4].Remark = "";

            objectInfos[5].Name = "Fun_FrmGBDictionary";
            objectInfos[5].Text = "������Ŀ�ֵ�";
            objectInfos[5].Remark = "";

            objectInfos[6].Name = "Fun_StatItem";
            objectInfos[6].Text = "ͳ�ƴ��༰����ά��";
            objectInfos[6].Remark = "";

            objectInfos[7].Name = "Fun_Drug_Match";
            objectInfos[7].Text = "��ũ��ҩƷƥ��";
            objectInfos[7].Remark = "";

            objectInfos[8].Name = "Fun_Item_Match";
            objectInfos[8].Text = "��ũ����Ŀƥ��";
            objectInfos[8].Remark = "";

            objectInfos[9].Name = "Fun_base_modulemenu";
            objectInfos[9].Text = "������˵�����";
            objectInfos[9].Remark = "";

            objectInfos[10].Name = "Fun_base_hospital_item";
            objectInfos[10].Text = "��Ժҽ�Ʒ�����Ŀά��";
            objectInfos[10].Remark = "";

            objectInfos[11].Name = "Fun_base_template_hj";
            objectInfos[11].Text = "������Ŀģ��ά��";
            objectInfos[11].Remark = "";

            objectInfos[12].Name = "Fun_base_CreatePYWB";
            objectInfos[12].Text = "ƴ�����������";
            objectInfos[12].Remark = "";

            objectInfos[13].Name = "Fun_base_work_unit";
            objectInfos[13].Text = "���˹�����λά��";
            objectInfos[13].Remark = "";

            objectInfos[14].Name = "Fun_basedata_Vindicator";
            objectInfos[14].Text = "������������ά��";
            objectInfos[14].Remark = "";

            objectInfos[15].Name = "Fun_ParameterSetting";
            objectInfos[15].Text = "ϵͳ��������";
            objectInfos[15].Remark = "";

            objectInfos[16].Name = "Fun_GH_BaseDataSet";
            objectInfos[16].Text = "�ҺŻ�������ά��";
            objectInfos[16].Remark = "";
			return objectInfos;
		}
		#endregion
		
		#endregion
	}
}
