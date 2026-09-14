using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tyuiu.denisovld.sprint0.task7.v0.lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] num1, int[] num2)
        {
            int[] resultArray = new int[5];
            for (var i = 0;  i < num1.Length; i++)
            {
                resultArray[i] = num1[i] + num2[i];
            }
            return resultArray;
        }
    }
}
