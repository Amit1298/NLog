﻿using System;

namespace NlogServicesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition Problem \n Enter a, b values");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            AddNumber add = new AddNumber();
            Console.WriteLine("Result is" + " " + add.Sum(a, b));
        }
    }
}
