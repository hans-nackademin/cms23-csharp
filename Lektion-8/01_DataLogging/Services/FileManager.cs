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
			using StreamWriter sw = new StreamWriter(filePath);
			sw.WriteLine(content);
			return true;
		}
		catch { }

		return false;
	}
}
