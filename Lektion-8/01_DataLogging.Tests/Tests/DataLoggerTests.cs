﻿using _01_DataLogging.Interfaces;
using _01_DataLogging.Services;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Moq;

namespace _01_DataLogging.Tests.Tests;

public class DataLoggerTests
{
	private readonly string _filePath = @$"{Guid.NewGuid()}.txt";	
	private readonly string _content = "Testing";


	[Fact]
	public void Log_Should_LogMessageToLogFile()
	{
		// Arrange (SUT = System Under Test dvs det jag vill testa...)
		var mockFileManager = new Mock<IFileManager>();
		IDataLogger dataLogger = new DataLogger(_filePath, mockFileManager.Object);

		// Act
		string message = $"{DateTime.Now}:{_content}";
		dataLogger.Log(_content);

		// Assert
		mockFileManager.Verify(fileManager => fileManager.SaveToFile(_filePath, message), Times.Once);
	} 

}

