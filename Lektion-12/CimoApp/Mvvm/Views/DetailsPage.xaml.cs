using CimoApp.Mvvm.Models;
using CimoApp.Mvvm.ViewModels;

namespace CimoApp.Mvvm.Views;

[QueryProperty(nameof(ContactModel), "Contact")]
public partial class DetailsPage : ContentPage
{
    ContactModel contact;
    public ContactModel Contact
    {
        get => contact;
        set
        {
            contact = value;
            OnPropertyChanged();
        }
    }


    public DetailsPage(DetailsViewModel viewModel)
	{       
		InitializeComponent();
        viewModel.Contact = Contact;
        BindingContext = viewModel;

        Check();
    }

    void Check()
    {

    }

}