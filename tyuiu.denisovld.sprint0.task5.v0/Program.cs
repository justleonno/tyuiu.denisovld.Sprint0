using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.denisovld.sprint0.task5.v0.lib;
namespace tyuiu.denisovld.sprint0.task5.v0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(5, 7));
            Console.WriteLine("A - B = " + DataService.Subtraction(5, 7));
            Console.WriteLine("A * B = " + DataService.Multiplication(5, 7));

            Console.WriteLine("A / B = " + DataService.Division(5, 0));
            Console.WriteLine("A / B = " + DataService.Division(5, 5));
            Console.ReadKey();
        }
    }
}
