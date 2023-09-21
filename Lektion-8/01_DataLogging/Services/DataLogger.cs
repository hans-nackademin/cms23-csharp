using _01_DataLogging.Interfaces;
using System.Diagnostics;

namespace _01_DataLogging.Services;

public class DataLogger : IDataLogger
{
	private readonly string _filePath;
	private readonly IFileManager _fileManager;

	public DataLogger(string filePath, IFileManager fileManager)
	{
		_filePath = filePath;
		_fileManager = fileManager;
	}

	public void Log(string message)
	{
		try
		{
			message = GenerateLogMessage(message);
			bool result = _fileManager.SaveToFile(_filePath, message);
			if (result == false)
				throw new Exception($"Failed to log message: {message} to filepath: {_filePath}.");
		}
		catch (Exception ex) { Console.WriteLine(ex.Message); }
	}

	public string GenerateLogMessage(string message)
	{
		if (Path.GetExtension(_filePath) == ".txt")
			message = $"{DateTime.Now}:{message}";

		return message;
	}
}
