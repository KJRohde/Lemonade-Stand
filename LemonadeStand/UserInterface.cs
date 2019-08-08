using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class UserInterface
    {
        private static void DisplayInventory(Inventory inventory)
        {
            Console.WriteLine("You now have $" + inventory.moneyCounter + " and the following ingredients and supplies:\n" + inventory.sugar + " cups of sugar\n" + inventory.lemons + " lemons\n" + inventory.iceCubes + " ice cubes\n" + inventory.cups + " paper cups\nAnd you have $" + inventory.moneyCounter + " remaining.");
        }

    }
}
