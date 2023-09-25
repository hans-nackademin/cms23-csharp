namespace _01_Assignment_Example.Services;

public class FileService
{
	public static async Task SaveToFileAsync(string filePath, string content)
	{
		using StreamWriter sw = new StreamWriter(filePath);
		await sw.WriteLineAsync(content);

		await Task.Delay(10000);
		Console.WriteLine("File Saved");
	}

	//public static string ReadFromFile(string filePath)
	//{
	//	using StreamReader sr = new StreamReader(filePath);
	//	return sr.ReadToEndAsync();
	//}
}
