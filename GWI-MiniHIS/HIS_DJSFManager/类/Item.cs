using System;

namespace HIS_DJSFManager.��
{
	/// <summary>
	/// Item ��ժҪ˵����
	/// </summary>
	public class Item
	{
		private string _text;
		private object _value;
		/// <summary>
		/// ����һ��Item����
		/// </summary>
		public Item()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
			_text="";
			_value=null;
		}
		/// <summary>
		/// ���û��߷���Item�����Text
		/// </summary>
		public string Text
		{
			get{return _text;}
			set{_text=value;}
		}
		/// <summary>
		/// ���û��߷���Item�����Value
		/// </summary>
		public object Value
		{
			get{return _value;}
			set{_value=value;}
		}
		/// <summary>
		/// ����Item�����Text
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return _text;
		}

	}
}
