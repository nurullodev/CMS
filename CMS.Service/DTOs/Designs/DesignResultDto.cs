using CMS.Domain.Enums;
using CMS.Service.DTOs.Damens;
using CMS.Service.DTOs.DesignCategories;

namespace CMS.Service.DTOs.Designs;

public class DesignResultDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Attribute { get; set; }
    public Language Language { get; set; }
    public DamenResultDto DamenResultDto { get; set; }
    public DesignCategoryResultDto DesignCategoryResultDto { get; set; }
}