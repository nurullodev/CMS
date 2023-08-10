using CMS.Domain.Enums;

namespace CMS.Service.DTOs.Designs;

public class DesignUpdateDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Attribute { get; set; }
    public Language Language { get; set; }
    public long DamenId { get; set; }
    public long DesignCategoryId { get; set; }
}
