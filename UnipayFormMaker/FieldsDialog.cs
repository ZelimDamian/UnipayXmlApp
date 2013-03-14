using System;
using System.Collections.Generic;
using Gtk;
using GLib;
using Gdk;

namespace UnipayFormMaker
{
	public class FieldNode : Gtk.TreeNode
	{
		ing id;
		String name;
		String keyboard;
		String maxLen;
		String example;
		String message;
		String title;
		String regex;
		String split;
		String help;

		public FieldNode (int id, string name, string keyboard, string maxLen, string example, string message, string title, string regex, string split, string help)
		{
			this.id = id;
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

		public int Id
		{
			set { this.id = value; }
			get { return this.id;  }
		}

		[Gtk.TreeNodeValue (Column=0)]
		public string Name {get { return name; } 
			set {this.name = value; }}

		[Gtk.TreeNodeValue (Column=1)]
		public string Keyboard {get { return keyboard; } 
			set {this.keyboard = value; }}

		[Gtk.TreeNodeValue (Column=2)]
		public string MaxLen {get { return maxLen; } 
			set {this.maxLen = value; }}

		[Gtk.TreeNodeValue (Column=3)]
		public string Example {get { return example; } 
			set {this.example = value; }}

		[Gtk.TreeNodeValue (Column=4)]
		public string Message {get { return message; } 
			set { this.message = value; }}

		[Gtk.TreeNodeValue (Column=5)]
		public string Title {get { return title; } 
			set {this.title = value; }}

		[Gtk.TreeNodeValue (Column=6)]
		public string Regex {get { return regex; } 
			set {this.regex = value; }}

		[Gtk.TreeNodeValue (Column=7)]
		public string Split {get { return split; } 
			set {this.split = value; }}

		[Gtk.TreeNodeValue (Column=8)]
		public string Help {get { return help; } 
			set {this.help = value; }}


	}

	public partial class FieldsDialog : Gtk.Dialog
	{
		public FieldsDialog ()
		{
			this.Build ();
			CellRendererText nameCell = new Gtk.CellRendererText ();
			nameCell.Editable = true;
		
			nameCell.Edited += delegate(object o, EditedArgs args) {
				nodeView.NodeSelection.SelectPath(new TreePath(args.Path));
				FieldNode node = (FieldNode) nodeView.NodeSelection.SelectedNode;
				node.Name = args.NewText;
			};

			this.nodeView.AppendColumn ("Имя", nameCell, "text", 0);
			CellRendererText keyboardCell = new Gtk.CellRendererText ();
			keyboardCell.Editable = true;
			nameCell.Edited += delegate(object o, EditedArgs args) {
				
			};
			this.nodeView.AppendColumn ("Клавиатура", keyboardCell, "text", 1);
			CellRendererText maxLenCell = new Gtk.CellRendererText ();
			maxLenCell.Editable = true;
			nameCell.Edited += delegate(object o, EditedArgs args) {
				
			};
			this.nodeView.AppendColumn ("Максимальная длина", maxLenCell, "text", 2);
			CellRendererText messageCell = new Gtk.CellRendererText ();
			messageCell.Editable = true;
			nameCell.Edited += delegate(object o, EditedArgs args) {
				
			};
			this.nodeView.AppendColumn ("Сообщение", messageCell, "text", 3);
			CellRendererText exampleCell = new Gtk.CellRendererText ();
			exampleCell.Editable = true;
			nameCell.Edited += delegate(object o, EditedArgs args) {
				
			};
			this.nodeView.AppendColumn ("Пример", exampleCell, "text", 4);
			CellRendererText titleCell = new Gtk.CellRendererText ();
			titleCell.Editable = true;
			nameCell.Edited += delegate(object o, EditedArgs args) {
				
			};
			this.nodeView.AppendColumn ("Заглавие", titleCell, "text", 5);
			CellRendererText regexCell = new Gtk.CellRendererText ();
			regexCell.Editable = true;
			nameCell.Edited += delegate(object o, EditedArgs args) {
				
			};
			this.nodeView.AppendColumn ("Рег. выражение", regexCell, "text", 6);
			CellRendererText splitCell = new Gtk.CellRendererText ();
			splitCell.Editable = true;
			nameCell.Edited += delegate(object o, EditedArgs args) {
				
			};
			this.nodeView.AppendColumn ("Разделитель", splitCell, "text", 7);
			CellRendererText helpCell = new Gtk.CellRendererText ();
			helpCell.Editable = true;
			nameCell.Edited += delegate(object o, EditedArgs args) {
				
			};
			this.nodeView.AppendColumn ("Помощь", helpCell, "text", 8);
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

		public void AddFieldToVBox( int id,
		                           String name, 
		                           String keyboard,
		                           int maxLen,
		                           String example,
		                           String message,
		                           String title,
		                           String regex,
		                           String split,
		                           String help )
		{
			FieldNode node = new FieldNode(id, name, keyboard, maxLen.ToString(), example, message, title, regex, split, help);
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

