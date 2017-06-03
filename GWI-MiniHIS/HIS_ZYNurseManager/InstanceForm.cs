using System;
using System.Windows.Forms;
using GWMHIS.BussinessLogicLayer.Interfaces;
using HIS.SYSTEM.PubicBaseClasses;


namespace HIS_ZYNurseManager
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
                _functionName = value;
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
                _chineseName = value;
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
                _currentUserId = value;
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
                _currentDeptId = value;
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
                _menuId = value;
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
                _mdiParent = value;
            }
        }
        #endregion

        #region ����
        /// <summary>
        /// ���ݺ�������ʵ��������
        /// </summary>
        public void InstanceXcForm()
        {
            if (_functionName == "")
            {
                throw new Exception("��������������Ϊ�գ�");
            }

            switch (_functionName)
            {
                case "FrmPatOut":

                    FrmPatOut frmPatOut = new FrmPatOut(_currentUserId, _currentDeptId, _chineseName);
                    if (_mdiParent != null)
                    {
                        frmPatOut.MdiParent = _mdiParent;
                    }
                    frmPatOut.WindowState = FormWindowState.Maximized;
                    frmPatOut.Show();
                    break;

                case "FrmInsertNewBed":

                    FrmInsertNewBed frmInsertNewBed = new FrmInsertNewBed(_currentUserId, _currentDeptId, _chineseName, false);
                    if (_mdiParent != null)
                    {
                        frmInsertNewBed.MdiParent = _mdiParent;
                    }
                    frmInsertNewBed.WindowState = FormWindowState.Maximized;
                    frmInsertNewBed.Show();
                    break;

                //�����Ҵ�λά��
                case "FrmInsertBedCurrDept":
                    FrmInsertNewBed frmInsertBedCurrDept = new FrmInsertNewBed(_currentUserId, _currentDeptId, _chineseName, true);
                    if (_mdiParent != null)
                    {
                        frmInsertBedCurrDept.MdiParent = _mdiParent;
                    }
                    frmInsertBedCurrDept.WindowState = FormWindowState.Maximized;
                    frmInsertBedCurrDept.Show();
                    break;

                case "FrmOrderTrans":

                    FrmOrderTrans frmOrderTrans = new FrmOrderTrans(_currentUserId, _currentDeptId, _chineseName);
                    if (_mdiParent != null)
                    {
                        frmOrderTrans.MdiParent = _mdiParent;
                    }
                    frmOrderTrans.WindowState = FormWindowState.Maximized;
                    frmOrderTrans.Show();
                    break;

                case "FrmOrderManager":

                    FrmOrderManager frmOrderManager = new FrmOrderManager(_currentUserId, _currentDeptId, _chineseName);
                    if (_mdiParent != null)
                    {
                        frmOrderManager.MdiParent = _mdiParent;
                    }
                    frmOrderManager.WindowState = FormWindowState.Maximized;
                    frmOrderManager.Show();
                    break;
                case "FrmFeeInput":

                    FrmFeeInput frmFeeInput = new FrmFeeInput(_currentUserId, _currentDeptId, _chineseName);
                    if (_mdiParent != null)
                    {
                        frmFeeInput.MdiParent = _mdiParent;
                    }
                    frmFeeInput.WindowState = FormWindowState.Maximized;
                    frmFeeInput.Show();
                    break;
                case "FrmBedShow":

                    FrmBedShow frmBedShow = new FrmBedShow(_currentUserId, _currentDeptId, _chineseName);
                    if (_mdiParent != null)
                    {
                        frmBedShow.MdiParent = _mdiParent;
                    }
                    frmBedShow.WindowState = FormWindowState.Maximized;
                    frmBedShow.Show();
                    break;              

                case "FrmOrderExec":

                    FrmOrderExec frmOrderExec = new FrmOrderExec(_currentUserId, _currentDeptId, _chineseName);
                    if (_mdiParent != null)
                    {
                        frmOrderExec.MdiParent = _mdiParent;
                    }
                    frmOrderExec.WindowState = FormWindowState.Maximized;
                    frmOrderExec.Show();
                    break;
                case "FrmAccountCheck":

                    FrmAccountCheck frmaccountcheck = new FrmAccountCheck(_currentUserId, _currentDeptId, _chineseName);
                    if (_mdiParent != null)
                    {
                        frmaccountcheck.MdiParent = _mdiParent;
                    }
                    frmaccountcheck.WindowState = FormWindowState.Maximized;
                    frmaccountcheck.Show();
                    break;          
                case "FrmOrderPrint":
                    FrmOrderPrint frmOrderPrint = new FrmOrderPrint(-1, _currentUserId, _currentDeptId, _chineseName);
                    if (_mdiParent != null)
                    {
                        frmOrderPrint.MdiParent = _mdiParent;
                    }
                    frmOrderPrint.WindowState = FormWindowState.Maximized;
                    frmOrderPrint.Show();
                    break;
                case "FrmFeeModel":
                    FrmFeeModel frmfeeModel = new FrmFeeModel(_currentUserId, _currentDeptId);
                    if (_mdiParent != null)
                    {
                        frmfeeModel.MdiParent = _mdiParent;
                    }
                    frmfeeModel.WindowState = FormWindowState.Maximized;
                    frmfeeModel.Show();
                    break;
                default:
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
            objectInfo.Name = "HIS_ZYNurseManager        ";
            objectInfo.Text = "סԺ��ʿվϵͳ";
            objectInfo.Remark = "סԺ��ʿվϵͳ";
            return objectInfo;
        }
        /// <summary>
        /// ��ø�Dll��������������Ϣ
        /// </summary>
        /// <returns></returns>
        public ObjectInfo[] GetFunctionsInfo()
        {
            ObjectInfo[] objectInfos = new ObjectInfo[13];

            objectInfos[0].Name = "FrmPatOut";
            objectInfos[0].Text = "���˳���";
            objectInfos[0].Remark = "���˳���";

            objectInfos[1].Name = "FrmInsertNewBed";
            objectInfos[1].Text = "��λά��";
            objectInfos[1].Remark ="��λά��";

            objectInfos[2].Name = "FrmOrderTrans";
            objectInfos[2].Text = "ҽ��ת��";
            objectInfos[2].Remark = "ҽ��ת��";

            objectInfos[3].Name = "FrmOrderManager";
            objectInfos[3].Text = "ҽ������";
            objectInfos[3].Remark = "ҽ������";

            objectInfos[4].Name = "FrmFeeInput";
            objectInfos[4].Text = "�˵�¼��";
            objectInfos[4].Remark = "ҽ������";

            objectInfos[5].Name = "FrmBedShow";
            objectInfos[5].Text = "��λ����";
            objectInfos[5].Remark = "��λ����";

            objectInfos[6].Name = "FrmBedAssign";
            objectInfos[6].Text = "��λ����";
            objectInfos[6].Remark = "��λ����";

            objectInfos[7].Name = "FrmOrderExec";
            objectInfos[7].Text = "ҽ��ִ��";
            objectInfos[7].Remark = "ҽ��ִ��";

            objectInfos[8].Name = "FrmAccountCheck";
            objectInfos[8].Text = "���ú˶�";
            objectInfos[8].Remark = "���ú˶�";

            objectInfos[9].Name = "FrmInsertBedCurrDept";
            objectInfos[9].Text = "���Ҵ�λά��";
            objectInfos[9].Remark = "���Ҵ�λά��";

            objectInfos[10].Name = "FrmAllOrderManager";
            objectInfos[10].Text = "ҽ������(ȫ)";
            objectInfos[10].Remark = "ҽ������(ȫ)";

            objectInfos[11].Name = "FrmOrderPrint";
            objectInfos[11].Text = "ҽ����ӡ";
            objectInfos[11].Remark = "ҽ����ӡ";


            objectInfos[12].Name = "FrmFeeModel";
            objectInfos[12].Text = "��ʿ�˵�ģ��ά��";
            objectInfos[12].Remark = "��ʿ�˵�ģ��ά��";


            return objectInfos;
        }
        #endregion


        #endregion
    }
}
