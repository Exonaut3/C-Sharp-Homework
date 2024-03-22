using Qinshift.Class07.Domain;
using Qinshift.Class07.Domain.Enums;



Employee employee = new Employee()
{
    FirstName = "Zlatko",
    LastName = "Zlatev",
    Role = Role.Other,

};

employee.PrintInfo();
employee.GetSalary();

Manager manager = new Manager("Elon", "Musk", 1000);
manager.PrintInfo();
manager.AddBonus(300);
manager.PrintInfo();
Console.WriteLine(manager.GetSalary());




