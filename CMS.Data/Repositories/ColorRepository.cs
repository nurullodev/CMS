using CMS.Data.Commons;
using CMS.Data.DbContexts;
using CMS.Data.IRepositories;
using CMS.Domain.Entities.DesignTools;

namespace CMS.Data.Repositories;

public class ColorRepository : Repository<Color>, IColorRepository
{
    public ColorRepository(AppDbContext appDbContext) : base(appDbContext)
    {

    }
}
