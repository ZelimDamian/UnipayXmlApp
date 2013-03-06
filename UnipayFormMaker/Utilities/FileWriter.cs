using System;
using Gtk;
using Gdk;
using System.IO;

namespace UnipayFormMaker
{
	public class FileWriter
	{
		private static FileWriter instance = null;

		public static FileWriter GetInstance()
		{
			if(instance == null)
				instance = new FileWriter();
			return instance;
		}

		private FileWriter ()
		{
		}

		public void WriteToFile(String text)
		{
			Gtk.FileChooserDialog fcd = new Gtk.FileChooserDialog ("Save Image File", null, FileChooserAction.Save, Gtk.Stock.Cancel, Gtk.ResponseType.Cancel, Gtk.Stock.Save, Gtk.ResponseType.Ok);
			
			int response = fcd.Run ();
			
			if (response == (int)Gtk.ResponseType.Ok)
				SaveFile (fcd.Filename, text);
			
			fcd.Destroy ();
		}

		protected void SaveFile(string path, string text)
		{
			using(StreamWriter writer = new StreamWriter(path, false, System.Text.Encoding.UTF8))
			{
				writer.Write(text);
			}
		}
	}
}

