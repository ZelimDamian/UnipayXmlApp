using System;
using System.Collections;
using System.Collections.Generic;
using Gtk;
using UnipayFormMaker;

public partial class MainWindow: Gtk.Window
{	
	[Gtk.TreeNode (ListOnly=true)]
	public class MyTreeNode : Gtk.TreeNode {
		
		string formName;
		
		public MyTreeNode (string formName)
		{
			this.formName = formName;
		}

		[Gtk.TreeNodeValue (Column=0)]
		public string FormName {get { return formName; } }
	}

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		nodeview1.NodeSelection.Changed += new System.EventHandler (OnSelectionChanged);
		nodeview1.ButtonPressEvent += delegate(object o, ButtonPressEventArgs args) {
			Console.WriteLine("HELLLOOOOO");
		};
		sourseTextView.Buffer.Changed += delegate(object sender, EventArgs e) {
			this.sourceHolder = sourseTextView.Buffer.Text;
		};
	}

	void OnSelectionChanged (object o, System.EventArgs args)
	{
		Gtk.NodeSelection selection = (Gtk.NodeSelection) o;
		MyTreeNode node = (MyTreeNode) selection.SelectedNode;
		if(node != null)
			FormController.GetInstance().SelectForm(node.FormName);
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	public void UpdateView()
	{
		MainController.GetInstance().UpdateFormsList();
	}

	public void UpdateFormsList(List<String> list)
	{
		this.NodeViewPopulate(this.nodeview1, list);
	}

	private void NodeViewPopulate(NodeView nodeView, List<String> list ) 
	{ 
		foreach(TreeViewColumn col in nodeView.Columns)
			nodeView.RemoveColumn(col);

		nodeView.NodeStore = new Gtk.NodeStore( typeof(MyTreeNode) ); ;
		nodeView.AppendColumn ("Имя формы", new Gtk.CellRendererText (), "text", 0);

		foreach (String str in list) 
		{ 
			MyTreeNode node = new MyTreeNode(str);
			nodeView.NodeStore.AddNode(node);
		} 
	}

	String sourceHolder = "";

	public String SourceText
	{
		set {
			this.sourceHolder = value;
			this.sourseTextView.Buffer.Text = value;
		}
		get {
			return this.sourceHolder;
		}
	}

	protected void OpenFileButtonClicked (object sender, EventArgs e)
	{
		Gtk.FileChooserDialog fc=
			new Gtk.FileChooserDialog("Choose the file to open",
			                          this,
			                          FileChooserAction.Open,
			                          "Cancel",ResponseType.Cancel,
			                          "Open",ResponseType.Accept);
		
		if (fc.Run() == (int)ResponseType.Accept) 
		{
			SourceText = TextFileReader.GetInstance().ReadFile(fc.Filename);
		}
		//Don't forget to call Destroy() or the FileChooserDialog window won't get closed.
		fc.Destroy();
	}

	protected void OnNewFormButtonClicked (object sender, EventArgs e)
	{
		MainController.GetInstance().CreateNewForm();
	}

	protected void OnConvertButtonClicked (object sender, EventArgs e)
	{
		MainController.GetInstance().ConvertAndUpdateView();
	}

	protected void OnNodeview1ButtonPressEvent (object o, ButtonPressEventArgs args)
	{
		Console.Beep();

		if (args.Event.Button == 1) /* right click */
		{
		}
	}

	protected void OnOpenFormButtonClicked (object sender, EventArgs e)
	{
		FormController.GetInstance().ShowWindow();	}

	protected void OnSaveAllButtonClicked (object sender, EventArgs e)
	{
		MainController.GetInstance().WriteAllConvertedToFile();
	}

	protected void OnDeleteFormButtonClicked (object sender, EventArgs e)
	{
		MainController.GetInstance().RemoveSelectedForm();
	}
}
