namespace _02_Classes_GettersAndSetters.Models;

internal class Customer
{
	private string firstName;

	public string FirstName
	{
		get { return firstName; }
		set { firstName = value.Trim(); }
	}

	public string LastName { get; set; }

    public string FullName => $"{FirstName} {LastName}";
}
