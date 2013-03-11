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
		
		protected void OnDigitalPageButtonClicked (object sender, EventArgs e)
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
		
	
		
		public void UpdatePageList(List<String> PageList)
		{
			if(PageList.Count != 0)
				ComboBoxPopulate(this.textFieldListCombo, PageList);
		}
		
		public void RemoveAllFromPagesCombo()
		{
			this.textFieldListCombo.Clear ();
		}
		
		public String GetSelectedTextPage(int index)
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
		
		private void ComboBoxPopulate(ComboBox comboBox, List<String> alValuesList ) 
		{ 
			ListStore listStore = new Gtk.ListStore( alValuesList[0].GetType() ); 
			comboBox.Model = listStore; 
			CellRendererText text = new CellRendererText(); 
			comboBox.PackStart(text, true); 
			
			foreach (String oaValue in alValuesList) 
			{ 
				listStore.AppendValues(oaValue); 
			} 
			
			TreeIter iter; 
			if (listStore.GetIterFirst (out iter)) 
			{ 
				comboBox.SetActiveIter (iter); 
			} 
			
			
		}

		public bool PagesBoxSensitive
		{
			set { this.textFieldListCombo.Sensitive = value; }
		}

		public bool PagesButtonSensitive
		{
			set { this.textFieldButton.Sensitive = value; }
		}

		protected void OnFormNameTextChanged (object sender, EventArgs e)
		{
			FormController.GetInstance().SetFormName(this.FormName);
		}

		protected void OnButtonOkClicked (object sender, EventArgs e)
		{
			Destroy();
		}

		protected void OnTextFieldListComboChanged (object sender, EventArgs e)
		{

			this.PagesButtonSensitive = FieldsController.GetInstance().SetSelectedPage(this.textFieldListCombo.Active);
		}
	}
}

