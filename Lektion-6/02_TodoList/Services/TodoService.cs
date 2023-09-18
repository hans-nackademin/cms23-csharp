using _02_TodoList.Interfaces;
using System.Diagnostics;

namespace _02_TodoList.Services;

public class TodoService : ITodoService
{
	private List<ITodo> todos = new List<ITodo>();

	public bool AddTodo(ITodo todo)
	{
		try
		{
			todos.Add(todo);
			return true;
		}
		catch (Exception ex) { Debug.WriteLine(ex.Message); }
		return false;
	}

	public bool DeleteTodo(Guid id)
	{
		throw new NotImplementedException();
	}

	public IEnumerable<ITodo> GetAllTodos()
	{
		try
		{
			return todos;
		}
		catch (Exception ex) { Debug.WriteLine(ex.Message); }
		return null!;
	}
}
