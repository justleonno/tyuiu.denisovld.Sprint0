using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.denisovld.sprint0.task6.v0.lib;
namespace tyuiu.denisovld.sprint0.task6.v0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("The sum of the number array is " + DataService.AdditionArray(numsArray));
            Console.WriteLine("The difference of the number array is " + DataService.SubtractionArray(numsArray));
            Console.WriteLine("The product of the number array is " + DataService.MultiplicationArray(numsArray));
            Console.ReadKey(); 
        }
    }
}
