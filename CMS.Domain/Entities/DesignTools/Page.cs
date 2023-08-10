using CMS.Domain.Commons;

namespace CMS.Domain.Entities.DesignTools;

public class Page : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
    // this is ordinal number 
    public int Attribute { get; set; }  
}