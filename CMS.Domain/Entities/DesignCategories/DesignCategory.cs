using CMS.Domain.Commons;
using CMS.Domain.Entities.Designs;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CMS.Domain.Entities.DesignCategories;

public class DesignCategory : Auditable 
{
    [Column("name"), MinLength(3)]
    public string Name { get; set; }
    public IQueryable<Design> Designs { get; set; }
}