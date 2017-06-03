using System;
using System.Text ;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data;
namespace HIS.MZ_BLL.Print
{
	/// <summary>
	/// ��Ʊ����
	/// </summary>
	public enum InvoiceType
	{
        /// <summary>
        /// 
        /// </summary>
		���﷢Ʊ,
        /// <summary>
        /// 
        /// </summary>
        סԺ��Ʊ,
        /// <summary>
        /// 
        /// </summary>
        �Һŷ�Ʊ
	}
	/// <summary>
	/// ��Ʊ��Ŀ
	/// </summary>
	public struct InvoiceItem
	{
		/// <summary>
		/// ��Ʊ��Ŀ����
		/// </summary>
		public string ItemName;
		/// <summary>
		/// ��Ʊ���
		/// </summary>
		public decimal ItemMoney;
		/// <summary>
		/// ��ӡ����
		/// </summary>
		public ItemPrintSetting ItemSetting;
		/// <summary>
		/// ��������
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return ItemName ;
		}

	}
	/// <summary>
	/// ��Ʊ��ӡ����
	/// </summary>
	public struct ItemPrintSetting
	{
		/// <summary>
		/// ��ӡ��Ŀ��
		/// </summary>
		public string ItemName;
		/// <summary>
		/// ����
		/// </summary>
		public string FontName;
		/// <summary>
		/// �����С
		/// </summary>
		public int FontSize;
		/// <summary>
		/// X
		/// </summary>
		public float X;
		/// <summary>
		/// Y
		/// </summary>
		public float Y;
		/// <summary>
		/// ��������
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return ItemName;
		}
        /// <summary>
        /// ����Ҫ��ӡ
        /// </summary>
        public bool NeedPrint;

	}
	/// <summary>
	/// ��Ʊֽ����Ϣ
	/// </summary>
	public struct InvoicePaperInfo
	{
		/// <summary>
		/// ֽ������
		/// </summary>
		public string PaperName;
		/// <summary>
		/// ֽ�ſ��
		/// </summary>
		public int PaperWidth;
		/// <summary>
		/// ֽ�Ŵ�С
		/// </summary>
		public int PaperHeight;
		/// <summary>
		/// ����
		/// </summary>
		public int Top;
		/// <summary>
		/// �׾�
		/// </summary>
		public int Bottom;
		/// <summary>
		/// ���
		/// </summary>
		public int Left;
		/// <summary>
		/// �Ҿ�
		/// </summary>
		public int Right;
	}
    /// <summary>
    /// ����
    /// </summary>
	public class Const
	{
        /// <summary>
        /// ���﷢Ʊ��
        /// </summary>
		public  const int OPDInvoideDefaultWidth = 120;
        /// <summary>
        /// ���﷢Ʊ��
        /// </summary>
		public  const int OPDInvoideDefaultHeight = 95;
	}
	/// <summary>
	/// ��ӡ�����ࡣ
	/// </summary>
	public class PrintClass
	{
        /// <summary>
        /// �����ļ���
        /// </summary>
        public static readonly string ConfigFileName = "InvoiceSetting.xml";
        /// <summary>
        /// �����ļ�·��
        /// </summary>
        private static readonly string configFilePath = System.Windows.Forms.Application.StartupPath + "\\" + ConfigFileName;
        /// <summary>
        /// ���캯��
        /// </summary>
		public PrintClass()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}
        /// <summary>
        /// ��ȡָ�����ͷ�Ʊ��ӡ����
        /// </summary>
        /// <param name="invoiceType"></param>
        /// <param name="InvoiceItemName"></param>
        /// <returns></returns>
        public static ItemPrintSetting GetItemPrintSetting( InvoiceType invoiceType , string InvoiceItemName )
        {

            DataSet dsConfig = GetInvoiceSettingConfig( );
            string invoiceTypename = "";
            switch ( invoiceType )
            {
                case InvoiceType.���﷢Ʊ:
                    invoiceTypename = "�����շѷ�Ʊ";
                    break;
                case InvoiceType.�Һŷ�Ʊ:
                    invoiceTypename = "����Һŷ�Ʊ";
                    break;
            }
            DataRow[] drItems = dsConfig.Tables["INVOICE_ITEMS"].Select( "INVOICE_NAME = '" + invoiceTypename + "' and ITEM_NAME = '" + InvoiceItemName + "'" );
            ItemPrintSetting setting = new ItemPrintSetting( );
            if ( drItems.Length == 0 )
                return setting;

            string fontName = drItems[0]["FONT_NAME"].ToString( );
            string fontSize = drItems[0]["FONT_SIZE"].ToString( );
            string x = drItems[0]["X"].ToString( );
            string y = drItems[0]["Y"].ToString( );
            string needPrint = drItems[0]["NEED_PRINT"].ToString( );

            setting.ItemName = InvoiceItemName;
            setting.FontName = fontName;
            try
            {
                if ( fontSize != "" )
                    setting.FontSize = Convert.ToInt32( fontSize );
                if ( setting.FontSize <= 8 )
                    setting.FontSize = 8;
            }
            catch
            {
                setting.FontSize = 9;
            }
            try
            {
                if ( x.Trim( ) != "" )
                    setting.X = (float)Convert.ToDecimal( x );
            }
            catch
            {
                setting.X = 0;
            }
            try
            {
                if ( x.Trim( ) != "" )
                    setting.Y = (float)Convert.ToDecimal( y );
            }
            catch
            {
                setting.Y = 0;
            }
            try
            {
                if ( needPrint == "1" )
                    setting.NeedPrint = true;
            }
            catch
            {
                setting.NeedPrint = false;
            }
            return setting;
        }
        /// <summary>
        /// 
        /// </summary>
        public static void CreatePrintConfigFile()
        {
            if ( System.IO.File.Exists( configFilePath ) )
            {
                return;
            }
            try
            {
                #region ������Ʊ���ýṹ
                System.Data.DataTable tbInvoice = new System.Data.DataTable( "INVOICES" );
                tbInvoice.Columns.Add( "INVOICE_NAME" , Type.GetType( "System.String" ) );
                tbInvoice.Columns.Add( "PAPER_WIDTH" , Type.GetType( "System.Int32" ) );
                tbInvoice.Columns.Add( "PAPER_HEIGHT" , Type.GetType( "System.Int32" ) );

                System.Data.DataTable tbInvoiceItem = new System.Data.DataTable( "INVOICE_ITEMS" );

                tbInvoiceItem.Columns.Add( "INVOICE_NAME" , Type.GetType( "System.String" ) );
                tbInvoiceItem.Columns.Add( "ITEM_NAME" , Type.GetType( "System.String" ) );
                tbInvoiceItem.Columns.Add( "FONT_NAME" , Type.GetType( "System.String" ) );
                tbInvoiceItem.Columns.Add( "FONT_SIZE" , Type.GetType( "System.Int32" ) );
                tbInvoiceItem.Columns.Add( "X" , Type.GetType( "System.Int32" ) );
                tbInvoiceItem.Columns.Add( "Y" , Type.GetType( "System.Int32" ) );
                tbInvoiceItem.Columns.Add( "NEED_PRINT" , Type.GetType( "System.Int16" ) );
                #endregion

                #region ����Ĭ��ֵ(�շ�)
                //��Ʊ��
                tbInvoice.Rows.Add( new object[]{"�����շѷ�Ʊ",12.33,9.33}  );
                //��Ʊ��ϸ
                tbInvoiceItem.Rows.Add( new object[] { "�����շѷ�Ʊ" , "ҽԺ����" , "����" , 10 , 50 , 55 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "�����շѷ�Ʊ" , "����" , "����" , 9 , 90 , 115 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "�����շѷ�Ʊ" , "�����" , "����" , 9 , 270 , 115 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "�����շѷ�Ʊ" , "��" , "����" , 9 , 245 , 90 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "�����շѷ�Ʊ" , "��" , "����" , 9 , 300 , 90 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "�����շѷ�Ʊ" , "��" , "����" , 9 , 330 , 90 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "�����շѷ�Ʊ" , "��Ʊ��" , "����" , 9 , 50 , 85 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "�����շѷ�Ʊ" , "ҽ��" , "����" , 9 , 110 , 70 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "�����շѷ�Ʊ" , "����" , "����" , 9 , 50 , 70 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "�����շѷ�Ʊ" , "��д���" , "����" , 9 , 140 , 275 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "�����շѷ�Ʊ" , "Сд���" , "����" , 9 , 140 , 250 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "�����շѷ�Ʊ" , "�տ���" , "����" , 9 , 300 , 305 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "�����շѷ�Ʊ" , "��Ʊ��Ŀ" , "����" , 9 , 90 , 150 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "�����շѷ�Ʊ" , "������Ϣ" , "����" , 9 , 0 , 0 , 0 } );
                #endregion

                #region ����Ĭ��ֵ(�Һ�)
                //��Ʊ��  
                tbInvoice.Rows.Add( new object[]{ "����Һŷ�Ʊ",12.33,9.33} );
                //����
                tbInvoiceItem.Rows.Add( new object[] { "����Һŷ�Ʊ" , "�տλ" , "����" , 0 , 0 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "����Һŷ�Ʊ" , "�ﲡ�Ʊ�" , "����" , 0 , 0 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "����Һŷ�Ʊ" , "ҽ��" , "����" , 0 , 0 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "����Һŷ�Ʊ" , "��Ʊ��" , "����" , 0 , 0 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "����Һŷ�Ʊ" , "��" , "����" , 9 , 245 , 90 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "����Һŷ�Ʊ" , "��" , "����" , 9 , 300 , 90 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "����Һŷ�Ʊ" , "��" , "����" , 9 , 330 , 90 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "����Һŷ�Ʊ" , "����" , "����" , 9 , 90 , 115 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "����Һŷ�Ʊ" , "�����" , "����" , 9 , 270 , 115 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "����Һŷ�Ʊ" , "ҽʦְ��" , "����" , 0 , 0 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "����Һŷ�Ʊ" , "�Һŷ�" , "����" , 0 , 0 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "����Һŷ�Ʊ" , "����" , "����" , 0 , 0 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "����Һŷ�Ʊ" , "����" , "����" , 0 , 0 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "����Һŷ�Ʊ" , "���Ϸ�" , "����" , 0 , 0 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "����Һŷ�Ʊ" , "Сд���" , "����" , 9 , 140 , 250 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "����Һŷ�Ʊ" , "��д���" , "����" , 9 , 140 , 275 , 1 } );
                tbInvoiceItem.Rows.Add( new object[] { "����Һŷ�Ʊ" , "�տ���" , "����" , 9 , 300 , 305 , 1 } );
                #endregion

                System.Data.DataSet dsInvocies = new System.Data.DataSet( "��Ʊ����" );
                dsInvocies.Tables.Add( tbInvoice );
                dsInvocies.Tables.Add( tbInvoiceItem );

                dsInvocies.WriteXml( configFilePath );
            }
            catch ( Exception err )
            {
                ErrorWriter.WriteLog( err.Message );
                throw new Exception( "������Ʊ��ӡ�����ļ�����" );
            }
        }
        /// <summary>
        /// ��ȡ�����ļ�
        /// </summary>
        /// <returns></returns>
        private static System.Data.DataSet GetInvoiceSettingConfig()
        {
            System.Data.DataSet ds = new System.Data.DataSet( );
            ds.ReadXml( configFilePath  );
            return ds;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoiceType"></param>
        /// <returns></returns>
        public static System.Data.DataTable GetInvoiceItemSetting(InvoiceType invoiceType)
        {
            System.Data.DataSet ds = GetInvoiceSettingConfig( );
            string invoiceName = "�����շѷ�Ʊ";
            if ( invoiceType == InvoiceType.�Һŷ�Ʊ )
                invoiceName = "����Һŷ�Ʊ";
            DataRow[] drs = ds.Tables["INVOICE_ITEMS"].Select( "INVOICE_NAME='" + invoiceName + "'" );

            DataTable tb = ds.Tables["INVOICE_ITEMS"].Clone( );
            tb.Columns["NEED_PRINT"].DataType = Type.GetType( "System.Int16" );
            foreach ( DataRow dr in drs )
                tb.Rows.Add( dr.ItemArray );

            return tb;
            
        }
        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="invoiceType">��Ʊ����</param>
        /// <param name="dtSetting">��������</param>
        /// <returns></returns>
        public static bool SaveSetting( InvoiceType invoiceType ,DataTable dtSetting)
        {
            try
            {
                System.Data.DataSet ds = GetInvoiceSettingConfig( );
                string invoiceName = "�����շѷ�Ʊ";
                if ( invoiceType == InvoiceType.�Һŷ�Ʊ )
                    invoiceName = "����Һŷ�Ʊ";
                DataRow[] drs = ds.Tables["INVOICE_ITEMS"].Select( "INVOICE_NAME='" + invoiceName + "'" );
                foreach ( DataRow dr in drs )
                    ds.Tables["INVOICE_ITEMS"].Rows.Remove( dr );
                foreach ( DataRow dr in dtSetting.Rows )
                    ds.Tables["INVOICE_ITEMS"].Rows.Add( dr.ItemArray );

                ds.WriteXml( configFilePath );
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// ��ȡֽ����Ϣ
        /// </summary>
        /// <returns></returns>
        public static InvoicePaperInfo GetPaperInfo( InvoiceType invoiceType )
        {
            InvoicePaperInfo paperInfo = new InvoicePaperInfo( );
            switch ( invoiceType )
            {
                case InvoiceType.���﷢Ʊ:
                    paperInfo.PaperName = "���﷢Ʊ";
                    paperInfo.Bottom = 0;
                    paperInfo.Left = 0;
                    paperInfo.PaperHeight = 333;
                    paperInfo.PaperWidth = 433;
                    paperInfo.Right = 0;
                    paperInfo.Top = 0;
                    break;
            }
            return paperInfo;
        }

	}
}
