namespace _02_TodoList.Interfaces;

public interface ITodo
{
	Guid Id { get; set; }
	string Activity { get; set; }
	DateTime Created { get; set; }
}