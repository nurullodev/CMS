using CMS.Data.Commons;
using CMS.Data.DbContexts;
using CMS.Data.IRepositories;
using CMS.Domain.Entities.DesignTools;

namespace CMS.Data.Repositories;

public class FontSizeRepository : Repository<FontSize>, IFontSizeRepository
{
    public FontSizeRepository(AppDbContext appDbContext) : base(appDbContext)
    {

    }
}
