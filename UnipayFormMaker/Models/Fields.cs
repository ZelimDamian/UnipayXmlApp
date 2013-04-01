using System;
using System.Xml;

namespace UnipayFormMaker.Fields
{
	public class Field
	{
		public static String[] KeyboardList = new string[]{
			"Digital",
         	"LetterEn",
         	"LetterEnRu",
         	"Digital",
         	"letter:ru:any::upper:true"
		};

		public static class KeyboardType
		{
			public const String Digital = 		"Digital";
			public const String Letters = 		"LetterEn";
			public const String LettersEnRu = 	"LetterEnRu";
			public const String Latinic = 		"Digital";
			public const String CyrillicUpper = "letter:ru:any::upper:true";
		}

		String name;
		String keyboard = KeyboardType.Digital;
		int maxLen = 255;
		String example = "";
		String message = "";
		String title = "";
		String regex = "";
		String split = "";
		String help = "";


		public string Name {
			get {
				return this.name;
			}
			set {
				name = value;
			}
		}

		public string Keyboard {
			get {
				return this.keyboard;
			}
			set {
				keyboard = value;
			}
		}

		public int MaxLen {
			get {
				return this.maxLen;
			}
			set {
				maxLen = value;
			}
		}

		public string Example {
			get {
				return this.example;
			}
			set {
				example = value;
			}
		}

		public string Message {
			get {
				return this.message;
			}
			set {
				message = value;
			}
		}

		public string Title {
			get {
				return this.title;
			}
			set {
				title = value;
			}
		}

		public string Regex {
			get {
				return this.regex;
			}
			set {
				this.regex = value;
			}
		}

		public string Split {
			get {
				return this.split;
			}
			set {
				split = value;
			}
		}

		public string Help {
			get {
				return this.help;
			}
			set {
				help = value;
			}
		}

		private String text = "textfield";
		
		public String Text {
			get { return this.text; }
			set { this.text = value; }
		}
		
		public void AppendToXmlWriter(XmlWriter writer)
		{
			writer.WriteStartElement("text-field");
			
			writer.WriteAttributeString("name", this.Name);
			writer.WriteAttributeString("keyboard", this.Keyboard);
			writer.WriteAttributeString("max-len", this.MaxLen.ToString());
			writer.WriteAttributeString("example", this.Example);
			writer.WriteAttributeString("message", this.Message);
			
			if(this.Regex.Length != 0)
			{
				writer.WriteStartElement("verify");
				writer.WriteStartElement("rule");
				writer.WriteAttributeString("regex", this.Regex);
				writer.WriteEndElement();
				writer.WriteEndElement();
			}

			if(this.Split.Length != 0)
			{
				writer.WriteStartElement("split");
				writer.WriteAttributeString("default", this.Split);
				writer.WriteEndElement();
			}

			if(this.Help.Length > 3)
			{
				writer.WriteStartElement("help");
				writer.WriteCData(this.Help);
				writer.WriteEndElement();
			}

			writer.WriteEndElement();
		}

	}
	
	public class TextField : Field
	{
		public TextField () : base()
		{
			this.Keyboard = "Digital";
		}
	}
	
	public class DigitField : Field
	{
		public DigitField() : base ()
		{
			this.Keyboard = "LetterEnRu";
		}
	}
}