using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jokerStage2
{
    public class Draw
    {
        public Random RandomNumber { get; } = new Random();
        
        public int RandomJoker()
        {
            return RandomNumber.Next(1, 21);
        }

        public List<int> RandomNumbers()
        {
            List<int> numbers = new List<int>();
            for(int i = 0; i < 4; i++)
            {
                var number = RandomNumber.Next(1, 46);
                if (numbers.Contains(number))
                {
                    i--;
                }
                else
                {
                    numbers.Add(number);
                }
            }
            return numbers;
        }

        
        
    }
}
