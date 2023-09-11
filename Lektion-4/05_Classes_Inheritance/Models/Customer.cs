namespace _05_Classes_Inheritance.Models;

internal abstract class Customer
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Email { get; set; } = null!;
    public DateTime Created { get; set; } = DateTime.Now;
    public DateTime Modified {  get; set; } = DateTime.Now;
}
