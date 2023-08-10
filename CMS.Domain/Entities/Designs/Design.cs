using CMS.Domain.Commons;
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
}