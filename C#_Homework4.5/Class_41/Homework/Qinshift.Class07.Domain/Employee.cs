
using Qinshift.Class07.Domain.Enums;

namespace Qinshift.Class07.Domain
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Employee name: {FirstName}, Employee Lastname {LastName}, Employee Salary: {Salary}");
        }
        public virtual double GetSalary()
        {
            return Salary;
        }

    }
}
