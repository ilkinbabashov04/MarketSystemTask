using Task2MarketSystem;

UserManager userManager = new UserManager();
MyMethod(userManager);

static void MyMethod(UserManager userManager)
{
    Console.Write("Enter username: ");
    string setUserName = Console.ReadLine();
    Console.Write("Enter password: ");
    string setPassword = Console.ReadLine();
    Menu menu = new Menu();
    int option;
    bool adminManagerChoose = userManager.UserControl(setUserName, setPassword);
    if (adminManagerChoose)
    {
        Console.Clear();
        do
        {
            menu.MenuShow(userManager.isAdmin);
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 0:
                    userManager.Exit();
                    break;
                case 1:
                    if (userManager.isAdmin)
                    {
                        Console.Clear();
                        userManager.AddSeller();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("This button is not for seller");
                    }
                    break;
                case 2:
                    if (userManager.isAdmin)
                    {
                        Console.Clear();
                        userManager.AddCashier();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("This button is not for seller");
                    }
                    break;
                case 3:
                    if (userManager.isAdmin)
                    {
                        Console.Clear();
                        userManager.AddProduct();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("This button is not for seller");
                    }
                    break;
                case 4:
                    if (userManager.isAdmin)
                    {
                        Console.Clear();
                        userManager.AddCategory();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("This button is not for seller");
                    }
                    break;
                case 5:
                    userManager.ShowProductList();
                    break;
                case 6:
                    userManager.ShowProductsById();
                    break;
                case 7:
                    userManager.ShowCategoryList();
                    break;
                case 8:
                    if (userManager.isAdmin)
                    {
                        Console.Clear();
                        userManager.DeleteProduct();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("This button is not for seller");
                    }
                    break;
                case 9:
                    userManager.SellProduct();
                    break;
                case 10:
                    userManager.ShowSelledProduct();
                    break;
                case 11:
                    if (userManager.isAdmin)
                    {
                        Console.Clear();
                        userManager.ReturnSelledProduct();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("This button is not for seller");
                    } break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }

        while (option != 0);
        {
            Console.Clear();
            MyMethod(userManager);
        }
    }
    else
    {
        Console.WriteLine("Press Enter to return to the menu...");
        Console.ReadLine();
        Console.Clear();
        MyMethod(userManager);
    }
}
