﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);

            int sum = 0;
            string numtostring = Convert.ToString(num);

            Console.WriteLine("The digits");

            foreach (var item in numtostring)
            {          
                Console.WriteLine(item);
                sum += Convert.ToInt32(item.ToString());
            }

            Console.WriteLine("The sum of digits {0}", sum);
            Console.ReadLine();
        }
    }
}
