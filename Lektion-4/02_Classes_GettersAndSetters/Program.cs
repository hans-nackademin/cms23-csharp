using _02_Classes_GettersAndSetters.Models;
using System.Text;

var customer = new Customer();
// set - sätt ett värde
customer.FirstName = "Hans ";
customer.LastName = "Mattin-Lassei";

// get - hämta värdet
var name = customer.FullName;
Console.WriteLine(name);



var user = new User();
user.FirstName = "Hans";
user.LastName = "Mattin-Lassei";
user.Email = " Hans.mattin-lassei@domain.com";

user.SetSecurePassword("BytMig123!");
var password = Encoding.UTF8.GetString(user.Password);
Console.WriteLine($"Password: {password} \n");
Console.ReadKey();

