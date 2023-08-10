using CMS.Data.Commons;
using CMS.Data.DbContexts;
using CMS.Data.IRepositories;
using CMS.Domain.Entities.DesignCategories;

namespace CMS.Data.Repositories;

public class DesignCategoryRepository : Repository<DesignCategory>, IDesignCategoryRepository
{
    public DesignCategoryRepository(AppDbContext appDbContext) : base(appDbContext)
    {

    }
}
