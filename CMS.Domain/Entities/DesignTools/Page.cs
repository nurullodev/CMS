using CMS.Domain.Commons;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CMS.Domain.Entities.DesignTools;

public class Page : Auditable
{
    [Column("name"), MinLength(3)]
    public string Name { get; set; }

    [Column("description"), MinLength(3)]
    public string Description { get; set; }

    // this is ordinal number 
    public int Attribute { get; set; }  
}