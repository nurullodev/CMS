using CMS.Service.DTOs.FontTypes;
using CMS.Service.Interfaces;
using CMS.Service.Services;

namespace CMS.Print.Views.DesignToolsViews;

public class FontSizeView
{
    private readonly IFontTypeService fontSizeService = new FontTypeService();
    public async void Create()
    {
        Console.Write("Size: ");
        string type = Console.ReadLine();
        var response = await this.fontSizeService.CreateAsync(new FontTypeCreationDto
        {
            Type = type
        });
        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var fontSize = response.Data;
            Console.WriteLine($"Id: {fontSize.Id} |Size: {fontSize.Type}");
        }
    }

    public async void Update()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        var isValidId = await this.fontSizeService.GetByIdAsync(id);
        if (isValidId.StatusCode != 200)
            Console.WriteLine(isValidId.Message);
        else
        {
            Console.Write("Size: ");
            string type = Console.ReadLine();
            var response = await this.fontSizeService.UpdateAsync(new FontTypeUpdateDto
            {
                Id = id,
                Type = type
            });
            if (response.StatusCode != 200)
                Console.WriteLine(response.Message);
            else
            {
                var fontSize = response.Data;
                Console.WriteLine($"Id: {fontSize.Id} |Size: {fontSize.Type}");
            }
        }
    }

    public async void GetById()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        var response = await this.fontSizeService.GetByIdAsync(id);
        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var fontSize = response.Data;
            Console.WriteLine($"Id: {fontSize.Id} |Size: {fontSize.Type}");
        }
    }

    public async void Delete()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        var response = await this.fontSizeService.DeleteAsync(id);
        Console.WriteLine(response.Message);
    }

    public async void GetAll()
    {
        var fontsizes = await this.fontSizeService.GetAllAsync();
        if (!fontsizes.Data.Any())
            Console.WriteLine("Font size table is empty");
        else
        {
            foreach (var font in fontsizes.Data)
            {
                Console.WriteLine($"Id: {font.Id} |Size: {font.Type}");
            }
        }
    }
}
