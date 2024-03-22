

namespace Qinshift.Class07.Domain
{
    public class Contractor : Employee 
    {
        public double WorkHours;
        public int PayPerHour;
        public Manager Responsible;



        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return WorkHours * PayPerHour;
        }
        public void CurrentPosition()
        {
            Console.WriteLine($"The manager of the contracot {FirstName} {LastName} is {Responsible.FirstName} {Responsible.LastName}");
        }
        // idk what you guys mean by department so I just made it return who the contractors manager is 
    }
}
