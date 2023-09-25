using static _02_AsyncAwait.Services.MenuService;

namespace _02_AsyncAwait.Services
{
	internal class UserService
	{
		public static async Task SaveUserAsync(User user)
		{
			// saving data to database
			// doing som work here....

			await Task.Delay(15000);
			Console.WriteLine("TASK DONE!");
		}
	}
}
