﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3
{
    internal class Program
    {
        static void GetMax(int a)
        {
            int n = int.Parse(Console.ReadLine());
            var m = -10000000000000;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num > m)
                    m = num;
            }
            Console.WriteLine("max=" + m);
        }
        static void Main(string[] args)
        {
           Console.WriteLine("Enter 3 numbers");
           GetMax(3);
        }
    }
}
