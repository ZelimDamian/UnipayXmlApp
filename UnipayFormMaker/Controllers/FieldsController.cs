using System;
using UnipayFormMaker.Fields;
using UnipayFormMaker.Pages;

namespace UnipayFormMaker
{
	public class FieldsController
	{
		public static FieldsController instance = null;
		public static FieldsDialog dialog = null;
		public static FormModel Model
		{ get { return FormController.Model; }
		}

		public static FieldsController GetInstance()
		{
			if(instance == null)
				instance = new FieldsController();
			return instance;
		}

		public FieldsController ()
		{

		}

		public void ShowDialog()
		{
			if(dialog!=null)
				dialog.Destroy();
			dialog = new FieldsDialog();
			UpdateFieldList();
			dialog.Run();
		}

		public void UpdateFieldList ()
		{
//			dialog.ClearFieldsList();

			foreach(Page page in Model.Pages)
			{
				foreach(Field field in page.Fields)
					this.AddFieldToView(field);
			}
		}

		public void AddFieldToModel(Field field)
		{
			Model.Pages[0].Fields.Add(field);
		}

		public void AddNewTextField( )
		{
			Field field = new TextField();
			field.Name = "something";

			AddFieldToModel(field);
			AddFieldToView( field );
		}

		public void AddNewDigitField( )
		{
			Field field = new DigitField();
			field.Name = "something";
			
			AddFieldToModel(field);

			AddFieldToView( field );
		}

		public void AddFieldToView( Field field )
		{
			dialog.AddFieldToVBox(field.Name, field.Keyboard, field.MaxLen, field.Example, field.Message, field.Title, field.Regex, field.Split, field.Text);
		}
	}
}

