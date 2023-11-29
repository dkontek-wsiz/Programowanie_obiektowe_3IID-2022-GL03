using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Bank
{
    public class Account
    {
        public static double TotalIncome { get; set; }
        public static double TotalExpenses { get; set; }

        public void ProcessTransaction(Transaction transaction)
        {
            transaction.ProcessTransaction();
        }

        public void DisplaySummary()
        {
            Console.WriteLine($"Total Income {TotalIncome}");
            Console.WriteLine($"Total Expenses {TotalExpenses}");
            Console.WriteLine($"Total {TotalIncome - TotalExpenses}");
        }
    }
}
