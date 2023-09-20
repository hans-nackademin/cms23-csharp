using _04_DataLogging.Interfaces;
using _04_DataLogging.Services;
using Moq;
using Xunit;

namespace _04_DataLogging.Tests.UnitTests;

public class DataLoggerTests
{
	[Fact]
	public void Messages_Should_WhenFileDoesNotExist_ReturnNull()
	{
		// Arrange
		var mockFileHandler = new Mock<IFileHandler>();
		mockFileHandler.Setup(fileHandler => fileHandler.ReadFromFile(It.IsAny<string>()))
			.Returns((IEnumerable<string>) null!);

		IDataLogger dataLogger = new DataLogger("fakeFile.txt", mockFileHandler.Object);


		// Act
		var result = dataLogger.Messages();


		// Assert
		Assert.Null(result);
	}
}
