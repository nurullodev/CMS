using CMS.Domain.Commons;
using CMS.Domain.Entities.Designs;
using CMS.Domain.Entities.Domains;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Domain.Entities.Users;

public class User : Auditable
{
    [Column("first_name"), StringLength(30, MinimumLength=3)]
    public string FirstName { get; set; }

    [Column("last_name"), StringLength(30, MinimumLength = 3)]
    public string LastName { get; set; }

    [Column("email_address"), DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [Column("password"), DataType(DataType.Password)]
    public string Password { get; set; }

    public long DamenId { get; set; }
    public Damen Damen { get; set; }

    public long DesignId { get; set; }
    public Design Design { get; set; }

    public IQueryable<UserGroup> userGroups { get; set; }
}