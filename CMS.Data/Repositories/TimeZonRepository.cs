using CMS.Data.Commons;
using CMS.Data.DbContexts;
using CMS.Data.IRepositories;
using CMS.Domain.Entities.TimeZones;

namespace CMS.Data.Repositories;

public class TimeZonRepository : Repository<TimeZon>, ITimeZonRepository
{
    public TimeZonRepository(AppDbContext appDbContext) : base(appDbContext)
    {

    }
}
