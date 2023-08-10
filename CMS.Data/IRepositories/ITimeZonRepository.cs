using CMS.Data.ICommons;
using CMS.Domain.Entities.TimeZones;

namespace CMS.Data.IRepositories;

public interface ITimeZonRepository : IRepository<TimeZon>
{
    Task<TimeZon> SelectByNameAsync(string name);
}