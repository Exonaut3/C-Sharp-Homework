using ClassLibrary1.Interfaces;

namespace ClassLibrary1.Base
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }

        public virtual void PrintUser()
        {
            Console.WriteLine($"[ID: {Id}, Name: {Name}, Username: {Username}]");
        }
    }
}
