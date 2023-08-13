using CMS.Print.Views.UserViews;
using CMS.Service.DTOs.Damens;
using CMS.Service.Interfaces;
using CMS.Service.Services;

namespace CMS.Print.Views.DamensView;

public class DamenServiceView
{
    private readonly IDamenService damenService = new DamenService();

    public async void Methods()
    {
        Console.WriteLine(@"---------- Domen Page ----------
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
        Console.Write("Name: ");
        string name = Console.ReadLine();
        var response = await this.damenService.CreateAsync(new DamenCreationDto
        {
            Name = name,
        });
        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var damen = response.Data;
            Console.WriteLine($"Id: {damen.Id} |Name: {damen.Name}");
        }
    }

    public async void Update()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        Console.Write("Name: ");
        string name = Console.ReadLine();
        var response = await this.damenService.UpdateAsync(new DamenUpdateDto
        {
            Id = id,
            Name = name,
        });
        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var damen = response.Data;
            Console.WriteLine($"Id: {damen.Id} |Name: {damen.Name}");
        }
    }

    public async void GetById()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        var response = await this.damenService.GetByIdAsync(id);
        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var damen = response.Data;
            Console.WriteLine($"Id: {damen.Id} |Name: {damen.Name}");
        }
    }

    public async void Delete()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        var response = await this.damenService.DeleteAsync(id);
        Console.WriteLine(response.Message);
    }

    public async void GetAll()
    {
        var response = await this.damenService.GetAllAsync();
        if (!response.Data.Any())
            Console.WriteLine("This table is empty");
        else
        {
            foreach(var damen in response.Data)
                Console.WriteLine($"Id: {damen.Id} |Name: {damen.Name}");
        }
    }
}
