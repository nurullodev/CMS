using CMS.Data.ICommons;
using CMS.Domain.Entities.Users;

namespace CMS.Data.IRepositories;

public interface IUserRepository : IRepository<User>
{
    Task<User> SelectByEmailAsync(string email);
}
