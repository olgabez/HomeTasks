package com.epam.test.automation.java.practice6;
import java.math.BigDecimal;
/**
 * <summary>
 * Implement code according to description of task.
 * </summary>
 */
public class Employee {

    private String name;
    private BigDecimal bonus;
    private BigDecimal salary;

    public Employee(String name, BigDecimal salary){
        this.name = name;
        this.salary = salary;
    }
    public String getName() {
        return name;
    }

    public BigDecimal getSalary() {
        return salary;
    }

    public void setSalary(BigDecimal salary) {
        this.salary = salary;
    }

    public void setBonus(BigDecimal bonus) {
        this.bonus = bonus;
    }
    public BigDecimal getBonus() {
        
        return bonus;
    }

   public BigDecimal toPay(){
        return salary.add(bonus);
    }
}
