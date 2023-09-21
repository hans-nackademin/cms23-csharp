using _01_DataLogging.Interfaces;
using _01_DataLogging.Models;

namespace _01_DataLogging.Tests.Tests;

public class User_Tests
{
	// Arrange
	private readonly string password = "BytMig123!";
	private readonly IUser user = new User()
	{
		FirstName = "Hans",
		LastName = "Mattin-Lassei",
		Email = "hans@domain.com"
	};

	[Fact]
	public void GenerateSecurePassword_Should_EncryptPasswordFromPassword()
	{
		// Act
		user.GenerateSecurePassword(password);

		// Assert
		Assert.NotNull(user.Password);
	}

	[Fact]
	public void ValidatePassword_Should_ReturnTrue_IfPasswordIsValid()
	{
		// Arrange
		user.GenerateSecurePassword(password);

		// Act
		bool result = user.ValidatePassword(password);

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void ValidatePassword_Should_ReturnFalse_IfPasswordIsInValid()
	{
		// Arrange
		user.GenerateSecurePassword(password);
		string invalid_password = "Test123!";

		// Act
		bool result = user.ValidatePassword(invalid_password);

		// Assert
		Assert.False(result);
	}
}
