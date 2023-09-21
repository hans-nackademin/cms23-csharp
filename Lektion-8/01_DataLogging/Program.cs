using _01_DataLogging.Interfaces;
using _01_DataLogging.Services;

IFileManager fileManager = new FileManager();
string filePath = @$"c:\{Guid.NewGuid()}\fakefile.txt";
string content = "Testing";


// Act
var result = fileManager.SaveToFile(filePath, content);