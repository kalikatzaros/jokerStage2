using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jokerStage2
{
    class PlayerService
    {
        public static List<Player> AllPlayers = new List<Player>();
        public static void CreatePlayer()
        {
            var player =  new Player(); 
            Console.WriteLine("Insert Players");
            Console.WriteLine("Give player's name :");
            player.Name = Console.ReadLine();
            Console.WriteLine("Choose a way of playing :");
            Console.WriteLine("Press 1 for random numbers or 2 to enter your numbers");
            var choice = Console.ReadKey();
            if (choice.Key == ConsoleKey.D1)
            {
                var draw = new Draw();
                player.JokerNumber = draw.RandomJoker();
                player.Numbers = draw.RandomNumbers();
            }
            if (choice.Key == ConsoleKey.D2)
            {
               player.SelectNumber();
               player.SelectNumbers();
            }
            player.PrintSelectedNumbers();
            Console.WriteLine($"Joker: {player.JokerNumber}");
            AllPlayers.Add(player);
    }
    }
       
}
