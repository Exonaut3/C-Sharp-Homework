

namespace Inheritance.Classes
{
    internal class Cat : Animal
    {
        public string Lazyness { get; set; }

        public Cat() : base("Cat")
        {
            Console.WriteLine("Cat constructor is used");
        }
        public Cat(string name, string type, string lazyness) : base(name, type)
        {
            Lazyness = lazyness;
        }
        public override void Eat()
        {
            Console.WriteLine($"You don't tell the cat {Name} when to eat");
        }

        public void Meow()
        {
            Console.WriteLine("MEOW MEOW AAAAAAAAAAAAAAAAAAAAAAAAAAAAA IT'S 4 AM");
        }
    }
}
