using CMS.Print.Views.UserViews;
using CMS.Service.DTOs.DesignCategories;
using CMS.Service.Interfaces;
using CMS.Service.Services;

namespace CMS.Print.Views.DesingsViews;

public class CategoryServiceView
{
    private readonly IDesignCategoryService DesignCategoryService = new DesignCategoryService();
    private readonly DesignService designService = new DesignService();

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
        var response = await this.DesignCategoryService.CreateAsync(new DesignCategoryCreationDto
        {
            Name = name,
        });
        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var designCategory = response.Data;
            Console.WriteLine($"Id: {designCategory.Id} |Name: {designCategory.Name}");
        }
    }

    public async void Update()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        Console.Write("Name: ");
        string name = Console.ReadLine();
        var response = await this.DesignCategoryService.UpdateAsync(new DesignCategoryUpdateDto
        {
            Id = id,
            Name = name,
        });
        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var designCategory = response.Data;
            Console.WriteLine($"Id: {designCategory.Id} |Name: {designCategory.Name}");
        }
    }

    public async void GetById()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        var response = await this.DesignCategoryService.GetByIdAsync(id);
        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var designCategory = response.Data;
            Console.WriteLine($"Id: {designCategory.Id} |Name: {designCategory.Name}");
        }
    }

    public async void Delete()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        var response = await this.DesignCategoryService.DeleteAsync(id);
        await this.designService.DeleteByCategoryIdAsync(id);

        Console.WriteLine(response.Message);
    }

    public async void GetAll()
    {
        var response = await this.DesignCategoryService.GetAllAsync();
        if (!response.Data.Any())
            Console.WriteLine("This table is empty");
        else
        {
            foreach (var designCategory in response.Data)
                Console.WriteLine($"Id: {designCategory.Id} |Name: {designCategory.Name}");
        }
    }
}
