
namespace _02_Structs.Structs.Domain_Driven_Design;

internal class User
{
	public string FirstName { get; set; } = null!;
	public string LastName { get; set; } = null!;
	
	public Email Email { get; set; }
	public Password Password { get; set; }
}
