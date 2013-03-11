using System;
using System.Collections.Generic;
using UnipayFormMaker.Fields;

namespace UnipayFormMaker
{
	public class FormController
	{
		public static FormController instance = null;
		public static FormModel Model = new FormModel();
		public static MainWindow Win = null;
		public static FormDialog dialog = null;

		public static FormController GetInstance()
		{
			if(instance == null)
				instance = new FormController();
			return instance;
		}

		private FormController (){}

		public void ShowWindow()
		{
			dialog = new FormDialog();
			if(Model == null)
				Model = new FormModel();
			UpdateView();
			dialog.Run();
		}

		public void AddField(Field field)
		{
			Model.Pages[0].Fields.Add(field);
		}

		public void UpdateView()
		{
			dialog.UpdatePageList(Model.GetPagesNumList());

			dialog.FormId = Model.Id.ToString();
			dialog.FormName = Model.Name;
			dialog.ResultText = Model.GenerateXMLString();
		}

		public void SetFormID(int id)
		{
			Model.Id = id;
		}

		public void SetFormName(String name)
		{
			Model.Name = name;
		}

		public void SetFormID(String id)
		{
			if(id == "" || id == null)
			{
				id = "0";
				dialog.FormId = id;
			}
			try
			{
				SetFormID(Int32.Parse(id));
			}catch(Exception)
			{
				dialog.FormId = Model.Id.ToString();
			}
		}

		public void SelectForm(String name)
		{
			foreach(FormModel model in MainController.Models)
			{
				if(model.Name == name)
					Model = model;
			}
		}

		public void InitiateConvertion()
		{
			MainController.Models = GetConvertedFroms(dialog.SourseText);
			FormController.Model = MainController.Models[0];
			UpdateView();
		}

		public List<FormModel> GetConvertedFroms(String part)
		{
			return FormFactory.GetInstance().ConvertPhpToXml(part);
		}

	}
}

