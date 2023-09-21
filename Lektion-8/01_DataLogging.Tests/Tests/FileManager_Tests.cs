using _01_DataLogging.Interfaces;
using _01_DataLogging.Services;

namespace _01_DataLogging.Tests.Tests;

public class FileManager_Tests
{
	private readonly string _realFilePath = @$"{Guid.NewGuid()}.txt";
	private readonly string _fakeFilePath = @$"c:\{Guid.NewGuid()}\fakefile.txt";
	private readonly string _content = "Testing";


	[Fact] // IntegrationTest (går mot ett annat system, såsom filsystemet på datorn)
	public void SaveToFile_Should_ReturnTrue_WhenContentIsWrittenToRealFile()
	{
		// Arrange
		IFileManager fileManager = new FileManager();

		// Act
		bool result = fileManager.SaveToFile(_realFilePath, _content);
		string result_content = File.ReadAllText(_realFilePath);

		// Assert
		Assert.True(result);		
		Assert.Equal(result_content.Trim(), _content);


		// Cleanup
		if (File.Exists(_realFilePath))
			File.Delete(_realFilePath);
	}

	[Fact] // Unit test (testar bara själva funktionaliteten, ingen koppling till något annat system)
	public void SaveToFile_Should_ReturnFalse_WhenFileNotCreated()
	{
		// Arrange
		IFileManager fileManager = new FileManager();

		// Act
		bool result = fileManager.SaveToFile(_fakeFilePath, _content);

		// Assert
		Assert.False(result);
	}

	[Fact] // Unit test
	public void ReadFromFile_Should_ReturnNull_WhenFileDoesNotExists()
	{
		// Arrange
		IFileManager fileManager = new FileManager();

		// Act
		string result = fileManager.ReadFromFile(_fakeFilePath);

		// Assert
		Assert.Null(result);
	}
}
