using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.denisovld.sprint0.task3.v0.lib;
namespace tyuiu.denisovld.sprint0.task3.v0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Sum(7, 9));
            Console.ReadKey();
        }
    }
}
