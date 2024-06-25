using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2MarketSystem
{
    internal class ProductManager : IProductManager
    {
        List<Product> selledProducts = new List<Product>();
        List<Product> products = new List<Product>();
        List<Category> categories;

        public ProductManager(List<Category> categories)
        {
            this.categories = categories;
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

        public void DeleteProduct()
        {
            Console.Clear();
            Console.WriteLine("Enter the Id of product which you want to delete: ");
            int DeleteId = int.Parse(Console.ReadLine());

            Product deletedProduct = products.Find(x => x.Id == DeleteId);
            if (deletedProduct != null)
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
            Console.Clear();
        }

        public void ReturnSelledProduct()
        {
            Console.Clear();
            Console.WriteLine("Enter id of product which one you want to return: ");
            int returnSelledProduct = int.Parse(Console.ReadLine());

            Product productToReturn = selledProducts.Find(a => a.Id == returnSelledProduct);
            if (productToReturn != null)
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

        public void SellProduct()
        {
            Console.Clear();
            Console.WriteLine("Enter the id of product which one you want to sell: ");
            int sellProductId = int.Parse(Console.ReadLine());

            Product productToSell = products.Find(a => a.Id == sellProductId);
            if (productToSell != null)
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

        public void ShowProductList()
        {
            Console.Clear();
            foreach (Product product in products)
            {
                Console.WriteLine($"product name: {product.ProductName}, \n product id: {product.Id}, \n category id: {product.CategoryId}");
            }
            Console.ReadLine();
            Console.Clear();
        }

        public void ShowProductListById()
        {
            Console.Clear();
            Console.Write("Enter category Id to show products: ");
            int categoryId = int.Parse(Console.ReadLine());

            bool foundProduct = false;
            Console.WriteLine();
            Console.WriteLine($"Products in category {categoryId}: ");
            foreach (Product product in products)
            {
                if (product.CategoryId == categoryId)
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

        public void UpdateProduct(int productId, string newname, int newCategoryId)
        {
            Product product = products.Find(x=>x.Id == productId);
            if (product != null)
            {
                Category category = categories.Find(y => y.CategoryId == newCategoryId);
                if (category != null)
                {
                    product.ProductName = newname;
                    product.CategoryId = newCategoryId;
                    Console.WriteLine("Product updated successfully");
                }
                else
                {
                    Console.WriteLine("Category not found with this Id");
                }

            }
            else 
            { 
                Console.WriteLine("Product not found with this Id"); 
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
