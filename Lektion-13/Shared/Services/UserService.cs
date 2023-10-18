using Newtonsoft.Json;
using Shared.Handlers;
using Shared.Models;
using System.Diagnostics;

namespace Shared.Services;

public class UserService
{
    private readonly string path = @"c:\example\users.json";
    private List<User> _userList = new List<User>();
    public User? CurrentUser { get; set; }
    public event Action UserUpdated;

    public UserService()
    {
        GetUsersFromList();
        UserUpdated += () => {
            if (CurrentUser != null)
                UpdateCurrentUser(CurrentUser.Id);
        };
    }


    public void AddUserToList(User user)
    {
        _userList.Add(user);
        FileHandler.SaveToFile(path, JsonConvert.SerializeObject(_userList));
        UserUpdated.Invoke();
    }

    public IEnumerable<User> GetUsersFromList()
    {
        try
        {
            var users = FileHandler.ReadFromFile(path);
            if (!string.IsNullOrEmpty(users))
            {
                _userList = JsonConvert.DeserializeObject<List<User>>(users)!;
            }
            
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        
        return _userList;
    }

    public User GetUserFromList(Func<User, bool> expression)
    {
        try
        {
            var user = _userList.FirstOrDefault(expression);
            if (user != null)
                return user;    
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }

        return null!;
    }

    public User UpdateUserInList(User user) 
    {
        var _user = _userList.FirstOrDefault(x => x.Id == user.Id);
        if (_user != null)
        {
            if (_user.FirstName != user.FirstName)
                _user.FirstName = user.FirstName;

            if (_user.LastName != user.LastName)
                _user.LastName = user.LastName;

            if (_user.Email != user.Email)
                _user.Email = user.Email;

            FileHandler.SaveToFile(path, JsonConvert.SerializeObject(_userList));
            UserUpdated.Invoke();
            return _user;
        }

        return null!;
    }

    public bool DeleteUserFromList(Func<User, bool> expression)
    {
        var user = GetUserFromList(expression);
        if ( user != null )
        {
            _userList.Remove(user);
            FileHandler.SaveToFile(path, JsonConvert.SerializeObject(_userList));
            UserUpdated.Invoke();
            return true;
        }

        return false;
    }

    private void UpdateCurrentUser(string id)
    {
        CurrentUser = GetUserFromList(x => x.Id == id);
    }
}
