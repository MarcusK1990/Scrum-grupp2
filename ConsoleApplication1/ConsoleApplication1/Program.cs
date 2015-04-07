using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("\n Test Console App ver. 0.9");
            Console.WriteLine("\n Slumpat nummer mellan 0 - 999: " + new Random().Next(0, 1000));
            Console.ReadKey();
        }
    }
}
