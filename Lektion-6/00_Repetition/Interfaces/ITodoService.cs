using _00_Repetition.Models;

namespace _00_Repetition.Interfaces;

internal interface ITodoService
{
	void AddTodoToList(Todo todo);

	IEnumerable<Todo> GetAll();

	void Delete(Guid id);
}
