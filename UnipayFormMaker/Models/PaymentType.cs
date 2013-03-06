using System;
using System.Xml;
using System.Collections.Generic;

namespace UnipayFormMaker.PaymentTypes
{
	public class Item {
		String text = "";
		String value = "";

		public string Text {
			get {
				return this.text;
			}
			set {
				text = value;
			}
		}

		public string Value {
			get {
				return this.value;
			}
			set {
				this.value = value;
			}
		}

		public virtual void AppendToXMLWriter(XmlWriter writer)
		{

		}
	}

	public class ImageItem : Item
	{
		String imgSrc = "";

		public String ImgSrc
		{
			get {return this.imgSrc;}
			set {this.imgSrc = value;}
		}

		public override void AppendToXMLWriter(XmlWriter writer)
		{

					writer.WriteStartElement("item");
					writer.WriteAttributeString("img", this.ImgSrc);
					writer.WriteAttributeString("text", this.Text);
					writer.WriteAttributeString("value", this.Value);
					writer.WriteEndElement();
		}
	}

	public class TextItem : Item
	{

	}

	public class PaymentType
	{
		List<Item> items = new List<Item>();

		public PaymentType ()
		{

		}

		public void AppendToXmlWriter(XmlWriter writer)
		{
			writer.WriteStartElement("image-selector");
			writer.WriteAttributeString("name", "id2");
			writer.WriteAttributeString("message", "Выберите пакет каналов");
			
			foreach(Item item in items){

				item.AppendToXMLWriter(writer);
			}

			
			writer.WriteEndElement();
	
		}
	}


}