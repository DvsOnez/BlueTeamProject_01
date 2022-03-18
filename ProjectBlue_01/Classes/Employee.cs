namespace Classes
{
    [Serializable]
    public class Employee
    {
        private const string EMPLOYEE_STORAGE = "employeeStorage.json";
        public Guid ID { get;  } 
        //public string ID { get; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Surname { get; set; } 
        public double SalaryPerMonth { get; set; }
        public enum EmplyeeType { Manager, Cashier, Barista, Waiter}

        public Employee() {

        }
    }
}