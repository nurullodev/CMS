using CMS.Data.Commons;
using CMS.Data.DbContexts;
using CMS.Data.IRepositories;
using CMS.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data.Repositories;

public class UserGroupRepository : Repository<UserGroup>, IUserGroupRepository
{
    private readonly AppDbContext _appDbContext;
    public UserGroupRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<UserGroup> SelectByUserIdAndEmailAsync(long userId, string email)
        => await _appDbContext.Groups.FirstOrDefaultAsync(g => g.UserId.Equals(userId) && g.Email.Equals(email));   
}