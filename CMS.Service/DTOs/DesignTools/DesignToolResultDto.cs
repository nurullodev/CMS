using CMS.Service.DTOs.Colors;
using CMS.Service.DTOs.FontSizes;

namespace CMS.Service.DTOs.DesignTools;

public class DesignToolResultDto
{
    public long Id { get; set; }
    public ColorResultDto ColorResultDto { get; set; }
    public FontSizeResultDto FontSizeResultDto { get; set; }
}