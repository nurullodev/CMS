using CMS.Service.DTOs.Damens;
using CMS.Service.DTOs.DesignCategories;

namespace CMS.Service.DTOs.Users;

public class UserResultDto
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DamenResultDto DamenResultDto { get; set; }
    public DesignCategoryResultDto DesignCategoryResultDto { get; set; }
}