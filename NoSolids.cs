// Bad Example – Violates All SOLID Principles
using System;

namespace SOLID_Demo
{
    public class BadCalculatorV2
    {
        // Method does everything + depends on strings + prints directly.
        public void Calculate(string operation, double x, double y)
        {
            if (operation == "add")
            {
                Console.WriteLine(x + y);
            }
            else if (operation == "sub")
            {
                Console.WriteLine(x - y);
            }
            else if (operation == "mul")
            {
                Console.WriteLine(x * y);
            }
            else if (operation == "div")
            {
                if (y == 0)
                {
                    Console.WriteLine("Division By Zero!!!");
                }
                else
                {
                    Console.WriteLine(x / y);
                }
            }
            else if (operation == "pow")
            {
                Console.WriteLine(Math.Pow(x, y));
            }
            else
            {
                Console.WriteLine("Invalid Operation");
            }
        }
    }
}
