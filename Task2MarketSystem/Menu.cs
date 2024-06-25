using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2MarketSystem
{
    internal class Menu
    {
        public void MenuShow(bool isAdmin)
        {
            Console.WriteLine("0. Sistemden cixish");
            if (isAdmin)
            {
                Console.WriteLine("1. Satici elave et");
                Console.WriteLine("2. Cashier elave et");
                Console.WriteLine("8. Produkt sil");
                Console.WriteLine("3. Produkt elave et");
                Console.WriteLine("4. Kateqoriya elave et");
                Console.WriteLine("11. Satilmish produktu geri qaytar");
                Console.WriteLine("12. Produktu yenile");
            }
            Console.WriteLine("5. Produkt listini goster");
            Console.WriteLine("6. Kateqoriya Id-ne gore produktlari goster");
            Console.WriteLine("7. Kateqoriya listini goster");
            Console.WriteLine("9. Produkt sat");
            Console.WriteLine("10. Satilmish produklari gor");
            Console.WriteLine();
            Console.WriteLine("Enter number: ");
        }
    }
}
