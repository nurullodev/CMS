using CMS.Data.Commons;
using CMS.Data.DbContexts;
using CMS.Data.IRepositories;
using CMS.Domain.Entities.Users;

namespace CMS.Data.Repositories;

public class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        
    }
}