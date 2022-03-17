using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Transaction
    {
        public Guid ID { get; }
        public Guid CustomerID { get; }
        public Guid EmployeeID { get; }
        public DateTime Date { get; }
        public double TotalPrice { get; set; }

        List<TransactionLine> Lines { get; set; }
        public enum PaymentMethod { Cash, CreditCard }
        //public  
        public Transaction()
        {
            ID = Guid.NewGuid();

        }

        public void GetTotalPrice(List<TransactionLine> lines) //return doouble?
        {
            for (int i = 0; i < lines.Count; i++)
            {
                TotalPrice += lines[i].TotalPrice;
            }
        }
    }
}
