package com.epam.test.automation.java.practice4;

public class Task4 {

    /**
     * <summary>
     * Implement code according to description of task.
     * </summary>
     * if set invalid arguments in method, then method must throws
     * IllegalArgumentException
     */
    public static double sumGeometricElements(int a1, double t, int alim) {
        double sum = 0;
            while (a1 > alim)
            {
                sum = sum + a1;
                a1 = a1 * (int)t;
            }
            return sum;

    }
}
