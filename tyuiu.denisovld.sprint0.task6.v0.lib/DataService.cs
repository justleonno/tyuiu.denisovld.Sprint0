using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tyuiu.denisovld.sprint0.task6.v0.lib
{
    public class DataService
    {
        public static object AdditionArray(int[] numbers)
        {
            var total = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            return total;
        }
        public static object SubtractionArray(int[] numbers)
        {
            var total = 0;
            var index = 0;
            while (index < numbers.Length)
            {
                total = total - numbers[index];
                index++;
            }
            return total;
        }
        public static object MultiplicationArray(int[] numbers)
        {
            var index = 0;
            var total = 1;
            do
            {
                total = total * numbers[index];
                index++;
            }
            while (index < numbers.Length);

            return total;
        }
    }
}
