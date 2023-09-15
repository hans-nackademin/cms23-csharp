using _01_Exercise.Interfaces;
using _01_Exercise.Models;

namespace _01_Exercise.Services;

internal interface IMenuService
{
    public void MainMenu();
    public void CreateMenu();
    public void ListAllMenu();
    public void ListSpecificMenu();
}

internal class MenuService : IMenuService
{
    private readonly IUserService _userService = new UserService();

    public void MainMenu()
    {
        var exit = false;

        do
        {
            Console.Clear();
            Console.WriteLine("1. Skapa en ny användare");
            Console.WriteLine("2. Visa en specifik användare");
            Console.WriteLine("3. Visa alla användare");
            Console.WriteLine("0. Avsluta");
            Console.Write("Välj ett av ovanstående alternativ (0-4): ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CreateMenu();
                    break;
                
                case "2":
                    ListSpecificMenu();
                    break;
                
                case "3":
                    ListAllMenu();
                    break;
                
                case "0":
                    exit = true;
                    break;
                
                default:
                    break;

            }
        }
        while (exit == false);
    }




    public void CreateMenu()
    {
        Console.Clear();
        Console.WriteLine("Skapa en ny användare");
        Console.WriteLine("---------------------");

        var user = new UserCreateRequest();
        
        Console.Write("Förnamn: ");
        user.FirstName = Console.ReadLine()!.Trim();

        Console.Write("Efternamn: ");
        user.LastName = Console.ReadLine()!.Trim();

        Console.Write("E-postadress: ");
        user.Email = Console.ReadLine()!.Trim().ToLower();

        Console.Write("Lösenord: ");
        user.Password = Console.ReadLine()!.Trim();

        _userService.Create(user);

        Console.WriteLine("En ny användare har blivit tillagd.");
        Console.ReadKey();
    }

    public void ListAllMenu()
    {
        Console.Clear();
        Console.WriteLine("Alla Användare");
        Console.WriteLine("-------------------------------------");

        foreach (var user in _userService.GetAll())
            Console.WriteLine($"{user.FirstName} {user.LastName} <{user.Email}>");
        
        Console.ReadKey();
    }

    public void ListSpecificMenu()
    {
        throw new NotImplementedException();
    }


}
