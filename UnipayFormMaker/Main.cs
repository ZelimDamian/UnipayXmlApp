using System;
using Gtk;

namespace UnipayFormMaker
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainController.GetInstance().ShowWindow();
			Application.Run ();
		}
	}
}
