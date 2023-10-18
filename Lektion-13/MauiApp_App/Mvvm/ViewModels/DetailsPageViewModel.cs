using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp_App.Mvvm.Views;
using Shared.Models;
using Shared.Services;

namespace MauiApp_App.Mvvm.ViewModels;

public partial class DetailsPageViewModel : ObservableObject
{
    private readonly UserService _userService;

    public DetailsPageViewModel(UserService userService)
    {
        _userService = userService;
        User = _userService.CurrentUser;
    }

    [ObservableProperty]
    User user = new User();

    [RelayCommand]
    public async Task GoToEdit()
    {
        await Shell.Current.GoToAsync(nameof(EditPage));
    }

    [RelayCommand]
    public async Task GoBack()
    {
        await Shell.Current.GoToAsync($"..");
    }

    private void UpdateUser()
    {
        User = _userService.GetUserFromList(x => x.Id == User.Id);
    }
}
