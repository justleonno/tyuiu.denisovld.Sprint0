using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
using System.Threading.Tasks;

using tyuiu.denisovld.sprint0.Task2.v0.lib;


namespace tyuiu.denisovld.sprint0.task2.v0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("John"));
            Console.ReadKey();
        }
    }
}
