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
            int rangeThreeDigitNumbersBegin = 100;
            int rangeThreeDigitNumbersEnd = 999;
            int countDivisible = 0;
            int number = random.Next(rangeNumberBegin , rangeNumberEnd +1);
            int potentialDivisible;

            for (int i = rangeThreeDigitNumbersBegin; i <= rangeThreeDigitNumbersEnd; i++)
            {
                potentialDivisible = i;

                while (potentialDivisible>0)
                {
                    potentialDivisible-=number;
                }

                if (potentialDivisible==0)
                {
                    countDivisible++;
                }
            }

            Console.WriteLine("У числа " + number + " количество кратных чисел равно " + countDivisible);
        }
    }
}