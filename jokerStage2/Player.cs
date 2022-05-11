using System;
using System.Collections.Generic;

namespace jokerStage2
{
    class Player
    {
        public string Name { get; set; }

        public List<int> Numbers { get; set; } = new List<int>();
        public int JokerNumber { get;  set; }


        public void SelectNumbers()
        {
            
            Console.WriteLine("Select 4 numbers");
            for (int i = 0; i < 4; i++)
            {
                
               var number = Convert.ToInt32(Console.ReadLine());

                if (number > 0 && number < 46)
                {
                    Numbers.Add(number);                   
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    i--;
                }
                
            }

        }

        public void SelectNumber()
        {
            Console.WriteLine("Select the Joker number");
            var number = Convert.ToInt32(Console.ReadLine());

            //if(number > 0 && number < 21)
            //{
            //    Numbers.Add(number);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //    SelectNumber();
            //}
            while(number>21 || number < 1)
            {
                Console.WriteLine("Provide a valid number (1-21)");
                number = Convert.ToInt32(Console.ReadLine());
            }
            JokerNumber = number;

        }

        public void PrintSelectedNumbers()
        {
            Console.WriteLine("Your selected numbers are :");

            foreach (var number in Numbers)
            {
                Console.WriteLine(number);
            }            
        }

    }  

 }
