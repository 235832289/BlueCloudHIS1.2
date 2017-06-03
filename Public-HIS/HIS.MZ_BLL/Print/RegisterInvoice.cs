using System;
using System.Drawing;
using System.Drawing.Printing;

namespace HIS.MZ_BLL.Print
{
    /// <summary>
    /// �Һŷ�Ʊ��
    /// </summary>
    public class RegisterInvoice : OPDInvoice
    {
        /// <summary>
        /// �Һż���
        /// </summary>
        private string register_type;
        /// <summary>
        /// �Һŷ�
        /// </summary>
        private string register_fee;
        /// <summary>
        /// ����
        /// </summary>
        private string jerque_fee;
        /// <summary>
        /// ����
        /// </summary>
        private string examine_fee;
        /// <summary>
        /// ���Ϸ�
        /// </summary>
        private string material_fee;
        /// <summary>
        /// �Һŷ�
        /// </summary>
        public string RegisterFee
        {
            get
            {
                return register_fee;
            }
            set
            {
                register_fee = value;
            }
        }
        /// <summary>
        /// ����
        /// </summary>
        public string JerqueFee
        {
            get
            {
                return jerque_fee;
            }
            set
            {
                jerque_fee = value;
            }
        }
        /// <summary>
        /// ����
        /// </summary>
        public string ExamineFee
        {
            get
            {
                return examine_fee;
            }
            set
            {
                examine_fee = value;
            }
        }
        /// <summary>
        /// ���Ϸ�
        /// </summary>
        public string  MaterialFee
        {
            get
            {
                return material_fee;
            }
            set
            {
                material_fee = value; 
            }
        }
        /// <summary>
        /// �Һ�����
        /// </summary>
        public string RegisterType
        {
            get
            {
                return register_type;
            }
            set
            {
                register_type = value;
            }
        }
        /// <summary>
        /// ��ӡ
        /// </summary>
        public override void Print()
        {
            PrintDocument doc = new PrintDocument( );

            PrintController pc = new StandardPrintController( );
            doc.PrintController = pc;
            doc.DefaultPageSettings.PrinterSettings.PrinterName = doc.PrinterSettings.PrinterName;
            doc.DefaultPageSettings.PaperSize = doc.PrinterSettings.DefaultPageSettings.PaperSize;
            doc.PrintPage += new PrintPageEventHandler( doc_PrintPage );

            doc.Print( );
        }
        /// <summary>
        /// Ԥ��
        /// </summary>
        public override void Preview()
        {
            PrintDocument doc = new PrintDocument( );
            //PageSettings ps = new PageSettings( );
            //ps.PaperSize = paperSize;
            //ps.Margins = new Margins( paperInfo.Left , paperInfo.Right , paperInfo.Top , paperInfo.Bottom );

            //doc.DefaultPageSettings = ps;

            System.Windows.Forms.PrintPreviewDialog dlg = new System.Windows.Forms.PrintPreviewDialog( );
            doc.PrintPage += new PrintPageEventHandler( doc_PrintPage );
            dlg.Document = doc;

            dlg.ShowDialog( );
            doc.Dispose( );
        }

