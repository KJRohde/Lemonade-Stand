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
        public int iceCubes;
        public int lemons;
        public int sugar;
        public int cups;
        public int lemonsPerPitcher;
        public int sugarPerPitcher;
        public int iceCubesPerPitcher;
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
        //public int AddSugar()
        //{
        //    Console.WriteLine("You have $" + moneyCounter + " to buy supplies");
        //    store.PurchaseSugar();
        //    if (store.sugarSale * store.sugarPrice > moneyCounter)
        //    {
        //        Console.WriteLine("You cannot afford this many cups of sugar. Try again.");
        //        store.sugarSale = 0;
        //        return store.PurchaseSugar();
        //    }
        //    else
        //    {              
        //        moneyCounter -= (store.sugarSale * store.sugarPrice);
        //        sugar += store.sugarSale;
        //        return sugar;
        //    }
        //}
        //public int AddLemons()
        //{
        //    Console.WriteLine("You have $" + moneyCounter + " to buy supplies");
        //    store.PurchaseLemons();
        //    if (store.lemonSale * store.lemonPrice > moneyCounter)
        //    {
        //        Console.WriteLine("You cannot afford this many lemons. Try again.");
        //        store.lemonSale = 0;
        //        return store.PurchaseLemons();
        //    }
        //    else
        //    {
        //        moneyCounter -= (store.lemonSale * store.lemonPrice);
        //        lemons += store.lemonSale;
        //        return lemons;
        //    }
        //}
        //public int AddIce()
        //{
        //    Console.WriteLine("You have $" + moneyCounter + " to buy supplies");
        //    store.PurchaseIce();
        //    if (store.iceSale * store.icePrice > moneyCounter)
        //    {
        //        Console.WriteLine("You cannot afford this many ice cubes. Try again.");
        //        store.iceSale = 0;
        //        return store.PurchaseIce();
        //    }
        //    else
        //    {
        //        moneyCounter -= (store.iceSale * store.icePrice);
        //        iceCubes += store.iceSale;
        //        return iceCubes;
        //    }
        //}
        //public int AddCups()
        //{
        //    Console.WriteLine("You have $" + moneyCounter + " to buy supplies");
        //    store.PurchaseCups();
        //    if (store.cupSale * store.cupPrice > moneyCounter)
        //    {
        //        Console.WriteLine("You cannot afford this many cups. Try again.");
        //        store.cupSale = 0;
        //        return store.PurchaseCups();
        //    }
        //    else
        //    {
        //        moneyCounter -= (store.cupSale * store.cupPrice);
        //        cups += store.cupSale;
        //        return cups;
        //    }
        //}
        public int PlanPitchersLemon()
        {
            Console.WriteLine("How many lemons would you like to place in each pitcher?");
            while (int.TryParse(Console.ReadLine(), out lemonsPerPitcher))
                {
                return lemonsPerPitcher;
                }
            return PlanPitchersLemon();
        }
        public int PlanPitchersSugar()
        {
            Console.WriteLine("How many cups of sugar would you like to place in each pitcher?");
            while (int.TryParse(Console.ReadLine(), out sugarPerPitcher))
            {
                return sugarPerPitcher;
            }
            return PlanPitchersSugar();
        }
        public int PlanPitchersIce()
        {
            Console.WriteLine("How many ice cubes would you like to place in each pitcher?");
            while (int.TryParse(Console.ReadLine(), out iceCubesPerPitcher))
            {
                return iceCubesPerPitcher;
            }
            return PlanPitchersIce();
        }
            public int MakePitchers()
        {
            while (lemons >= lemonsPerPitcher && sugar >= sugarPerPitcher && cups > 4 && iceCubes >= iceCubesPerPitcher)
            {
                lemons -= lemonsPerPitcher;
                sugar -= sugarPerPitcher;
                cups -= 5;
                iceCubes -= iceCubesPerPitcher;
                pitcherCounter++;
            }
            return pitcherCounter;
        }
    }
}
