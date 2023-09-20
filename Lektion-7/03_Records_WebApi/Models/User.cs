namespace _03_Records_WebApi.Models;

public class User
{
	public required Guid Id { get; set; }
	public required string FirstName { get; set; } = null!;
	public required string LastName { get; set; } = null!;
	public required string Email { get; set; } = null!;
}
