using System;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnipayFormMaker.Fields;
using System.Xml;
using System.Data.Linq;

namespace UnipayFormMaker
{
	public class FormFactory
	{
		private static FormFactory instance = null;

		public static FormFactory GetInstance()
		{
			if(instance == null)
				instance = new FormFactory();
			return instance;
		}

		private FormFactory ()
		{
		}

		public List<FormModel> ConvertPhpToXml(String php)
		{
			MatchCollection matches = Regex.Matches(php, @"\d+\s?=>\s*stdClass((.|\s)*?)stdClass");
			List<FormModel> models = new List<FormModel>();

			foreach(Match match in matches)
			{
				if(match.Success)
				{
					if(match.Groups.Count == 3)
					{
						FormModel model = ConvertPhpPartToXml(match.Groups[1].Value);

						models.Add(model);
					}
				}
			}

			if(matches.Count == 0)
			{
				models.Add(new FormModel());
			}

			return models;
		}

		public FormModel ConvertPhpPartToXml(String phpPart)
		{
			MatchCollection matches = Regex.Matches(phpPart, @"'(\w*)' => '?(.[^']*)'?,");
			Dictionary<String, String> dict = ConstructDictionary(matches);

			FormModel model = new FormModel();
			Field field = new Field();
			field.Name = "id1";

			foreach(KeyValuePair<String, String> pair in dict)
			{
				if(pair.Key == "reg_exp")
				{
					field.Regex = pair.Value;


					if(field.Regex.Contains("a") ||
					   field.Regex.Contains("z") ||
					   field.Regex.Contains("A") ||
					   field.Regex.Contains("Z"))
					{
						field.Keyboard = Field.KeyboardType.Letters;
					}

//					field.MaxLen = CalculateMaxLenRegex(field.Regex);

				}
				else if(pair.Key == "acc_mask")
				{
					field.MaxLen = CalculateMaxLenString(pair.Value);
					field.Split = ConertMask(pair.Value);
				}
				else if(pair.Key == "acc_name")
				{
					field.Title = pair.Value;
					if(!pair.Value.ToLower().Contains("введите"))
						field.Message = "Введите " + pair.Value.ToLower();
					else
						field.Message = pair.Value;
				}
				else if(pair.Key == "name")
				{
					model.Name = pair.Value;
				}
				else if(pair.Key == "condition_info")
				{
					if(pair.Value.Length == 0)
						continue;

					field.Help = Regex.Replace(pair.Value, @"<.+?>", " ");
				}
				else if(pair.Key == "display_scheme")
				{
					if(pair.Value.Contains("<page>"))
					{
						model.Pages.AddRange(ConstructAndReturnPages(pair.Value));
					}
					else if(pair.Value.Contains("<field "))
					{
						model.Pages.Add(ConstructPage(pair.Value));
					}
				}
			}

			model.Pages[0].Fields.Add(field);
			return model;
		}

		protected Dictionary<String, String> ConstructDictionary(MatchCollection matches)
		{
			Dictionary<String, String> dict = new Dictionary<string, string>();
			
			foreach(Match match in matches)
			{
				if(match.Groups.Count == 3)
				{
					String key = match.Groups[1].Value;
					String value = match.Groups[2].Value;
					try{
						dict.Add(key, value);
					}catch(Exception ex)
					{
						Console.WriteLine(ex.Message + " -- " + key);
					}
				}
			}

			return dict;
		}

		protected int CalculateMaxLenRegex(String regex)
		{
			int maxLen = 0;
			MatchCollection matches = Regex.Matches(regex, @"\{\d*?,? ?(\d+)\}");

			foreach(Match match in matches)
			{
				String lenString = match.Groups[1].Value;
				try{
					maxLen += Int32.Parse(lenString);
				}catch(Exception ex)
				{
					Console.WriteLine(ex.Message + " -- Error parsing maxlen from regex " + lenString);
				}
			}

			if(maxLen == 0)
				return 255;
			else 
				return maxLen;
		}

		protected int CalculateMaxLenString(String source)
		{
			MatchCollection matches = Regex.Matches(source, @"[A-Za-z0-9|\#]");

			int maxLen = matches.Count;

			if(maxLen == 0)
				return 255;
			else 
				return maxLen;
		}

		protected List<Pages.Page> ConstructAndReturnPages(String displayScheme)
		{
			List<Pages.Page> list = new List<Pages.Page>();
			MatchCollection pageMatches = Regex.Matches(displayScheme, @"<page>(.+?)</page>");

			foreach(Match pageMatch in pageMatches)
			{
				list.Add(this.ConstructPage(pageMatch.Groups[1].Value));
			}

			return list;
		}

		protected Pages.Page ConstructPage(String pageStr)
		{
			Pages.Page page = new Pages.Page();

			MatchCollection fieldMatches = Regex.Matches(pageStr, "<field[\\s.*?]*?type=\"input\"(.+?)/?>(.*?</field>)?");
			
			foreach(Match match in fieldMatches)
			{
				String value = match.Groups[0].Value;

				XmlDocument doc = new XmlDocument();
				try{
					doc.LoadXml(value);
				}
				catch(Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
				XmlNode node = doc.SelectSingleNode(@"/field");

				if(node != null && node.Attributes.Count > 2)
					page.Fields.Add(ConstructDisplaySchemeField(node));
			}
			
			return page;
		}

		protected Field ConstructDisplaySchemeField(XmlNode node)
		{
			Field field = new Field();

			XmlAttribute keyboard = node.Attributes["keyboard"];
			if(keyboard != null && keyboard.Value.Length != 0)
			{

				// TODO: Might wanna add some more
				if(keyboard.Value == "latletters")
					field.Keyboard = Field.KeyboardType.Letters;
				else if (keyboard.Value.Contains("letters"))
					field.Keyboard = Field.KeyboardType.LettersEnRu;

			}

			XmlAttribute hint = node.Attributes["hint"];
			if(hint!=null && hint.Value.Length != 0)
			{
				if(!hint.Value.ToLower().Contains("введите"))
					field.Message = "Введите " + hint.Value.ToLower();
				else
					field.Message = hint.Value;
			}

			XmlAttribute mask = node.Attributes["mask"];
			if(mask != null && mask.Value.Length!=0)
			{
				String maskStr = mask.Value;
				int indexOfSemiColumn = mask.Value.IndexOf(";");
				if(indexOfSemiColumn > 3 )
					maskStr = maskStr.Substring(0, indexOfSemiColumn);
				maskStr = maskStr.Replace("9", "*");
				maskStr = maskStr.Replace("//", "");
				maskStr = maskStr.Replace("\\", "");
				field.Split = maskStr;
			}

			XmlAttribute regex = node.Attributes["regexp"];
			if(regex !=null && regex.Value.Length!=0)
			{
				field.Regex = regex.Value;
			}

			return field;
		}

		protected int PagesCount (Dictionary<string, string> dict)
		{
			foreach(KeyValuePair<string, string> pair in dict)
			{
				if(pair.Key == "display_scheme")
				{

					MatchCollection matches = Regex.Matches(pair.Value, @"<page>");
					
					return matches.Count;

				}
			}

			return 0;
		}

		protected String ConertMask(String original)
		{
			return original.Replace("#", "*");;
		}
	}
}

