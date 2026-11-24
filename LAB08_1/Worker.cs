using System;

namespace LAB08_1
{
    public class Worker : Employee
    {
        public int Grade { get; set; }

        // Вот конструктор с 5 аргументами
        public Worker(int id, string name, DateTime birthDate, DateTime hireDate, int grade)
            : base(id, name, birthDate, hireDate)
        {
            Grade = grade;
        }

        public override decimal SalaryBonus() => Grade * 100;
        public override string ToString() => $"Рабочий: {Name}, Разряд: {Grade}, Зарплата: {TotalSalary()}";
    }
}