using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Monthly_Ledger
    {
        public int Year { get; set; }
        public int Month { get; }
        public double Income { get; }
        public double Expences { get; }
        public double Total { get; }
        public List<Transaction> Transactions { get; }

        public Monthly_Ledger()
        {

        }

        public string GetReport(int month, double income, double expenses, int year)
        {
            return "Month: " + month + "\nIncome: " + income + "\nExpenses: " + expenses + "\nTotal: ";
        }
        public string GetMonth(DateTime date) {
            return date.Month.ToString();
        }
    }
}
