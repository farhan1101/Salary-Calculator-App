using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class SalaryCalculator
    {
        public double salary { get; private set; }

        public double GetSalary(double amount, double houseRent, double medAllowance)
        {
            return salary = amount + ((amount*houseRent)/100) + ((amount*medAllowance)/100);
        }
    }
}
