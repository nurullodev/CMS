using CMS.Data.Commons;
using CMS.Data.DbContexts;
using CMS.Data.IRepositories;
using CMS.Domain.Entities.TimeZones;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data.Repositories;

public class TimeZonRepository : Repository<TimeZon>, ITimeZonRepository
{
    private readonly AppDbContext _appDbContext;
    public TimeZonRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<TimeZon> SelectByNameAsync(string name)
        => await _appDbContext.TimeZons
        .FirstOrDefaultAsync(t => t.Name.Equals(name));
}