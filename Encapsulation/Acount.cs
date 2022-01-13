using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Encapsulation
{
    class Acount
    {
        private double balance = 2000;
        public void AddAmount(double amount)
        {
            if (amount > 0)
            {
                balance = balance + amount;
                Console.WriteLine("Total balance is: " + balance);
            }
            else
            {
                Console.WriteLine("Enter positive number");
            }
        }
    }
}