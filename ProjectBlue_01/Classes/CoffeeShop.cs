using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Classes
{
    public class CoffeeShop
    {
        public Customer SingleCustomer { get; set; }
        public List<Employee> Employees { get; set; }
        public readonly string EmployeesFileName = "employees.json";
        public readonly string CustomerFileName = "customer.json";
        public CoffeeShop()
        {
            Employees = new List<Employee>();
        }

        
        public void SaveEmployees()
        {
            string jsonStr = JsonSerializer.Serialize(Employees);
            File.WriteAllText(EmployeesFileName, jsonStr);
        }

        public bool LoadEmployees()
        {//returns true if successful load
            bool fileExists = File.Exists(EmployeesFileName);
            if (fileExists)
            {
                string jsonStr = File.ReadAllText(EmployeesFileName);
                Employees = JsonSerializer.Deserialize<List<Employee>>(jsonStr);
            }
            return fileExists;
        }

        public void SaveCustomer()
        {
            string jsonStr = JsonSerializer.Serialize(SingleCustomer);
            File.WriteAllText(CustomerFileName, jsonStr);
        }

        public bool LoadCustomer()
        {//returns true if successful load
            bool fileExists = File.Exists(CustomerFileName);
            if (fileExists)
            {
                string jsonStr = File.ReadAllText(CustomerFileName);
                SingleCustomer = JsonSerializer.Deserialize<Customer>(jsonStr);
            }
            return fileExists;
        }
        



    }
}
