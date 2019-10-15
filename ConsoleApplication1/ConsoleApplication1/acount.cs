using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class acount
    {
        private int MONEY;
        public acount(int amount)
        {
            MONEY = amount;

        }
        public void Deposit(int amount)
        {
            MONEY += amount;
        }
        public void WithDraw(int amount)
        {
            MONEY += amount;
        }
        public  int Balance()
        {
            return MONEY;
        }
    }
}
