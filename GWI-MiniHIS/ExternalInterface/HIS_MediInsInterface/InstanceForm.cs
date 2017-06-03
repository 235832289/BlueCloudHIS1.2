using System;
using System.Windows.Forms;
using GWMHIS.BussinessLogicLayer.Interfaces;
using HIS.SYSTEM.PubicBaseClasses;

namespace HIS_MediInsInterface
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
            GWMHIS.BussinessLogicLayer.Classes.User currentUser = new GWMHIS.BussinessLogicLayer.Classes.User(_currentUserId);
            GWMHIS.BussinessLogicLayer.Classes.Deptment currentDept = new GWMHIS.BussinessLogicLayer.Classes.Deptment(_currentDeptId);
			switch(_functionName)
			{

                case "Fxc_InsurMatchItem":
                    FrmInsurMatch frmItemMatch = new FrmInsurMatch(_chineseName, HIS.Base_BLL.Enums.MatchClass.��Ŀƥ��, currentUser);
                    if (_mdiParent != null)
                    {
                        frmItemMatch.MdiParent = _mdiParent;
                    }
                    frmItemMatch.WindowState = FormWindowState.Maximized;
                    frmItemMatch.Show();
                    break;
                case "Fxc_InsurMatchDrug":
                    FrmInsurMatch frmDrugMatch = new FrmInsurMatch(_chineseName, HIS.Base_BLL.Enums.MatchClass.ҩƷƥ��, currentUser);
                    if (_mdiParent != null)
                    {
                        frmDrugMatch.MdiParent = _mdiParent;
                    }
                    frmDrugMatch.WindowState = FormWindowState.Maximized;
                    frmDrugMatch.Show();
                    break;
                case "Fxc_PresOrderUpload":
                    FrmPatCostUpdate frmpatcu = new FrmPatCostUpdate();
                    if (_mdiParent != null)
                    {
                        frmpatcu.MdiParent = _mdiParent;
                    }
                    frmpatcu.currentDeptId = _currentDeptId;
                    frmpatcu.currentUserId = _currentUserId;
                    frmpatcu.chineseName = _chineseName;
                    frmpatcu.WindowState = FormWindowState.Maximized;
                    frmpatcu.Show();
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
            objectInfo.Name = "HIS_MediInsInterface";
			objectInfo.Text="ҽ�Ʊ��սӿ�";
            objectInfo.Remark = "ҽ�Ʊ��սӿ�";
			return objectInfo;
		}
		/// <summary>
		/// ��ø�Dll��������������Ϣ
		/// </summary>
		/// <returns></returns>
		public ObjectInfo[] GetFunctionsInfo()
		{
			ObjectInfo[] objectInfos=new ObjectInfo[3];

			objectInfos[0].Name="Fxc_InsurMatchItem";
			objectInfos[0].Text="��Ŀƥ��";
            objectInfos[0].Remark = "��Ŀƥ��";

            objectInfos[1].Name = "Fxc_InsurMatchDrug";
			objectInfos[1].Text="ҩƷƥ��";
            objectInfos[1].Remark = "ҩƷƥ��";

            objectInfos[2].Name = "Fxc_PresOrderUpload";
            objectInfos[2].Text = "�����ϴ�";
            objectInfos[2].Remark = "�����ϴ�";

			return objectInfos;
		}
		#endregion
		
		#endregion
	}
}
