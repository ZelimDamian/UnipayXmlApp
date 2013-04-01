using System;
using System.Xml;
using System.Collections.Generic;
using UnipayFormMaker.Fields;

namespace UnipayFormMaker.Pages
{
	public class Page
	{
		List<Field> fields = new List<Field>();

		public List<Field> Fields
		{
			set { this.fields = value; }
			get { return this.fields;  }
		}

		public Page ()
		{
		}

		public void AppendToXmlWriter(XmlWriter writer, bool writeBoolTag)
		{
			if(writeBoolTag)
			{
				writer.WriteStartElement("field-group");
			}

			foreach(Field field in this.Fields)
			{
				field.AppendToXmlWriter(writer);
			}

			if(writeBoolTag)
			{
				writer.WriteEndElement();
			}
		}

		public List<object[]> GetFieldsAsObjects()
		{
			List<object[]> list = new List<object[]>();
			
			foreach(Field field in Fields)
			{
				list.Add(new object[]{ field.Name });
			}
			
			return list;
		}

		public String AggregateFieldNames()
		{
			String acc = "";

			foreach(Field field in this.Fields)
			{
				acc += field.Name + ", ";
			}

			return acc;
		}
	}
}

