using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
    class Manager : Employee
    {
        private readonly int quantity;
        public Manager(string name, decimal salary, int clientAmount) : base(name, salary)
        {
            this.quantity = clientAmount;
        }
        public override void SetBonus(decimal bonus)
        {
            if (quantity > 100)
            {
                bonus += 500;
            }
            if (quantity > 150)
            {
                _ = bonus + 1000;
            }            
        }
    }
}

