using CMS.Domain.Commons;
using CMS.Domain.Entities.Domains;

namespace CMS.Domain.Entities.Users;

public class User : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public long? DamenId { get; set; }
    public Damen Damen { get; set; }
}