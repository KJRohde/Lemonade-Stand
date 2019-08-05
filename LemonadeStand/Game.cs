using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //member variables
        private Player player1;

        //construct

        //methods
        public void RunGame()
        {
            Console.WriteLine("Your Lemonade Stand starts with $20.\nYou are able to purchase new supplies and ingredients each day before selling.\nCustomers will decide whether they want to buy your product based on various circumstances.\nYou will have the option to buy and sell each day for 7 days to maximize profits.");
            player1 = new Player();
            Console.ReadLine();
            player1.ChooseName();
        }
    }
}
