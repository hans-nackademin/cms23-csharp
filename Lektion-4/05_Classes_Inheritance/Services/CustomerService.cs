using _05_Classes_Inheritance.Models;

namespace _05_Classes_Inheritance.Services;

internal class CustomerService
{
    private static List<Customer> customers = new List<Customer>();


    public static void CreatePrivateCustomer()
    {
        var customer = new PrivateCustomer();
        Console.Write("Ange förnamn: ");
        customer.FirstName = Console.ReadLine() ?? "";
        Console.Write("Ange efternamn: ");
        customer.LastName = Console.ReadLine() ?? "";
        Console.Write("Ange e-postadress: ");
        customer.Email = Console.ReadLine() ?? "";
        Console.Write("Ange telefonnummer: ");
        customer.PhoneNumber = Console.ReadLine() ?? "";

        customers.Add(customer);
        Console.WriteLine("En ny privatkund har lagts till i listan.");
        Console.ReadKey();
    }

    public static void CreateCompanyCustomer()
    {
        var customer = new CompanyCustomer();
        Console.Write("Ange företagsnamn: ");
        customer.CompanyName = Console.ReadLine() ?? "";
        Console.Write("Ange e-postadress: ");
        customer.Email = Console.ReadLine() ?? "";
        Console.Write("Ange telefonnummer: ");
        customer.PhoneNumber = Console.ReadLine() ?? "";

        customers.Add(customer);
        Console.WriteLine("En ny företagskund har lagts till i listan.");
        Console.ReadKey();
    }

}
