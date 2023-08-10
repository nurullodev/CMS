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


//using CMS.Service.Services;

//FontSizeService fontSizeService = new FontSizeService();
//var res1 = await fontSizeService.CreateAsync(new CMS.Service.DTOs.FontSizes.FontSizeCreationDto
//{
//    Size = "25px"
//});
//Console.WriteLine(res1.Data.Size);

//var res1 = await fontSizeService.CreateAsync(new CMS.Service.DTOs.FontSizes.FontSizeCreationDto
//{
//    Size = "20px"
//});
//Console.WriteLine(res1.Data.Size);

//var res2 = await fontSizeService.UpdateAsync(new CMS.Service.DTOs.FontSizes.FontSizeUpdateDto
//{
//    Id = 4,
//    Size = "22,5px"
//});
//Console.WriteLine(res2.Data.Size);

//var res3 = await fontSizeService.GetByIdAsync(4);
//Console.WriteLine(res3.Data.Id +" "+res3.Data.Size);

//var res4 = await fontSizeService.GetAllAsync();
//res4.Data.ToList().ForEach(r => Console.WriteLine(r.Size));

//var res5 = await fontSizeService.DeleteAsync(4);
//Console.WriteLine(res5.Message);

using CMS.Service.Services;

TimeZonService timeZonService = new TimeZonService();
//var res1 = await timeZonService.CreateAsync(new CMS.Service.DTOs.TimeZones.TimeZonCreationDto
//{
//    Name = "Krasnoyarsk Summer Time",
//    Abbreviation = "KRAST",
//    OffSet = "UTC +7"
//});
//Console.WriteLine(res1.Data.OffSet);

//var res2 = await timeZonService.UpdateAsync(new CMS.Service.DTOs.TimeZones.TimeZonUpdateDto
//{
//    Id = 6,
//    Name = "Krasnoyarsk Summer Time",
//    Abbreviation = "KRAST",
//    OffSet = "UTC +8"
//});
//Console.WriteLine(res2.Data.OffSet);

//var res3 = await timeZonService.GetByIdAsync(6);
//Console.WriteLine(res3.Data.Name);
//var res4 = await timeZonService.GetAllAsync();
//res4.Data.ToList().ForEach(x => Console.WriteLine(x.Name));

var res5 = await timeZonService.DeleteAsync(6);
Console.WriteLine(res5.Message);