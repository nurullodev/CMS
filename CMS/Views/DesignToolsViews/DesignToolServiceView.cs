using CMS.Print.Views.UserViews;
using CMS.Service.DTOs.DesignTools;
using CMS.Service.Helpers;
using CMS.Service.Services;

namespace CMS.Print.Views.DesignToolsViews;

public class DesignToolServiceView
{
    private readonly DesignToolService designToolService = new DesignToolService();

    public async void Methods()
    {
        Console.WriteLine(@"---------- DesignTools Page ----------
1. Create
2. Update
3. Get by Id 
4. Delete 
5. Get All
6. Dashboard");
        Console.Write(">>>>> ");
        string number = Console.ReadLine();
        switch (number)
        {
            case "1":
                {
                    Create();
                    break;
                }
            case "2":
                {
                    Update();
                    break;
                }
            case "3":
                {
                    GetById();
                    break;
                }
            case "4":
                {
                    Delete();
                    break;
                }
            case "5":
                {
                    GetAll();
                    break;
                }
            case "6":
                {
                    UserHomeView userHomeView = new UserHomeView();
                    userHomeView.Dashboard();
                    break;
                }
            default:
                {
                    Methods();
                    break;
                }
        }
    }

    public async void Create()
    {
        Console.Write("Font type Id: ");
        long fontId = long.Parse(Console.ReadLine());
        Console.Write("Color Id: ");
        long colorId = long.Parse(Console.ReadLine());
        var response = await designToolService.CreateAsync(new DesignToolCreationDto
        {
            FontTypeId = fontId,
            ColorId = colorId
        });
        if (response.StatusCode != 200) 
            Console.WriteLine(response.Message);
        else
        {
            var tool = response.Data;
            Console.WriteLine($"Tool Id: {tool.Id} |" +
                $"Color Id: {tool.ColorResultDto.Id} |" +
                $"Color name: {tool.ColorResultDto.Name} |" +
                $"Font type Id: {tool.FontTypeResultDto.Id} |" +
                $"Font type: {tool.FontTypeResultDto.Type}");
        }
    }

    public async void Update()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        Console.Write("Font type Id: ");
        long fontId = long.Parse(Console.ReadLine());
        Console.Write("Color Id: ");
        long colorId = long.Parse(Console.ReadLine());
        var response = await designToolService.UpdateAsync(new DesignToolUpdateDto
        {
            Id = id,
            FontTypeId = fontId,
            ColorId = colorId
        });

        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var tool = response.Data;
            Console.WriteLine($"Tool Id: {tool.Id} |" +
                $"Color Id: {tool.ColorResultDto.Id} |" +
                $"Color name: {tool.ColorResultDto.Name} |" +
                $"Font type Id: {tool.FontTypeResultDto.Id} |" +
                $"Font type: {tool.FontTypeResultDto.Type}");
        }
    }

    public async void GetById()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        var response = await this.designToolService.GetByIdAsync(id);

        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var tool = response.Data;
            Console.WriteLine($"Tool Id: {tool.Id} |" +
                $"Color Id: {tool.ColorResultDto.Id} |" +
                $"Color name: {tool.ColorResultDto.Name} |" +
                $"Font type Id: {tool.FontTypeResultDto.Id} |" +
                $"Font type: {tool.FontTypeResultDto.Type}");
        }
    }

    public async void Delete()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        var response = await this.designToolService.DeleteAsync(id);
        Console.WriteLine(response.Message);
    }

    public async void GetAll()
    {
        var response = await this.designToolService.GetAllAsync();
        if (!response.Data.Any())
            Console.WriteLine("This table is empty");
        else
        {
            foreach(var tool  in response.Data)
                Console.WriteLine($"Tool Id: {tool.Id} |" +
                $"Color Id: {tool.ColorResultDto.Id} |" +
                $"Color name: {tool.ColorResultDto.Name} |" +
                $"Font type Id: {tool.FontTypeResultDto.Id} |" +
                $"Font type: {tool.FontTypeResultDto.Type}");
        }
    }
}
