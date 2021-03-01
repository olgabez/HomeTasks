package com.epam.test.automation.java.practice2;

public class Main {

    /**
     * <summary>
     * Implement code according to description of task 1.
     * </summary>
     */
    public static int task1(int n) {
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

    /**
     * <summary>
     * Implement code according to description of task 2.
     * </summary>
     */
    public static int task2(int n) {
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

    /**
     * <summary>
     * Implement code according to description of task 3.
     * </summary>
     */
    public static int task3(int n) {
        int fib;
        int fibNumber0 = 0;
        int fibNumber1 = 1;
        int result = 0;
        for (int i = 2; i <= n; i++)
        {
            result = result + fibNumber1;
            fib = fibNumber0 + fibNumber1;
            fibNumber0 = fibNumber1;
            fibNumber1 = fib;
        }
        return result;
    }
}
