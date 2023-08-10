using CMS.Service.DTOs.Colors;
using CMS.Service.DTOs.FontTypes;

namespace CMS.Service.DTOs.DesignTools;

public class DesignToolResultDto
{
    public long Id { get; set; }
    public ColorResultDto ColorResultDto { get; set; }
    public FontTypeResultDto FontSizeResultDto { get; set; }
}