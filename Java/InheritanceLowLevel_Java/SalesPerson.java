package com.epam.test.automation.java.practice6;
import java.math.BigDecimal;
/**
 * <summary>
 * Implement code according to description of task.
 * </summary>
 */
public class SalesPerson extends Employee {

    private int percent;
    public SalesPerson(String name, BigDecimal salary, int percent) {
        super(name, salary);
        this.percent = percent;
    }
    
    @Override
    public void setBonus(BigDecimal bonus) {
        BigDecimal three =  new BigDecimal("3");
        BigDecimal two =  new BigDecimal("2");
        
        if (percent > 200){
            super.setBonus(bonus.multiply(three));
        } else if ( percent > 100 && percent <=200){
            super.setBonus(bonus.multiply(two));
        } else {
            super.setBonus(bonus);
        }
    
    }
}