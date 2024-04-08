using Zoo.Domain.Models.BaseModel;

namespace Zoo.Domain.Models
{
    public class Fish : Pet
    {
        public Fish(string name, string type, int age, string size, string color) : base(name, type, age)
        {
            Size = size;
            Color = color;
        }

        public string Size { get; set; }
        public string Color { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"This is {Name} the fish. They are a {Type}. They are {Age} years old, their size is {Size} and their color is {Color}.");
            //Feels like I'm making a language book for kids
        }
    }
}
