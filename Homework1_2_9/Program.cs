using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int rangeNumberBegin = 1;
            int rangeNumberEnd = 27;
            int rangeNumbersBegin = 0;
            int rangeNumbersEnd = 999;
            int countDivisible = 0;
            int startCheck = 100;
            int number = random.Next(rangeNumberBegin , rangeNumberEnd +1);

            for (int i = rangeNumbersBegin; i <= rangeNumbersEnd; i+=number)
            {
                if (i>=startCheck)
                {
                    countDivisible++;
                }
            }

            Console.WriteLine("У числа " + number + " количество кратных чисел равно " + countDivisible);
        }
    }
}