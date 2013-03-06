using System;
using Gtk;
using GLib;
using Gdk;

namespace UnipayFormMaker
{
	public partial class FieldsDialog : Gtk.Dialog
	{
		public FieldsDialog ()
		{
			this.Build ();
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

		protected void OnAddFieldButtonClicked (object sender, EventArgs e)
		{
			FieldsController.GetInstance().AddNewTextField();
		}

		protected void OnAddDigitalButtonClicked (object sender, EventArgs e)
		{
			FieldsController.GetInstance().AddNewDigitField();
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

			HBox box = new HBox (false, 6);
			Entry label = new  Entry (name);
			Entry label1 = new Entry (title);
			box.PackStart (label, true, false, 0);
			box.PackStart (label1, true, false, 0);
			label.Show();
			label1.Show();

			Entry entry = new Entry (regex);
			
			box.PackStart (entry, true, false, 0);
			label.Show();

			this.fieldList.PackStart(box);
//			this.fieldList.ShowAll();
		}

		public void ClearFieldsList()
		{
			foreach(Widget widget in this.fieldList.AllChildren)
				if(widget is HBox)
					widget.Destroy();

		}
	}
}

