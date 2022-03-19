using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Classes
{
    [Serializable]
    public class Transaction
    {
        private const string TRANS_STORAGE = "transStorage.json";

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
            Lines = new List<TransactionLine>();

        }

        public void GetTotalPrice(List<TransactionLine> lines) //return double?
        {
            for (int i = 0; i < lines.Count; i++)
            {
                TotalPrice += lines[i].TotalPrice;
            }
        }

        public void SaveTransaction() {
            if(File.Exists("transStorage.json")) {
                //Load
            }

            //string json = JsonSerializer.Serialize();
        }
    }
}
