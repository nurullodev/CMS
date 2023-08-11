using CMS.Service.DTOs.UserGroups;
using CMS.Service.Services;

namespace CMS.Print.Views.UserViews;

public class UserGroupServiceView
{
    private readonly UserGroupService userGroupService = new UserGroupService();

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
        Console.Write("User Id: ");
        long userId = long.Parse(Console.ReadLine());
        Console.Write("Friend email: ");
        string email = Console.ReadLine();
        Console.Write("Damen Id: ");
        long damenId = long.Parse(Console.ReadLine());

        var response = await userGroupService.CreateAsync(new UserGroupCreationDto
        {
            DamenId = userId,
            Email = email,
            UserId = userId,
        });

        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var userGroup = response.Data;
            Console.WriteLine($"Id: {userGroup.Id} |" +
                $"User Email: {userGroup.UserResultDto.Email} |" +
                $"Damen: {userGroup.DamenResultDto.Name} |" +
                $"Friend email: {userGroup.Email}");
        }
    }

    public async void Update()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        Console.Write("User Id: ");
        long userId = long.Parse(Console.ReadLine());
        Console.Write("Friend email: ");
        string email = Console.ReadLine();
        Console.Write("Damen Id: ");
        long damenId = long.Parse(Console.ReadLine());

        var response = await userGroupService.UpdateAsync(new UserGroupUpdateDto
        {
            Id = id,
            DamenId = userId,
            Email = email,
            UserId = userId,
        });

        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var userGroup = response.Data;
            Console.WriteLine($"Id: {userGroup.Id} |" +
                $"User Email: {userGroup.UserResultDto.Email} |" +
                $"Damen: {userGroup.DamenResultDto.Name} |" +
                $"Friend email: {userGroup.Email}");
        }
    }

    public async void GetById()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        var response = await userGroupService.GetByIdAsync(id);

        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var userGroup = response.Data;
            Console.WriteLine($"Id: {userGroup.Id} |" +
                $"User Email: {userGroup.UserResultDto.Email} |" +
                $"Damen: {userGroup.DamenResultDto.Name} |" +
                $"Friend email: {userGroup.Email}");
        }
    }

    public async void Delete()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        var response = await this.userGroupService.DeleteAsync(id);
        Console.WriteLine(response.Message);
    }

    public async void GetAll()
    {
        var response = await this.userGroupService.GetAllAsync();
        if (!response.Data.Any())
            Console.WriteLine("This table is empty");
        else
        {
            foreach (var userGroup in response.Data)
                Console.WriteLine($"Id: {userGroup.Id} |" +
                $"User Email: {userGroup.UserResultDto.Email} |" +
                $"Damen: {userGroup.DamenResultDto.Name} |" +
                $"Friend email: {userGroup.Email}");
        }
    }
}
