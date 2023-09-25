namespace _01_Assignment_Example.Interfaces;

public interface IAddress
{
    string? City { get; set; }
    string? PostalCode { get; set; }
    string? StreetName { get; set; }
    string? StreetNumber { get; set; }
	string? FullAddress { get; }
}