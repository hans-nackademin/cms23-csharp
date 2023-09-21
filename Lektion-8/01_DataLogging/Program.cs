using _01_DataLogging.Interfaces;
using _01_DataLogging.Models;
using _01_DataLogging.Services;

IFileManager fileManager = new FileManager();
IDataLogger logger = new DataLogger("log.txt", fileManager);
IUserManager userManager = new UserManager(logger);


string password = "BytMig123!";
IUser user = new User
{
	FirstName = "Hans",
	LastName = "Mattin-Lassei",
	Email = "hans@domain.com"
};

IUser _user = userManager.CreateUser(user, password);
if (_user != null)
	Console.WriteLine($"{_user.FirstName} {_user.LastName} <{_user.Email}>");

Console.ReadKey();