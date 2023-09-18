namespace _00_Repetition.Models;

internal class Todo
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public string Activity { get; set; } = null!;
	public DateTime Created { get; set; } = DateTime.Now;

}
