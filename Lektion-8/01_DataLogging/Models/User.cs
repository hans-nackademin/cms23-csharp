using _01_DataLogging.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace _01_DataLogging.Models;

public class User : IUser
{
	public string Id { get; set; } = null!;
	public string FirstName { get; set; } = null!;
	public string LastName { get; set; } = null!;
	public string Email { get; set; } = null!;
	public byte[] SecurityKey { get; private set; } = null!;
	public byte[] Password { get; private set; } = null!;



	public void GenerateSecurePassword(string password)
	{
		using var hmac = new HMACSHA512();
		SecurityKey = hmac.Key;
		Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
	}

	public bool ValidatePassword(string password)
	{
		using var hmac = new HMACSHA512(SecurityKey);
		var _password = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

		for(int i = 0; i < _password.Length; i++)
			if (_password[i] != Password[i])
				return false;

		return true;
	}
}


/* 
	
	Genererat Lösenord:		0e8efa65-5fc9-44bc-88d2-2b406a238658 
	Lösenord att validera:	0e8efa65-4fc9-44bc-88d2-2b406a238658

	Om de skiljer sig så blir det falskt dvs lösenordet är inte giltigt
	Annars så blir det sant för att lösenorden är lika.
*/