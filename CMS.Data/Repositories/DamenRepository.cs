using CMS.Data.Commons;
using CMS.Data.DbContexts;
using CMS.Data.IRepositories;
using CMS.Domain.Entities.Domains;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data.Repositories;

public class DamenRepository : Repository<Damen>, IDamenRepository
{
    private readonly AppDbContext _appDbContext;
    public DamenRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public Task<Damen> SelectByNameAsync(string name)
        => _appDbContext.Damens.FirstOrDefaultAsync(d => d.Name.Equals(name));
}