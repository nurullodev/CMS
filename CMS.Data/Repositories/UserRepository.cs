using CMS.Data.Commons;
using CMS.Data.DbContexts;
using CMS.Data.IRepositories;
using CMS.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data.Repositories;

public class UserRepository : Repository<User>, IUserRepository
{
    private readonly AppDbContext _appDbContext;
    public UserRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<User> SelectByEmailAsync(string email)
        => await _appDbContext.Users.FirstOrDefaultAsync(u => u.Email.Equals(email));  
}