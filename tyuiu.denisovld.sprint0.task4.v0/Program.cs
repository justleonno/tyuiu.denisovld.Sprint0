using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using tyuiu.denisovld.sprint0.task4.v0.lib;
namespace tyuiu.denisovld.sprint0.task4.v0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(8, 13));
            Console.WriteLine(DataService.Subtraction(13, 4));
            Console.WriteLine(DataService.Multiplication(5, 6));
            Console.WriteLine(DataService.Division(20, 4));
            Console.WriteLine("lol");
            Console.ReadKey();
        }
    }
}
