using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kanelbullen.Mvvm.Models;
using Kanelbullen.Mvvm.Views;
using Kanelbullen.Services;
using System.Collections.ObjectModel;

namespace Kanelbullen.Mvvm.ViewModels
{
	public partial class MainViewModel : ObservableObject
	{
		private readonly MemberService _memberService;

		[ObservableProperty]
		private ObservableCollection<MemberModel> members = new ObservableCollection<MemberModel>();


		public MainViewModel(MemberService memberService)
		{
			_memberService = memberService;
			GetMembers();

			_memberService.MembersUpdated += GetMembers;
		}

		private void GetMembers()
		{
			Members.Clear();

			foreach (var member in _memberService.GetMembersFromList())
				Members.Add(member);
		}




		[RelayCommand]
		public async Task GoToDetail(MemberModel member)
		{
			var viewModel = new DetailViewModel(member.Id, new MemberService());
			var detailPage = new DetailPage(viewModel);
			await Shell.Current.Navigation.PushAsync(detailPage);
		}

		[RelayCommand]
		public async Task GoToEdit()
		{
			await Shell.Current.GoToAsync(nameof(EditPage));
		}
	}
}
