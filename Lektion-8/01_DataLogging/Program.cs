using _01_DataLogging.Interfaces;
using _01_DataLogging.Services;

IFileManager fileManager = new FileManager();
IDataLogger dataLogger = new DataLogger(@"c:\dadafsadfasdf\log.txt", fileManager);

dataLogger.Log("dataaaaaaddadaa");





Console.ReadKey();