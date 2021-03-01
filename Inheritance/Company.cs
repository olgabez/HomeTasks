using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
    class Company
    {
        private readonly Employee[] employees;

        public Company(int n)
        {
            employees = new Employee[n];
        }
    }
}
