using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tyuiu.denisovld.sprint0.task5.v0.lib
{
    public class DataService
    {
        public static int Addition(int a, int b)
        { return a + b; }

        public static int Subtraction(int a, int b)
        { return a - b; }

        public static int Multiplication(int a, int b)
        { return a * b; }

        public static double Division(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Переменная b == {0}. На 0 делить нельзя.", b);
                return -1;
            }
            else
            {
                return a / b;
            }
        }
    }
}
