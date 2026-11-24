using System.Collections.Generic;

namespace LAB08_1
{
    public class Department
    {
        public string Name { get; set; }
        private List<Employee> employees;

        public Department(string name)
        {
            Name = name;
            employees = new List<Employee>();
        }

        public bool AddEmployee(Employee employee)
        {
            if (employee == null) return false;
            foreach (Employee emp in employees) if (emp.ID == employee.ID) return false;
            employees.Add(employee);
            return true;
        }

        public bool RemoveEmployee(int id)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].ID == id) { employees.RemoveAt(i); return true; }
            }
            return false;
        }

        public int CountEmployees() => employees.Count;
        public int CountWorkers() { int c = 0; foreach (Employee e in employees) if (e is Worker) c++; return c; }
        public int CountProgrammers() { int c = 0; foreach (Employee e in employees) if (e is Programmer) c++; return c; }
        public int CountManagers() { int c = 0; foreach (Employee e in employees) if (e is Manager) c++; return c; }

        public decimal CalculateTotalSalary()
        {
            decimal total = 0;
            foreach (Employee emp in employees) total += emp.TotalSalary();
            return total;
        }
        public decimal CalculateAverageSalary()
        {
            if (employees.Count == 0) return 0;
            return CalculateTotalSalary() / employees.Count;
        }
        public Employee FindEmployee(int id)
        {
            foreach (Employee emp in employees) if (emp.ID == id) return emp;
            return null;
        }
        public Employee FindHighestPaidEmployee()
        {
            if (employees.Count == 0) return null;
            Employee highest = employees[0];
            foreach (Employee emp in employees) if (emp.TotalSalary() > highest.TotalSalary()) highest = emp;
            return highest;
        }

        public Employee FindLowestPaidEmployee()
        {
            if (employees.Count == 0) return null;
            Employee lowest = employees[0];
            foreach (Employee emp in employees) if (emp.TotalSalary() < lowest.TotalSalary()) lowest = emp;
            return lowest;
        }

        public decimal CalculateAverageSalaryByType(string type)
        {
            decimal total = 0;
            int count = 0;
            foreach (Employee emp in employees)
            {
                if (emp.GetType().Name == type) { total += emp.TotalSalary(); count++; }
            }
            return count == 0 ? 0 : total / count;
        }
        public void PrintEmployees()
        {
            Console.WriteLine($"Подразделение: {Name}");
            Console.WriteLine("----------------------------");
            foreach (Employee emp in employees) Console.WriteLine(emp);
            Console.WriteLine("----------------------------");
        }
    }

}