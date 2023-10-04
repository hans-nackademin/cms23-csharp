using CommunityToolkit.Mvvm.ComponentModel;
using Kanelbullen.Mvvm.Models;
using Kanelbullen.Services;

namespace Kanelbullen.Mvvm.ViewModels
{
	public partial class DetailViewModel : ObservableObject
	{
		private Guid _memberId;
		private readonly MemberService _memberService;

		[ObservableProperty]
		private string firstName;

		[ObservableProperty]
		private string lastName;

		[ObservableProperty]
		private string email;




		public DetailViewModel(Guid memberId, MemberService memberService)
		{
			_memberId = memberId;
			_memberService = memberService;

			var _member = _memberService.GetMemberFromList(_memberId);

			FirstName = _member.FirstName;
			LastName = _member.LastName;
			Email = _member.Email;
		}
	}
}
