using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Driver
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Dice = new Regular(DiceTypes.D6);
            for (int i = 0; i < 10; i++)
            {                
                Console.WriteLine("Result = {0}",Dice.RollDie());
            }

            Console.WriteLine();
            ListTest(DiceTypes.D10, 5);

            Console.ReadKey();
        }

        static void ListTest(DiceTypes Die, int size)
        {
            List<Dice> col = new List<Dice>();

            col.Add(new Regular(Die));
            col.Add(new Exploding(Die,size));

            foreach (var Y in col)
            {
                if (Y is Regular)
                    Console.WriteLine("It is a regular dice");
                else if (Y is Exploding)
                    Console.WriteLine("It is an exploding dice");
                else
                    Console.WriteLine("It is neither");
            }
        }
    }
}
