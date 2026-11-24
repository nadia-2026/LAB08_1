using System;

namespace LAB08_1
{
    public class Manager : Employee
    {
        public int TeamSize { get; set; }
        public bool HasBonus { get; set; }

        public Manager(int id, string name, DateTime birthDate, DateTime hireDate, int teamSize, bool hasBonus)
            : base(id, name, birthDate, hireDate)
        {
            TeamSize = teamSize;
            HasBonus = hasBonus;
        }

        public override decimal SalaryBonus() => HasBonus ? 800m : 400m;
        public override string ToString() => $"Менеджер: {Name}, Команда: {TeamSize}, Зарплата: {TotalSalary()}";
    }
}