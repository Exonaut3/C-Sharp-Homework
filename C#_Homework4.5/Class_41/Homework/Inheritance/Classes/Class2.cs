
namespace Inheritance.Classes
{
    internal class Dog: Animal
    {
        public string Race { get; set; }

        public Dog()
        {
            Console.WriteLine("A new instance of an Dog has been created. Dog Constructor");
        }
        public Dog(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public void Bark()
        {
            Console.WriteLine("Bark Bark, WOOF, WOOF, AWOOGA");
        }
    }
}
