package com.epam.test.automation.java.practice1;

public class Main {

    /**
     * <summary>
     * Implement code according to description of task 1.
     * </summary>
     */
    public static int task1(int n) {
        int x = 0;
        if (n > 0){
            x = n *n;
        }
        else {
            x = Math.abs(n);
        }
        return x;
    }

    /**
     * <summary>
     * Implement code according to description of task 2.
     * </summary>
     */
    public static int task2(int n) {
        if (n >= 100 && n <= 999){
            int k;
            int e;
            int c;
            k = n % 10;
            c = n / 10 % 10;
            e = n / 10 / 10 % 10;

            int o = Math.max((k * 100 + c * 10 + e), (k * 100 + e * 10 + c));
            int m = Math.max((e * 100 + k * 10 + c), (c * 100 + k * 10 + e));
            int h = Math.max(o, m);
            int r = Math.max((c * 100 + e * 10 + k), h);
            return r;
        }
        return n;
    }

}
