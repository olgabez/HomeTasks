using System;

namespace InheritanceTask
{
    class Employee
    {
        private readonly string name;
        private decimal salary;
        private decimal bonus;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (salary > 0)
                salary = value;
            }
        }
        public Employee(string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public virtual void SetBonus(decimal bonus)
        {
            this.bonus = bonus;
        }
        public decimal ToPay()
        {
            decimal sum = salary + bonus;
            return sum;
        }
    }
}

