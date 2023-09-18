/* Json = JavaScript Object Notation  
 
	"key": "value" -pair

	{
		"firstName": "Hans",
		"lastName": "Mattin-Lassei",
		"age": 39,
		"isActive": false,
		"skills": ["C#", "JS", "Python", "C"],
		"relatives": [
			{ "firstName": "Tommy", "lastName": "Mattin-Lassei" },
			{ "firstName": "Anki", "lastName": "Mattin-Lassei" }
		]
	}
 
 */


using _01_SaveAndReadToFromFile.Models;
using _01_SaveAndReadToFromFile.Services;

var customerService = new CustomerService();
customerService.GetCustomers();

var customer = new Customer
{
	FirstName = "Hans",
	LastName = "Mattin-Lassei",
	Email = "hans@domain.com"
};
customerService.AddToList(customer);


Console.ReadKey();