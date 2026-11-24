using System;

namespace LAB08_1
{
    public class Programmer : Employee
    {
        public string Level { get; set; }

        public Programmer(int id, string name, DateTime birthDate, DateTime hireDate, string level)
            : base(id, name, birthDate, hireDate)
        {
            Level = level;
        }

        public override decimal SalaryBonus() => Level == "SENIOR" ? 500m : 250m;
        public override string ToString() => $"Программист: {Name}, Уровень: {Level}, Зарплата: {TotalSalary()}";
    }
}