using CMS.Domain.Entities.DesignCategories;
using CMS.Print.Views.DamensView;
using CMS.Print.Views.DesignToolsViews;
using CMS.Print.Views.DesingsViews;

namespace CMS.Print.Views.UserViews;

public class UserHomeView
{
    private readonly UserServiceView userServiceView = new UserServiceView();

    public void Dashboard()
    {
        Console.WriteLine("1. Damen\n" +
                    "2. Design\n" +
                    "3. Cagegory\n" +
                    "4. Design Tools\n" +
                    "5. Friends\n" +
                    "6. Color\n" +
                    "7. Font type\n" +
                    "8. User\n" +
                    "9. Time zone\n" +
                    "10. Exit");
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
                    UserServiceView userServiceView = new UserServiceView();
                    userServiceView.Methods();
                    break;
                }
            case "9": 
                {
                    TimeZonServiceView timeZonServiceView = new TimeZonServiceView();
                    timeZonServiceView.Methods(); 
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
