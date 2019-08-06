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

        //construct
        public Inventory(int sugar, int lemons, int iceCubes, int cups)
        {
            moneyCounter = 20;
            pitcherCounter = 0;
        }



        //methods
        public int AddSugar()
        {
            store.PurchaseSugar();
            sugar += store.sugarSale;
            return sugar;
        }
        public int AddLemons()
        {
            store.PurchaseLemons();
            lemons += store.lemonSale;
            return lemons;
        }
        public int AddIce()
        {
            store.PurchaseIce();
            iceCubes += store.iceSale;
            return iceCubes;
        }
        public int AddCups()
        {
            store.PurchaseCups();
            cups += store.cupSale;
            return cups;
        }
        public double ChargeSugar()
        {
            moneyCounter -= store.sugarSale * store.sugarPrice;
            return moneyCounter;
        }
        public double ChargeLemons()
        {
            moneyCounter -= store.lemonSale * store.lemonPrice;
            return moneyCounter;
        }
        public double ChargeIce()
        {
            moneyCounter -= store.iceSale * store.icePrice;
            return moneyCounter;
        }
        public double ChargeCups()
        {
            moneyCounter -= store.cupSale * store.cupPrice;
            return moneyCounter;
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
