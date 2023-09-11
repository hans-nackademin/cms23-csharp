using _03_Classes_Constructors.Models;

var customer_1 = new Customer();

var customer_2 = new Customer();
customer_2.Id = 1;
customer_2.Name = "Hans Mattin-Lassei";
customer_2.Email = "hans@domain.com";
customer_2.PhoneNumber = "1234567890";


var customer_3 = new Customer()
{
    Id = 1,
    Name = "Hans Mattin-Lassei",
    Email = "hans@domain.com",
    PhoneNumber = "1234567890"
};


var customer_4 = new Customer("Hans Mattin-Lassei", "hans@domain.com", "1234567890");