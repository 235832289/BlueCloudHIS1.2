using System;
using System.Drawing;
using System.Drawing.Printing;
namespace HIS.MZ_BLL.Print
{
	/// <summary>
	/// ���﷢Ʊ��
	/// </summary>
	public class OPDInvoice : IInvoice
	{
        /// <summary>
        /// ���캯��
        /// </summary>
		public OPDInvoice()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
            paperInfo = PrintClass.GetPaperInfo( InvoiceType.���﷢Ʊ );
			paperSize = new PaperSize(paperInfo.PaperName,paperInfo.PaperWidth,paperInfo.PaperHeight );
		}
		private PaperSize paperSize ;
		private InvoicePaperInfo paperInfo;

		private string _hisName;
		private string _invoiceNo;
		private string _patientName;
		private string _departmentName;
		private int _year;
		private int _month;
		private int _day;
		private string _payee;
		private decimal _totalMoneynum;
		private string _totalMoneycn;
		private InvoiceItem[] _items;
		private string _doctorName;
		private string _outPatientNo;
        private string otherInfo="";
		#region IInvoice ��Ա
		/// <summary>
		/// ��Ʊ��
		/// </summary>
		public string InvoiceNo
		{
			get
			{
				// TODO:  ��� OPDInvoice.InvoiceNo getter ʵ��
				return _invoiceNo;
			}
			set
			{
				// TODO:  ��� OPDInvoice.InvoiceNo setter ʵ��
				_invoiceNo = value;
			}
		}

		/// <summary>
		/// ��������
		/// </summary>
		public string PatientName
		{
			get
			{
				// TODO:  ��� OPDInvoice.PatientName getter ʵ��
				return _patientName;
			}
			set
			{
				// TODO:  ��� OPDInvoice.PatientName setter ʵ��
				_patientName = value;
			}
		}

		/// <summary>
		/// ���˾������
		/// </summary>
		public string DepartmentName
		{
			get
			{
				// TODO:  ��� OPDInvoice.DepartmentName getter ʵ��
				return _departmentName;
			}
			set
			{
				// TODO:  ��� OPDInvoice.DepartmentName setter ʵ��
				_departmentName = value;
			}
		}
		/// <summary>
		/// ��Ʊ���ڣ���
		/// </summary>
		public int Year
		{
			get
			{
				// TODO:  ��� OPDInvoice.Year getter ʵ��
				return _year;
			}
			set
			{
				// TODO:  ��� OPDInvoice.Year setter ʵ��
				_year = value;
			}
		}
		/// <summary>
		/// ��Ʊ���ڣ���
		/// </summary>
		public int Month
		{
			get
			{
				// TODO:  ��� OPDInvoice.Month getter ʵ��
				return _month;
			}
			set
			{
				// TODO:  ��� OPDInvoice.Month setter ʵ��
				_month = value;
			}
		}
		/// <summary>
		/// ��Ʊ���ڣ���
		/// </summary>
		public int Day
		{
			get
			{
				// TODO:  ��� OPDInvoice.Day getter ʵ��
				return _day;
			}
			set
			{
				// TODO:  ��� OPDInvoice.Day setter ʵ��
				_day = value;
			}
		}

