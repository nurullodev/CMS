using CMS.Data.Commons;
using CMS.Data.DbContexts;
using CMS.Data.IRepositories;
using CMS.Domain.Entities.Users;

namespace CMS.Data.Repositories;

public class UserGroupRepository : Repository<UserGroup>, IUserGroupRepository
{
    public UserGroupRepository(AppDbContext appDbContext) : base(appDbContext)
    {

    }
}