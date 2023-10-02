using System.Collections.ObjectModel;
using TodoListApp.Models;

namespace TodoListApp;

public partial class MainPage : ContentPage
{
	ObservableCollection<Todo> Todos = new ObservableCollection<Todo>();


	public MainPage()
	{
		InitializeComponent();
		CollectionViewTodoList.ItemsSource = Todos;
	}

	private void AddButton_Clicked(object sender, EventArgs e)
	{
		Todos.Add(new Todo { Activity = TodoActivity.Text });
		TodoActivity.Text = string.Empty;
	}

	private void DeleteButton_Clicked(object sender, EventArgs e)
	{
		var button = (Button)sender;
		var todo = button.BindingContext as Todo;

		Todos.Remove(todo);
	}
}