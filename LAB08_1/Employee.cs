using System;

namespace LAB08_1
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }

        public Employee(int id, string name, DateTime birthDate, DateTime hireDate)
        {
            ID = id;
            Name = name;
            BirthDate = birthDate;
            HireDate = hireDate;
        }

        public abstract decimal SalaryBonus();
        public decimal TotalSalary() => 1000m + SalaryBonus(); // Базовая ставка 1000

        public override string ToString() => $"ID: {ID}, Имя: {Name}, Зарплата: {TotalSalary()}";
    }
}