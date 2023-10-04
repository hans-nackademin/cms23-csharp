using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kanelbullen.Mvvm.Models;
using Kanelbullen.Mvvm.Views;
using Kanelbullen.Services;

namespace Kanelbullen.Mvvm.ViewModels
{
	public partial class EditViewModel : ObservableObject
	{
		private readonly MemberService _memberService;

		public EditViewModel(MemberService memberService)
		{
			_memberService = memberService;
		}


		[ObservableProperty]
		private string firstName;

		[ObservableProperty]
		private string lastName;

		[ObservableProperty]
		private string email;



		[RelayCommand]
		public async Task Save()
		{
			var member = new MemberModel()
			{
				FirstName = FirstName,
				LastName = LastName,
				Email = Email
			};

			_memberService.AddMemberToList(member);

			await Shell.Current.GoToAsync("..");
		}
	}
}
