using System.Globalization;
using Task2MarketSystem;

UserManager userManager = new UserManager();
CategoryManager categoryManager = new CategoryManager();
ProductManager productManager = new ProductManager(categoryManager.GetCategories());
MyMethod(userManager, productManager, categoryManager);

static void MyMethod(UserManager userManager, ProductManager productManager, CategoryManager categoryManager)
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
                        productManager.AddProduct();
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
                        categoryManager.AddCategory();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("This button is not for seller");
                    }
                    break;
                case 5:
                    productManager.ShowProductList();
                    break;
                case 6:
                    productManager.ShowProductListById();
                    break;
                case 7:
                    categoryManager.ShowCategoryList();
                    break;
                case 8:
                    if (userManager.isAdmin)
                    {
                        Console.Clear();
                        productManager.DeleteProduct();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("This button is not for seller");
                    }
                    break;
                case 9:
                    productManager.SellProduct();
                    break;
                case 10:
                    productManager.ShowSelledProduct();
                    break;
                case 11:
                    if (userManager.isAdmin)
                    {
                        Console.Clear();
                        productManager.ReturnSelledProduct();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("This button is not for seller");
                    } break;
                 case 12:
                     if(userManager.isAdmin)
                    {
                        Console.Clear();
                        Console.WriteLine("Enter product id to update: ");
                        int productId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new product name: ");
                        string newName = Console.ReadLine();
                        Console.WriteLine("Enter new categoryId: ");
                        int newCategoryId = int.Parse(Console.ReadLine());
                        productManager.UpdateProduct(productId, newName, newCategoryId);
                    }
                    else
                    {
                        Console.WriteLine("This button is not for seller");
                    }
                     break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }

        while (option != 0);
        {
            Console.Clear();
            MyMethod(userManager, productManager, categoryManager);
        }
    }
    else
    {
        Console.WriteLine("Press Enter to return to the menu...");
        Console.ReadLine();
        Console.Clear();
        MyMethod(userManager, productManager, categoryManager);
    }
}
