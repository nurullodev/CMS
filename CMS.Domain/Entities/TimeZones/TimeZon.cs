using CMS.Domain.Commons;

namespace CMS.Domain.Entities.TimeZones;

public class TimeZon : Auditable
{
    public string Name { get; set; }
    public string Abbreviation { get; set; }
    public string OffSet { get; set; }
}