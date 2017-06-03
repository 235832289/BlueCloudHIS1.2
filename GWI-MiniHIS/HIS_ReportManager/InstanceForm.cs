using System;
using System.Windows.Forms;
using GWMHIS.BussinessLogicLayer.Interfaces;
using System.Data;
using HIS.SYSTEM.PubicBaseClasses;
namespace HIS_ReportManager
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
        private long _currentGroupId;
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

        public long CurrentGroupId
        {
            get 
            {
                return _currentGroupId;
            }
            set
            {
                _currentGroupId=value;
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
            Form fMain = null;

            string sql;
            

            GWMHIS.BussinessLogicLayer.Classes.User currentUser = new GWMHIS.BussinessLogicLayer.Classes.User( _currentUserId );
            GWMHIS.BussinessLogicLayer.Classes.Deptment currentDept = new GWMHIS.BussinessLogicLayer.Classes.Deptment(_currentDeptId);
            GWMHIS.BussinessLogicLayer.Classes.Group currentGroup = new GWMHIS.BussinessLogicLayer.Classes.Group();
           

			switch(_functionName)
			{
                case "Fxc_HisReport":
                    fMain = new FrmReport(currentUser,currentDept );//(_currentUserId, _currentDeptId, _chineseName);
                    if (_mdiParent != null)
                    {
                        fMain.MdiParent = _mdiParent;
                    }
                    fMain.WindowState = FormWindowState.Maximized;
                    fMain.BringToFront();
                    fMain.Show();
					break;
                case "Fxc_HisReportShow":
                    fMain = new FrmReportShow(currentUser, currentDept, currentUser.GetGroupInfo());//(_currentUserId, _currentDeptId, _chineseName);
                    if (_mdiParent != null)
                    {
                        fMain.MdiParent = _mdiParent;
                    }
                    fMain.WindowState = FormWindowState.Maximized;
                    fMain.BringToFront();
                    fMain.Show();
                    break;
                case "Fun_ReportPermission":
                    fMain = new FrmReportGroup();// frmReportPermissionManager();
                    if (_mdiParent != null)
                    {
                        fMain.MdiParent = _mdiParent;
                    }
                    fMain.WindowState = FormWindowState.Maximized;
                    fMain.BringToFront();
                    fMain.Show();
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
            objectInfo.Name = "HIS_ReportManager";
			objectInfo.Text="�����������";
			objectInfo.Remark="";
			return objectInfo;
		}
		/// <summary>
		/// ��ø�Dll��������������Ϣ
		/// </summary>
		/// <returns></returns>
		public ObjectInfo[] GetFunctionsInfo()
		{
			ObjectInfo[] objectInfos=new ObjectInfo[3];
			

            objectInfos[0].Name = "Fxc_HisReport";
            objectInfos[0].Text = "�������";
            objectInfos[0].Remark = "";

            objectInfos[1].Name = "Fxc_HisReportShow";
            objectInfos[1].Text = "����չʾ";
            objectInfos[1].Remark = "";

            objectInfos[2].Name = "Fun_ReportPermission";
            objectInfos[2].Text = "����Ȩ�޹���";
            objectInfos[2].Remark = "";

            
			return objectInfos;
		}
		#endregion
		
		#endregion
	}
}
