using _02_TodoList.Interfaces;
using _02_TodoList.Models;
using _02_TodoList.Services;

namespace _02_TodoList.Tests.UnitTests;

public class TodoService_Should
{
	[Fact]
	public void AddTodo_Should_AddOneTodoToList_AndReturnTrue()
	{
		// Arrange
		ITodoService todoService = new TodoService();	
		ITodo todo = new Todo();


		// Act
		todo.Id = Guid.NewGuid();
		todo.Activity = "Testaktivitet";
		todo.Created = DateTime.Now;

		bool result = todoService.AddTodo(todo);


		// Assert
		Assert.True(result);

	}

	[Fact]
	public void GetAllTodos_Should_GetAListOfTodos_ReturnOneTodo()
	{
		// Arrange
		ITodoService todoService = new TodoService();
		ITodo todo = new Todo();

		todo.Id = Guid.NewGuid();
		todo.Activity = "Testaktivitet";
		todo.Created = DateTime.Now;

		todoService.AddTodo(todo);

		// Act
		IEnumerable<ITodo> result = todoService.GetAllTodos();

		// Assert
		Assert.NotNull(result);
		Assert.Single(result);
	}
}
