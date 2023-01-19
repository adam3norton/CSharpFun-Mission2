using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Adam Norton -- Wed Jan 18, 2023
// IS 413 -- Enterprise Application Development
// Mission #2 Assignment

namespace CSharpFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Adam's Dice-Throwing Simulator!");
            Console.WriteLine("How many dice rolls would you like to simulate?");
            int numRolls = int.Parse(Console.ReadLine());
            int[] rollTotals = new int[13];

            Random rand = new Random();

            for (int i = 0; i < numRolls; i++)
            {
                int roll1 = rand.Next(1, 7);
                int roll2 = rand.Next(1, 7);
                int rollTotal = roll1 + roll2;
                rollTotals[rollTotal]++;
            }

            for (int i = 2; i < 13; i++)
            {
                double numStars = (double)rollTotals[i] / numRolls * 100;
                Console.Write(i + ": ");
                for (int j = 0; j < numStars; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
