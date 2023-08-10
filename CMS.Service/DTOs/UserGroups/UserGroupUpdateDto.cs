namespace CMS.Service.DTOs.UserGroups;

public class UserGroupUpdateDto
{
    public long Id { get; set; }
    public string Email { get; set; }
    public long UserId { get; set; }
    public long DamenId { get; set; }
}