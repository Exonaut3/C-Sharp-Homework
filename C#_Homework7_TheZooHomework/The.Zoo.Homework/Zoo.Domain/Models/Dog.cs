using Zoo.Domain.Models.BaseModel;

namespace Zoo.Domain.Models
{
    public class Dog : Pet
    {
        public Dog(string name, string type, int age, bool goodboy, string favoriteFood) : base(name, type, age)
        {
            GoodBoy = goodboy;
            FavoriteFood = favoriteFood;
        }

        public bool GoodBoy { get; set; }
        public string FavoriteFood { get; set; }

        public override void PrintInfo()
        {
            if(GoodBoy)
            {
                Console.WriteLine($"This is {Name} the dog. They are a {Type}. They are {Age} years old, their favorite food is {FavoriteFood} and are most definitely a good boy.");

            }
            else
            {
                Console.WriteLine($"This is {Name} the dog. They are a {Type}. They are {Age} years old, their favorite food is {FavoriteFood} and are not a good boy because they are a good girl.");
            }
        }
    }
}
