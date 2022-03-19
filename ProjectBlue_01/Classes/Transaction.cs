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

        public List<TransactionLine> Lines { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
        public enum PaymentMethod { Cash, CreditCard }
        //public  
        public Transaction()
        {
            ID = Guid.NewGuid();
            Lines = new List<TransactionLine>();
        }



        public void AddTransactionLine(Transaction trans, TransactionLine transLine) {
            trans.Lines.Add(transLine);
        }

        public double GetTotalPrice(List<TransactionLine> lines) //return double?
        {
            double totalPrice = 0;
            for (int i = 0; i < lines.Count; i++)
            {
                TotalPrice += lines[i].TotalPrice;
            }
            return TotalPrice;
        }

        private Transaction _transaction;
        public void SaveTransaction(Transaction transaction) {
            if(File.Exists("transStorage.json")) {
                //Load
            }

            string json = JsonSerializer.Serialize(transaction);
            File.WriteAllText(TRANS_STORAGE, json);
        }

        private void LoadTransaction() {
            string s = File.ReadAllText(TRANS_STORAGE);
            _transaction = (Transaction)JsonSerializer.Deserialize(s, typeof(Transaction));  
        }
    }
}
