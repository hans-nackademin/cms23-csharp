namespace _01_Assignment_Example.Interfaces;

public interface ICustomer
{
    IAddress? Address { get; set; }
    string? Email { get; set; }
    string? FirstName { get; set; }
    string? LastName { get; set; }
	string? FullName { get; }
}