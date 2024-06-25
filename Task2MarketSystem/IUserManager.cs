using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2MarketSystem
{
    internal interface IUserManager
    {
        bool UserControl(string username, string password);
        void AddSeller();
        void AddCashier();
        void Exit();
    }
}
