package com.epam.test.automation.java.practice5;

public class Rectangle {
    private double sideA;
    private double sideB;

    public Rectangle(double a, double b) {
        this.sideA = a;
        this.sideB = b;
    }

    public Rectangle(double a) {
        this.sideA = a;
        sideB = 5;

    }

    public Rectangle() {
        sideA = 4;
        sideB = 3;
    }

    /**
     * <summary>
     * Implement code according to description of task.
     * </summary>
     */
    public double getSideA() {
        return sideA;
    }

    /**
     * <summary>
     * Implement code according to description of task.
     * </summary>
     */
    public double getSideB() {
        return sideB;
    }

    /**
     * <summary>
     * Implement code according to description of task.
     * </summary>
     */
    public double area() {
         return sideA * sideB;
    }

    /**
     * <summary>
     * Implement code according to description of task.
     * </summary>
     */
    public double perimeter() {
        return (sideA + sideB) * 2;
    }

    /**
     * <summary>
     * Implement code according to description of task.
     * </summary>
     */
    public boolean isSquare() {
        if (sideA == sideB){
            return true;
        }
        else {
            return false;
        }
    }

    /**
     * <summary>
     * Implement code according to description of task.
     * </summary>
     */
    public void replaceSides() {
        double sideA2 = sideA;
            sideA = sideB;
            sideB = sideA2;
    }

}
