using System;

namespace LoopTasks
{
    public static class LoopTasks
    {
        /// <summary>
        /// Task 1
        /// </summary>
        public static int SumOfOddDigits(int n)
        {
            int oddDigit;
            int oddDigitSum = 0;
            while (n > 0)
            {
                oddDigit = n % 10;
                if (oddDigit % 2 != 0)
                {
                    oddDigitSum = oddDigitSum + oddDigit;
                }
                n = n / 10;
            }
            return oddDigitSum;
        }

        /// <summary>
        /// Task 2
        /// </summary>
        public static int NumberOfUnitsInBinaryRecord(int n)
        {
            int binaryUnit;
            int sumOfUnits = 0;
            while (n > 0)
            {
                binaryUnit = n % 2;
                sumOfUnits = sumOfUnits + binaryUnit;
                n = n / 2;
            }
            return sumOfUnits;
        }

        /// <summary>
        /// Task 3 
        /// </summary>
        public static int SumOfFirstNFibonacciNumbers(int n)
        {
            int Fn;
            int F0 = 0;
            int F1 = 1;
            int result = 0;
            for (int i = 2; i <= n; i++)
            {
                result = result + F1;
                Fn = F0 + F1;
                F0 = F1;
                F1 = Fn;
            }
            return result;
        }
    }
}
