using System;
using System.Collections.Generic;
using Gtk;
using GLib;
using Gdk;

namespace UnipayFormMaker
{
	public class FieldNode : Gtk.TreeNode
	{
		String name;
		String keyboard;
		String maxLen;
		String example;
		String message;
		String title;
		String regex;
		String split;
		String help;

		public FieldNode (string name, string keyboard, string maxLen, string example, string message, string title, string regex, string split, string help)
		{
			this.name = name;
			this.keyboard = keyboard;
			this.maxLen = maxLen;
			this.example = example;
			this.message = message;
			this.title = title;
			this.regex = regex;
			this.split = split;
			this.help = help;
		}
		

		[Gtk.TreeNodeValue (Column=0)]
		public string Name {get { return name; } }

		[Gtk.TreeNodeValue (Column=1)]
		public string Keyboard {get { return keyboard; } }

		[Gtk.TreeNodeValue (Column=2)]
		public string MaxLen {get { return maxLen; } }

		[Gtk.TreeNodeValue (Column=3)]
		public string Example {get { return example; } }

		[Gtk.TreeNodeValue (Column=4)]
		public string Message {get { return message; } }

		[Gtk.TreeNodeValue (Column=5)]
		public string Title {get { return title; } }

		[Gtk.TreeNodeValue (Column=6)]
		public string Regex {get { return regex; } }

		[Gtk.TreeNodeValue (Column=7)]
		public string Split {get { return split; } }

		[Gtk.TreeNodeValue (Column=8)]
		public string Help {get { return help; } }


	}

	public partial class FieldsDialog : Gtk.Dialog
	{
		public FieldsDialog ()
		{
			this.Build ();
			this.nodeView.AppendColumn ("Имя", new Gtk.CellRendererText (), "text", 0);
			this.nodeView.AppendColumn ("Клавиатура", new Gtk.CellRendererText (), "text", 1);
			this.nodeView.AppendColumn ("Максимальная длина", new Gtk.CellRendererText (), "text", 2);
			this.nodeView.AppendColumn ("Сообщение", new Gtk.CellRendererText (), "text", 3);
			this.nodeView.AppendColumn ("Пример", new Gtk.CellRendererText (), "text", 4);
			this.nodeView.AppendColumn ("Заглавие", new Gtk.CellRendererText (), "text", 5);
			this.nodeView.AppendColumn ("Рег. выражение", new Gtk.CellRendererText (), "text", 6);
			this.nodeView.AppendColumn ("Разделитель", new Gtk.CellRendererText (), "text", 7);
			this.nodeView.AppendColumn ("Помощь", new Gtk.CellRendererText (), "text", 8);
		}

		protected void OnButtonCancelClicked (object sender, EventArgs e)
		{
			FormController.GetInstance().UpdateView();
			this.Destroy();
		}

		protected void OnButtonOkClicked (object sender, EventArgs e)
		{
			FormController.GetInstance().UpdateView();
			this.Destroy();
		}

		protected void OnAddDigitalButtonClicked (object sender, EventArgs e)
		{
//			FieldsController.GetInstance().AddNewDigitField();
		}

		public void AddFieldToVBox( String name, 
		                           String keyboard,
		                           int maxLen,
		                           String example,
		                           String message,
		                           String title,
		                           String regex,
		                           String split,
		                           String help )
		{
			FieldNode node = new FieldNode(name, keyboard, maxLen.ToString(), example, message, title, regex, split, help);
			nodeView.NodeStore.AddNode(node);
		}

		public void ClearFieldsList()
		{
			nodeView.NodeStore = new NodeStore(typeof(FieldNode));
		}

		protected void OnAddFieldButtonClicked (object sender, EventArgs e)
		{
			FieldsController.GetInstance().AddNewTextField();
		}
	}
}

