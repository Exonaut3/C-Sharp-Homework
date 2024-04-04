
using ClassLibrary1.Base;
using ClassLibrary1.Interfaces;

namespace ClassLibrary1.Classes
{
    public class Student : User, IStudent
    {
        Dictionary<string, int> Grades = new Dictionary<string, int>();

        public void PrintGrades()
        {
            foreach(var item in Grades)
            {
                Console.WriteLine($"Subject: {item.Key}; Grade: {item.Value}");
            }
        }

        public override void PrintUser()
        {
            Console.WriteLine($"[ID: {Id}, Name: {Name}, Username: {Username}]");
            
            List<double> gradeList = new List<double>();
            double gradeAverage = 0;
            foreach(var item in Grades)
            {
                gradeList.Add(item.Value);
            }
            foreach(int grade in gradeList)
            {
                gradeAverage += grade;
            }
            Console.WriteLine($"Grade Average: {gradeAverage / gradeList.Count}");
        }

        public Student(int id, string name, string username, Dictionary<string, int> grades)
        {
            Id = id;
            Name = name;
            Username = username;
            Grades = grades;
        }
    }
}
