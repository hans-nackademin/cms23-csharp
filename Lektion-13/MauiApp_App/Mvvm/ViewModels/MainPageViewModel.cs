using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp_App.Mvvm.Views;
using Shared.Models;
using Shared.Services;
using System.Collections.ObjectModel;

namespace MauiApp_App.Mvvm.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    private readonly UserService _userService;

    public MainPageViewModel(UserService userService)
    {
        _userService = userService;
        Update();
        UpdateUserList();
    }

    [ObservableProperty]
    ObservableCollection<User> users = new ObservableCollection<User>();

    [RelayCommand]
    public async Task GoToDetails(User user)
    {
        _userService.CurrentUser = user;
        await Shell.Current.GoToAsync(nameof(DetailsPage));
    }




    [RelayCommand]
    public async Task GoToAdd()
    {
        await Shell.Current.GoToAsync($"{nameof(AddPage)}");
    }

    private void UpdateUserList()
    {
        _userService.UserUpdated += () =>
        {
            Update();
        };
    }

    private void Update()
    {
        var _users = _userService.GetUsersFromList();
        Users.Clear();
        foreach (var user in _users)
        {
            Users.Add(user);
        }
    }
}
