using Shared.Models;
using Shared.Services;

namespace ConsoleApp;

internal class MenuService
{
    private readonly UserService _userService = new UserService();

    public void MainMenu()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("---------- MENU -------------");
            Console.WriteLine("1. Lägg till en användare");
            Console.WriteLine("2. Ta bort en användare");
            Console.WriteLine("3. Visa alla användare");
            Console.WriteLine("4. Visa en användare");
            Console.WriteLine("5. Uppdatera en användare");
            Console.WriteLine("0. Avsluta Applikationen");
            Console.WriteLine("-----------------------------");
            Console.Write("Ange ett av alternativen ovan: ");
            var option = Console.ReadLine();

            switch (option!.ToLower())
            {
                case "1":
                    AddMenu();
                    break;

                case "2":
                    RemoveMenu();
                    break;

                case "3":
                    ShowAllMenu();
                    break;

                case "4":
                    ShowOneMenu();
                    break;

                case "5":
                    UpdateMenu();
                    break;

                case "0":
                    Environment.Exit(0);
                    break;

            }

            Console.ReadKey();
        }
        while(true);    
    }


    private void AddMenu()
    {
        var user = new User();

        Console.Clear();
        Console.Write("Förnamn: ");
        user.FirstName = Console.ReadLine()!;

        Console.Write("Efternamn: ");
        user.LastName = Console.ReadLine()!;

        Console.Write("E-postadress: ");
        user.Email = Console.ReadLine()!;
    
        _userService.AddUserToList(user);
    }

    private void RemoveMenu()
    {
        Console.Clear();
        Console.Write("E-postadress: ");
        var email = Console.ReadLine()!;

        _userService.DeleteUserFromList(x => x.Email ==  email);
    }

    private void ShowAllMenu()
    {
        Console.Clear();
        foreach (var user in _userService.GetUsersFromList())
            Console.WriteLine($"{user.FirstName} {user.LastName} <{user.Email}> \n");
    }

    private void ShowOneMenu()
    {
        Console.Clear();
        Console.Write("E-postadress: ");
        var email = Console.ReadLine()!;

        var user = _userService.GetUserFromList(x => x.Email == email);
        if (user != null)
            Console.WriteLine($"{user.FirstName} {user.LastName} <{user.Email}> \n");
        else
            Console.WriteLine("Ingen användare kunde hittas");

    }

    private void UpdateMenu()
    {
        Console.Clear();
        Console.Write("E-postadress: ");
        var email = Console.ReadLine()!;

        var user = _userService.GetUserFromList(x => x.Email == email);
        if (user != null)
        {
            Console.WriteLine($"{user.FirstName} {user.LastName} <{user.Email}> \n");

            Console.Write("Vill du uppdatera förnamnet? (y/n): ");
            var updateFirstName = Console.ReadLine()!;
            if (updateFirstName.ToLower() == "y")
            {
                Console.Write("Förnamn: ");
                user.FirstName = Console.ReadLine()!;
            }

            Console.Write("Vill du uppdatera efternamnet? (y/n): ");
            var updateLastName = Console.ReadLine()!;
            if (updateLastName.ToLower() == "y")
            {
                Console.Write("Efternamn: ");
                user.LastName = Console.ReadLine()!;
            }

            _userService.UpdateUserInList(user);
        }
            
        else
            Console.WriteLine("Ingen användare kunde hittas");
    }
}
