using System;
using System.Collections.Generic;
using System.Linq;

namespace Class
{
    class Rectangle
    {
        private double sideA;
        private double sideB;

        public Rectangle(double a, double b)
        {
            this.sideA = a;
            this.sideB = b;
        }

        public Rectangle(double a)
        {
            this.sideA = a;
            sideB = 5;
        }

        public Rectangle()
        {
            sideA = 4;
            sideB = 3;
        }

        public double GetSideA()
        {
            return sideA;
        }
        public double GetSideB()
        {
            return sideB;
        }

        public double Area()
        {
            double area = sideA * sideB;
            return area;
        }

        public double Perimeter()
        {
            double perimeter = (sideA + sideB) * 2;
            return perimeter;
        }

        public bool IsSquare()
        {
            if (sideA == sideB)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ReplaceSides()
        {
            double sideA2 = sideA;
            sideA = sideB;
            sideB = sideA2;
            
        }
        public class ArrayRectangles
        {
            private Rectangle[] rectangle_array;

            public ArrayRectangles(int n)
            {
                rectangle_array = new Rectangle[n];
            }

            public ArrayRectangles(params Rectangle[] array)
            {
                rectangle_array = array;
            }

            public bool AddRectangle(Rectangle rectangle)
            {
                for (int i = 0; i < rectangle_array.Length; i++)
                {
                    if (rectangle_array[i] == null)
                    {
                        rectangle_array[i] = rectangle;
                        return true;
                    }
                }
                return false;

            }
            public int NumberMaxArea()
            {
                double max_area = rectangle_array[0].Area();
                int number = 0;
                for (int i = 0; i < rectangle_array.Length; i++)
                {
                    if (rectangle_array[i] != null && max_area < rectangle_array[i].Area())
                    {
                        max_area = rectangle_array[i].Area();
                        number = i;
                    }
                }
                return number;
            }
            public int NumberMinPerimeter()
            {
                int number = 0;
                double min_perimeter = rectangle_array[0].Perimeter();
                for (int i = 1; i < rectangle_array.Length; i++)
                {
                    if (rectangle_array[i] != null && min_perimeter > rectangle_array[i].Perimeter())
                    {
                        min_perimeter = rectangle_array[i].Perimeter();
                        number = 1;
                    }
                }
                return number;
            }
            
        }
    }
}
