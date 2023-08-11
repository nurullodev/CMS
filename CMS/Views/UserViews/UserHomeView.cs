using CMS.Domain.Entities.DesignCategories;
using CMS.Print.Views.DamensView;
using CMS.Print.Views.DesignToolsViews;
using CMS.Print.Views.DesingsViews;

namespace CMS.Print.Views.UserViews;

public class UserHomeView
{
    private readonly UserServiceView userServiceView = new UserServiceView();
    public void UserHome()
    {
        Console.WriteLine("1. Sing up\n" +
            "2. Log in");
        Console.Write(">>>>> ");
        string answer = Console.ReadLine();
        switch(answer)
        {
            case "1":
                {
                    userServiceView.Create();
                    Console.Clear();
                    userServiceView.Checking();
                    break;
                }
            case "2": 
                {
                    userServiceView.Checking(); 
                    break;
                }
        }
    }

    public void Dashboard()
    {
        Console.WriteLine("1.Damen\n" +
                    "2. Design" +
                    "3. Cagegory" +
                    "4. Design Tools" +
                    "5. Friends" +
                    "6. Color" +
                    "7. Font type" +
                    "8. User" +
                    "9. Time zone" +
                    "10. Main");
        Console.Write(">>>>> ");
        string number = Console.ReadLine();
        switch (number)
        {
            case "1": 
                {
                    DamenServiceView damenServiceView = new DamenServiceView();
                    damenServiceView.Methods();
                    break;
                }
            case "2": 
                {
                    DesignServiceView designServiceView = new DesignServiceView();
                    designServiceView.Methods(); 
                    break;
                }
            case "3": 
                {
                    CategoryServiceView categoryServiceView = new CategoryServiceView();
                    categoryServiceView.Methods();
                    break;
                }
            case "4": 
                {
                    DesignToolServiceView designToolServiceView = new DesignToolServiceView();
                    designToolServiceView.Methods();
                    break;
                }
            case "5": 
                {
                    UserGroupServiceView userGroupServiceView = new UserGroupServiceView();
                    userGroupServiceView.Methods(); 
                    break;
                }
            case "6":
                {
                    ColorServiceView colorServiceView = new ColorServiceView();
                    colorServiceView.Methods();
                    break;
                }
            case "7":
                {
                    FontTypeServiceView fontTypeServiceView = new FontTypeServiceView();
                    fontTypeServiceView.Methods();
                    break;
                }
            case "8":
                {
                    break;
                }
            case "9": 
                {
                    TimeZonServiceView timeZonServiceView = new TimeZonServiceView();
                    timeZonServiceView.Methods(); 
                    break;
                }
            case "10": 
                {
                    UserHome();
                    break;
                }
            default: 
                {
                    Dashboard();
                    break;
                }
        }
    }
}
