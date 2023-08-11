using CMS.Data.ICommons;
using CMS.Domain.Entities.DesignCategories;

namespace CMS.Data.IRepositories;

public interface IDesignCategoryRepository : IRepository<DesignCategory>
{
    Task<DesignCategory> SelectByNameAsync(string name);
}