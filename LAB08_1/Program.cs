using LAB08_1;

Worker w1 = new Worker(1, "Ivan", DateTime.Now, DateTime.Now, 20);
Department department = new Department("IT Department");
Programmer p1 = new Programmer(2, "Anna", DateTime.Now, DateTime.Now, "MIDDLE");
Manager m1 = new Manager(3, "Ritchy", DateTime.Now, DateTime.Now, 12, true);

department.AddEmployee(w1);
department.AddEmployee(p1);
department.AddEmployee(m1);

department.PrintEmployees();
department.RemoveEmployee(p1.ID);
department.PrintEmployees();
Console.WriteLine($"После удаления, всего: {department.CountEmployees()}");