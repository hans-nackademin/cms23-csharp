namespace _04_DataLogging.Interfaces;

public interface IDataLogger
{
	void Run();
	void LogMessage(string message);
	IEnumerable<string> Messages();
}