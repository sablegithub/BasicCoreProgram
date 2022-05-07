using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Flipcoin
    {
        public void FlipCoin()
        {
            Random rnd = new Random();
            int result = rnd.Next(0, 2);

            if (result < 0.5)
            {
                Console.WriteLine("Tails!");

            }
            else if (result == 1)
            {
                Console.WriteLine("Heads!");

            }
        }
    }
}
