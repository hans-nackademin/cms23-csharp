namespace Shared.Models;

public class User
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
}
