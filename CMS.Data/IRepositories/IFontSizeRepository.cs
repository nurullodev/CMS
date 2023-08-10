using CMS.Data.ICommons;
using CMS.Domain.Entities.DesignTools;

namespace CMS.Data.IRepositories;

public interface IFontSizeRepository : IRepository<FontSize>
{
    Task<FontSize> SelectBySizeAsync(string size);
}