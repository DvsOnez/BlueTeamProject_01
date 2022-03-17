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

        public Monthly_Ledger()
        {

        }

        public string GetReport(int month, int year)
        {
            return "";
        }
    }
}
