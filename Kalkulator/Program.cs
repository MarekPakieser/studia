﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)

            {
                int menuOption = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("1. add");
                Console.WriteLine("2. Diff");
                if (menuOption==0)
                {
                    break;
                }
                Console.WriteLine("4. Exit");

            }
        }
    }
}
