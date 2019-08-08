using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
        //This class is SOLID! It uses the single responsibility principle to do one thing only, and that is to sell products to the user.
    {
        //member variables
        public int sugarSale;
        public int iceSale;
        public int lemonSale;
        public int cupSale;
        public double sugarPrice;
        public double icePrice;
        public double lemonPrice;
        public double cupPrice;

        //construct
        public Store()
        {
            sugarPrice = 0.12;
            icePrice = 0.05;
            lemonPrice = 0.29;
            cupPrice = 0.08;
        }

        //methods
        public int PurchaseSugar()
        {
            Console.WriteLine("How many cups of sugar would you like to buy?\nSugar costs 12 cents per cup.");
            sugarSale = int.Parse(Console.ReadLine());
            return sugarSale;
        }
        public int PurchaseLemons()
        {
            Console.WriteLine("How many lemons would you like to buy?\nLemons costs 49 cents each.");
            lemonSale = int.Parse(Console.ReadLine());
            return lemonSale;
        }
        public int PurchaseIce()
        {
            Console.WriteLine("How many ice cubes would you like to buy?\nIce costs 6 cents per cube.");
            iceSale = int.Parse(Console.ReadLine());
            return iceSale;
        }
        public int PurchaseCups()
        {
            Console.WriteLine("How many cups would you like to buy?\nCups cost 8 cents each.");
            cupSale = int.Parse(Console.ReadLine());
            return cupSale;
        }

    }
}
