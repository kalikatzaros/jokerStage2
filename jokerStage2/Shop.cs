using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jokerStage2
{
    class Shop
    {
        public string Name { get; set; }
        public List<int> Numbers { get; set; } = new List<int>();
        public int JokerNumber { get; set; }
        public List<Player> Players { get;  set; } = new List<Player>();


        public Shop()
        {

            Players = PlayerService.AllPlayers;
        }
         public void LotteryNumbers()
        {
            var draw = new Draw();
            JokerNumber = draw.RandomJoker();
            Numbers = draw.RandomNumbers();
        }

        public void CheckWinners()
        {
            int playerCount = 0;
            foreach (var player in Players)
            {                
                foreach (var number in player.Numbers)
                {
                    if (Numbers.Contains(number))
                    {
                        playerCount++;
                    }
                }
                var joker = (player.JokerNumber == JokerNumber) ? 1 : 0;
                Console.WriteLine($"Player {player.Name} finds {playerCount} and {joker}");
                playerCount = 0;
            }

            //foreach (var player in Players)
            //{

            //    if (player.JokerNumber == JokerNumber)
            //    {
            //        Console.WriteLine($"Player :{player.Name} 1");
            //    }
            //}
            
        }
        public void PrintLotteryNumbers()
        {
            foreach (var number in Numbers)
            {
                Console.Write(number + ",");
            }
            Console.Write($"\t{JokerNumber}\n");
        }
    }
}
