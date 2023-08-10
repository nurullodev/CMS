using CMS.Data.Commons;
using CMS.Data.DbContexts;
using CMS.Data.IRepositories;
using CMS.Domain.Entities.DesignTools;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data.Repositories;

public class FontSizeRepository : Repository<FontSize>, IFontSizeRepository
{
    private readonly AppDbContext _appDbContext;
    public FontSizeRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<FontSize> SelectBySizeAsync(string size)
        => await _appDbContext.FontSizes
        .FirstOrDefaultAsync(s => s.Size.Equals(size));
}