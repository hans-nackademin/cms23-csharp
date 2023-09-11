using _01_Classes.Models;

namespace _01_Classes.Services;

internal class CustomerService
{
    // fields
    private List<Customer> _customerList;


    public void CreateCustomer(Customer customer)
    {
        if (!_customerList.Contains(customer))
            _customerList.Add(customer);
    }


    public List<Customer> GetCustomers() 
    {
        return _customerList
            .OrderBy(x => x.Id).ToList();
    }

}
