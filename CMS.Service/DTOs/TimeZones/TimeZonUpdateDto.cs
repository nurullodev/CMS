namespace CMS.Service.DTOs.TimeZones;

public class TimeZonUpdateDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Abbreviation { get; set; }
    public string OffSet { get; set; }
}
