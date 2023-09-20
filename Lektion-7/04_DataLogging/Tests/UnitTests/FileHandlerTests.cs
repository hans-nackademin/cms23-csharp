using _04_DataLogging.Interfaces;
using _04_DataLogging.Services;
using Xunit;

namespace _04_DataLogging.Tests.UnitTests;

public class FileHandlerTests
{
	[Fact]
	public void ReadFromFile_Should_WhenFileDoesNotExist_ReturnNull()
	{
		// Arrange
		IFileHandler fileHandler = new FileHandler();
		string filePath = "fakefile.txt";

		// Act
		IEnumerable<string> result = fileHandler.ReadFromFile(filePath);


		// Assert
		Assert.Null(result);

	}
}
