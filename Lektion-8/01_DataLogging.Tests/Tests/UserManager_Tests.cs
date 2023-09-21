using _01_DataLogging.Interfaces;
using _01_DataLogging.Models;
using _01_DataLogging.Services;
using Moq;

namespace _01_DataLogging.Tests.Tests;

public class UserManager_Tests
{
	[Fact]
	public void CreateUser_Should_CreateNewUser_And_ReturnCreatedUser()
	{
		// Arrange
		Mock<IFileManager> mockFileManager = new Mock<IFileManager>();
		IDataLogger logger = new DataLogger("log.txt", mockFileManager.Object);
		
		string password = "BytMig123!";
		IUser user = new User
		{
			FirstName = "Hans",
			LastName = "Mattin-Lassei",
			Email = "hans@domain.com"
		};

		IUserManager userManager = new UserManager(logger);

		// Act
		IUser result = userManager.CreateUser(user, password);

		// Assert
		Assert.NotNull(result);
		Assert.IsAssignableFrom<IUser>(result);
		Assert.NotNull(result.Id);
		Assert.True(Guid.TryParse(result.Id, out Guid id));
	}
}
