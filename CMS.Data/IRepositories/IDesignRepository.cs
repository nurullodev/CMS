using CMS.Data.ICommons;
using CMS.Domain.Entities.Designs;

namespace CMS.Data.IRepositories;

public interface IDesignRepository : IRepository<Design>
{
    Task<Design> SelectByDamenIdAndNameAsync(string name, long damenId);
}