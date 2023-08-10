using CMS.Data.Commons;
using CMS.Data.DbContexts;
using CMS.Data.IRepositories;
using CMS.Domain.Entities.DesignTools;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data.Repositories;

public class DesignToolRepository : Repository<DesignTool>, IDesignToolRepository
{
    private readonly AppDbContext _appDbContext;
    public DesignToolRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;   
    }

    public Task<DesignTool> SelectByColorIdAndFontIdAsync(long colorId, long fontId)
        => _appDbContext.DesignTools
            .FirstOrDefaultAsync(d => d.ColorId == colorId && d.FontTypeId == fontId);
}