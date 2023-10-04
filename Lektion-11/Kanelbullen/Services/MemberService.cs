using Kanelbullen.Mvvm.Models;

namespace Kanelbullen.Services
{
	public class MemberService
	{
		private List<MemberModel> _members = new List<MemberModel>();
		public event Action MembersUpdated;

		public void AddMemberToList(MemberModel member)
		{
			_members.Add(member);
			MembersUpdated.Invoke();
		}

		public List<MemberModel> GetMembersFromList()
		{
			return _members;
		}

		public MemberModel GetMemberFromList(Guid memberId)
		{
			var member = _members.FirstOrDefault(x => x.Id == memberId);
			if (member != null)
				return member;

			return null;
		}
	}
}
