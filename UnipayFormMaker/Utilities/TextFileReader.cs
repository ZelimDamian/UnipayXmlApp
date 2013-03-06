using System;
using System.IO;

namespace UnipayFormMaker
{
	public class TextFileReader
	{
		private static TextFileReader instance = null;

//		FileStream reader = null;

		public static TextFileReader GetInstance()
		{
			if(instance == null)
				instance = new TextFileReader();
			return instance;
		}

		private TextFileReader ()
		{
		}

		public String ReadFile(String path)
		{
			return File.ReadAllText(path);
		}
	}
}

