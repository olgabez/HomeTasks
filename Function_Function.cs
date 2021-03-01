using System;

namespace Function
{
    public enum SortOrder { Ascending, Descending }
    public static class Function
    {        
        public static bool IsSorted (int[] array, SortOrder order)
        {
            switch (order)
            {
                case SortOrder.Ascending:
                    for (int i = 1; i < array.Length; i++)
                    {
                        if (array[i] < array[i-1])
                            return false;
                    }
                    break;
                case SortOrder.Descending:
                    for (int i = 1; i < array.Length; i++)
                    {
                        if (array[i] > array[i -1])
                            return false;
                    }
                    break;
            }
            return true;
        }
        
        public static void Transform (int[] array, SortOrder order)
        {
            if (IsSorted(array, order))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = array[i] + i;
                }
            }
        }

        public static double MultArithmeticElements(double a, double t, double n)
        {
            double result = 1.0;
            for (int i = 0; i < n; i++)
            {
                result = result * a;
                a = a + t;
            }
            return result;
        }

        public static double SumGeometricElements(double a, double t, double alim)
        {
            double sum = 0;
            while (a > alim)
            {
                sum = sum + a;
                a = a * t;
            }
            return sum;
        }        
    }
}
