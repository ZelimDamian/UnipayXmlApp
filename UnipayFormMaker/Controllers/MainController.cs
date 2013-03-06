using System;
using System.Collections.Generic;

namespace UnipayFormMaker
{
	public class MainController
	{
		private static MainController instance = null;
		public static MainWindow window = null;
		public static List<FormModel> Models = new List<FormModel>();

		public static MainController GetInstance()
		{
			if(instance == null)
				instance = new MainController();
			return instance;
		}

		private MainController ()
		{
		}

		public FormModel CreateNewForm()
		{
			FormModel model = new FormModel();
			Models.Add(model);
			FormController.Model = model;
			FormController.GetInstance().ShowWindow();
			window.UpdateView();
			return model;
		}

		public void ShowWindow()
		{
			if(window != null)
				window.Destroy();
			window = new MainWindow();
			MainController.GetInstance().UpdateFormsList();
			window.Show();
		}

		public void UpdateFormsList()
		{
			window.UpdateFormsList(GetFormNamesList());
		}

		public List<object[]> GetFormsAsObjArrays()
		{
			List<object[]> list = new List<object[]>();
			
			foreach(FormModel form in Models)
			{
				list.Add(new object[]{ form.Name });
			}
			
			return list;
		}

		public List<String> GetFormNamesList()
		{
			List<String> list = new List<String>();
			
			foreach(FormModel form in Models)
			{
				list.Add( form.Name );
			}
			
			return list;
		}

		public void ConvertAndUpdateView()
		{
			MainController.Models = FormController.GetInstance().GetConvertedFroms(window.SourceText);
			window.UpdateView();
		}

		public void WriteAllConvertedToFile()
		{
			FileWriter.GetInstance().WriteToFile(MainController.GetInstance().GetAllConverted());
		}

		public String GetAllConverted()
		{
			String convertedForms = "";

			foreach(FormModel model in Models)
			{
				convertedForms += model.GenerateXMLString() + Environment.NewLine;
			}

			return convertedForms;
		}

		public FormModel GetFormByName(String name)
		{
			foreach(FormModel model in Models)
			{
				if(model.Name == name)
					return model;
			}

			return null;
		}

		public void RemoveSelectedForm()
		{
			RemoveForm(FormController.Model);
			this.UpdateFormsList();
		}

		public void RemoveFormWithName(String name)
		{
			RemoveForm(GetFormByName(name));
		}

		public void RemoveForm(FormModel model)
		{
			if(model != null)
				Models.Remove(model);
		}

		public void RemoveFormAt(int index)
		{
			Models.RemoveAt(index);
		}
	}
}

