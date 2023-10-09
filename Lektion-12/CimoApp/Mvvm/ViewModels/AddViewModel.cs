using CimoApp.Mvvm.Models;
using CimoApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CimoApp.Mvvm.ViewModels
{
    public partial class AddViewModel : ObservableObject
    {
        [ObservableProperty]
        ContactModel contact = new ContactModel();


        [RelayCommand]
        async Task Add()
        {
            // lägga till en kontakt i en lista
            ContactService.AddToList(Contact);

            Contact = new ContactModel();
            await Shell.Current.GoToAsync("..");
        }


        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
