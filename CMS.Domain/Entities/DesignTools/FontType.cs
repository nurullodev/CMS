using CMS.Domain.Commons;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CMS.Domain.Entities.DesignTools;

public class FontType : Auditable
{
    [Column("size")]
    public string Type { get; set; }
}