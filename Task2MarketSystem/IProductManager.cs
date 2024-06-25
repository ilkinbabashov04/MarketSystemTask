using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2MarketSystem
{
    internal interface IProductManager
    {
        void AddProduct();
        void ShowProductList();
        void ShowProductListById();
        void DeleteProduct();
        void SellProduct();
        void ShowSelledProduct();
        void ReturnSelledProduct();
        void UpdateProduct(int productId, string newname, int newCategoryId);

    }
}
