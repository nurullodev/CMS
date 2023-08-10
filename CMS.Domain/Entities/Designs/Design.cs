using CMS.Domain.Commons;
using CMS.Domain.Entities.DesignCategories;
using CMS.Domain.Entities.Domains;
using CMS.Domain.Entities.TimeZones;
using CMS.Domain.Enums;

namespace CMS.Domain.Entities.Designs;

public class Design : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Language Language { get; set; }
    public long TimeZonId { get; set; }
    public TimeZon TimeZon { get; set; }

    public long DamenId { get; set; }
    public Damen Damen { get; set; }

    public long DesignCategoryId { get; set; }
    public DesignCategory DesignCategory { get; set; }
}