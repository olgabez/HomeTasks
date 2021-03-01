package com.epam.test.automation.java.practice3;

public class Main {

    /**
     * <summary>
     * Implement code according to description of task 1.
     * </summary>
     */
    public static int[] task1(int[] array) {
       int start = 0;
        int length = array.length;
        for (int i = 0; i < length / 2; i++)
        {
            if ((array[i] % 2 == 0) && (array[length - i - 1] % 2 == 0))
            {
                start = array[length - i - 1];
                array[length - i - 1] = array[i];
                array[i] = start;
            }
        }
        return task1(array);
    }

    /**
     * <summary>
     * Implement code according to description of task 2.
     * </summary>
     */
    public static int task2(int[] array) {
        int first = 0;
        int last = 0;
        for (int i = 0; i < array.length; i++)
        {
            if (array[i] > array[first])
                first = i;
            if (array[i] >= array[last])
                last = i;
        }
        return last - first;
    }

    /**
     * <summary>
     * Implement code according to description of task 3.
     * </summary>
     */
    public static int[][] task3(int[][] matrix) {
        for (int i = 0; i < matrix.length; i++)
        {
            for (int j = 1; j <  matrix.length; j++)
            {
                if (i < j)
                {
                    matrix[i][ j] = 1;
                }
            }
        }
        for (int i = 0; i <  matrix.length; i++)
        {
            for (int j = 0; j <  matrix.length; j++)
            {
                if (i > j)
                {
                    matrix[i][j] = 0;
                }
            }
        }
        return matrix;

    }
}
