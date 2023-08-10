using CMS.Domain.Commons;
using CMS.Domain.Entities.DesignCategories;
using CMS.Domain.Entities.Domains;
using CMS.Domain.Entities.TimeZones;
using CMS.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CMS.Domain.Entities.Designs;

public class Design : Auditable
{
    [Column("name"), MinLength(3)]
    public string Name { get; set; }

    [Column("sescription"), MinLength(3)]
    public string Description { get; set; }

    // this is ordinal number 
    public int Attribute { get; set; }
    public Language Language { get; set; }

    public long? DamenId { get; set; }
    public Damen Damen { get; set; }

    public long? DesignCategoryId { get; set; }
    public DesignCategory DesignCategory { get; set; }
}