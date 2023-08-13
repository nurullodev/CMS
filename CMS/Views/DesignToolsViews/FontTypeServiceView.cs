using CMS.Print.Views.UserViews;
using CMS.Service.DTOs.Colors;
using CMS.Service.DTOs.FontTypes;
using CMS.Service.Interfaces;
using CMS.Service.Services;

namespace CMS.Print.Views.DesignToolsViews;

internal class FontTypeServiceView
{
    private readonly IFontTypeService fontTypeService = new FontTypeService();

    public async void Methods()
    {
        Console.WriteLine(@"1. Create
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
        Console.Write("Type: ");
        string type = Console.ReadLine();
        var response = await this.fontTypeService.CreateAsync(new FontTypeCreationDto
        {
            Type = type
        });
        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var font = response.Data;
            Console.WriteLine($"Id: {font.Id} |Type: {font.Type}");
        }
    }

    public async void Update()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        Console.Write("Type: ");
        string type = Console.ReadLine();
        var response = await this.fontTypeService.UpdateAsync(new FontTypeUpdateDto
        {
            Id = id,
            Type = type,
        });
        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var font = response.Data;
            Console.WriteLine($"Id: {font.Id} |Type: {font.Type}");
        }
    }

    public async void GetById()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        var response = await this.fontTypeService.GetByIdAsync(id);

        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var font = response.Data;
            Console.WriteLine($"Id: {font.Id} |Type: {font.Type}");
        }
    }

    public async void Delete()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        var response = await this.fontTypeService.DeleteAsync(id);
        Console.WriteLine(response.Message);
    }

    public async void GetAll()
    {
        var response = await this.fontTypeService.GetAllAsync();
        if (!response.Data.Any())
            Console.WriteLine("This table is empty");
        else
        {
            foreach (var font in response.Data)
                Console.WriteLine($"Id: {font.Id} |Type: {font.Type}");
        }
    }
}
