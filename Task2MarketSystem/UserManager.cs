using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2MarketSystem
{
    internal class UserManager : IUserManager
    {
        List<Seller> sellers = new List<Seller>();
        List<Cashier> cashiers = new List<Cashier>();
        string defaultUserName = "Admin";
        string defaultPassword = "admin123";
        public bool isAdmin { get; set; } = false;
        public bool UserControl(string username, string password)
        {
            if (username == defaultUserName && password == defaultPassword)
            {
                isAdmin = true;
                return true;
            }
            foreach (Seller seller in sellers)
            {
                if (seller.UserName == username && seller.Password == password)
                {
                    isAdmin = false;
                    return true;
                }
            }
            foreach (Cashier cashier in cashiers)
            {
                if (cashier.UserName == username && cashier.Password == password)
                {
                    isAdmin = false;
                    return true;
                }
            }
            return false;
        }
        public void AddCashier()
        {
            Cashier cashier = new Cashier();
            Console.Write("Enter cashier fullname: ");
            cashier.FullName = Console.ReadLine();
            Console.Write("Enter cashier username: ");
            cashier.UserName = Console.ReadLine();
            Console.Write("Enter cashier password: ");
            cashier.Password = Console.ReadLine();

            cashiers.Add(cashier);
            Console.WriteLine("Cashier added successfully");
        }

        public void AddSeller()
        {
            Seller seller = new Seller();
            Console.Write("Enter seller fullname: ");
            seller.FullName = Console.ReadLine();
            Console.Write("Enter seller username: ");
            seller.UserName = Console.ReadLine();
            Console.Write("Enter seller password: ");
            seller.Password = Console.ReadLine();

            sellers.Add(seller);
            Console.WriteLine("Seller added successfully");
        }

        public void Exit()
        {
            Console.WriteLine("Exited App");
        }

    }
}
