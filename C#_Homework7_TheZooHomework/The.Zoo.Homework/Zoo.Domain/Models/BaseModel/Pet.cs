namespace Zoo.Domain.Models.BaseModel
{
    public abstract class Pet
    {
        public Pet(string name, string type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }

        public abstract void PrintInfo();
    }
}
