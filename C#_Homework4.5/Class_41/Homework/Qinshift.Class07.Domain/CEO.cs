

namespace Qinshift.Class07.Domain
{
    public class CEO : Employee
    {
        public Employee[] Employees;
        public int Shares;
        private double SharesPrice;

        public void AddSharesPrice(double number)
        {
            SharesPrice = number;
        }
        public void PrintEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"Firstname: {employee.FirstName}, Lastname: {employee.LastName}");
            }
        }
        public override double GetSalary()
        {
            return Salary + Shares * SharesPrice;
        }
    }
}
