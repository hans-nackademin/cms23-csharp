using _02_AsyncAwait.Services;

namespace _02_AsyncAwait;

internal class Program
{
	public static void Main(string[] args)
	{
		MenuService.AddUserMenu();
		Console.ReadKey();
	}
}