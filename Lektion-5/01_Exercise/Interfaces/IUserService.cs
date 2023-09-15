using _01_Exercise.Models;
using System.Linq.Expressions;

namespace _01_Exercise.Interfaces;

internal interface IUserService
{
    public void Create(UserCreateRequest userCreateRequest);
    public User Get(Func<User, bool> expression);
//  public User Get(Expression<Func<User, bool>> expression);
    public IEnumerable<User> GetAll();
}
