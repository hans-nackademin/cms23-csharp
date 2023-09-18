using _00_Repetition.Interfaces;
using _00_Repetition.Models;

namespace _00_Repetition.Services;

internal class TodoService : ITodoService
{
	private readonly List<Todo> _list = new List<Todo>();


	public void AddTodoToList(Todo todo)
	{
		try
		{
			_list.Add(todo);
		}
		catch { }
	}

	public void Delete(Guid id)
	{
		try
		{
			var todo = _list.FirstOrDefault(todo => todo.Id == id);
			if (todo != null)
				_list.Remove(todo);
		}
		catch { }
	}

	public IEnumerable<Todo> GetAll()
	{
		try
		{
			return _list.OrderByDescending(todo => todo.Created);
		}
		catch { }
		return null!;
	}

}
