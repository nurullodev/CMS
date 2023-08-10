using CMS.Service.DTOs.Damens;
using CMS.Service.DTOs.Users;

namespace CMS.Service.DTOs.UserGroups;

public class UserGroupResultDto
{
    public long Id { get; set; } 
    public string Email { get; set; }
    public UserResultDto UserResultDto { get; set; }
    public DamenResultDto DamenResultDto { get; set; }
}