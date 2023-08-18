using CMS.Print.Views.DamensView;
using CMS.Service.DTOs.Users;
using CMS.Service.Helpers;
using CMS.Service.Interfaces;
using CMS.Service.Services;

namespace CMS.Print.Views.UserViews;

public class UserServiceView
{
    private readonly IUserService userService = new UserService();

    public async void Methods()
    {
        Console.WriteLine(@"--------- User Page ----------
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
        Console.Write("First name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();

        var response = await this.userService.CreateAsync(new UserCreationDto
        {
            Email = email,
            LastName = lastName,
            Password = password,
            FirstName = firstName,
        });
        if (response.StatusCode !=200)
            Console.WriteLine(response.Message);
        else
        {
            var user = response.Data;
            Console.WriteLine($"Id: {user.Id} |" +
                $"First name: {user.FirstName} |" +
                $"Last name: {user.LastName} |" +
                $"Email: {user.Email} |" +
                $"Password: {user.Password}");
        }
    }
    
    public async void Update()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        var isValidId = await this.userService.GetByIdAsync(id);
        if (isValidId.StatusCode != 200)
        {
            Console.WriteLine(isValidId.Message);
            Update();
        }
        else
        {
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            var response = await this.userService.UpdateAsync(new UserUpdateDto
            {
                Id = id,
                Email = email,
                LastName = lastName,
                Password = password,
                FirstName = firstName,
            });

            if (response.StatusCode != 200)
                Console.WriteLine(response.Message);
            else
            {
                var user = response.Data;
                Console.WriteLine($"Id: {user.Id} |" +
                    $"First name: {user.FirstName} |" +
                    $"Last name: {user.LastName} |" +
                    $"Email: {user.Email} |" +
                    $"Password: {user.Password}");
            }
        }
    }

    public async void GetById()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        var response = await this.userService.GetByIdAsync(id);

        if (response.StatusCode != 200)
            Console.WriteLine(response.Message);
        else
        {
            var user = response.Data;
            Console.WriteLine($"Id: {user.Id} |" +
                $"First name: {user.FirstName} |" +
                $"Last name: {user.LastName} |" +
                $"Email: {user.Email} |" +
                $"Password: {user.Password}");
        }
    }

    public async void Delete()
    {
        Console.Write("Id: ");
        long id = long.Parse(Console.ReadLine());
        var response = await this.userService.DeleteAsync(id);
        Console.WriteLine(response.Message);
    }

    public async void GetAll()
    {
        var response = await this.userService.GetAllAsync();
        if (!response.Data.Any())
            Console.WriteLine("This table is empty");
        else
        {
            foreach (var user in response.Data)
            {
                Console.WriteLine($"Id: {user.Id} |" +
                $"First name: {user.FirstName} |" +
                $"Last name: {user.LastName} |" +
                $"Email: {user.Email} |" +
                $"Password: {user.Password}");
            }
        }
    }
}