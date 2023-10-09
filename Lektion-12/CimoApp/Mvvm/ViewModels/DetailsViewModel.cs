using CimoApp.Mvvm.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimoApp.Mvvm.ViewModels
{
    public partial class DetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        ContactModel contact = new ContactModel();
    }
}
