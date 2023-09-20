namespace _04_DataLogging.Interfaces;

public interface IFileHandler
{
	void SaveToFile(string filePath, string content);
	IEnumerable<string> ReadFromFile(string filePath);
}
