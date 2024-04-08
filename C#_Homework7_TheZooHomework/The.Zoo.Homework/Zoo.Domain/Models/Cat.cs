using Zoo.Domain.Models.BaseModel;

namespace Zoo.Domain.Models
{
    public class Cat : Pet
    {
   

        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public Cat(string name, string type, int age, bool lazy, int livesLeft) : base(name, type, age)
        {
            Lazy = lazy;
            LivesLeft = livesLeft;
        }
        public override void PrintInfo()
        {
            if (Lazy)
            {
                Console.WriteLine($"This is {Name} the {Type} cat. They are {Age} years old, are very lazy and have {LivesLeft} lives left.");

            }
            else
            {
            Console.WriteLine($"This is {Name} the {Type} cat. They are {Age} years old, are surprisingly not lazy (what a phenomenon) and have {LivesLeft} lives left.");
            }
        }


    }
}
