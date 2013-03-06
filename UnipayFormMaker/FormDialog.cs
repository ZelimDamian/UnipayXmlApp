using System;
using System.Collections.Generic;
using Gtk;
using Gdk;

namespace UnipayFormMaker
{
	public partial class FormDialog : Gtk.Dialog
	{
		public FormDialog ()
		{
			this.Build ();
		}

		protected void OnPaymentTypeButtonClicked (object sender, EventArgs e)
		{
//			 throw new System.NotImplementedException ();
		}
		
		protected void OnTextFieldButtonClicked (object sender, EventArgs e)
		{
			FieldsController.GetInstance().ShowDialog();
		}
		
		protected void OnDigitalFieldButtonClicked (object sender, EventArgs e)
		{
			throw new System.NotImplementedException ();
		}
		
		protected void OnGenerateButtonClicked (object sender, EventArgs e)
		{
			FormController.GetInstance().UpdateView();
		}
		
		public String FormId{
			set { this.formIdEntry.Text = value; }
			get { return this.formIdEntry.Text ; }
		}
		
		public String FormName{
			set { this.formNameText.Text = value; }
			get { return this.formNameText.Text ; }
		}
		
		public String ResultText{
			set { this.resultText.Buffer.Text = value;  }
			get { return this.resultText.Buffer.Text ; }
		}
		
		public List<String> TextFields
		{
			get { return new List<string>(); }
		}
		
		public void UpdateFieldList(List<object[]> fieldList)
		{
			if(fieldList.Count != 0)
				ComboBoxPopulate(this.textFieldListCombo, fieldList);
		}
		
		public void RemoveAllFromFieldsCombo()
		{
			this.textFieldListCombo.Clear ();
		}
		
		public String GetSelectedTextField(int index)
		{
			return this.textFieldListCombo.ActiveText;
		}
		
		protected void OnFormIdEntryChanged (object sender, EventArgs e)
		{
			FormController.GetInstance().SetFormID(this.FormId);
		}
		
		protected void OnConvertButtonClicked (object sender, EventArgs e)
		{
			FormController.GetInstance().InitiateConvertion();
		}
		
		public String SourseText
		{
			get { return this.sourceTextView.Buffer.Text;}
			set { this.sourceTextView.Buffer.Text = value;}
		}
		
		private void ComboBoxPopulate(ComboBox comboBox, List<object[]> alValuesList ) 
		{ 
			//		comboBox.Clear();
			// types of ListStore columns are taken from alValuesList 
			ListStore listStore = new Gtk.ListStore( alValuesList[0][0].GetType() ); 
			comboBox.Model = listStore; 
			CellRendererText text = new CellRendererText(); 
			comboBox.PackStart(text, true); 
			
			foreach (object[] oaValue in alValuesList) 
			{ 
				listStore.AppendValues(oaValue); 
			} 
			
			TreeIter iter; 
			if (listStore.GetIterFirst (out iter)) 
			{ 
				comboBox.SetActiveIter (iter); 
			} 
			
			
		}
		
		protected void OnFormNameTextChanged (object sender, EventArgs e)
		{
			FormController.GetInstance().SetFormName(this.FormName);
		}

		protected void OnButtonOkClicked (object sender, EventArgs e)
		{
			Destroy();
		}
	}
}

