using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class Amount
    {
        public string name;
        public double salaryAmount;
        public double houseRent;
        public double medicalAllowance;

        public double salary()
        {
            double totalSalary;
            double houserentAmount = 0;
            double medicalAmount = 0;
            houserentAmount = (salaryAmount*houseRent)/100;
            medicalAmount = (salaryAmount*medicalAllowance)/100;
            totalSalary = houserentAmount + medicalAmount + salaryAmount;
            return totalSalary;
        }
    }
}
