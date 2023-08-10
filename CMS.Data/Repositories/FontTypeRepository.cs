using CMS.Data.Commons;
using CMS.Data.DbContexts;
using CMS.Data.IRepositories;
using CMS.Domain.Entities.DesignTools;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data.Repositories;

public class FontTypeRepository : Repository<FontType>, IFontTypeRepository
{
    private readonly AppDbContext _appDbContext;
    public FontTypeRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<FontType> SelectByTypeAsync(string size)
        => await _appDbContext.FontTypes
        .FirstOrDefaultAsync(s => s.Type.Equals(size));
}