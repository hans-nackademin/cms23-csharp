using _01_Assignment_Example.Interfaces;
using _01_Assignment_Example.Services;

namespace _01_Assignment_Example.Menu;

public class ViewOneCustomerMenu
{
	private static readonly ICustomerService customerService = new CustomerService();

	public static void Show()
	{
		Console.Write("E-postadress: ");
		var email = Console.ReadLine();

		var customer = customerService.GetOneCustomer(email!);

		Console.WriteLine(customer?.FullName);
		Console.WriteLine(customer?.Address?.FullAddress);
		Console.WriteLine();
	}
}
