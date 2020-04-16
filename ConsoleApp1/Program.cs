using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = 0, x2 = 0, y1 = 1, y2 = 2, z = 1;
            otrezok a = new otrezok();
            xoy aXoY = new xoy();
            a.Init(x1, y1, x2, y2);
            aXoY.Init(x1, y1, x2, y2, z);
            Console.WriteLine("Hello World!");
        }
    }
}
