
// This file has been generated by the GUI designer. Do not modify.
namespace UnipayFormMaker
{
	public partial class FieldsDialog
	{
		private global::Gtk.Frame frame3;
		private global::Gtk.Alignment GtkAlignment2;
		private global::Gtk.VBox fieldList;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.NodeView nodeView;
		private global::Gtk.Label GtkLabel2;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Button AddFieldButton;
		private global::Gtk.Button removeFieldButton;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget UnipayFormMaker.FieldsDialog
			this.Name = "UnipayFormMaker.FieldsDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child UnipayFormMaker.FieldsDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.frame3 = new global::Gtk.Frame ();
			this.frame3.Name = "frame3";
			this.frame3.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame3.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.fieldList = new global::Gtk.VBox ();
			this.fieldList.Name = "fieldList";
			this.fieldList.Spacing = 6;
			// Container child fieldList.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.nodeView = new global::Gtk.NodeView ();
			this.nodeView.CanFocus = true;
			this.nodeView.Name = "nodeView";
			this.GtkScrolledWindow.Add (this.nodeView);
			this.fieldList.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.fieldList [this.GtkScrolledWindow]));
			w3.Position = 0;
			this.GtkAlignment2.Add (this.fieldList);
			this.frame3.Add (this.GtkAlignment2);
			this.GtkLabel2 = new global::Gtk.Label ();
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Поля</b>");
			this.GtkLabel2.UseMarkup = true;
			this.frame3.LabelWidget = this.GtkLabel2;
			w1.Add (this.frame3);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(w1 [this.frame3]));
			w6.Position = 0;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.AddFieldButton = new global::Gtk.Button ();
			this.AddFieldButton.CanFocus = true;
			this.AddFieldButton.Name = "AddFieldButton";
			this.AddFieldButton.UseUnderline = true;
			// Container child AddFieldButton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w7 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w8 = new global::Gtk.HBox ();
			w8.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w9 = new global::Gtk.Image ();
			w9.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
			w8.Add (w9);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w11 = new global::Gtk.Label ();
			w11.LabelProp = global::Mono.Unix.Catalog.GetString ("Добавить");
			w11.UseUnderline = true;
			w8.Add (w11);
			w7.Add (w8);
			this.AddFieldButton.Add (w7);
			this.hbox1.Add (this.AddFieldButton);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.AddFieldButton]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.removeFieldButton = new global::Gtk.Button ();
			this.removeFieldButton.CanFocus = true;
			this.removeFieldButton.Name = "removeFieldButton";
			this.removeFieldButton.UseUnderline = true;
			// Container child removeFieldButton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w16 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w17 = new global::Gtk.HBox ();
			w17.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w18 = new global::Gtk.Image ();
			w18.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-delete", global::Gtk.IconSize.Menu);
			w17.Add (w18);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w20 = new global::Gtk.Label ();
			w20.LabelProp = global::Mono.Unix.Catalog.GetString ("Удалить");
			w20.UseUnderline = true;
			w17.Add (w20);
			w16.Add (w17);
			this.removeFieldButton.Add (w16);
			this.hbox1.Add (this.removeFieldButton);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.removeFieldButton]));
			w24.Position = 2;
			w24.Expand = false;
			w24.Fill = false;
			w1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(w1 [this.hbox1]));
			w25.Position = 1;
			w25.Expand = false;
			w25.Fill = false;
			// Internal child UnipayFormMaker.FieldsDialog.ActionArea
			global::Gtk.HButtonBox w26 = this.ActionArea;
			w26.Name = "dialog1_ActionArea";
			w26.Spacing = 10;
			w26.BorderWidth = ((uint)(5));
			w26.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			// Container child buttonCancel.Gtk.Container+ContainerChild
			global::Gtk.Alignment w27 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w28 = new global::Gtk.HBox ();
			w28.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w29 = new global::Gtk.Image ();
			w29.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			w28.Add (w29);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w31 = new global::Gtk.Label ();
			w31.LabelProp = global::Mono.Unix.Catalog.GetString ("_Удалить всю страницу");
			w31.UseUnderline = true;
			w28.Add (w31);
			w27.Add (w28);
			this.buttonCancel.Add (w27);
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w35 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w26 [this.buttonCancel]));
			w35.Expand = false;
			w35.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseUnderline = true;
			// Container child buttonOk.Gtk.Container+ContainerChild
			global::Gtk.Alignment w36 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w37 = new global::Gtk.HBox ();
			w37.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w38 = new global::Gtk.Image ();
			w38.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Menu);
			w37.Add (w38);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w40 = new global::Gtk.Label ();
			w40.LabelProp = global::Mono.Unix.Catalog.GetString ("_OK");
			w40.UseUnderline = true;
			w37.Add (w40);
			w36.Add (w37);
			this.buttonOk.Add (w36);
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w44 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w26 [this.buttonOk]));
			w44.Position = 1;
			w44.Expand = false;
			w44.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 735;
			this.DefaultHeight = 433;
			this.Show ();
			this.nodeView.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnNodeViewButtonPressEvent);
			this.AddFieldButton.Clicked += new global::System.EventHandler (this.OnAddFieldButtonClicked);
			this.removeFieldButton.Clicked += new global::System.EventHandler (this.OnRemoveFieldButtonClicked);
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnButtonCancelClicked);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}
