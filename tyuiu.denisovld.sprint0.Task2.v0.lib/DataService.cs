using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tyuiu.denisovld.sprint0.Task2.v0.lib
{
    public class DataService
    {
        public static string GetMessage(string name)
        {
            return $"Привет, {name}";
        }
    }
}
