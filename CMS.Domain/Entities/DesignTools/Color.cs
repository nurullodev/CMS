using CMS.Domain.Commons;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CMS.Domain.Entities.DesignTools;

public class Color : Auditable
{
    [Column("name"), MinLength(3)]
    public string Name { get; set; }
}
