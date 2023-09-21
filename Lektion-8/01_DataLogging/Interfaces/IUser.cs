namespace _01_DataLogging.Interfaces;

public interface IUser
{
	string Id { get; set; }
	string FirstName { get; set; }
	string LastName { get; set; }	
	string Email { get; set; }
	byte[] SecurityKey { get; }
	byte[] Password { get; }

	void GenerateSecurePassword(string password);
	bool ValidatePassword(string password);
}