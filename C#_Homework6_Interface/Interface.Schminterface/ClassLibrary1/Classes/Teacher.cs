
using ClassLibrary1.Base;
using ClassLibrary1.Interfaces;

namespace ClassLibrary1.Classes
{
    public class Teacher : User, ITeacher
    {
        List<string> Subjects = new List<string>();
        public void PrintSubjects()
        {
            foreach (string subject in Subjects)
            {
                Console.WriteLine(subject);
            }
        }

        public override void PrintUser()
        {
            Console.WriteLine($"There are currently {Subjects.Count} subjects :)))");
        }

        public Teacher(int id, string name, string username, List<string> subjects)
        {
            Id = id;
            Name = name;
            Username = username;
            Subjects = subjects;
        }
    }
}
