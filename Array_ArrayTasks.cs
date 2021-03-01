using System;

namespace ArrayObject
{
    public static class ArrayTasks
    {
        /// <summary>
        /// Task 1
        /// </summary>
       public static void ChangeElementsInArray(int[] nums)
        {
            int start = 0;
            int length = nums.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if ((nums[i] % 2 == 0) && (nums[length - i - 1] % 2 == 0))
                {
                    start = nums[length - i - 1];
                    nums[length - i - 1] = nums[i];
                    nums[i] = start;
                }
            }
            
        }

        /// <summary>
        /// Task 2
        /// </summary>
        public static int DistanceBetweenFirstAndLastOccurrenceOfMaxValue(int[] nums)
        {
            int first = 0;
            int last = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > nums[first])
                    first = i;
                if (nums[i] >= nums[last])
                    last = i;
            }
            return last - first;
        }

        /// <summary>
        /// Task 3 
        /// </summary>
        public static void ChangeMatrixDiagonally(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    if (i < j)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (i > j)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
        }
    }
}
