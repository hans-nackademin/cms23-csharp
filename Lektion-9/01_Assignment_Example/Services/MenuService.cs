using _01_Assignment_Example.Interfaces;
using _01_Assignment_Example.Menu;
using _01_Assignment_Example.Models;

namespace _01_Assignment_Example.Services;

public class MenuService
{

	private static readonly ICustomerService customerService = new CustomerService();

	public static void AddCustomerMenu()
	{
		ICustomer customer = new Customer();

		Console.Write("Förnamn: ");
		customer.FirstName = Console.ReadLine();
		Console.Write("Efternamn: ");
		customer.LastName = Console.ReadLine();
		Console.Write("E-postadress: ");
		customer.Email = Console.ReadLine();

		customer.Address = new Address();
		Console.Write("Gatuadress: ");
		customer.Address.StreetName = Console.ReadLine();
		Console.Write("Gatunummer ");
		customer.Address.StreetNumber = Console.ReadLine();
		Console.Write("Postnummer: ");
		customer.Address.PostalCode = Console.ReadLine();
		Console.Write("Stad/Ort: ");
		customer.Address.City = Console.ReadLine();

		Task.Run(() => customerService.AddCustomerAsync(customer));
	}

	public static void ViewAllCustomersMenu()
	{
		foreach (var customer in customerService.GetAllCustomers())
		{
			Console.WriteLine(customer.FullName);
			Console.WriteLine(customer.Address?.FullAddress);
			Console.WriteLine();
		}
	}

	public static void ViewOneCustomerMenu()
	{
		Console.Write("E-postadress: ");
		var email = Console.ReadLine();

		var customer = customerService.GetOneCustomer(email!);

		Console.WriteLine(customer?.FullName);
		Console.WriteLine(customer?.Address?.FullAddress);
		Console.WriteLine();
	}

	public static void RemoveOneCustomerMenu()
	{
		Console.Write("E-postadress: ");
		var email = Console.ReadLine();

		customerService.RemoveCustomer(email!);
	}

	public static void MainMenu()
	{
		do
		{
			Console.Clear();
			Console.WriteLine("1. Skapa en ny kund");
			Console.WriteLine("2. Visa alla kunder");
			Console.WriteLine("3. Visa en kund");
			Console.WriteLine("4. Ta bort en kund");
			Console.WriteLine("0. Avsluta");
			Console.Write("Välj något av följande alternativ: ");
			var option = Console.ReadLine();

			Console.Clear();

			switch (option)
			{
				case "1":
					AddCustomerMenu();
					break;

				case "2":
					ViewAllCustomersMenu();
					break;

				case "3":
					ViewOneCustomerMenu();
					break;

				case "4":
					RemoveOneCustomerMenu();
					break;

				case "0":
					Environment.Exit(0);
					break;
			}

			Console.ReadKey();

		} while (true);
	}


}
