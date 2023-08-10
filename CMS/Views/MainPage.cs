//using CMS.Print.Views.DesignToolsViews;

//namespace CMS.Print.Views;

//public class MainPage
//{
//    private readonly FontTypeView fontTypeView = new FontTypeView();
//    public void MainView()
//    {

//    }
//    public void FontTypeView()
//    {
//        Console.WriteLine("1. Create\n" +
//            "2. Update\n" +
//            "3. Delete\n" +
//            "4. Get by Id\n" +
//            "5. Get All\n" +
//            "6. Change\n" +
//            "7. Main");
//        Console.Write(">>>>>: ");
//        string number = Console.ReadLine();
//        switch(number)
//        {
//            case "1":
//                {
//                    fontTypeView.Create();
//                    break;
//                }
//            case "2":
//                {
//                    fontTypeView.Update();
//                    break;
//                }
//            case "3":
//                {
//                    fontTypeView.Delete();
//                    break;
//                }
//            case "4":
//                {
//                    fontTypeView.GetById();
//                    break;
//                }
//            case "5":
//                {
//                    fontTypeView.GetAll();
//                    break;
//                }
//            case "6":
//                {
//                    fontTypeView.ChangeFontFamily();
//                    break;
//                }
//            case "7":
//                {
//                    MainView();
//                    break;
//                }
//            default:
//                {
//                    FontTypeView();
//                    break;   
//                }
//        }
//    }
//}
