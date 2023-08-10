using CMS.Domain.Commons;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Domain.Entities.Domains;

public class Damen : Auditable
{
    [Column("name"), MinLength(3)]
    public string Name { get; set; }
}