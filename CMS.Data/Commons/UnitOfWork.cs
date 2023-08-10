using CMS.Data.DbContexts;
using CMS.Data.ICommons;
using CMS.Data.IRepositories;

namespace CMS.Data.Commons;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _appDbContext;
    public IColorRepository ColorRepository { get; }

    public IFontSizeRepository FontSizeRepository { get; }

    public IDesignCategoryRepository DesignCategoryRepository { get; }

    public IDesignRepository DesignRepository { get; }

    public IDesignToolRepository DesignToolRepository { get; }

    public IDamenRepository DamenRepository { get; }

    public IUserGroupRepository UserGroupRepository { get; }

    public IUserRepository UserRepository { get; }

    public ITimeZonRepository TimeZonRepository { get; }

    public void Dispose()
    {
        GC.SuppressFinalize(true);
    }

    public async Task SaveAsync()
    {
        await this._appDbContext.SaveChangesAsync();
    }
}