namespace _02_TodoList.Interfaces;

public interface ITodoService
{
	bool AddTodo(ITodo todo);
	IEnumerable<ITodo> GetAllTodos();
	bool DeleteTodo(Guid id);
}
