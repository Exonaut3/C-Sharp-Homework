using Inheritance.Classes;
#region Inheritance 

Animal animal = new Animal()
{
    Id = 5,
    Name = "Dambo",
    Type = "Elephant"
};


animal.Eat();
animal.PrintInfo();

Console.WriteLine("================================");

Dog spark = new Dog()
{
    Id = 1,
    Name = "Spark",
    Type = "Dog",
    Race = "Labrador"
};

spark.Eat();
spark.PrintInfo();


Dog bak = new Dog("Bak", "Dog");

Cat garfiled = new Cat()
{
    Id = 55,
    Name = "Garfield",
    Lazyness = "Very",
    Type = "Cat"
};
garfiled.Eat();
Cat tom = new Cat("Tom", "Cat", "Not so Lazy");
tom.Meow();

#endregion