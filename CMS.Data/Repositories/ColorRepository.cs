using CMS.Data.Commons;
using CMS.Data.DbContexts;
using CMS.Data.IRepositories;
using CMS.Domain.Entities.DesignTools;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data.Repositories;

public class ColorRepository : Repository<Color>, IColorRepository
{
    private readonly AppDbContext _appDbContext;
    public ColorRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<Color> SelectByNameAsync(string name)
        => await this._appDbContext.Colors
        .FirstOrDefaultAsync(c => c.Name.Equals(name));
}