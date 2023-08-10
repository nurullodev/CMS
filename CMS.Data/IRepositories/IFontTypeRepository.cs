using CMS.Data.ICommons;
using CMS.Domain.Entities.DesignTools;

namespace CMS.Data.IRepositories;

public interface IFontTypeRepository : IRepository<FontType>
{
    Task<FontType> SelectByTypeAsync(string type);
}