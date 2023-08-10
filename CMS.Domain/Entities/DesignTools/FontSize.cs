using CMS.Domain.Commons;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CMS.Domain.Entities.DesignTools;

public class FontSize : Auditable
{
    [Column("size")]
    public string Size { get; set; }
}