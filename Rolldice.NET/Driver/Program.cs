using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            var Dice = new Regular(DiceTypes.D6);
            for (int i = 0; i < 10; i++)
            {                
                Console.WriteLine("Result = {0}",Dice.RollDie());
            }

            Console.ReadKey();
        }
    }
}
