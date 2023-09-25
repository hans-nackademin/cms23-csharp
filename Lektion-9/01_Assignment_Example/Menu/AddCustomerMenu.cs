using _01_Assignment_Example.Interfaces;
using _01_Assignment_Example.Models;
using _01_Assignment_Example.Services;

namespace _01_Assignment_Example.Menu;

public class AddCustomerMenu
{
	private static readonly ICustomerService customerService = new CustomerService();

	public static void Show()
	{
		//ICustomer customer = new Customer();

		//Console.Write("Förnamn: ");
		//customer.FirstName = Console.ReadLine();
		//Console.Write("Efternamn: ");
		//customer.LastName = Console.ReadLine();
		//Console.Write("E-postadress: ");
		//customer.Email = Console.ReadLine();

		//customer.Address = new Address();
		//Console.Write("Gatuadress: ");
		//customer.Address.StreetName = Console.ReadLine();
		//Console.Write("Gatunummer ");
		//customer.Address.StreetNumber = Console.ReadLine();
		//Console.Write("Postnummer: ");
		//customer.Address.PostalCode = Console.ReadLine();
		//Console.Write("Stad/Ort: ");
		//customer.Address.City = Console.ReadLine();

		//customerService.AddCustomer(customer);
	}
}
