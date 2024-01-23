using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuysConsoleApp
{
    public class Guy
    {
        public string? Name { get; set; }
        public int Cash { get; set; }
        public void WriteMyInfo()
        {
            Console.WriteLine(Name + " has " + Cash + " In Cash");
        }
        public int GiveCash(int amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine(Name + " Says: " + amount + " is not a valid amount");
                return 0;
            }
            else if(amount > Cash)
            {
                Console.WriteLine(Name + " says : I Don't Have Enough Cash To Give You " + amount);
                return 0;
            }

            Cash -= amount;
            return amount;
        }
        public void RecieveCash(int amount)
        {
            if(amount<= 0)
            {
                Console.WriteLine(Name + " says: " + amount + "isn't an amount I'd Take ");
            }
            else
            {
                Cash += amount;
            }
        }
    }
}
