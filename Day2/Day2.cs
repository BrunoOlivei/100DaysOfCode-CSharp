﻿using System;

namespace Day2
{
    class Day2
    {
        static void Main(string[] args)
        {
            // ArithmeticOperators(args);
            //
            // Console.WriteLine();
            //
            // Bhaskara(args);
            
            DataInput(args);

        }

        /*
         * Arithmetic Operators
         */
        static void ArithmeticOperators(string[] args)
        {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            int n4 = 10 / 8;
            double n5 = 10 / 8; // Possible loss of fraction
            double n6 = (double) 10 / 8;
            double n7 = 10.0 / 8;
            
            Console.WriteLine(n1); // 11
            Console.WriteLine(n2); // 14
            Console.WriteLine(n3); // 2
            Console.WriteLine(n4); // 1
            Console.WriteLine(n5); // 1.0
            Console.WriteLine(n6); // 1.25
            Console.WriteLine(n7); // 1.25
        }
        static void Baskara(string[] args)
        {
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            
            Console.WriteLine($"Delta: {delta}"); // 25
            Console.WriteLine($"X1: {x1}"); // 4
            Console.WriteLine($"X2: {x2}"); // -1
        }
        
        /*
         * Data Input
         */
        static void DataInput(string[] args)
        {
            Console.WriteLine("Enter your full name:");
            string name = Console.ReadLine();
            Console.WriteLine(name);

        }
    }
}