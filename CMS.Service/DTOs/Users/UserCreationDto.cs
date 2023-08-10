namespace CMS.Service.DTOs.Users;

public class UserCreationDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public long DamenId { get; set; }
    public long DesignId { get; set; }
}