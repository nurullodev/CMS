using CMS.Domain.Commons;

namespace CMS.Domain.Entities.DesignTools;

public class DesignTool : Auditable
{
    public long ColorId { get; set; }
    public Color Color { get; set; }

    public long FontSizeId { get; set; }
    public FontSize FontSize { get; set; }

    public long PageId { get; set; }
    public Page Page { get; set; }
}
