using System;

namespace Condition
{
    public static class Condition
    {
        /// <summary>
        /// Implement code according to description of  task 1
        /// </summary>        
        public static int Task1(int n)
        {
            if (n > 0)
            {
                return n * n;
            }
            else
            {
                if (n < 0)
                {
                    int second = Math.Abs(n);
                    return second;
                }
                else
                {
                    if (n == 0)
                    {
                        return 0;
                    }
                }
            }
            return Task1(n);
        }

        /// <summary>
        /// Implement code according to description of  task 2
        /// </summary>  
        public static int Task2(int n)
        {
            if (n >= 100 && n <= 999)
            {
                int k, e, c;
                k = n % 10;
                c = n / 10 % 10;
                e = n / 10 / 10 % 10;

                int o = Math.Max((k * 100 + c * 10 + e), (k * 100 + e * 10 + c));
                int m = Math.Max((e * 100 + k * 10 + c), (c * 100 + k * 10 + e));
                int h = Math.Max(o, m);
                int r = Math.Max((c * 100 + e * 10 + k), h);
                return r;
            }
            return Task2(n);
        }
    }
}
