using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Encapsulation
{
    public class SalaryAccount
    {
        private double acc_bal;

        private int _ssn;
        public int SSN
        {
            get
            {
                return _ssn;
            }
            set
            {
                _ssn = value;
            }
        }

        public double DepositeSalary(int Salary)
        {
            acc_bal = 100000;
            return (acc_bal + Salary);
        }
    }
}
