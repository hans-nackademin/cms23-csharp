namespace _05_Classes_Inheritance.Models;

internal class PrivateCustomer : Customer
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? PhoneNumber { get; set; }
}
