using CMS.Domain.Enums;
using CMS.Print.Views.UserViews;
using CMS.Service.DTOs.Designs;
using CMS.Service.Interfaces;
using CMS.Service.Services;

namespace CMS.Print.Views.DesingsViews;

public class DesignServiceView
{
    private readonly IDesignService designService = new DesignService();
    public async void Methods()
    {
        Console.WriteLine(@"---------- Design Page ----------
1. Create
2. Update
3. Get by Id 
4. Delete 
5. Get All
6. Dashboard");
        Console.Write(">>>>> ");
        string number = Console.ReadLine(); 
        switch(number)
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
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.WriteLine("Attribute: ");
        int attribute = int.Parse(Console.ReadLine());
        Console.WriteLine("1. English\n" +
            "2. Mandarin\n" +
            "3. Chinese\n" +
            "4. Hindi\n" +
            "5. Spanish\n" +
            "6. French\n" +
            "7. Standard\n" +
            "8. Arabic\n" +
            "9. Bengali\n" +
            "10. Russian\n" +
            "11. Portuguese\n" +
            "12.Urdu");
        Console.Write(">>>>> ");
        string number = Console.ReadLine();
        Console.Write("Damen Id: ");
        long damenid = long.Parse(Console.ReadLine());
        Console.Write("Design Category Id: ");
        long categoryId = long.Parse(Console.ReadLine());

        var response = await this.designService.CreateAsync(new DesignCreationDto
        {
            Name = name,
            DamenId = damenid,
            Attribute = attribute,
            Description = description,
            DesignCategoryId = categoryId,
            Language = (Language)Enum.Parse(typeof(Language), number),
        });

        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var design = response.Data;
            Console.WriteLine($"Id: {design.Id} |" +
                $"Name: {design.Name} |" +
                $"Language: {design.Language} |" +
                $"Category name: {design.DesignCategoryResultDto.Name} |" +
                $"Damen name: {design.DamenResultDto.Name} |" +
                $"Attribute: {design.Attribute} |" +
                $"Description: {design.Description}");
        }
    }

    public async void Update()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        var isValidId = await this.designService.GetByIdAsync(id);
        if (isValidId.StatusCode != 200)
        {
            Console.WriteLine(isValidId.Message);
            Update();
        }

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.WriteLine("Attribute: ");
        int attribute = int.Parse(Console.ReadLine());
        Console.WriteLine("1. English\n" +
            "2. Mandarin\n" +
            "3. Chinese\n" +
            "4. Hindi\n" +
            "5. Spanish\n" +
            "6. French\n" +
            "7. Standard\n" +
            "8. Arabic\n" +
            "9. Bengali\n" +
            "10. Russian\n" +
            "11. Portuguese\n" +
            "12.Urdu");
        Console.Write(">>>>> ");
        string number = Console.ReadLine();
        Console.Write("Damen Id: ");
        long damenid = long.Parse(Console.ReadLine());
        Console.Write("Design Category Id: ");
        long categoryId = long.Parse(Console.ReadLine());

        var response = await this.designService.UpdateAsync(new DesignUpdateDto
        {
            Id = id,
            Name = name,
            DamenId = damenid,
            Attribute = attribute,
            Description = description,
            DesignCategoryId = categoryId,
            Language = (Language)Enum.Parse(typeof(Language), number),
        });

        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var design = response.Data;
            Console.WriteLine($"Id: {design.Id} |" +
                $"Name: {design.Name} |" +
                $"Language: {design.Language} |" +
                $"Category name: {design.DesignCategoryResultDto.Name} |" +
                $"Damen name: {design.DamenResultDto.Name} |" +
                $"Attribute: {design.Attribute} |" +
                $"Description: {design.Description}");
        }
    }

    public async void GetById()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());

        var response = await this.designService.GetByIdAsync(id);
        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var design = response.Data;
            Console.WriteLine($"Id: {design.Id} |" +
                $"Name: {design.Name} |" +
                $"Language: {design.Language} |" +
                $"Category name: {design.DesignCategoryResultDto.Name} |" +
                $"Damen name: {design.DamenResultDto.Name} |" +
                $"Attribute: {design.Attribute} |" +
                $"Description: {design.Description}");
        }
    }

    public async void Delete()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        var response = await this.designService.DeleteAsync(id);
        Console.WriteLine(response.Message);
    }

    public async void GetAll()
    {
        var response = await this.designService.GetAllAsync();
        if (!response.Data.Any())
            Console.WriteLine("This table is empty");
        else
        {
            foreach (var design in response.Data)
                Console.WriteLine($"Id: {design.Id} |" +
                $"Name: {design.Name} |" +
                $"Language: {design.Language} |" +
                $"Category name: {design.DesignCategoryResultDto.Name} |" +
                $"Damen name: {design.DamenResultDto.Name} |" +
                $"Attribute: {design.Attribute} |" +
                $"Description: {design.Description}");
        }
    }
}