using _01_DataLogging.Interfaces;

namespace _01_DataLogging.Services;

public class FileManager : IFileManager
{
	public string ReadFromFile(string filePath)
	{
		try
		{
			if (File.Exists(filePath))
				return File.ReadAllText(filePath);
		}
		catch { }

		return null!;
	}

	public bool SaveToFile(string filePath, string content)
	{
		try
		{
			switch(Path.GetExtension(filePath))
			{
				case ".json":
					File.WriteAllText(filePath, content);
					break;

				case ".txt":
					File.AppendAllText(filePath, Environment.NewLine + content);
					break;
			}

			return true;
		}
		catch { }

		return false;
	}
}

/*  
 
	c:\users\hans\desktop\log\myfile.json

	split letar efter tecknet som jag vill dela upp allt på
	så kör vi split(".") så kommer den splitta på alla punkter och ge mig en lista

	[0]:	c:\users\hans\desktop\log\myfile
	[1]:	json
 
	skulle jag istället splitta på Split("\") så skulle jag få följande

	[0]:	c:
	[1]:	users
	[2]:	hans
	[3]:	desktop
	[4]:	log
	[5]:	myfile.json
	[6]:	json

*/