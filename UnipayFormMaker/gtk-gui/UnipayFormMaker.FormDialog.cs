
// This file has been generated by the GUI designer. Do not modify.
namespace UnipayFormMaker
{
	public partial class FormDialog
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.Notebook notebook1;
		private global::Gtk.VBox vbox3;
		private global::Gtk.HBox hbox5;
		private global::Gtk.Alignment alignment1;
		private global::Gtk.Label asdf;
		private global::Gtk.Entry formIdEntry;
		private global::Gtk.HBox hbox6;
		private global::Gtk.Alignment alignment3;
		private global::Gtk.Label asdf1;
		private global::Gtk.Entry formNameText;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label label3;
		private global::Gtk.ComboBox paymentTypeCombo;
		private global::Gtk.Button paymentTypeButton;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Label label4;
		private global::Gtk.ComboBox textFieldListCombo;
		private global::Gtk.Button textFieldButton;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Button GenerateButton;
		private global::Gtk.Label label1;
		private global::Gtk.VBox vbox4;
		private global::Gtk.Frame frame2;
		private global::Gtk.Alignment GtkAlignment3;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.TextView sourceTextView;
		private global::Gtk.Label GtkLabel6;
		private global::Gtk.Alignment alignment2;
		private global::Gtk.Button convertButton;
		private global::Gtk.Label label2;
		private global::Gtk.Frame frame1;
		private global::Gtk.Alignment GtkAlignment5;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TextView resultText;
		private global::Gtk.Label GtkLabel7;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget UnipayFormMaker.FormDialog
			this.Name = "UnipayFormMaker.FormDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child UnipayFormMaker.FormDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Homogeneous = true;
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.alignment1.LeftPadding = ((uint)(105));
			this.alignment1.RightPadding = ((uint)(115));
			// Container child alignment1.Gtk.Container+ContainerChild
			this.asdf = new global::Gtk.Label ();
			this.asdf.Name = "asdf";
			this.asdf.LabelProp = global::Mono.Unix.Catalog.GetString ("Id сервиса");
			this.alignment1.Add (this.asdf);
			this.hbox5.Add (this.alignment1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.alignment1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.formIdEntry = new global::Gtk.Entry ();
			this.formIdEntry.CanFocus = true;
			this.formIdEntry.Name = "formIdEntry";
			this.formIdEntry.IsEditable = true;
			this.formIdEntry.InvisibleChar = '●';
			this.hbox5.Add (this.formIdEntry);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.formIdEntry]));
			w4.Position = 1;
			this.vbox3.Add (this.hbox5);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox5]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Homogeneous = true;
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			this.alignment3.LeftPadding = ((uint)(105));
			this.alignment3.RightPadding = ((uint)(115));
			// Container child alignment3.Gtk.Container+ContainerChild
			this.asdf1 = new global::Gtk.Label ();
			this.asdf1.Name = "asdf1";
			this.asdf1.LabelProp = global::Mono.Unix.Catalog.GetString ("Имя сервиса");
			this.alignment3.Add (this.asdf1);
			this.hbox6.Add (this.alignment3);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.alignment3]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.formNameText = new global::Gtk.Entry ();
			this.formNameText.CanFocus = true;
			this.formNameText.Name = "formNameText";
			this.formNameText.IsEditable = true;
			this.formNameText.InvisibleChar = '●';
			this.hbox6.Add (this.formNameText);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.formNameText]));
			w8.Position = 1;
			this.vbox3.Add (this.hbox6);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox6]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Типы платежа");
			this.hbox1.Add (this.label3);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label3]));
			w10.Position = 0;
			w10.Fill = false;
			w10.Padding = ((uint)(6));
			// Container child hbox1.Gtk.Box+BoxChild
			this.paymentTypeCombo = global::Gtk.ComboBox.NewText ();
			this.paymentTypeCombo.Name = "paymentTypeCombo";
			this.hbox1.Add (this.paymentTypeCombo);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.paymentTypeCombo]));
			w11.Position = 1;
			// Container child hbox1.Gtk.Box+BoxChild
			this.paymentTypeButton = new global::Gtk.Button ();
			this.paymentTypeButton.CanFocus = true;
			this.paymentTypeButton.Name = "paymentTypeButton";
			this.paymentTypeButton.UseUnderline = true;
			this.paymentTypeButton.Label = global::Mono.Unix.Catalog.GetString ("Подробнее");
			this.hbox1.Add (this.paymentTypeButton);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.paymentTypeButton]));
			w12.Position = 2;
			w12.Fill = false;
			this.vbox3.Add (this.hbox1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox1]));
			w13.Position = 2;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Вводимые поля");
			this.hbox2.Add (this.label4);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label4]));
			w14.Position = 0;
			w14.Fill = false;
			w14.Padding = ((uint)(2));
			// Container child hbox2.Gtk.Box+BoxChild
			this.textFieldListCombo = global::Gtk.ComboBox.NewText ();
			this.textFieldListCombo.TooltipMarkup = "Список вводимых полей";
			this.textFieldListCombo.Name = "textFieldListCombo";
			this.hbox2.Add (this.textFieldListCombo);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.textFieldListCombo]));
			w15.Position = 1;
			// Container child hbox2.Gtk.Box+BoxChild
			this.textFieldButton = new global::Gtk.Button ();
			this.textFieldButton.CanFocus = true;
			this.textFieldButton.Name = "textFieldButton";
			this.textFieldButton.UseUnderline = true;
			this.textFieldButton.Label = global::Mono.Unix.Catalog.GetString ("Подробнее");
			this.hbox2.Add (this.textFieldButton);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.textFieldButton]));
			w16.Position = 2;
			w16.Fill = false;
			this.vbox3.Add (this.hbox2);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox2]));
			w17.Position = 3;
			w17.Expand = false;
			w17.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.GenerateButton = new global::Gtk.Button ();
			this.GenerateButton.CanFocus = true;
			this.GenerateButton.Name = "GenerateButton";
			this.GenerateButton.UseUnderline = true;
			// Container child GenerateButton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w18 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w19 = new global::Gtk.HBox ();
			w19.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w20 = new global::Gtk.Image ();
			w20.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-execute", global::Gtk.IconSize.Menu);
			w19.Add (w20);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w22 = new global::Gtk.Label ();
			w22.LabelProp = global::Mono.Unix.Catalog.GetString ("Сгенерировать");
			w22.UseUnderline = true;
			w19.Add (w22);
			w18.Add (w19);
			this.GenerateButton.Add (w18);
			this.hbox4.Add (this.GenerateButton);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.GenerateButton]));
			w26.Position = 0;
			w26.Fill = false;
			this.vbox3.Add (this.hbox4);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox4]));
			w27.PackType = ((global::Gtk.PackType)(1));
			w27.Position = 5;
			w27.Expand = false;
			w27.Fill = false;
			this.notebook1.Add (this.vbox3);
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Копозитор");
			this.notebook1.SetTabLabel (this.vbox3, this.label1);
			this.label1.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment3 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment3.Name = "GtkAlignment3";
			this.GtkAlignment3.LeftPadding = ((uint)(12));
			// Container child GtkAlignment3.Gtk.Container+ContainerChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.sourceTextView = new global::Gtk.TextView ();
			this.sourceTextView.CanFocus = true;
			this.sourceTextView.Name = "sourceTextView";
			this.GtkScrolledWindow1.Add (this.sourceTextView);
			this.GtkAlignment3.Add (this.GtkScrolledWindow1);
			this.frame2.Add (this.GtkAlignment3);
			this.GtkLabel6 = new global::Gtk.Label ();
			this.GtkLabel6.Name = "GtkLabel6";
			this.GtkLabel6.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Вставить для ковертирования</b>");
			this.GtkLabel6.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel6;
			this.vbox4.Add (this.frame2);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.frame2]));
			w32.Position = 0;
			// Container child vbox4.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0.5F, 0.5F, 0.1F, 1F);
			this.alignment2.Name = "alignment2";
			// Container child alignment2.Gtk.Container+ContainerChild
			this.convertButton = new global::Gtk.Button ();
			this.convertButton.CanFocus = true;
			this.convertButton.Name = "convertButton";
			this.convertButton.UseUnderline = true;
			// Container child convertButton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w33 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w34 = new global::Gtk.HBox ();
			w34.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w35 = new global::Gtk.Image ();
			w35.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-goto-bottom", global::Gtk.IconSize.Menu);
			w34.Add (w35);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w37 = new global::Gtk.Label ();
			w37.LabelProp = global::Mono.Unix.Catalog.GetString ("Конвертировать");
			w37.UseUnderline = true;
			w34.Add (w37);
			w33.Add (w34);
			this.convertButton.Add (w33);
			this.alignment2.Add (this.convertButton);
			this.vbox4.Add (this.alignment2);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.alignment2]));
			w42.Position = 1;
			w42.Expand = false;
			w42.Fill = false;
			this.notebook1.Add (this.vbox4);
			global::Gtk.Notebook.NotebookChild w43 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.vbox4]));
			w43.Position = 1;
			// Notebook tab
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Исходник");
			this.notebook1.SetTabLabel (this.vbox4, this.label2);
			this.label2.ShowAll ();
			this.vbox2.Add (this.notebook1);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.notebook1]));
			w44.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment5 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment5.Name = "GtkAlignment5";
			this.GtkAlignment5.LeftPadding = ((uint)(12));
			// Container child GtkAlignment5.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.resultText = new global::Gtk.TextView ();
			this.resultText.CanFocus = true;
			this.resultText.Name = "resultText";
			this.resultText.WrapMode = ((global::Gtk.WrapMode)(2));
			this.GtkScrolledWindow.Add (this.resultText);
			this.GtkAlignment5.Add (this.GtkScrolledWindow);
			this.frame1.Add (this.GtkAlignment5);
			this.GtkLabel7 = new global::Gtk.Label ();
			this.GtkLabel7.Name = "GtkLabel7";
			this.GtkLabel7.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>XML результат</b>");
			this.GtkLabel7.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel7;
			this.vbox2.Add (this.frame1);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.frame1]));
			w48.Position = 1;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w49.Position = 0;
			// Internal child UnipayFormMaker.FormDialog.ActionArea
			global::Gtk.HButtonBox w50 = this.ActionArea;
			w50.Name = "dialog1_ActionArea";
			w50.Spacing = 10;
			w50.BorderWidth = ((uint)(5));
			w50.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w51 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w50 [this.buttonOk]));
			w51.Expand = false;
			w51.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 651;
			this.DefaultHeight = 520;
			this.Show ();
			this.formIdEntry.Changed += new global::System.EventHandler (this.OnFormIdEntryChanged);
			this.formNameText.Changed += new global::System.EventHandler (this.OnFormNameTextChanged);
			this.paymentTypeButton.Clicked += new global::System.EventHandler (this.OnPaymentTypeButtonClicked);
			this.textFieldButton.Clicked += new global::System.EventHandler (this.OnTextFieldButtonClicked);
			this.GenerateButton.Clicked += new global::System.EventHandler (this.OnGenerateButtonClicked);
			this.convertButton.Clicked += new global::System.EventHandler (this.OnConvertButtonClicked);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}
