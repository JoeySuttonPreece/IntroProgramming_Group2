using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuoVia;

namespace W5
{
    class Program
    {
        static void Main(string[] args)
        {
            string old;
            string current;

            while (true)
            {
                current = Console.ReadLine();
                double score = DuoVia.FuzzyStrings.DiceCoefficientExtensions.DiceCoefficient(Console.ReadLine(), Console.ReadLine());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }

       
}