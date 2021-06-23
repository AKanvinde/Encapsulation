using System;

namespace OOP_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            double bal;
            SalaryAccount obj = new SalaryAccount();
            bal = obj.DepositeSalary(2000);
            obj.SSN = 1234;
            Console.WriteLine("Account Balance is " +bal);
            Console.ReadLine();
        }
    }
}
