using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        //member variables
        private Store store = new Store();
        public int iceCubes;
        public int lemons;
        public int sugar;
        public int cups;
        public double moneyCounter;
        public int pitcherCounter;
        public bool comfirmPurchase;

        //construct
        public Inventory(int sugar, int lemons, int iceCubes, int cups)
        {
            moneyCounter = 20;
            moneyCounter = Math.Round(moneyCounter, 2);
            pitcherCounter = 0;
        }



        //methods
        public int AddSugar()
        {
            store.PurchaseSugar();
            if (store.sugarSale * store.sugarPrice > moneyCounter)
            {
                Console.WriteLine("You cannot afford this many cups of sugar. Try again.");
                return store.PurchaseSugar();
            }
            else
            {
                Console.WriteLine("Are you sure you want to buy " + store.sugarSale + " cups of sugar for $" + store.sugarSale * store.sugarPrice + "?");
                Console.ReadLine();
                moneyCounter -= (store.sugarSale * store.sugarPrice);
                sugar += store.sugarSale;
                return sugar;
            }
        }
        public int AddLemons()
        {
            store.PurchaseLemons();
            if (store.lemonSale * store.lemonPrice > moneyCounter)
            {
                Console.WriteLine("You cannot afford this many lemons. Try again.");
                return store.PurchaseLemons();
            }
            else
            {
                Console.WriteLine("Are you sure you want to buy " + store.lemonSale + " cups of sugar for $" + store.lemonSale * store.lemonPrice + "?");
                Console.ReadLine();
                moneyCounter -= (store.lemonSale * store.lemonPrice);
                lemons += store.lemonSale;
                return lemons;
            }
        }
        public int AddIce()
        {
            store.PurchaseIce();
            if (store.iceSale * store.icePrice > moneyCounter)
            {
                Console.WriteLine("You cannot afford this many ice cubes. Try again.");
                return store.PurchaseIce();
            }
            else
            {
                Console.WriteLine("Are you sure you want to buy " + store.iceSale + " cups of sugar for $" + store.iceSale * store.icePrice + "?");
                Console.ReadLine();
                moneyCounter -= (store.iceSale * store.icePrice);
                iceCubes += store.iceSale;
                return iceCubes;
            }
        }
        public int AddCups()
        {
            store.PurchaseCups();
            if (store.cupSale * store.cupPrice > moneyCounter)
            {
                Console.WriteLine("You cannot afford this many cups. Try again.");
                return store.PurchaseCups();
            }
            else
            {
                Console.WriteLine("Are you sure you want to buy " + store.cupSale + " cups of sugar for $" + store.cupSale * store.cupPrice + "?");
                Console.ReadLine();
                moneyCounter -= (store.cupSale * store.cupPrice);
                cups += store.cupSale;
                return cups;
            }
        }
        public int MakePitchers()
        {
            while (lemons >= 4 && sugar >= 4 && cups > 4 && iceCubes > 2)
            {
                lemons -= 4;
                sugar -= 4;
                cups -= 5;
                iceCubes -= 3;
                pitcherCounter++;
            }
            return pitcherCounter;
        }
    }
}
