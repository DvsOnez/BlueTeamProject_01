namespace Classes
{
    public class Employee
    {
        public Guid ID { get; }
        public string Name { get; set; }
        public string Surname { get; set; } 
        public double SalaryPerMonth { get; set; }
        public enum EmplyeeType { Manager, Cashier, Barista, Waiter}

        public Employee() {

        }
    }
}