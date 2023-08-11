using CMS.Data.Commons;
using CMS.Data.DbContexts;
using CMS.Data.IRepositories;
using CMS.Domain.Entities.Designs;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data.Repositories;

public class DesignRepository : Repository<Design>, IDesignRepository
{
    private readonly AppDbContext _appDbContext;
    public DesignRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<Design> SelectByDamenIdAndNameAsync(string name, long damenId)
        => await _appDbContext.Designs
        .FirstOrDefaultAsync(d => d.Name.Equals(name) && d.DamenId.Equals(damenId));
}