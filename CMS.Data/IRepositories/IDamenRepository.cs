using CMS.Data.ICommons;
using CMS.Domain.Entities.Domains;

namespace CMS.Data.IRepositories;

public interface IDamenRepository : IRepository<Damen>
{
    Task<Damen> SelectByNameAsync(string name);
}