using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace tyuiu.denisovld.sprint0.task4.v0.lib
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
        { return a / b; }
    }
}
