using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static class UserInterface
    {
        public static void DisplayInventory(Inventory inventory)
        {
            Console.WriteLine("\nYou now have $" + inventory.moneyCounter + " and the following ingredients and supplies:\n" + inventory.sugar + " cups of sugar\n" + inventory.lemons + " lemons\n" + inventory.iceCubes + " ice cubes\n" + inventory.cups + " paper cups.\n");
        }
        public static void EndDay(Inventory inventory)
        {
            Console.WriteLine("You ended today with $" + inventory.moneyCounter + ". and all of your ice has melted");
            Console.ReadLine();
            Console.Clear();
        }
        public static void BeginDay(Inventory inventory, Player player1)
        {
            if (inventory.moneyCounter >= 20)
            {
                Console.WriteLine("You have made $" + (inventory.moneyCounter - 20) + " so far.");
            }
            else
            {
                Console.WriteLine("You have lost $" + (20 - inventory.moneyCounter) + " so far.");
            }
            Console.WriteLine(player1.playerName + " is about to open for today. You have $" + inventory.moneyCounter + ".\n");
            Console.ReadLine();
            Console.WriteLine("Your Lemonade Stand forecast is below, temperature followed by conditions\n");
        }
        public static void EndGame(Inventory inventory, Player player1)
        {
            Console.WriteLine("You were able to make $" + (inventory.moneyCounter - 20) + " from " + player1.playerName + ".");
            Console.ReadLine();
            Console.WriteLine("The game is over! Please play again and try to make even more money next time!");
            Console.ReadLine();
        }
        public static void TodayWeather(Day day)
        {
            Console.WriteLine("Today is " + day.weather.temperature + " degrees and it is " + day.weather.condition + ".\n");
        }

}
}
