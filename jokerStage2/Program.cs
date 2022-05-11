using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jokerStage2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalispera!!!");
            var player1 = new Player()
            {
                Name = "kali"
            };
            //player1.SelectNumbers();
            //player1.PrintSelectedNumbers();
            //player1.SelectNumber();
            //Console.WriteLine(player1.JokerNumber);
            player1.Numbers.Add(1);
            player1.Numbers.Add(23);
            player1.Numbers.Add(4);
            player1.Numbers.Add(14);
            player1.JokerNumber = 4;

            //PlayerSeplayer1.rvice.CreatePlayer();
            var player2= new Player()
            {
                Name = "alexis"
            };

            player2.Numbers.Add(1);
            player2.Numbers.Add(23);
            player2.Numbers.Add(4);
            player2.Numbers.Add(14);
            player2.JokerNumber = 4;
            var player3= new Player()
            {
                Name = "nick"
            };

            var shop = new Shop()
            {
                Name = "shop"
            };

           shop.Numbers.Add(1);
            shop.Numbers.Add(3);
            shop.Numbers.Add(4);
            shop.Numbers.Add(14);
           shop.JokerNumber = 2;
            shop.PrintLotteryNumbers();
            shop.Players.Add(player1);
            shop.Players.Add(player2);
            foreach (var player in shop.Players)
            {
                Console.WriteLine(player.Name);
            }
            shop.CheckWinners();
        }
    }
}
