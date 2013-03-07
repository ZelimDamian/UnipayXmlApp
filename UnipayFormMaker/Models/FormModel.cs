using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using UnipayFormMaker.Fields;
using UnipayFormMaker.Pages;
using UnipayFormMaker.PaymentTypes;

namespace UnipayFormMaker
{
	public class FormModel
	{
		
		private int id = 0;
		private List<Page> pages = new List<Page>();
		private List<PaymentType> paymentTypes = new List<PaymentType>();

		private String name = "";

		public FormModel ()
		{
			pages.Add(new Page());
		}

		public FormModel (int id, List<Page> pages, List<PaymentType> paymentTypes)
		{
			this.id = id;
			this.pages = pages;
			this.paymentTypes = paymentTypes;
		}
		

		public int Id {
			get {
				return this.id;
			}
			set {
				id = value;
			}
		}

		public List<Page> Pages {
			get {
				return this.pages;
			}
			set {
				pages = value;
			}
		}

		public List<PaymentType> PaymentTypes {
			get {
				return this.paymentTypes;
			}
			set {
				paymentTypes = value;
			}
		}

		public string Name {
			get {
				return this.name;
			}
			set {
				name = value;
			}
		}
        
		public String GenerateXMLString()
		{
			StringBuilder result = new StringBuilder();
			
			XmlWriterSettings settings = new XmlWriterSettings();
			settings.Indent = true;
			settings.IndentChars = "\t";
			settings.OmitXmlDeclaration = true;
						
			XmlWriter writer = XmlWriter.Create(result, settings);

			writer.WriteComment(this.Name);
			writer.WriteStartElement("form");
			writer.WriteAttributeString("service-id", this.Id.ToString());

			foreach(PaymentType paymentType in PaymentTypes)
			{
				paymentType.AppendToXmlWriter(writer);
			}

			bool writeGroupTag = this.Pages.Count > 1;

			foreach(Page page in this.Pages)
			{
				page.AppendToXmlWriter(writer, writeGroupTag);
			}

			writer.WriteEndElement();

            writer.Flush();

			return result.ToString();
		}

		public List<object[]> GetFieldsAsObjects()
		{
			List<object[]> list = new List<object[]>();
			
			foreach(Page page in Pages)
			{
				list.AddRange(page.GetFieldsAsObjects());
			}
			
			return list;
		}
	}
}

