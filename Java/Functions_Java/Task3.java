package com.epam.test.automation.java.practice4;

public class Task3 {

    /**
     * <summary>
     * Implement code according to description of task.
     * </summary>
     * if set invalid arguments in method, then method must throws
     * IllegalArgumentException
     */
    public static int multiArithmeticElements(int a1, int t, int n) {
        int result = 1;
            for (int i = 0; i < n; i++)
            {
                result = result * a1;
                a1 = a1 + t;
            }
            return result;

    }
}
