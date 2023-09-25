namespace _02_AsyncAwait.Services;

internal class MenuService
{
	public record User(string Name, string Email);

	public static void AddUserMenu()
	{
		var user = new User("Hans", "hans@domain.com");

		Console.WriteLine("Starting...");
		Console.WriteLine("Saving user to database");

		Task.Run(async () => await UserService.SaveUserAsync(user));
		
		Console.WriteLine("Continue doing som work");
	}
}
