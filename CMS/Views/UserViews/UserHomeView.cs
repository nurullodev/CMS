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
                    break;
                }
            case "2": 
                {
                    userServiceView.Checking(); 
                    break;
                }
        }
    }
}
