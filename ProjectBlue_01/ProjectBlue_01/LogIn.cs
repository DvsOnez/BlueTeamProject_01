using CoffeeShopForms;
using Classes;

namespace ProjectBlue_01
{
    public partial class LogIn : Form
    {
        private Order order;
        private Administrator administrator;
        public LogIn()
        {
            InitializeComponent();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            administrator = new Administrator();
            administrator.ShowDialog();

        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            order = new Order();
            order.ShowDialog();
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            /*Transaction tr = new Transaction();

            Product product = new Product();
            product.ID = Guid.NewGuid();
            product.Price = 20;
            product.Description = "eh";
            product.Cost = 10;
            product.Code = "12";

            Product product2 = new Product();
            product2.ID = Guid.NewGuid();
            product2.Price = 1;
            product2.Description = "meh";
            product2.Cost = 0.1;
            product2.Code = "12";

            TransactionLine transactionLine = new TransactionLine();
            transactionLine.GetPrice(2, product);
            transactionLine.GetTotalPrice(transactionLine.Price);
            //double d = transactionLine.GetPrice(2, product);
            tr.AddTransactionLine(tr, transactionLine);
            //tr.AddTransLine(transactionLine);

            TransactionLine transactionLine2 = new TransactionLine();
            transactionLine2.GetPrice(2, product2);
            transactionLine2.GetTotalPrice(2, product2);
            tr.AddTransactionLine(tr, transactionLine2);
            //tr.AddTransLine(transactionLine2);

            //List<TransactionLine> list = new List<TransactionLine>();
            //list.Add(transactionLine);
            //list.Add(transactionLine2);

            //tr.GetTotalPrice(list);
            tr.GetTotalPrice();

            tr.SaveTransaction(tr);*/
        }
    }
}