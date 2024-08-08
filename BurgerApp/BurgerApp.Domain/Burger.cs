namespace BurgerApp.Domain
{
    public class Burger : BaseEntity
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan {  get; set; }
        public bool HasFries { get; set; }
        public int Ammount { get; set; }

        public Burger(int id,string name, double price, bool isVegetarian, bool isVegan, bool hasFries )
        {
            Id = id;
            Name = name;
            Price = price;
            IsVegetarian = isVegetarian;
            IsVegan = isVegan;
            HasFries = hasFries;
        }
    }
}
