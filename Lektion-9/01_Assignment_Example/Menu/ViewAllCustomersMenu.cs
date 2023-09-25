using _01_Assignment_Example.Interfaces;
using _01_Assignment_Example.Services;

namespace _01_Assignment_Example.Menu;

public class ViewAllCustomersMenu
{
	private static readonly ICustomerService customerService = new CustomerService();

	public static void Show()
	{
		foreach (var customer in customerService.GetAllCustomers())
		{
			Console.WriteLine(customer.FullName);
			Console.WriteLine(customer.Address?.FullAddress);
			Console.WriteLine();
		}
	}
}
