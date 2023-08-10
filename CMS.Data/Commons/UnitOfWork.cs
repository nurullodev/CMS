using CMS.Data.DbContexts;
using CMS.Data.ICommons;
using CMS.Data.IRepositories;
using CMS.Data.Repositories;

namespace CMS.Data.Commons;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _appDbContext;
    public UnitOfWork()
    {
        _appDbContext = new AppDbContext();
        UserRepository = new UserRepository(_appDbContext);
        ColorRepository = new ColorRepository(_appDbContext);
        DamenRepository = new DamenRepository(_appDbContext);
        DesignRepository = new DesignRepository(_appDbContext);
        TimeZonRepository = new TimeZonRepository(_appDbContext);
        FontTypeRepository = new FontTypeRepository(_appDbContext);
        UserGroupRepository = new UserGroupRepository(_appDbContext);
        DesignToolRepository = new DesignToolRepository(_appDbContext);
        DesignCategoryRepository = new DesignCategoryRepository(_appDbContext);
    }

    public IColorRepository ColorRepository { get; }

    public IFontTypeRepository FontTypeRepository { get; }

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