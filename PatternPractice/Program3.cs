﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
               for(int j = 5; j>= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
