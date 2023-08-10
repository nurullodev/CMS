using CMS.Domain.Commons;

namespace CMS.Domain.Entities.DesignTools;

public class DesignTool : Auditable
{
    public long? ColorId { get; set; }
    public Color Color { get; set; }

    public long? FontTypeId { get; set; }
    public FontType FontType { get; set; }
}