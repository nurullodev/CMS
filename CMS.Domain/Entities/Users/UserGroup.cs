using CMS.Domain.Commons;
using CMS.Domain.Entities.Domains;
using System.ComponentModel.DataAnnotations;

namespace CMS.Domain.Entities.Users;

public class UserGroup : Auditable
{
    [EmailAddress]
    public string Email { get; set; }

    public long? UserId { get; set; }
    public User User { get; set; }

    public long? DamenId { get; set; }
    public Damen Damen { get; set; }
}