using System;
using UnipayFormMaker.Fields;

namespace UnipayFormMaker
{
	public class FieldsController
	{
		public static FieldsController instance = null;
		public static FieldsDialog dialog = null;
		static Pages.Page page = null;
		public static Pages.Page Page
		{
			get { return page; }
			set { page = value; }
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

		public bool SetSelectedPage(int index)
		{
			try{
				Page = FormController.Model.Pages[index];
				return true;
			}catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
				Page = FormController.Model.Pages[0];
				return false;
			}
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
			dialog.ClearFieldsList();

			int id = 0;

			foreach(Field field in Page.Fields)
			{
				dialog.AddFieldToVBox(id++, 
				                      field.Name,
				                      field.Keyboard,
				                      field.MaxLen,
				                      field.Example,
				                      field.Message,
				                      field.Title,
				                      field.Regex,
				                      field.Split,
				                      field.Help);
			}
		}

		public void AddFieldToModel(Field field)
		{
			Page.Fields.Add(field);
		}

		public void AddNewTextField( )
		{
			Field field = new TextField();
			field.Name = "Новое поле";

			AddFieldToModel(field);
			UpdateFieldList();		
		}

		public Field GetFieldById(int id)
		{
			return Page.Fields[id];
		}

		public void AddFieldToView( int index, Field field )
		{
			dialog.AddFieldToVBox(index, field.Name, field.Keyboard, field.MaxLen, field.Example, field.Message, field.Title, field.Regex, field.Split, field.Text);
		}

	}
}

