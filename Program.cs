﻿using System;

namespace myApp
{
    class Program
    {
        static void WorkingWithIntegers()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("The current time is " + DateTime.Now);
            int a = 28;
            int b = 42;
            int c = a + b;
            Console.WriteLine(c);
            c = a - b;
            Console.WriteLine(c);
            c = a * b;
            Console.WriteLine(c);
            c = a / b;
            Console.WriteLine(c);
            c = a + b / b;
            Console.WriteLine(c);
        }

        static void OrderPrecedence()
        {
                        int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);
            d = (a  + b) * c;
            Console.WriteLine(d);
            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);
            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e  + f) / g;
            Console.WriteLine(h);
        }

        static void Main(string[] args) 
        {
            // WorkingWithIntegers();

            // OrderPrecedence();
        }
    }
}
