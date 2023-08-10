using CMS.Domain.Commons;
using CMS.Domain.Entities.Designs;

namespace CMS.Domain.Entities.DesignCategories;

public class DesignCategory : Auditable 
{
    public string Name { get; set; }
    public IQueryable<Design> Designs { get; set; }
}