		/// <summary>
		/// �տ���
		/// </summary>
		public string Payee
		{
			get
			{
				// TODO:  ��� OPDInvoice.Payee getter ʵ��
				return _payee;
			}
			set
			{
				// TODO:  ��� OPDInvoice.Payee setter ʵ��
				_payee = value;
			}
		}
		/// <summary>
		/// �ܽ�Сд��
		/// </summary>
		public decimal TotalMoneyNum
		{
			get
			{
				// TODO:  ��� OPDInvoice.TotalMoneyNum getter ʵ��
				return _totalMoneynum;
			}
			set
			{
				// TODO:  ��� OPDInvoice.TotalMoneyNum setter ʵ��
				_totalMoneynum = value;
			}
		}
		/// <summary>
		/// �ܽ���д��
		/// </summary>
		public string TotalMoneyCN
		{
			get
			{
				// TODO:  ��� OPDInvoice.TotalMoneyCN getter ʵ��
				return _totalMoneycn;
			}
			set
			{
				// TODO:  ��� OPDInvoice.TotalMoneyCN setter ʵ��
				_totalMoneycn = value;
			}
		}
        /// <summary>
        /// ������Ϣ
        /// </summary>
        public string OtherInfo
        {
            get
            {
                return otherInfo;
            }
            set
            {
                otherInfo = value;
            }
        }
		#endregion
		/// <summary>
		/// ��Ʊ��Ŀ����
		/// </summary>
		public InvoiceItem[] Items
		{
			get
			{
				return _items;
			}
			set
			{
				_items = value;
			}
		}
		/// <summary>
		/// ҽԺ����
		/// </summary>
		public string HisName
		{
			get
			{
				return _hisName;
			}
			set
			{
				_hisName = value;
			}
		}
		/// <summary>
		/// ҽ��
		/// </summary>
		public string DoctorName
		{
			get
			{
				return _doctorName;
			}
			set
			{
				_doctorName = value;
			}
		}
		/// <summary>
		/// �����
		/// </summary>
		public string OutPatientNo
		{
			get
			{
				return _outPatientNo;
			}
			set
			{
				_outPatientNo = value;
			}
		}
		/// <summary>
		/// ��ӡ��Ʊ
		/// </summary>
		public virtual void Print()
		{
			PrintDocument doc = new PrintDocument();

			PrintController pc = new StandardPrintController();
			doc.PrintController = pc;
			doc.DefaultPageSettings.PrinterSettings.PrinterName = doc.PrinterSettings.PrinterName;
			doc.DefaultPageSettings.PaperSize = doc.PrinterSettings.DefaultPageSettings.PaperSize;
			doc.PrintPage+=new PrintPageEventHandler(doc_PrintPage);
			
			doc.Print();
			
		}
		/// <summary>
		/// Ԥ��
		/// </summary>
		public virtual void Preview()
		{
			PrintDocument doc = new PrintDocument();
			PageSettings ps = new PageSettings();
			ps.PaperSize = paperSize;
			ps.Margins = new Margins(paperInfo.Left,paperInfo.Right,paperInfo.Top,paperInfo.Bottom );
			
			doc.DefaultPageSettings = ps;
			
			System.Windows.Forms.PrintPreviewDialog dlg = new System.Windows.Forms.PrintPreviewDialog();
			doc.PrintPage+=new PrintPageEventHandler(doc_PrintPage);
			dlg.Document = doc;
			
			dlg.ShowDialog();
			doc.Dispose();
		}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void doc_PrintPage(object sender, PrintPageEventArgs e)
		{
			try
			{
				Font font=null;
				Brush brush = Brushes.Black;
				ItemPrintSetting setting;
				#region ��ӡ����
				//��ӡҽԺ����
				setting = PrintClass.GetItemPrintSetting( InvoiceType.���﷢Ʊ, "ҽԺ����" );
                if ( setting.NeedPrint )
                {
                    font = new Font( setting.FontName , setting.FontSize );
                    e.Graphics.DrawString( _hisName , font , brush , setting.X , setting.Y );
                }
				//��ӡ����
                setting = PrintClass.GetItemPrintSetting( InvoiceType.���﷢Ʊ , "����" );
                if ( setting.NeedPrint )
                {
                    font = new Font( setting.FontName , setting.FontSize );
                    e.Graphics.DrawString( _departmentName , font , brush , setting.X , setting.Y );
                }
				//��ӡҽ��
                setting = PrintClass.GetItemPrintSetting( InvoiceType.���﷢Ʊ , "ҽ��" );
                if ( setting.NeedPrint )
                {
                    font = new Font( setting.FontName , setting.FontSize );
                    e.Graphics.DrawString( _doctorName , font , brush , setting.X , setting.Y );
                }
				//��ӡ���Է�Ʊ��
                setting = PrintClass.GetItemPrintSetting( InvoiceType.���﷢Ʊ , "��Ʊ��" );
                if ( setting.NeedPrint )
                {
                    font = new Font( setting.FontName , setting.FontSize );
                    e.Graphics.DrawString( _invoiceNo , font , brush , setting.X , setting.Y );
                }
				//��ӡ������
                setting = PrintClass.GetItemPrintSetting( InvoiceType.���﷢Ʊ , "��" );
                if ( setting.NeedPrint )
                {
                    font = new Font( setting.FontName , setting.FontSize );
                    e.Graphics.DrawString( _year.ToString( ) , font , brush , setting.X , setting.Y );
                }
                setting = PrintClass.GetItemPrintSetting( InvoiceType.���﷢Ʊ , "��" );
                if ( setting.NeedPrint )
                {
                    font = new Font( setting.FontName , setting.FontSize );
                    e.Graphics.DrawString( _month.ToString( ) , font , brush , setting.X , setting.Y );
                }
                setting = PrintClass.GetItemPrintSetting( InvoiceType.���﷢Ʊ , "��" );
                if ( setting.NeedPrint )
                {
                    font = new Font( setting.FontName , setting.FontSize );
                    e.Graphics.DrawString( _day.ToString( ) , font , brush , setting.X , setting.Y );
                }
				//��ӡ��������
                setting = PrintClass.GetItemPrintSetting( InvoiceType.���﷢Ʊ , "����" );
                if ( setting.NeedPrint )
                {
                    font = new Font( setting.FontName , setting.FontSize );
                    e.Graphics.DrawString( _patientName , font , brush , setting.X , setting.Y );
                }
				//��ӡ�����
                setting = PrintClass.GetItemPrintSetting( InvoiceType.���﷢Ʊ , "�����" );
                if ( setting.NeedPrint )
                {
                    font = new Font( setting.FontName , setting.FontSize );
                    e.Graphics.DrawString( _outPatientNo , font , brush , setting.X , setting.Y );
                }
				//��ӡ��Ʊ��Ŀ
                setting = PrintClass.GetItemPrintSetting( InvoiceType.���﷢Ʊ , "��Ʊ��Ŀ" );
                if ( setting.NeedPrint )
                {
                    font = new Font( setting.FontName , setting.FontSize );
                    float x = setting.X;
                    float y = setting.Y;
                    for ( int i = 0 ; i < _items.Length ; i++ )
                    {
                        e.Graphics.DrawString( _items[i].ItemName + "��" + _items[i].ItemMoney.ToString( "0.0" ) + "Ԫ" , font , brush , x , y );
                        y = y + font.Height;
                    }
                }
				//��ӡСд���
                setting = PrintClass.GetItemPrintSetting( InvoiceType.���﷢Ʊ , "Сд���" );
                if ( setting.NeedPrint )
                {
                    font = new Font( setting.FontName , setting.FontSize );
                    e.Graphics.DrawString( _totalMoneynum.ToString( "0.0" ) + "Ԫ" , font , brush , setting.X , setting.Y );
                }
				//��ӡ��д���
                setting = PrintClass.GetItemPrintSetting( InvoiceType.���﷢Ʊ , "��д���" );
                if ( setting.NeedPrint )
                {
                    font = new Font( setting.FontName , setting.FontSize );
                    e.Graphics.DrawString( _totalMoneycn , font , brush , setting.X , setting.Y );
                }
				//��ӡ�տ���
                setting = PrintClass.GetItemPrintSetting( InvoiceType.���﷢Ʊ , "�տ���" );
                if ( setting.NeedPrint )
                {
                    font = new Font( setting.FontName , setting.FontSize );
                    e.Graphics.DrawString( _payee , font , brush , setting.X , setting.Y );
                }

                //������Ϣ
                setting = PrintClass.GetItemPrintSetting( InvoiceType.���﷢Ʊ , "������Ϣ" );
                if ( setting.NeedPrint )
                {
                    font = new Font( setting.FontName , setting.FontSize );
                    e.Graphics.DrawString( otherInfo , font , brush , setting.X , setting.Y );
                }
				#endregion
				
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
	}
}
