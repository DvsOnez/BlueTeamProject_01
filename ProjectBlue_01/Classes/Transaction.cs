using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Classes
{
    public enum PaymentMethod { Cash, CreditCard }

    [Serializable]
    public class Transaction
    {
        public TransactionLine TransactionLine { get; set; }
        private const double DISCOUNT_LIMIT = 10;
        private const double DISCOUNT_RATE = 0.15;
        public const string TRANS_STORAGE = "transStorage.json";

        public Guid ID { get; }
        public Guid CustomerID { get; }
        public Guid EmployeeID { get; }
        public double TotalPrice { get; set; }

        //public List<TransactionLine> TransactionLines { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
        public double TransCost { get; set; }
        public DateTime Date { get; }
        CoffeeShop CoffeeShop { get; set; }


        //public  
        public Transaction()
        {
            ID = Guid.NewGuid(); 
            //CustomerID = CoffeeShop.Customer.ID;
            //EmployeeID = CoffeeShop.Employees.First().ID;
            Date = DateTime.Now;
        }

        //private double _totalPrice;
        //private double _discount;
        //public void DoTransaction()
        //{
            
        //    foreach (TransactionLine item in CoffeeShop.TransactionLines)
        //    {
        //        _totalPrice = item.Price* item.Quantity;
        //        _discount = item.Price * DISCOUNT_RATE;
        //    }
        //    if (_totalPrice > DISCOUNT_LIMIT)
        //    {
        //        TransactionLine.Discount = _discount;
        //        TransactionLine.TotalPrice =_totalPrice - _discount;
        //    }
        //    else
        //    {
        //        _discount = 0;
        //        TransactionLine.TotalPrice = _totalPrice;
        //        TransactionLine.Discount = _discount;
        //    }
        //}



        //public void AddTransactionLine(Transaction trans, TransactionLine transLine)
        //{
        //    trans.Lines.Add(transLine);
        //}
        //public void AddTransactionLine(TransactionLine transLine)
        //{ //ver2
        //    Lines.Add(transLine);
        //}

        //public double GetTotalPrice(List<TransactionLine> lines)
        //{
        //    double totalPrice = 0;
        //    for (int i = 0; i < lines.Count; i++)
        //    {
        //        totalPrice += lines[i].TotalPrice;
        //    }
        //    return totalPrice;
        //}
        //public void GetTotalCost(List<TransactionLine> lines)
        //{
        //    for (int i = 0; i < lines.Count; i++)
        //    {
        //        TransCost += lines[i].LineCost;
        //    }
        //}

        //public double ApplyDisc(List<TransactionLine> lines) {
        //    double price = GetTotalPrice(lines);
        //    if(price > discLimit) {
        //        return (price - (price * discRate));
        //        //TODO: Dicount per line
        //        //TransactionLine.ApplyDisc();
        //    }
        //    else {
        //        return price;
        //    }
        //}

        //private Transaction _transaction;
        //public void SaveTransaction(Transaction transaction)
        //{
        //    if (File.Exists("transStorage.json"))
        //    {
        //        //Load
        //    }

        //    string json = JsonSerializer.Serialize(transaction);
        //    File.WriteAllText(TRANS_STORAGE, json);
        //}

        //public void LoadTransaction()
        //{
        //    string s = File.ReadAllText(TRANS_STORAGE);
        //    _transaction = (Transaction)JsonSerializer.Deserialize(s, typeof(Transaction));
        //}

        //public bool CardAvailable(double price)
        //{
        //    if (price > 50)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}
    }
}
