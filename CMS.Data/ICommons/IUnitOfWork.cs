using CMS.Data.IRepositories;

namespace CMS.Data.ICommons;

public interface IUnitOfWork : IDisposable
{
    IColorRepository ColorRepository { get; }
    IFontSizeRepository FontSizeRepository { get; }
    IDesignCategoryRepository DesignCategoryRepository { get; }
    IDesignRepository DesignRepository { get; }
    IDesignToolRepository DesignToolRepository { get; } 
    IDamenRepository DamenRepository { get; }
    IUserGroupRepository UserGroupRepository { get; }
    IUserRepository UserRepository { get; }
    ITimeZonRepository TimeZonRepository { get; }
    Task SaveAsync();
}