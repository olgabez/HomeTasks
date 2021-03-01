package com.epam.test.automation.java.practice6;
import java.math.BigDecimal;
/**
 * <summary>
 * Implement code according to description of task.
 * </summary>
 */
public class Manager extends Employee{
    private int quantity ;

    public Manager(String name, BigDecimal salary, int clientAmount) {
        super(name, salary);
        this.quantity  = clientAmount;
    }
    @Override
    public void setBonus(BigDecimal bonus){
        BigDecimal thousand = new BigDecimal("1000");
        BigDecimal fiveHundred = new BigDecimal("500");
        
        if (quantity > 150){
            super.setBonus(bonus.add(thousand));
        } else if (quantity > 100 && quantity <=150){
            super.setBonus(bonus.add(fiveHundred));
        } else {
            super.setBonus(bonus);
        }
        
    }
}