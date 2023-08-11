using CMS.Data.ICommons;
using CMS.Domain.Entities.Users;

namespace CMS.Data.IRepositories;

public interface IUserGroupRepository : IRepository<UserGroup>
{
    Task<UserGroup> SelectByUserIdAndEmailAsync(long  userId, string email);
}