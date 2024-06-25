using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2MarketSystem
{
    internal class CategoryManager : ICategoryManager
    {
        List<Category> categories = new List<Category>();
        public void AddCategory()
        {
            Category category = new Category();
            Console.Write("Enter Category Id: ");
            category.CategoryId = int.Parse(Console.ReadLine());
            Console.Write("Enter Category name: ");
            category.CategoryName = Console.ReadLine();

            categories.Add(category);
        }

        public void ShowCategoryList()
        {
            Console.Clear();
            foreach (Category category in categories)
            {
                Console.WriteLine($"Category name: {category.CategoryName}, Category Id: {category.CategoryId}");
            }
            Console.ReadLine();
            Console.Clear();
        }
        
        public List<Category> GetCategories()
        {
            return categories;
        }
    }
}
