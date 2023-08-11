using CMS.Print.Views.UserViews;
using CMS.Service.DTOs.Colors;
using CMS.Service.DTOs.DesignCategories;
using CMS.Service.Interfaces;
using CMS.Service.Services;

namespace CMS.Print.Views.DesignToolsViews;

public class ColorServiceView
{
    private readonly IColorService colorService = new ColorService();

    public async void Methods()
    {
        Console.WriteLine("1. Create\n" +
            "2. Update\n" +
            "3. get by Id\n" +
            "4. Delete \n" +
            "5. Get All\n" +
            "6. Dashboard");
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
        Console.Write("Name: ");
        string name = Console.ReadLine();
        var response = await this.colorService.CreateAsync(new ColorCreationDto
        {
            Name = name,
        });
        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var color = response.Data;
            Console.WriteLine($"Id: {color.Id} |Name: {color.Name}");
        }
    }

    public async void Update()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        Console.Write("Name: ");
        string name = Console.ReadLine();
        var response = await this.colorService.UpdateAsync(new ColorUpdateDto
        {
            Id = id,
            Name = name,
        });
        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var color = response.Data;
            Console.WriteLine($"Id: {color.Id} |Name: {color.Name}");
        }
    }

    public async void GetById()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        var response = await this.colorService.GetByIdAsync(id);

        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var color = response.Data;
            Console.WriteLine($"Id: {color.Id} |Name: {color.Name}");
        }
    }

    public async void Delete()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        var response = await this.colorService.DeleteAsync(id);
        Console.WriteLine(response.Message);
    }

    public async void GetAll()
    {
        var response = await this.colorService.GetAllAsync();
        if (!response.Data.Any())
            Console.WriteLine("This table is empty");
        else
        {
            foreach(var color in response.Data)
                Console.WriteLine($"Id: {color.Id} |Name: {color.Name}");
        }
    }
}
