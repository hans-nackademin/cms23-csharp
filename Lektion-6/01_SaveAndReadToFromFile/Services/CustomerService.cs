using _01_SaveAndReadToFromFile.Models;
using Newtonsoft.Json;

namespace _01_SaveAndReadToFromFile.Services;

internal class CustomerService
{
	private List<Customer> _customerList = new List<Customer>();

	public void AddToList(Customer customer)
	{
		_customerList.Add(customer);

		var json = JsonConvert.SerializeObject(_customerList);
		FileService.SaveToFile(json);
	}

	public void GetCustomers()
	{
		var content = FileService.ReadFromFile();
		if (!string.IsNullOrEmpty(content))
			_customerList = JsonConvert.DeserializeObject<List<Customer>>(content)!;


		foreach(var customer in _customerList)
		{
			Console.WriteLine($"{customer.FirstName} {customer.LastName} <{customer.Email}>");
		}
	}
}
