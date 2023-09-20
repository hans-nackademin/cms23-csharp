using System.Text.RegularExpressions;

namespace _02_Structs.Structs.Domain_Driven_Design;

internal struct Email
{
	private readonly string _value;

	public Email(string value)
	{
		if (!Regex.IsMatch(value, @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$"))
			throw new ArgumentException("Invalid email format");

		_value = value;
	}
}
