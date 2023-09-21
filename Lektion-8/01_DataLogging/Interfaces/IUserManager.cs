namespace _01_DataLogging.Interfaces;

public interface IUserManager
{
	IUser CreateUser(IUser user, string password);
	IUser GetUser(Func<IUser, bool> expression);
	IEnumerable<IUser> GetUsers();
}
