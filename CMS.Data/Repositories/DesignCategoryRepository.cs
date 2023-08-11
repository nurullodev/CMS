using CMS.Data.Commons;
using CMS.Data.DbContexts;
using CMS.Data.IRepositories;
using CMS.Domain.Entities.DesignCategories;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data.Repositories;

public class DesignCategoryRepository : Repository<DesignCategory>, IDesignCategoryRepository
{
    private readonly AppDbContext _appDbContext;
    public DesignCategoryRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public Task<DesignCategory> SelectByNameAsync(string name)
        => _appDbContext.DesignCategories.FirstOrDefaultAsync(c=> c.Name.Equals(name));
}