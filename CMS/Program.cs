using CMS.Service.Services;

ColorService colorService = new ColorService();
var res = await colorService.CreateAsync(new CMS.Service.DTOs.Colors.ColorCreationDto
{
    Name = "White"
});
Console.WriteLine(res.Data.Name);