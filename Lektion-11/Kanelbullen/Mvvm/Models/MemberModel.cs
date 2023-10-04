namespace Kanelbullen.Mvvm.Models
{
	public class MemberModel
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public string FirstName { get; set; } = null!;
		public string LastName { get; set; } = null!;
		public string Email { get; set; } = null!;
	}
}
