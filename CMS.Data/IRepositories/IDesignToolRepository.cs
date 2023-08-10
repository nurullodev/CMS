using CMS.Data.ICommons;
using CMS.Domain.Entities.DesignTools;

namespace CMS.Data.IRepositories;

public interface IDesignToolRepository : IRepository<DesignTool>
{
    Task<DesignTool> SelectByColorIdAndFontIdAsync(long colorId, long fontId);
}