using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Polymorphism.Method_OverLoading
{
    public class Calculation
    {
        public int a;
        public int b;
        public int c;
        public double v;
        public int add()
        {
            Console.WriteLine("Enter first number ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            int b = int.Parse(Console.ReadLine());
            return c = a + b;
        }
        public int add(int x, int y)
        {
            Console.WriteLine("Enter first number ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            int b = int.Parse(Console.ReadLine());
            return c = a + b + x + y;
        }
        public double add(float x, double y)
        {
            Console.WriteLine("Enter first number ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            int b = int.Parse(Console.ReadLine());
            //double z = x + y;
            return v = a + b + x + y;

        }
    }
}