using _04_Classes_Example_With_List.Models;

var customers = new List<Customer>();
var option = 0;

do
{
    var customer = new Customer();

    Console.Write("Id: ");
    var id = Console.ReadLine();
    if (int.TryParse(id, out option))
        customer.Id = int.Parse(id);

    Console.Write("Namn: ");
    customer.Name = Console.ReadLine() ?? "";

    Console.Write("Email: ");
    customer.Email = Console.ReadLine() ?? null!;

    Console.Write("Telefon: ");
    customer.PhoneNumber = Console.ReadLine();

    customers.Add(customer);


}
while (option == 0);