        private void doc_PrintPage( object sender , PrintPageEventArgs e )
        {
            try
            {
                Font font = null;
                Brush brush = Brushes.Black;
                ItemPrintSetting setting;
                #region ��ӡ����
                //��ӡҽԺ����
                setting = PrintClass.GetItemPrintSetting( InvoiceType.�Һŷ�Ʊ, "�տλ" );
                font = new Font( setting.FontName , setting.FontSize );
                e.Graphics.DrawString( base.HisName , font , brush , setting.X , setting.Y );
                //��ӡ����
                setting = PrintClass.GetItemPrintSetting( InvoiceType.�Һŷ�Ʊ , "�ﲡ�Ʊ�" );
                font = new Font( setting.FontName , setting.FontSize );
                e.Graphics.DrawString( base.DepartmentName , font , brush , setting.X , setting.Y );
                //��ӡҽ��
                setting = PrintClass.GetItemPrintSetting( InvoiceType.�Һŷ�Ʊ , "ҽ��" );
                font = new Font( setting.FontName , setting.FontSize );
                e.Graphics.DrawString( base.DoctorName , font , brush , setting.X , setting.Y );
                //��ӡ���Է�Ʊ��
                setting = PrintClass.GetItemPrintSetting( InvoiceType.�Һŷ�Ʊ , "��Ʊ��" );
                font = new Font( setting.FontName , setting.FontSize );
                e.Graphics.DrawString( base.InvoiceNo , font , brush , setting.X , setting.Y );
                //��ӡ������
                setting = PrintClass.GetItemPrintSetting( InvoiceType.�Һŷ�Ʊ , "��" );
                font = new Font( setting.FontName , setting.FontSize );
                e.Graphics.DrawString( base.Year.ToString( ) , font , brush , setting.X , setting.Y );
                setting = PrintClass.GetItemPrintSetting( InvoiceType.�Һŷ�Ʊ , "��" );
                font = new Font( setting.FontName , setting.FontSize );
                e.Graphics.DrawString( base.Month.ToString( ) , font , brush , setting.X , setting.Y );
                setting = PrintClass.GetItemPrintSetting( InvoiceType.�Һŷ�Ʊ , "��" );
                font = new Font( setting.FontName , setting.FontSize );
                e.Graphics.DrawString( base.Day.ToString( ) , font , brush , setting.X , setting.Y );
                //��ӡ��������
                setting = PrintClass.GetItemPrintSetting( InvoiceType.�Һŷ�Ʊ , "����" );
                font = new Font( setting.FontName , setting.FontSize );
                e.Graphics.DrawString( base.PatientName , font , brush , setting.X , setting.Y );
                //��ӡ�����
                setting = PrintClass.GetItemPrintSetting( InvoiceType.�Һŷ�Ʊ , "�����" );
                font = new Font( setting.FontName , setting.FontSize );
                e.Graphics.DrawString( base.OutPatientNo , font , brush , setting.X , setting.Y );
                //��ӡ�Һż���
                setting = PrintClass.GetItemPrintSetting( InvoiceType.�Һŷ�Ʊ , "ҽʦְ��" );
                font = new Font( setting.FontName , setting.FontSize );
                e.Graphics.DrawString( register_type , font , brush , setting.X , setting.Y );
                //��ӡ��Ʊ��Ŀ
                setting = PrintClass.GetItemPrintSetting( InvoiceType.�Һŷ�Ʊ , "�Һŷ�" );
                font = new Font( setting.FontName , setting.FontSize );
                e.Graphics.DrawString( register_fee , font , brush , setting.X , setting.Y );
                //��ӡ����
                setting = PrintClass.GetItemPrintSetting( InvoiceType.�Һŷ�Ʊ , "����" );
                font = new Font( setting.FontName , setting.FontSize );
                e.Graphics.DrawString( examine_fee , font , brush , setting.X , setting.Y );
                //��ӡ����
                setting = PrintClass.GetItemPrintSetting( InvoiceType.�Һŷ�Ʊ , "����" );
                font = new Font( setting.FontName , setting.FontSize );
                e.Graphics.DrawString( jerque_fee , font , brush , setting.X , setting.Y );
                //��ӡ���Ϸ�
                setting = PrintClass.GetItemPrintSetting( InvoiceType.�Һŷ�Ʊ , "���Ϸ�" );
                font = new Font( setting.FontName , setting.FontSize );
                e.Graphics.DrawString( material_fee , font , brush , setting.X , setting.Y );

                //��ӡСд���
                //setting = PrintClass.GetItemPrintSetting( InvoiceType.�Һŷ�Ʊ , "Сд���" );
                //font = new Font( setting.FontName , setting.FontSize );
                //e.Graphics.DrawString( base.TotalMoneyNum.ToString( "0.0" ) + "Ԫ" , font , brush , setting.X , setting.Y );
                //��ӡ��д���
                setting = PrintClass.GetItemPrintSetting( InvoiceType.�Һŷ�Ʊ , "��д���" );
                font = new Font( setting.FontName , setting.FontSize );
                e.Graphics.DrawString( base.TotalMoneyCN , font , brush , setting.X , setting.Y );
                //��ӡ�տ���
                setting = PrintClass.GetItemPrintSetting( InvoiceType.�Һŷ�Ʊ , "�տ���" );
                font = new Font( setting.FontName , setting.FontSize );
                e.Graphics.DrawString( base.Payee , font , brush , setting.X , setting.Y );

                //������Ϣ
                setting = PrintClass.GetItemPrintSetting( InvoiceType.�Һŷ�Ʊ , "������Ϣ" );
                font = new Font( setting.FontName , setting.FontSize );
                e.Graphics.DrawString( base.OtherInfo , font , brush , setting.X , setting.Y );
                #endregion

            }
            catch ( Exception ex )
            {
                ErrorWriter.WriteLog( ex.Message );
                throw new Exception("��ӡ��������");
            }
        }


    }
}
