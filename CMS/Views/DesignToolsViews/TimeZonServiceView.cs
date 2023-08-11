using CMS.Print.Views.UserViews;
using CMS.Service.DTOs.TimeZones;
using CMS.Service.Services;

namespace CMS.Print.Views.DesignToolsViews;

public class TimeZonServiceView
{
    private readonly TimeZonService timeZonService = new TimeZonService();

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
        Console.Write("Abbreviation: ");
        string abbreviation = Console.ReadLine();
        Console.Write("Offet: ");
        string offset = Console.ReadLine();

        var response = await timeZonService.CreateAsync(new TimeZonCreationDto
        {
            Name = name,
            OffSet = offset,
            Abbreviation = abbreviation,
        });

        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var timeZon = response.Data;
            Console.WriteLine($"Id: {timeZon.Id} |" +
                $"Abbreviation: {timeZon.Abbreviation} |" +
                $"Name: {timeZon.Name} |" +
                $"OffSet: {timeZon.OffSet}");
        }
    }

    public async void Update()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Abbreviation: ");
        string abbreviation = Console.ReadLine();
        Console.Write("Offet: ");
        string offset = Console.ReadLine();

        var response = await timeZonService.UpdateAsync(new TimeZonUpdateDto
        {
            Id = id,
            Name = name,
            OffSet = offset,
            Abbreviation = abbreviation,
        });
        
        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var timeZon = response.Data;
            Console.WriteLine($"Id: {timeZon.Id} |" +
                $"Abbreviation: {timeZon.Abbreviation} |" +
                $"Name: {timeZon.Name} |" +
                $"OffSet: {timeZon.OffSet}");
        }
    }

    public async void GetById()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        var response = await this.timeZonService.GetByIdAsync(id);

        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var timeZon = response.Data;
            Console.WriteLine($"Id: {timeZon.Id} |" +
                $"Abbreviation: {timeZon.Abbreviation} |" +
                $"Name: {timeZon.Name} |" +
                $"OffSet: {timeZon.OffSet}");
        }
    }

    public async void Delete()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        var response = await this.timeZonService.DeleteAsync(id);
        Console.WriteLine(response.Message);
    }

    public async void GetAll()
    {
        var response = await this.timeZonService.GetAllAsync();
        if (!response.Data.Any())
            Console.WriteLine("This table is empty");
        else
        {
            foreach( var timeZon in response.Data)
                Console.WriteLine($"Id: {timeZon.Id} |" +
                $"Abbreviation: {timeZon.Abbreviation} |" +
                $"Name: {timeZon.Name} |" +
                $"OffSet: {timeZon.OffSet}");
        }
    }
}
