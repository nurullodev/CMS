using CMS.Data.Commons;
using CMS.Data.DbContexts;
using CMS.Data.IRepositories;
using CMS.Domain.Entities.Designs;

namespace CMS.Data.Repositories;

public class DesignRepository : Repository<Design>, IDesignRepository
{
    public DesignRepository(AppDbContext appDbContext) : base(appDbContext)
    {

    }
}