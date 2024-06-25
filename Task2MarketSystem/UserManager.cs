using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2MarketSystem
{
    internal class UserManager
    {
        List<Seller> sellers = new List<Seller>();
        List<Cashier> cashiers = new List<Cashier>();
        List<Product> products = new List<Product>();
        List<Category> categories = new List<Category>();
        List<Product> selledProducts = new List<Product>();
        string defaultUserName = "Admin";
        string defaultPassword = "admin123";
        public bool isAdmin { get; set; } = false;
        public bool UserControl(string username, string password)
        {
            if(username == defaultUserName && password == defaultPassword)
            {
                isAdmin = true;
                return true;
            }
            foreach(Seller seller in sellers)
            {
                if(seller.UserName == username && seller.Password == password)
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
        public void AddSeller()
        {
            Seller seller = new Seller();
            Console.Write("Enter seller fullname:");
            seller.FullName = Console.ReadLine();
            Console.Write("Enter seller username: ");
            seller.UserName = Console.ReadLine();
            Console.Write("Enter seller password: ");
            seller.Password = Console.ReadLine();

            sellers.Add(seller);
            Console.WriteLine("Seller added successfully");
        }

        public void AddCashier()
        {
            Cashier cashier = new Cashier();
            Console.Write("Enter cashier fullname:");
            cashier.FullName = Console.ReadLine();
            Console.Write("Enter cashier username:");
            cashier.UserName = Console.ReadLine();
            Console.Write("Enter cashier password: ");
            cashier.Password = Console.ReadLine();

            cashiers.Add(cashier);
            Console.WriteLine("Cashier added successfully");
        }

        public void AddCategory()
        {
            Category category = new Category();
            Console.Write("Enter Category Id: ");
            category.CategoryId = int.Parse(Console.ReadLine());
            Console.Write("Enter Category name: ");
            category.CategoryName = Console.ReadLine();

            categories.Add(category);
        }

        public void AddProduct()
        {
            Product product = new Product();
            Console.Write("Enter product Id: ");
            product.Id = int.Parse(Console.ReadLine());
            Console.Write("Enter product name: ");
            product.ProductName = Console.ReadLine();
            Console.Write("Enter category Id: ");
            int categoryId = int.Parse(Console.ReadLine());

            Category category = categories.Find(c => c.CategoryId == categoryId);
            if (category != null)
            {
                product.CategoryId = categoryId;
                products.Add(product);
                Console.WriteLine("Product added successfully");
            }
            else
            {
                Console.WriteLine("Category Id not found");
            }
        }


        public void ShowProductList() 
        {
            Console.Clear();
            foreach (Product product in products)
            {
                Console.WriteLine($"product name: {product.ProductName}, \n product id: {product.Id}, \n category id: {product.CategoryId}");
            }
            Console.ReadLine();
            Console.Clear ();
        }

        public void ShowProductsById()
        {
            Console.Clear ();
            Console.Write("Enter category Id to show products: ");
            int categoryId = int.Parse(Console.ReadLine());

            bool foundProduct = false;
            Console.WriteLine();
            Console.WriteLine($"Products in category {categoryId}: ");
            foreach (Product product in products)
            {
                if(product.CategoryId == categoryId)
                {
                    Console.WriteLine($"Product Name: {product.ProductName}, Product id: {product.Id}");
                    foundProduct = true;
                }

            }
            if (!foundProduct) 
            {
                Console.WriteLine("There is no product inside of this category number");
            }
            Console.ReadLine();
            Console.Clear ();

        }

        public void ShowCategoryList()
        {
            Console.Clear();
            foreach (Category category in categories)
            {
                Console.WriteLine($"Category name: {category.CategoryName}, Category Id: {category.CategoryId}");
            }
            Console.ReadLine();
            Console.Clear ();
        }

        public void DeleteProduct()
        {
            Console.Clear();
            Console.WriteLine("Enter the Id of product which you want to delete: ");
            int DeleteId = int.Parse(Console.ReadLine());
            
            Product deletedProduct = products.Find(x => x.Id == DeleteId);
            if(deletedProduct != null)
            {
                products.Remove(deletedProduct);
                Console.WriteLine();
                Console.WriteLine("Product deleted successfully");
            }
            else
            {
                Console.WriteLine("There is no product with this Id");
            }
            Console.ReadLine();
            Console.Clear ();
        }

        public void SellProduct()
        {
            Console.Clear();
            Console.WriteLine("Enter the id of product which one you want to sell: ");
            int sellProductId = int.Parse(Console.ReadLine());

            Product productToSell = products.Find(a => a.Id == sellProductId);
            if(productToSell != null)
            {
                products.Remove(productToSell);
                selledProducts.Add(productToSell);
            }
            else
            {
                Console.WriteLine("There is no product with this Id");
            }
            Console.ReadLine();
            Console.Clear();
        }

        public void ShowSelledProduct()
        {
            Console.Clear();
            foreach (Product selledproduct in selledProducts)
            {
                Console.WriteLine($"Category id: {selledproduct.CategoryId}, Product name: {selledproduct.ProductName} ");
            }
            Console.ReadLine();
            Console.Clear();

        }

        public void ReturnSelledProduct()
        {
            Console.Clear();
            Console.WriteLine("Enter id of product which one you want to return: ");
            int returnSelledProduct = int.Parse(Console.ReadLine());

            Product productToReturn = selledProducts.Find(a =>a.Id == returnSelledProduct);
            if(productToReturn != null)
            {
                selledProducts.Remove(productToReturn);
                products.Add(productToReturn);
            }
            else
            {
                Console.WriteLine("There is no product with this Id");
            }
            Console.ReadLine();
            Console.Clear();
        }


        public void Exit()
        {
            Console.WriteLine("Exited app");
        }
    }
}
