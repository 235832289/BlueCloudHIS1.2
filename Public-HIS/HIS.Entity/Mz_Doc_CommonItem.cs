using System;
namespace HIS.Model
{
    /// <summary>
    /// ������
    /// </summary>
	public class Mz_Doc_CommonItem
    {
        public Mz_Doc_CommonItem()
        { 
        }

        #region Model
        private int _commonitemid; //������ID
        private int _item_id;      //��ĿID
        private int _record_doc;   //����ҽ��
        private int _frequency;    //ʹ��Ƶ��
        private int _type;         //����������
        private int _delete_bit;   //ɾ����־
    
		/// <summary>
        /// ������ID
		/// </summary>
		public int CommonItemId
		{
			get{return _commonitemid;}
			set{_commonitemid = value ;}

		}
		
		/// <summary>
        /// ��ĿID
		/// </summary>
		public int Item_Id
		{
			get{return _item_id;}
			set{_item_id = value ;}

		}
		
		/// <summary>
        /// ����ҽ��
		/// </summary>
		public int Record_Doc
		{
			get{return _record_doc;}
			set{_record_doc = value ;}

		}
		
		/// <summary>
        ///  ʹ��Ƶ��
		/// </summary>
		public int Frequency
		{
			get{return _frequency;}
			set{_frequency = value ;}

		}

        /// <summary>
        /// ����������
        /// </summary>
        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }

		/// <summary>
        /// ɾ����־
		/// </summary>
		public int Delete_Bit
		{
			get{return _delete_bit;}
			set{_delete_bit = value ;}

        }
        #endregion Model
    }
}
