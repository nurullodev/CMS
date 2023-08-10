//using CMS.Service.Services;
//using System.Runtime.Intrinsics.Arm;

//ColorService colorService = new ColorService();
//var res = await colorService.CreateAsync(new CMS.Service.DTOs.Colors.ColorCreationDto
//{
//    Name = "Black"
//});
//Console.WriteLine(res.Data.Name);

//var res2 = await colorService.UpdateAsync(new CMS.Service.DTOs.Colors.ColorUpdateDto
//{
//    Id = 4,
//    Name = "Dark"
//});
//Console.WriteLine(res2.Data.Name);

//var res3 = await colorService.GetByIdAsync(4);
//Console.WriteLine(res3.Data.Name);

//var res4 = await colorService.GetAllAsync();
//res4.Data.ToList().ForEach(x => Console.WriteLine(x.Name));

//var res5 = await colorService.DeleteAsync(4);
//Console.WriteLine(res5.Message);


using CMS.Service.Services;

FontSizeService fontSizeService = new FontSizeService();
var res1 = await fontSizeService.CreateAsync(new CMS.Service.DTOs.FontSizes.FontSizeCreationDto
{
    Size = "25px"
});
Console.WriteLine(res1.Data.Size);