using System;
using System.Collections.Generic;
using Gtk;
using Gdk;

namespace UnipayFormMaker
{

	public partial class FormDialog : Gtk.Dialog
	{
		public class PageNodeCell : Gtk.TreeNode
		{
			private int id;
			private String name;
			private String fields;

			public PageNodeCell (int id, string name, string fields)
			{
				this.id = id;
				this.name = name;
				this.fields = fields;
			}

			public int Id
			{
				set { this.id = value; }
				get { return this.id;  }
			}

			[Gtk.TreeNodeValue (Column = 0) ]
			public String Name
			{
				set { this.name = value; }
				get { return this.name;  }
			}

			[Gtk.TreeNodeValue (Column = 1)]
			public String Fields
			{
				set { this.fields = value; }
				get { return this.fields;  }
			}
		}


		public FormDialog ()
		{
			this.Build ();
			RemoveAllFromPagesNodeView();
			pagesNodeView.AppendColumn ("Номер", new Gtk.CellRendererText (), "text", 0);
			pagesNodeView.AppendColumn ("Поля", new Gtk.CellRendererText (), "text", 1);
			pagesNodeView.NodeSelection.Changed += delegate(object sender, EventArgs e) {
				PageNodeCell cell = pagesNodeView.NodeSelection.SelectedNode as PageNodeCell;
				if(cell != null)
					FieldsController.GetInstance().SetSelectedPage(cell.Id);
			};
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
		
	
		
		public void UpdatePageList(List<String[]> PageList)
		{
			if(PageList.Count != 0)
				NodeViewPopulate(this.pagesNodeView, PageList);
		}
		
		public void RemoveAllFromPagesNodeView()
		{
			pagesNodeView.NodeStore = new NodeStore(typeof(PageNodeCell));
		}
		
		public String GetSelectedTextPage(int index)
		{
			return (this.pagesNodeView.NodeSelection.SelectedNode as PageNodeCell).Name;
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
		
		private void NodeViewPopulate(NodeView nodeView, List<String[]> alValuesList ) 
		{ 
			RemoveAllFromPagesNodeView();

			int i = 0;
			foreach (String[] oaValue in alValuesList) 
			{ 
				nodeView.NodeStore.AddNode(new PageNodeCell(i++, oaValue[0], oaValue[1])); 
			}
		}

		public bool PagesBoxSensitive
		{
			set { this.pagesNodeView.Sensitive = value; }
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
			this.PagesButtonSensitive = FieldsController.GetInstance().SetSelectedPage(this.pagesNodeView.NodeSelection.SelectedNode.ID);
		}

		protected void OnNewPageButtonClicked (object sender, EventArgs e)
		{
			FormController.GetInstance().AddNewPage();
		}
	}
}

