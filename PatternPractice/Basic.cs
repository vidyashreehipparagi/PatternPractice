using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice
{
    internal class Basic
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}