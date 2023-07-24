using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice
{
    internal class triangle
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
