using CMS.Domain.Commons;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CMS.Domain.Entities.TimeZones;

public class TimeZon : Auditable
{
    [Column("name"), MinLength(3)]
    public string Name { get; set; }

    [Column("abbreviation")]
    public string Abbreviation { get; set; }
    public string OffSet { get; set; }
}