using _01_Assignment_Example.Interfaces;

namespace _01_Assignment_Example.Models;

public class Address : IAddress
{
	public string? StreetName { get; set; }
	public string? StreetNumber { get; set; }
	public string? PostalCode { get; set; }
	public string? City { get; set; }


	public string? FullAddress => $"{StreetName} {StreetNumber}, {PostalCode} {City}";
}