﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, n1 = 0, n2 = 1, n3;
            Console.Write("Enter the range of the Fibonacci series: ");
            num = Convert.ToInt32(Console.ReadLine());
            if(num == 0)
            {
                Console.Write(n1 + " ");
            }
            else if(num == 2)
            {
                Console.Write(n1 + " " + n2 + " ");

            }
            else
            {
                Console.Write(n1 + " " + n2 + " ");
                for(int i = 2; i < num; i++)
                {
                    n3 = n1 + n2;
                    Console.Write(n3 + " ");
                    n1 = n2;
                    n2 = n3;
                }
            }
            Console.ReadLine();
        }
    }
}
